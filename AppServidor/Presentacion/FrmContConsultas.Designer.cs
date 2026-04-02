namespace AppServidor.Presentacion
{
    partial class FrmContConsultas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCont3 = new CuoreUI.Controls.cuiPanel();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.cmbEntidad = new CuoreUI.Controls.cuiComboBox();
            this.cmbOrden = new CuoreUI.Controls.cuiComboBox();
            this.mensajeInfo = new System.Windows.Forms.ToolTip(this.components);
            this.btnSiguiente = new CuoreUI.Controls.cuiButton();
            this.btnAnterior = new CuoreUI.Controls.cuiButton();
            this.btnBuscar = new CuoreUI.Controls.cuiButton();
            this.cuiPictureBox2 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            this.pnlCont3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCont3
            // 
            this.pnlCont3.Controls.Add(this.tabla);
            this.pnlCont3.Location = new System.Drawing.Point(12, 58);
            this.pnlCont3.Name = "pnlCont3";
            this.pnlCont3.OutlineThickness = 1F;
            this.pnlCont3.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.pnlCont3.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.pnlCont3.Rounding = new System.Windows.Forms.Padding(13);
            this.pnlCont3.Size = new System.Drawing.Size(1436, 482);
            this.pnlCont3.TabIndex = 23;
            // 
            // tabla
            // 
            this.tabla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.tabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.tabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(240)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(240)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla.DefaultCellStyle = dataGridViewCellStyle2;
            this.tabla.EnableHeadersVisualStyles = false;
            this.tabla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.tabla.Location = new System.Drawing.Point(12, 14);
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(240)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tabla.RowHeadersVisible = false;
            this.tabla.Size = new System.Drawing.Size(1412, 451);
            this.tabla.TabIndex = 24;
            // 
            // cmbEntidad
            // 
            this.cmbEntidad.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.cmbEntidad.DropDownBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.cmbEntidad.DropDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.cmbEntidad.ExpandArrowColor = System.Drawing.Color.Gray;
            this.cmbEntidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEntidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.cmbEntidad.Items = new string[] {
        "Vehiculo",
        "Categoria",
        "Cliente",
        "Sucursal",
        "VehiculoxSucursal",
        "Vendedor",
        "Venta"};
            this.cmbEntidad.Location = new System.Drawing.Point(12, 12);
            this.cmbEntidad.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbEntidad.MaxDropDownHeight = 240;
            this.cmbEntidad.Name = "cmbEntidad";
            this.cmbEntidad.NoSelectionText = "None";
            this.cmbEntidad.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmbEntidad.OutlineThickness = 1F;
            this.cmbEntidad.Rounding = 18;
            this.cmbEntidad.SelectedIndex = 0;
            this.cmbEntidad.SelectedItem = "Vehiculo";
            this.cmbEntidad.Size = new System.Drawing.Size(150, 38);
            this.cmbEntidad.SortAlphabetically = true;
            this.cmbEntidad.TabIndex = 28;
            this.mensajeInfo.SetToolTip(this.cmbEntidad, "Entidad a Buscar");
            // 
            // cmbOrden
            // 
            this.cmbOrden.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.cmbOrden.DropDownBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.cmbOrden.DropDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.cmbOrden.ExpandArrowColor = System.Drawing.Color.Gray;
            this.cmbOrden.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.cmbOrden.Items = new string[] {
        "Fecha",
        "Nombre",
        "ID"};
            this.cmbOrden.Location = new System.Drawing.Point(172, 12);
            this.cmbOrden.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbOrden.MaxDropDownHeight = 240;
            this.cmbOrden.Name = "cmbOrden";
            this.cmbOrden.NoSelectionText = "None";
            this.cmbOrden.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmbOrden.OutlineThickness = 1F;
            this.cmbOrden.Rounding = 18;
            this.cmbOrden.SelectedIndex = 2;
            this.cmbOrden.SelectedItem = "ID";
            this.cmbOrden.Size = new System.Drawing.Size(150, 38);
            this.cmbOrden.SortAlphabetically = true;
            this.cmbOrden.TabIndex = 29;
            this.mensajeInfo.SetToolTip(this.cmbOrden, "Ordenar por ...");
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.CheckButton = false;
            this.btnSiguiente.Checked = false;
            this.btnSiguiente.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSiguiente.CheckedForeColor = System.Drawing.Color.White;
            this.btnSiguiente.CheckedImageTint = System.Drawing.Color.White;
            this.btnSiguiente.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSiguiente.Content = "Siguiente";
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnSiguiente.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(112)))), ((int)(((byte)(128)))));
            this.btnSiguiente.HoverForeColor = System.Drawing.Color.Black;
            this.btnSiguiente.HoverImageTint = System.Drawing.Color.Black;
            this.btnSiguiente.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSiguiente.Image = global::AppServidor.Properties.Resources.circle_arrow_right;
            this.btnSiguiente.ImageExpand = new System.Drawing.Point(-3, -3);
            this.btnSiguiente.Location = new System.Drawing.Point(144, 546);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.btnSiguiente.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnSiguiente.NormalImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnSiguiente.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSiguiente.OutlineThickness = 1F;
            this.btnSiguiente.Padding = new System.Windows.Forms.Padding(12);
            this.btnSiguiente.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnSiguiente.PressedForeColor = System.Drawing.Color.White;
            this.btnSiguiente.PressedImageTint = System.Drawing.Color.White;
            this.btnSiguiente.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSiguiente.Rounding = new System.Windows.Forms.Padding(15);
            this.btnSiguiente.Size = new System.Drawing.Size(126, 29);
            this.btnSiguiente.TabIndex = 31;
            this.btnSiguiente.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSiguiente.TextPadding = 12;
            this.btnSiguiente.TextSpacing = 2;
            // 
            // btnAnterior
            // 
            this.btnAnterior.CheckButton = false;
            this.btnAnterior.Checked = false;
            this.btnAnterior.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnAnterior.CheckedForeColor = System.Drawing.Color.White;
            this.btnAnterior.CheckedImageTint = System.Drawing.Color.White;
            this.btnAnterior.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnAnterior.Content = "Anterior";
            this.btnAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnterior.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAnterior.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnAnterior.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(112)))), ((int)(((byte)(128)))));
            this.btnAnterior.HoverForeColor = System.Drawing.Color.Black;
            this.btnAnterior.HoverImageTint = System.Drawing.Color.Black;
            this.btnAnterior.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAnterior.Image = global::AppServidor.Properties.Resources.circle_arrow_left;
            this.btnAnterior.ImageExpand = new System.Drawing.Point(-3, -3);
            this.btnAnterior.Location = new System.Drawing.Point(12, 546);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.btnAnterior.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnAnterior.NormalImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnAnterior.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAnterior.OutlineThickness = 1F;
            this.btnAnterior.Padding = new System.Windows.Forms.Padding(12);
            this.btnAnterior.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnAnterior.PressedForeColor = System.Drawing.Color.White;
            this.btnAnterior.PressedImageTint = System.Drawing.Color.White;
            this.btnAnterior.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAnterior.Rounding = new System.Windows.Forms.Padding(15);
            this.btnAnterior.Size = new System.Drawing.Size(126, 29);
            this.btnAnterior.TabIndex = 30;
            this.btnAnterior.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAnterior.TextPadding = 12;
            this.btnAnterior.TextSpacing = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnBuscar.CheckButton = false;
            this.btnBuscar.Checked = false;
            this.btnBuscar.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnBuscar.CheckedForeColor = System.Drawing.Color.White;
            this.btnBuscar.CheckedImageTint = System.Drawing.Color.White;
            this.btnBuscar.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnBuscar.Content = "Consultar";
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnBuscar.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(112)))), ((int)(((byte)(128)))));
            this.btnBuscar.HoverForeColor = System.Drawing.Color.Black;
            this.btnBuscar.HoverImageTint = System.Drawing.Color.Black;
            this.btnBuscar.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBuscar.Image = global::AppServidor.Properties.Resources.search;
            this.btnBuscar.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnBuscar.Location = new System.Drawing.Point(330, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.btnBuscar.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnBuscar.NormalImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnBuscar.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBuscar.OutlineThickness = 1F;
            this.btnBuscar.Padding = new System.Windows.Forms.Padding(12);
            this.btnBuscar.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnBuscar.PressedForeColor = System.Drawing.Color.White;
            this.btnBuscar.PressedImageTint = System.Drawing.Color.White;
            this.btnBuscar.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBuscar.Rounding = new System.Windows.Forms.Padding(18);
            this.btnBuscar.Size = new System.Drawing.Size(150, 38);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnBuscar.TextPadding = 12;
            this.btnBuscar.TextSpacing = 2;
            // 
            // cuiPictureBox2
            // 
            this.cuiPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.cuiPictureBox2.Content = global::AppServidor.Properties.Resources.filtrar;
            this.cuiPictureBox2.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox2.Location = new System.Drawing.Point(180, 21);
            this.cuiPictureBox2.Name = "cuiPictureBox2";
            this.cuiPictureBox2.OutlineThickness = 1F;
            this.cuiPictureBox2.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox2.Rotation = 0;
            this.cuiPictureBox2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox2.Size = new System.Drawing.Size(22, 21);
            this.cuiPictureBox2.TabIndex = 32;
            // 
            // cuiPictureBox1
            // 
            this.cuiPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.cuiPictureBox1.Content = global::AppServidor.Properties.Resources.ajuste;
            this.cuiPictureBox1.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox1.Location = new System.Drawing.Point(19, 21);
            this.cuiPictureBox1.Name = "cuiPictureBox1";
            this.cuiPictureBox1.OutlineThickness = 1F;
            this.cuiPictureBox1.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox1.Rotation = 0;
            this.cuiPictureBox1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox1.Size = new System.Drawing.Size(22, 21);
            this.cuiPictureBox1.TabIndex = 33;
            // 
            // FrmContConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1460, 805);
            this.Controls.Add(this.cuiPictureBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cuiPictureBox2);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.cmbOrden);
            this.Controls.Add(this.cmbEntidad);
            this.Controls.Add(this.pnlCont3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmContConsultas";
            this.Text = "Form1";
            this.pnlCont3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiPanel pnlCont3;
        private System.Windows.Forms.DataGridView tabla;
        private CuoreUI.Controls.cuiButton btnBuscar;
        private CuoreUI.Controls.cuiComboBox cmbEntidad;
        private CuoreUI.Controls.cuiComboBox cmbOrden;
        private System.Windows.Forms.ToolTip mensajeInfo;
        private CuoreUI.Controls.cuiButton btnAnterior;
        private CuoreUI.Controls.cuiButton btnSiguiente;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox2;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
    }
}