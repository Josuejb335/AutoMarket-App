using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AccesoDatos
{
    internal class VendedorDatos : ConexionBD
    {
        public List<Vendedor> ListarVendedores()
        {
            List<Vendedor> lista = new List<Vendedor>();

            string sql = @"SELECT IdVendedor, Identificacion, NombreCompleto,
                           FechaNacimiento, FechaIngreso, Telefono
                           FROM Cliente";

            //bloque para asegurar que la conexión se cierre
            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);
                cnx.Open();

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var vend = new Vendedor
                        {
                            IdVend = (int)dr["IdVendedor"],
                            Ident = dr["Identificacion"].ToString(),
                            Nombre = dr["NombreCompleto"].ToString(),
                            FechaNacimiento = (DateTime)dr["FechaNacimiento"],
                            FechaIngreso = (DateTime)dr["FechaRegistro"],
                            Telefono = dr["Telefono"].ToString()
                        };
                        lista.Add(vend);
                    }
                }
            }
            return lista;
        }

        public bool InsertarVendedor(Vendedor v)
        {
            string sql = @"INSERT INTO Vendedor ( IdVendedor, Identificacion, NombreCompleto, FechaNacimiento, FechaIngreso, Telefono)
                           VALUES (@id, @ident, @nombre, @nacimiento, @ingreso, @telefono)";
             
            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);

                cmd.Parameters.AddWithValue("@id", v.IdVend);
                cmd.Parameters.AddWithValue("@ident", v.Ident);
                cmd.Parameters.AddWithValue("@nombre", v.Nombre);
                cmd.Parameters.AddWithValue("@nacimiento", v.FechaNacimiento);
                cmd.Parameters.AddWithValue("@registro", v.FechaIngreso);
                cmd.Parameters.AddWithValue("@activo", v.Telefono);

                cnx.Open();

                return cmd.ExecuteNonQuery() > 0; //retorna true si se inserto al menos un registro
            }
        }
    }
}
