using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Data.SqlClient;
using Utilidades;
using System.Drawing;
using System.IO;
using Newtonsoft.Json;

namespace Comunicacion
{
    public class ServidorSocket
    {
        // constantes servidor
        private const string IP_SERVIDOR = "127.0.0.1";
        private const int PUERTO = 15500;
        private const int MAX_CLIENTES = 10;

        private TcpListener servidor;

        private Thread hiloEscucha;

        private bool servidorActivo = false;

        private List<InfoCliente> clientesConectados;

        public event Action<string> ClienteConectado;
        public event Action<string> ClienteDesconectado;

        public ServidorSocket()
        {
            clientesConectados = new List<InfoCliente>();
        }

        public void Iniciar()
        {
            try
            {
                servidor = new TcpListener(IPAddress.Parse(IP_SERVIDOR), PUERTO);
                servidor.Start();
                // actualizar estado
                servidorActivo = true;
                Logger.Escribir($"Servidor iniciado en {IP_SERVIDOR}:{PUERTO}, Max Clientes: {MAX_CLIENTES}", 2);
                // iniciar hilo de escucha
                hiloEscucha = new Thread(EscucharConexiones);
                hiloEscucha.IsBackground = true;
                hiloEscucha.Start();
            }
            catch (Exception ex) 
            {
                Logger.Escribir($"Error al iniciar el servidor: {ex.Message}", 3);
            }
        }

        public void Detener()
        {
            try
            {
                if (!servidorActivo) return;

                servidorActivo = false;

                // detener el Listener para que no acepte nuevas conexiones
                if (servidor != null)
                {
                    servidor.Stop();
                }

                // desconectar a todos los clientes que estén actualmente conectados
                if (clientesConectados != null)
                {
                    // ToList() para crear una copia temporal y evitar errores por modificar la colección original
                    foreach (var cliente in clientesConectados.ToList())
                    {
                        if (cliente.Conexion != null && cliente.Conexion.Connected)
                        {
                            cliente.Conexion.Close();
                        }
                    }
                    clientesConectados.Clear();
                }

                Logger.Escribir("El servidor se ha detenido correctamente y todos los clientes fueron desconectados.", 3);
            }
            catch (Exception ex)
            {
                Logger.Escribir($"Error al detener el servidor: {ex.Message}", 3);
            }
        }

        //metodo que se ejecuta en el hilo de escucha, acepta conexiones entrantes y crea un hilo para cada cliente
        public void EscucharConexiones()
        {
            try
            {
                while (servidorActivo)
                {
                    TcpClient cliente = servidor.AcceptTcpClient();

                    //si se alcanzó el límite de clientes, rechazar la conexión
                    if (clientesConectados.Count >= MAX_CLIENTES)
                    {
                        Logger.Escribir($"Cliente Rechazado {cliente.Client.RemoteEndPoint}: límite de clientes alcanzado.", 3);
                        cliente.Close();
                        continue;
                    }

                    // hilo para cada cliente
                    Thread hiloCliente = new Thread(() => AtenderCliente(cliente));
                    hiloCliente.IsBackground = true;
                    hiloCliente.Start();
                }
            }
            catch(Exception ex)
            {
                Logger.Escribir($"Error en Escucha de Conexiones: {ex.Message}", 3);
            }
        }

