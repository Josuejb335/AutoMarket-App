using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades;

namespace AppCliente.Presentacion
{
    public partial class UcLogin : UserControl
    {
        public UcLogin()
        {
            InitializeComponent();
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            // Obtener el panel contenedor el que contiene a este UserControl
            Panel pnlContenedor = (Panel)this.Parent;

            // abrir el UserControl UcHome en el panel contenedor
            UtilForms.AbrirUserControlEnPanel(pnlContenedor, new UcHome());
        }
    }
}
