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

        public bool InsertarVehiculoxSucursal(VehiculoxSucursal vs)
        {
            string sql = @"INSERT INTO VehiculoxSucursal (IdSucursal, IdVehiculo, Cantidad)
                           VALUES (@idSucursal, @idVehiculo, @cantidad)";

            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);

                // Parámetros basados en las propiedades mapeadas
                cmd.Parameters.AddWithValue("@idSucursal", vs.SucursalAsociada.IdSuc);
                cmd.Parameters.AddWithValue("@idVehiculo", vs.VehiculoAsociado.IdVehi);
                cmd.Parameters.AddWithValue("@cantidad", vs.Cantidad);

                cnx.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}