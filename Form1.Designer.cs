namespace BorNaplo
{
    partial class FoMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HozzaAdas = new Button();
            Torles = new Button();
            Kijelzo = new ListBox();
            Betoltes = new Button();
            BorNeve = new TextBox();
            BorFajtaja = new ComboBox();
            label1 = new Label();
            BorEvjarata = new DateTimePicker();
            SzoloFajtaja = new TextBox();
            PinceszetNeve = new TextBox();
            KostolasIdopontja = new DateTimePicker();
            KostolasHelyszine = new TextBox();
            RovidErtekeles = new TextBox();
            trackBar1 = new TrackBar();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            Ertekeles_1tol_5ig = new Label();
            Modositas = new Button();
            EloszlasGrafikon = new Button();
            Lekerdezesek = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // HozzaAdas
            // 
            HozzaAdas.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            HozzaAdas.Location = new Point(612, 12);
            HozzaAdas.Name = "HozzaAdas";
            HozzaAdas.Size = new Size(96, 23);
            HozzaAdas.TabIndex = 0;
            HozzaAdas.Text = "HozzaAdas";
            HozzaAdas.UseVisualStyleBackColor = true;
            HozzaAdas.Click += HozzaAdas_Click;
            // 
            // Torles
            // 
            Torles.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            Torles.Location = new Point(12, 429);
            Torles.Name = "Torles";
            Torles.Size = new Size(190, 23);
            Torles.TabIndex = 1;
            Torles.Text = "Torles";
            Torles.UseVisualStyleBackColor = true;
            Torles.Click += Torles_Click;
            // 
            // Kijelzo
            // 
            Kijelzo.Font = new Font("Comic Sans MS", 6.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            Kijelzo.FormattingEnabled = true;
            Kijelzo.ItemHeight = 14;
            Kijelzo.Location = new Point(12, 41);
            Kijelzo.Name = "Kijelzo";
            Kijelzo.Size = new Size(593, 382);
            Kijelzo.TabIndex = 2;
            Kijelzo.SelectedIndexChanged += Kijelzo_SelectedIndexChanged;
            // 
            // Betoltes
            // 
            Betoltes.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Betoltes.Location = new Point(12, 12);
            Betoltes.Name = "Betoltes";
            Betoltes.Size = new Size(593, 23);
            Betoltes.TabIndex = 3;
            Betoltes.Text = "Betoltes";
            Betoltes.UseVisualStyleBackColor = true;
            Betoltes.Click += Betoltes_Click;
            // 
            // BorNeve
            // 
            BorNeve.Location = new Point(612, 61);
            BorNeve.Name = "BorNeve";
            BorNeve.Size = new Size(201, 23);
            BorNeve.TabIndex = 4;
            BorNeve.TextChanged += BorNeve_TextChanged;
            // 
            // BorFajtaja
            // 
            BorFajtaja.FormattingEnabled = true;
            BorFajtaja.Items.AddRange(new object[] { "Roze", "Feher", "Voros", "Aszu", "BikaVer", "Furmint", "Kadarka", "PinotNoir", "Merlot", "Chardonnay", "Tablettas", "Egyeb" });
            BorFajtaja.Location = new Point(612, 110);
            BorFajtaja.Name = "BorFajtaja";
            BorFajtaja.Size = new Size(201, 23);
            BorFajtaja.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 192, 0);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(612, 38);
            label1.Name = "label1";
            label1.Size = new Size(200, 20);
            label1.TabIndex = 6;
            label1.Text = "             Bor Neve              ";
            // 
            // BorEvjarata
            // 
            BorEvjarata.Location = new Point(613, 159);
            BorEvjarata.Name = "BorEvjarata";
            BorEvjarata.Size = new Size(200, 23);
            BorEvjarata.TabIndex = 8;
            // 
            // SzoloFajtaja
            // 
            SzoloFajtaja.Location = new Point(613, 208);
            SzoloFajtaja.Name = "SzoloFajtaja";
            SzoloFajtaja.Size = new Size(200, 23);
            SzoloFajtaja.TabIndex = 9;
            // 
            // PinceszetNeve
            // 
            PinceszetNeve.Location = new Point(613, 257);
            PinceszetNeve.Name = "PinceszetNeve";
            PinceszetNeve.Size = new Size(200, 23);
            PinceszetNeve.TabIndex = 11;
            // 
            // KostolasIdopontja
            // 
            KostolasIdopontja.Location = new Point(613, 306);
            KostolasIdopontja.Name = "KostolasIdopontja";
            KostolasIdopontja.Size = new Size(200, 23);
            KostolasIdopontja.TabIndex = 12;
            // 
            // KostolasHelyszine
            // 
            KostolasHelyszine.Location = new Point(613, 355);
            KostolasHelyszine.Name = "KostolasHelyszine";
            KostolasHelyszine.Size = new Size(200, 23);
            KostolasHelyszine.TabIndex = 13;
            // 
            // RovidErtekeles
            // 
            RovidErtekeles.Location = new Point(613, 406);
            RovidErtekeles.Name = "RovidErtekeles";
            RovidErtekeles.Size = new Size(200, 23);
            RovidErtekeles.TabIndex = 14;
            // 
            // trackBar1
            // 
            trackBar1.LargeChange = 1;
            trackBar1.Location = new Point(705, 435);
            trackBar1.Maximum = 5;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(104, 45);
            trackBar1.TabIndex = 15;
            trackBar1.Value = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 192, 0);
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(612, 87);
            label2.Name = "label2";
            label2.Size = new Size(199, 20);
            label2.TabIndex = 16;
            label2.Text = "            Bor Fajtaja            ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 192, 0);
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(613, 136);
            label3.Name = "label3";
            label3.Size = new Size(197, 20);
            label3.TabIndex = 17;
            label3.Text = "            Bor Evjarata          ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 192, 0);
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(613, 185);
            label4.Name = "label4";
            label4.Size = new Size(198, 20);
            label4.TabIndex = 18;
            label4.Text = "           Szolo Fajtaja           ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 192, 0);
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(613, 234);
            label5.Name = "label5";
            label5.Size = new Size(198, 20);
            label5.TabIndex = 19;
            label5.Text = "          Pinceszet Neve          ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(0, 192, 0);
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(613, 283);
            label6.Name = "label6";
            label6.Size = new Size(197, 20);
            label6.TabIndex = 20;
            label6.Text = "         Kostolas Idopntja        ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(0, 192, 0);
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(613, 332);
            label7.Name = "label7";
            label7.Size = new Size(196, 20);
            label7.TabIndex = 21;
            label7.Text = "        Kostolas Helyszine        ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(0, 192, 0);
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(613, 383);
            label8.Name = "label8";
            label8.Size = new Size(196, 20);
            label8.TabIndex = 22;
            label8.Text = "          Rovid Ertekeles         ";
            // 
            // Ertekeles_1tol_5ig
            // 
            Ertekeles_1tol_5ig.AutoSize = true;
            Ertekeles_1tol_5ig.BackColor = Color.FromArgb(0, 192, 0);
            Ertekeles_1tol_5ig.BorderStyle = BorderStyle.Fixed3D;
            Ertekeles_1tol_5ig.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Ertekeles_1tol_5ig.ForeColor = Color.Black;
            Ertekeles_1tol_5ig.Location = new Point(612, 435);
            Ertekeles_1tol_5ig.Name = "Ertekeles_1tol_5ig";
            Ertekeles_1tol_5ig.Size = new Size(96, 20);
            Ertekeles_1tol_5ig.TabIndex = 23;
            Ertekeles_1tol_5ig.Text = "   Ertekeles   ";
            // 
            // Modositas
            // 
            Modositas.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Modositas.Location = new Point(718, 12);
            Modositas.Name = "Modositas";
            Modositas.Size = new Size(95, 23);
            Modositas.TabIndex = 24;
            Modositas.Text = "Modositas";
            Modositas.UseVisualStyleBackColor = true;
            Modositas.Click += Modositas_Click;
            // 
            // EloszlasGrafikon
            // 
            EloszlasGrafikon.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            EloszlasGrafikon.Location = new Point(208, 429);
            EloszlasGrafikon.Name = "EloszlasGrafikon";
            EloszlasGrafikon.Size = new Size(200, 23);
            EloszlasGrafikon.TabIndex = 25;
            EloszlasGrafikon.Text = "EloszlasGrafikon";
            EloszlasGrafikon.UseVisualStyleBackColor = true;
            EloszlasGrafikon.Click += EloszlasGrafikon_Click;
            // 
            // Lekerdezesek
            // 
            Lekerdezesek.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Lekerdezesek.Location = new Point(414, 429);
            Lekerdezesek.Name = "Lekerdezesek";
            Lekerdezesek.Size = new Size(190, 23);
            Lekerdezesek.TabIndex = 26;
            Lekerdezesek.Text = "Lekerdezesek";
            Lekerdezesek.UseVisualStyleBackColor = true;
            Lekerdezesek.Click += Lekerdezesek_Click;
            // 
            // FoMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(820, 462);
            Controls.Add(Lekerdezesek);
            Controls.Add(EloszlasGrafikon);
            Controls.Add(Modositas);
            Controls.Add(Ertekeles_1tol_5ig);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(trackBar1);
            Controls.Add(RovidErtekeles);
            Controls.Add(KostolasHelyszine);
            Controls.Add(KostolasIdopontja);
            Controls.Add(PinceszetNeve);
            Controls.Add(SzoloFajtaja);
            Controls.Add(BorEvjarata);
            Controls.Add(label1);
            Controls.Add(BorFajtaja);
            Controls.Add(BorNeve);
            Controls.Add(Betoltes);
            Controls.Add(Kijelzo);
            Controls.Add(Torles);
            Controls.Add(HozzaAdas);
            Name = "FoMenu";
            Text = "UltraMeno_AlkeszAdatbazis_Technologia _V_69";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button HozzaAdas;
        private Button Torles;
        private ListBox Kijelzo;
        private Button Betoltes;
        private TextBox BorNeve;
        private ComboBox BorFajtaja;
        private Label label1;
        private DateTimePicker BorEvjarata;
        private TextBox SzoloFajtaja;
        private TextBox PinceszetNeve;
        private DateTimePicker KostolasIdopontja;
        private TextBox KostolasHelyszine;
        private TextBox RovidErtekeles;
        private TrackBar trackBar1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label Ertekeles_1tol_5ig;
        private Button Modositas;
        private Button EloszlasGrafikon;
        private Button Lekerdezesek;
    }
}