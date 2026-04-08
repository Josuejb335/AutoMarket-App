namespace AppServidor.Presentacion.Presentacion_Registro
{
    partial class ucRegistroCat
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
            this.pnl1 = new CuoreUI.Controls.cuiPanel();
            this.btnGuardar = new CuoreUI.Controls.cuiButton();
            this.txtDescripcion = new CuoreUI.Controls.cuiTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new CuoreUI.Controls.cuiTextBox();
            this.txtId = new CuoreUI.Controls.cuiTextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.btnGuardar);
            this.pnl1.Controls.Add(this.txtDescripcion);
            this.pnl1.Controls.Add(this.label3);
            this.pnl1.Controls.Add(this.label2);
            this.pnl1.Controls.Add(this.label1);
            this.pnl1.Controls.Add(this.txtNombre);
            this.pnl1.Controls.Add(this.txtId);
            this.pnl1.Location = new System.Drawing.Point(16, 42);
            this.pnl1.Name = "pnl1";
            this.pnl1.OutlineThickness = 1F;
            this.pnl1.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.pnl1.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnl1.Rounding = new System.Windows.Forms.Padding(15);
            this.pnl1.Size = new System.Drawing.Size(534, 753);
            this.pnl1.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.btnGuardar.CheckButton = false;
            this.btnGuardar.Checked = false;
            this.btnGuardar.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnGuardar.CheckedForeColor = System.Drawing.Color.White;
            this.btnGuardar.CheckedImageTint = System.Drawing.Color.White;
            this.btnGuardar.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnGuardar.Content = "Registrar";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnGuardar.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(112)))), ((int)(((byte)(128)))));
            this.btnGuardar.HoverForeColor = System.Drawing.Color.Black;
            this.btnGuardar.HoverImageTint = System.Drawing.Color.Black;
            this.btnGuardar.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGuardar.Image = global::AppServidor.Properties.Resources.save;
            this.btnGuardar.ImageExpand = new System.Drawing.Point(-3, -3);
            this.btnGuardar.Location = new System.Drawing.Point(3, 714);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnGuardar.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnGuardar.NormalImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnGuardar.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGuardar.OutlineThickness = 1F;
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(12);
            this.btnGuardar.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnGuardar.PressedForeColor = System.Drawing.Color.White;
            this.btnGuardar.PressedImageTint = System.Drawing.Color.White;
            this.btnGuardar.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGuardar.Rounding = new System.Windows.Forms.Padding(15);
            this.btnGuardar.Size = new System.Drawing.Size(153, 36);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnGuardar.TextPadding = 12;
            this.btnGuardar.TextSpacing = 2;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.txtDescripcion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.txtDescripcion.Content = "";
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.FocusBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.txtDescripcion.FocusImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.txtDescripcion.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescripcion.Image = null;
            this.txtDescripcion.ImageExpand = new System.Drawing.Point(0, 0);
            this.txtDescripcion.ImageOffset = new System.Drawing.Point(0, 0);
            this.txtDescripcion.Location = new System.Drawing.Point(7, 193);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.NormalImageTint = System.Drawing.Color.White;
            this.txtDescripcion.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtDescripcion.Padding = new System.Windows.Forms.Padding(20, 9, 20, 9);
            this.txtDescripcion.PasswordChar = false;
            this.txtDescripcion.PlaceholderColor = System.Drawing.Color.LightGray;
            this.txtDescripcion.PlaceholderText = ". . .";
            this.txtDescripcion.Rounding = new System.Windows.Forms.Padding(15);
            this.txtDescripcion.Size = new System.Drawing.Size(512, 147);
            this.txtDescripcion.TabIndex = 8;
            this.txtDescripcion.TextOffset = new System.Drawing.Size(0, 0);
            this.txtDescripcion.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(18, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descripcion Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(18, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre Categoria:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Categoria";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.txtNombre.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.txtNombre.Content = "";
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.FocusBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.txtNombre.FocusImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.txtNombre.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.Image = null;
            this.txtNombre.ImageExpand = new System.Drawing.Point(0, 0);
            this.txtNombre.ImageOffset = new System.Drawing.Point(0, 0);
            this.txtNombre.Location = new System.Drawing.Point(7, 112);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.NormalImageTint = System.Drawing.Color.White;
            this.txtNombre.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtNombre.Padding = new System.Windows.Forms.Padding(20, 9, 20, 0);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.PlaceholderColor = System.Drawing.Color.LightGray;
            this.txtNombre.PlaceholderText = ". . .";
            this.txtNombre.Rounding = new System.Windows.Forms.Padding(15);
            this.txtNombre.Size = new System.Drawing.Size(512, 39);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextOffset = new System.Drawing.Size(0, 0);
            this.txtNombre.UnderlinedStyle = true;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.txtId.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.txtId.Content = "";
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.Enabled = false;
            this.txtId.FocusBackgroundColor = System.Drawing.Color.White;
            this.txtId.FocusImageTint = System.Drawing.Color.White;
            this.txtId.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtId.Image = null;
            this.txtId.ImageExpand = new System.Drawing.Point(0, 0);
            this.txtId.ImageOffset = new System.Drawing.Point(0, 0);
            this.txtId.Location = new System.Drawing.Point(7, 36);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.NormalImageTint = System.Drawing.Color.White;
            this.txtId.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtId.Padding = new System.Windows.Forms.Padding(20, 9, 20, 0);
            this.txtId.PasswordChar = false;
            this.txtId.PlaceholderColor = System.Drawing.Color.LightGray;
            this.txtId.PlaceholderText = "AutoGenerado : ";
            this.txtId.Rounding = new System.Windows.Forms.Padding(15);
            this.txtId.Size = new System.Drawing.Size(512, 39);
            this.txtId.TabIndex = 0;
            this.txtId.TextOffset = new System.Drawing.Size(0, 0);
            this.txtId.UnderlinedStyle = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.lblTitulo.Location = new System.Drawing.Point(33, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(238, 30);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Registro De Categoria";
            // 
            // ucRegistroCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnl1);
            this.Name = "ucRegistroCat";
            this.Size = new System.Drawing.Size(1460, 808);
            this.Load += new System.EventHandler(this.ucRegistroCat_Load);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CuoreUI.Controls.cuiPanel pnl1;
        private System.Windows.Forms.Label lblTitulo;
        private CuoreUI.Controls.cuiTextBox txtId;
        private CuoreUI.Controls.cuiTextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CuoreUI.Controls.cuiTextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private CuoreUI.Controls.cuiButton btnGuardar;
    }
}
