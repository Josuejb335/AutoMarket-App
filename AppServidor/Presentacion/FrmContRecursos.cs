
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
            float valorCpu = MonitorHardware.Cpu.NextValue();
            //valor label
            lblCPU.Text = $"Uso: {valorCpu:0.0}%";
            //chart
            var sCpu = chartCPU.Series["CPU"];
            sCpu.Points.AddXY(tiempo, valorCpu);
            if (sCpu.Points.Count > 20) sCpu.Points.RemoveAt(0);

            //RAM 
            //valores ram
            float libreRam = MonitorHardware.Ram.NextValue();
            float totalRam = MonitorHardware.RamTotalMB;
            //calculo uso de ram
            float usoRamPct = ((totalRam - libreRam) / totalRam) * 100;

            //valor label
            lblRAM.Text = $"Uso: {usoRamPct:0.1}% ({(totalRam - libreRam):0} MB / {totalRam:0} MB)";
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
