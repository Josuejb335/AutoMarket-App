using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AccesoDatos.ConsultasDashBoard
{
    //metodo que debuelve un diccionario con el nombre del mes y el total de ventas de ese mes, ordenado por mes
    public class ConsultasDashBoard : ConexionBD
    {
        public Dictionary<string, decimal> ObtenerVentasMensuales()
        {
            var datos = new Dictionary<string, decimal>();
            string sql = @"SELECT FORMAT(FechaVenta, 'MMMM', 'es-ES') 
                            AS Mes, SUM(Monto)
                            AS Total 
                            FROM Venta 
                            GROUP BY FORMAT(FechaVenta, 'MMMM', 'es-ES'), MONTH(FechaVenta) 
                            ORDER BY MONTH(FechaVenta)";

            using (var cnx = ObtenerConexion())
            {
                using (var cmd = new SqlCommand(sql, cnx))
                {
                    cnx.Open();
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            datos.Add(dr["Mes"].ToString(), Convert.ToDecimal(dr["Total"]));
                        }
                    }
                }
               
            }
            return datos;
        }

        //metodo que devuelve numero de sucursales vehiculos y categorias
        public Dictionary<string, int> ObtenerConteosGenerales()
        {
            Dictionary<string, int> conteos = new Dictionary<string, int>();
            string sql = @"SELECT COUNT(*) FROM Vehiculo;
                           SELECT COUNT(*) FROM Sucursal;
                           SELECT COUNT(*) FROM CategoriaVehiculo;";

            using (var cnx = ObtenerConexion())
            {
                using (var cmd = new SqlCommand(sql, cnx))
                {
                    cnx.Open();
                    using (var dr = cmd.ExecuteReader())
                    {
                        // Primer resultado: Vehículos
                        if (dr.Read()) conteos.Add("Vehículos", dr.GetInt32(0));

                        // Segundo resultado: Sucursales
                        dr.NextResult();
                        if (dr.Read()) conteos.Add("Sucursales", dr.GetInt32(0));

                        // Tercer resultado: Categorías
                        dr.NextResult();
                        if (dr.Read()) conteos.Add("Categorías", dr.GetInt32(0));
                    }
                }
            }
            return conteos;
        }
        public Dictionary<string, int> ObtenerEstadoSucursales()
        {
            var resultados = new Dictionary<string, int>();
            // Usamos el SELECT con CASE para que las etiquetas ya vengan listas
            string sql = @"SELECT 
                              CASE WHEN Activo = 1 THEN 'Activos' ELSE 'Inactivos' END AS Estado, COUNT(*) AS Total
                              FROM Sucursal 
                              GROUP BY Activo";

            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);
                cnx.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        resultados.Add(dr["Estado"].ToString(), Convert.ToInt32(dr["Total"]));
                    }
                }
            }
            return resultados;
        }
    }
}