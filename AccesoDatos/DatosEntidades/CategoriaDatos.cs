using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class CategoriaDatos : ConexionBD
    {
        public List<Categoria> ListarCategorias()
        {
            //Lista para almacenar las categorias obtenidas de la bd
            List<Categoria> lista = new List<Categoria>();

            string sql = @"SELECT c.IdCategoria, c.NombreCategoria,
                            c.Descripcion FROM CategoriaVehiculo c";

            //bloque using para asegurar que la conexion se cierre
            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);
                cnx.Open();

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var cat = new Categoria
                        {
                            IdCat = (int)dr["IdCategoria"],
                            NombreCat = dr["NombreCategoria"].ToString(),
                            DescCat = dr["Descripcion"].ToString()
                        };

                        //Agregar a la lista
                        lista.Add(cat);
                    }
                }
            }
            return lista;
        }

        //metodo para insertar Categoria a la db
        public bool InsertarCategoria(Categoria c)
        {
            string sql = @"INSERT INTO CategoriaVehiculo (IdCategoria, NombreCategoria, Descripcion)
                           VALUES (@id, @nombre, @descripcion)";

            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);

                cmd.Parameters.AddWithValue("@id", c.IdCat);
                cmd.Parameters.AddWithValue("@nombre", c.NombreCat);
                cmd.Parameters.AddWithValue("@descripcion", c.DescCat);

                cnx.Open();
                return cmd.ExecuteNonQuery() > 0; //retorna true si se inserto al menos un registro
            }
        }

        //metodo para listar categorias con paginacion y ordenamiento
        public List<Categoria> ListarCategoriasPaginado(int pagina, int tamaño, string criterioOrden)
        {
            List<Categoria> lista = new List<Categoria>();
            int skip = (pagina - 1) * tamaño;
            string sql = $"SELECT * FROM CategoriaVehiculo ORDER BY {criterioOrden} OFFSET @skip ROWS FETCH NEXT @pSize ROWS ONLY";

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
                        lista.Add(new Categoria
                        {
                            IdCat = (int)dr["IdCategoria"],
                            NombreCat = dr["NombreCategoria"].ToString(),
                            DescCat = dr["Descripcion"].ToString()
                        });
                    }
                }
            }
            return lista;
        }

        //metodo para obtener el total de categorias en la db
        public int ObtenerTotalCategorias()
        {
            string sql = "SELECT COUNT(*) FROM CategoriaVehiculo";
            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);
                cnx.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        //metodo para obtener el proximo id disponible en la tabla CategoriaVehiculo
        public int ObtenerProximoId()
        {
            // Si la tabla está vacía, MAX es NULL, entonces ISNULL lo convierte en 0 y le suma 1.
            string sql = "SELECT ISNULL(MAX(IdCategoria), 0) + 1 FROM CategoriaVehiculo";

            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);
                cnx.Open();
                // ExecuteScalar se usa porque solo esperamos un único valor (un número)
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}
