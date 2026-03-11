
/*
 * UNED I Cuatrimestre 2026
 * Proyecto 2, Gestion De AutoMarket II. 
 * Estudiante: Josue Jimenez Barrantes
 * Fecha desarrollo : 11/02/2026 - 30/02/2026
 */

namespace CapaEntidades
{
    public class Vehiculo
    {
        // atributos
        public int IdVehi { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public decimal Precio { get; set; }
        public char Estado { get; set; }
        public Categoria Cat { get; set; }

        //constructores
        public Vehiculo(int id, string marca, string modelo, int anio, decimal precio, char estado, Categoria categoria)
        {
            this.IdVehi = id;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Anio = anio;
            this.Precio = precio;
            this.Estado = estado;
            this.Cat = categoria;
        }
        public Vehiculo() { }
    }
}
