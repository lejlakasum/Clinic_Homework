namespace Zadaca2
{
    partial class DodajAparat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajAparat));
            this.groupBox_Aktivnost = new System.Windows.Forms.GroupBox();
            this.radioButton_Neaktivna = new System.Windows.Forms.RadioButton();
            this.radioButton_Aktivna = new System.Windows.Forms.RadioButton();
            this.textBox_NazivOrdinacije = new System.Windows.Forms.TextBox();
            this.label_NazivAparata = new System.Windows.Forms.Label();
            this.comboBox_Ordinacija = new System.Windows.Forms.ComboBox();
            this.label_Ordinacija = new System.Windows.Forms.Label();
            this.button_Zatvori = new System.Windows.Forms.Button();
            this.button_Dodaj = new System.Windows.Forms.Button();
            this.toolTip_Aktivan = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider_NazivAparata = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelDodajAparat = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox_Aktivnost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_NazivAparata)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Aktivnost
            // 
            this.groupBox_Aktivnost.Controls.Add(this.radioButton_Neaktivna);
            this.groupBox_Aktivnost.Controls.Add(this.radioButton_Aktivna);
            this.groupBox_Aktivnost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_Aktivnost.Location = new System.Drawing.Point(305, 153);
            this.groupBox_Aktivnost.Name = "groupBox_Aktivnost";
            this.groupBox_Aktivnost.Size = new System.Drawing.Size(284, 67);
            this.groupBox_Aktivnost.TabIndex = 5;
            this.groupBox_Aktivnost.TabStop = false;
            this.groupBox_Aktivnost.MouseHover += new System.EventHandler(this.groupBox_Aktivnost_MouseHover);
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
            // textBox_NazivOrdinacije
            // 
            this.textBox_NazivOrdinacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_NazivOrdinacije.Location = new System.Drawing.Point(286, 38);
            this.textBox_NazivOrdinacije.Name = "textBox_NazivOrdinacije";
            this.textBox_NazivOrdinacije.Size = new System.Drawing.Size(326, 27);
            this.textBox_NazivOrdinacije.TabIndex = 4;
            this.textBox_NazivOrdinacije.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_NazivOrdinacije_Validating);
            this.textBox_NazivOrdinacije.Validated += new System.EventHandler(this.textBox_NazivOrdinacije_Validated);
            // 
            // label_NazivAparata
            // 
            this.label_NazivAparata.AutoSize = true;
            this.label_NazivAparata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_NazivAparata.Location = new System.Drawing.Point(23, 41);
            this.label_NazivAparata.Name = "label_NazivAparata";
            this.label_NazivAparata.Size = new System.Drawing.Size(112, 20);
            this.label_NazivAparata.TabIndex = 3;
            this.label_NazivAparata.Text = "Naziv aparata";
            // 
            // comboBox_Ordinacija
            // 
            this.comboBox_Ordinacija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Ordinacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_Ordinacija.FormattingEnabled = true;
            this.comboBox_Ordinacija.Location = new System.Drawing.Point(286, 88);
            this.comboBox_Ordinacija.Name = "comboBox_Ordinacija";
            this.comboBox_Ordinacija.Size = new System.Drawing.Size(326, 28);
            this.comboBox_Ordinacija.TabIndex = 21;
            // 
            // label_Ordinacija
            // 
            this.label_Ordinacija.AutoSize = true;
            this.label_Ordinacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Ordinacija.Location = new System.Drawing.Point(23, 91);
            this.label_Ordinacija.Name = "label_Ordinacija";
            this.label_Ordinacija.Size = new System.Drawing.Size(225, 20);
            this.label_Ordinacija.TabIndex = 20;
            this.label_Ordinacija.Text = "Ordinacija u koju je smješten";
            // 
            // button_Zatvori
            // 
            this.button_Zatvori.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Zatvori.CausesValidation = false;
            this.button_Zatvori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Zatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Zatvori.Location = new System.Drawing.Point(483, 280);
            this.button_Zatvori.Name = "button_Zatvori";
            this.button_Zatvori.Size = new System.Drawing.Size(106, 37);
            this.button_Zatvori.TabIndex = 23;
            this.button_Zatvori.Text = "Zatvori";
            this.button_Zatvori.UseVisualStyleBackColor = false;
            this.button_Zatvori.Click += new System.EventHandler(this.button_Zatvori_Click);
            // 
            // button_Dodaj
            // 
            this.button_Dodaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Dodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Dodaj.Location = new System.Drawing.Point(305, 280);
            this.button_Dodaj.Name = "button_Dodaj";
            this.button_Dodaj.Size = new System.Drawing.Size(106, 37);
            this.button_Dodaj.TabIndex = 22;
            this.button_Dodaj.Text = "Dodaj";
            this.button_Dodaj.UseVisualStyleBackColor = false;
            this.button_Dodaj.Click += new System.EventHandler(this.button_Dodaj_Click);
            // 
            // errorProvider_NazivAparata
            // 
            this.errorProvider_NazivAparata.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelDodajAparat});
            this.statusStrip1.Location = new System.Drawing.Point(0, 351);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(686, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelDodajAparat
            // 
            this.toolStripStatusLabelDodajAparat.Name = "toolStripStatusLabelDodajAparat";
            this.toolStripStatusLabelDodajAparat.Size = new System.Drawing.Size(0, 17);
            // 
            // DodajAparat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 373);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_Zatvori);
            this.Controls.Add(this.button_Dodaj);
            this.Controls.Add(this.comboBox_Ordinacija);
            this.Controls.Add(this.label_Ordinacija);
            this.Controls.Add(this.groupBox_Aktivnost);
            this.Controls.Add(this.textBox_NazivOrdinacije);
            this.Controls.Add(this.label_NazivAparata);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajAparat";
            this.Text = "Dodavanje aparata";
            this.Load += new System.EventHandler(this.DodajAparat_Load);
            this.groupBox_Aktivnost.ResumeLayout(false);
            this.groupBox_Aktivnost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_NazivAparata)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Aktivnost;
        private System.Windows.Forms.RadioButton radioButton_Neaktivna;
        private System.Windows.Forms.RadioButton radioButton_Aktivna;
        private System.Windows.Forms.TextBox textBox_NazivOrdinacije;
        private System.Windows.Forms.Label label_NazivAparata;
        private System.Windows.Forms.ComboBox comboBox_Ordinacija;
        private System.Windows.Forms.Label label_Ordinacija;
        private System.Windows.Forms.Button button_Zatvori;
        private System.Windows.Forms.Button button_Dodaj;
        private System.Windows.Forms.ToolTip toolTip_Aktivan;
        private System.Windows.Forms.ErrorProvider errorProvider_NazivAparata;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDodajAparat;
    }
}