
/*
 * UNED I Cuatrimestre 2026
 * Proyecto 2, Gestion De AutoMarket II. 
 * Estudiante: Josue Jimenez Barrantes
 * Fecha desarrollo : 11/02/2026 - 30/02/2026
 */

using System;

namespace CapaEntidades
{
    public class Vendedor : Persona
    {
        //atributos
        public int IdVend { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Telefono { get; set; }

        //constructores
        public Vendedor(int id, string identificacion, string nombre, DateTime nacimiento, DateTime ingreso, string telefono)
            : base(identificacion, nombre, nacimiento)
        {
            this.IdVend = id;
            this.FechaIngreso = ingreso;
            this.Telefono = telefono;
        }

        public Vendedor() { }
    }
}
