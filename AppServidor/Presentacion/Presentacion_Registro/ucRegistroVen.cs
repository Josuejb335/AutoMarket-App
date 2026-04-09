using CapaEntidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades;

namespace AppServidor.Presentacion.Presentacion_Registro
{
    public partial class ucRegistroVen : UserControl
    {
        public ucRegistroVen()
        {
            InitializeComponent();
        }

        private void ucRegistroVen_Load(object sender, EventArgs e)
        {
            txtId.Content = "AutoGenerado : " + siguienteId();
        }

        //gestor para insertar los datos y para consultar proximo ID
        GestorConsultas consultas = new GestorConsultas();
        GestorRegistros registros = new GestorRegistros();

        public int siguienteId()
        {
            return consultas.ObtenerProximoIdVend();
        }

        //metodo para registrar los datos ingresados
        public void registrarDatos()
        {
            // validar que no haya campos vacíos o sin seleccionar
            if (string.IsNullOrWhiteSpace(txtIdentificacion.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text)) 
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios antes de continuar.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Vendedor v = new Vendedor
                {
                    IdVend = siguienteId(),
                    Ident = txtIdentificacion.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    FechaNacimiento = fechaNacimiento.Content,
                    FechaIngreso = cuiCalendarDatePicker1.Content,
                    Telefono = txtTelefono.Text.Trim()
                };

                // InsertarVendedor lanza una excepcion si las reglas de los datos no se cumplen
                if (registros.InsertarVendedor(v))
                {
                    MessageBox.Show("Vendedor registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Logger.Escribir("Registro Exitoso De Vendedor", Color.Green);

                    // Limpiar campos después del registro y actualizar el ID
                    txtIdentificacion.Text = "";
                    txtNombre.Text = "";
                    txtTelefono.Text = "";
                    fechaNacimiento.Content = DateTime.Now;
                    cuiCalendarDatePicker1.Content = DateTime.Now;
                    txtId.Content = "AutoGenerado : " + siguienteId();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el vendedor en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Logger.Escribir("Intento Fallido De Registro De Vendedor en BD", Color.Red);
                }
            }
            catch (ArgumentException ex)
            {
                // Atrapa las validaciones del gestor de registros
                MessageBox.Show(ex.Message, "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Logger.Escribir("Validación fallida al registrar datos: " + ex.Message, Color.Yellow);
            }
            catch (Exception ex)
            {
                // Atrapa errores del sistema (Caída de base de datos, error SQL, etc)
                MessageBox.Show("Ocurrió un error inesperado en el sistema." + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Escribir("Error crítico al registrar vendedor: " + ex.Message, Color.Red);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            registrarDatos();
        }
    }
}
