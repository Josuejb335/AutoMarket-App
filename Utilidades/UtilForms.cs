/*
•	UNED I Cuatrimestre 2026
•	Proyecto 2, Gestion De AutoMarket.
•	Estudiante: Josue Jimenez Barrantes
•	Fecha Finalizacion:  11 Abril de 2026
•	Clase estática de utilidades para gestionar formularios y controles de usuario en paneles
*/

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
        //metodo para abrir un UserControl dentro de un panel, se usa en la app de server y cliente
        public static void AbrirUserControlEnPanel(Panel pnl, UserControl uc)
        {
            pnl.Controls.Clear();

            uc.Dock = DockStyle.Fill;
            pnl.Controls.Add(uc);
        }
    }
}
