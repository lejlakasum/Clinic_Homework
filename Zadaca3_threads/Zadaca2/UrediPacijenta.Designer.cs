namespace Zadaca2
{
    partial class UrediPacijenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrediPacijenta));
            this.groupBox_LicniPodaci = new System.Windows.Forms.GroupBox();
            this.button_Zatvori = new System.Windows.Forms.Button();
            this.button_IzmjeniPacijenta = new System.Windows.Forms.Button();
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelIzmjeniPacijenta = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox_LicniPodaci.SuspendLayout();
            this.groupBox_Spol.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_LicniPodaci
            // 
            this.groupBox_LicniPodaci.Controls.Add(this.button_Zatvori);
            this.groupBox_LicniPodaci.Controls.Add(this.button_IzmjeniPacijenta);
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
            this.groupBox_LicniPodaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_LicniPodaci.Location = new System.Drawing.Point(0, 5);
            this.groupBox_LicniPodaci.Name = "groupBox_LicniPodaci";
            this.groupBox_LicniPodaci.Size = new System.Drawing.Size(498, 509);
            this.groupBox_LicniPodaci.TabIndex = 22;
            this.groupBox_LicniPodaci.TabStop = false;
            this.groupBox_LicniPodaci.Text = "Lični podaci";
            // 
            // button_Zatvori
            // 
            this.button_Zatvori.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Zatvori.CausesValidation = false;
            this.button_Zatvori.Location = new System.Drawing.Point(286, 463);
            this.button_Zatvori.Name = "button_Zatvori";
            this.button_Zatvori.Size = new System.Drawing.Size(101, 40);
            this.button_Zatvori.TabIndex = 18;
            this.button_Zatvori.Text = "&Zatvori";
            this.button_Zatvori.UseVisualStyleBackColor = false;
            this.button_Zatvori.Click += new System.EventHandler(this.button_Zatvori_Click);
            // 
            // button_IzmjeniPacijenta
            // 
            this.button_IzmjeniPacijenta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_IzmjeniPacijenta.Location = new System.Drawing.Point(97, 463);
            this.button_IzmjeniPacijenta.Name = "button_IzmjeniPacijenta";
            this.button_IzmjeniPacijenta.Size = new System.Drawing.Size(101, 40);
            this.button_IzmjeniPacijenta.TabIndex = 17;
            this.button_IzmjeniPacijenta.Text = "&Izmjeni";
            this.button_IzmjeniPacijenta.UseVisualStyleBackColor = false;
            this.button_IzmjeniPacijenta.Click += new System.EventHandler(this.button_IzmjeniPacijenta_Click);
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(247, 306);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(211, 27);
            this.textBox_Email.TabIndex = 16;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(39, 309);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(113, 20);
            this.label_Email.TabIndex = 15;
            this.label_Email.Text = "E-mail adresa";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(247, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 27);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // textBox_MaticniBroj
            // 
            this.textBox_MaticniBroj.Location = new System.Drawing.Point(247, 170);
            this.textBox_MaticniBroj.MaxLength = 13;
            this.textBox_MaticniBroj.Name = "textBox_MaticniBroj";
            this.textBox_MaticniBroj.Size = new System.Drawing.Size(211, 27);
            this.textBox_MaticniBroj.TabIndex = 13;
            // 
            // textBox_Adresa
            // 
            this.textBox_Adresa.Location = new System.Drawing.Point(247, 218);
            this.textBox_Adresa.Name = "textBox_Adresa";
            this.textBox_Adresa.Size = new System.Drawing.Size(211, 27);
            this.textBox_Adresa.TabIndex = 12;
            // 
            // textBox_Prezime
            // 
            this.textBox_Prezime.Location = new System.Drawing.Point(247, 83);
            this.textBox_Prezime.Name = "textBox_Prezime";
            this.textBox_Prezime.Size = new System.Drawing.Size(211, 27);
            this.textBox_Prezime.TabIndex = 11;
            // 
            // textBox_Ime
            // 
            this.textBox_Ime.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_Ime.Location = new System.Drawing.Point(247, 38);
            this.textBox_Ime.Name = "textBox_Ime";
            this.textBox_Ime.Size = new System.Drawing.Size(211, 27);
            this.textBox_Ime.TabIndex = 10;
            // 
            // comboBox_BracnoStanje
            // 
            this.comboBox_BracnoStanje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_BracnoStanje.FormattingEnabled = true;
            this.comboBox_BracnoStanje.Location = new System.Drawing.Point(247, 261);
            this.comboBox_BracnoStanje.Name = "comboBox_BracnoStanje";
            this.comboBox_BracnoStanje.Size = new System.Drawing.Size(211, 28);
            this.comboBox_BracnoStanje.TabIndex = 9;
            // 
            // groupBox_Spol
            // 
            this.groupBox_Spol.Controls.Add(this.radioButton_Zensko);
            this.groupBox_Spol.Controls.Add(this.radioButton_Musko);
            this.groupBox_Spol.Location = new System.Drawing.Point(43, 368);
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
            this.radioButton_Zensko.Text = "Žensko";
            this.radioButton_Zensko.UseVisualStyleBackColor = true;
            // 
            // radioButton_Musko
            // 
            this.radioButton_Musko.AutoSize = true;
            this.radioButton_Musko.Checked = true;
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
            this.label_BracnoStanje.Location = new System.Drawing.Point(39, 264);
            this.label_BracnoStanje.Name = "label_BracnoStanje";
            this.label_BracnoStanje.Size = new System.Drawing.Size(113, 20);
            this.label_BracnoStanje.TabIndex = 7;
            this.label_BracnoStanje.Text = "Bračno stanje";
            // 
            // label_Adresa
            // 
            this.label_Adresa.AutoSize = true;
            this.label_Adresa.Location = new System.Drawing.Point(39, 221);
            this.label_Adresa.Name = "label_Adresa";
            this.label_Adresa.Size = new System.Drawing.Size(62, 20);
            this.label_Adresa.TabIndex = 6;
            this.label_Adresa.Text = "Adresa";
            // 
            // label_MaticniBroj
            // 
            this.label_MaticniBroj.AutoSize = true;
            this.label_MaticniBroj.Location = new System.Drawing.Point(39, 173);
            this.label_MaticniBroj.Name = "label_MaticniBroj";
            this.label_MaticniBroj.Size = new System.Drawing.Size(96, 20);
            this.label_MaticniBroj.TabIndex = 5;
            this.label_MaticniBroj.Text = "Matični broj";
            // 
            // label_DatumRodjenja
            // 
            this.label_DatumRodjenja.AutoSize = true;
            this.label_DatumRodjenja.Location = new System.Drawing.Point(39, 126);
            this.label_DatumRodjenja.Name = "label_DatumRodjenja";
            this.label_DatumRodjenja.Size = new System.Drawing.Size(119, 20);
            this.label_DatumRodjenja.TabIndex = 4;
            this.label_DatumRodjenja.Text = "Datum rođenja";
            // 
            // label_Prezime
            // 
            this.label_Prezime.AutoSize = true;
            this.label_Prezime.Location = new System.Drawing.Point(39, 83);
            this.label_Prezime.Name = "label_Prezime";
            this.label_Prezime.Size = new System.Drawing.Size(71, 20);
            this.label_Prezime.TabIndex = 3;
            this.label_Prezime.Text = "Prezime";
            // 
            // label_Ime
            // 
            this.label_Ime.AutoSize = true;
            this.label_Ime.Location = new System.Drawing.Point(39, 38);
            this.label_Ime.Name = "label_Ime";
            this.label_Ime.Size = new System.Drawing.Size(36, 20);
            this.label_Ime.TabIndex = 2;
            this.label_Ime.Text = "Ime";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelIzmjeniPacijenta});
            this.statusStrip1.Location = new System.Drawing.Point(0, 517);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(510, 22);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelIzmjeniPacijenta
            // 
            this.toolStripStatusLabelIzmjeniPacijenta.Name = "toolStripStatusLabelIzmjeniPacijenta";
            this.toolStripStatusLabelIzmjeniPacijenta.Size = new System.Drawing.Size(0, 17);
            // 
            // UrediPacijenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 539);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox_LicniPodaci);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UrediPacijenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izmjena pacijenta";
            this.Load += new System.EventHandler(this.UrediPacijenta_Load);
            this.groupBox_LicniPodaci.ResumeLayout(false);
            this.groupBox_LicniPodaci.PerformLayout();
            this.groupBox_Spol.ResumeLayout(false);
            this.groupBox_Spol.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_LicniPodaci;
        private System.Windows.Forms.Button button_Zatvori;
        private System.Windows.Forms.Button button_IzmjeniPacijenta;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label_Email;
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
        private System.Windows.Forms.Label label_Adresa;
        private System.Windows.Forms.Label label_MaticniBroj;
        private System.Windows.Forms.Label label_DatumRodjenja;
        private System.Windows.Forms.Label label_Prezime;
        private System.Windows.Forms.Label label_Ime;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelIzmjeniPacijenta;
    }
}