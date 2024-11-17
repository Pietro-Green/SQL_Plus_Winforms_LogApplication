namespace BorNaplo
{
    partial class Form3
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
            FoMenu = new Button();
            BorFajta = new ComboBox();
            Pinceszet = new TextBox();
            SzoloFajta = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Ertekeles = new TrackBar();
            Kijelzo = new ListBox();
            ((System.ComponentModel.ISupportInitialize)Ertekeles).BeginInit();
            SuspendLayout();
            // 
            // FoMenu
            // 
            FoMenu.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            FoMenu.Location = new Point(12, 12);
            FoMenu.Name = "FoMenu";
            FoMenu.Size = new Size(75, 23);
            FoMenu.TabIndex = 0;
            FoMenu.Text = "FoMenu";
            FoMenu.UseVisualStyleBackColor = true;
            FoMenu.Click += FoMenu_Click;
            // 
            // BorFajta
            // 
            BorFajta.FormattingEnabled = true;
            BorFajta.Items.AddRange(new object[] { "Roze", "Feher", "Voros", "Aszu", "BikaVer", "Furmint", "Kadarka", "PinotNoir", "Merlot", "Chardonnay", "Tablettas", "Egyeb" });
            BorFajta.Location = new Point(336, 12);
            BorFajta.Name = "BorFajta";
            BorFajta.Size = new Size(121, 23);
            BorFajta.TabIndex = 2;
            BorFajta.SelectedIndexChanged += BorFajta_SelectedIndexChanged;
            // 
            // Pinceszet
            // 
            Pinceszet.Location = new Point(162, 12);
            Pinceszet.Name = "Pinceszet";
            Pinceszet.Size = new Size(100, 23);
            Pinceszet.TabIndex = 3;
            Pinceszet.TextChanged += Pinceszet_TextChanged;
            // 
            // SzoloFajta
            // 
            SzoloFajta.Location = new Point(540, 12);
            SzoloFajta.Name = "SzoloFajta";
            SzoloFajta.Size = new Size(100, 23);
            SzoloFajta.TabIndex = 4;
            SzoloFajta.TextChanged += SzoloFajta_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 192, 0);
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(93, 12);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 8;
            label2.Text = "Pinceszet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 192, 0);
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(268, 12);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 9;
            label3.Text = "BorFajta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 192, 0);
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(646, 14);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 10;
            label4.Text = "Ertekeles";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 192, 0);
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(463, 12);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 11;
            label5.Text = "SzoloFajta";
            // 
            // Ertekeles
            // 
            Ertekeles.LargeChange = 1;
            Ertekeles.Location = new Point(718, 12);
            Ertekeles.Maximum = 5;
            Ertekeles.Minimum = 1;
            Ertekeles.Name = "Ertekeles";
            Ertekeles.Size = new Size(70, 45);
            Ertekeles.TabIndex = 16;
            Ertekeles.Value = 5;
            Ertekeles.Scroll += Ertekeles_Scroll;
            // 
            // Kijelzo
            // 
            Kijelzo.FormattingEnabled = true;
            Kijelzo.ItemHeight = 15;
            Kijelzo.Location = new Point(12, 41);
            Kijelzo.Name = "Kijelzo";
            Kijelzo.Size = new Size(776, 394);
            Kijelzo.TabIndex = 17;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(Kijelzo);
            Controls.Add(Ertekeles);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(SzoloFajta);
            Controls.Add(Pinceszet);
            Controls.Add(BorFajta);
            Controls.Add(FoMenu);
            Name = "Form3";
            Text = "Lekerdezesek";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)Ertekeles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FoMenu;
        private ComboBox BorFajta;
        private TextBox Pinceszet;
        private TextBox SzoloFajta;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TrackBar Ertekeles;
        private ListBox Kijelzo;
    }
}