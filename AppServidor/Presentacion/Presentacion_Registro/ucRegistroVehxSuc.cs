using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using Logica;
using Utilidades;

namespace AppServidor.Presentacion.Presentacion_Registro
{
    public partial class ucRegistroVehxSuc : UserControl
    {
        public ucRegistroVehxSuc()
        {
            InitializeComponent();
        }

        GestorRegistros registros = new GestorRegistros();

        public void registrarDatos()
        {
            // Validar que no haya campos vacíos
            if (string.IsNullOrWhiteSpace(txtIdSuc.Content) ||
                string.IsNullOrWhiteSpace(txtIdVeh.Content) ||
                string.IsNullOrWhiteSpace(txtCantidad.Content))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios antes de continuar.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar formato de IDs y cantidad
            if (!int.TryParse(txtIdSuc.Content.Trim(), out int idSucursal))
            {
                MessageBox.Show("El ID de la Sucursal debe ser un número válido.", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtIdVeh.Content.Trim(), out int idVehiculo))
            {
                MessageBox.Show("El ID del Vehículo debe ser un número válido.", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCantidad.Content.Trim(), out int cantidad))
            {
                MessageBox.Show("La Cantidad debe ser un número válido.", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                VehiculoxSucursal vxs = new VehiculoxSucursal
                {
                    SucursalAsociada = new Sucursal { IdSuc = idSucursal },
                    VehiculoAsociado = new Vehiculo { IdVehi = idVehiculo },
                    Cantidad = cantidad
                };

                if (registros.InsertarVehiculoxSucursal(vxs))
                {
                    MessageBox.Show("Vehículo asignado a sucursal exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Logger.Escribir("Registro Exitoso De VehiculoxSucursal", Color.Green);

                    // Limpiar campos
                    txtIdSuc.Content = "";
                    txtIdVeh.Content = "";
                    txtCantidad.Content = "";
                }
                else
                {
                    MessageBox.Show("No se pudo asignar el Vehículo a la Sucursal en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Logger.Escribir("Intento Fallido De Registro De VehiculoxSucursal en BD", Color.Red);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Logger.Escribir("Validación fallida al registrar datos: " + ex.Message, Color.Yellow);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado en el sistema.\n\nAtención: Vehículo podría ya estar en esta Sucursal." + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Escribir("Error crítico al registrar VehiculoxSucursal: " + ex.Message, Color.Red);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            registrarDatos();
        }
    }
}
