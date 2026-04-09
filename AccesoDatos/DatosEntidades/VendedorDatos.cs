using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class VendedorDatos : ConexionBD
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
                cmd.Parameters.AddWithValue("@ingreso", v.FechaIngreso);
                cmd.Parameters.AddWithValue("@telefono", v.Telefono);

                cnx.Open();

                return cmd.ExecuteNonQuery() > 0; //retorna true si se inserto al menos un registro
            }
        }

        public List<Vendedor> ListarVendedoresPaginado(int pagina, int tamaño, string criterioOrden)
        {
            List<Vendedor> lista = new List<Vendedor>();
            int skip = (pagina - 1) * tamaño;
            string sql = $"SELECT * FROM Vendedor ORDER BY {criterioOrden} OFFSET @skip ROWS FETCH NEXT @pSize ROWS ONLY";

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
                        lista.Add(new Vendedor
                        {
                            IdVend = (int)dr["IdVendedor"],
                            Ident = dr["Identificacion"].ToString(),
                            Nombre = dr["NombreCompleto"].ToString(),
                            FechaNacimiento = (DateTime)dr["FechaNacimiento"],
                            FechaIngreso = (DateTime)dr["FechaIngreso"],
                            Telefono = dr["Telefono"].ToString()
                        });
                    }
                }
            }
            return lista;
        }

        public int ObtenerTotalVendedores()
        {
            string sql = "SELECT COUNT(*) FROM Vendedor";
            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);
                cnx.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        public int ObtenerProximoId()
        {
            string sql = "SELECT ISNULL(MAX(IdVendedor), 0) + 1 FROM Vendedor";
            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);
                cnx.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}
