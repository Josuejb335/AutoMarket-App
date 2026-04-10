/*
•	UNED I Cuatrimestre 2026
•	Proyecto 2, Gestion De AutoMarket.
•	Estudiante: Josue Jimenez Barrantes
•	Fecha Finalizacion:  11 Abril de 2026
•	Formulario principal de la aplicación cliente que actúa como contenedor de los componentes de interfaz
*/

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
using AppCliente.Presentacion;
using AppCliente.Red;

namespace AppCliente
{
    public partial class FrmMenuCliente : Form
    {
        // Instancia global del socket para toda la aplicación cliente
        public ClienteSocket ClienteTCP { get; private set; }

        public FrmMenuCliente()
        {
            InitializeComponent();
            ClienteTCP = new ClienteSocket();
        }

        private void FrmMenuCliente_Load(object sender, EventArgs e)
        {
            // Suscribirnos al evento para detectar cuando cambia el control dentro del panel
            this.pnlContenedor.ControlAdded += PnlContenedor_ControlAdded;

            UtilForms.AbrirUserControlEnPanel(this.pnlContenedor, new UcLogin());
        }

        private void PnlContenedor_ControlAdded(object sender, ControlEventArgs e)
        {
            // Si el control cargado en pantalla es UcLogin, bloquea los botones.
            // Si es cualquier otro User Control (tras hacer login), los desbloquea.
            if (e.Control is UcLogin)
            {
                btnComprar.Enabled = false;
                btnConsultas.Enabled = false;
            }
            else
            {
                btnComprar.Enabled = true;
                btnConsultas.Enabled = true;
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Desconectar al cliente del servidor
            if (ClienteTCP != null)
            {
                ClienteTCP.Desconectar();
            }

            UtilForms.AbrirUserControlEnPanel(this.pnlContenedor, new UcLogin());
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            UtilForms.AbrirUserControlEnPanel(this.pnlContenedor, new UcCompra());
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            UtilForms.AbrirUserControlEnPanel(this.pnlContenedor, new UcConsulta());
        }
    }
}
