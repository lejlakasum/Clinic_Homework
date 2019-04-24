namespace Zadaca2
{
    partial class Prijava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prijava));
            this.label_KorisnickoIme = new System.Windows.Forms.Label();
            this.label_Lozinka = new System.Windows.Forms.Label();
            this.textBoxLozinka = new System.Windows.Forms.TextBox();
            this.textBox_KorisnickoIme = new System.Windows.Forms.TextBox();
            this.button_Prijava = new System.Windows.Forms.Button();
            this.button_Zatvori = new System.Windows.Forms.Button();
            this.statusStrip_Prijava = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusPrijava = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_Info = new System.Windows.Forms.Button();
            this.statusStrip_Prijava.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_KorisnickoIme
            // 
            this.label_KorisnickoIme.AutoSize = true;
            this.label_KorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_KorisnickoIme.Location = new System.Drawing.Point(338, 125);
            this.label_KorisnickoIme.Name = "label_KorisnickoIme";
            this.label_KorisnickoIme.Size = new System.Drawing.Size(119, 20);
            this.label_KorisnickoIme.TabIndex = 0;
            this.label_KorisnickoIme.Text = "Korisničko ime";
            // 
            // label_Lozinka
            // 
            this.label_Lozinka.AutoSize = true;
            this.label_Lozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Lozinka.Location = new System.Drawing.Point(338, 203);
            this.label_Lozinka.Name = "label_Lozinka";
            this.label_Lozinka.Size = new System.Drawing.Size(67, 20);
            this.label_Lozinka.TabIndex = 1;
            this.label_Lozinka.Text = "Lozinka";
            // 
            // textBoxLozinka
            // 
            this.textBoxLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLozinka.Location = new System.Drawing.Point(482, 196);
            this.textBoxLozinka.Name = "textBoxLozinka";
            this.textBoxLozinka.PasswordChar = '*';
            this.textBoxLozinka.Size = new System.Drawing.Size(212, 27);
            this.textBoxLozinka.TabIndex = 2;
            // 
            // textBox_KorisnickoIme
            // 
            this.textBox_KorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_KorisnickoIme.Location = new System.Drawing.Point(482, 122);
            this.textBox_KorisnickoIme.Name = "textBox_KorisnickoIme";
            this.textBox_KorisnickoIme.Size = new System.Drawing.Size(212, 27);
            this.textBox_KorisnickoIme.TabIndex = 3;
            // 
            // button_Prijava
            // 
            this.button_Prijava.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Prijava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Prijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Prijava.Location = new System.Drawing.Point(341, 332);
            this.button_Prijava.Name = "button_Prijava";
            this.button_Prijava.Size = new System.Drawing.Size(109, 37);
            this.button_Prijava.TabIndex = 4;
            this.button_Prijava.Text = "Prijava";
            this.button_Prijava.UseVisualStyleBackColor = false;
            this.button_Prijava.Click += new System.EventHandler(this.button_Prijava_Click);
            // 
            // button_Zatvori
            // 
            this.button_Zatvori.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Zatvori.CausesValidation = false;
            this.button_Zatvori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Zatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Zatvori.Location = new System.Drawing.Point(546, 332);
            this.button_Zatvori.Name = "button_Zatvori";
            this.button_Zatvori.Size = new System.Drawing.Size(109, 37);
            this.button_Zatvori.TabIndex = 5;
            this.button_Zatvori.Text = "Zatvori";
            this.button_Zatvori.UseVisualStyleBackColor = false;
            this.button_Zatvori.Click += new System.EventHandler(this.button_Zatvori_Click);
            // 
            // statusStrip_Prijava
            // 
            this.statusStrip_Prijava.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip_Prijava.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusPrijava});
            this.statusStrip_Prijava.Location = new System.Drawing.Point(0, 389);
            this.statusStrip_Prijava.Name = "statusStrip_Prijava";
            this.statusStrip_Prijava.Size = new System.Drawing.Size(742, 22);
            this.statusStrip_Prijava.TabIndex = 6;
            this.statusStrip_Prijava.Text = "statusStrip1";
            this.statusStrip_Prijava.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip_Prijava_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusPrijava
            // 
            this.toolStripStatusPrijava.Name = "toolStripStatusPrijava";
            this.toolStripStatusPrijava.Size = new System.Drawing.Size(0, 17);
            // 
            // button_Info
            // 
            this.button_Info.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Info.Location = new System.Drawing.Point(667, 2);
            this.button_Info.Name = "button_Info";
            this.button_Info.Size = new System.Drawing.Size(75, 29);
            this.button_Info.TabIndex = 7;
            this.button_Info.Text = "Info";
            this.button_Info.UseVisualStyleBackColor = false;
            this.button_Info.Click += new System.EventHandler(this.button_Info_Click);
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 411);
            this.Controls.Add(this.button_Info);
            this.Controls.Add(this.statusStrip_Prijava);
            this.Controls.Add(this.button_Zatvori);
            this.Controls.Add(this.button_Prijava);
            this.Controls.Add(this.textBox_KorisnickoIme);
            this.Controls.Add(this.textBoxLozinka);
            this.Controls.Add(this.label_Lozinka);
            this.Controls.Add(this.label_KorisnickoIme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Prijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.Prijava_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Prijava_Paint);
            this.statusStrip_Prijava.ResumeLayout(false);
            this.statusStrip_Prijava.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_KorisnickoIme;
        private System.Windows.Forms.Label label_Lozinka;
        private System.Windows.Forms.TextBox textBoxLozinka;
        private System.Windows.Forms.TextBox textBox_KorisnickoIme;
        private System.Windows.Forms.Button button_Prijava;
        private System.Windows.Forms.Button button_Zatvori;
        private System.Windows.Forms.StatusStrip statusStrip_Prijava;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusPrijava;
        private System.Windows.Forms.Button button_Info;
    }
}