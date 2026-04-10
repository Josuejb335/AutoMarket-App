using System.Configuration;
using System.Data.SqlClient;
using System;

namespace AccesoDatos
{
    public class ConexionBD
    {
        // Cadena de conexión a la base de datos, obtenida del archivo de configuración
         private readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["CnxAutoMarket"].ConnectionString;

        // Método que expone la conexión hacia la base de datos
        protected SqlConnection ObtenerConexion()
        {
            try
            {
                return new SqlConnection(cadenaConexion);
            }
            catch(Exception e)
            {
                return null;
            }
        }
    }
}
 