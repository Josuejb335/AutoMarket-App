/*
•	UNED I Cuatrimestre 2026
•	Proyecto 2, Gestion De AutoMarket.
•	Estudiante: Josue Jimenez Barrantes
•	Fecha Finalizacion:  11 Abril de 2026
•	Clase estática para monitorear recursos de hardware del sistema (CPU, RAM, red)
*/

using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;

namespace Utilidades
{
    public static class MonitorHardware
    {
        [StructLayout(LayoutKind.Sequential)]
        private class MEMORYSTATUSEX
        {
            public uint dwLength;
            public uint dwMemoryLoad;
            public ulong ullTotalPhys;
            public ulong ullAvailPhys;
            public ulong ullTotalPageFile;
            public ulong ullAvailPageFile;
            public ulong ullTotalVirtual;
            public ulong ullAvailVirtual;
            public ulong ullAvailExtendedVirtual;
            public MEMORYSTATUSEX()
            {
                this.dwLength = (uint)Marshal.SizeOf(typeof(MEMORYSTATUSEX));
            }
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GlobalMemoryStatusEx([In, Out] MEMORYSTATUSEX lpBuffer);

        // Contadores estaticos
        public static PerformanceCounter Cpu { get; private set; }
        public static PerformanceCounter Ram { get; private set; }
        public static PerformanceCounter RedEnviado { get; private set; }
        public static PerformanceCounter RedRecibido { get; private set; }

        public static float RamTotalMB { get; private set; }

        // Obtener porcentaje de RAM usado (0-100) directamente de la API de Windows
        public static float ObtenerRamPorcentaje() 
        { 
            try
            {
                MEMORYSTATUSEX memStatus = new MEMORYSTATUSEX(); 
                if (GlobalMemoryStatusEx(memStatus)) 
                { 
                    return memStatus.dwMemoryLoad; 
                } 
            }
            catch { }
            return 0f; 
        }

        public static (float usada, float total) ObtenerRamMB() 
        { 
            try
            {
                MEMORYSTATUSEX memStatus = new MEMORYSTATUSEX(); 
                if (GlobalMemoryStatusEx(memStatus)) 
                { 
                    float total = memStatus.ullTotalPhys / 1048576f; 
                    float libre = memStatus.ullAvailPhys / 1048576f; 
                    float usada = total - libre; 
                    if (usada < 0) usada = 0; 
                    return (usada, total); 
                }
            }
            catch { }
            return (0, 0); 
        }

        //metodo para inicializar los sensores al iniciar app para evitar retraso al abrir el form de recursos
        public static void Inicializar()
        {
            // Inicializar RAM primero independientemente para que no falle si CPU produce una excepción
            try
            {
                MEMORYSTATUSEX memStatus = new MEMORYSTATUSEX();
                if (GlobalMemoryStatusEx(memStatus) && memStatus.ullTotalPhys > 0)
                {
                    RamTotalMB = (float)(memStatus.ullTotalPhys / 1048576f);
                }
                else
                {
                    // Fallback
                    ComputerInfo info = new ComputerInfo();
                    RamTotalMB = (float)(info.TotalPhysicalMemory / 1048576f);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error inicializando RAM Total: " + ex.Message);
                RamTotalMB = 8192; // Valor de fallback de seguridad para evitar división por cero
            }

            try
            {
                Cpu = new PerformanceCounter("Processor", "% Processor Time", "_Total");
                // Despertar contador
                Cpu.NextValue();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error inicializando CPU: " + ex.Message);
            }

            try
            {
                Ram = new PerformanceCounter("Memory", "Available MBytes");
            }
            catch { }

            try
            {
                // inicializar RED dinamicamente
                var categoria = new PerformanceCounterCategory("Network Interface");
                // Buscar la primera interfaz que tenga algo de nombre (evitando túneles o loopbacks si es posible)
                string interfazValida = categoria.GetInstanceNames()
                    .FirstOrDefault(n => !n.Contains("Loopback") && !n.Contains("Pseudo"));

                if (interfazValida != null)
                {
                    RedEnviado = new PerformanceCounter("Network Interface", "Bytes Sent/sec", interfazValida);
                    RedRecibido = new PerformanceCounter("Network Interface", "Bytes Received/sec", interfazValida);
                }
            }
            catch { }

            try
            {
                //log monitor
                Logger.Escribir("Monitor de Recursos Iniciado", 5);
            }
            catch { }
        }

        // Obtener MB libres usando API nativa o fallback a PerformanceCounter
        public static float ObtenerRamLibreMB()
        {
            try
            {
                MEMORYSTATUSEX memStatus = new MEMORYSTATUSEX();
                if (GlobalMemoryStatusEx(memStatus) && memStatus.ullAvailPhys > 0)
                {
                    return (float)(memStatus.ullAvailPhys / 1048576f);
                }
            }
            catch { }
            
            // Fallback
            return Ram?.NextValue() ?? 0;
        }
    }
}
