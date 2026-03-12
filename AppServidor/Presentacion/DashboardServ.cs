using AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppServidor
{
    public partial class DashboardServ : Form
    {
        public DashboardServ()
        {
            InitializeComponent();
        }

        //metodo para actualizar chartGeneral
        private void ActChartGeneral(int nVehiculos, int nSucursales, int nCategorias)
        {
            try
            {
                chartGeneral.Series[0].Points.Clear();
                //agregar datos al gráfico general
                chartGeneral.Series[0].Points.AddXY("Vehículos", nVehiculos);
                chartGeneral.Series[0].Points.AddXY("Sucursales", nSucursales);
                chartGeneral.Series[0].Points.AddXY("Categorías", nCategorias);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el gráfico general");
            }
        }

        //metodo para actualizar chartGeneral
        private void ActChartPersonas(int nClientes, int nVendedores)
        {
            try
            {
                chartGeneral2.Series[0].Points.Clear();
                //agregar datos al gráfico general
                chartGeneral2.Series[0].Points.AddXY("Vehículos", nVendedores);
                chartGeneral2.Series[0].Points.AddXY("Sucursales", nClientes);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el gráfico de personas");
            }
        }


        // Al cargar form
        private void DashboardServ_Load(object sender, EventArgs e)
        {
            // Timer para actualizar el dashboard cada x segundos
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick +=  actualizarDashboard;
            timer.Start();
        }

        // Actulizar metodo cada que se registre un evento o cada 3 segundos
        private void actualizarDashboard(object sender, EventArgs e)
        {
            try
            {
                ActChartGeneral(2, 4, 4);
                ActChartPersonas(3, 6);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
    }
}
