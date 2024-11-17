namespace BorNaplo
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            X = new Button();
            BorKategoriaMegoszlas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            Veg = new DateTimePicker();
            Kezdet = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)BorKategoriaMegoszlas).BeginInit();
            SuspendLayout();
            // 
            // X
            // 
            X.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            X.Location = new Point(12, 12);
            X.Name = "X";
            X.Size = new Size(188, 23);
            X.TabIndex = 0;
            X.Text = "FoMenu";
            X.UseVisualStyleBackColor = true;
            X.Click += X_Click;
            // 
            // BorKategoriaMegoszlas
            // 
            BorKategoriaMegoszlas.BackColor = Color.FromArgb(0, 192, 192);
            BorKategoriaMegoszlas.BorderlineColor = Color.FromArgb(0, 192, 192);
            BorKategoriaMegoszlas.BorderSkin.PageColor = Color.FromArgb(0, 192, 192);
            chartArea1.BackColor = Color.FromArgb(0, 192, 192);
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            chartArea1.BackSecondaryColor = Color.FromArgb(0, 192, 192);
            chartArea1.Name = "ChartArea1";
            BorKategoriaMegoszlas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            BorKategoriaMegoszlas.Legends.Add(legend1);
            BorKategoriaMegoszlas.Location = new Point(12, 41);
            BorKategoriaMegoszlas.Name = "BorKategoriaMegoszlas";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = Color.FromArgb(0, 192, 192);
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            BorKategoriaMegoszlas.Series.Add(series1);
            BorKategoriaMegoszlas.Size = new Size(600, 600);
            BorKategoriaMegoszlas.TabIndex = 1;
            BorKategoriaMegoszlas.Text = "chart1";
            // 
            // Veg
            // 
            Veg.Location = new Point(412, 12);
            Veg.Name = "Veg";
            Veg.Size = new Size(200, 23);
            Veg.TabIndex = 3;
            Veg.ValueChanged += Veg_ValueChanged;
            // 
            // Kezdet
            // 
            Kezdet.Location = new Point(206, 12);
            Kezdet.Name = "Kezdet";
            Kezdet.Size = new Size(200, 23);
            Kezdet.TabIndex = 4;
            Kezdet.Value = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            Kezdet.ValueChanged += Kezdet_ValueChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(624, 651);
            Controls.Add(Kezdet);
            Controls.Add(Veg);
            Controls.Add(BorKategoriaMegoszlas);
            Controls.Add(X);
            Name = "Form2";
            Text = "EloszlasGrafikon";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)BorKategoriaMegoszlas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button X;
        private System.Windows.Forms.DataVisualization.Charting.Chart BorKategoriaMegoszlas;
        private DateTimePicker Veg;
        private DateTimePicker Kezdet;
    }
}