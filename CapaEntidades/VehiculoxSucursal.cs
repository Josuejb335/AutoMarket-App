
/*
 * UNED I Cuatrimestre 2026
 * Proyecto 2, Gestion De AutoMarket II. 
 * Estudiante: Josue Jimenez Barrantes
 * Fecha desarrollo : 11/02/2026 - 30/02/2026
 */

namespace CapaEntidades
{
    public class VehiculoxSucursal
    { 
        //Atributos
        public Vehiculo VehiculoAsociado { get; set; }
        public Sucursal SucursalAsociada { get; set; }
        public int Cantidad { get; set; }

        // Constructores
        public VehiculoxSucursal(Vehiculo vehiculo, Sucursal sucursal, int cantidad)
        {
            this.VehiculoAsociado = vehiculo;
            this.SucursalAsociada = sucursal;
            this.Cantidad = cantidad;
        }
        public VehiculoxSucursal() { }
    }
}
