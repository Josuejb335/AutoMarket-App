namespace AppCliente.Presentacion
{
    partial class UcCompra
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.cuiPictureBox2 = new CuoreUI.Controls.cuiPictureBox();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSuc = new CuoreUI.Controls.cuiComboBox();
            this.btnComprar = new CuoreUI.Controls.cuiButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cuiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.Controls.Add(this.cuiPictureBox2);
            this.cuiPanel1.Controls.Add(this.tabla);
            this.cuiPanel1.Controls.Add(this.label1);
            this.cuiPanel1.Controls.Add(this.cmbSuc);
            this.cuiPanel1.Controls.Add(this.btnComprar);
            this.cuiPanel1.Controls.Add(this.label2);
            this.cuiPanel1.Location = new System.Drawing.Point(199, 25);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(134)))), ((int)(((byte)(233)))));
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(20);
            this.cuiPanel1.Size = new System.Drawing.Size(579, 420);
            this.cuiPanel1.TabIndex = 2;
            // 
            // cuiPictureBox2
            // 
            this.cuiPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox2.Content = global::AppCliente.Properties.Resources.chevron_down;
            this.cuiPictureBox2.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox2.Location = new System.Drawing.Point(281, 96);
            this.cuiPictureBox2.Name = "cuiPictureBox2";
            this.cuiPictureBox2.OutlineThickness = 1F;
            this.cuiPictureBox2.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox2.Rotation = 0;
            this.cuiPictureBox2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox2.Size = new System.Drawing.Size(16, 16);
            this.cuiPictureBox2.TabIndex = 26;
            // 
            // tabla
            // 
            this.tabla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(134)))), ((int)(((byte)(233)))));
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
            this.tabla.Location = new System.Drawing.Point(15, 118);
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
            this.tabla.Size = new System.Drawing.Size(550, 245);
            this.tabla.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(59)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(215, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Seleccione el Vehiculo";
            // 
            // cmbSuc
            // 
            this.cmbSuc.BackColor = System.Drawing.Color.Transparent;
            this.cmbSuc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(59)))), ((int)(((byte)(153)))));
            this.cmbSuc.DropDownBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.cmbSuc.DropDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.cmbSuc.ExpandArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.cmbSuc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.cmbSuc.Items = new string[] {
        ""};
            this.cmbSuc.Location = new System.Drawing.Point(176, 37);
            this.cmbSuc.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbSuc.MaxDropDownHeight = 600;
            this.cmbSuc.Name = "cmbSuc";
            this.cmbSuc.NoSelectionText = "None";
            this.cmbSuc.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmbSuc.OutlineThickness = 1F;
            this.cmbSuc.Rounding = 18;
            this.cmbSuc.SelectedIndex = -1;
            this.cmbSuc.SelectedItem = "";
            this.cmbSuc.Size = new System.Drawing.Size(230, 38);
            this.cmbSuc.SortAlphabetically = true;
            this.cmbSuc.TabIndex = 30;
            this.cmbSuc.SelectedIndexChanged += new System.EventHandler(this.cmbSuc_SelectedIndexChanged);
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.Transparent;
            this.btnComprar.CheckButton = false;
            this.btnComprar.Checked = false;
            this.btnComprar.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnComprar.CheckedForeColor = System.Drawing.Color.White;
            this.btnComprar.CheckedImageTint = System.Drawing.Color.White;
            this.btnComprar.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnComprar.Content = "Comprar";
            this.btnComprar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnComprar.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(134)))), ((int)(((byte)(233)))));
            this.btnComprar.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(98)))), ((int)(((byte)(220)))));
            this.btnComprar.HoverForeColor = System.Drawing.Color.Black;
            this.btnComprar.HoverImageTint = System.Drawing.Color.Black;
            this.btnComprar.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnComprar.Image = global::AppCliente.Properties.Resources.log_in;
            this.btnComprar.ImageExpand = new System.Drawing.Point(-3, -3);
            this.btnComprar.Location = new System.Drawing.Point(219, 384);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(59)))), ((int)(((byte)(153)))));
            this.btnComprar.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(134)))), ((int)(((byte)(233)))));
            this.btnComprar.NormalImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnComprar.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnComprar.OutlineThickness = 1F;
            this.btnComprar.Padding = new System.Windows.Forms.Padding(12);
            this.btnComprar.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(42)))), ((int)(((byte)(116)))));
            this.btnComprar.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(134)))), ((int)(((byte)(233)))));
            this.btnComprar.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(134)))), ((int)(((byte)(233)))));
            this.btnComprar.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnComprar.Rounding = new System.Windows.Forms.Padding(15);
            this.btnComprar.Size = new System.Drawing.Size(126, 29);
            this.btnComprar.TabIndex = 9;
            this.btnComprar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnComprar.TextPadding = 12;
            this.btnComprar.TextSpacing = 2;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(59)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(215, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seleccione la Sucursal";
            // 
            // UcCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.cuiPanel1);
            this.Name = "UcCompra";
            this.Size = new System.Drawing.Size(988, 470);
            this.Load += new System.EventHandler(this.UcCompra_Load);
            this.cuiPanel1.ResumeLayout(false);
            this.cuiPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiButton btnComprar;
        private System.Windows.Forms.Label label2;
        private CuoreUI.Controls.cuiComboBox cmbSuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tabla;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox2;
    }
}
