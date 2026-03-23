using AccesoDatos.ConsultasDashBoard;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Utilidades;
using AppServidor.Presentacion;

namespace AppServidor
{
    
    public partial class DashboardServ : Form
    {
        public DashboardServ()
        {
            InitializeComponent();
        }

        //instancias para clases hijas de consultas y logica
        ConsultasDashBoard consultas = new ConsultasDashBoard();

        private void DashboardServ_Load(object sender, EventArgs e)
        {
            UtilForms.AbrirFormularioEnPanel(pnlContenedor, new ContHome(consultas));
        }
        private void btnBitacora_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
        
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
        }

        private void cuiPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chartSucursales_Click(object sender, EventArgs e)
        {

        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlFondo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRecursos_Click(object sender, EventArgs e)
        {
            UtilForms.AbrirFormularioEnPanel(pnlContenedor, new ContRecursos());
        }
    }
}
