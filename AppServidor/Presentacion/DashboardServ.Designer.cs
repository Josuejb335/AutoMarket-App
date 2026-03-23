namespace AppServidor
{
    partial class DashboardServ
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardServ));
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.btnConsulta = new CuoreUI.Controls.cuiButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnBitacora = new CuoreUI.Controls.cuiButton();
            this.btnRegistro = new CuoreUI.Controls.cuiButton();
            this.btnRecursos = new CuoreUI.Controls.cuiButton();
            this.pnlFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFondo
            // 
            this.pnlFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.pnlFondo.Controls.Add(this.btnBitacora);
            this.pnlFondo.Controls.Add(this.btnRecursos);
            this.pnlFondo.Controls.Add(this.pnlContenedor);
            this.pnlFondo.Controls.Add(this.btnRegistro);
            this.pnlFondo.Controls.Add(this.btnConsulta);
            this.pnlFondo.Controls.Add(this.lblTitulo);
            this.pnlFondo.Location = new System.Drawing.Point(-4, -1);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(1900, 900);
            this.pnlFondo.TabIndex = 1;
            this.pnlFondo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFondo_Paint);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Location = new System.Drawing.Point(16, 45);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1460, 805);
            this.pnlContenedor.TabIndex = 4;
            this.pnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContenedor_Paint);
            // 
            // btnConsulta
            // 
            this.btnConsulta.CheckButton = false;
            this.btnConsulta.Checked = false;
            this.btnConsulta.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnConsulta.CheckedForeColor = System.Drawing.Color.White;
            this.btnConsulta.CheckedImageTint = System.Drawing.Color.White;
            this.btnConsulta.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnConsulta.Content = "Consultas";
            this.btnConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsulta.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConsulta.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnConsulta.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(112)))), ((int)(((byte)(128)))));
            this.btnConsulta.HoverForeColor = System.Drawing.Color.Black;
            this.btnConsulta.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnConsulta.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnConsulta.Image = null;
            this.btnConsulta.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnConsulta.Location = new System.Drawing.Point(1350, 10);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.btnConsulta.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnConsulta.NormalImageTint = System.Drawing.Color.Black;
            this.btnConsulta.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnConsulta.OutlineThickness = 1F;
            this.btnConsulta.Padding = new System.Windows.Forms.Padding(12);
            this.btnConsulta.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnConsulta.PressedForeColor = System.Drawing.Color.White;
            this.btnConsulta.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnConsulta.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnConsulta.Rounding = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.btnConsulta.Size = new System.Drawing.Size(126, 29);
            this.btnConsulta.TabIndex = 0;
            this.btnConsulta.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnConsulta.TextPadding = 12;
            this.btnConsulta.TextSpacing = 2;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.lblTitulo.Location = new System.Drawing.Point(11, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(151, 30);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "DASHBOARD";
            // 
            // btnBitacora
            // 
            this.btnBitacora.CheckButton = false;
            this.btnBitacora.Checked = false;
            this.btnBitacora.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnBitacora.CheckedForeColor = System.Drawing.Color.White;
            this.btnBitacora.CheckedImageTint = System.Drawing.Color.White;
            this.btnBitacora.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnBitacora.Content = "Bitacora";
            this.btnBitacora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBitacora.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBitacora.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBitacora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnBitacora.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(112)))), ((int)(((byte)(128)))));
            this.btnBitacora.HoverForeColor = System.Drawing.Color.Black;
            this.btnBitacora.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnBitacora.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBitacora.Image = null;
            this.btnBitacora.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnBitacora.Location = new System.Drawing.Point(981, 10);
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.btnBitacora.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnBitacora.NormalImageTint = System.Drawing.Color.Black;
            this.btnBitacora.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBitacora.OutlineThickness = 1F;
            this.btnBitacora.Padding = new System.Windows.Forms.Padding(12);
            this.btnBitacora.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnBitacora.PressedForeColor = System.Drawing.Color.White;
            this.btnBitacora.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnBitacora.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBitacora.Rounding = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.btnBitacora.Size = new System.Drawing.Size(126, 29);
            this.btnBitacora.TabIndex = 2;
            this.btnBitacora.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnBitacora.TextPadding = 12;
            this.btnBitacora.TextSpacing = 2;
            this.btnBitacora.Click += new System.EventHandler(this.btnBitacora_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.CheckButton = false;
            this.btnRegistro.Checked = false;
            this.btnRegistro.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnRegistro.CheckedForeColor = System.Drawing.Color.White;
            this.btnRegistro.CheckedImageTint = System.Drawing.Color.White;
            this.btnRegistro.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnRegistro.Content = "Registro";
            this.btnRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistro.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRegistro.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnRegistro.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(112)))), ((int)(((byte)(128)))));
            this.btnRegistro.HoverForeColor = System.Drawing.Color.Black;
            this.btnRegistro.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnRegistro.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRegistro.Image = null;
            this.btnRegistro.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnRegistro.Location = new System.Drawing.Point(1227, 10);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.btnRegistro.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnRegistro.NormalImageTint = System.Drawing.Color.Black;
            this.btnRegistro.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRegistro.OutlineThickness = 1F;
            this.btnRegistro.Padding = new System.Windows.Forms.Padding(12);
            this.btnRegistro.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnRegistro.PressedForeColor = System.Drawing.Color.White;
            this.btnRegistro.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnRegistro.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRegistro.Rounding = new System.Windows.Forms.Padding(0);
            this.btnRegistro.Size = new System.Drawing.Size(126, 29);
            this.btnRegistro.TabIndex = 1;
            this.btnRegistro.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnRegistro.TextPadding = 12;
            this.btnRegistro.TextSpacing = 2;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnRecursos
            // 
            this.btnRecursos.CheckButton = false;
            this.btnRecursos.Checked = false;
            this.btnRecursos.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnRecursos.CheckedForeColor = System.Drawing.Color.White;
            this.btnRecursos.CheckedImageTint = System.Drawing.Color.White;
            this.btnRecursos.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnRecursos.Content = "Recursos";
            this.btnRecursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecursos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRecursos.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecursos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnRecursos.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(112)))), ((int)(((byte)(128)))));
            this.btnRecursos.HoverForeColor = System.Drawing.Color.Black;
            this.btnRecursos.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnRecursos.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRecursos.Image = null;
            this.btnRecursos.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnRecursos.Location = new System.Drawing.Point(1104, 10);
            this.btnRecursos.Name = "btnRecursos";
            this.btnRecursos.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.btnRecursos.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnRecursos.NormalImageTint = System.Drawing.Color.Black;
            this.btnRecursos.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRecursos.OutlineThickness = 1F;
            this.btnRecursos.Padding = new System.Windows.Forms.Padding(12);
            this.btnRecursos.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnRecursos.PressedForeColor = System.Drawing.Color.White;
            this.btnRecursos.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnRecursos.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRecursos.Rounding = new System.Windows.Forms.Padding(0);
            this.btnRecursos.Size = new System.Drawing.Size(126, 29);
            this.btnRecursos.TabIndex = 5;
            this.btnRecursos.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnRecursos.TextPadding = 12;
            this.btnRecursos.TextSpacing = 2;
            this.btnRecursos.Click += new System.EventHandler(this.btnRecursos_Click);
            // 
            // DashboardServ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.pnlFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashboardServ";
            this.Load += new System.EventHandler(this.DashboardServ_Load);
            this.pnlFondo.ResumeLayout(false);
            this.pnlFondo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFondo;
        private CuoreUI.Controls.cuiButton btnConsulta;
        private CuoreUI.Controls.cuiButton btnBitacora;
        private CuoreUI.Controls.cuiButton btnRegistro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlContenedor;
        private CuoreUI.Controls.cuiButton btnRecursos;
    }
}

