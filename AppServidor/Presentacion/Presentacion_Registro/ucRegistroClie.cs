/*
•	UNED I Cuatrimestre 2026
•	Proyecto 2, Gestion De AutoMarket.
•	Estudiante: Josue Jimenez Barrantes
•	Fecha Finalizacion:  11 Abril de 2026
•	Componente de interfaz para registrar nuevos clientes
*/

using System;
using System.Collections.Generic;
using System.Drawing;
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
    public partial class ucRegistroClie : UserControl
    {
        public ucRegistroClie()
        {
            InitializeComponent();
        }

        private void ucRegistroClie_Load(object sender, EventArgs e)
        {
            txtId.Content = "AutoGenerado : " + siguienteId();
        }

        //gestor para insertar los datos y para consultar proximo ID
        GestorConsultas consultas = new GestorConsultas();
        GestorRegistros registros = new GestorRegistros();

        public int siguienteId()
        {
            return consultas.ObtenerProximoIdClie();
        }

        //metodo para registrar los datos ingresados
        public void registrarDatos()
        {
            // validar que no haya campos vacíos o sin seleccionar
            if (string.IsNullOrWhiteSpace(txtIdentificacion.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Content)) 
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios antes de continuar.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que se haya seleccionado un estado
            if (!btnActiva.Checked && !btnInactiva.Checked)
            {
                MessageBox.Show("Por favor, seleccione el estado del cliente (Activo o Inactivo).", "Estado requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Cliente c = new Cliente
                {
                    IdCliente = siguienteId(),
                    Ident = txtIdentificacion.Text.Trim(),
                    Nombre = txtNombre.Content.Trim(),
                    FechaNacimiento = fechaNacimiento.Content,
                    FechaRegistro = cuiCalendarDatePicker1.Content,
                    Activo = btnActiva.Checked
                };

                // InsertarCliente lanza una excepcion si las reglas de los datos no se cumplen
                if (registros.InsertarCliente(c))
                {
                    MessageBox.Show("Cliente registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Logger.Escribir("Registro Exitoso De Cliente", 1);

                    // Limpiar campos después del registro y actualizar el ID
                    txtIdentificacion.Text = "";
                    txtNombre.Content = "";
                    fechaNacimiento.Content = DateTime.Now;
                    cuiCalendarDatePicker1.Content = DateTime.Now;
                    btnActiva.Checked = false;
                    btnInactiva.Checked = false;
                    txtId.Content = "AutoGenerado : " + siguienteId();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el cliente en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Logger.Escribir("Intento Fallido De Registro De Cliente en BD", 3);
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
                Logger.Escribir("Error crítico al registrar cliente: " + ex.Message, 3);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            registrarDatos();
        }
    }
}
