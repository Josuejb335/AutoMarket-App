/*
•	UNED I Cuatrimestre 2026
•	Proyecto 2, Gestion De AutoMarket.
•	Estudiante: Josue Jimenez Barrantes
•	Fecha Finalizacion:  11 Abril de 2026
•	Clase base que proporciona la conexión a la base de datos SQL Server
*/

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
 