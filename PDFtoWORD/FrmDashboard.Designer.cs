namespace PDFtoWORD
{
    partial class FrmDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.BtnCargarExcel = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Caracteristica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Con_Scaner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SinScaner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCargarExcel
            // 
            this.BtnCargarExcel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnCargarExcel.IconColor = System.Drawing.Color.Black;
            this.BtnCargarExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCargarExcel.Location = new System.Drawing.Point(591, 18);
            this.BtnCargarExcel.Name = "BtnCargarExcel";
            this.BtnCargarExcel.Size = new System.Drawing.Size(188, 23);
            this.BtnCargarExcel.TabIndex = 0;
            this.BtnCargarExcel.Text = "Cargar Datos";
            this.BtnCargarExcel.UseVisualStyleBackColor = true;
            this.BtnCargarExcel.Click += new System.EventHandler(this.BtnCargarExcel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnCargarExcel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 63);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 624);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Caracteristica,
            this.Con_Scaner,
            this.SinScaner});
            this.dataGridView1.Location = new System.Drawing.Point(73, 445);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(358, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // Caracteristica
            // 
            this.Caracteristica.HeaderText = "";
            this.Caracteristica.Name = "Caracteristica";
            this.Caracteristica.ReadOnly = true;
            // 
            // Con_Scaner
            // 
            this.Con_Scaner.HeaderText = "Con_Scaner";
            this.Con_Scaner.Name = "Con_Scaner";
            this.Con_Scaner.ReadOnly = true;
            // 
            // SinScaner
            // 
            this.SinScaner.HeaderText = "SinScaner";
            this.SinScaner.Name = "SinScaner";
            this.SinScaner.ReadOnly = true;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.chart1.BorderlineColor = System.Drawing.Color.Tomato;
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineWidth = 0;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.SystemColors.ButtonFace;
            chartArea2.AxisX.MajorGrid.LineWidth = 0;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea2.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated90;
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.Blue;
            chartArea2.AxisX2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated90;
            chartArea2.AxisX2.TitleForeColor = System.Drawing.Color.BlueViolet;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LabelStyle.Format = "S/.{0}";
            chartArea2.AxisY.LineColor = System.Drawing.Color.BlanchedAlmond;
            chartArea2.AxisY.LineWidth = 0;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea2.AxisY.MajorTickMark.LineWidth = 0;
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 17);
            this.chart1.Name = "chart1";
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series3.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            series3.IsValueShownAsLabel = true;
            series3.IsXValueIndexed = true;
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.Name = "Con Scaner";
            series3.SmartLabelStyle.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.LabelCalloutStyle.None;
            series4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            series4.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            series4.IsValueShownAsLabel = true;
            series4.IsXValueIndexed = true;
            series4.LabelForeColor = System.Drawing.Color.White;
            series4.Legend = "Legend1";
            series4.Name = "Sin Scaner";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(960, 374);
            this.chart1.TabIndex = 78;
            this.chart1.Text = "chart1";
            title2.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title2.ForeColor = System.Drawing.Color.White;
            title2.Name = "Title1";
            title2.Text = "GANACIAS";
            this.chart1.Titles.Add(title2);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.Location = new System.Drawing.Point(502, 421);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(358, 150);
            this.dataGridView2.TabIndex = 79;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Con_Scaner";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "SinScaner";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 687);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDashboard";
            this.Text = "FrmDashboard";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnCargarExcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caracteristica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Con_Scaner;
        private System.Windows.Forms.DataGridViewTextBoxColumn SinScaner;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}