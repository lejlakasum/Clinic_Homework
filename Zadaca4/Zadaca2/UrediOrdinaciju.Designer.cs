namespace Zadaca2
{
    partial class UrediOrdinaciju
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
            this.comboBox_Ordinacija = new System.Windows.Forms.ComboBox();
            this.label_Ordinacija = new System.Windows.Forms.Label();
            this.groupBox_Aktivnost = new System.Windows.Forms.GroupBox();
            this.radioButton_Neaktivna = new System.Windows.Forms.RadioButton();
            this.radioButton_Aktivna = new System.Windows.Forms.RadioButton();
            this.textBox_NazivOrdinacije = new System.Windows.Forms.TextBox();
            this.label_NazivOrdinacije = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelUredjivanjeOrdinacije = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_Zatvori = new System.Windows.Forms.Button();
            this.button_Zavrsi = new System.Windows.Forms.Button();
            this.button_Obrisi = new System.Windows.Forms.Button();
            this.groupBox_Aktivnost.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_Ordinacija
            // 
            this.comboBox_Ordinacija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Ordinacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_Ordinacija.FormattingEnabled = true;
            this.comboBox_Ordinacija.Location = new System.Drawing.Point(283, 38);
            this.comboBox_Ordinacija.Name = "comboBox_Ordinacija";
            this.comboBox_Ordinacija.Size = new System.Drawing.Size(260, 28);
            this.comboBox_Ordinacija.TabIndex = 21;
            // 
            // label_Ordinacija
            // 
            this.label_Ordinacija.AutoSize = true;
            this.label_Ordinacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Ordinacija.Location = new System.Drawing.Point(75, 41);
            this.label_Ordinacija.Name = "label_Ordinacija";
            this.label_Ordinacija.Size = new System.Drawing.Size(179, 20);
            this.label_Ordinacija.TabIndex = 20;
            this.label_Ordinacija.Text = "Odaberite ordinaciju";
            // 
            // groupBox_Aktivnost
            // 
            this.groupBox_Aktivnost.Controls.Add(this.radioButton_Neaktivna);
            this.groupBox_Aktivnost.Controls.Add(this.radioButton_Aktivna);
            this.groupBox_Aktivnost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_Aktivnost.Location = new System.Drawing.Point(166, 164);
            this.groupBox_Aktivnost.Name = "groupBox_Aktivnost";
            this.groupBox_Aktivnost.Size = new System.Drawing.Size(284, 67);
            this.groupBox_Aktivnost.TabIndex = 24;
            this.groupBox_Aktivnost.TabStop = false;
            // 
            // radioButton_Neaktivna
            // 
            this.radioButton_Neaktivna.AutoSize = true;
            this.radioButton_Neaktivna.Location = new System.Drawing.Point(149, 26);
            this.radioButton_Neaktivna.Name = "radioButton_Neaktivna";
            this.radioButton_Neaktivna.Size = new System.Drawing.Size(103, 24);
            this.radioButton_Neaktivna.TabIndex = 1;
            this.radioButton_Neaktivna.Text = "Zatvorena";
            this.radioButton_Neaktivna.UseVisualStyleBackColor = true;
            // 
            // radioButton_Aktivna
            // 
            this.radioButton_Aktivna.AutoSize = true;
            this.radioButton_Aktivna.Checked = true;
            this.radioButton_Aktivna.Location = new System.Drawing.Point(31, 26);
            this.radioButton_Aktivna.Name = "radioButton_Aktivna";
            this.radioButton_Aktivna.Size = new System.Drawing.Size(98, 24);
            this.radioButton_Aktivna.TabIndex = 0;
            this.radioButton_Aktivna.TabStop = true;
            this.radioButton_Aktivna.Text = "Otvorena";
            this.radioButton_Aktivna.UseVisualStyleBackColor = true;
            // 
            // textBox_NazivOrdinacije
            // 
            this.textBox_NazivOrdinacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_NazivOrdinacije.Location = new System.Drawing.Point(283, 101);
            this.textBox_NazivOrdinacije.Name = "textBox_NazivOrdinacije";
            this.textBox_NazivOrdinacije.Size = new System.Drawing.Size(260, 27);
            this.textBox_NazivOrdinacije.TabIndex = 23;
            // 
            // label_NazivOrdinacije
            // 
            this.label_NazivOrdinacije.AutoSize = true;
            this.label_NazivOrdinacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_NazivOrdinacije.Location = new System.Drawing.Point(75, 101);
            this.label_NazivOrdinacije.Name = "label_NazivOrdinacije";
            this.label_NazivOrdinacije.Size = new System.Drawing.Size(128, 20);
            this.label_NazivOrdinacije.TabIndex = 22;
            this.label_NazivOrdinacije.Text = "Naziv ordinacije";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelUredjivanjeOrdinacije});
            this.statusStrip1.Location = new System.Drawing.Point(0, 354);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(629, 22);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelUredjivanjeOrdinacije
            // 
            this.toolStripStatusLabelUredjivanjeOrdinacije.Name = "toolStripStatusLabelUredjivanjeOrdinacije";
            this.toolStripStatusLabelUredjivanjeOrdinacije.Size = new System.Drawing.Size(0, 17);
            // 
            // button_Zatvori
            // 
            this.button_Zatvori.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Zatvori.CausesValidation = false;
            this.button_Zatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Zatvori.Location = new System.Drawing.Point(421, 262);
            this.button_Zatvori.Name = "button_Zatvori";
            this.button_Zatvori.Size = new System.Drawing.Size(122, 47);
            this.button_Zatvori.TabIndex = 27;
            this.button_Zatvori.Text = "Zatvori";
            this.button_Zatvori.UseVisualStyleBackColor = false;
            this.button_Zatvori.Click += new System.EventHandler(this.button_Zatvori_Click);
            // 
            // button_Zavrsi
            // 
            this.button_Zavrsi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Zavrsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Zavrsi.Location = new System.Drawing.Point(79, 262);
            this.button_Zavrsi.Name = "button_Zavrsi";
            this.button_Zavrsi.Size = new System.Drawing.Size(122, 47);
            this.button_Zavrsi.TabIndex = 26;
            this.button_Zavrsi.Text = "&Izmjeni";
            this.button_Zavrsi.UseVisualStyleBackColor = false;
            this.button_Zavrsi.Click += new System.EventHandler(this.button_Zavrsi_Click);
            // 
            // button_Obrisi
            // 
            this.button_Obrisi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Obrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Obrisi.Location = new System.Drawing.Point(252, 262);
            this.button_Obrisi.Name = "button_Obrisi";
            this.button_Obrisi.Size = new System.Drawing.Size(122, 47);
            this.button_Obrisi.TabIndex = 28;
            this.button_Obrisi.Text = "&Obriši";
            this.button_Obrisi.UseVisualStyleBackColor = false;
            this.button_Obrisi.Click += new System.EventHandler(this.button_Obrisi_Click);
            // 
            // UrediOrdinaciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 376);
            this.Controls.Add(this.button_Obrisi);
            this.Controls.Add(this.button_Zatvori);
            this.Controls.Add(this.button_Zavrsi);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox_Aktivnost);
            this.Controls.Add(this.textBox_NazivOrdinacije);
            this.Controls.Add(this.label_NazivOrdinacije);
            this.Controls.Add(this.comboBox_Ordinacija);
            this.Controls.Add(this.label_Ordinacija);
            this.Name = "UrediOrdinaciju";
            this.Text = "UrediOrdinaciju";
            this.Load += new System.EventHandler(this.UrediOrdinaciju_Load);
            this.groupBox_Aktivnost.ResumeLayout(false);
            this.groupBox_Aktivnost.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Ordinacija;
        private System.Windows.Forms.Label label_Ordinacija;
        private System.Windows.Forms.GroupBox groupBox_Aktivnost;
        private System.Windows.Forms.RadioButton radioButton_Neaktivna;
        private System.Windows.Forms.RadioButton radioButton_Aktivna;
        private System.Windows.Forms.TextBox textBox_NazivOrdinacije;
        private System.Windows.Forms.Label label_NazivOrdinacije;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUredjivanjeOrdinacije;
        private System.Windows.Forms.Button button_Zatvori;
        private System.Windows.Forms.Button button_Zavrsi;
        private System.Windows.Forms.Button button_Obrisi;
    }
}