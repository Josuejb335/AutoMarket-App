using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AppCliente.Red;
using Comunicacion;
using CapaEntidades;
using Newtonsoft.Json;

namespace AppCliente.Presentacion
{
    public partial class UcCompra : UserControl
    {
        private List<Sucursal> sucursales;
        private List<VehiculoxSucursal> vehiculosSucursal;

        public UcCompra()
        {
            InitializeComponent();
        }

        private void UcCompra_Load(object sender, EventArgs e)
        {
            CargarSucursales();
        }

        private void CargarSucursales()
        {
            try
            {
                var formPrincipal = (FrmMenuCliente)this.FindForm();
                Mensaje peticion = new Mensaje { Accion = "CONSULTAR_SUCURSALES", Datos = "" };
                Mensaje respuesta = formPrincipal.ClienteTCP.EnviarPeticion(peticion);

                if (respuesta.Tipo == "OK")
                {
                    sucursales = JsonConvert.DeserializeObject<List<Sucursal>>(respuesta.Datos) ?? new List<Sucursal>();
                    
                    // Almacenar temporalmente los strings
                    var listaItems = new List<string>();
                    foreach (var s in sucursales)
                    {
                        if (s.Activo) // Solo mostrar sucursales activas
                        {
                            listaItems.Add($"{s.IdSuc} - {s.NombreSuc}");
                        }
                    }
                    cmbSuc.Items = listaItems.ToArray();
                }
                else
                {
                    MessageBox.Show("Error al cargar sucursales: " + respuesta.Datos, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar sucursales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbSuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSuc.SelectedIndex == -1) return;

            try
            {
                string seleccion = cmbSuc.Items[cmbSuc.SelectedIndex].ToString();
                int idSucursal = int.Parse(seleccion.Split('-')[0].Trim());

                var formPrincipal = (FrmMenuCliente)this.FindForm();
                Mensaje peticion = new Mensaje { Accion = "CONSULTAR_VEHICULOS_SUCURSAL", Datos = idSucursal.ToString() };
                Mensaje respuesta = formPrincipal.ClienteTCP.EnviarPeticion(peticion);

                if (respuesta.Tipo == "OK")
                {
                    vehiculosSucursal = JsonConvert.DeserializeObject<List<VehiculoxSucursal>>(respuesta.Datos);
                    
                    tabla.DataSource = null;
                    if (vehiculosSucursal != null && vehiculosSucursal.Count > 0)
                    {
                        var dataSource = vehiculosSucursal.Select(vs => new {
                            ID_Vehiculo = vs.VehiculoAsociado.IdVehi,
                            Marca = vs.VehiculoAsociado.Marca,
                            Modelo = vs.VehiculoAsociado.Modelo,
                            Precio = vs.VehiculoAsociado.Precio.ToString("C"),
                            Cantidad_Disponible = vs.Cantidad
                        }).ToList();
                        
                        tabla.DataSource = dataSource;
                        tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                    else
                    {
                        MessageBox.Show("No hay vehículos disponibles en la sucursal seleccionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Error al consultar vehículos: " + respuesta.Datos, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar vehículos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (cmbSuc.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una sucursal.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tabla.SelectedRows.Count == 0 && tabla.SelectedCells.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un vehículo de la tabla para comprar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int rowIndex = tabla.SelectedCells.Count > 0 ? tabla.SelectedCells[0].RowIndex : tabla.SelectedRows[0].Index;
                int idVehiculo = (int)tabla.Rows[rowIndex].Cells["ID_Vehiculo"].Value;

                var vehiculoSeleccionado = vehiculosSucursal.FirstOrDefault(vs => vs.VehiculoAsociado.IdVehi == idVehiculo);
                if (vehiculoSeleccionado == null) return;

                if (vehiculoSeleccionado.Cantidad <= 0)
                {
                    MessageBox.Show("No hay stock disponible de este vehículo en la sucursal seleccionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string seleccionSucursal = cmbSuc.Items[cmbSuc.SelectedIndex].ToString();
                int idSucursal = int.Parse(seleccionSucursal.Split('-')[0].Trim());

                // Enviar la compra al servidor
                var formPrincipal = (FrmMenuCliente)this.FindForm();
                
                // Formar objeto venta básico con los datos que tenemos a mano
                var peticionCompra = new
                {
                    IdSucursal = idSucursal,
                    IdVehiculo = idVehiculo,
                    Monto = vehiculoSeleccionado.VehiculoAsociado.Precio
                };

                string JSONCompra = JsonConvert.SerializeObject(peticionCompra);
                Mensaje peticion = new Mensaje { Accion = "COMPRAR_VEHICULO", Datos = JSONCompra };
                
                Mensaje respuesta = formPrincipal.ClienteTCP.EnviarPeticion(peticion);

                if (respuesta.Tipo == "OK")
                {
                    MessageBox.Show("¡Compra realizada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Recargar tabla de vehículos
                    cmbSuc_SelectedIndexChanged(null, null); 
                }
                else
                {
                    MessageBox.Show("No se pudo realizar la compra: " + respuesta.Datos, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar la compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
