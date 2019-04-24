namespace Zadaca2
{
    partial class UcitavanjeOsoba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcitavanjeOsoba));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maticniBroj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bracnoStanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uloga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DodajOsobe = new System.Windows.Forms.Button();
            this.Zatvori = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime,
            this.Prezime,
            this.DatumRodjenja,
            this.maticniBroj,
            this.adresa,
            this.spol,
            this.bracnoStanje,
            this.email,
            this.uloga});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1103, 304);
            this.dataGridView1.TabIndex = 0;
            // 
            // Ime
            // 
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.HeaderText = "Datum rodjenja";
            this.DatumRodjenja.Name = "DatumRodjenja";
            // 
            // maticniBroj
            // 
            this.maticniBroj.HeaderText = "Maticni broj";
            this.maticniBroj.Name = "maticniBroj";
            // 
            // adresa
            // 
            this.adresa.HeaderText = "Adresa";
            this.adresa.Name = "adresa";
            // 
            // spol
            // 
            this.spol.HeaderText = "Spol";
            this.spol.Name = "spol";
            // 
            // bracnoStanje
            // 
            this.bracnoStanje.HeaderText = "Bracno Stanje";
            this.bracnoStanje.Name = "bracnoStanje";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // uloga
            // 
            this.uloga.HeaderText = "Uloga";
            this.uloga.Name = "uloga";
            // 
            // DodajOsobe
            // 
            this.DodajOsobe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DodajOsobe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DodajOsobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DodajOsobe.Location = new System.Drawing.Point(383, 322);
            this.DodajOsobe.Name = "DodajOsobe";
            this.DodajOsobe.Size = new System.Drawing.Size(151, 55);
            this.DodajOsobe.TabIndex = 1;
            this.DodajOsobe.Text = "Dodaj osobe u kliniku";
            this.DodajOsobe.UseVisualStyleBackColor = false;
            this.DodajOsobe.Click += new System.EventHandler(this.DodajOsobe_Click);
            // 
            // Zatvori
            // 
            this.Zatvori.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Zatvori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Zatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Zatvori.Location = new System.Drawing.Point(588, 322);
            this.Zatvori.Name = "Zatvori";
            this.Zatvori.Size = new System.Drawing.Size(151, 55);
            this.Zatvori.TabIndex = 2;
            this.Zatvori.Text = "&Zatvori";
            this.Zatvori.UseVisualStyleBackColor = false;
            this.Zatvori.Click += new System.EventHandler(this.Zatvori_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 384);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1124, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // UcitavanjeOsoba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 406);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Zatvori);
            this.Controls.Add(this.DodajOsobe);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UcitavanjeOsoba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Učitavanje osoba";
            this.Load += new System.EventHandler(this.UcitavanjeOsoba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodjenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn maticniBroj;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn spol;
        private System.Windows.Forms.DataGridViewTextBoxColumn bracnoStanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn uloga;
        private System.Windows.Forms.Button DodajOsobe;
        private System.Windows.Forms.Button Zatvori;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}