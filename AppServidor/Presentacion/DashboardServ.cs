using AccesoDatos.ConsultasDashBoard;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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

        //metodo para actualizar chart de Datos registrado
        private void ActChartGeneral()
        {
            try
            {
                var datos = consultas.ObtenerConteosGenerales();
                chartGeneral.Series["Datos Registrados"].Points.Clear();

                foreach (var item in datos)
                {
                    int i = chartGeneral.Series["Datos Registrados"].Points.AddXY(item.Key, item.Value);
                }

            }
            catch
            {
                throw new Exception("Error al actualizar el gráfico general");
            }
        }

        //metodo para actualizar chart Sucursales
        private void ActChartSucursales(Dictionary<string, int> datos)
        {
            try
            {
                // Supongamos que tu serie se llama "SeriesPie"
                var serie = chartSucursales.Series["Series"];
                serie.Points.Clear();
                serie.ChartType = SeriesChartType.Pie;

                // Opcional: Hacer que parezca una "Dona" (se ve más moderno)
                serie["PieDrawingStyle"] = "Concave"; 
                serie.CustomProperties = "DoughnutRadius=40"; 

                foreach (var item in datos)
                {
                    int i = serie.Points.AddXY(item.Key, item.Value);

                    // Configuramos para que el texto salga DENTRO o FUERA del pastel
                    serie.Points[i].Label = "#VALX: #VALY (#PERCENT)"; // Muestra: Activos: 10 (60%)
                    serie.Points[i].LegendText = "#VALX"; // Para que la leyenda diga "Activos" o "Inactivos"
                }

                // Colores específicos para que "Activos" sea verde y "Inactivos" rojo
                if (serie.Points.Count > 0)
                {
                    // Esto depende del orden en que lleguen de la BD, 
                    // pero puedes buscar por la etiqueta:
                    foreach (var p in serie.Points)
                    {
                        if (p.AxisLabel == "Activos") p.Color = Color.SeaGreen;
                        if (p.AxisLabel == "Inactivos") p.Color = Color.IndianRed;
                    }
                }
            }
            catch
            {
                throw new Exception("Error al actualizar el gráfico de personas");
            }
        }

        //metodo para actualizar chartGeneral
        private void ActChartVentas(Dictionary<string, decimal> ventasPorMes)
        {
            try
            {
                var serie = chartVentas.Series["Ventas"];
                serie.Points.Clear();

                // Configurar formato de moneda
                chartVentas.ChartAreas[0].AxisY.LabelStyle.Format = "C0";

                // 3. Cargar los datos al gráfico
                foreach (var entrega in ventasPorMes)
                {
                    // entrega.Key es el nombre del Mes, entrega.Value es el monto
                    serie.Points.AddXY(entrega.Key, (double)entrega.Value);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la línea de tiempo de ventas: " + ex.Message);
            }
        }

        // Al cargar form
        private void DashboardServ_Load(object sender, EventArgs e)
        {
            // Timer para actualizar el dashboard cada x segundos
            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Tick +=  actualizarDashboard;
            timer.Start();
        }

        // Actulizar metodo cada que se registre un evento o cada 3 segundos
        private void actualizarDashboard(object sender, EventArgs e)
        {
            try
            {
                ActChartGeneral();
                ActChartSucursales(consultas.ObtenerEstadoSucursales());
                ActChartVentas(consultas.ObtenerVentasMensuales());
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
