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

namespace ComunicacionServidor
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

        public event Action<string> NuevaBitacora;
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
                NuevaBitacora?.Invoke($"Servidor iniciado en {IP_SERVIDOR}:{PUERTO}, Max Clientes: {MAX_CLIENTES}");
                // iniciar hilo de escucha
                hiloEscucha = new Thread(EscucharConexiones);
                hiloEscucha.IsBackground = true;
                hiloEscucha.Start();
            }
            catch (Exception ex) 
            {
                NuevaBitacora?.Invoke($"Error al iniciar el servidor: {ex.Message}");
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
                        NuevaBitacora?.Invoke($"Cliente Rechazado {cliente.Client.RemoteEndPoint}: límite de clientes alcanzado.");
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
                NuevaBitacora?.Invoke($"Error en Escucha de Conexiones: {ex.Message}");
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
                            NuevaBitacora?.Invoke($"Cliente Conectado: {nombreCliente} ({cliente.Client.RemoteEndPoint})");
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
                        NuevaBitacora?.Invoke($"Mensaje recibido de {nombreCliente}");
                        Mensaje mensaje = JsonConvert.DeserializeObject<Mensaje>(mensajeJson);
                        if (mensaje != null)
                        {
                            Mensaje respuesta = ProcesarMensaje(mensaje);
                            string respuestaJson = JsonConvert.SerializeObject(respuesta);
                            writer.WriteLine(respuestaJson);
                            writer.Flush();
                            NuevaBitacora?.Invoke($"Respuesta enviada a {respuesta.Accion}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                NuevaBitacora?.Invoke($"Error al atender cliente: {ex.Message}");
            }
            finally
            {
                //limpiar recursos y actualizar estado
                if (infoCliente != null)
                {
                    clientesConectados.Remove(infoCliente);
                }
                cliente.Close();
                NuevaBitacora?.Invoke($"Cliente: {nombreCliente} desconectado. Total: {clientesConectados.Count}/{MAX_CLIENTES}");
                ClienteDesconectado?.Invoke(nombreCliente);
            }
        }

        public void ProcesarMensaje(Mensaje mensaje)
        {

        }
    }
}
