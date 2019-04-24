namespace Zadaca2
{
    partial class UrediAparat
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
            this.labelOdabirAparata = new System.Windows.Forms.Label();
            this.comboBox_Aparati = new System.Windows.Forms.ComboBox();
            this.button_Zatvori = new System.Windows.Forms.Button();
            this.button_Izmjeni = new System.Windows.Forms.Button();
            this.comboBox_Ordinacija = new System.Windows.Forms.ComboBox();
            this.label_Ordinacija = new System.Windows.Forms.Label();
            this.groupBox_Aktivnost = new System.Windows.Forms.GroupBox();
            this.radioButton_Neaktivna = new System.Windows.Forms.RadioButton();
            this.radioButton_Aktivna = new System.Windows.Forms.RadioButton();
            this.textBox_NazivAparata = new System.Windows.Forms.TextBox();
            this.label_NazivAparata = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelUredjivanjeAparata = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_Obrisi = new System.Windows.Forms.Button();
            this.groupBox_Aktivnost.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelOdabirAparata
            // 
            this.labelOdabirAparata.AutoSize = true;
            this.labelOdabirAparata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOdabirAparata.Location = new System.Drawing.Point(80, 55);
            this.labelOdabirAparata.Name = "labelOdabirAparata";
            this.labelOdabirAparata.Size = new System.Drawing.Size(150, 20);
            this.labelOdabirAparata.TabIndex = 0;
            this.labelOdabirAparata.Text = "Odaberite aparat";
            // 
            // comboBox_Aparati
            // 
            this.comboBox_Aparati.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Aparati.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_Aparati.FormattingEnabled = true;
            this.comboBox_Aparati.Location = new System.Drawing.Point(343, 55);
            this.comboBox_Aparati.Name = "comboBox_Aparati";
            this.comboBox_Aparati.Size = new System.Drawing.Size(326, 28);
            this.comboBox_Aparati.TabIndex = 22;
            this.comboBox_Aparati.SelectedIndexChanged += new System.EventHandler(this.comboBox_Aparati_SelectedIndexChanged);
            // 
            // button_Zatvori
            // 
            this.button_Zatvori.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Zatvori.CausesValidation = false;
            this.button_Zatvori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Zatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Zatvori.Location = new System.Drawing.Point(563, 343);
            this.button_Zatvori.Name = "button_Zatvori";
            this.button_Zatvori.Size = new System.Drawing.Size(106, 37);
            this.button_Zatvori.TabIndex = 30;
            this.button_Zatvori.Text = "Zatvori";
            this.button_Zatvori.UseVisualStyleBackColor = false;
            this.button_Zatvori.Click += new System.EventHandler(this.button_Zatvori_Click);
            // 
            // button_Izmjeni
            // 
            this.button_Izmjeni.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Izmjeni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Izmjeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Izmjeni.Location = new System.Drawing.Point(296, 343);
            this.button_Izmjeni.Name = "button_Izmjeni";
            this.button_Izmjeni.Size = new System.Drawing.Size(106, 37);
            this.button_Izmjeni.TabIndex = 29;
            this.button_Izmjeni.Text = "&Izmjeni";
            this.button_Izmjeni.UseVisualStyleBackColor = false;
            this.button_Izmjeni.Click += new System.EventHandler(this.button_Izmjeni_Click);
            // 
            // comboBox_Ordinacija
            // 
            this.comboBox_Ordinacija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Ordinacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_Ordinacija.FormattingEnabled = true;
            this.comboBox_Ordinacija.Location = new System.Drawing.Point(343, 151);
            this.comboBox_Ordinacija.Name = "comboBox_Ordinacija";
            this.comboBox_Ordinacija.Size = new System.Drawing.Size(326, 28);
            this.comboBox_Ordinacija.TabIndex = 28;
            // 
            // label_Ordinacija
            // 
            this.label_Ordinacija.AutoSize = true;
            this.label_Ordinacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Ordinacija.Location = new System.Drawing.Point(80, 154);
            this.label_Ordinacija.Name = "label_Ordinacija";
            this.label_Ordinacija.Size = new System.Drawing.Size(225, 20);
            this.label_Ordinacija.TabIndex = 27;
            this.label_Ordinacija.Text = "Ordinacija u koju je smješten";
            // 
            // groupBox_Aktivnost
            // 
            this.groupBox_Aktivnost.Controls.Add(this.radioButton_Neaktivna);
            this.groupBox_Aktivnost.Controls.Add(this.radioButton_Aktivna);
            this.groupBox_Aktivnost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_Aktivnost.Location = new System.Drawing.Point(362, 216);
            this.groupBox_Aktivnost.Name = "groupBox_Aktivnost";
            this.groupBox_Aktivnost.Size = new System.Drawing.Size(284, 67);
            this.groupBox_Aktivnost.TabIndex = 26;
            this.groupBox_Aktivnost.TabStop = false;
            // 
            // radioButton_Neaktivna
            // 
            this.radioButton_Neaktivna.AutoSize = true;
            this.radioButton_Neaktivna.Location = new System.Drawing.Point(149, 26);
            this.radioButton_Neaktivna.Name = "radioButton_Neaktivna";
            this.radioButton_Neaktivna.Size = new System.Drawing.Size(84, 24);
            this.radioButton_Neaktivna.TabIndex = 1;
            this.radioButton_Neaktivna.Text = "Ne radi";
            this.radioButton_Neaktivna.UseVisualStyleBackColor = true;
            // 
            // radioButton_Aktivna
            // 
            this.radioButton_Aktivna.AutoSize = true;
            this.radioButton_Aktivna.Checked = true;
            this.radioButton_Aktivna.Location = new System.Drawing.Point(31, 26);
            this.radioButton_Aktivna.Name = "radioButton_Aktivna";
            this.radioButton_Aktivna.Size = new System.Drawing.Size(64, 24);
            this.radioButton_Aktivna.TabIndex = 0;
            this.radioButton_Aktivna.TabStop = true;
            this.radioButton_Aktivna.Text = "Radi";
            this.radioButton_Aktivna.UseVisualStyleBackColor = true;
            // 
            // textBox_NazivAparata
            // 
            this.textBox_NazivAparata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_NazivAparata.Location = new System.Drawing.Point(343, 101);
            this.textBox_NazivAparata.Name = "textBox_NazivAparata";
            this.textBox_NazivAparata.Size = new System.Drawing.Size(326, 27);
            this.textBox_NazivAparata.TabIndex = 25;
            // 
            // label_NazivAparata
            // 
            this.label_NazivAparata.AutoSize = true;
            this.label_NazivAparata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_NazivAparata.Location = new System.Drawing.Point(80, 104);
            this.label_NazivAparata.Name = "label_NazivAparata";
            this.label_NazivAparata.Size = new System.Drawing.Size(112, 20);
            this.label_NazivAparata.TabIndex = 24;
            this.label_NazivAparata.Text = "Naziv aparata";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelUredjivanjeAparata});
            this.statusStrip1.Location = new System.Drawing.Point(0, 427);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(779, 22);
            this.statusStrip1.TabIndex = 31;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelUredjivanjeAparata
            // 
            this.toolStripStatusLabelUredjivanjeAparata.Name = "toolStripStatusLabelUredjivanjeAparata";
            this.toolStripStatusLabelUredjivanjeAparata.Size = new System.Drawing.Size(0, 17);
            // 
            // button_Obrisi
            // 
            this.button_Obrisi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Obrisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Obrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Obrisi.Location = new System.Drawing.Point(428, 343);
            this.button_Obrisi.Name = "button_Obrisi";
            this.button_Obrisi.Size = new System.Drawing.Size(106, 37);
            this.button_Obrisi.TabIndex = 32;
            this.button_Obrisi.Text = "&Obriši";
            this.button_Obrisi.UseVisualStyleBackColor = false;
            this.button_Obrisi.Click += new System.EventHandler(this.button_Obrisi_Click);
            // 
            // UrediAparat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 449);
            this.Controls.Add(this.button_Obrisi);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_Zatvori);
            this.Controls.Add(this.button_Izmjeni);
            this.Controls.Add(this.comboBox_Ordinacija);
            this.Controls.Add(this.label_Ordinacija);
            this.Controls.Add(this.groupBox_Aktivnost);
            this.Controls.Add(this.textBox_NazivAparata);
            this.Controls.Add(this.label_NazivAparata);
            this.Controls.Add(this.comboBox_Aparati);
            this.Controls.Add(this.labelOdabirAparata);
            this.Name = "UrediAparat";
            this.Text = "Uređivanje aparata";
            this.Load += new System.EventHandler(this.UrediAparat_Load);
            this.groupBox_Aktivnost.ResumeLayout(false);
            this.groupBox_Aktivnost.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOdabirAparata;
        private System.Windows.Forms.ComboBox comboBox_Aparati;
        private System.Windows.Forms.Button button_Zatvori;
        private System.Windows.Forms.Button button_Izmjeni;
        private System.Windows.Forms.ComboBox comboBox_Ordinacija;
        private System.Windows.Forms.Label label_Ordinacija;
        private System.Windows.Forms.GroupBox groupBox_Aktivnost;
        private System.Windows.Forms.RadioButton radioButton_Neaktivna;
        private System.Windows.Forms.RadioButton radioButton_Aktivna;
        private System.Windows.Forms.TextBox textBox_NazivAparata;
        private System.Windows.Forms.Label label_NazivAparata;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUredjivanjeAparata;
        private System.Windows.Forms.Button button_Obrisi;
    }
}