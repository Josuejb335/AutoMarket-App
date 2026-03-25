using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public static class MonitorHardware
    {
        // Contadores estaticos
        public static PerformanceCounter Cpu { get; private set; }
        public static PerformanceCounter Ram { get; private set; }
        public static PerformanceCounter RedEnviado { get; private set; }
        public static PerformanceCounter RedRecibido { get; private set; }

        public static float RamTotalMB { get; private set; }

        //metodo para inicializar los sensores al iniciar app para evitar retraso al abrir el form de recursos
        public static void Inicializar()
        {
            try
            {
                // 1. Inicializar CPU y RAM
                Cpu = new PerformanceCounter("Processor", "% Processor Time", "_Total");
                Ram = new PerformanceCounter("Memory", "Available MBytes");

                // Detectar RAM Total
                ComputerInfo info = new ComputerInfo();
                RamTotalMB = info.TotalPhysicalMemory / 1024 / 1024;

                // 2. Inicializar RED dinámicamente
                var categoria = new PerformanceCounterCategory("Network Interface");
                // Buscamos la primera interfaz que tenga algo de nombre (evitando túneles o loopbacks si es posible)
                string interfazValida = categoria.GetInstanceNames()
                    .FirstOrDefault(n => !n.Contains("Loopback") && !n.Contains("Pseudo"));

                if (interfazValida != null)
                {
                    RedEnviado = new PerformanceCounter("Network Interface", "Bytes Sent/sec", interfazValida);
                    RedRecibido = new PerformanceCounter("Network Interface", "Bytes Received/sec", interfazValida);
                }

                // "Despertar" los contadores (la primera lectura siempre es 0)
                Cpu.NextValue();
                //log monitor
                Logger.Escribir("Monitor de Recursos Iniciado", Color.LimeGreen);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error inicializando sensores: " + ex.Message);
            }
        }
    }
}
