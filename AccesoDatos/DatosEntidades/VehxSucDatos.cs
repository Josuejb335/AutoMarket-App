using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidades;

namespace AccesoDatos
{
    public class VehxSucDatos : ConexionBD
    {
        public List<VehiculoxSucursal> ListarInventario()
        {
            List<VehiculoxSucursal> lista = new List<VehiculoxSucursal>();
            string sql = @"SELECT vs.Cantidad, 
                          s.IdSucursal, s.Nombre AS NombreSucursal,
                          v.IdVehiculo, v.Marca, v.Modelo
                   FROM VehiculoxSucursal vs
                   INNER JOIN Sucursal s ON vs.IdSucursal = s.IdSucursal
                   INNER JOIN Vehiculo v ON vs.IdVehiculo = v.IdVehiculo";

            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);
                cnx.Open();

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Sucursal suc = new Sucursal
                        {
                            IdSuc = Convert.ToInt32(dr["IdSucursal"]),
                            NombreSuc = dr["NombreSucursal"].ToString()
                        };

                        Vehiculo veh = new Vehiculo
                        {
                            IdVehi = Convert.ToInt32(dr["IdVehiculo"]),
                            Marca = dr["Marca"].ToString(),
                            Modelo = dr["Modelo"].ToString()
                        };

                        // Armamos el objeto principal
                        VehiculoxSucursal inventario = new VehiculoxSucursal
                        {
                            SucursalAsociada = suc,
                            VehiculoAsociado = veh,
                            Cantidad = Convert.ToInt32(dr["Cantidad"])
                        };

                        lista.Add(inventario);
                    }

                }
            }
            return lista;
        }

        public bool InsertarVehiculoEnSucursal(VehiculoxSucursal item)
        {
            string sql = @"INSERT INTO VehiculoxSucursal (IdSucursal, IdVehiculo, Cantidad) 
                   VALUES (@idSuc, @idVeh, @cantidad)";

            using (SqlConnection cnx = ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnx))
                {
                    cmd.Parameters.AddWithValue("@idSuc", item.SucursalAsociada.IdSuc);
                    cmd.Parameters.AddWithValue("@idVeh", item.VehiculoAsociado.IdVehi);
                    cmd.Parameters.AddWithValue("@cantidad", item.Cantidad);

                    cnx.Open();
                    return cmd.ExecuteNonQuery() > 0; //retorna true si se inserto al menos un registro
                }
            }
        }
    }
}