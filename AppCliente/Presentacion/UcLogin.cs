/*
•	UNED I Cuatrimestre 2026
•	Proyecto 2, Gestion De AutoMarket.
•	Estudiante: Josue Jimenez Barrantes
•	Fecha Finalizacion:  11 Abril de 2026
•	Componente de interfaz que permite al usuario iniciar sesión verificando su identificación con el servidor
*/

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
using AppCliente.Red;
using Comunicacion;

namespace AppCliente.Presentacion
{
    public partial class UcLogin : UserControl
    {
        public UcLogin()
        {
            InitializeComponent();
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            string idCliente = txtNombre.Content.Trim();

            if (string.IsNullOrEmpty(idCliente))
            {
                MessageBox.Show("Por favor digite su ID de Cliente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el formulario principal para usar su socket ya instanciado
            var formPrincipal = (FrmMenuCliente)this.FindForm();

            // 1. Intentar conectar (esto registra al cliente temporalmente o inicia conexión)
            if (!formPrincipal.ClienteTCP.Conectar(idCliente))
            {
                MessageBox.Show("No se pudo conectar con el servidor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Enviar petición para verificar el ID
            Mensaje peticion = new Mensaje { Accion = "VERIFICAR_ID", Datos = idCliente };
            Mensaje respuesta = formPrincipal.ClienteTCP.EnviarPeticion(peticion);

            if (respuesta != null && respuesta.Tipo == "OK" && respuesta.Datos == "SI")
            {
                MessageBox.Show("Sesión iniciada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Obtener el panel contenedor el que contiene a este UserControl
                Panel pnlContenedor = (Panel)this.Parent;

                // abrir el UserControl UcHome en el panel contenedor
                UtilForms.AbrirUserControlEnPanel(pnlContenedor, new UcHome());
            }
            else
            {
                MessageBox.Show("El ID no existe o no pudo ser verificado: " + (respuesta?.Datos ?? "Sin respuesta"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                formPrincipal.ClienteTCP.Desconectar();
            }
        }
    }
}
