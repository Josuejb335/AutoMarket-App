using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class SucursalDatos : ConexionBD
    {
        public List<Sucursal> ListarSucursales()
        {
            // Lista para almacenar las sucursales obtenidas de la bd
            List<Sucursal> lista = new List<Sucursal>();

            string sql = @"SELECT s.IdSucursal, s.Nombre, s.Direccion, s.Telefono, s.Activo,
                           v.IdVendedor, v.Identificacion, v.NombreCompleto, v.FechaNacimiento,
                           v.FechaIngreso, v.Telefono AS TelVendedor
                           FROM Sucursal s
                           LEFT JOIN Vendedor v ON s.Idvendedor = v.IdVendedor";

            // Bloque para asegurar que la conexión se cierre
            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);
                cnx.Open();

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var suc = new Sucursal
                        {
                            IdSuc = (int)dr["IdSucursal"],
                            NombreSuc = dr["Nombre"].ToString(),
                            Direccion = dr["Direccion"].ToString(),
                            Telefono = dr["Telefono"].ToString(),
                            Activo = (bool)dr["Activo"],
                            Encargado = dr["IdVendedor"] != DBNull.Value ? new Vendedor
                            {
                                IdVend = (int)dr["IdVendedor"],
                                Ident = dr["Identificacion"].ToString(),
                                Nombre = dr["NombreCompleto"].ToString(),
                                FechaNacimiento = (DateTime)dr["FechaNacimiento"],
                                FechaIngreso = (DateTime)dr["FechaIngreso"],
                                Telefono = dr["TelVendedor"].ToString()
                            } : new Vendedor()
                        };

                        // Agrega a la lista
                        lista.Add(suc);
                    }
                }
            }
            return lista;
        }

        // Método para insertar sucursal a la base de datos
        public bool InsertarSucursal(Sucursal s)
        {
            string sql = @"INSERT INTO Sucursal (IdSucursal, Nombre, Direccion, Telefono, Activo, IdVendedor)
                           VALUES (@id, @nombre, @direccion, @telefono, @activo, @idvendedor)";
            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);

                cmd.Parameters.AddWithValue("@id", s.IdSuc);
                cmd.Parameters.AddWithValue("@nombre", s.NombreSuc);
                cmd.Parameters.AddWithValue("@direccion", s.Direccion);
                cmd.Parameters.AddWithValue("@telefono", s.Telefono);
                cmd.Parameters.AddWithValue("@activo", s.Activo);
                cmd.Parameters.AddWithValue("@idvendedor", s.Encargado.IdVend);

                cnx.Open();

                return cmd.ExecuteNonQuery() > 0; // Retorna true si se insertó al menos un registro
            }
        }

        public List<Sucursal> ListarSucursalesPaginado(int pagina, int tamaño, string criterioOrden)
        {
            List<Sucursal> lista = new List<Sucursal>();
            int skip = (pagina - 1) * tamaño;
            string sql = $@"SELECT s.IdSucursal, s.Nombre, s.Direccion, s.Telefono, s.Activo,
                                   v.IdVendedor, v.Identificacion, v.NombreCompleto, v.FechaNacimiento, v.FechaIngreso, v.Telefono AS TelVendedor
                            FROM Sucursal s
                            LEFT JOIN Vendedor v ON s.IdVendedor = v.IdVendedor
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
                        lista.Add(new Sucursal
                        {
                            IdSuc = (int)dr["IdSucursal"],
                            NombreSuc = dr["Nombre"].ToString(),
                            Direccion = dr["Direccion"].ToString(),
                            Telefono = dr["Telefono"].ToString(),
                            Activo = (bool)dr["Activo"],
                            Encargado = dr["IdVendedor"] != DBNull.Value ? new Vendedor
                            {
                                IdVend = (int)dr["IdVendedor"],
                                Ident = dr["Identificacion"].ToString(),
                                Nombre = dr["NombreCompleto"].ToString(),
                                FechaNacimiento = (DateTime)dr["FechaNacimiento"],
                                FechaIngreso = (DateTime)dr["FechaIngreso"],
                                Telefono = dr["TelVendedor"].ToString()
                            } : new Vendedor()
                        });
                    }
                }
            }
            return lista;
        }

        public Dictionary<string, int> ObtenerEstadoSucursales()
        {
            var resultados = new Dictionary<string, int>();
            string sql = @"SELECT CASE WHEN Activo = 1 THEN 'Activas' ELSE 'Inactivas' END AS Estado, COUNT(*) AS Total
                           FROM Sucursal GROUP BY Activo";

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
            return resultados;
        }

        public int ObtenerTotalSucursales()
        {
            string sql = "SELECT COUNT(*) FROM Sucursal";
            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);
                cnx.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        public int ObtenerProximoId()
        {
            string sql = "SELECT ISNULL(MAX(IdSucursal), 0) + 1 FROM Sucursal";
            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);
                cnx.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public bool ExisteSucursal(int idSucursal)
        {
            string sql = "SELECT COUNT(1) FROM Sucursal WHERE IdSucursal = @id";
            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);
                cmd.Parameters.AddWithValue("@id", idSucursal);
                cnx.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
        }
    }
}