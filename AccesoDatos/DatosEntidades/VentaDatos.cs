using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidades;    

namespace AccesoDatos
{
    public class VentaDatos : ConexionBD
    {
        public List<Venta> ListarVentas()
        {
            List<Venta> lista = new List<Venta>();

            string sql = @"SELECT 
                        V.IdVenta, V.FechaVenta, V.Monto,
                        C.IdCliente, C.NombreCompleto AS NombreCliente, C.Identificacion AS CedulaCliente,
                        S.IdSucursal, S.Nombre AS NombreSucursal,
                        Ven.IdVendedor, Ven.NombreCompleto AS NombreVendedor,
                        Veh.IdVehiculo, Veh.Marca, Veh.Modelo,
                        Cat.IdCategoria, Cat.NombreCategoria
                        FROM Venta V
                        INNER JOIN Cliente C ON V.IdCliente = C.IdCliente
                        INNER JOIN Sucursal S ON V.IdSucursal = S.IdSucursal
                        INNER JOIN Vendedor Ven ON S.IdVendedor = Ven.IdVendedor
                        INNER JOIN Vehiculo Veh ON V.IdVehiculo = Veh.IdVehiculo
                        INNER JOIN CategoriaVehiculo Cat ON Veh.IdCategoria = Cat.IdCategoria";

            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);
                cnx.Open();

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Vendedor vendedor = new Vendedor
                        {
                            IdVend = Convert.ToInt32(dr["IdVendedor"]),
                            Nombre = dr["NombreVendedor"].ToString()
                        };

                        Categoria categoria = new Categoria
                        {
                            IdCat = Convert.ToInt32(dr["IdCategoria"]),
                            NombreCat = dr["NombreCategoria"].ToString()
                        };

                        Cliente cliente = new Cliente
                        {
                            IdCliente = Convert.ToInt32(dr["IdCliente"]),
                            Nombre = dr["NombreCliente"].ToString()
                        };

                        Sucursal sucursal = new Sucursal
                        {
                            IdSuc = Convert.ToInt32(dr["IdSucursal"]),
                            NombreSuc = dr["NombreSucursal"].ToString(),
                            Encargado = vendedor
                        };

                        Vehiculo vehiculo = new Vehiculo
                        {
                            IdVehi = Convert.ToInt32(dr["IdVehiculo"]),
                            Marca = dr["Marca"].ToString(),
                            Modelo = dr["Modelo"].ToString(),
                            Cat = categoria
                        };

                        Venta venta = new Venta
                        {
                            IdVenta = Convert.ToInt32(dr["IdVenta"]),
                            FechaVenta = Convert.ToDateTime(dr["FechaVenta"]),
                            Monto = Convert.ToDecimal(dr["Monto"]),

                            Clie = cliente,
                            Suc = sucursal,
                            Veh = vehiculo
                        };

                        lista.Add(venta);
                    }
                }

            }
            return lista;
        }
        public bool InsertarVenta(Venta nuevaVenta)
        {
            // IdVenta no se pone porque es IDENTITY (autoincremental)
            string sql = @"INSERT INTO Venta (IdCliente, IdSucursal, IdVehiculo, FechaVenta, Monto) 
                   VALUES (@idCliente, @idSucursal, @idVehiculo, @fecha, @monto)";

            using (SqlConnection cnx = ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnx))
                {
                    cmd.Parameters.AddWithValue("@idCliente", nuevaVenta.Clie.IdCliente);
                    cmd.Parameters.AddWithValue("@idSucursal", nuevaVenta.Suc.IdSuc);
                    cmd.Parameters.AddWithValue("@idVehiculo", nuevaVenta.Veh.IdVehi);
                    cmd.Parameters.AddWithValue("@fecha", nuevaVenta.FechaVenta);
                    cmd.Parameters.AddWithValue("@monto", nuevaVenta.Monto);

                    cnx.Open();

                    return cmd.ExecuteNonQuery() > 0; //retorna true si se inserto al menos un registro
                }
            }
        }

        public List<Venta> ListarVentasPaginado(int pagina, int tamaño, string criterioOrden)
        {
            List<Venta> lista = new List<Venta>();
            int skip = (pagina - 1) * tamaño;
            string sql = $@"SELECT V.IdVenta, V.FechaVenta, V.Monto,
                                   C.IdCliente, C.NombreCompleto AS NombreCliente, C.Identificacion AS CedulaCliente,
                                   S.IdSucursal, S.Nombre AS NombreSucursal,
                                   Veh.IdVehiculo, Veh.Marca, Veh.Modelo
                            FROM Venta V
                            INNER JOIN Cliente C ON V.IdCliente = C.IdCliente
                            INNER JOIN Sucursal S ON V.IdSucursal = S.IdSucursal
                            INNER JOIN Vehiculo Veh ON V.IdVehiculo = Veh.IdVehiculo
                            ORDER BY {criterioOrden} OFFSET @skip ROWS FETCH NEXT @pSize ROWS ONLY";

            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);
                cmd.Parameters.AddWithValue("@skip", skip);
                cmd.Parameters.AddWithValue("@pSize", tamaño);
                cnx.Open();

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Venta
                        {
                            IdVenta = Convert.ToInt32(dr["IdVenta"]),
                            FechaVenta = Convert.ToDateTime(dr["FechaVenta"]),
                            Monto = Convert.ToDecimal(dr["Monto"]),
                            Clie = new Cliente { IdCliente = Convert.ToInt32(dr["IdCliente"]), Nombre = dr["NombreCliente"].ToString(), Ident = dr["CedulaCliente"].ToString() },
                            Suc = new Sucursal { IdSuc = Convert.ToInt32(dr["IdSucursal"]), NombreSuc = dr["NombreSucursal"].ToString() },
                            Veh = new Vehiculo { IdVehi = Convert.ToInt32(dr["IdVehiculo"]), Marca = dr["Marca"].ToString(), Modelo = dr["Modelo"].ToString() }
                        });
                    }
                }
            }
            return lista;
        }

        public Dictionary<string, decimal> ObtenerVentasMensuales()
        {
            var datos = new Dictionary<string, decimal>();
            string sql = @"SELECT FORMAT(FechaVenta, 'MMMM', 'es-ES') AS Mes, SUM(Monto) AS Total 
                           FROM Venta GROUP BY FORMAT(FechaVenta, 'MMMM', 'es-ES'), MONTH(FechaVenta) ORDER BY MONTH(FechaVenta)";

            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);
                cnx.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        datos.Add(dr["Mes"].ToString(), Convert.ToDecimal(dr["Total"]));
                    }
                }
            }
            return datos;
        }

        public decimal ObtenerTotalMontoVentas()
        {
            string sql = "SELECT SUM(Monto) FROM Venta";
            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);
                cnx.Open();
                object result = cmd.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
            }
        }

        public int ObtenerTotalVentas()
        {
            string sql = "SELECT COUNT(*) FROM Venta";
            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);
                cnx.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
    }
}
