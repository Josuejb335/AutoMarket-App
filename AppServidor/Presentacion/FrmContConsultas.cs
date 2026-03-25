using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using CapaEntidades;

namespace AppServidor.Presentacion
{
    public partial class FrmContConsultas : Form
    {
        // Instanciar el gestor de logica
        private GestorConsultas gestor = new GestorConsultas();

        // Variables de paginación
        private int paginaActual = 1;
        private int tamanoPagina = 18; // 18 registros por página
        private int totalRegistros = 0;

        public FrmContConsultas()
        {
            InitializeComponent();
            
            // Suscribir eventos de los controles de la UI
            btnAnterior.Click += BtnAnterior_Click;
            btnSiguiente.Click += BtnSiguiente_Click;
            btnBuscar.Click += BtnBuscar_Click;
            
            // Cargar datos por defecto al abrir el form
            this.Load += (s, e) => CargarDatos();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            paginaActual = 1; // Al buscar o cambiar de tab, se regresa a la p1
            CargarDatos();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            if (paginaActual > 1)
            {
                paginaActual--;
                CargarDatos();
            }
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            int maxPaginas = (int)Math.Ceiling((double)totalRegistros / tamanoPagina);
            if (paginaActual < maxPaginas)
            {
                paginaActual++;
                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            string entidad = cmbEntidad.SelectedItem?.ToString() ?? "Categoria";
            string criterioUI = cmbOrden.SelectedItem?.ToString() ?? "ID";
            string ordenSQL = ObtenerColumnaOrden(entidad, criterioUI);

            try
            {
                // Limpiar la tabla antes de bindear nuevos datos
                tabla.DataSource = null;

                switch (entidad)
                {
                    case "Categoria":
                        totalRegistros = gestor.ObtenerTotalCategorias();
                        tabla.DataSource = gestor.ListarCategoriasPaginado(paginaActual, tamanoPagina, ordenSQL);
                        break;
                    case "Cliente":
                        totalRegistros = gestor.ObtenerTotalClientes();
                        tabla.DataSource = gestor.ListarClientesPaginado(paginaActual, tamanoPagina, ordenSQL);
                        break;
                    case "Sucursal":
                        totalRegistros = gestor.ObtenerTotalSucursales();
                        tabla.DataSource = gestor.ListarSucursalesPaginado(paginaActual, tamanoPagina, ordenSQL);
                        break;
                    case "Vehiculo":
                        totalRegistros = gestor.ObtenerTotalVehiculos();
                        tabla.DataSource = gestor.ListarVehiculosPaginado(paginaActual, tamanoPagina, ordenSQL);
                        break;
                    case "Vendedor":
                        totalRegistros = gestor.ObtenerTotalVendedores();
                        tabla.DataSource = gestor.ListarVendedoresPaginado(paginaActual, tamanoPagina, ordenSQL);
                        break;
                    case "Venta":
                        totalRegistros = gestor.ObtenerTotalVentas();
                        tabla.DataSource = gestor.ListarVentasPaginado(paginaActual, tamanoPagina, ordenSQL);
                        break;
                    default:
                        MessageBox.Show("Esta entidad aún no está configurada para vista paginada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        totalRegistros = 0;
                        break;
                }

                formatearTabla();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al consultar la base de datos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ActualizarEstadoBotones();
        }

        // Metodo seguro para traducir la opción del ComboBox a una columna real de base de datos
        // Y evitar vulnerabilidad de inyección SQL
        private string ObtenerColumnaOrden(string entidad, string criterio)
        {
            if (criterio == "ID")
            {
                switch (entidad)
                {
                    case "Categoria": return "IdCategoria";
                    case "Cliente": return "IdCliente";
                    case "Sucursal": return "IdSucursal";
                    case "Vehiculo": return "IdVehiculo";
                    case "Vendedor": return "IdVendedor";
                    case "Venta": return "IdVenta";
                    default: return "1"; // Fallback seguro
                }
            }
            else if (criterio == "Nombre")
            {
                switch (entidad)
                {
                    case "Categoria": return "NombreCategoria";
                    case "Cliente": return "NombreCompleto";
                    case "Sucursal": return "Nombre";
                    case "Vehiculo": return "Marca"; // Vehiculo no tiene "Nombre", se usa Marca
                    case "Vendedor": return "NombreCompleto";
                    case "Venta": return "IdVenta"; // Venta no tiene nombre
                    default: return "1"; 
                }
            }
            else if (criterio == "Fecha")
            {
                switch (entidad)
                {
                    case "Cliente": return "FechaRegistro";
                    case "Vendedor": return "FechaIngreso";
                    case "Venta": return "FechaVenta";
                    case "Vehiculo": return "Ano"; // Vehiculo no tiene fecha, usamos Año
                    // Entidades sin fechas caen en su ID por defecto para que no se caiga SQL
                    case "Categoria": return "IdCategoria";
                    case "Sucursal": return "IdSucursal";
                    default: return "1";
                }
            }

            return "1"; // Si por alguna razón nada coincide, "ORDER BY 1" es válido en SQL y no explota
        }

        private void ActualizarEstadoBotones()
        {
            int maxPaginas = (int)Math.Ceiling((double)totalRegistros / tamanoPagina);
            btnAnterior.Enabled = (paginaActual > 1);
            btnSiguiente.Enabled = (paginaActual < maxPaginas);
        }

        private void formatearTabla()
        {
            // Ocultar nombres de propiedades que son objetos de otras clases para que no salgan raras (CapaEntidades.Xxxx) en las columnas de la DataGridView
            string[] columnasAEvitar = { "Cat", "Suc", "Veh", "Encargado", "Clie" };

            foreach (DataGridViewColumn col in tabla.Columns)
            {
                if (columnasAEvitar.Contains(col.Name))
                {
                    col.Visible = false;
                }
            }
            
            // Opcional: autoajustar tablas
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
