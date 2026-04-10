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
        // Definimos el evento que enviará el mensaje y el color ya interpretado
        public static event Action<string, Color> AlPublicarMensaje;

        /// <summary>
        /// Escribe un mensaje en el log.
        /// Código de color: 1 = Verde, 2 = Azul, 3 = Rojo, 4 = Amarillo, 5 = Blanco
        /// </summary>
        public static void Escribir(string mensaje, int codigoColor = 0)
        {
            Color colorElegido = Color.White; // Por defecto

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

            // Si alguien está escuchando el evento, se le envian los datos
            AlPublicarMensaje?.Invoke(mensaje, colorElegido);
        }
    }
}
