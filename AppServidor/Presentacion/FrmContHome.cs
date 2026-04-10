/*
•	UNED I Cuatrimestre 2026
•	Proyecto 2, Gestion De AutoMarket.
•	Estudiante: Josue Jimenez Barrantes
•	Fecha Finalizacion:  11 Abril de 2026
•	Formulario que maneja el Dashboard del servidor y el control de conexión
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using Utilidades;
using Logica;
using System.Collections.Generic;
using Comunicacion; 

namespace AppServidor.Presentacion
{
    public partial class FrmContHome : Form
    {
        // instanciar el gestor de logica
        private GestorConsultas gestor = new GestorConsultas();
        
        // instanciar el servidor
        private ServidorSocket servidorTCP;

        public FrmContHome()
        {
            InitializeComponent();
        }

        private void ContHome_Load(object sender, EventArgs e)
        {
            actualizarDashboard();
            Logger.AlPublicarMensaje += MetodoReceptorLog;
        }

        private void MetodoReceptorLog(string msg, Color color)
        {
            AgregarLog(msg, color);
            
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => actualizarDashboard()));
            }
            else
            {
                actualizarDashboard();
            }
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            try
            {
                IniciarServidor();
                
                btnOn.Enabled = false;
                btnOff.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico al intentar iniciar el servidor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            try
            {
                servidorTCP?.Detener();
                
                btnOn.Enabled = true;
                btnOff.Enabled = false;
            }
            catch (Exception ex)
            {
                Logger.Escribir("Error al detener: " + ex.Message, 3);
            }
        }

        private void IniciarServidor()
        {
            if (servidorTCP != null)
            {
                servidorTCP.Detener();
            }

            servidorTCP = new ServidorSocket();
            servidorTCP.Iniciar();
        }

        public void AgregarLog(string mensaje, Color color)
        {
            // Si el llamado proviene de otro hilo, usar Invoke para ejecutar en el hilo principal de la UI
            if (rtbLog.InvokeRequired)
            {
                rtbLog.Invoke(new Action(() => AgregarLog(mensaje, color)));
            }
            else
            {
                // Formatear el mensaje con marca de hora para saber cuándo ocurrió
                string linea = $"[{DateTime.Now:HH:mm:ss}] {mensaje}{Environment.NewLine}";

                // Mover el cursor al final del texto para agregar la nueva línea
                rtbLog.SelectionStart = rtbLog.TextLength;
                rtbLog.SelectionLength = 0;

                // Aplicar el color especificado al texto
                rtbLog.SelectionColor = color;
                rtbLog.AppendText(linea);

                // Restablecer el color al default para las próximas líneas
                rtbLog.SelectionColor = rtbLog.ForeColor;
                // Hacer scroll automático para ver el último mensaje añadido
                rtbLog.ScrollToCaret();

                // Limpieza automática: si el log supera 150 líneas, mantener solo las últimas 100
                // Esto evita que la aplicación se vuelva lenta por demasiado texto en memoria
                if (rtbLog.Lines.Length > 150)
                {
                    rtbLog.ReadOnly = false;
                    // Seleccionar desde el inicio hasta la línea 50 (para borrar las primeras 100)
                    rtbLog.Select(0, rtbLog.GetFirstCharIndexFromLine(rtbLog.Lines.Length - 100));
                    rtbLog.SelectedText = "";
                    rtbLog.ReadOnly = true;
                }
            }
        }

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
                Logger.Escribir("Error al actualizar el dashboard: " + ex.Message, 3);
            }
        }

        private void ActChartGeneral()
        {
            try
            {
                // Crear un diccionario con los totales de cada entidad de la base de datos
                var datos = new Dictionary<string, int>();
                datos.Add("Vehículos", gestor.ObtenerTotalVehiculos());
                datos.Add("Sucursales", gestor.ObtenerTotalSucursales());
                datos.Add("Categorías", gestor.ObtenerTotalCategorias());
                datos.Add("Clientes", gestor.ObtenerTotalClientes());
                datos.Add("Vendedores", gestor.ObtenerTotalVendedores());

                // Limpiar los datos anteriores del gráfico para evitar duplicados
                chartGeneral.Series["Datos Registrados"].Points.Clear();

                // Iterar sobre los datos y añadirlos al gráfico (nombre en eje X, cantidad en eje Y)
                foreach (var item in datos)
                {
                    chartGeneral.Series["Datos Registrados"].Points.AddXY(item.Key, item.Value);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el gráfico general" + ex.Message);
            }
        }

        private void ActChartSucursales()
        {
            try
            {
                // Obtener el estado de las sucursales (cuántas activas y cuántas inactivas)
                var datos = gestor.ObtenerEstadoSucursales();
                var serie = chartSucursales.Series["Series"];
                // Limpiar los puntos anteriores
                serie.Points.Clear();

                // Añadir los datos del estado de sucursales al gráfico
                foreach (var item in datos)
                {
                    serie.Points.AddXY(item.Key, item.Value);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el gráfico de sucursales" + ex.Message);
            }
        }

        private void ActChartVentas()
        {
            try
            {
                // Obtener el monto total de ventas por cada mes del año
                var ventasPorMes = gestor.ObtenerVentasMensuales();
                var serie = chartVentas.Series["Ventas"];
                // Limpiar los puntos anteriores del gráfico
                serie.Points.Clear();

                // Iterar sobre los meses y añadir el monto de ventas de cada mes
                foreach (var entrega in ventasPorMes)
                {
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
                // Obtener la cantidad de clientes registrados por cada mes del último año
                var datos = gestor.ObtenerRegistrosClientesPorMes();
                var serie = chartClientes.Series["Clientes Registrados en el Ultimo Año"];
                // Limpiar los puntos anteriores
                serie.Points.Clear();

                // Añadir un punto por cada mes con la cantidad de clientes registrados en ese mes
                foreach (var registro in datos)
                {
                    serie.Points.AddXY(registro.Key, (double)registro.Value);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la línea de tiempo de clientes: " + ex.Message);
            }
        }

        private void FrmContHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logger.AlPublicarMensaje -= MetodoReceptorLog;
        }
    }
}