        public void AtenderCliente(TcpClient cliente)
        {
            NetworkStream stream = null;
            string nombreCliente = "Desconocido";
            InfoCliente infoCliente = null;

            try
            {
                //Obtener stream del cliente
                stream = cliente.GetStream();

                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8, true, 1024, true))
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8, 1024, true))
                {
                    //recibir nombre cliente
                    string mensajeBienvenidaJson = reader.ReadLine();

                    if (!string.IsNullOrEmpty(mensajeBienvenidaJson))
                    {
                        //deserializar mensaje de bienvenida
                        Mensaje mensajeBienvenida = JsonConvert.DeserializeObject<Mensaje>(mensajeBienvenidaJson);

                        if (mensajeBienvenida != null && mensajeBienvenida.Accion == "CONECTAR")
                        {
                            nombreCliente = mensajeBienvenida.Datos;

                            //crear info cliente y agregar a lista
                            infoCliente = new InfoCliente(cliente, nombreCliente);   
                            clientesConectados.Add(infoCliente);

                            //notificar conexión
                            Logger.Escribir($"Cliente Conectado: {nombreCliente} ({cliente.Client.RemoteEndPoint})", 2);
                            ClienteConectado?.Invoke(nombreCliente);

                            //enviar confirmacion a cliente
                            Mensaje respuestaBienvenida = new Mensaje("OK", "Conexion", "Bienvenido");
                            string respuestaJson = JsonConvert.SerializeObject(respuestaBienvenida);
                            writer.WriteLine(respuestaJson);
                            writer.Flush();
                        }
                    }

                    //ciclo de peticiones
                    while (cliente.Connected && servidorActivo)
                    {
                        string mensajeJson = reader.ReadLine();
                        if (string.IsNullOrEmpty(mensajeJson))
                        {
                            break; // cliente desconectado
                        }
                        Logger.Escribir($"Mensaje recibido de {nombreCliente}", 2);
                        Mensaje mensaje = JsonConvert.DeserializeObject<Mensaje>(mensajeJson);
                        if (mensaje != null)
                        {
                            Mensaje respuesta = ProcesarMensaje(mensaje, nombreCliente);
                            string respuestaJson = JsonConvert.SerializeObject(respuesta);
                            writer.WriteLine(respuestaJson);
                            writer.Flush();
                            Logger.Escribir($"Respuesta enviada a {respuesta.Accion}", 2);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Escribir($"Error al atender cliente: {ex.Message}", 3);
            }
            finally
            {
                //limpiar recursos y actualizar estado
                if (infoCliente != null)
                {
                    clientesConectados.Remove(infoCliente);
                }
                cliente.Close();
                Logger.Escribir($"Cliente: {nombreCliente} desconectado. Total: {clientesConectados.Count}/{MAX_CLIENTES}", 3);
                ClienteDesconectado?.Invoke(nombreCliente);
            }
        }

        public Mensaje ProcesarMensaje(Mensaje mensaje, string nombreCliente)
        {
            Mensaje respuesta = new Mensaje();
            respuesta.Accion = mensaje.Accion; // Devolvemos la misma accion para que el cliente sepa a qué le estamos respondiendo

            try
            {
                // Switch que decide qué hacer según la acción del cliente
                switch (mensaje.Accion)
                {
                    case "VERIFICAR_ID":
                        // instanciar el gestor de logica
                        Logica.GestorConsultas gestor = new Logica.GestorConsultas();
                        string idCliente = mensaje.Datos;
                        bool existe = gestor.ExisteClientePorIDCadena(idCliente); // Debes implementar esto en GestorConsultas
                        
                        if (existe) 
                        {
                            respuesta.Datos = "SI"; 
                            respuesta.Tipo = "OK";
                        }
                        else 
                        {
                            respuesta.Datos = "NO";
                            respuesta.Tipo = "ERROR";
                        }
                        break;

                    case "COMPRAR_VEHICULO":
                        Logica.GestorRegistros gestorReg = new Logica.GestorRegistros();
                        Logica.GestorConsultas gestorCons = new Logica.GestorConsultas();
                        
                        // Parsear los datos enviados por el cliente
                        dynamic datosCompra = JsonConvert.DeserializeObject(mensaje.Datos);
                        int sucId = datosCompra.IdSucursal;
                        int vehId = datosCompra.IdVehiculo;
                        decimal monto = datosCompra.Monto;

                        // Obtener el ID interno del cliente a partir de su identificacion con la que inició sesion
                        int clienteId = gestorCons.ObtenerIdCliente(nombreCliente);

                        if (clienteId <= 0)
                        {
                             respuesta.Datos = "Cliente no registrado o sesión inválida.";
                             respuesta.Tipo = "ERROR";
                             break;
                        }

                        // Procesar la transacción completa (Insertar venta y deducir inventario)
                        bool compraExitosa = gestorReg.ProcesarCompraTCP(sucId, vehId, clienteId, monto);
                        
                        if (compraExitosa)
                        {
                            respuesta.Datos = "Compra Exitosa";
                            respuesta.Tipo = "OK";
                        }
                        else
                        {
                            respuesta.Datos = "No se pudo procesar la compra (Verifique inventario).";
                            respuesta.Tipo = "ERROR";
                        }
                        break;

                    case "CONSULTAR_SUCURSALES":
                        Logica.GestorConsultas gestorSuc = new Logica.GestorConsultas();
                        var listaSucursales = gestorSuc.ObtenerTodasSucursales();
                        respuesta.Datos = JsonConvert.SerializeObject(listaSucursales);
                        respuesta.Tipo = "OK";
                        break;
                        
                    case "CONSULTAR_VEHICULOS_SUCURSAL":
                        Logica.GestorConsultas gestorVeh = new Logica.GestorConsultas();
                        int idSucursal = int.Parse(mensaje.Datos);
                        var vehiculosSucursal = gestorVeh.ObtenerVehiculosPorSucursal(idSucursal);
                        respuesta.Datos = JsonConvert.SerializeObject(vehiculosSucursal);
                        respuesta.Tipo = "OK";
                        break;

                    case "CONSULTAR_MIS_COMPRAS":
                        Logica.GestorConsultas gestorCompras = new Logica.GestorConsultas();
                        int idClie = gestorCompras.ObtenerIdCliente(nombreCliente); // nombreCliente es la identificacion
                        if (idClie > 0)
                        {
                            var misCompras = gestorCompras.ObtenerVentasPorCliente(idClie);
                            respuesta.Datos = JsonConvert.SerializeObject(misCompras);
                            respuesta.Tipo = "OK";
                        }
                        else
                        {
                            respuesta.Datos = "Cliente no autenticado o no encontrado.";
                            respuesta.Tipo = "ERROR";
                        }
                        break;

                    default:
                        respuesta.Tipo = "ERROR";
                        respuesta.Datos = "Acción no reconocida por el servidor.";
                        break;
                }
            }
            catch (Exception ex)
            {
                respuesta.Tipo = "ERROR";
                respuesta.Datos = ex.Message;
            }

            return respuesta;
        }


    }
}
