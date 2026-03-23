using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
//se usa para obtener informacion del sistema como la RAM Total del sistema
using Microsoft.VisualBasic.Devices;

namespace AppServidor
{
    public partial class ContRecursos : Form
    {
        public ContRecursos()
        {
            InitializeComponent();
            ObtenerRamTotal();
        }

        private PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        private PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");
        private float ramTotalMB;

        private void ObtenerRamTotal()
        {
            ComputerInfo info = new ComputerInfo();
            // convertir de Mb a MB
            ulong totalBytes = info.TotalPhysicalMemory;
            ramTotalMB = totalBytes / 1024 / 1024;
        }

        private void ActualizarCPU()
        {
            try
            {
                float valorCPU = cpuCounter.NextValue();

                // Actualizar Label
                lblCPU.Text = string.Format("Uso: {0:0.0}%", valorCPU);

                // Actualizar Gráfico
                var serie = chartCPU.Series["CPU"];
                serie.Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), valorCPU);

                if (serie.Points.Count > 20) serie.Points.RemoveAt(0);
            }
            catch { }
        }

        private void ActualizarRAM()
        {
            try
            {
                float ramDisponible = ramCounter.NextValue();
                // Cálculo automático basado en la detección inicial
                float ramUsoPorcentaje = ((ramTotalMB - ramDisponible) / ramTotalMB) * 100;
                float ramUsadaMB = ramTotalMB - ramDisponible;

                // Actualizar Label con MB usados y porcentaje
                lblRAM.Text = string.Format("Uso: {0:0.0}% ({1:0} MB / {2:0} MB)",
                                            ramUsoPorcentaje, ramUsadaMB, ramTotalMB);

                // Actualizar Gráfico
                var serie = chartRAM.Series["RAM"];
                serie.Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), ramUsoPorcentaje);

                if (serie.Points.Count > 20) serie.Points.RemoveAt(0);
            }
            catch { }
        }
        private void timerRecursos_Tick(object sender, EventArgs e)
        {
            ActualizarCPU();
            ActualizarRAM();
        }

        private void lblRAM_Click(object sender, EventArgs e)
        {

        }

        private void ContRecursos_Load(object sender, EventArgs e)
        {
            // Forzar que el eje Y siempre sea de 0 a 100
            chartCPU.ChartAreas[0].AxisY.Maximum = 100;
            chartCPU.ChartAreas[0].AxisY.Minimum = 0;

            chartRAM.ChartAreas[0].AxisY.Maximum = 100;
            chartRAM.ChartAreas[0].AxisY.Minimum = 0;
        }
    }
}
