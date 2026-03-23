namespace AppServidor
{
    partial class ContRecursos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlCont3 = new CuoreUI.Controls.cuiPanel();
            this.chartCPU = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.chartRAM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timerRecursos = new System.Windows.Forms.Timer(this.components);
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.pnlCont3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCPU)).BeginInit();
            this.cuiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRAM)).BeginInit();
            this.cuiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
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
            // chartCPU
            // 
            this.chartCPU.BackColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX.IsLabelAutoFit = false;
            chartArea4.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            chartArea4.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea4.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea4.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea4.AxisX.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea4.AxisX.TitleForeColor = System.Drawing.Color.BlanchedAlmond;
            chartArea4.AxisX2.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea4.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea4.AxisX2.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea4.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea4.AxisY.IsLabelAutoFit = false;
            chartArea4.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            chartArea4.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea4.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea4.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea4.AxisY.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea4.AxisY2.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea4.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea4.AxisY2.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea4.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.BorderColor = System.Drawing.Color.White;
            chartArea4.Name = "ChartArea1";
            this.chartCPU.ChartAreas.Add(chartArea4);
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
            this.chartCPU.Legends.Add(legend4);
            this.chartCPU.Location = new System.Drawing.Point(3, 3);
            this.chartCPU.Name = "chartCPU";
            this.chartCPU.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartCPU.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(65))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(240)))), ((int)(((byte)(158)))))};
            series4.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series4.BackSecondaryColor = System.Drawing.Color.White;
            series4.BorderColor = System.Drawing.Color.Transparent;
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.LimeGreen;
            series4.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.LabelBackColor = System.Drawing.Color.Transparent;
            series4.LabelBorderColor = System.Drawing.Color.Transparent;
            series4.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series4.LabelForeColor = System.Drawing.Color.White;
            series4.Legend = "Legend1";
            series4.Name = "CPU";
            series4.YValuesPerPoint = 4;
            this.chartCPU.Series.Add(series4);
            this.chartCPU.Size = new System.Drawing.Size(1430, 221);
            this.chartCPU.TabIndex = 1;
            this.chartCPU.Text = "chart1";
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
            // chartRAM
            // 
            this.chartRAM.BackColor = System.Drawing.Color.Transparent;
            chartArea5.AxisX.IsLabelAutoFit = false;
            chartArea5.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea5.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            chartArea5.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea5.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea5.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea5.AxisX.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea5.AxisX.TitleForeColor = System.Drawing.Color.BlanchedAlmond;
            chartArea5.AxisX2.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea5.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea5.AxisX2.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea5.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea5.AxisY.IsLabelAutoFit = false;
            chartArea5.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea5.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            chartArea5.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea5.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea5.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea5.AxisY.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea5.AxisY2.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea5.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea5.AxisY2.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea5.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea5.BackColor = System.Drawing.Color.Transparent;
            chartArea5.BorderColor = System.Drawing.Color.White;
            chartArea5.Name = "ChartArea1";
            this.chartRAM.ChartAreas.Add(chartArea5);
            this.chartRAM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend5.BackColor = System.Drawing.Color.Transparent;
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend5.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend5.ForeColor = System.Drawing.Color.White;
            legend5.HeaderSeparatorColor = System.Drawing.Color.White;
            legend5.IsTextAutoFit = false;
            legend5.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend5.Name = "Legend1";
            legend5.TitleForeColor = System.Drawing.Color.White;
            legend5.TitleSeparatorColor = System.Drawing.Color.White;
            this.chartRAM.Legends.Add(legend5);
            this.chartRAM.Location = new System.Drawing.Point(0, 3);
            this.chartRAM.Name = "chartRAM";
            this.chartRAM.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartRAM.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(65))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(240)))), ((int)(((byte)(158)))))};
            series5.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series5.BackSecondaryColor = System.Drawing.Color.White;
            series5.BorderColor = System.Drawing.Color.Transparent;
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.DodgerBlue;
            series5.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series5.LabelBackColor = System.Drawing.Color.Transparent;
            series5.LabelBorderColor = System.Drawing.Color.Transparent;
            series5.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series5.LabelForeColor = System.Drawing.Color.White;
            series5.Legend = "Legend1";
            series5.Name = "RAM";
            series5.YValuesPerPoint = 4;
            this.chartRAM.Series.Add(series5);
            this.chartRAM.Size = new System.Drawing.Size(1433, 221);
            this.chartRAM.TabIndex = 1;
            this.chartRAM.Text = "chart1";
            // 
            // cuiPanel2
            // 
            this.cuiPanel2.Controls.Add(this.chart2);
            this.cuiPanel2.Location = new System.Drawing.Point(12, 478);
            this.cuiPanel2.Name = "cuiPanel2";
            this.cuiPanel2.OutlineThickness = 1F;
            this.cuiPanel2.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.cuiPanel2.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiPanel2.Rounding = new System.Windows.Forms.Padding(13);
            this.cuiPanel2.Size = new System.Drawing.Size(1436, 227);
            this.cuiPanel2.TabIndex = 24;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            chartArea6.AxisX.IsLabelAutoFit = false;
            chartArea6.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea6.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            chartArea6.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea6.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea6.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea6.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea6.AxisX.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea6.AxisX.TitleForeColor = System.Drawing.Color.BlanchedAlmond;
            chartArea6.AxisX2.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea6.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea6.AxisX2.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea6.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea6.AxisY.IsLabelAutoFit = false;
            chartArea6.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea6.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            chartArea6.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea6.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea6.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea6.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea6.AxisY.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea6.AxisY2.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea6.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea6.AxisY2.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea6.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            chartArea6.BackColor = System.Drawing.Color.Transparent;
            chartArea6.BorderColor = System.Drawing.Color.White;
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            legend6.BackColor = System.Drawing.Color.Transparent;
            legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend6.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend6.ForeColor = System.Drawing.Color.White;
            legend6.HeaderSeparatorColor = System.Drawing.Color.White;
            legend6.IsTextAutoFit = false;
            legend6.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend6.Name = "Legend1";
            legend6.TitleForeColor = System.Drawing.Color.White;
            legend6.TitleSeparatorColor = System.Drawing.Color.White;
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(0, 3);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart2.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(176)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(65))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(240)))), ((int)(((byte)(158)))))};
            series6.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series6.BackSecondaryColor = System.Drawing.Color.White;
            series6.BorderColor = System.Drawing.Color.Transparent;
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Color = System.Drawing.Color.Lime;
            series6.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series6.LabelBackColor = System.Drawing.Color.Transparent;
            series6.LabelBorderColor = System.Drawing.Color.Transparent;
            series6.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series6.LabelForeColor = System.Drawing.Color.White;
            series6.Legend = "Legend1";
            series6.Name = "RED";
            series6.YValuesPerPoint = 4;
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(1433, 221);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            // 
            // timerRecursos
            // 
            this.timerRecursos.Enabled = true;
            this.timerRecursos.Interval = 1000;
            this.timerRecursos.Tick += new System.EventHandler(this.timerRecursos_Tick);
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
            this.lblRAM.Click += new System.EventHandler(this.lblRAM_Click);
            // 
            // ContRecursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1460, 805);
            this.Controls.Add(this.cuiPanel2);
            this.Controls.Add(this.cuiPanel1);
            this.Controls.Add(this.pnlCont3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContRecursos";
            this.Text = "ContRecursos";
            this.Load += new System.EventHandler(this.ContRecursos_Load);
            this.pnlCont3.ResumeLayout(false);
            this.pnlCont3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCPU)).EndInit();
            this.cuiPanel1.ResumeLayout(false);
            this.cuiPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRAM)).EndInit();
            this.cuiPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CuoreUI.Controls.cuiPanel pnlCont3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCPU;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRAM;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Timer timerRecursos;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblRAM;
    }
}