using System;

namespace CapaEntidades
{
    public class Venta
    {
        //atributos
        public int IdVenta { get; set; }
        public Cliente Clie { get; set; }
        public Sucursal Suc { get; set; }
        public Vehiculo Veh { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal Monto { get; set; }

        //constructores
        public Venta(int id, Cliente cliente, Sucursal sucursal, Vehiculo vehiculo, DateTime fecha, decimal monto)
        {
            this.IdVenta = id;
            this.Clie = cliente;
            this.Suc = sucursal;
            this.Veh = vehiculo;
            this.FechaVenta = fecha;
            this.Monto = monto;
        }   

        public Venta() { }
    }
}
