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
            //se cargan los chart al cargar este form y por individual cada uno cada que se registre un evento
            actualizarDashboard();

            //suscribirse al evento de log para mostrarlo en el rtbLog
            Logger.AlPublicarMensaje += MetodoReceptorLog;
        }


        //metodo receptor del evento de log
        private void MetodoReceptorLog(string msg, Color color)
        {
            AgregarLog(msg, color);
        }

        // Encender y apagar el servidor con los botones
        private void btnOn_Click(object sender, EventArgs e)
        {
            try
            {
                // Iniciar y conectar el servidor
                IniciarServidor();
                
                // Bloquear el boton de ON y habilitar el de OFF
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
                
                // Habilitar el boton de ON y bloquear el de OFF
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
            // si el servidor ya existe y está activo no se vuelve a crear
            if (servidorTCP != null)
            {
                servidorTCP.Detener(); // Por si quedo colgado, se limpia antes
            }

            servidorTCP = new ServidorSocket();

            // Iniciar la escucha
            servidorTCP.Iniciar();
        }

        //metodo para agregar texto al rtbLog con color y formato, se llama desde el evento de log
        public void AgregarLog(string mensaje, Color color)
        {
            if (rtbLog.InvokeRequired)
            {
                rtbLog.Invoke(new Action(() => AgregarLog(mensaje, color)));
            }
            else
            {
                // Agregarle la hora al texto
                string linea = $"[{DateTime.Now:HH:mm:ss}] {mensaje}{Environment.NewLine}";

                // ir al final del texto para agregar la nueva línea
                rtbLog.SelectionStart = rtbLog.TextLength;
                rtbLog.SelectionLength = 0;

                // poner el color y escribir
                rtbLog.SelectionColor = color;
                rtbLog.AppendText(linea);

                // resetear color al default 
                rtbLog.SelectionColor = rtbLog.ForeColor;
                rtbLog.ScrollToCaret();

                // limpieza automática (evita que el programa se ponga lento tras mil líneas)
                if (rtbLog.Lines.Length > 150)
                {
                    // mantiene las últimas 100 líneas
                    rtbLog.ReadOnly = false;
                    rtbLog.Select(0, rtbLog.GetFirstCharIndexFromLine(rtbLog.Lines.Length - 100));
                    rtbLog.SelectedText = "";
                    rtbLog.ReadOnly = true;
                }
            }
        }

        // Actulizar todos los charts del dashboard, se llama al cargar el form y cada que se registre un evento para mantener los datos actualizados
        private void actualizarDashboard()
        {
            try
            {
                ActChartGeneral();
                ActChartSucursales();
                ActChartVentas();
                ActChartClientes();
            }
            //recibe las excepciones de cada método individual
            //para mostrar un mensaje específico de error en caso de que falle alguno
            //sin afectar la actualización de los demás charts
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Logger.Escribir("Error al actualizar el dashboard: " + ex.Message, 3);
            }
        }

        //metodo para actualizar chart de Datos registrado
        private void ActChartGeneral()
        {
            try
            {
                //obtener datos individualmente y armar el diccionario 
                var datos = new Dictionary<string, int>();
                datos.Add("Vehículos", gestor.ObtenerTotalVehiculos());
                datos.Add("Sucursales", gestor.ObtenerTotalSucursales());
                datos.Add("Categorías", gestor.ObtenerTotalCategorias());
                datos.Add("Clientes", gestor.ObtenerTotalClientes());
                datos.Add("Vendedores", gestor.ObtenerTotalVendedores());

                //limpiar datos anteriores del chart
                chartGeneral.Series["Datos Registrados"].Points.Clear();

                //cargar datos al chart, item.Key es el nombre (Clientes, Sucursales, etc) y item.Value es el conteo
                foreach (var item in datos)
                {
                    chartGeneral.Series["Datos Registrados"].Points.AddXY(item.Key, item.Value);
                }

            }
            catch ( Exception ex)
            {
                throw new Exception("Error al actualizar el gráfico general" + ex.Message);
            }
        }

        //metodo para actualizar chart Sucursales
        private void ActChartSucursales()
        {
            try
            {
                //obtener datos (diccionario) desde la logica
                var datos = gestor.ObtenerEstadoSucursales();
                //limpiar datos anteriores del chart
                var serie = chartSucursales.Series["Series"];
                serie.Points.Clear();

                // cargar datos al chart, item.Key es el nombre (Activas/Inactivas) y item.Value es el conteo
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

        //metodo para actualizar chart de ventas
        private void ActChartVentas()
        {
            try
            {
                //obtener datos (diccionario) desde la logica
                var ventasPorMes = gestor.ObtenerVentasMensuales();
                var serie = chartVentas.Series["Ventas"];
                //limpiar datos anteriores del chart
                serie.Points.Clear();

                // Cargar los datos al gráfico
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
                //obtener datos (diccionario) desde la logica
                var datos = gestor.ObtenerRegistrosClientesPorMes();
                var serie = chartClientes.Series["Clientes Registrados en el Ultimo Año"];
                serie.Points.Clear();

                // Cargar los datos al gráfico
                foreach (var registro in datos)
                {
                    // Key = Mes, Value = Cantidad de clientes
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
            //desuscribirse del evento al cerrar el form para evitar errores de referencia a controles que ya no existen
            Logger.AlPublicarMensaje -= MetodoReceptorLog;
        }
    }
}
