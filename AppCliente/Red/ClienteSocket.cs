using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;
using Utilidades;
using Comunicacion;

namespace AppCliente.Red
{
    public class ClienteSocket
    {
        private TcpClient cliente;
        private StreamReader reader;
        private StreamWriter writer;

        // tiene que coincidir con el puerto que el servidor está escuchando
        private const string IP = "127.0.0.1";
        private const int PUERTO = 15500;

        public bool Conectar(string identificacion)
        {
            try
            {
                cliente = new TcpClient(IP, PUERTO);
                NetworkStream stream = cliente.GetStream();
                
                reader = new StreamReader(stream, Encoding.UTF8, true, 1024, true);
                writer = new StreamWriter(stream, Encoding.UTF8, 1024, true);

                // Mandar mensaje inicial para registrarse en el Servidor
                Mensaje msj = new Mensaje { Accion = "CONECTAR", Datos = identificacion };
                string json = JsonConvert.SerializeObject(msj);
                
                writer.WriteLine(json);
                writer.Flush();

                // Esperar a que el servidor confirme que nos aceptó ("OK")
                string respuestaJson = reader.ReadLine();
                Mensaje respuesta = JsonConvert.DeserializeObject<Mensaje>(respuestaJson);

                if(respuesta != null && respuesta.Accion == "OK")
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                Logger.Escribir("Error al conectar con el servidor: " + ex.Message, 3);
                return false;
            }
        }

        // Método para enviarle preguntas al servidor y recibir su respuesta
        public Mensaje EnviarPeticion(Mensaje peticion)
        {
            try
            {
                if (cliente == null || !cliente.Connected)
                    throw new Exception("No hay conexión activa con el servidor.");

                // Serializar y enviar
                string jsonPeticion = JsonConvert.SerializeObject(peticion);
                writer.WriteLine(jsonPeticion);
                writer.Flush();

                // quedarse esperando la respuesta
                string jsonRespuesta = reader.ReadLine();
                
                if (string.IsNullOrEmpty(jsonRespuesta))
                    throw new Exception("El servidor no devolvió ninguna respuesta.");

                // deserializar la respuesta
                Mensaje respuesta = JsonConvert.DeserializeObject<Mensaje>(jsonRespuesta);
                return respuesta;
            }
            catch (Exception ex)
            {
                // En caso de fallo, se devuelve mensaje de error falso para que el programa no colapse
                return new Mensaje("ERROR", "ERROR", ex.Message);
            }
        }

        public void Desconectar()
        {
            try
            {
                if (cliente != null && cliente.Connected)
                {
                    cliente.Close();
                }
            }
            catch { }
        }
    }
}
