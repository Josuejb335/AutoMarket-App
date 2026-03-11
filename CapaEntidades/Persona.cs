
/*
 * UNED I Cuatrimestre 2026
 * Proyecto 2, Gestion De AutoMarket II. 
 * Estudiante: Josue Jimenez Barrantes
 * Fecha desarrollo : 11/02/2026 - 30/02/2026
 */

using System;

namespace CapaEntidades
{
    public class Persona
    {
        //atributos
        public string Ident { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }

        //constructores
        public Persona(string identificacion, string nombre, DateTime fechaNacimiento)
        {
            Ident = identificacion;
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
        }

        public Persona() { }
    }
}
