/*
•	UNED I Cuatrimestre 2026
•	Proyecto 2, Gestion De AutoMarket.
•	Estudiante: Josue Jimenez Barrantes
•	Fecha Finalizacion:  11 Abril de 2026
•	Componente de interfaz para registrar nuevas sucursales
*/

using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using Logica;
using Utilidades;

namespace AppServidor.Presentacion.Presentacion_Registro
{
    public partial class ucRegistroSuc : UserControl
    {
        public ucRegistroSuc()
        {
            InitializeComponent();
        }

        private void ucRegistroSuc_Load(object sender, EventArgs e)
        {
            txtId.Content = "AutoGenerado : " + siguienteId();
        }

        //gestor para insertar los datos y para consultar proximo ID
        GestorConsultas consultas = new GestorConsultas();
        GestorRegistros registros = new GestorRegistros();

        public int siguienteId()
        {
            return consultas.ObtenerProximoIdSuc();
        }

        //metodo para registrar los datos ingresados
        public void registrarDatos()
        {
            // validar que no haya campos vacíos o sin seleccionar
            if (string.IsNullOrWhiteSpace(txtNombreSuc.Content) ||
                string.IsNullOrWhiteSpace(txtDireccion.Content) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtIdVend.Text)) 
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios antes de continuar.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtIdVend.Text.Trim(), out int idVendedor))
            {
                MessageBox.Show("El ID del vendedor asignado debe ser un número válido.", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que se haya seleccionado un estado
            if (!btnActiva.Checked && !btnInactiva.Checked)
            {
                MessageBox.Show("Por favor, seleccione el estado de la sucursal (Activa o Inactiva).", "Estado requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Sucursal s = new Sucursal
                {
                    IdSuc = siguienteId(),
                    NombreSuc = txtNombreSuc.Content.Trim(),
                    Direccion = txtDireccion.Content.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Encargado = new Vendedor { IdVend = idVendedor },
                    Activo = btnActiva.Checked
                };

                // InsertarSucursal lanza una excepcion si las reglas de los datos no se cumplen
                if (registros.InsertarSucursal(s))
                {
                    MessageBox.Show("Sucursal registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Logger.Escribir("Registro Exitoso De Sucursal", 1);

                    // Limpiar campos después del registro y actualizar el ID
                    txtNombreSuc.Content = "";
                    txtDireccion.Content = "";
                    txtTelefono.Text = "";
                    txtIdVend.Text = "";
                    btnActiva.Checked = false;
                    btnInactiva.Checked = false;
                    txtId.Content = "AutoGenerado : " + siguienteId();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la sucursal en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Logger.Escribir("Intento Fallido De Registro De Sucursal en BD", 3);
                }
            }
            catch (ArgumentException ex)
            {
                // Atrapa las validaciones del gestor de registros
                MessageBox.Show(ex.Message, "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Logger.Escribir("Validación fallida al registrar datos: " + ex.Message, 4);
            }
            catch (Exception ex)
            {
                // Atrapa errores del sistema (Caída de base de datos, error SQL, etc)
                MessageBox.Show("Ocurrió un error inesperado en el sistema." + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Escribir("Error crítico al registrar sucursal: " + ex.Message, 3);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            registrarDatos();
        }
    }
}
