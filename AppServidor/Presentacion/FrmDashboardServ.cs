using System;
using System.Windows.Forms;
using Utilidades;
using AppServidor.Presentacion;

namespace AppServidor
{
    
    public partial class FrmDashboardServ : Form
    {
        public FrmDashboardServ()
        {
            InitializeComponent();
        }
        //instancias forms hijos para mantener en cache
        private FrmContRecursos frmRecursosCache = null;
        private FrmContHome frmHomeCache = null;
        private FrmContConsultas frmConsCache = null;


        //al cargar form por primera vez
        private void DashboardServ_Load(object sender, EventArgs e)
        {
            // Verificar si el formulario ya está en caché y no ha sido cerrado 
            if (frmHomeCache == null || frmHomeCache.IsDisposed)
            {
                frmHomeCache = new FrmContHome();
            }
            // Abrir el formulario en el panel contenedor
            UtilForms.AbrirFormularioEnPanel(this.pnlContenedor, frmHomeCache);
            //Inicializar sensores al iniciar la aplicación
            MonitorHardware.Inicializar();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            // Verificar si el formulario ya está en caché y no ha sido cerrado 
            if (frmConsCache == null || frmConsCache.IsDisposed)
            {
                frmConsCache = new FrmContConsultas();
            }
            // Abrir el formulario en el panel contenedor
            UtilForms.AbrirFormularioEnPanel(this.pnlContenedor, frmConsCache);
        }

        private void btnRecursos_Click(object sender, EventArgs e)
        {
            // Verificar si el formulario ya está en caché y no ha sido cerrado 
            if (frmRecursosCache == null || frmRecursosCache.IsDisposed)
            {
                frmRecursosCache = new FrmContRecursos();
            }
            // Abrir el formulario en el panel contenedor
            UtilForms.AbrirFormularioEnPanel(this.pnlContenedor, frmRecursosCache);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // Verificar si el formulario ya está en caché y no ha sido cerrado 
            if (frmHomeCache == null || frmHomeCache.IsDisposed)
            {
                frmHomeCache = new FrmContHome();
            }
            // Abrir el formulario en el panel contenedor
            UtilForms.AbrirFormularioEnPanel(this.pnlContenedor, frmHomeCache);
        }
    }
}
