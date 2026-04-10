using Logica;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Utilidades;

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
        }

        private void FrmContConsultas_Load(object sender, EventArgs e)
        {
            // Cargar datos por defecto al abrir el form
            CargarDatos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
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
                        tabla.DataSource = gestor.ListarCategoriasPaginado(paginaActual, tamanoPagina, ordenSQL).Select(c => new
                        {
                            ID = c.IdCat,
                            Categoria = c.NombreCat,
                            Descripción = c.DescCat
                        }).ToList();
                        Logger.Escribir("Consulta a Tabla Categoria Finalizada Con Exito", 1);
                        break;
                    case "Cliente":
                        totalRegistros = gestor.ObtenerTotalClientes();
                        tabla.DataSource = gestor.ListarClientesPaginado(paginaActual, tamanoPagina, ordenSQL).Select(c => new
                        {
                            ID = c.IdCliente,
                            Identificación = c.Ident,
                            Nombre = c.Nombre,
                            Nacimiento = c.FechaNacimiento.ToString("dd/MM/yyyy"),
                            Registro = c.FechaRegistro.ToString("dd/MM/yyyy"),
                            Activo = c.Activo ? "Sí" : "No"
                        }).ToList();
                        Logger.Escribir("Consulta a Tabla Cliente Finalizada Con Exito", 1);
                        break;
                    case "Sucursal":
                        totalRegistros = gestor.ObtenerTotalSucursales();
                        tabla.DataSource = gestor.ListarSucursalesPaginado(paginaActual, tamanoPagina, ordenSQL).Select(s => new
                        {
                            ID = s.IdSuc,
                            Nombre = s.NombreSuc,
                            Dirección = s.Direccion,
                            Teléfono = s.Telefono,
                            Activo = s.Activo ? "Sí" : "No",
                            Encargado = s.Encargado != null && s.Encargado.IdVend > 0 ? s.Encargado.Nombre : "Sin asignar"
                        }).ToList();
                        Logger.Escribir("Consulta a Tabla Sucursal Finalizada Con Exito", 1);
                        break;
                    case "Vehiculo":
                        totalRegistros = gestor.ObtenerTotalVehiculos();
                        tabla.DataSource = gestor.ListarVehiculosPaginado(paginaActual, tamanoPagina, ordenSQL).Select(v => new
                        {
                            ID = v.IdVehi,
                            Marca = v.Marca,
                            Modelo = v.Modelo,
                            Año = v.Anio,
                            Precio = v.Precio.ToString("C"),
                            Estado = v.Estado.ToString(),
                            Categoría = v.Cat != null ? v.Cat.NombreCat : "Sin categorizar"
                        }).ToList();
                        Logger.Escribir("Consulta a Tabla Vehiculo Finalizada Con Exito", 1);
                        break;
                    case "Vendedor":
                        totalRegistros = gestor.ObtenerTotalVendedores();
                        tabla.DataSource = gestor.ListarVendedoresPaginado(paginaActual, tamanoPagina, ordenSQL).Select(v => new
                        {
                            ID = v.IdVend,
                            Identificación = v.Ident,
                            Nombre = v.Nombre,
                            Nacimiento = v.FechaNacimiento.ToString("dd/MM/yyyy"),
                            Ingreso = v.FechaIngreso.ToString("dd/MM/yyyy"),
                            Teléfono = v.Telefono
                        }).ToList();
                        Logger.Escribir("Consulta a Tabla Vendedor Finalizada Con Exito", 1);
                        break;
                    case "Venta":
                        totalRegistros = gestor.ObtenerTotalVentas();
                        tabla.DataSource = gestor.ListarVentasPaginado(paginaActual, tamanoPagina, ordenSQL).Select(v => new
                        {
                            ID = v.IdVenta,
                            Fecha = v.FechaVenta.ToString("dd/MM/yyyy"),
                            Monto = v.Monto.ToString("C"),
                            Cliente = v.Clie != null ? v.Clie.Nombre : "N/A",
                            Sucursal = v.Suc != null ? v.Suc.NombreSuc : "N/A",
                            Vehículo = v.Veh != null ? $"{v.Veh.Marca} {v.Veh.Modelo}" : "N/A"
                        }).ToList();
                        Logger.Escribir("Consulta a Tabla Venta Finalizada Con Exito", 1);
                        break;
                    case "VehiculoxSucursal":
                        totalRegistros = gestor.ObtenerTotalVehiculosxSucursal();
                        tabla.DataSource = gestor.ListarVehiculosxSucursalPaginado(paginaActual, tamanoPagina, ordenSQL).Select(vs => new
                        {
                            Sucursal = vs.SucursalAsociada != null ? vs.SucursalAsociada.NombreSuc : "N/A",
                            Vehículo = vs.VehiculoAsociado != null ? $"{vs.VehiculoAsociado.Marca} {vs.VehiculoAsociado.Modelo}" : "N/A",
                            Cantidad = vs.Cantidad
                        }).ToList();
                        Logger.Escribir("Consulta a Tabla Vehiculo X Sucursal Finalizada Con Exito", 1);
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
                Logger.Escribir("Error al consultar la base de datos", 3);
            }

            ActualizarEstadoBotones();
        }

        // Metodo para traducir la opción del ComboBox a una columna real de base de datos
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
                    case "VehiculoxSucursal": return "vs.IdSucursal, vs.IdVehiculo";
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
                    case "VehiculoxSucursal": return "s.Nombre, v.Marca"; // Ordenar por nombres
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
                    case "Vehiculo": return "Ano"; // Vehiculo no tiene fecha, se usa Año
                    // Entidades sin fechas caen en su ID por defecto para que no se caiga SQL
                    case "Categoria": return "IdCategoria";
                    case "Sucursal": return "IdSucursal";
                    case "VehiculoxSucursal": return "vs.IdSucursal, vs.IdVehiculo";
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
            //  no es necesario ocultar columnas manualmente porque se filtra que se quiere ver en cargarDatos
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
