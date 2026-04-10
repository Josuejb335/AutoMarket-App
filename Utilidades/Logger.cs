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
        // Definimos el evento que enviará el mensaje y el color
        public static event Action<string, Color> AlPublicarMensaje;

        public static void Escribir(string mensaje, Color color)
        {
            // Si alguien está escuchando el evento, se le envian los datos
            AlPublicarMensaje?.Invoke(mensaje, color);
        }
    }
}
