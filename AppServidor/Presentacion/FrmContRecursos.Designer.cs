namespace AppServidor
{
    partial class FrmContRecursos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlCont3 = new CuoreUI.Controls.cuiPanel();
            this.lblCPU = new System.Windows.Forms.Label();
            this.chartCPU = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.lblRAM = new System.Windows.Forms.Label();
            this.chartRAM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            this.lblRed = new System.Windows.Forms.Label();
            this.chartRed = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timerRecursos = new System.Windows.Forms.Timer(this.components);
            this.mensajesInfo = new System.Windows.Forms.ToolTip(this.components);
            this.pnlCont3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCPU)).BeginInit();
            this.cuiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRAM)).BeginInit();
            this.cuiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRed)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCont3
            // 
            this.pnlCont3.Controls.Add(this.lblCPU);
            this.pnlCont3.Controls.Add(this.chartCPU);
            this.pnlCont3.Location = new System.Drawing.Point(12, 12);
            this.pnlCont3.Name = "pnlCont3";
            this.pnlCont3.OutlineThickness = 1F;
            this.pnlCont3.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.pnlCont3.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.pnlCont3.Rounding = new System.Windows.Forms.Padding(13);
            this.pnlCont3.Size = new System.Drawing.Size(1436, 227);
            this.pnlCont3.TabIndex = 22;
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.lblCPU.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.ForeColor = System.Drawing.Color.White;
            this.lblCPU.Location = new System.Drawing.Point(137, 16);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(20, 21);
            this.lblCPU.TabIndex = 25;
            this.lblCPU.Text = "0";
            // 
            // chartCPU
            // 
            this.chartCPU.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.BlanchedAlmond;
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea1.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea1.AxisX2.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea1.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea1.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea1.AxisY2.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea1.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chartCPU.ChartAreas.Add(chartArea1);
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
            this.chartCPU.Legends.Add(legend1);
            this.chartCPU.Location = new System.Drawing.Point(3, 3);
            this.chartCPU.Name = "chartCPU";
            this.chartCPU.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartCPU.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(65))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(240)))), ((int)(((byte)(158)))))};
            series1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(205)))), ((int)(((byte)(55)))));
            series1.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelBorderColor = System.Drawing.Color.Transparent;
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            series1.YValuesPerPoint = 4;
            this.chartCPU.Series.Add(series1);
            this.chartCPU.Size = new System.Drawing.Size(1430, 221);
            this.chartCPU.TabIndex = 1;
            this.chartCPU.Text = "chart1";
            this.mensajesInfo.SetToolTip(this.chartCPU, "Consumo de CPU De El Hardware Actual");
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.Controls.Add(this.lblRAM);
            this.cuiPanel1.Controls.Add(this.chartRAM);
            this.cuiPanel1.Location = new System.Drawing.Point(12, 245);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(13);
            this.cuiPanel1.Size = new System.Drawing.Size(1436, 227);
            this.cuiPanel1.TabIndex = 23;
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.lblRAM.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAM.ForeColor = System.Drawing.Color.White;
            this.lblRAM.Location = new System.Drawing.Point(137, 16);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(20, 21);
            this.lblRAM.TabIndex = 26;
            this.lblRAM.Text = "0";
            // 
            // chartRAM
            // 
            this.chartRAM.BackColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.BlanchedAlmond;
            chartArea2.AxisX2.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea2.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea2.AxisX2.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea2.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea2.AxisY.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea2.AxisY2.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea2.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea2.AxisY2.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea2.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.chartRAM.ChartAreas.Add(chartArea2);
            this.chartRAM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.HeaderSeparatorColor = System.Drawing.Color.White;
            legend2.IsTextAutoFit = false;
            legend2.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend2.Name = "Legend1";
            legend2.TitleForeColor = System.Drawing.Color.White;
            legend2.TitleSeparatorColor = System.Drawing.Color.White;
            this.chartRAM.Legends.Add(legend2);
            this.chartRAM.Location = new System.Drawing.Point(0, 3);
            this.chartRAM.Name = "chartRAM";
            this.chartRAM.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartRAM.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(65))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(240)))), ((int)(((byte)(158)))))};
            series2.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series2.BackSecondaryColor = System.Drawing.Color.White;
            series2.BorderColor = System.Drawing.Color.Transparent;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(102)))), ((int)(((byte)(252)))));
            series2.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.LabelBackColor = System.Drawing.Color.Transparent;
            series2.LabelBorderColor = System.Drawing.Color.Transparent;
            series2.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "RAM";
            series2.YValuesPerPoint = 4;
            this.chartRAM.Series.Add(series2);
            this.chartRAM.Size = new System.Drawing.Size(1433, 221);
            this.chartRAM.TabIndex = 1;
            this.chartRAM.Text = "chart1";
            this.mensajesInfo.SetToolTip(this.chartRAM, "Consumo de Memoria RAM De El Hardware Actual");
            // 
            // cuiPanel2
            // 
            this.cuiPanel2.Controls.Add(this.lblRed);
            this.cuiPanel2.Controls.Add(this.chartRed);
            this.cuiPanel2.Location = new System.Drawing.Point(12, 478);
            this.cuiPanel2.Name = "cuiPanel2";
            this.cuiPanel2.OutlineThickness = 1F;
            this.cuiPanel2.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.cuiPanel2.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiPanel2.Rounding = new System.Windows.Forms.Padding(13);
            this.cuiPanel2.Size = new System.Drawing.Size(1436, 227);
            this.cuiPanel2.TabIndex = 24;
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.lblRed.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.ForeColor = System.Drawing.Color.White;
            this.lblRed.Location = new System.Drawing.Point(137, 17);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(20, 21);
            this.lblRed.TabIndex = 27;
            this.lblRed.Text = "0";
            // 
            // chartRed
            // 
            this.chartRed.BackColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            chartArea3.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea3.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea3.AxisX.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea3.AxisX.TitleForeColor = System.Drawing.Color.BlanchedAlmond;
            chartArea3.AxisX2.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea3.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea3.AxisX2.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea3.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            chartArea3.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea3.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea3.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea3.AxisY.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea3.AxisY2.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea3.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea3.AxisY2.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea3.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.BorderColor = System.Drawing.Color.White;
            chartArea3.Name = "ChartArea1";
            this.chartRed.ChartAreas.Add(chartArea3);
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
            this.chartRed.Legends.Add(legend3);
            this.chartRed.Location = new System.Drawing.Point(0, 3);
            this.chartRed.Name = "chartRed";
            this.chartRed.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartRed.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(65))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(240)))), ((int)(((byte)(158)))))};
            series3.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series3.BackSecondaryColor = System.Drawing.Color.White;
            series3.BorderColor = System.Drawing.Color.Transparent;
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(65)))));
            series3.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.LabelBackColor = System.Drawing.Color.Transparent;
            series3.LabelBorderColor = System.Drawing.Color.Transparent;
            series3.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.Name = "Red";
            series3.YValuesPerPoint = 4;
            this.chartRed.Series.Add(series3);
            this.chartRed.Size = new System.Drawing.Size(1433, 221);
            this.chartRed.TabIndex = 2;
            this.chartRed.Text = "chart2";
            this.mensajesInfo.SetToolTip(this.chartRed, "Uso De RED De El Hardware Actual");
            // 
            // timerRecursos
            // 
            this.timerRecursos.Enabled = true;
            this.timerRecursos.Interval = 1000;
            this.timerRecursos.Tick += new System.EventHandler(this.timerRecursos_Tick);
            // 
            // FrmContRecursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1460, 805);
            this.Controls.Add(this.cuiPanel2);
            this.Controls.Add(this.cuiPanel1);
            this.Controls.Add(this.pnlCont3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmContRecursos";
            this.Text = "ContRecursos";
            this.Load += new System.EventHandler(this.ContRecursos_Load);
            this.pnlCont3.ResumeLayout(false);
            this.pnlCont3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCPU)).EndInit();
            this.cuiPanel1.ResumeLayout(false);
            this.cuiPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRAM)).EndInit();
            this.cuiPanel2.ResumeLayout(false);
            this.cuiPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CuoreUI.Controls.cuiPanel pnlCont3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCPU;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRAM;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRed;
        private System.Windows.Forms.Timer timerRecursos;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.ToolTip mensajesInfo;
    }
}