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
using System.Windows.Forms.DataVisualization.Charting;
using Utilidades;

namespace AppServidor.Presentacion.Presentacion_Registro
{
    public partial class ucRegistroVeh : UserControl
    {
        public ucRegistroVeh()
        {
            InitializeComponent();
        }

        private void ucRegistroVeh_Load(object sender, EventArgs e)
        {
            txtId.Content = "AutoGenerado : " + siguienteId();
        }

        //gestor para insertar los datos y para consultar proximo ID
        GestorConsultas consultas = new GestorConsultas();
        GestorRegistros registros = new GestorRegistros();


        public int siguienteId()
        {
            return consultas.ObtenerProximoIdVeh();
        }

        //metodo para registrar los datos ingresados
        public void registrarDatos()
        {
            // 1. Validar que no haya campos vacíos o sin seleccionar
            if (string.IsNullOrWhiteSpace(txtMarca.Text) ||
                string.IsNullOrWhiteSpace(txtModelo.Text) ||
                string.IsNullOrWhiteSpace(txtAnio.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                (!btnNuevo.Checked && !btnUsado.Checked))
            {
                MessageBox.Show("Por favor, complete todos los campos y seleccione el estado antes de continuar.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validar que los campos numéricos tengan el formato correcto (evitar que introduzcan letras)
            if (!int.TryParse(txtAnio.Text, out int anio) || 
                !decimal.TryParse(txtPrecio.Text, out decimal precio) || 
                !int.TryParse(txtCategoria.Text, out int idCat))
            {
                MessageBox.Show("Por favor, verifique que Año, Precio y Categoría contengan números válidos (no letras o símbolos).", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Vehiculo v = new Vehiculo
                {

                    IdVehi = siguienteId(),
                    Marca = txtMarca.Text.Trim(),
                    Modelo = txtModelo.Text.Trim(),
                    Anio = anio,
                    Precio = precio,
                    Cat = new Categoria { IdCat = idCat },
                    // Obtener estado de los botones
                    Estado = btnNuevo.Checked ? 'N' : 'U'
                };

                // InsertarVehiculo lanza una excepcion si las reglas de los datos no se cumplen
                if (registros.InsertarVehiculo(v))
                {
                    MessageBox.Show("Vehículo registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Logger.Escribir("Registro Exitoso De Vehículo", Color.Green);

                    // Limpiar campos después del registro y actualizar el ID
                    txtMarca.Text = "";
                    txtModelo.Text = "";
                    txtAnio.Text = "";
                    txtPrecio.Text = "";
                    txtId.Content = "AutoGenerado : " + siguienteId();
                    txtCategoria.Text = "";
                    btnNuevo.Checked = false;
                    btnUsado.Checked = false;
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el vehículo en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Logger.Escribir("Intento Fallido De Registro De Vehículo en BD", Color.Red);

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
                MessageBox.Show("Ocurrió un error inesperado en el sistema (verifique que los números sean válidos)." + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Escribir("Error crítico al registrar vehículo: " + ex.Message, Color.Red);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            registrarDatos();
        }
    }
}
