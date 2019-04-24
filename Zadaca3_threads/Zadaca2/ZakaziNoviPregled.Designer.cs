namespace Zadaca2
{
    partial class ZakaziNoviPregled
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZakaziNoviPregled));
            this.groupBox_registracijaPregleda = new System.Windows.Forms.GroupBox();
            this.checkedListBox_Pregledi = new System.Windows.Forms.CheckedListBox();
            this.button_Registruj = new System.Windows.Forms.Button();
            this.label_OdabirPregleda = new System.Windows.Forms.Label();
            this.button_Zakazi = new System.Windows.Forms.Button();
            this.button_Zatvori = new System.Windows.Forms.Button();
            this.groupBox_registracijaPregleda.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_registracijaPregleda
            // 
            this.groupBox_registracijaPregleda.BackColor = System.Drawing.Color.LightGray;
            this.groupBox_registracijaPregleda.Controls.Add(this.button_Zatvori);
            this.groupBox_registracijaPregleda.Controls.Add(this.button_Zakazi);
            this.groupBox_registracijaPregleda.Controls.Add(this.checkedListBox_Pregledi);
            this.groupBox_registracijaPregleda.Controls.Add(this.button_Registruj);
            this.groupBox_registracijaPregleda.Controls.Add(this.label_OdabirPregleda);
            this.groupBox_registracijaPregleda.Location = new System.Drawing.Point(13, 13);
            this.groupBox_registracijaPregleda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_registracijaPregleda.Name = "groupBox_registracijaPregleda";
            this.groupBox_registracijaPregleda.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_registracijaPregleda.Size = new System.Drawing.Size(504, 595);
            this.groupBox_registracijaPregleda.TabIndex = 5;
            this.groupBox_registracijaPregleda.TabStop = false;
            this.groupBox_registracijaPregleda.Text = "Registracija pregleda";
            // 
            // checkedListBox_Pregledi
            // 
            this.checkedListBox_Pregledi.CheckOnClick = true;
            this.checkedListBox_Pregledi.FormattingEnabled = true;
            this.checkedListBox_Pregledi.Location = new System.Drawing.Point(18, 55);
            this.checkedListBox_Pregledi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkedListBox_Pregledi.Name = "checkedListBox_Pregledi";
            this.checkedListBox_Pregledi.Size = new System.Drawing.Size(462, 466);
            this.checkedListBox_Pregledi.TabIndex = 6;
            // 
            // button_Registruj
            // 
            this.button_Registruj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Registruj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Registruj.Location = new System.Drawing.Point(160, 609);
            this.button_Registruj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Registruj.Name = "button_Registruj";
            this.button_Registruj.Size = new System.Drawing.Size(208, 44);
            this.button_Registruj.TabIndex = 5;
            this.button_Registruj.Text = "Registruj";
            this.button_Registruj.UseVisualStyleBackColor = false;
            // 
            // label_OdabirPregleda
            // 
            this.label_OdabirPregleda.AutoSize = true;
            this.label_OdabirPregleda.Location = new System.Drawing.Point(14, 31);
            this.label_OdabirPregleda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_OdabirPregleda.Name = "label_OdabirPregleda";
            this.label_OdabirPregleda.Size = new System.Drawing.Size(151, 20);
            this.label_OdabirPregleda.TabIndex = 2;
            this.label_OdabirPregleda.Text = "Odaberite preglede";
            // 
            // button_Zakazi
            // 
            this.button_Zakazi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Zakazi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Zakazi.Location = new System.Drawing.Point(83, 543);
            this.button_Zakazi.Name = "button_Zakazi";
            this.button_Zakazi.Size = new System.Drawing.Size(113, 45);
            this.button_Zakazi.TabIndex = 7;
            this.button_Zakazi.Text = "&Zakaži";
            this.button_Zakazi.UseVisualStyleBackColor = false;
            this.button_Zakazi.Click += new System.EventHandler(this.button_Zakazi_Click);
            // 
            // button_Zatvori
            // 
            this.button_Zatvori.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Zatvori.CausesValidation = false;
            this.button_Zatvori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Zatvori.Location = new System.Drawing.Point(293, 543);
            this.button_Zatvori.Name = "button_Zatvori";
            this.button_Zatvori.Size = new System.Drawing.Size(113, 45);
            this.button_Zatvori.TabIndex = 8;
            this.button_Zatvori.Text = "&Zatvori";
            this.button_Zatvori.UseVisualStyleBackColor = false;
            this.button_Zatvori.Click += new System.EventHandler(this.button_Zatvori_Click);
            // 
            // ZakaziNoviPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 621);
            this.Controls.Add(this.groupBox_registracijaPregleda);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ZakaziNoviPregled";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zakazivanje novog pregleda";
            this.Load += new System.EventHandler(this.ZakaziNoviPregled_Load);
            this.groupBox_registracijaPregleda.ResumeLayout(false);
            this.groupBox_registracijaPregleda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_registracijaPregleda;
        private System.Windows.Forms.Button button_Zatvori;
        private System.Windows.Forms.Button button_Zakazi;
        private System.Windows.Forms.CheckedListBox checkedListBox_Pregledi;
        private System.Windows.Forms.Button button_Registruj;
        private System.Windows.Forms.Label label_OdabirPregleda;
    }
}