/*
•	UNED I Cuatrimestre 2026
•	Proyecto 2, Gestion De AutoMarket.
•	Estudiante: Josue Jimenez Barrantes
•	Fecha Finalizacion:  11 Abril de 2026
•	Clase que representa la estructura de mensajes intercambiados entre cliente y servidor
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunicacion
{
    public class Mensaje
    {
        public string Accion { get; set; }
        public string Tipo { get; set; }
        public string Datos { get; set; }

        public Mensaje()
        {
            Accion = string.Empty;
            Tipo = string.Empty;
            Datos = string.Empty;
        }

        public Mensaje(string accion, string tipo, string datos)
        {
            Accion = accion;
            Tipo = tipo;
            Datos = datos;
        }
    }
}
