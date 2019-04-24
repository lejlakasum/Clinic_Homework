namespace Zadaca2
{
    partial class DodajOrdinaciju
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajOrdinaciju));
            this.label_NazivOrdinacije = new System.Windows.Forms.Label();
            this.textBox_NazivOrdinacije = new System.Windows.Forms.TextBox();
            this.groupBox_Aktivnost = new System.Windows.Forms.GroupBox();
            this.radioButton_Neaktivna = new System.Windows.Forms.RadioButton();
            this.radioButton_Aktivna = new System.Windows.Forms.RadioButton();
            this.errorProvider_NazivOrdinacije = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip_Aktivnost = new System.Windows.Forms.ToolTip(this.components);
            this.button_Dodaj = new System.Windows.Forms.Button();
            this.button_Zatvori = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelDodavanjeOrdinacije = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox_Aktivnost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_NazivOrdinacije)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_NazivOrdinacije
            // 
            this.label_NazivOrdinacije.AutoSize = true;
            this.label_NazivOrdinacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_NazivOrdinacije.Location = new System.Drawing.Point(49, 31);
            this.label_NazivOrdinacije.Name = "label_NazivOrdinacije";
            this.label_NazivOrdinacije.Size = new System.Drawing.Size(128, 20);
            this.label_NazivOrdinacije.TabIndex = 0;
            this.label_NazivOrdinacije.Text = "Naziv ordinacije";
            // 
            // textBox_NazivOrdinacije
            // 
            this.textBox_NazivOrdinacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_NazivOrdinacije.Location = new System.Drawing.Point(243, 28);
            this.textBox_NazivOrdinacije.Name = "textBox_NazivOrdinacije";
            this.textBox_NazivOrdinacije.Size = new System.Drawing.Size(216, 27);
            this.textBox_NazivOrdinacije.TabIndex = 1;
            this.textBox_NazivOrdinacije.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            this.textBox_NazivOrdinacije.Validated += new System.EventHandler(this.textBox_NazivOrdinacije_Validated);
            // 
            // groupBox_Aktivnost
            // 
            this.groupBox_Aktivnost.Controls.Add(this.radioButton_Neaktivna);
            this.groupBox_Aktivnost.Controls.Add(this.radioButton_Aktivna);
            this.groupBox_Aktivnost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_Aktivnost.Location = new System.Drawing.Point(102, 87);
            this.groupBox_Aktivnost.Name = "groupBox_Aktivnost";
            this.groupBox_Aktivnost.Size = new System.Drawing.Size(284, 67);
            this.groupBox_Aktivnost.TabIndex = 2;
            this.groupBox_Aktivnost.TabStop = false;
            this.groupBox_Aktivnost.MouseHover += new System.EventHandler(this.groupBox_Aktivnost_MouseHover);
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
            this.radioButton_Aktivna.CheckedChanged += new System.EventHandler(this.radioButton_Aktivna_CheckedChanged);
            // 
            // errorProvider_NazivOrdinacije
            // 
            this.errorProvider_NazivOrdinacije.ContainerControl = this;
            // 
            // button_Dodaj
            // 
            this.button_Dodaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Dodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Dodaj.Location = new System.Drawing.Point(102, 205);
            this.button_Dodaj.Name = "button_Dodaj";
            this.button_Dodaj.Size = new System.Drawing.Size(106, 37);
            this.button_Dodaj.TabIndex = 3;
            this.button_Dodaj.Text = "Dodaj";
            this.button_Dodaj.UseVisualStyleBackColor = false;
            this.button_Dodaj.Click += new System.EventHandler(this.button_Dodaj_Click);
            // 
            // button_Zatvori
            // 
            this.button_Zatvori.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Zatvori.CausesValidation = false;
            this.button_Zatvori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Zatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Zatvori.Location = new System.Drawing.Point(280, 205);
            this.button_Zatvori.Name = "button_Zatvori";
            this.button_Zatvori.Size = new System.Drawing.Size(106, 37);
            this.button_Zatvori.TabIndex = 4;
            this.button_Zatvori.Text = "Zatvori";
            this.button_Zatvori.UseVisualStyleBackColor = false;
            this.button_Zatvori.Click += new System.EventHandler(this.button_Zatvori_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelDodavanjeOrdinacije});
            this.statusStrip1.Location = new System.Drawing.Point(0, 247);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(500, 24);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelDodavanjeOrdinacije
            // 
            this.toolStripStatusLabelDodavanjeOrdinacije.Name = "toolStripStatusLabelDodavanjeOrdinacije";
            this.toolStripStatusLabelDodavanjeOrdinacije.Size = new System.Drawing.Size(0, 19);
            // 
            // DodajOrdinaciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 271);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_Zatvori);
            this.Controls.Add(this.button_Dodaj);
            this.Controls.Add(this.groupBox_Aktivnost);
            this.Controls.Add(this.textBox_NazivOrdinacije);
            this.Controls.Add(this.label_NazivOrdinacije);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DodajOrdinaciju";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje ordinacije";
            this.Load += new System.EventHandler(this.DodajOrdinaciju_Load);
            this.groupBox_Aktivnost.ResumeLayout(false);
            this.groupBox_Aktivnost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_NazivOrdinacije)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_NazivOrdinacije;
        private System.Windows.Forms.TextBox textBox_NazivOrdinacije;
        private System.Windows.Forms.GroupBox groupBox_Aktivnost;
        private System.Windows.Forms.RadioButton radioButton_Neaktivna;
        private System.Windows.Forms.RadioButton radioButton_Aktivna;
        private System.Windows.Forms.ErrorProvider errorProvider_NazivOrdinacije;
        private System.Windows.Forms.ToolTip toolTip_Aktivnost;
        private System.Windows.Forms.Button button_Zatvori;
        private System.Windows.Forms.Button button_Dodaj;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDodavanjeOrdinacije;
    }
}