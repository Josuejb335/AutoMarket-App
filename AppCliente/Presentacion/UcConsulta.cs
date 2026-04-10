using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCliente.Red;
using Comunicacion;
using CapaEntidades;
using Newtonsoft.Json;

namespace AppCliente.Presentacion
{
    public partial class UcConsulta : UserControl
    {
        public UcConsulta()
        {
            InitializeComponent();
        }

        private void UcConsulta_Load(object sender, EventArgs e)
        {
            CargarMisCompras();
        }

        private void CargarMisCompras()
        {
            try
            {
                var formPrincipal = (FrmMenuCliente)this.FindForm();
                
                // Enviar la petición al servidor sin necesidad de enviarle mi propia id, 
                // ya que el servidor TCP guarda mi estado de sesion
                Mensaje peticion = new Mensaje { Accion = "CONSULTAR_MIS_COMPRAS", Datos = "" };
                Mensaje respuesta = formPrincipal.ClienteTCP.EnviarPeticion(peticion);

                if (respuesta.Tipo == "OK")
                {
                    List<Venta> compras = JsonConvert.DeserializeObject<List<Venta>>(respuesta.Datos);
                    
                    tabla.DataSource = null;
                    if (compras != null && compras.Count > 0)
                    {
                        var data = compras.Select(c => new
                        {
                            ID_Venta = c.IdVenta,
                            Fecha = c.FechaVenta.ToString("dd/MM/yyyy"),
                            Monto = c.Monto.ToString("C"),
                            Vehículo = c.Veh.Marca + " " + c.Veh.Modelo,
                            Categoría = c.Veh.Cat.NombreCat,
                            Sucursal = c.Suc.NombreSuc
                        }).ToList();

                        tabla.DataSource = data;
                        tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron compras registradas con su usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No se consultaron las compras: " + respuesta.Datos, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sucedió un error al cargar su registro de compras: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnComprar_Click(object sender, EventArgs e)
        {
            // Puedes usar este botón como un recargar datos en el User Control (ya que se llama igual en el Designer)
            CargarMisCompras();
        }
    }
}
