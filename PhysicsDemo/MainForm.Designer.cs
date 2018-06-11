namespace PhysicsDemo
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Temprature_TB = new System.Windows.Forms.TextBox();
            this.Velocity_TB = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Version_L = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.MolarMass_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.Interval_NumUD = new System.Windows.Forms.NumericUpDown();
            this.Draw_Btn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.MolarMass_Graph_TB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.End_NumUD = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Start_NumUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Interval_NumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.End_NumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start_NumUD)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea1.AxisX.Title = "T, Кельвин";
            chartArea1.AxisY.Title = "v, м/с";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(477, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Программа для вычисления средней скорости молекулы";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(30, -56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 55);
            this.panel1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(171, -56);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(198, 55);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Где R=8.31 Ж/(К*моль), \r\nu - молярная масса молекулы, \r\nT - темпратура молукулы";
            // 
            // Temprature_TB
            // 
            this.Temprature_TB.Location = new System.Drawing.Point(17, 175);
            this.Temprature_TB.Name = "Temprature_TB";
            this.Temprature_TB.Size = new System.Drawing.Size(264, 20);
            this.Temprature_TB.TabIndex = 1;
            this.Temprature_TB.TextChanged += new System.EventHandler(this.Temprature_TB_TextChanged);
            // 
            // Velocity_TB
            // 
            this.Velocity_TB.Location = new System.Drawing.Point(15, 294);
            this.Velocity_TB.Name = "Velocity_TB";
            this.Velocity_TB.ReadOnly = true;
            this.Velocity_TB.Size = new System.Drawing.Size(264, 20);
            this.Velocity_TB.TabIndex = 12;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(485, 422);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.Version_L);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.Velocity_TB);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.MolarMass_TB);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.Temprature_TB);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(477, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Формула";
            // 
            // Version_L
            // 
            this.Version_L.AutoSize = true;
            this.Version_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Version_L.Location = new System.Drawing.Point(147, 377);
            this.Version_L.Name = "Version_L";
            this.Version_L.Size = new System.Drawing.Size(41, 13);
            this.Version_L.TabIndex = 16;
            this.Version_L.Text = "version";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(15, 377);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Developed by SuxrobGM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Формула";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Введите молярная масса молекулы(u, кг/моль)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(17, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Средняя скорость молекулы(v, м/с) равно:";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(15, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 65);
            this.panel2.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(168, 47);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(198, 65);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "Где R = 8.31 Ж/(К*моль), \r\nu - молярная масса молекулы, \r\nT - темпратура молукулы" +
    ",\r\nPi = 3.14";
            // 
            // MolarMass_TB
            // 
            this.MolarMass_TB.Location = new System.Drawing.Point(17, 234);
            this.MolarMass_TB.Name = "MolarMass_TB";
            this.MolarMass_TB.Size = new System.Drawing.Size(264, 20);
            this.MolarMass_TB.TabIndex = 2;
            this.MolarMass_TB.TextChanged += new System.EventHandler(this.MolarMass_TB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введите темратура молекулы(T, Кельвин)";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.Interval_NumUD);
            this.tabPage2.Controls.Add(this.Draw_Btn);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.MolarMass_Graph_TB);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.End_NumUD);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.Start_NumUD);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(477, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "График";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(55, 352);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Интервал dT:";
            // 
            // Interval_NumUD
            // 
            this.Interval_NumUD.Location = new System.Drawing.Point(55, 367);
            this.Interval_NumUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Interval_NumUD.Name = "Interval_NumUD";
            this.Interval_NumUD.Size = new System.Drawing.Size(58, 20);
            this.Interval_NumUD.TabIndex = 10;
            this.Interval_NumUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Draw_Btn
            // 
            this.Draw_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Draw_Btn.Location = new System.Drawing.Point(196, 364);
            this.Draw_Btn.Name = "Draw_Btn";
            this.Draw_Btn.Size = new System.Drawing.Size(87, 23);
            this.Draw_Btn.TabIndex = 9;
            this.Draw_Btn.Text = "Нарисовать";
            this.Draw_Btn.UseVisualStyleBackColor = true;
            this.Draw_Btn.Click += new System.EventHandler(this.Draw_Btn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(79, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "---";
            // 
            // MolarMass_Graph_TB
            // 
            this.MolarMass_Graph_TB.Location = new System.Drawing.Point(196, 321);
            this.MolarMass_Graph_TB.Name = "MolarMass_Graph_TB";
            this.MolarMass_Graph_TB.Size = new System.Drawing.Size(154, 20);
            this.MolarMass_Graph_TB.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(193, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Молярная масса(u, кг/моль):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(106, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Конец";
            // 
            // End_NumUD
            // 
            this.End_NumUD.Location = new System.Drawing.Point(106, 322);
            this.End_NumUD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.End_NumUD.Minimum = new decimal(new int[] {
            273,
            0,
            0,
            -2147483648});
            this.End_NumUD.Name = "End_NumUD";
            this.End_NumUD.Size = new System.Drawing.Size(58, 20);
            this.End_NumUD.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(11, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Начало";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(8, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Темпратура(T, Кельвин):";
            // 
            // Start_NumUD
            // 
            this.Start_NumUD.Location = new System.Drawing.Point(11, 322);
            this.Start_NumUD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Start_NumUD.Minimum = new decimal(new int[] {
            273,
            0,
            0,
            -2147483648});
            this.Start_NumUD.Name = "Start_NumUD";
            this.Start_NumUD.Size = new System.Drawing.Size(58, 20);
            this.Start_NumUD.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(485, 422);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "Physics Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Interval_NumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.End_NumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start_NumUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;      
        private System.Windows.Forms.Panel panel1;       
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Temprature_TB;
        private System.Windows.Forms.TextBox Velocity_TB;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox MolarMass_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Start_NumUD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox MolarMass_Graph_TB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown End_NumUD;
        private System.Windows.Forms.Button Draw_Btn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Version_L;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown Interval_NumUD;
    }
}

