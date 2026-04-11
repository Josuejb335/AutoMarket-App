/*
•	UNED I Cuatrimestre 2026
•	Proyecto 2, Gestion De AutoMarket.
•	Estudiante: Josue Jimenez Barrantes
•	Fecha Finalizacion:  11 Abril de 2026
•	Clase encargada de gestionar las conexiones TCP de clientes, aceptar peticiones y procesar mensajes
*/

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
                // Crear el servidor TCP que escuchará en la IP y puerto especificados
                servidor = new TcpListener(IPAddress.Parse(IP_SERVIDOR), PUERTO);
                // Iniciar el servidor para que comience a aceptar conexiones
                servidor.Start();
                
                servidorActivo = true;
                Logger.Escribir($"Servidor iniciado en {IP_SERVIDOR}:{PUERTO}, Max Clientes: {MAX_CLIENTES}", 2);
                
                // Crear un hilo independiente para escuchar continuamente nuevas conexiones de clientes
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

                // Detener el TcpListener para que no acepte más conexiones entrantes
                if (servidor != null)
                {
                    servidor.Stop();
                }

                // Recorrer todos los clientes conectados y cerrar sus conexiones de forma ordenada
                if (clientesConectados != null)
                {
                    // Usar ToList() para crear una copia y evitar errores al modificar la colección durante la iteración
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

        public void EscucharConexiones()
        {
            try
            {
                // Loop infinito que acepta nuevas conexiones de clientes mientras el servidor esté activo
                while (servidorActivo)
                {
                    // Esperar a que un cliente intente conectarse (operación bloqueante)
                    TcpClient cliente = servidor.AcceptTcpClient();

                    // Validar si se ha alcanzado el límite máximo de clientes permitidos simultáneamente
                    if (clientesConectados.Count >= MAX_CLIENTES)
                    {
                        Logger.Escribir($"Cliente Rechazado {cliente.Client.RemoteEndPoint}: límite de clientes alcanzado.", 3);
                        cliente.Close();
                        continue;
                    }

                    // Crear un nuevo hilo para cada cliente, permitiendo atender múltiples clientes concurrentemente
                    // Cada hilo llama a AtenderCliente() para mantener la comunicación con su cliente
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
                // Obtener el stream (flujo de datos) del cliente para poder leer y escribir datos
                stream = cliente.GetStream();

                // Usar StreamReader y StreamWriter para simplificar la lectura y escritura de datos JSON
                // El encoding UTF8 asegura compatibilidad con caracteres especiales
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8, true, 1024, true))
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8, 1024, true))
                {
                    // Leer el primer mensaje del cliente (debe ser el mensaje de conexión con su identificación)
                    string mensajeBienvenidaJson = reader.ReadLine();

                    if (!string.IsNullOrEmpty(mensajeBienvenidaJson))
                    {
                        // Deserializar el JSON para obtener un objeto Mensaje que sea más fácil de manipular
                        Mensaje mensajeBienvenida = JsonConvert.DeserializeObject<Mensaje>(mensajeBienvenidaJson);

                        // Verificar que sea un mensaje de acción "CONECTAR" del cliente
                        if (mensajeBienvenida != null && mensajeBienvenida.Accion == "CONECTAR")
                        {
                            // Extraer la identificación del cliente del mensaje recibido
                            nombreCliente = mensajeBienvenida.Datos;

                            // Crear un registro del cliente conectado en la lista para poder mantener su sesión
                            infoCliente = new InfoCliente(cliente, nombreCliente);   
                            clientesConectados.Add(infoCliente);

                            // Notificar en los logs que un nuevo cliente se ha conectado
                            Logger.Escribir($"Cliente Conectado: {nombreCliente} ({cliente.Client.RemoteEndPoint})", 2);
                            ClienteConectado?.Invoke(nombreCliente);

                            // Enviar un mensaje de confirmación al cliente indicando que fue aceptado
                            Mensaje respuestaBienvenida = new Mensaje("OK", "Conexion", "Bienvenido");
                            string respuestaJson = JsonConvert.SerializeObject(respuestaBienvenida);
                            writer.WriteLine(respuestaJson);
                            writer.Flush();
                        }
                    }

                    // Ciclo continuo para recibir y procesar peticiones del cliente mientras esté conectado
                    while (cliente.Connected && servidorActivo)
                    {
                        // Leer una línea de JSON enviada por el cliente (una petición)
                        string mensajeJson = reader.ReadLine();
                        
                        // Si no hay datos, significa que el cliente se desconectó
                        if (string.IsNullOrEmpty(mensajeJson))
                        {
                            break;
                        }
                        
                        Logger.Escribir($"Mensaje recibido de {nombreCliente}", 2);
                        
                        // Deserializar el JSON para convertirlo en un objeto Mensaje
                        Mensaje mensaje = JsonConvert.DeserializeObject<Mensaje>(mensajeJson);
                        
                        if (mensaje != null)
                        {
                            // Procesar la petición del cliente y obtener la respuesta correspondiente
                            Mensaje respuesta = ProcesarMensaje(mensaje, nombreCliente);
                            
                            // Serializar la respuesta a JSON y enviarla al cliente
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
                // Limpiar recursos: remover el cliente de la lista de conectados y cerrar su conexión
                if (infoCliente != null)
                {
                    clientesConectados.Remove(infoCliente);
                }
                cliente.Close();
                Logger.Escribir($"Cliente: {nombreCliente} desconectado. Total: {clientesConectados.Count}/{MAX_CLIENTES}", 3);
                
                // Notificar que un cliente se ha desconectado (para actualizar la interfaz si es necesario)
                ClienteDesconectado?.Invoke(nombreCliente);
            }
        }

        public Mensaje ProcesarMensaje(Mensaje mensaje, string nombreCliente)
        {
            Mensaje respuesta = new Mensaje();
            respuesta.Accion = mensaje.Accion;

            try
            {
                // Procesar la petición del cliente según el tipo de acción solicitada
                switch (mensaje.Accion)
                {
                    case "VERIFICAR_ID":
                        Logica.GestorConsultas gestor = new Logica.GestorConsultas();
                        string idCliente = mensaje.Datos;
                        
                        // Paso 1: Verificar si la identificación existe en el sistema
                        bool existe = gestor.ExisteClientePorIDCadena(idCliente);
                        // Paso 2: Verificar si el perfil del cliente se encuentra activo para operar
                        bool activo = gestor.EsClienteActivo(idCliente);
                        
                        // Devolver la validación final basada en existencia y estado del cliente
                        if (existe && activo) 
                        {
                            respuesta.Datos = "SI"; 
                            respuesta.Tipo = "OK";
                        }
                        else if (existe && !activo)
                        {
                            respuesta.Datos = "El cliente existe pero cuenta con estado Inactivo.";
                            respuesta.Tipo = "ERROR";
                        }
                        else 
                        {
                            respuesta.Datos = "NO";
                            respuesta.Tipo = "ERROR";
                        }
                        break;

                    case "COMPRAR_VEHICULO":
                        // Procesar una compra de vehículo por parte del cliente
                        Logica.GestorRegistros gestorReg = new Logica.GestorRegistros();
                        Logica.GestorConsultas gestorCons = new Logica.GestorConsultas();
                        
                        // Extraer los datos de la compra del JSON recibido
                        dynamic datosCompra = JsonConvert.DeserializeObject(mensaje.Datos);
                        int sucId = datosCompra.IdSucursal;
                        int vehId = datosCompra.IdVehiculo;
                        decimal monto = datosCompra.Monto;

                        // Obtener el ID interno del cliente a partir de su identificación (que usó para conectarse)
                        int clienteId = gestorCons.ObtenerIdCliente(nombreCliente);
                        if (clienteId <= 0)
                        {
                             respuesta.Datos = "Cliente no registrado o sesión inválida.";
                             respuesta.Tipo = "ERROR";
                             break;
                        }

                        // Procesar la transacción: insertar la venta y reducir el inventario
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
                        // Obtener la lista de todas las sucursales activas
                        Logica.GestorConsultas gestorSuc = new Logica.GestorConsultas();
                        var listaSucursales = gestorSuc.ObtenerTodasSucursales();
                        // Serializar la lista a JSON para enviarla al cliente
                        respuesta.Datos = JsonConvert.SerializeObject(listaSucursales);
                        respuesta.Tipo = "OK";
                        break;
                        
                    case "CONSULTAR_VEHICULOS_SUCURSAL":
                        // Obtener los vehículos disponibles en una sucursal específica
                        Logica.GestorConsultas gestorVeh = new Logica.GestorConsultas();
                        int idSucursal = int.Parse(mensaje.Datos);
                        var vehiculosSucursal = gestorVeh.ObtenerVehiculosPorSucursal(idSucursal);
                        // Serializar la lista de vehículos a JSON
                        respuesta.Datos = JsonConvert.SerializeObject(vehiculosSucursal);
                        respuesta.Tipo = "OK";
                        break;

                    case "CONSULTAR_MIS_COMPRAS":
                        // Obtener el historial de compras del cliente que hace la petición
                        Logica.GestorConsultas gestorCompras = new Logica.GestorConsultas();
                        // Usar el nombre del cliente como identificación para buscar sus compras
                        int idClie = gestorCompras.ObtenerIdCliente(nombreCliente);
                        if (idClie > 0)
                        {
                            var misCompras = gestorCompras.ObtenerVentasPorCliente(idClie);
                            // Serializar el historial de compras a JSON
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
                        // Si la acción no es reconocida, devolver un error
                        respuesta.Tipo = "ERROR";
                        respuesta.Datos = "Acción no reconocida por el servidor.";
                        break;
                }
            }
            catch (Exception ex)
            {
                // Capturar cualquier error que ocurra durante el procesamiento y devolverlo al cliente
                respuesta.Tipo = "ERROR";
                respuesta.Datos = ex.Message;
            }

            return respuesta;
        }


    }
}
