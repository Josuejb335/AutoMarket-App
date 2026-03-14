using AccesoDatos.ConsultasDashBoard;
using CapaEntidades;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace AppServidor
{
    
    public partial class DashboardServ : Form
    {
        public DashboardServ()
        {
            InitializeComponent();
        }

        //test
        ConsultasDashBoard consultas = new ConsultasDashBoard();

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
            catch
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
            catch
            {
                throw new Exception("Error al actualizar el gráfico de personas");
            }
        }

        //metodo para actualizar chartGeneral
        private void ActChartVentas(decimal montoVentas)
        {
            try
            {
                // 1. Limpiar datos anteriores (importante para que no se encimen las barras)
                chartVentas.Series["Ventas"].Points.Clear();

                // 2. Configuración visual (lo que ya tenías)
                chartVentas.ChartAreas[0].AxisY.LabelStyle.Format = "C0";
                chartVentas.Series["Ventas"].IsValueShownAsLabel = true;
                chartVentas.Series["Ventas"].LabelFormat = "C2";

                // 3. AQUÍ es donde se usa el valor para mostrarlo
                // "Total" es la etiqueta del eje X, y montoVentas es la altura de la barra
                chartVentas.Series["Ventas"].Points.AddXY("Total Ventas", montoVentas);
            }
            catch
            {
                throw new Exception("Error al actualizar el gráfico de Ventas");
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
                ActChartGeneral(6, 4, 4);
                ActChartPersonas(6, 6);
                ActChartVentas(consultas.ObtenerMontoVentas());
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
