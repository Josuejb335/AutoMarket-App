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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardServ));
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.pnlContWid2 = new CuoreUI.Controls.cuiPanel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlContWid1 = new CuoreUI.Controls.cuiPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnBitacora = new CuoreUI.Controls.cuiButton();
            this.btnRegistro = new CuoreUI.Controls.cuiButton();
            this.btnConsulta = new CuoreUI.Controls.cuiButton();
            this.lblContWid3 = new CuoreUI.Controls.cuiPanel();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblEventos = new System.Windows.Forms.Label();
            this.txtLog = new CuoreUI.Controls.cuiTextBox();
            this.pnlFondo.SuspendLayout();
            this.pnlContWid2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.pnlContWid1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.lblContWid3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFondo
            // 
            this.pnlFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.pnlFondo.Controls.Add(this.txtLog);
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
            // pnlContWid2
            // 
            this.pnlContWid2.Controls.Add(this.chart2);
            this.pnlContWid2.Location = new System.Drawing.Point(712, 67);
            this.pnlContWid2.Name = "pnlContWid2";
            this.pnlContWid2.OutlineThickness = 1F;
            this.pnlContWid2.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.pnlContWid2.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.pnlContWid2.Rounding = new System.Windows.Forms.Padding(13);
            this.pnlContWid2.Size = new System.Drawing.Size(394, 289);
            this.pnlContWid2.TabIndex = 6;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(13, 3);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart2.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(80)))), ((int)(((byte)(119))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(240)))), ((int)(((byte)(158))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(102)))), ((int)(((byte)(252))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(220)))), ((int)(((byte)(113)))))};
            series2.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series2.BackSecondaryColor = System.Drawing.Color.White;
            series2.BorderColor = System.Drawing.Color.Transparent;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(240)))), ((int)(((byte)(158)))));
            series2.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.LabelBackColor = System.Drawing.Color.Transparent;
            series2.LabelBorderColor = System.Drawing.Color.Transparent;
            series2.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 4;
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(364, 283);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart1";
            // 
            // pnlContWid1
            // 
            this.pnlContWid1.Controls.Add(this.chart1);
            this.pnlContWid1.Location = new System.Drawing.Point(11, 67);
            this.pnlContWid1.Name = "pnlContWid1";
            this.pnlContWid1.OutlineThickness = 1F;
            this.pnlContWid1.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.pnlContWid1.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.pnlContWid1.Rounding = new System.Windows.Forms.Padding(13);
            this.pnlContWid1.Size = new System.Drawing.Size(683, 289);
            this.pnlContWid1.TabIndex = 5;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.BorderColor = System.Drawing.Color.White;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend3.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.ForeColor = System.Drawing.Color.White;
            legend3.HeaderSeparatorColor = System.Drawing.Color.White;
            legend3.IsTextAutoFit = false;
            legend3.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend3.Name = "Legend1";
            legend3.TitleForeColor = System.Drawing.Color.White;
            legend3.TitleSeparatorColor = System.Drawing.Color.White;
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(5, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series3.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series3.BackSecondaryColor = System.Drawing.Color.White;
            series3.BorderColor = System.Drawing.Color.Transparent;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(240)))), ((int)(((byte)(158)))));
            series3.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.LabelBackColor = System.Drawing.Color.Transparent;
            series3.LabelBorderColor = System.Drawing.Color.Transparent;
            series3.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.Name = "Datos Registrados";
            series3.YValuesPerPoint = 4;
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(665, 283);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(3, -3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(228, 45);
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
            // lblContWid3
            // 
            this.lblContWid3.Controls.Add(this.chart3);
            this.lblContWid3.Location = new System.Drawing.Point(712, 384);
            this.lblContWid3.Name = "lblContWid3";
            this.lblContWid3.OutlineThickness = 1F;
            this.lblContWid3.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.lblContWid3.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.lblContWid3.Rounding = new System.Windows.Forms.Padding(13);
            this.lblContWid3.Size = new System.Drawing.Size(394, 229);
            this.lblContWid3.TabIndex = 7;
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart3.Legends.Add(legend1);
            this.chart3.Location = new System.Drawing.Point(12, 3);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart3.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(80)))), ((int)(((byte)(119))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(240)))), ((int)(((byte)(158))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(102)))), ((int)(((byte)(252))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(220)))), ((int)(((byte)(113)))))};
            series1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(205)))), ((int)(((byte)(193)))));
            series1.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelBorderColor = System.Drawing.Color.Transparent;
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Clientes Registrados";
            series1.YValuesPerPoint = 4;
            this.chart3.Series.Add(series1);
            this.chart3.Size = new System.Drawing.Size(365, 226);
            this.chart3.TabIndex = 1;
            this.chart3.Text = "chart1";
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
            // txtLog
            // 
            this.txtLog.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.txtLog.Content = "";
            this.txtLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLog.FocusBackgroundColor = System.Drawing.Color.White;
            this.txtLog.FocusImageTint = System.Drawing.Color.White;
            this.txtLog.FocusOutlineColor = System.Drawing.Color.White;
            this.txtLog.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.ForeColor = System.Drawing.Color.Gray;
            this.txtLog.Image = null;
            this.txtLog.ImageExpand = new System.Drawing.Point(0, 0);
            this.txtLog.ImageOffset = new System.Drawing.Point(0, 0);
            this.txtLog.Location = new System.Drawing.Point(11, 384);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4);
            this.txtLog.Multiline = false;
            this.txtLog.Name = "txtLog";
            this.txtLog.NormalImageTint = System.Drawing.Color.White;
            this.txtLog.OutlineColor = System.Drawing.Color.Transparent;
            this.txtLog.Padding = new System.Windows.Forms.Padding(16, 106, 16, 0);
            this.txtLog.PasswordChar = false;
            this.txtLog.PlaceholderColor = System.Drawing.Color.LightGray;
            this.txtLog.PlaceholderText = "";
            this.txtLog.Rounding = new System.Windows.Forms.Padding(13);
            this.txtLog.Size = new System.Drawing.Size(683, 229);
            this.txtLog.TabIndex = 9;
            this.txtLog.TextOffset = new System.Drawing.Size(0, 0);
            this.txtLog.UnderlinedStyle = true;
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
            this.pnlFondo.ResumeLayout(false);
            this.pnlFondo.PerformLayout();
            this.pnlContWid2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.pnlContWid1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.lblContWid3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFondo;
        private CuoreUI.Controls.cuiButton btnConsulta;
        private CuoreUI.Controls.cuiButton btnBitacora;
        private CuoreUI.Controls.cuiButton btnRegistro;
        private System.Windows.Forms.Label lblTitulo;
        private CuoreUI.Controls.cuiPanel pnlContWid1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private CuoreUI.Controls.cuiPanel pnlContWid2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private CuoreUI.Controls.cuiPanel lblContWid3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private CuoreUI.Controls.cuiTextBox txtLog;
        private System.Windows.Forms.Label lblEventos;
    }
}

