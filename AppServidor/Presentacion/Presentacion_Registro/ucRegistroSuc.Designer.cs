namespace AppServidor.Presentacion.Presentacion_Registro
{
    partial class ucRegistroSuc
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnl1 = new CuoreUI.Controls.cuiPanel();
            this.cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDireccion = new CuoreUI.Controls.cuiTextBox();
            this.btnGuardar = new CuoreUI.Controls.cuiButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new CuoreUI.Controls.cuiTextBox();
            this.txtNombreSuc = new CuoreUI.Controls.cuiTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInactiva = new CuoreUI.Controls.cuiButtonGroup();
            this.grpBox = new CuoreUI.Controls.cuiGroupBox();
            this.btnActiva = new CuoreUI.Controls.cuiButtonGroup();
            this.txtIdVend = new CuoreUI.Controls.cuiTextBox();
            this.pnl1.SuspendLayout();
            this.cuiPanel2.SuspendLayout();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.lblTitulo.Location = new System.Drawing.Point(36, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(239, 30);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Registro De Vendedor";
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.txtIdVend);
            this.pnl1.Controls.Add(this.label7);
            this.pnl1.Controls.Add(this.grpBox);
            this.pnl1.Controls.Add(this.txtNombreSuc);
            this.pnl1.Controls.Add(this.cuiPanel2);
            this.pnl1.Controls.Add(this.label5);
            this.pnl1.Controls.Add(this.label4);
            this.pnl1.Controls.Add(this.txtDireccion);
            this.pnl1.Controls.Add(this.btnGuardar);
            this.pnl1.Controls.Add(this.label3);
            this.pnl1.Controls.Add(this.label2);
            this.pnl1.Controls.Add(this.label1);
            this.pnl1.Controls.Add(this.txtId);
            this.pnl1.Location = new System.Drawing.Point(19, 42);
            this.pnl1.Name = "pnl1";
            this.pnl1.OutlineThickness = 1F;
            this.pnl1.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.pnl1.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnl1.Rounding = new System.Windows.Forms.Padding(15);
            this.pnl1.Size = new System.Drawing.Size(534, 753);
            this.pnl1.TabIndex = 9;
            // 
            // cuiPanel2
            // 
            this.cuiPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.cuiPanel2.Controls.Add(this.txtTelefono);
            this.cuiPanel2.Location = new System.Drawing.Point(7, 269);
            this.cuiPanel2.Name = "cuiPanel2";
            this.cuiPanel2.OutlineThickness = 1F;
            this.cuiPanel2.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.cuiPanel2.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel2.Rounding = new System.Windows.Forms.Padding(15);
            this.cuiPanel2.Size = new System.Drawing.Size(512, 39);
            this.cuiPanel2.TabIndex = 51;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTelefono.Location = new System.Drawing.Point(10, 11);
            this.txtTelefono.Mask = "########";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(488, 20);
            this.txtTelefono.TabIndex = 49;
            this.txtTelefono.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(18, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "ID Vendedor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(18, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Telefono:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.txtDireccion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.txtDireccion.Content = "";
            this.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccion.FocusBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.txtDireccion.FocusImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.txtDireccion.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtDireccion.Image = null;
            this.txtDireccion.ImageExpand = new System.Drawing.Point(0, 0);
            this.txtDireccion.ImageOffset = new System.Drawing.Point(0, 0);
            this.txtDireccion.Location = new System.Drawing.Point(7, 191);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Multiline = false;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.NormalImageTint = System.Drawing.Color.White;
            this.txtDireccion.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtDireccion.Padding = new System.Windows.Forms.Padding(20, 9, 20, 0);
            this.txtDireccion.PasswordChar = false;
            this.txtDireccion.PlaceholderColor = System.Drawing.Color.LightGray;
            this.txtDireccion.PlaceholderText = ". . .";
            this.txtDireccion.Rounding = new System.Windows.Forms.Padding(15);
            this.txtDireccion.Size = new System.Drawing.Size(512, 39);
            this.txtDireccion.TabIndex = 10;
            this.txtDireccion.TextOffset = new System.Drawing.Size(0, 0);
            this.txtDireccion.UnderlinedStyle = true;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(18, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Direccion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(18, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre Sucursal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Sucursal:";
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
            // txtNombreSuc
            // 
            this.txtNombreSuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.txtNombreSuc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.txtNombreSuc.Content = "";
            this.txtNombreSuc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreSuc.FocusBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.txtNombreSuc.FocusImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.txtNombreSuc.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.txtNombreSuc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreSuc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombreSuc.Image = null;
            this.txtNombreSuc.ImageExpand = new System.Drawing.Point(0, 0);
            this.txtNombreSuc.ImageOffset = new System.Drawing.Point(0, 0);
            this.txtNombreSuc.Location = new System.Drawing.Point(7, 112);
            this.txtNombreSuc.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreSuc.Multiline = false;
            this.txtNombreSuc.Name = "txtNombreSuc";
            this.txtNombreSuc.NormalImageTint = System.Drawing.Color.White;
            this.txtNombreSuc.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtNombreSuc.Padding = new System.Windows.Forms.Padding(20, 9, 20, 0);
            this.txtNombreSuc.PasswordChar = false;
            this.txtNombreSuc.PlaceholderColor = System.Drawing.Color.LightGray;
            this.txtNombreSuc.PlaceholderText = ". . .";
            this.txtNombreSuc.Rounding = new System.Windows.Forms.Padding(15);
            this.txtNombreSuc.Size = new System.Drawing.Size(512, 39);
            this.txtNombreSuc.TabIndex = 52;
            this.txtNombreSuc.TextOffset = new System.Drawing.Size(0, 0);
            this.txtNombreSuc.UnderlinedStyle = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(18, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 53;
            this.label7.Text = "Estado:";
            // 
            // btnInactiva
            // 
            this.btnInactiva.Checked = false;
            this.btnInactiva.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.btnInactiva.CheckedForeColor = System.Drawing.Color.White;
            this.btnInactiva.CheckedImageTint = System.Drawing.Color.White;
            this.btnInactiva.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(102)))), ((int)(((byte)(252)))));
            this.btnInactiva.Content = "Inactiva";
            this.btnInactiva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInactiva.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInactiva.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInactiva.Group = 0;
            this.btnInactiva.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(112)))), ((int)(((byte)(128)))));
            this.btnInactiva.HoverForeColor = System.Drawing.Color.Black;
            this.btnInactiva.HoverImageTint = System.Drawing.Color.Black;
            this.btnInactiva.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnInactiva.Image = null;
            this.btnInactiva.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnInactiva.Location = new System.Drawing.Point(151, 0);
            this.btnInactiva.Name = "btnInactiva";
            this.btnInactiva.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnInactiva.NormalForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInactiva.NormalImageTint = System.Drawing.Color.Black;
            this.btnInactiva.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnInactiva.OutlineThickness = 1F;
            this.btnInactiva.Padding = new System.Windows.Forms.Padding(12);
            this.btnInactiva.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnInactiva.PressedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInactiva.PressedImageTint = System.Drawing.Color.WhiteSmoke;
            this.btnInactiva.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnInactiva.Rounding = new System.Windows.Forms.Padding(15);
            this.btnInactiva.Size = new System.Drawing.Size(141, 39);
            this.btnInactiva.TabIndex = 2;
            this.btnInactiva.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnInactiva.TextPadding = 12;
            this.btnInactiva.TextSpacing = 2;
            // 
            // grpBox
            // 
            this.grpBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.grpBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpBox.BorderColor = System.Drawing.Color.Transparent;
            this.grpBox.Content = "";
            this.grpBox.Controls.Add(this.btnInactiva);
            this.grpBox.Controls.Add(this.btnActiva);
            this.grpBox.Location = new System.Drawing.Point(3, 426);
            this.grpBox.Name = "grpBox";
            this.grpBox.Padding = new System.Windows.Forms.Padding(4, 15, 4, 4);
            this.grpBox.Rounding = new System.Windows.Forms.Padding(4);
            this.grpBox.Size = new System.Drawing.Size(300, 47);
            this.grpBox.TabIndex = 54;
            // 
            // btnActiva
            // 
            this.btnActiva.Checked = false;
            this.btnActiva.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.btnActiva.CheckedForeColor = System.Drawing.Color.White;
            this.btnActiva.CheckedImageTint = System.Drawing.Color.White;
            this.btnActiva.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(102)))), ((int)(((byte)(252)))));
            this.btnActiva.Content = "Activa";
            this.btnActiva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActiva.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActiva.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnActiva.Group = 0;
            this.btnActiva.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(112)))), ((int)(((byte)(128)))));
            this.btnActiva.HoverForeColor = System.Drawing.Color.Black;
            this.btnActiva.HoverImageTint = System.Drawing.Color.Black;
            this.btnActiva.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnActiva.Image = null;
            this.btnActiva.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnActiva.Location = new System.Drawing.Point(4, 0);
            this.btnActiva.Name = "btnActiva";
            this.btnActiva.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnActiva.NormalForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnActiva.NormalImageTint = System.Drawing.Color.Black;
            this.btnActiva.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnActiva.OutlineThickness = 1F;
            this.btnActiva.Padding = new System.Windows.Forms.Padding(12);
            this.btnActiva.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnActiva.PressedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnActiva.PressedImageTint = System.Drawing.Color.WhiteSmoke;
            this.btnActiva.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnActiva.Rounding = new System.Windows.Forms.Padding(15);
            this.btnActiva.Size = new System.Drawing.Size(141, 39);
            this.btnActiva.TabIndex = 1;
            this.btnActiva.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnActiva.TextPadding = 12;
            this.btnActiva.TextSpacing = 2;
            // 
            // txtIdVend
            // 
            this.txtIdVend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.txtIdVend.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.txtIdVend.Content = "";
            this.txtIdVend.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdVend.FocusBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.txtIdVend.FocusImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.txtIdVend.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.txtIdVend.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdVend.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtIdVend.Image = null;
            this.txtIdVend.ImageExpand = new System.Drawing.Point(0, 0);
            this.txtIdVend.ImageOffset = new System.Drawing.Point(0, 0);
            this.txtIdVend.Location = new System.Drawing.Point(11, 357);
            this.txtIdVend.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdVend.Multiline = false;
            this.txtIdVend.Name = "txtIdVend";
            this.txtIdVend.NormalImageTint = System.Drawing.Color.White;
            this.txtIdVend.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtIdVend.Padding = new System.Windows.Forms.Padding(20, 9, 20, 0);
            this.txtIdVend.PasswordChar = false;
            this.txtIdVend.PlaceholderColor = System.Drawing.Color.LightGray;
            this.txtIdVend.PlaceholderText = ". . .";
            this.txtIdVend.Rounding = new System.Windows.Forms.Padding(15);
            this.txtIdVend.Size = new System.Drawing.Size(512, 39);
            this.txtIdVend.TabIndex = 55;
            this.txtIdVend.TextOffset = new System.Drawing.Size(0, 0);
            this.txtIdVend.UnderlinedStyle = true;
            // 
            // ucRegistroSuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnl1);
            this.Name = "ucRegistroSuc";
            this.Size = new System.Drawing.Size(1460, 808);
            this.Load += new System.EventHandler(this.ucRegistroSuc_Load);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.cuiPanel2.ResumeLayout(false);
            this.cuiPanel2.PerformLayout();
            this.grpBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private CuoreUI.Controls.cuiPanel pnl1;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private CuoreUI.Controls.cuiTextBox txtDireccion;
        private CuoreUI.Controls.cuiButton btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CuoreUI.Controls.cuiTextBox txtId;
        private CuoreUI.Controls.cuiTextBox txtNombreSuc;
        private System.Windows.Forms.Label label7;
        private CuoreUI.Controls.cuiGroupBox grpBox;
        private CuoreUI.Controls.cuiButtonGroup btnInactiva;
        private CuoreUI.Controls.cuiButtonGroup btnActiva;
        private CuoreUI.Controls.cuiTextBox txtIdVend;
    }
}
