﻿namespace Zadaca2
{
    partial class DodajOsobu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajOsobu));
            this.label_Uloga = new System.Windows.Forms.Label();
            this.comboBox_Uloga = new System.Windows.Forms.ComboBox();
            this.groupBox_LicniPodaci = new System.Windows.Forms.GroupBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox_MaticniBroj = new System.Windows.Forms.TextBox();
            this.textBox_Adresa = new System.Windows.Forms.TextBox();
            this.textBox_Prezime = new System.Windows.Forms.TextBox();
            this.textBox_Ime = new System.Windows.Forms.TextBox();
            this.comboBox_BracnoStanje = new System.Windows.Forms.ComboBox();
            this.groupBox_Spol = new System.Windows.Forms.GroupBox();
            this.radioButton_Zensko = new System.Windows.Forms.RadioButton();
            this.radioButton_Musko = new System.Windows.Forms.RadioButton();
            this.label_BracnoStanje = new System.Windows.Forms.Label();
            this.label_Adresa = new System.Windows.Forms.Label();
            this.label_MaticniBroj = new System.Windows.Forms.Label();
            this.label_DatumRodjenja = new System.Windows.Forms.Label();
            this.label_Prezime = new System.Windows.Forms.Label();
            this.label_Ime = new System.Windows.Forms.Label();
            this.groupBox_OstaleInfo = new System.Windows.Forms.GroupBox();
            this.comboBox_Ordinacija = new System.Windows.Forms.ComboBox();
            this.label_Ordinacija = new System.Windows.Forms.Label();
            this.numericUpDown_Plata = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_NazivPozicije = new System.Windows.Forms.ComboBox();
            this.label_NazivPozicije = new System.Windows.Forms.Label();
            this.errorProvider_MaticniBroj = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_Email = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_Ime = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_Prezime = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAdresa = new System.Windows.Forms.ErrorProvider(this.components);
            this.button_Dodaj = new System.Windows.Forms.Button();
            this.button_Zatvori = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusDodavanjeOsobe = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox_LicniPodaci.SuspendLayout();
            this.groupBox_Spol.SuspendLayout();
            this.groupBox_OstaleInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Plata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_MaticniBroj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Ime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Prezime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAdresa)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Uloga
            // 
            this.label_Uloga.AutoSize = true;
            this.label_Uloga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Uloga.Location = new System.Drawing.Point(29, 28);
            this.label_Uloga.Name = "label_Uloga";
            this.label_Uloga.Size = new System.Drawing.Size(57, 20);
            this.label_Uloga.TabIndex = 0;
            this.label_Uloga.Text = "Uloga";
            // 
            // comboBox_Uloga
            // 
            this.comboBox_Uloga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Uloga.FormattingEnabled = true;
            this.comboBox_Uloga.Location = new System.Drawing.Point(237, 25);
            this.comboBox_Uloga.Name = "comboBox_Uloga";
            this.comboBox_Uloga.Size = new System.Drawing.Size(211, 28);
            this.comboBox_Uloga.TabIndex = 1;
            this.comboBox_Uloga.SelectedIndexChanged += new System.EventHandler(this.comboBox_Uloga_SelectedIndexChanged);
            // 
            // groupBox_LicniPodaci
            // 
            this.groupBox_LicniPodaci.Controls.Add(this.textBox_Email);
            this.groupBox_LicniPodaci.Controls.Add(this.label_Email);
            this.groupBox_LicniPodaci.Controls.Add(this.dateTimePicker1);
            this.groupBox_LicniPodaci.Controls.Add(this.textBox_MaticniBroj);
            this.groupBox_LicniPodaci.Controls.Add(this.textBox_Adresa);
            this.groupBox_LicniPodaci.Controls.Add(this.textBox_Prezime);
            this.groupBox_LicniPodaci.Controls.Add(this.textBox_Ime);
            this.groupBox_LicniPodaci.Controls.Add(this.comboBox_BracnoStanje);
            this.groupBox_LicniPodaci.Controls.Add(this.groupBox_Spol);
            this.groupBox_LicniPodaci.Controls.Add(this.label_BracnoStanje);
            this.groupBox_LicniPodaci.Controls.Add(this.label_Adresa);
            this.groupBox_LicniPodaci.Controls.Add(this.label_MaticniBroj);
            this.groupBox_LicniPodaci.Controls.Add(this.label_DatumRodjenja);
            this.groupBox_LicniPodaci.Controls.Add(this.label_Prezime);
            this.groupBox_LicniPodaci.Controls.Add(this.label_Ime);
            this.groupBox_LicniPodaci.Controls.Add(this.comboBox_Uloga);
            this.groupBox_LicniPodaci.Controls.Add(this.label_Uloga);
            this.groupBox_LicniPodaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_LicniPodaci.Location = new System.Drawing.Point(12, 23);
            this.groupBox_LicniPodaci.Name = "groupBox_LicniPodaci";
            this.groupBox_LicniPodaci.Size = new System.Drawing.Size(498, 505);
            this.groupBox_LicniPodaci.TabIndex = 2;
            this.groupBox_LicniPodaci.TabStop = false;
            this.groupBox_LicniPodaci.Text = "Lični podaci";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(237, 344);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(211, 27);
            this.textBox_Email.TabIndex = 16;
            this.textBox_Email.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Email_Validating);
            this.textBox_Email.Validated += new System.EventHandler(this.textBox_Email_Validated);
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(29, 347);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(113, 20);
            this.label_Email.TabIndex = 15;
            this.label_Email.Text = "E-mail adresa";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(237, 164);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 27);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // textBox_MaticniBroj
            // 
            this.textBox_MaticniBroj.Location = new System.Drawing.Point(237, 208);
            this.textBox_MaticniBroj.MaxLength = 13;
            this.textBox_MaticniBroj.Name = "textBox_MaticniBroj";
            this.textBox_MaticniBroj.Size = new System.Drawing.Size(211, 27);
            this.textBox_MaticniBroj.TabIndex = 13;
            this.textBox_MaticniBroj.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_MaticniBroj_Validating);
            this.textBox_MaticniBroj.Validated += new System.EventHandler(this.textBox_MaticniBroj_Validated);
            // 
            // textBox_Adresa
            // 
            this.textBox_Adresa.Location = new System.Drawing.Point(237, 256);
            this.textBox_Adresa.Name = "textBox_Adresa";
            this.textBox_Adresa.Size = new System.Drawing.Size(211, 27);
            this.textBox_Adresa.TabIndex = 12;
            this.textBox_Adresa.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Adresa_Validating);
            this.textBox_Adresa.Validated += new System.EventHandler(this.textBox_Adresa_Validated);
            // 
            // textBox_Prezime
            // 
            this.textBox_Prezime.Location = new System.Drawing.Point(237, 121);
            this.textBox_Prezime.Name = "textBox_Prezime";
            this.textBox_Prezime.Size = new System.Drawing.Size(211, 27);
            this.textBox_Prezime.TabIndex = 11;
            this.textBox_Prezime.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Prezime_Validating);
            this.textBox_Prezime.Validated += new System.EventHandler(this.textBox_Prezime_Validated);
            // 
            // textBox_Ime
            // 
            this.textBox_Ime.Location = new System.Drawing.Point(237, 76);
            this.textBox_Ime.Name = "textBox_Ime";
            this.textBox_Ime.Size = new System.Drawing.Size(211, 27);
            this.textBox_Ime.TabIndex = 10;
            this.textBox_Ime.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Ime_Validating);
            this.textBox_Ime.Validated += new System.EventHandler(this.textBox_Ime_Validated);
            // 
            // comboBox_BracnoStanje
            // 
            this.comboBox_BracnoStanje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_BracnoStanje.FormattingEnabled = true;
            this.comboBox_BracnoStanje.Location = new System.Drawing.Point(237, 299);
            this.comboBox_BracnoStanje.Name = "comboBox_BracnoStanje";
            this.comboBox_BracnoStanje.Size = new System.Drawing.Size(211, 28);
            this.comboBox_BracnoStanje.TabIndex = 9;
            // 
            // groupBox_Spol
            // 
            this.groupBox_Spol.Controls.Add(this.radioButton_Zensko);
            this.groupBox_Spol.Controls.Add(this.radioButton_Musko);
            this.groupBox_Spol.Location = new System.Drawing.Point(33, 406);
            this.groupBox_Spol.Name = "groupBox_Spol";
            this.groupBox_Spol.Size = new System.Drawing.Size(415, 82);
            this.groupBox_Spol.TabIndex = 8;
            this.groupBox_Spol.TabStop = false;
            this.groupBox_Spol.Text = "Spol";
            // 
            // radioButton_Zensko
            // 
            this.radioButton_Zensko.AutoSize = true;
            this.radioButton_Zensko.Location = new System.Drawing.Point(204, 35);
            this.radioButton_Zensko.Name = "radioButton_Zensko";
            this.radioButton_Zensko.Size = new System.Drawing.Size(83, 24);
            this.radioButton_Zensko.TabIndex = 1;
            this.radioButton_Zensko.TabStop = true;
            this.radioButton_Zensko.Text = "Žensko";
            this.radioButton_Zensko.UseVisualStyleBackColor = true;
            // 
            // radioButton_Musko
            // 
            this.radioButton_Musko.AutoSize = true;
            this.radioButton_Musko.Location = new System.Drawing.Point(32, 35);
            this.radioButton_Musko.Name = "radioButton_Musko";
            this.radioButton_Musko.Size = new System.Drawing.Size(79, 24);
            this.radioButton_Musko.TabIndex = 0;
            this.radioButton_Musko.TabStop = true;
            this.radioButton_Musko.Text = "Muško";
            this.radioButton_Musko.UseVisualStyleBackColor = true;
            // 
            // label_BracnoStanje
            // 
            this.label_BracnoStanje.AutoSize = true;
            this.label_BracnoStanje.Location = new System.Drawing.Point(29, 302);
            this.label_BracnoStanje.Name = "label_BracnoStanje";
            this.label_BracnoStanje.Size = new System.Drawing.Size(113, 20);
            this.label_BracnoStanje.TabIndex = 7;
            this.label_BracnoStanje.Text = "Bračno stanje";
            // 
            // label_Adresa
            // 
            this.label_Adresa.AutoSize = true;
            this.label_Adresa.Location = new System.Drawing.Point(29, 259);
            this.label_Adresa.Name = "label_Adresa";
            this.label_Adresa.Size = new System.Drawing.Size(62, 20);
            this.label_Adresa.TabIndex = 6;
            this.label_Adresa.Text = "Adresa";
            // 
            // label_MaticniBroj
            // 
            this.label_MaticniBroj.AutoSize = true;
            this.label_MaticniBroj.Location = new System.Drawing.Point(29, 211);
            this.label_MaticniBroj.Name = "label_MaticniBroj";
            this.label_MaticniBroj.Size = new System.Drawing.Size(96, 20);
            this.label_MaticniBroj.TabIndex = 5;
            this.label_MaticniBroj.Text = "Matični broj";
            // 
            // label_DatumRodjenja
            // 
            this.label_DatumRodjenja.AutoSize = true;
            this.label_DatumRodjenja.Location = new System.Drawing.Point(29, 164);
            this.label_DatumRodjenja.Name = "label_DatumRodjenja";
            this.label_DatumRodjenja.Size = new System.Drawing.Size(119, 20);
            this.label_DatumRodjenja.TabIndex = 4;
            this.label_DatumRodjenja.Text = "Datum rođenja";
            // 
            // label_Prezime
            // 
            this.label_Prezime.AutoSize = true;
            this.label_Prezime.Location = new System.Drawing.Point(29, 121);
            this.label_Prezime.Name = "label_Prezime";
            this.label_Prezime.Size = new System.Drawing.Size(71, 20);
            this.label_Prezime.TabIndex = 3;
            this.label_Prezime.Text = "Prezime";
            // 
            // label_Ime
            // 
            this.label_Ime.AutoSize = true;
            this.label_Ime.Location = new System.Drawing.Point(29, 76);
            this.label_Ime.Name = "label_Ime";
            this.label_Ime.Size = new System.Drawing.Size(36, 20);
            this.label_Ime.TabIndex = 2;
            this.label_Ime.Text = "Ime";
            // 
            // groupBox_OstaleInfo
            // 
            this.groupBox_OstaleInfo.Controls.Add(this.comboBox_Ordinacija);
            this.groupBox_OstaleInfo.Controls.Add(this.label_Ordinacija);
            this.groupBox_OstaleInfo.Controls.Add(this.numericUpDown_Plata);
            this.groupBox_OstaleInfo.Controls.Add(this.label7);
            this.groupBox_OstaleInfo.Controls.Add(this.comboBox_NazivPozicije);
            this.groupBox_OstaleInfo.Controls.Add(this.label_NazivPozicije);
            this.groupBox_OstaleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_OstaleInfo.Location = new System.Drawing.Point(541, 23);
            this.groupBox_OstaleInfo.Name = "groupBox_OstaleInfo";
            this.groupBox_OstaleInfo.Size = new System.Drawing.Size(485, 168);
            this.groupBox_OstaleInfo.TabIndex = 17;
            this.groupBox_OstaleInfo.TabStop = false;
            this.groupBox_OstaleInfo.Text = "Ostale informacije";
            this.groupBox_OstaleInfo.Visible = false;
            // 
            // comboBox_Ordinacija
            // 
            this.comboBox_Ordinacija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Ordinacija.FormattingEnabled = true;
            this.comboBox_Ordinacija.Location = new System.Drawing.Point(237, 118);
            this.comboBox_Ordinacija.Name = "comboBox_Ordinacija";
            this.comboBox_Ordinacija.Size = new System.Drawing.Size(211, 28);
            this.comboBox_Ordinacija.TabIndex = 19;
            // 
            // label_Ordinacija
            // 
            this.label_Ordinacija.AutoSize = true;
            this.label_Ordinacija.Location = new System.Drawing.Point(29, 121);
            this.label_Ordinacija.Name = "label_Ordinacija";
            this.label_Ordinacija.Size = new System.Drawing.Size(85, 20);
            this.label_Ordinacija.TabIndex = 18;
            this.label_Ordinacija.Text = "Ordinacija";
            // 
            // numericUpDown_Plata
            // 
            this.numericUpDown_Plata.Location = new System.Drawing.Point(237, 73);
            this.numericUpDown_Plata.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_Plata.Name = "numericUpDown_Plata";
            this.numericUpDown_Plata.Size = new System.Drawing.Size(211, 27);
            this.numericUpDown_Plata.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Iznos plate";
            // 
            // comboBox_NazivPozicije
            // 
            this.comboBox_NazivPozicije.FormattingEnabled = true;
            this.comboBox_NazivPozicije.Items.AddRange(new object[] {
            "Čistać/ica",
            "Doktor opšte medicine",
            "Doktor specijalista",
            "Domar",
            "Finansijski direktor",
            "Laborant",
            "Medicinski/a tehničar/ka",
            "Poslovni direktor",
            "Vlasnik"});
            this.comboBox_NazivPozicije.Location = new System.Drawing.Point(237, 25);
            this.comboBox_NazivPozicije.Name = "comboBox_NazivPozicije";
            this.comboBox_NazivPozicije.Size = new System.Drawing.Size(211, 28);
            this.comboBox_NazivPozicije.Sorted = true;
            this.comboBox_NazivPozicije.TabIndex = 1;
            // 
            // label_NazivPozicije
            // 
            this.label_NazivPozicije.AutoSize = true;
            this.label_NazivPozicije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_NazivPozicije.Location = new System.Drawing.Point(29, 28);
            this.label_NazivPozicije.Name = "label_NazivPozicije";
            this.label_NazivPozicije.Size = new System.Drawing.Size(113, 20);
            this.label_NazivPozicije.TabIndex = 0;
            this.label_NazivPozicije.Text = "Naziv pozicije";
            // 
            // errorProvider_MaticniBroj
            // 
            this.errorProvider_MaticniBroj.ContainerControl = this;
            // 
            // errorProvider_Email
            // 
            this.errorProvider_Email.ContainerControl = this;
            // 
            // errorProvider_Ime
            // 
            this.errorProvider_Ime.ContainerControl = this;
            // 
            // errorProvider_Prezime
            // 
            this.errorProvider_Prezime.ContainerControl = this;
            // 
            // errorProviderAdresa
            // 
            this.errorProviderAdresa.ContainerControl = this;
            // 
            // button_Dodaj
            // 
            this.button_Dodaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Dodaj.Location = new System.Drawing.Point(599, 464);
            this.button_Dodaj.Name = "button_Dodaj";
            this.button_Dodaj.Size = new System.Drawing.Size(122, 47);
            this.button_Dodaj.TabIndex = 18;
            this.button_Dodaj.Text = "Dodaj";
            this.button_Dodaj.UseVisualStyleBackColor = false;
            this.button_Dodaj.Click += new System.EventHandler(this.button_Dodaj_Click);
            // 
            // button_Zatvori
            // 
            this.button_Zatvori.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Zatvori.CausesValidation = false;
            this.button_Zatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Zatvori.Location = new System.Drawing.Point(847, 464);
            this.button_Zatvori.Name = "button_Zatvori";
            this.button_Zatvori.Size = new System.Drawing.Size(122, 47);
            this.button_Zatvori.TabIndex = 19;
            this.button_Zatvori.Text = "Zatvori";
            this.button_Zatvori.UseVisualStyleBackColor = false;
            this.button_Zatvori.Click += new System.EventHandler(this.button_Zatvori_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusDodavanjeOsobe});
            this.statusStrip1.Location = new System.Drawing.Point(0, 534);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1066, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusDodavanjeOsobe
            // 
            this.toolStripStatusDodavanjeOsobe.Name = "toolStripStatusDodavanjeOsobe";
            this.toolStripStatusDodavanjeOsobe.Size = new System.Drawing.Size(0, 17);
            // 
            // DodajOsobu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 556);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_Zatvori);
            this.Controls.Add(this.button_Dodaj);
            this.Controls.Add(this.groupBox_OstaleInfo);
            this.Controls.Add(this.groupBox_LicniPodaci);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DodajOsobu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje osobe";
            this.Load += new System.EventHandler(this.DodajOsobu_Load);
            this.groupBox_LicniPodaci.ResumeLayout(false);
            this.groupBox_LicniPodaci.PerformLayout();
            this.groupBox_Spol.ResumeLayout(false);
            this.groupBox_Spol.PerformLayout();
            this.groupBox_OstaleInfo.ResumeLayout(false);
            this.groupBox_OstaleInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Plata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_MaticniBroj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Ime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Prezime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAdresa)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Uloga;
        private System.Windows.Forms.ComboBox comboBox_Uloga;
        private System.Windows.Forms.GroupBox groupBox_LicniPodaci;
        private System.Windows.Forms.Label label_DatumRodjenja;
        private System.Windows.Forms.Label label_Prezime;
        private System.Windows.Forms.Label label_Ime;
        private System.Windows.Forms.Label label_MaticniBroj;
        private System.Windows.Forms.Label label_Adresa;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox_MaticniBroj;
        private System.Windows.Forms.TextBox textBox_Adresa;
        private System.Windows.Forms.TextBox textBox_Prezime;
        private System.Windows.Forms.TextBox textBox_Ime;
        private System.Windows.Forms.ComboBox comboBox_BracnoStanje;
        private System.Windows.Forms.GroupBox groupBox_Spol;
        private System.Windows.Forms.RadioButton radioButton_Zensko;
        private System.Windows.Forms.RadioButton radioButton_Musko;
        private System.Windows.Forms.Label label_BracnoStanje;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.GroupBox groupBox_OstaleInfo;
        private System.Windows.Forms.NumericUpDown numericUpDown_Plata;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_NazivPozicije;
        private System.Windows.Forms.Label label_NazivPozicije;
        private System.Windows.Forms.ComboBox comboBox_Ordinacija;
        private System.Windows.Forms.Label label_Ordinacija;
        private System.Windows.Forms.ErrorProvider errorProvider_MaticniBroj;
        private System.Windows.Forms.ErrorProvider errorProvider_Email;
        private System.Windows.Forms.ErrorProvider errorProvider_Ime;
        private System.Windows.Forms.ErrorProvider errorProvider_Prezime;
        private System.Windows.Forms.ErrorProvider errorProviderAdresa;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusDodavanjeOsobe;
        private System.Windows.Forms.Button button_Zatvori;
        private System.Windows.Forms.Button button_Dodaj;
    }
}