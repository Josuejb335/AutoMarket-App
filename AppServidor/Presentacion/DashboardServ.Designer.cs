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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardServ));
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.pnlContLog = new CuoreUI.Controls.cuiPanel();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.pnlContWid3 = new CuoreUI.Controls.cuiPanel();
            this.chartVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnConsulta = new CuoreUI.Controls.cuiButton();
            this.lblEventos = new System.Windows.Forms.Label();
            this.lblContWid3 = new CuoreUI.Controls.cuiPanel();
            this.chartClientes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlContWid2 = new CuoreUI.Controls.cuiPanel();
            this.chartGeneral2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlContWid1 = new CuoreUI.Controls.cuiPanel();
            this.chartGeneral = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnBitacora = new CuoreUI.Controls.cuiButton();
            this.btnRegistro = new CuoreUI.Controls.cuiButton();
            this.pnlFondo.SuspendLayout();
            this.pnlContLog.SuspendLayout();
            this.pnlContWid3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentas)).BeginInit();
            this.lblContWid3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartClientes)).BeginInit();
            this.pnlContWid2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGeneral2)).BeginInit();
            this.pnlContWid1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFondo
            // 
            this.pnlFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.pnlFondo.Controls.Add(this.pnlContLog);
            this.pnlFondo.Controls.Add(this.pnlContWid3);
            this.pnlFondo.Controls.Add(this.btnConsulta);
            this.pnlFondo.Controls.Add(this.lblEventos);
            this.pnlFondo.Controls.Add(this.lblContWid3);
            this.pnlFondo.Controls.Add(this.pnlContWid2);
            this.pnlFondo.Controls.Add(this.pnlContWid1);
            this.pnlFondo.Controls.Add(this.lblTitulo);
            this.pnlFondo.Controls.Add(this.btnBitacora);
            this.pnlFondo.Controls.Add(this.btnRegistro);
            this.pnlFondo.Location = new System.Drawing.Point(-4, -1);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(1119, 626);
            this.pnlFondo.TabIndex = 1;
            // 
            // pnlContLog
            // 
            this.pnlContLog.Controls.Add(this.txtLog);
            this.pnlContLog.Location = new System.Drawing.Point(11, 384);
            this.pnlContLog.Name = "pnlContLog";
            this.pnlContLog.OutlineThickness = 1F;
            this.pnlContLog.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.pnlContLog.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlContLog.Rounding = new System.Windows.Forms.Padding(13);
            this.pnlContLog.Size = new System.Drawing.Size(683, 229);
            this.pnlContLog.TabIndex = 11;
            this.pnlContLog.Paint += new System.Windows.Forms.PaintEventHandler(this.cuiPanel1_Paint);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.ForeColor = System.Drawing.Color.White;
            this.txtLog.Location = new System.Drawing.Point(8, 3);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(659, 223);
            this.txtLog.TabIndex = 10;
            // 
            // pnlContWid3
            // 
            this.pnlContWid3.Controls.Add(this.chartVentas);
            this.pnlContWid3.Location = new System.Drawing.Point(365, 70);
            this.pnlContWid3.Name = "pnlContWid3";
            this.pnlContWid3.OutlineThickness = 1F;
            this.pnlContWid3.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.pnlContWid3.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.pnlContWid3.Rounding = new System.Windows.Forms.Padding(13);
            this.pnlContWid3.Size = new System.Drawing.Size(329, 289);
            this.pnlContWid3.TabIndex = 6;
            // 
            // chartVentas
            // 
            this.chartVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chartVentas.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.HeaderSeparatorColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            legend1.TitleForeColor = System.Drawing.Color.White;
            legend1.TitleSeparatorColor = System.Drawing.Color.White;
            this.chartVentas.Legends.Add(legend1);
            this.chartVentas.Location = new System.Drawing.Point(3, 14);
            this.chartVentas.Name = "chartVentas";
            this.chartVentas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(5)))));
            series1.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelBorderColor = System.Drawing.Color.Transparent;
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Costo Vehiculos en Sucursales";
            series1.YValuesPerPoint = 4;
            this.chartVentas.Series.Add(series1);
            this.chartVentas.Size = new System.Drawing.Size(323, 269);
            this.chartVentas.TabIndex = 1;
            this.chartVentas.Text = "chart4";
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
            this.btnConsulta.ForeColor = System.Drawing.Color.White;
            this.btnConsulta.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(112)))), ((int)(((byte)(128)))));
            this.btnConsulta.HoverForeColor = System.Drawing.Color.Black;
            this.btnConsulta.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnConsulta.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnConsulta.Image = null;
            this.btnConsulta.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnConsulta.Location = new System.Drawing.Point(980, 13);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.btnConsulta.NormalForeColor = System.Drawing.Color.White;
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
            // lblEventos
            // 
            this.lblEventos.AutoSize = true;
            this.lblEventos.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventos.ForeColor = System.Drawing.Color.White;
            this.lblEventos.Location = new System.Drawing.Point(10, 359);
            this.lblEventos.Name = "lblEventos";
            this.lblEventos.Size = new System.Drawing.Size(218, 21);
            this.lblEventos.TabIndex = 8;
            this.lblEventos.Text = "LOG Eventos Del Servidor :";
            // 
            // lblContWid3
            // 
            this.lblContWid3.Controls.Add(this.chartClientes);
            this.lblContWid3.Location = new System.Drawing.Point(712, 384);
            this.lblContWid3.Name = "lblContWid3";
            this.lblContWid3.OutlineThickness = 1F;
            this.lblContWid3.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.lblContWid3.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.lblContWid3.Rounding = new System.Windows.Forms.Padding(13);
            this.lblContWid3.Size = new System.Drawing.Size(394, 229);
            this.lblContWid3.TabIndex = 7;
            // 
            // chartClientes
            // 
            this.chartClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartClientes.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chartClientes.Legends.Add(legend2);
            this.chartClientes.Location = new System.Drawing.Point(12, 3);
            this.chartClientes.Name = "chartClientes";
            this.chartClientes.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartClientes.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(80)))), ((int)(((byte)(119))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(240)))), ((int)(((byte)(158))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(102)))), ((int)(((byte)(252))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(220)))), ((int)(((byte)(113)))))};
            series2.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series2.BackSecondaryColor = System.Drawing.Color.White;
            series2.BorderColor = System.Drawing.Color.Transparent;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(205)))), ((int)(((byte)(193)))));
            series2.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.LabelBackColor = System.Drawing.Color.Transparent;
            series2.LabelBorderColor = System.Drawing.Color.Transparent;
            series2.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Clientes Registrados";
            series2.YValuesPerPoint = 4;
            this.chartClientes.Series.Add(series2);
            this.chartClientes.Size = new System.Drawing.Size(365, 226);
            this.chartClientes.TabIndex = 1;
            this.chartClientes.Text = "chart1";
            // 
            // pnlContWid2
            // 
            this.pnlContWid2.Controls.Add(this.chartGeneral2);
            this.pnlContWid2.Location = new System.Drawing.Point(712, 70);
            this.pnlContWid2.Name = "pnlContWid2";
            this.pnlContWid2.OutlineThickness = 1F;
            this.pnlContWid2.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.pnlContWid2.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.pnlContWid2.Rounding = new System.Windows.Forms.Padding(13);
            this.pnlContWid2.Size = new System.Drawing.Size(394, 286);
            this.pnlContWid2.TabIndex = 6;
            // 
            // chartGeneral2
            // 
            this.chartGeneral2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chartGeneral2.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.ForeColor = System.Drawing.Color.White;
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.chartGeneral2.Legends.Add(legend3);
            this.chartGeneral2.Location = new System.Drawing.Point(12, 3);
            this.chartGeneral2.Name = "chartGeneral2";
            this.chartGeneral2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartGeneral2.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(240)))), ((int)(((byte)(158))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(102)))), ((int)(((byte)(252))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(220)))), ((int)(((byte)(113))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(80)))), ((int)(((byte)(119)))))};
            series3.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series3.BackSecondaryColor = System.Drawing.Color.White;
            series3.BorderColor = System.Drawing.Color.Transparent;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(240)))), ((int)(((byte)(158)))));
            series3.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.LabelBackColor = System.Drawing.Color.Transparent;
            series3.LabelBorderColor = System.Drawing.Color.Transparent;
            series3.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.YValuesPerPoint = 4;
            this.chartGeneral2.Series.Add(series3);
            this.chartGeneral2.Size = new System.Drawing.Size(365, 280);
            this.chartGeneral2.TabIndex = 1;
            this.chartGeneral2.Text = "chart1";
            // 
            // pnlContWid1
            // 
            this.pnlContWid1.Controls.Add(this.chartGeneral);
            this.pnlContWid1.Location = new System.Drawing.Point(11, 70);
            this.pnlContWid1.Name = "pnlContWid1";
            this.pnlContWid1.OutlineThickness = 1F;
            this.pnlContWid1.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.pnlContWid1.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.pnlContWid1.Rounding = new System.Windows.Forms.Padding(13);
            this.pnlContWid1.Size = new System.Drawing.Size(334, 286);
            this.pnlContWid1.TabIndex = 5;
            // 
            // chartGeneral
            // 
            this.chartGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.BorderColor = System.Drawing.Color.White;
            chartArea4.Name = "ChartArea1";
            this.chartGeneral.ChartAreas.Add(chartArea4);
            legend4.BackColor = System.Drawing.Color.Transparent;
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend4.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend4.ForeColor = System.Drawing.Color.White;
            legend4.HeaderSeparatorColor = System.Drawing.Color.White;
            legend4.IsTextAutoFit = false;
            legend4.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend4.Name = "Legend1";
            legend4.TitleForeColor = System.Drawing.Color.White;
            legend4.TitleSeparatorColor = System.Drawing.Color.White;
            this.chartGeneral.Legends.Add(legend4);
            this.chartGeneral.Location = new System.Drawing.Point(3, 14);
            this.chartGeneral.Name = "chartGeneral";
            this.chartGeneral.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            this.chartGeneral.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(240)))), ((int)(((byte)(158))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(102)))), ((int)(((byte)(252))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))))};
            series4.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series4.BackSecondaryColor = System.Drawing.Color.White;
            series4.BorderColor = System.Drawing.Color.Transparent;
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(240)))), ((int)(((byte)(158)))));
            series4.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.LabelBackColor = System.Drawing.Color.Transparent;
            series4.LabelBorderColor = System.Drawing.Color.Transparent;
            series4.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series4.LabelForeColor = System.Drawing.Color.White;
            series4.Legend = "Legend1";
            series4.Name = "Datos Registrados";
            series4.YValuesPerPoint = 4;
            this.chartGeneral.Series.Add(series4);
            this.chartGeneral.Size = new System.Drawing.Size(323, 269);
            this.chartGeneral.TabIndex = 0;
            this.chartGeneral.Text = "chart1";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
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
            this.btnBitacora.ForeColor = System.Drawing.Color.White;
            this.btnBitacora.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(112)))), ((int)(((byte)(128)))));
            this.btnBitacora.HoverForeColor = System.Drawing.Color.Black;
            this.btnBitacora.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnBitacora.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBitacora.Image = null;
            this.btnBitacora.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnBitacora.Location = new System.Drawing.Point(712, 13);
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.btnBitacora.NormalForeColor = System.Drawing.Color.White;
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
            this.btnRegistro.ForeColor = System.Drawing.Color.White;
            this.btnRegistro.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(112)))), ((int)(((byte)(128)))));
            this.btnRegistro.HoverForeColor = System.Drawing.Color.Black;
            this.btnRegistro.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnRegistro.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRegistro.Image = null;
            this.btnRegistro.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnRegistro.Location = new System.Drawing.Point(836, 13);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.btnRegistro.NormalForeColor = System.Drawing.Color.White;
            this.btnRegistro.NormalImageTint = System.Drawing.Color.Black;
            this.btnRegistro.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRegistro.OutlineThickness = 1F;
            this.btnRegistro.Padding = new System.Windows.Forms.Padding(12);
            this.btnRegistro.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnRegistro.PressedForeColor = System.Drawing.Color.White;
            this.btnRegistro.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnRegistro.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRegistro.Rounding = new System.Windows.Forms.Padding(0);
            this.btnRegistro.Size = new System.Drawing.Size(146, 29);
            this.btnRegistro.TabIndex = 1;
            this.btnRegistro.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnRegistro.TextPadding = 12;
            this.btnRegistro.TextSpacing = 2;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // DashboardServ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1114, 621);
            this.Controls.Add(this.pnlFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashboardServ";
            this.Load += new System.EventHandler(this.DashboardServ_Load);
            this.pnlFondo.ResumeLayout(false);
            this.pnlFondo.PerformLayout();
            this.pnlContLog.ResumeLayout(false);
            this.pnlContLog.PerformLayout();
            this.pnlContWid3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartVentas)).EndInit();
            this.lblContWid3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartClientes)).EndInit();
            this.pnlContWid2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGeneral2)).EndInit();
            this.pnlContWid1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGeneral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFondo;
        private CuoreUI.Controls.cuiButton btnConsulta;
        private CuoreUI.Controls.cuiButton btnBitacora;
        private CuoreUI.Controls.cuiButton btnRegistro;
        private System.Windows.Forms.Label lblTitulo;
        private CuoreUI.Controls.cuiPanel pnlContWid1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGeneral;
        private CuoreUI.Controls.cuiPanel pnlContWid2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGeneral2;
        private CuoreUI.Controls.cuiPanel lblContWid3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartClientes;
        private System.Windows.Forms.Label lblEventos;
        private CuoreUI.Controls.cuiPanel pnlContWid3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentas;
        private System.Windows.Forms.TextBox txtLog;
        private CuoreUI.Controls.cuiPanel pnlContLog;
    }
}

