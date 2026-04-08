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
        GestorConsultas gestor = new GestorConsultas();

        public int siguienteId()
        {
            return gestor.ObtenerProximoIdCat();
        }

        
    }
}
