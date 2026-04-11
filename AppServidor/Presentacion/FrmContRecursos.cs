
/*
•	UNED I Cuatrimestre 2026
•	Proyecto 2, Gestion De AutoMarket.
•	Estudiante: Josue Jimenez Barrantes
•	Fecha Finalizacion:  11 Abril de 2026
•	Formulario que monitorea y muestra en tiempo real los recursos de hardware del sistema (CPU, RAM, Red)
*/

using System;
using System.Windows.Forms;
using Utilidades;
using System.Drawing;

namespace AppServidor
{
    public partial class FrmContRecursos : Form
    {
        public FrmContRecursos()
        {
            InitializeComponent();
        }

        private void ActualizarCharts()
        {
            //hora
            string tiempo = DateTime.Now.ToString("HH:mm:ss");

            //CPU
            float valorCpu = MonitorHardware.Cpu != null ? MonitorHardware.Cpu.NextValue() : 0f;
            
            // FIX: En muchas PCs de Windows, el PerformanceCounter del procesador en "_Total" suma 
            // el uso de cada núcleo individualmente (ej: 8 núcleos al 100% = 800%). Lo dividimos entre los núcleos.
            if (valorCpu > 100f)
            {
                valorCpu = valorCpu / Environment.ProcessorCount;
            }
            
            // Seguro extra para que no pase del framework de la gráfica
            if (valorCpu > 100f) valorCpu = 100f;
            if (valorCpu < 0f) valorCpu = 0f;

            //valor label
            lblCPU.Text = $"Uso: {valorCpu:0.0}%";
            //chart
            var sCpu = chartCPU.Series["CPU"];
            sCpu.Points.AddXY(tiempo, valorCpu);
            if (sCpu.Points.Count > 20) sCpu.Points.RemoveAt(0);

            //RAM 
            float usoRamPct = MonitorHardware.ObtenerRamPorcentaje();
            var ram = MonitorHardware.ObtenerRamMB();

            //valor label
            lblRAM.Text = $"Uso: {ram.usada:0} MB / {ram.total:0} MB";
            //chart
            var sRam = chartRAM.Series["RAM"];
            sRam.Points.AddXY(tiempo, usoRamPct);
            if (sRam.Points.Count > 20) sRam.Points.RemoveAt(0);

            //RED 
            // se usa ?. para evitar errores si no hay tarjeta de red
            //valores red
            float enviado = MonitorHardware.RedEnviado?.NextValue() / 1024 ?? 0;
            float recibido = MonitorHardware.RedRecibido?.NextValue() / 1024 ?? 0;
            //calculo total
            float totalRed = enviado + recibido;
            
            //valor label
            lblRed.Text = $"Enviado: {enviado:0} KB/s | Recibido: {recibido:0} KB/s";
            //chart
            var sRed = chartRed.Series["Red"];
            sRed.Points.AddXY(tiempo, totalRed);
            if (sRed.Points.Count > 20) sRed.Points.RemoveAt(0);
        }

        // actualizar charts cada tick del timer
        private void timerRecursos_Tick(object sender, EventArgs e)
        {
            ActualizarCharts();
        }

        private void ContRecursos_Load(object sender, EventArgs e)
        {
            // Forzar que el eje Y siempre sea de 0 a 100
            chartCPU.ChartAreas[0].AxisY.Maximum = 100;
            chartCPU.ChartAreas[0].AxisY.Minimum = 0;

            chartRAM.ChartAreas[0].AxisY.Maximum = 100;
            chartRAM.ChartAreas[0].AxisY.Minimum = 0;

            chartRed.ChartAreas[0].AxisY.Minimum = 0;
        }
    }
}
