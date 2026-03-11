
/*
 * UNED I Cuatrimestre 2026
 * Proyecto 2, Gestion De AutoMarket II. 
 * Estudiante: Josue Jimenez Barrantes
 * Fecha desarrollo : 11/02/2026 - 30/02/2026
 */

using System;

namespace CapaEntidades
{
    public class Cliente : Persona
    {
        // atributos
        public int IdCliente { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Activo { get; set; }
       
        // constructores
        public Cliente(int id, string identificacion, string nombre, DateTime nacimiento, DateTime registro, bool activo)
            : base(identificacion, nombre, nacimiento)
        {
            this.IdCliente = id;
            this.FechaRegistro = registro;
            this.Activo = activo;
        }

        public Cliente() { }
    }
}
