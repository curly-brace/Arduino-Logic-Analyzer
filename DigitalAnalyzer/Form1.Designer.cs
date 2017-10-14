namespace DigitalAnalyzer {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series26 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series27 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series28 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series29 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series30 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series31 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series32 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button4 = new System.Windows.Forms.Button();
            this.ctrlList = new System.Windows.Forms.ListBox();
            this.dataList = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.resetChk = new System.Windows.Forms.CheckBox();
            this.load = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.bit0 = new System.Windows.Forms.CheckBox();
            this.bit1 = new System.Windows.Forms.CheckBox();
            this.bit2 = new System.Windows.Forms.CheckBox();
            this.bit3 = new System.Windows.Forms.CheckBox();
            this.bit4 = new System.Windows.Forms.CheckBox();
            this.bit5 = new System.Windows.Forms.CheckBox();
            this.bit6 = new System.Windows.Forms.CheckBox();
            this.bit7 = new System.Windows.Forms.CheckBox();
            this.bit8 = new System.Windows.Forms.CheckBox();
            this.bit9 = new System.Windows.Forms.CheckBox();
            this.bit10 = new System.Windows.Forms.CheckBox();
            this.bit11 = new System.Windows.Forms.CheckBox();
            this.bit12 = new System.Windows.Forms.CheckBox();
            this.bit13 = new System.Windows.Forms.CheckBox();
            this.bit14 = new System.Windows.Forms.CheckBox();
            this.bit15 = new System.Windows.Forms.CheckBox();
            this.SerialPortComboBox = new System.Windows.Forms.ComboBox();
            this.SerialSpeedComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(504, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(724, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "4160 microseconds each";
            // 
            // chart1
            // 
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.LabelAutoFitStyle = System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont;
            chartArea2.AxisX.MajorGrid.Interval = 1D;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkOliveGreen;
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisX.MaximumAutoSize = 1F;
            chartArea2.AxisX.ScaleView.MinSize = 0D;
            chartArea2.AxisX.ScaleView.Size = 100D;
            chartArea2.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.Interval = 1D;
            chartArea2.AxisY.MajorGrid.Interval = 1D;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            chartArea2.AxisY.Maximum = 33D;
            chartArea2.AxisY.MaximumAutoSize = 1F;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.AxisY.ScaleView.MinSize = 33D;
            chartArea2.AxisY.ScaleView.Size = 33D;
            chartArea2.AxisY.ScaleView.Zoomable = false;
            chartArea2.BackColor = System.Drawing.Color.Black;
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.CursorX.SelectionColor = System.Drawing.Color.Gainsboro;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(174, 34);
            this.chart1.Name = "chart1";
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series17.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series17.Legend = "Legend1";
            series17.Name = "green1";
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series18.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series18.Legend = "Legend1";
            series18.Name = "green2";
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series19.Color = System.Drawing.Color.Yellow;
            series19.Legend = "Legend1";
            series19.Name = "yellow1";
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series20.Color = System.Drawing.Color.Yellow;
            series20.Legend = "Legend1";
            series20.Name = "yellow2";
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series21.Color = System.Drawing.Color.Fuchsia;
            series21.Legend = "Legend1";
            series21.Name = "purple1";
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series22.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series22.Legend = "Legend1";
            series22.Name = "purple2";
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series23.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series23.Legend = "Legend1";
            series23.Name = "purple3";
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series24.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series24.Legend = "Legend1";
            series24.Name = "purple4";
            series25.ChartArea = "ChartArea1";
            series25.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series25.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series25.Legend = "Legend1";
            series25.Name = "data0";
            series26.ChartArea = "ChartArea1";
            series26.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series26.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series26.Legend = "Legend1";
            series26.Name = "data1";
            series27.ChartArea = "ChartArea1";
            series27.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series27.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series27.Legend = "Legend1";
            series27.Name = "data2";
            series28.ChartArea = "ChartArea1";
            series28.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series28.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series28.Legend = "Legend1";
            series28.Name = "data3";
            series29.ChartArea = "ChartArea1";
            series29.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series29.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series29.Legend = "Legend1";
            series29.Name = "data4";
            series30.ChartArea = "ChartArea1";
            series30.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series30.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series30.Legend = "Legend1";
            series30.Name = "data5";
            series31.ChartArea = "ChartArea1";
            series31.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series31.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series31.Legend = "Legend1";
            series31.Name = "data6";
            series32.ChartArea = "ChartArea1";
            series32.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series32.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series32.Legend = "Legend1";
            series32.Name = "data7";
            this.chart1.Series.Add(series17);
            this.chart1.Series.Add(series18);
            this.chart1.Series.Add(series19);
            this.chart1.Series.Add(series20);
            this.chart1.Series.Add(series21);
            this.chart1.Series.Add(series22);
            this.chart1.Series.Add(series23);
            this.chart1.Series.Add(series24);
            this.chart1.Series.Add(series25);
            this.chart1.Series.Add(series26);
            this.chart1.Series.Add(series27);
            this.chart1.Series.Add(series28);
            this.chart1.Series.Add(series29);
            this.chart1.Series.Add(series30);
            this.chart1.Series.Add(series31);
            this.chart1.Series.Add(series32);
            this.chart1.Size = new System.Drawing.Size(1011, 420);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            this.chart1.CursorPositionChanged += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.CursorEventArgs>(this.chart1_CursorPositionChanged);
            this.chart1.MouseEnter += new System.EventHandler(this.chart1_MouseEnter);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Save control";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ctrlList
            // 
            this.ctrlList.FormattingEnabled = true;
            this.ctrlList.Location = new System.Drawing.Point(12, 34);
            this.ctrlList.Name = "ctrlList";
            this.ctrlList.Size = new System.Drawing.Size(75, 420);
            this.ctrlList.TabIndex = 9;
            // 
            // dataList
            // 
            this.dataList.FormattingEnabled = true;
            this.dataList.Location = new System.Drawing.Point(93, 34);
            this.dataList.Name = "dataList";
            this.dataList.Size = new System.Drawing.Size(75, 420);
            this.dataList.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(423, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Open";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // resetChk
            // 
            this.resetChk.AutoSize = true;
            this.resetChk.Location = new System.Drawing.Point(585, 11);
            this.resetChk.Name = "resetChk";
            this.resetChk.Size = new System.Drawing.Size(106, 17);
            this.resetChk.TabIndex = 12;
            this.resetChk.Text = "reset on connect";
            this.resetChk.UseVisualStyleBackColor = true;
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(1110, 7);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 23);
            this.load.TabIndex = 13;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(1029, 7);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 14;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(900, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Fill lists";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // bit0
            // 
            this.bit0.AutoSize = true;
            this.bit0.BackColor = System.Drawing.Color.Transparent;
            this.bit0.Checked = true;
            this.bit0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bit0.Location = new System.Drawing.Point(1058, 53);
            this.bit0.Name = "bit0";
            this.bit0.Size = new System.Drawing.Size(15, 14);
            this.bit0.TabIndex = 16;
            this.bit0.UseVisualStyleBackColor = false;
            // 
            // bit1
            // 
            this.bit1.AutoSize = true;
            this.bit1.BackColor = System.Drawing.Color.Transparent;
            this.bit1.Checked = true;
            this.bit1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bit1.Location = new System.Drawing.Point(1058, 67);
            this.bit1.Name = "bit1";
            this.bit1.Size = new System.Drawing.Size(15, 14);
            this.bit1.TabIndex = 16;
            this.bit1.UseVisualStyleBackColor = false;
            // 
            // bit2
            // 
            this.bit2.AutoSize = true;
            this.bit2.BackColor = System.Drawing.Color.Transparent;
            this.bit2.Checked = true;
            this.bit2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bit2.Location = new System.Drawing.Point(1058, 81);
            this.bit2.Name = "bit2";
            this.bit2.Size = new System.Drawing.Size(15, 14);
            this.bit2.TabIndex = 16;
            this.bit2.UseVisualStyleBackColor = false;
            // 
            // bit3
            // 
            this.bit3.AutoSize = true;
            this.bit3.BackColor = System.Drawing.Color.Transparent;
            this.bit3.Checked = true;
            this.bit3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bit3.Location = new System.Drawing.Point(1058, 95);
            this.bit3.Name = "bit3";
            this.bit3.Size = new System.Drawing.Size(15, 14);
            this.bit3.TabIndex = 16;
            this.bit3.UseVisualStyleBackColor = false;
            // 
            // bit4
            // 
            this.bit4.AutoSize = true;
            this.bit4.BackColor = System.Drawing.Color.Transparent;
            this.bit4.Checked = true;
            this.bit4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bit4.Location = new System.Drawing.Point(1058, 109);
            this.bit4.Name = "bit4";
            this.bit4.Size = new System.Drawing.Size(15, 14);
            this.bit4.TabIndex = 16;
            this.bit4.UseVisualStyleBackColor = false;
            // 
            // bit5
            // 
            this.bit5.AutoSize = true;
            this.bit5.BackColor = System.Drawing.Color.Transparent;
            this.bit5.Checked = true;
            this.bit5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bit5.Location = new System.Drawing.Point(1058, 123);
            this.bit5.Name = "bit5";
            this.bit5.Size = new System.Drawing.Size(15, 14);
            this.bit5.TabIndex = 16;
            this.bit5.UseVisualStyleBackColor = false;
            // 
            // bit6
            // 
            this.bit6.AutoSize = true;
            this.bit6.BackColor = System.Drawing.Color.Transparent;
            this.bit6.Checked = true;
            this.bit6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bit6.Location = new System.Drawing.Point(1058, 137);
            this.bit6.Name = "bit6";
            this.bit6.Size = new System.Drawing.Size(15, 14);
            this.bit6.TabIndex = 16;
            this.bit6.UseVisualStyleBackColor = false;
            // 
            // bit7
            // 
            this.bit7.AutoSize = true;
            this.bit7.BackColor = System.Drawing.Color.Transparent;
            this.bit7.Checked = true;
            this.bit7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bit7.Location = new System.Drawing.Point(1058, 151);
            this.bit7.Name = "bit7";
            this.bit7.Size = new System.Drawing.Size(15, 14);
            this.bit7.TabIndex = 16;
            this.bit7.UseVisualStyleBackColor = false;
            // 
            // bit8
            // 
            this.bit8.AutoSize = true;
            this.bit8.BackColor = System.Drawing.Color.Transparent;
            this.bit8.Checked = true;
            this.bit8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bit8.Location = new System.Drawing.Point(1058, 165);
            this.bit8.Name = "bit8";
            this.bit8.Size = new System.Drawing.Size(15, 14);
            this.bit8.TabIndex = 16;
            this.bit8.UseVisualStyleBackColor = false;
            // 
            // bit9
            // 
            this.bit9.AutoSize = true;
            this.bit9.BackColor = System.Drawing.Color.Transparent;
            this.bit9.Checked = true;
            this.bit9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bit9.Location = new System.Drawing.Point(1058, 179);
            this.bit9.Name = "bit9";
            this.bit9.Size = new System.Drawing.Size(15, 14);
            this.bit9.TabIndex = 16;
            this.bit9.UseVisualStyleBackColor = false;
            // 
            // bit10
            // 
            this.bit10.AutoSize = true;
            this.bit10.BackColor = System.Drawing.Color.Transparent;
            this.bit10.Checked = true;
            this.bit10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bit10.Location = new System.Drawing.Point(1058, 193);
            this.bit10.Name = "bit10";
            this.bit10.Size = new System.Drawing.Size(15, 14);
            this.bit10.TabIndex = 16;
            this.bit10.UseVisualStyleBackColor = false;
            // 
            // bit11
            // 
            this.bit11.AutoSize = true;
            this.bit11.BackColor = System.Drawing.Color.Transparent;
            this.bit11.Checked = true;
            this.bit11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bit11.Location = new System.Drawing.Point(1058, 207);
            this.bit11.Name = "bit11";
            this.bit11.Size = new System.Drawing.Size(15, 14);
            this.bit11.TabIndex = 16;
            this.bit11.UseVisualStyleBackColor = false;
            // 
            // bit12
            // 
            this.bit12.AutoSize = true;
            this.bit12.BackColor = System.Drawing.Color.Transparent;
            this.bit12.Checked = true;
            this.bit12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bit12.Location = new System.Drawing.Point(1058, 221);
            this.bit12.Name = "bit12";
            this.bit12.Size = new System.Drawing.Size(15, 14);
            this.bit12.TabIndex = 16;
            this.bit12.UseVisualStyleBackColor = false;
            // 
            // bit13
            // 
            this.bit13.AutoSize = true;
            this.bit13.BackColor = System.Drawing.Color.Transparent;
            this.bit13.Checked = true;
            this.bit13.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bit13.Location = new System.Drawing.Point(1058, 235);
            this.bit13.Name = "bit13";
            this.bit13.Size = new System.Drawing.Size(15, 14);
            this.bit13.TabIndex = 16;
            this.bit13.UseVisualStyleBackColor = false;
            // 
            // bit14
            // 
            this.bit14.AutoSize = true;
            this.bit14.BackColor = System.Drawing.Color.Transparent;
            this.bit14.Checked = true;
            this.bit14.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bit14.Location = new System.Drawing.Point(1058, 249);
            this.bit14.Name = "bit14";
            this.bit14.Size = new System.Drawing.Size(15, 14);
            this.bit14.TabIndex = 16;
            this.bit14.UseVisualStyleBackColor = false;
            // 
            // bit15
            // 
            this.bit15.AutoSize = true;
            this.bit15.BackColor = System.Drawing.Color.Transparent;
            this.bit15.Checked = true;
            this.bit15.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bit15.Location = new System.Drawing.Point(1058, 263);
            this.bit15.Name = "bit15";
            this.bit15.Size = new System.Drawing.Size(15, 14);
            this.bit15.TabIndex = 16;
            this.bit15.UseVisualStyleBackColor = false;
            // 
            // SerialPortComboBox
            // 
            this.SerialPortComboBox.FormattingEnabled = true;
            this.SerialPortComboBox.Location = new System.Drawing.Point(173, 8);
            this.SerialPortComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SerialPortComboBox.Name = "SerialPortComboBox";
            this.SerialPortComboBox.Size = new System.Drawing.Size(92, 21);
            this.SerialPortComboBox.TabIndex = 17;
            this.SerialPortComboBox.DropDown += new System.EventHandler(this.SerialPortComboBox_DropDown);
            // 
            // SerialSpeedComboBox
            // 
            this.SerialSpeedComboBox.FormattingEnabled = true;
            this.SerialSpeedComboBox.Location = new System.Drawing.Point(268, 7);
            this.SerialSpeedComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SerialSpeedComboBox.Name = "SerialSpeedComboBox";
            this.SerialSpeedComboBox.Size = new System.Drawing.Size(92, 21);
            this.SerialSpeedComboBox.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 462);
            this.Controls.Add(this.SerialSpeedComboBox);
            this.Controls.Add(this.SerialPortComboBox);
            this.Controls.Add(this.bit15);
            this.Controls.Add(this.bit14);
            this.Controls.Add(this.bit13);
            this.Controls.Add(this.bit12);
            this.Controls.Add(this.bit11);
            this.Controls.Add(this.bit10);
            this.Controls.Add(this.bit9);
            this.Controls.Add(this.bit8);
            this.Controls.Add(this.bit7);
            this.Controls.Add(this.bit6);
            this.Controls.Add(this.bit5);
            this.Controls.Add(this.bit4);
            this.Controls.Add(this.bit3);
            this.Controls.Add(this.bit2);
            this.Controls.Add(this.bit1);
            this.Controls.Add(this.bit0);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.save);
            this.Controls.Add(this.load);
            this.Controls.Add(this.resetChk);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataList);
            this.Controls.Add(this.ctrlList);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "LogicAnalyzer";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox ctrlList;
        private System.Windows.Forms.ListBox dataList;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox resetChk;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox bit0;
        private System.Windows.Forms.CheckBox bit1;
        private System.Windows.Forms.CheckBox bit2;
        private System.Windows.Forms.CheckBox bit3;
        private System.Windows.Forms.CheckBox bit4;
        private System.Windows.Forms.CheckBox bit5;
        private System.Windows.Forms.CheckBox bit6;
        private System.Windows.Forms.CheckBox bit7;
        private System.Windows.Forms.CheckBox bit8;
        private System.Windows.Forms.CheckBox bit9;
        private System.Windows.Forms.CheckBox bit10;
        private System.Windows.Forms.CheckBox bit11;
        private System.Windows.Forms.CheckBox bit12;
        private System.Windows.Forms.CheckBox bit13;
        private System.Windows.Forms.CheckBox bit14;
        private System.Windows.Forms.CheckBox bit15;
        private System.Windows.Forms.ComboBox SerialPortComboBox;
        private System.Windows.Forms.ComboBox SerialSpeedComboBox;
    }
}

