namespace AppCliente.Presentacion
{
    partial class UcHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcHome));
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            this.SuspendLayout();
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.Content = "¡Bienvenido\\ a\\ AutoMarket!";
            this.cuiLabel1.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(134)))), ((int)(((byte)(233)))));
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel1.Location = new System.Drawing.Point(46, 56);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(299, 31);
            this.cuiLabel1.TabIndex = 0;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(134)))), ((int)(((byte)(233)))));
            this.richTextBox1.Location = new System.Drawing.Point(597, 56);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(329, 326);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // cuiPictureBox1
            // 
            this.cuiPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox1.Content = global::AppCliente.Properties.Resources.Vehiculos;
            this.cuiPictureBox1.ImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(134)))), ((int)(((byte)(233)))));
            this.cuiPictureBox1.Location = new System.Drawing.Point(46, 93);
            this.cuiPictureBox1.Name = "cuiPictureBox1";
            this.cuiPictureBox1.OutlineThickness = 1F;
            this.cuiPictureBox1.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox1.Rotation = 0;
            this.cuiPictureBox1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox1.Size = new System.Drawing.Size(299, 264);
            this.cuiPictureBox1.TabIndex = 2;
            // 
            // UcHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.cuiPictureBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cuiLabel1);
            this.Name = "UcHome";
            this.Size = new System.Drawing.Size(988, 470);
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
    }
}
