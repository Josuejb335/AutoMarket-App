
/*
 * UNED I Cuatrimestre 2026
 * Proyecto 2, Gestion De AutoMarket II. 
 * Estudiante: Josue Jimenez Barrantes
 * Fecha desarrollo : 11/02/2026 - 30/02/2026
 */

namespace CapaEntidades
{
    public class Asocie
    { 
        //Atributos
        public Vehiculo vehiculoAsociado { get; set; }
        public Sucursal sucursalAsociada { get; set; }
        public int cantidad { get; set; }

        // Constructores
        public Asocie(Vehiculo vehiculo, Sucursal sucursal, int cantidad)
        {
            this.vehiculoAsociado = vehiculo;
            this.sucursalAsociada = sucursal;
            this.cantidad = cantidad;
        }
        public Asocie() { }
    }
}
