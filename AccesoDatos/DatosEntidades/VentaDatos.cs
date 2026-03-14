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
    }
}
