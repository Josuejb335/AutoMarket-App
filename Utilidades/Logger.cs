/*
•	UNED I Cuatrimestre 2026
•	Proyecto 2, Gestion De AutoMarket.
•	Estudiante: Josue Jimenez Barrantes
•	Fecha Finalizacion:  11 Abril de 2026
•	Clase estática que proporciona métodos para registrar mensajes con códigos de color en la interfaz
*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public static class Logger
    {
        public static event Action<string, Color> AlPublicarMensaje;

        /// <summary>
        /// Escribe un mensaje en el log.
        /// Código de color: 1 = Verde, 2 = Azul, 3 = Rojo, 4 = Amarillo, 5 = Blanco
        /// </summary>
        public static void Escribir(string mensaje, int codigoColor = 0)
        {
            Color colorElegido = Color.White;

            switch (codigoColor)
            {
                case 1:
                    colorElegido = Color.Green;
                    break;
                case 2:
                    colorElegido = Color.DodgerBlue;
                    break;
                case 3:
                    colorElegido = Color.Red;
                    break;
                case 4:
                    colorElegido = Color.Yellow;
                    break;
                case 5:
                    colorElegido = Color.White;
                    break;
            }

            AlPublicarMensaje?.Invoke(mensaje, colorElegido);
        }
    }
}
