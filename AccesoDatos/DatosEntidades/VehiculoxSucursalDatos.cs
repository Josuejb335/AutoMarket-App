/*
•	UNED I Cuatrimestre 2026
•	Proyecto 2, Gestion De AutoMarket.
•	Estudiante: Josue Jimenez Barrantes
•	Fecha Finalizacion:  11 Abril de 2026
•	Clase de acceso a datos que realiza operaciones CRUD sobre la tabla VehiculoxSucursal en la base de datos
*/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidades;

namespace AccesoDatos
{
    public class VehiculoxSucursalDatos : ConexionBD
    {
        public List<VehiculoxSucursal> ListarVehiculoxSucursalPaginado(int pagina, int tamaño, string criterioOrden)
        {
            List<VehiculoxSucursal> lista = new List<VehiculoxSucursal>();
            int skip = (pagina - 1) * tamaño;
            
            string sql = $@"SELECT vs.IdSucursal, s.Nombre AS NombreSucursal, 
                                   vs.IdVehiculo, v.Marca, v.Modelo, vs.Cantidad
                            FROM VehiculoxSucursal vs
                            INNER JOIN Sucursal s ON vs.IdSucursal = s.IdSucursal
                            INNER JOIN Vehiculo v ON vs.IdVehiculo = v.IdVehiculo
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
                        lista.Add(new VehiculoxSucursal
                        {
                            SucursalAsociada = new Sucursal { IdSuc = (int)dr["IdSucursal"], NombreSuc = dr["NombreSucursal"].ToString() },
                            VehiculoAsociado = new Vehiculo { IdVehi = (int)dr["IdVehiculo"], Marca = dr["Marca"].ToString(), Modelo = dr["Modelo"].ToString() },
                            Cantidad = (int)dr["Cantidad"]
                        });
                    }
                }
            }
            return lista;
        }

        public int ObtenerTotalVehiculoxSucursal()
        {
            string sql = "SELECT COUNT(*) FROM VehiculoxSucursal";
            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);
                cnx.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        public List<VehiculoxSucursal> ListarVehiculosPorSucursal(int idSucursal)
        {
            List<VehiculoxSucursal> lista = new List<VehiculoxSucursal>();
            // SQL para obtener todos los vehículos disponibles (con stock) en una sucursal específica
            string sql = @"SELECT vs.IdSucursal, s.Nombre AS NombreSucursal, 
                                   vs.IdVehiculo, v.Marca, v.Modelo, v.Precio, vs.Cantidad
                            FROM VehiculoxSucursal vs
                            INNER JOIN Sucursal s ON vs.IdSucursal = s.IdSucursal
                            INNER JOIN Vehiculo v ON vs.IdVehiculo = v.IdVehiculo
                            WHERE vs.IdSucursal = @idSucursal AND vs.Cantidad > 0";

            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);
                cmd.Parameters.AddWithValue("@idSucursal", idSucursal);
                cnx.Open();

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        // Mapear cada fila del resultado a un objeto VehiculoxSucursal con sus datos relacionados
                        lista.Add(new VehiculoxSucursal
                        {
                            SucursalAsociada = new Sucursal { IdSuc = (int)dr["IdSucursal"], NombreSuc = dr["NombreSucursal"].ToString() },
                            VehiculoAsociado = new Vehiculo { IdVehi = (int)dr["IdVehiculo"], Marca = dr["Marca"].ToString(), Modelo = dr["Modelo"].ToString(), Precio = (decimal)dr["Precio"] },
                            Cantidad = (int)dr["Cantidad"]
                        });
                    }
                }
            }
            return lista;
        }

        public bool InsertarVehiculoxSucursal(VehiculoxSucursal vs)
        {
            // SQL que vincula un vehículo a una sucursal con una cantidad inicial
            string sql = @"INSERT INTO VehiculoxSucursal (IdSucursal, IdVehiculo, Cantidad)
                           VALUES (@idSucursal, @idVehiculo, @cantidad)";

            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);

                // Asignar los valores del objeto VS a los parámetros de la consulta
                cmd.Parameters.AddWithValue("@idSucursal", vs.SucursalAsociada.IdSuc);
                cmd.Parameters.AddWithValue("@idVehiculo", vs.VehiculoAsociado.IdVehi);
                cmd.Parameters.AddWithValue("@cantidad", vs.Cantidad);

                cnx.Open();
                // Retornar true si se insertó correctamente (si se afectó al menos una fila)
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool RestarInventarioVehiculo(int idSucursal, int idVehiculo)
        {
            // SQL que reduce en 1 la cantidad de un vehículo en una sucursal (simula una compra)
            // Solo resta si la cantidad actual es mayor a 0 (evita cantidades negativas)
            string sql = @"UPDATE VehiculoxSucursal 
                           SET Cantidad = Cantidad - 1 
                           WHERE IdSucursal = @idSucursal AND IdVehiculo = @idVehiculo AND Cantidad > 0";

            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);
                cmd.Parameters.AddWithValue("@idSucursal", idSucursal);
                cmd.Parameters.AddWithValue("@idVehiculo", idVehiculo);

                cnx.Open();
                // Retornar true si la actualización fue exitosa (es decir, si el vehículo existía y tenía stock)
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}