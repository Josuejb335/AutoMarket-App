/*
•	UNED I Cuatrimestre 2026
•	Proyecto 2, Gestion De AutoMarket.
•	Estudiante: Josue Jimenez Barrantes
•	Fecha Finalizacion:  11 Abril de 2026
•	Clase de acceso a datos que realiza operaciones CRUD sobre la tabla Vehiculo en la base de datos
*/

using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidades;
using System;

namespace AccesoDatos
{
    public class VehiculoDatos : ConexionBD
    {
        public List<Vehiculo> ListarVehiculos()
        {
            // Lista para almacenar los vehículos obtenidos de la base de datos
            List<Vehiculo> lista = new List<Vehiculo>();

            string sql = @"SELECT v.IdVehiculo, v.Marca, v.Modelo, v.Precio, v.Ano,
                           v.Estado,c.IdCategoria, c.NombreCategoria, c.Descripcion 
                           FROM Vehiculo v 
                           INNER JOIN CategoriaVehiculo c ON v.IdCategoria = c.IdCategoria";

            // Bloque para asegurar que la conexión se cierre 
            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);
                cnx.Open();

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        // Instancia del objeto interno
                        var cat = new Categoria
                        {
                            IdCat = (int)dr["IdCategoria"],
                            NombreCat = dr["NombreCategoria"].ToString(),
                            DescCat = dr["Descripcion"].ToString()
                        };

                        var veh = new Vehiculo
                        {
                            IdVehi = (int)dr["IdVehiculo"],
                            Marca = dr["Marca"].ToString(),
                            Modelo = dr["Modelo"].ToString(),
                            Anio = (int)dr["Ano"],
                            Precio = (decimal)dr["Precio"],
                            Estado = dr["Estado"].ToString()[0],
                            Cat = cat
                        };

                        // Agrega a la lista
                        lista.Add(veh);
                    }
                }
            }
            // Retorna la lista de vehículos obtenida de la base de datos
            return lista;
        }

        // Método para insertar vehículo a la base de datos
        public bool InsertarVehiculo(Vehiculo v)
        {
            string sql = @"INSERT INTO Vehiculo (IdVehiculo, Marca, Modelo, Ano, Precio, Estado, IdCategoria)
                            VALUES (@id, @marca, @modelo, @ano, @precio, @estado, @idCat)";

            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);

                cmd.Parameters.AddWithValue("@id", v.IdVehi);
                cmd.Parameters.AddWithValue("@marca", v.Marca);
                cmd.Parameters.AddWithValue("@modelo", v.Modelo);
                cmd.Parameters.AddWithValue("@ano", v.Anio);
                cmd.Parameters.AddWithValue("@precio", v.Precio);
                cmd.Parameters.AddWithValue("@estado", v.Estado);
                cmd.Parameters.AddWithValue("@idCat", v.Cat.IdCat);

               cnx.Open();
               
               return cmd.ExecuteNonQuery() > 0; // Retorna true si se insertó al menos un registro
            }
        }

        public List<Vehiculo> ListarVehiculosPaginado(int pagina, int tamaño, string criterioOrden)
        {
            List<Vehiculo> lista = new List<Vehiculo>();
            int skip = (pagina - 1) * tamaño;
            string sql = $@"SELECT v.IdVehiculo, v.Marca, v.Modelo, v.Precio, v.Ano, v.Estado,
                                   c.IdCategoria, c.NombreCategoria, c.Descripcion 
                            FROM Vehiculo v 
                            INNER JOIN CategoriaVehiculo c ON v.IdCategoria = c.IdCategoria
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
                        lista.Add(new Vehiculo
                        {
                            IdVehi = (int)dr["IdVehiculo"],
                            Marca = dr["Marca"].ToString(),
                            Modelo = dr["Modelo"].ToString(),
                            Anio = (int)dr["Ano"],
                            Precio = (decimal)dr["Precio"],
                            Estado = dr["Estado"].ToString()[0],
                            Cat = new Categoria
                            {
                                IdCat = (int)dr["IdCategoria"],
                                NombreCat = dr["NombreCategoria"].ToString(),
                                DescCat = dr["Descripcion"].ToString()
                            }
                        });
                    }
                }
            }
            return lista;
        }

        public int ObtenerTotalVehiculos()
        {
            string sql = "SELECT COUNT(*) FROM Vehiculo";
            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);
                cnx.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        public int ObtenerProximoId()
        {
            string sql = "SELECT ISNULL(MAX(IdVehiculo), 0) + 1 FROM Vehiculo";
            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);
                cnx.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public bool ExisteVehiculo(int idVehiculo)
        {
            string sql = "SELECT COUNT(1) FROM Vehiculo WHERE IdVehiculo = @id";
            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);
                cmd.Parameters.AddWithValue("@id", idVehiculo);
                cnx.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
        }
    }
}
