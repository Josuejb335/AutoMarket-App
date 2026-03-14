using System;
using System.Data.SqlClient;

namespace AccesoDatos.ConsultasDashBoard
{
    public class ConsultasDashBoard : ConexionBD
    {
        public decimal ObtenerMontoVentas()
        {
            string sql = @"SELECT SUM(Monto) FROM Venta";

            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql,cnx);
                cnx.Open();

                //ExecuteScalar devuelve la primera columna de la primera fila
                object resultado = cmd.ExecuteScalar();
                resultado = (int)resultado;
                return resultado != DBNull.Value ? Convert.ToDecimal(resultado) : 0;
            }
        }
    }
}
