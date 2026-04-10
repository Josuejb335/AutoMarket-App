/*
•	UNED I Cuatrimestre 2026
•	Proyecto 2, Gestion De AutoMarket.
•	Estudiante: Josue Jimenez Barrantes
•	Fecha Finalizacion:  11 Abril de 2026
•	Clase que encapsula la información de un cliente conectado al servidor (conexión y nombre)
*/

using System.Net.Sockets;

namespace Comunicacion
{
    public class InfoCliente
    {
        public TcpClient Conexion { get; set; }
        public string Nombre { get; set; }
        
        public InfoCliente(TcpClient conexion, string nombre)
        {
            Conexion = conexion;
            Nombre = nombre;
        }
    }
}
