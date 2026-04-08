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
using CapaEntidades;


namespace AppServidor.Presentacion.Presentacion_Registro
{
    public partial class ucRegistroCat : UserControl
    {
        public ucRegistroCat()
        {
            InitializeComponent();
        }

        
        private void ucRegistroCat_Load(object sender, EventArgs e)
        {
            txtId.Content = "AutoGenerado : " + siguienteId() ;
        }

        //gestor para insertar los datos y para consultar proximo ID
        GestorConsultas consultas = new GestorConsultas();
        GestorRegistros registros = new GestorRegistros();

        public int siguienteId()
        {
            return consultas.ObtenerProximoIdCat();
        }

        //metodo para registrar los datos ingresados
        public void registrarDatos()
        {
            try
            {
                Categoria c = new Categoria
                {
                    IdCat = siguienteId(),
                    NombreCat = txtNombre.Text?.Trim(),
                    DescCat = txtDescripcion.Text?.Trim()
                };

                // InsertarCategoria lanza una excepcion si las reglas de los datos no se cumplen
                if (registros.InsertarCategoria(c))
                {
                    MessageBox.Show("Categoría registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Logger.Escribir("Registro Exitoso De Categoría", Color.Green);

                    // Limpiar campos después del registro y actualizar el ID
                    txtNombre.Content = "";
                    txtDescripcion.Content = "";
                    txtId.Content = "AutoGenerado : " + siguienteId();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la categoría en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Logger.Escribir("Intento Fallido De Registro De Categoría en BD", Color.Red);
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
                MessageBox.Show("Ocurrió un error inesperado en el sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Escribir("Error crítico al registrar categoría: " + ex.Message, Color.Red);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            registrarDatos();
        }
    }
}
