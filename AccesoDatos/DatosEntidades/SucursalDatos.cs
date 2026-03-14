using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class SucursalDatos : ConexionBD
    {
        public List<Sucursal> ListarSucursales()
        {
            //lista para almacenar las categorias obtenidas de la bd
            List<Sucursal> lista = new List<Sucursal>();

            string sql = @"SELECT s.IdSucursal, s.Nombre, s.Direccion, s.Telefono, s.Activo,
                           v.IdVendedor, v.Identificacion, v.NombreCompleto, v.FechaNacimiento,
                           FechaIngreso, v.Telefono
                           FROM Sucursal s
                           INNER JOIN Vendedor v ON s.Idvendedor = v.IdVendedor";

            //bloque para asegurar que la conexión se cierre
            using (var cnx = ObtenerConexion())
            {
                var cmd = new SqlCommand(sql, cnx);
                cnx.Open();

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var enc = new Vendedor
                        {
                            IdVend = (int)dr["IdVendedor"],
                            Ident = dr["Identificacion"].ToString(),
                            Nombre = dr["NombreCompleto"].ToString(),
                            FechaNacimiento = (DateTime)dr["FechaNacimiento"],
                            FechaIngreso = (DateTime)dr["FechaIngreso"],
                            Telefono = dr["Telefono"].ToString()
                        };

                        var suc = new Sucursal
                        {
                            IdSuc = (int)dr["IdSucursal"],
                            NombreSuc = dr["Nombre"].ToString(),
                            Direccion = dr["Direccion"].ToString(),
                            Telefono = dr["Telefono"].ToString(),
                            Activo = (bool)dr["Activo"],
                            Encargado = enc
                        };

                        //Agregar a la lista
                        lista.Add(suc);
                    }
                }
            }
            return lista;
        }

        //metodo para insertar sucursal a la db
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

                return cmd.ExecuteNonQuery() > 0; //retorna true si se al menos un registro
            }
        }
    }
}