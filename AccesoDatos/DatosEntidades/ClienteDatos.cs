using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   
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
    }
}