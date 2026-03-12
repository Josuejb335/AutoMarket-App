using System.Configuration;

namespace AccesoDatos
{
    public class ConexionBD
    {
        // Cadena de conexión a la base de datos, obtenida del archivo de configuración
        string cadenaConexion = ConfigurationManager.ConnectionStrings["CnxAutoMarket"].ConnectionString;

    }
}
