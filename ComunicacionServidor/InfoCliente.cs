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
