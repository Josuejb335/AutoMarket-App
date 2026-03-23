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

            try
            {
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
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener ventas mensuales: " + ex.Message);
            }
            return datos;
        }

        //metodo que devuelve numero de sucursales vehiculos y categorias
        public Dictionary<string, int> ObtenerConteosGenerales()
        {
            Dictionary<string, int> conteos = new Dictionary<string, int>();
            string sql = @"SELECT COUNT(*) FROM Vehiculo;
                           SELECT COUNT(*) FROM Sucursal;
                           SELECT COUNT(*) FROM CategoriaVehiculo
                           SELECT COUNT(*) FROM Cliente
                           SELECT COUNT(*) FROM Vendedor;";

            try
            {
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

                            // Cuarto resultado: Clientes
                            dr.NextResult();
                            if (dr.Read()) conteos.Add("Clientes", dr.GetInt32(0));

                            // Tercer resultado: Vendedores
                            dr.NextResult();
                            if (dr.Read()) conteos.Add("Vendedores", dr.GetInt32(0));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener conteos generales: " + ex.Message);
            }
            return conteos;
        }
        
        public Dictionary<string, int> ObtenerEstadoSucursales()
        {
            var resultados = new Dictionary<string, int>();
            // Usamos el SELECT con CASE para que las etiquetas ya vengan listas
            string sql = @"SELECT 
                              CASE WHEN Activo = 1 THEN 'Activas' ELSE 'Inactivas' END AS Estado, COUNT(*) AS Total
                              FROM Sucursal 
                              GROUP BY Activo";

            try
            {
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
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener estado de sucursales: " + ex.Message);
            }
            return resultados;
        }

        public Dictionary<string, decimal> ObtenerRegistrosClientesPorMes()
        {
            Dictionary<string, decimal> clientesPorMes = new Dictionary<string, decimal>();

            string sql = @"SELECT 
                           FORMAT(FechaRegistro, 'MMMM', 'es-ES') AS Mes,
                           COUNT(*) AS Total,
                           MONTH(FechaRegistro) as MesNumero
                           FROM Cliente
                           WHERE FechaRegistro >= DATEADD(YEAR, -1, GETDATE()) -- Últimos 12 meses
                           GROUP BY FORMAT(FechaRegistro, 'MMMM', 'es-ES'), MONTH(FechaRegistro)
                           ORDER BY MesNumero ASC";

            try
            {
                using (var cnx = ObtenerConexion())
                {
                    var cmd = new SqlCommand(sql, cnx);
                    cnx.Open();
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string mes = dr["Mes"].ToString();
                            decimal total = Convert.ToDecimal(dr["Total"]);

                            clientesPorMes.Add(mes, total);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener histórico de clientes: " + ex.Message);
            }

            return clientesPorMes;
        }
    }
}