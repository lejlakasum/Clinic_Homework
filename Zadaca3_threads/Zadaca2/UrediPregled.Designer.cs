namespace Zadaca2
{
    partial class UrediPregled
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
            this.button_Zatvori = new System.Windows.Forms.Button();
            this.button_Dodaj = new System.Windows.Forms.Button();
            this.numericUpDown_Cijena = new System.Windows.Forms.NumericUpDown();
            this.label_Cijena = new System.Windows.Forms.Label();
            this.comboBox_Ordinacija = new System.Windows.Forms.ComboBox();
            this.label_Ordinacija = new System.Windows.Forms.Label();
            this.textBox_NazivPregleda = new System.Windows.Forms.TextBox();
            this.label_NazivPregleda = new System.Windows.Forms.Label();
            this.comboBox_Pregledi = new System.Windows.Forms.ComboBox();
            this.label_OdabirPregleda = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelUredjivanjePregleda = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_Obrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Cijena)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Zatvori
            // 
            this.button_Zatvori.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Zatvori.CausesValidation = false;
            this.button_Zatvori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Zatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Zatvori.Location = new System.Drawing.Point(449, 287);
            this.button_Zatvori.Name = "button_Zatvori";
            this.button_Zatvori.Size = new System.Drawing.Size(106, 37);
            this.button_Zatvori.TabIndex = 37;
            this.button_Zatvori.Text = "Zatvori";
            this.button_Zatvori.UseVisualStyleBackColor = false;
            this.button_Zatvori.Click += new System.EventHandler(this.button_Zatvori_Click);
            // 
            // button_Dodaj
            // 
            this.button_Dodaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Dodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Dodaj.Location = new System.Drawing.Point(180, 287);
            this.button_Dodaj.Name = "button_Dodaj";
            this.button_Dodaj.Size = new System.Drawing.Size(106, 37);
            this.button_Dodaj.TabIndex = 36;
            this.button_Dodaj.Text = "Dodaj";
            this.button_Dodaj.UseVisualStyleBackColor = false;
            this.button_Dodaj.Click += new System.EventHandler(this.button_Dodaj_Click);
            // 
            // numericUpDown_Cijena
            // 
            this.numericUpDown_Cijena.DecimalPlaces = 1;
            this.numericUpDown_Cijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_Cijena.Location = new System.Drawing.Point(300, 203);
            this.numericUpDown_Cijena.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_Cijena.Name = "numericUpDown_Cijena";
            this.numericUpDown_Cijena.Size = new System.Drawing.Size(212, 27);
            this.numericUpDown_Cijena.TabIndex = 35;
            // 
            // label_Cijena
            // 
            this.label_Cijena.AutoSize = true;
            this.label_Cijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Cijena.Location = new System.Drawing.Point(55, 205);
            this.label_Cijena.Name = "label_Cijena";
            this.label_Cijena.Size = new System.Drawing.Size(125, 20);
            this.label_Cijena.TabIndex = 34;
            this.label_Cijena.Text = "Cijena pregleda";
            // 
            // comboBox_Ordinacija
            // 
            this.comboBox_Ordinacija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Ordinacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_Ordinacija.FormattingEnabled = true;
            this.comboBox_Ordinacija.Location = new System.Drawing.Point(300, 151);
            this.comboBox_Ordinacija.Name = "comboBox_Ordinacija";
            this.comboBox_Ordinacija.Size = new System.Drawing.Size(326, 28);
            this.comboBox_Ordinacija.TabIndex = 33;
            // 
            // label_Ordinacija
            // 
            this.label_Ordinacija.AutoSize = true;
            this.label_Ordinacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Ordinacija.Location = new System.Drawing.Point(55, 154);
            this.label_Ordinacija.Name = "label_Ordinacija";
            this.label_Ordinacija.Size = new System.Drawing.Size(218, 20);
            this.label_Ordinacija.TabIndex = 32;
            this.label_Ordinacija.Text = "Ordinacija u kojoj se obavlja";
            // 
            // textBox_NazivPregleda
            // 
            this.textBox_NazivPregleda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_NazivPregleda.Location = new System.Drawing.Point(300, 96);
            this.textBox_NazivPregleda.Name = "textBox_NazivPregleda";
            this.textBox_NazivPregleda.Size = new System.Drawing.Size(326, 27);
            this.textBox_NazivPregleda.TabIndex = 31;
            // 
            // label_NazivPregleda
            // 
            this.label_NazivPregleda.AutoSize = true;
            this.label_NazivPregleda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_NazivPregleda.Location = new System.Drawing.Point(55, 99);
            this.label_NazivPregleda.Name = "label_NazivPregleda";
            this.label_NazivPregleda.Size = new System.Drawing.Size(120, 20);
            this.label_NazivPregleda.TabIndex = 30;
            this.label_NazivPregleda.Text = "Naziv pregleda";
            // 
            // comboBox_Pregledi
            // 
            this.comboBox_Pregledi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Pregledi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_Pregledi.FormattingEnabled = true;
            this.comboBox_Pregledi.Location = new System.Drawing.Point(300, 46);
            this.comboBox_Pregledi.Name = "comboBox_Pregledi";
            this.comboBox_Pregledi.Size = new System.Drawing.Size(326, 28);
            this.comboBox_Pregledi.TabIndex = 39;
            this.comboBox_Pregledi.SelectedIndexChanged += new System.EventHandler(this.comboBox_Pregledi_SelectedIndexChanged);
            // 
            // label_OdabirPregleda
            // 
            this.label_OdabirPregleda.AutoSize = true;
            this.label_OdabirPregleda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_OdabirPregleda.Location = new System.Drawing.Point(55, 49);
            this.label_OdabirPregleda.Name = "label_OdabirPregleda";
            this.label_OdabirPregleda.Size = new System.Drawing.Size(159, 20);
            this.label_OdabirPregleda.TabIndex = 38;
            this.label_OdabirPregleda.Text = "Odaberite pregled";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelUredjivanjePregleda});
            this.statusStrip1.Location = new System.Drawing.Point(0, 352);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(740, 22);
            this.statusStrip1.TabIndex = 40;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelUredjivanjePregleda
            // 
            this.toolStripStatusLabelUredjivanjePregleda.Name = "toolStripStatusLabelUredjivanjePregleda";
            this.toolStripStatusLabelUredjivanjePregleda.Size = new System.Drawing.Size(0, 17);
            // 
            // button_Obrisi
            // 
            this.button_Obrisi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Obrisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Obrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Obrisi.Location = new System.Drawing.Point(313, 287);
            this.button_Obrisi.Name = "button_Obrisi";
            this.button_Obrisi.Size = new System.Drawing.Size(106, 37);
            this.button_Obrisi.TabIndex = 41;
            this.button_Obrisi.Text = "&Obriši";
            this.button_Obrisi.UseVisualStyleBackColor = false;
            this.button_Obrisi.Click += new System.EventHandler(this.button_Obrisi_Click);
            // 
            // UrediPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 374);
            this.Controls.Add(this.button_Obrisi);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.comboBox_Pregledi);
            this.Controls.Add(this.label_OdabirPregleda);
            this.Controls.Add(this.button_Zatvori);
            this.Controls.Add(this.button_Dodaj);
            this.Controls.Add(this.numericUpDown_Cijena);
            this.Controls.Add(this.label_Cijena);
            this.Controls.Add(this.comboBox_Ordinacija);
            this.Controls.Add(this.label_Ordinacija);
            this.Controls.Add(this.textBox_NazivPregleda);
            this.Controls.Add(this.label_NazivPregleda);
            this.Name = "UrediPregled";
            this.Text = "UrediPregled";
            this.Load += new System.EventHandler(this.UrediPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Cijena)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Zatvori;
        private System.Windows.Forms.Button button_Dodaj;
        private System.Windows.Forms.NumericUpDown numericUpDown_Cijena;
        private System.Windows.Forms.Label label_Cijena;
        private System.Windows.Forms.ComboBox comboBox_Ordinacija;
        private System.Windows.Forms.Label label_Ordinacija;
        private System.Windows.Forms.TextBox textBox_NazivPregleda;
        private System.Windows.Forms.Label label_NazivPregleda;
        private System.Windows.Forms.ComboBox comboBox_Pregledi;
        private System.Windows.Forms.Label label_OdabirPregleda;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUredjivanjePregleda;
        private System.Windows.Forms.Button button_Obrisi;
    }
}