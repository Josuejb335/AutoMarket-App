namespace AppServidor.Presentacion.Presentacion_Registro
{
    partial class ucRegistroClie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucRegistroClie));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnl1 = new CuoreUI.Controls.cuiPanel();
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.txtIdentificacion = new System.Windows.Forms.MaskedTextBox();
            this.cuiCalendarDatePicker1 = new CuoreUI.Controls.cuiCalendarDatePicker();
            this.fechaNacimiento = new CuoreUI.Controls.cuiCalendarDatePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new CuoreUI.Controls.cuiTextBox();
            this.btnGuardar = new CuoreUI.Controls.cuiButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new CuoreUI.Controls.cuiTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grpBox = new CuoreUI.Controls.cuiGroupBox();
            this.btnInactiva = new CuoreUI.Controls.cuiButtonGroup();
            this.btnActiva = new CuoreUI.Controls.cuiButtonGroup();
            this.pnl1.SuspendLayout();
            this.cuiPanel1.SuspendLayout();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.lblTitulo.Location = new System.Drawing.Point(35, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(210, 30);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Registro De Cliente";
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.label7);
            this.pnl1.Controls.Add(this.grpBox);
            this.pnl1.Controls.Add(this.cuiPanel1);
            this.pnl1.Controls.Add(this.cuiCalendarDatePicker1);
            this.pnl1.Controls.Add(this.fechaNacimiento);
            this.pnl1.Controls.Add(this.label5);
            this.pnl1.Controls.Add(this.label4);
            this.pnl1.Controls.Add(this.txtNombre);
            this.pnl1.Controls.Add(this.btnGuardar);
            this.pnl1.Controls.Add(this.label3);
            this.pnl1.Controls.Add(this.label2);
            this.pnl1.Controls.Add(this.label1);
            this.pnl1.Controls.Add(this.txtId);
            this.pnl1.Location = new System.Drawing.Point(18, 42);
            this.pnl1.Name = "pnl1";
            this.pnl1.OutlineThickness = 1F;
            this.pnl1.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.pnl1.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnl1.Rounding = new System.Windows.Forms.Padding(15);
            this.pnl1.Size = new System.Drawing.Size(534, 753);
            this.pnl1.TabIndex = 9;
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.cuiPanel1.Controls.Add(this.txtIdentificacion);
            this.cuiPanel1.Location = new System.Drawing.Point(7, 111);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(15);
            this.cuiPanel1.Size = new System.Drawing.Size(512, 39);
            this.cuiPanel1.TabIndex = 50;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.txtIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentificacion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtIdentificacion.Location = new System.Drawing.Point(12, 11);
            this.txtIdentificacion.Mask = "##########";
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(485, 20);
            this.txtIdentificacion.TabIndex = 39;
            this.txtIdentificacion.ValidatingType = typeof(System.DateTime);
            // 
            // cuiCalendarDatePicker1
            // 
            this.cuiCalendarDatePicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.cuiCalendarDatePicker1.Content = new System.DateTime(2026, 4, 9, 0, 0, 0, 0);
            this.cuiCalendarDatePicker1.EnableThemeChangeButton = true;
            this.cuiCalendarDatePicker1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiCalendarDatePicker1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cuiCalendarDatePicker1.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiCalendarDatePicker1.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiCalendarDatePicker1.Icon = ((System.Drawing.Image)(resources.GetObject("cuiCalendarDatePicker1.Icon")));
            this.cuiCalendarDatePicker1.IconTint = System.Drawing.Color.Gray;
            this.cuiCalendarDatePicker1.Location = new System.Drawing.Point(7, 353);
            this.cuiCalendarDatePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cuiCalendarDatePicker1.Name = "cuiCalendarDatePicker1";
            this.cuiCalendarDatePicker1.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.cuiCalendarDatePicker1.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiCalendarDatePicker1.OutlineThickness = 1.5F;
            this.cuiCalendarDatePicker1.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.Bottom;
            this.cuiCalendarDatePicker1.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiCalendarDatePicker1.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiCalendarDatePicker1.Rounding = 15;
            this.cuiCalendarDatePicker1.ShowIcon = true;
            this.cuiCalendarDatePicker1.Size = new System.Drawing.Size(512, 39);
            this.cuiCalendarDatePicker1.TabIndex = 47;
            this.cuiCalendarDatePicker1.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Dark;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.fechaNacimiento.Content = new System.DateTime(2026, 4, 9, 0, 0, 0, 0);
            this.fechaNacimiento.EnableThemeChangeButton = true;
            this.fechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaNacimiento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.fechaNacimiento.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.fechaNacimiento.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.fechaNacimiento.Icon = ((System.Drawing.Image)(resources.GetObject("fechaNacimiento.Icon")));
            this.fechaNacimiento.IconTint = System.Drawing.Color.Gray;
            this.fechaNacimiento.Location = new System.Drawing.Point(7, 271);
            this.fechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.fechaNacimiento.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.fechaNacimiento.OutlineThickness = 1.5F;
            this.fechaNacimiento.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.Bottom;
            this.fechaNacimiento.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.fechaNacimiento.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.fechaNacimiento.Rounding = 15;
            this.fechaNacimiento.ShowIcon = true;
            this.fechaNacimiento.Size = new System.Drawing.Size(512, 39);
            this.fechaNacimiento.TabIndex = 46;
            this.fechaNacimiento.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Dark;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(18, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Fecha  Registro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(18, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fecha Nacimiento:";
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
            this.txtNombre.Location = new System.Drawing.Point(7, 191);
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
            this.txtNombre.TabIndex = 10;
            this.txtNombre.TextOffset = new System.Drawing.Size(0, 0);
            this.txtNombre.UnderlinedStyle = true;
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
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre Completo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(18, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Identificacion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Cliente:";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(18, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 55;
            this.label7.Text = "Estado:";
            // 
            // grpBox
            // 
            this.grpBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.grpBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpBox.BorderColor = System.Drawing.Color.Transparent;
            this.grpBox.Content = "";
            this.grpBox.Controls.Add(this.btnInactiva);
            this.grpBox.Controls.Add(this.btnActiva);
            this.grpBox.Location = new System.Drawing.Point(3, 430);
            this.grpBox.Name = "grpBox";
            this.grpBox.Padding = new System.Windows.Forms.Padding(4, 15, 4, 4);
            this.grpBox.Rounding = new System.Windows.Forms.Padding(4);
            this.grpBox.Size = new System.Drawing.Size(300, 47);
            this.grpBox.TabIndex = 56;
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
            // ucRegistroClie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnl1);
            this.Name = "ucRegistroClie";
            this.Size = new System.Drawing.Size(1460, 808);
            this.Load += new System.EventHandler(this.ucRegistroClie_Load);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.cuiPanel1.ResumeLayout(false);
            this.cuiPanel1.PerformLayout();
            this.grpBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private CuoreUI.Controls.cuiPanel pnl1;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private System.Windows.Forms.MaskedTextBox txtIdentificacion;
        private CuoreUI.Controls.cuiCalendarDatePicker cuiCalendarDatePicker1;
        private CuoreUI.Controls.cuiCalendarDatePicker fechaNacimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private CuoreUI.Controls.cuiTextBox txtNombre;
        private CuoreUI.Controls.cuiButton btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CuoreUI.Controls.cuiTextBox txtId;
        private System.Windows.Forms.Label label7;
        private CuoreUI.Controls.cuiGroupBox grpBox;
        private CuoreUI.Controls.cuiButtonGroup btnInactiva;
        private CuoreUI.Controls.cuiButtonGroup btnActiva;
    }
}
