using System;
using System.Collections.Generic;
using System.Data.SqlClient;  
using CapaEntidades;

namespace AccesoDatos
{
    public class ClienteDatos : ConexionBD
    {
        public List<Cliente> ListarClientes()
        {
            List<Cliente> lista = new List<Cliente>();

            string sql = @"SELECT IdCliente, Identificacion, NombreCompleto,
                           FechaNacimiento, FechaRegistro, Activo
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
                        var clie = new Cliente
                        {
                            IdCliente = (int)dr["IdCliente"],
                            Ident = dr["Identificacion"].ToString(),
                            Nombre = dr["NombreCompleto"].ToString(),
                            FechaNacimiento = (DateTime)dr["FechaNacimiento"],
                            FechaRegistro = (DateTime)dr["FechaRegistro"],
                            Activo = (bool)dr["Activo"]
                        };
                        lista.Add(clie);
                    }
                }
            }
            return lista;
        }

        public bool InsertarCliente(Cliente c)
        {
            string sql = @"INSERT INTO Cliente ( IdCliente, Identificacion, NombreCompleto, FechaNacimiento, FechaRegistro, Activo)
                           VALUES (@id, @ident, @nombre, @nacimiento, @registro, @activo)";
            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);

                cmd.Parameters.AddWithValue("@id", c.IdCliente);
                cmd.Parameters.AddWithValue("@ident", c.Ident);
                cmd.Parameters.AddWithValue("@nombre", c.Nombre);
                cmd.Parameters.AddWithValue("@nacimiento", c.FechaNacimiento);
                cmd.Parameters.AddWithValue("@registro", c.FechaRegistro);
                cmd.Parameters.AddWithValue("@activo", c.Activo);

                cnx.Open();

                return cmd.ExecuteNonQuery() > 0; //retorna true si se inserto al menos un registro
            }
        }

        public List<Cliente> ListarClientesPaginado(int pagina, int tamaño, string criterioOrden)
        {
            List<Cliente> lista = new List<Cliente>();
            int skip = (pagina - 1) * tamaño;
            string sql = $"SELECT * FROM Cliente ORDER BY {criterioOrden} OFFSET @skip ROWS FETCH NEXT @pSize ROWS ONLY";

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
                        lista.Add(new Cliente
                        {
                            IdCliente = (int)dr["IdCliente"],
                            Ident = dr["Identificacion"].ToString(),
                            Nombre = dr["NombreCompleto"].ToString(),
                            FechaNacimiento = (DateTime)dr["FechaNacimiento"],
                            FechaRegistro = (DateTime)dr["FechaRegistro"],
                            Activo = (bool)dr["Activo"]
                        });
                    }
                }
            }
            return lista;
        }

        public Dictionary<string, decimal> ObtenerRegistrosClientesPorMes()
        {
            Dictionary<string, decimal> clientesPorMes = new Dictionary<string, decimal>();
            string sql = @"SELECT FORMAT(FechaRegistro, 'MMMM', 'es-ES') AS Mes, COUNT(*) AS Total, MONTH(FechaRegistro) as MesNumero
                           FROM Cliente WHERE FechaRegistro >= DATEADD(YEAR, -1, GETDATE()) GROUP BY FORMAT(FechaRegistro, 'MMMM', 'es-ES'), MONTH(FechaRegistro) ORDER BY MesNumero ASC";

            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);
                cnx.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        clientesPorMes.Add(dr["Mes"].ToString(), Convert.ToDecimal(dr["Total"]));
                    }
                }
            }
            return clientesPorMes;
        }

        public int ObtenerTotalClientes()
        {
            string sql = "SELECT COUNT(*) FROM Cliente";
            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);
                cnx.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        public int ObtenerProximoId()
        {
            string sql = "SELECT ISNULL(MAX(IdCliente), 0) + 1 FROM Cliente";
            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);
                cnx.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}