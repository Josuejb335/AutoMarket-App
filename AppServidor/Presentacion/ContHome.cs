using AccesoDatos.ConsultasDashBoard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppServidor.Presentacion
{
    public partial class ContHome : Form
    {
        //gestor de consultas para el dashboard, se instancia en el form padre y se pasa por parametro a este form hijo
        private ConsultasDashBoard consultas;
        public ContHome(ConsultasDashBoard consulta)
        {
            InitializeComponent();
            consultas = consulta;
        }

        private void ContHome_Load(object sender, EventArgs e)
        {
            //se cargan los chart al cargar este form y por individual cada uno cada que se registre un evento
            actualizarDashboard();
        }

        // Actulizar metodo cada que se registre un evento o cada 3 segundos
        private void actualizarDashboard()
        {
            try
            {
                ActChartGeneral();
                ActChartSucursales();
                ActChartVentas();
                ActChartClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

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
        private void ActChartSucursales()
        {
            try
            {
                var datos = consultas.ObtenerEstadoSucursales();
                // Supongamos que tu serie se llama "SeriesPie"
                var serie = chartSucursales.Series["Series"];
                serie.Points.Clear();

                foreach (var item in datos)
                {
                    int i = serie.Points.AddXY(item.Key, item.Value);

                    // --- LO QUE PEDISTE ---
                    // 1. Label vacío para que no salga texto SOBRE el pastel
                    serie.Points[i].Label = "";

                    // 2. LegendText con el nombre y el número para los cuadritos de la derecha
                    // #VALX es el nombre (Activos/Inactivos) y #VALY es el número
                    serie.Points[i].LegendText = "#VALX: #VALY";

                    // 3. Asignar colores fijos
                    if (item.Key == "Activas") serie.Points[i].Color = ColorTranslator.FromHtml("#F5DC71");
                    else serie.Points[i].Color = ColorTranslator.FromHtml("#FF9C41");
                }

                // Configuración extra para que la leyenda se vea clara
                chartSucursales.Legends[0].Enabled = true;
            }
            catch
            {
                throw new Exception("Error al actualizar el gráfico de personas");
            }
        }

        //metodo para actualizar chartGeneral
        private void ActChartVentas()
        {
            try
            {
                var ventasPorMes = consultas.ObtenerVentasMensuales();
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

        private void ActChartClientes()
        {
            try
            {
                // 1. Obtener los datos del diccionario
                var datos = consultas.ObtenerRegistrosClientesPorMes();

                // 2. Referencia a la serie (Asegúrate que en el diseñador se llame "Clientes")
                var serie = chartClientes.Series["Clientes Registrados en el Ultimo Año"];
                serie.Points.Clear();

                // Configurar el eje Y para que muestre números enteros (sin decimales ni $)
                chartClientes.ChartAreas[0].AxisY.LabelStyle.Format = "N0";

                // 4. Cargar los datos al gráfico
                foreach (var registro in datos)
                {
                    // registro.Key = Mes, registro.Value = Cantidad de clientes
                    serie.Points.AddXY(registro.Key, (double)registro.Value);
                }

                // Opcional: Mostrar el número exacto sobre cada punto
                serie.IsValueShownAsLabel = true;
            }
            catch (Exception ex)
            {
                // Usamos el mismo estilo de manejo de errores que tienes
                throw new Exception("Error al actualizar la línea de tiempo de clientes: " + ex.Message);
            }
        }
    }
}