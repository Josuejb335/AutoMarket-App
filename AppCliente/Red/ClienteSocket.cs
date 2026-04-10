/*
•	UNED I Cuatrimestre 2026
•	Proyecto 2, Gestion De AutoMarket.
•	Estudiante: Josue Jimenez Barrantes
•	Fecha Finalizacion:  11 Abril de 2026
•	Clase que gestiona la conexión TCP del cliente con el servidor remoto
*/

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

        private const string IP = "127.0.0.1";
        private const int PUERTO = 15500;

        public bool Conectar(string identificacion)
        {
            try
            {
                // Crear una conexión TCP con el servidor remoto usando la IP y puerto configurados
                cliente = new TcpClient(IP, PUERTO);
                // Obtener el stream (flujo de datos) para poder enviar y recibir información
                NetworkStream stream = cliente.GetStream();
                
                // Crear lectores y escritores para simplificar el manejo de strings JSON
                reader = new StreamReader(stream, Encoding.UTF8, true, 1024, true);
                writer = new StreamWriter(stream, Encoding.UTF8, 1024, true);

                // Crear un mensaje de conexión con la acción "CONECTAR" e incluir la identificación del cliente
                Mensaje msj = new Mensaje { Accion = "CONECTAR", Datos = identificacion };
                // Serializar el mensaje a JSON
                string json = JsonConvert.SerializeObject(msj);
                
                // Enviar el mensaje al servidor y flushar para asegurar que se envíe inmediatamente
                writer.WriteLine(json);
                writer.Flush();

                // Esperar la respuesta del servidor (debe ser una confirmación de aceptación)
                string respuestaJson = reader.ReadLine();
                Mensaje respuesta = JsonConvert.DeserializeObject<Mensaje>(respuestaJson);

                // Validar si el servidor aceptó la conexión (acción "OK")
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

        public Mensaje EnviarPeticion(Mensaje peticion)
        {
            try
            {
                // Validar que exista una conexión activa con el servidor
                if (cliente == null || !cliente.Connected)
                    throw new Exception("No hay conexión activa con el servidor.");

                // Serializar la petición a JSON
                string jsonPeticion = JsonConvert.SerializeObject(peticion);
                // Enviar la petición al servidor
                writer.WriteLine(jsonPeticion);
                writer.Flush();

                // Leer la respuesta del servidor (llegará en formato JSON)
                string jsonRespuesta = reader.ReadLine();
                
                // Validar que se haya recibido una respuesta válida
                if (string.IsNullOrEmpty(jsonRespuesta))
                    throw new Exception("El servidor no devolvió ninguna respuesta.");

                // Deserializar la respuesta JSON a un objeto Mensaje para poder acceder a sus propiedades
                Mensaje respuesta = JsonConvert.DeserializeObject<Mensaje>(jsonRespuesta);
                return respuesta;
            }
            catch (Exception ex)
            {
                // En caso de error, devolver un mensaje de error para que la aplicación pueda manejarlo
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
