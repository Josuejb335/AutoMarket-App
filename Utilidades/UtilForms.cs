using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilidades
{
    public static class UtilForms
    {
        //metodo para abrir un formulario dentro de un panel, se usa en la app de server y cliente
        public static void AbrirFormularioEnPanel(Panel pnlContenedor, Form fh)
        {
            if (fh == null) return;

            // Limpiar panel
            if (pnlContenedor.Controls.Count > 0)
                pnlContenedor.Controls.RemoveAt(0);

            // Configurar formulario hijo
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;

            // Añadir y mostrar
            pnlContenedor.Controls.Add(fh);
            pnlContenedor.Tag = fh;
            fh.Show();
        }
    }
}
