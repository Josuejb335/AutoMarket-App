
/*
 * UNED I Cuatrimestre 2026
 * Proyecto 2, Gestion De AutoMarket II. 
 * Estudiante: Josue Jimenez Barrantes
 * Fecha desarrollo : 11/02/2026 - 30/02/2026
 */

namespace CapaEntidades
{
    public class Sucursal
    {
        //atributos
        public int IdSuc { get; set; }
        public string NombreSuc { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Vendedor Encargado { get; set; }
        public bool Activo { get; set; }

        //constructores
        public Sucursal(int id, string nombre, string direccion, string telefono, Vendedor encargado, bool activo)
        {
            this.IdSuc = id;
            this.NombreSuc = nombre;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Encargado = encargado;
            this.Activo = activo;
        }

        public Sucursal() { }
    }
}
