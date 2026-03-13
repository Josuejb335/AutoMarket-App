
/*
 * UNED I Cuatrimestre 2026
 * Proyecto 2, Gestion De AutoMarket II. 
 * Estudiante: Josue Jimenez Barrantes
 * Fecha desarrollo : 11/02/2026 - 30/02/2026
 */

namespace CapaEntidades
{
    public class Categoria
    {
        //atributos
        public int IdCat { get; set; }
        public string NombreCat { get; set; }
        public string DescCat { get; set; }
        
        //constructores
        public Categoria(int id, string nombre, string descripcion)
        {
            this.IdCat = id;
            this.NombreCat = nombre;
            this.DescCat = descripcion;
        }
        public Categoria() { }
    }
}
