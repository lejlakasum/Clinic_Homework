namespace Zadaca2
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osobljeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordinacijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aparatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osobljeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ordinacijuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aparatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.masovniUnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvozPodatakaUDatotekuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uvozPodatakaIzDatotekeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusAdmin = new System.Windows.Forms.ToolStripStatusLabel();
            this.label_Dobrodosli = new System.Windows.Forms.Label();
            this.label_Uloga = new System.Windows.Forms.Label();
            this.label_Datum = new System.Windows.Forms.Label();
            this.groupBox_Dobrodosli = new System.Windows.Forms.GroupBox();
            this.groupBox_PromjenaLozinke = new System.Windows.Forms.GroupBox();
            this.buttonPromijeni = new System.Windows.Forms.Button();
            this.textBox_NovaP = new System.Windows.Forms.TextBox();
            this.textBox_Nova = new System.Windows.Forms.TextBox();
            this.textBox_Stara = new System.Windows.Forms.TextBox();
            this.textBox_Kime = new System.Windows.Forms.TextBox();
            this.label_PonoviL = new System.Windows.Forms.Label();
            this.label_NovaL = new System.Windows.Forms.Label();
            this.label_StaraL = new System.Windows.Forms.Label();
            this.label_Kime = new System.Windows.Forms.Label();
            this.errorProvider_StaraLozinka = new System.Windows.Forms.ErrorProvider(this.components);
            this.button_Odjava = new System.Windows.Forms.Button();
            this.button_PromijeniLozinku = new System.Windows.Forms.Button();
            this.errorProvider_NovaL = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_NovaP = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.promijeniBojuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox_Dobrodosli.SuspendLayout();
            this.groupBox_PromjenaLozinke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_StaraLozinka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_NovaL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_NovaP)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.urediToolStripMenuItem,
            this.masovniUnosToolStripMenuItem,
            this.loggerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1079, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osobljeToolStripMenuItem,
            this.ordinacijuToolStripMenuItem,
            this.aparatToolStripMenuItem,
            this.pregledToolStripMenuItem});
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            // 
            // osobljeToolStripMenuItem
            // 
            this.osobljeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("osobljeToolStripMenuItem.Image")));
            this.osobljeToolStripMenuItem.Name = "osobljeToolStripMenuItem";
            this.osobljeToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.osobljeToolStripMenuItem.Text = "Osoblje";
            this.osobljeToolStripMenuItem.Click += new System.EventHandler(this.osobljeToolStripMenuItem_Click);
            // 
            // ordinacijuToolStripMenuItem
            // 
            this.ordinacijuToolStripMenuItem.Name = "ordinacijuToolStripMenuItem";
            this.ordinacijuToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.ordinacijuToolStripMenuItem.Text = "Ordinaciju";
            this.ordinacijuToolStripMenuItem.Click += new System.EventHandler(this.ordinacijuToolStripMenuItem_Click);
            // 
            // aparatToolStripMenuItem
            // 
            this.aparatToolStripMenuItem.Name = "aparatToolStripMenuItem";
            this.aparatToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.aparatToolStripMenuItem.Text = "Aparat";
            this.aparatToolStripMenuItem.Click += new System.EventHandler(this.aparatToolStripMenuItem_Click);
            // 
            // pregledToolStripMenuItem
            // 
            this.pregledToolStripMenuItem.Name = "pregledToolStripMenuItem";
            this.pregledToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.pregledToolStripMenuItem.Text = "Pregled";
            this.pregledToolStripMenuItem.Click += new System.EventHandler(this.pregledToolStripMenuItem_Click);
            // 
            // urediToolStripMenuItem
            // 
            this.urediToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osobljeToolStripMenuItem1,
            this.ordinacijuToolStripMenuItem1,
            this.aparatToolStripMenuItem1,
            this.pregledToolStripMenuItem1});
            this.urediToolStripMenuItem.Name = "urediToolStripMenuItem";
            this.urediToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.urediToolStripMenuItem.Text = "Uredi";
            // 
            // osobljeToolStripMenuItem1
            // 
            this.osobljeToolStripMenuItem1.Name = "osobljeToolStripMenuItem1";
            this.osobljeToolStripMenuItem1.Size = new System.Drawing.Size(152, 26);
            this.osobljeToolStripMenuItem1.Text = "Osoblje";
            this.osobljeToolStripMenuItem1.Click += new System.EventHandler(this.osobljeToolStripMenuItem1_Click);
            // 
            // ordinacijuToolStripMenuItem1
            // 
            this.ordinacijuToolStripMenuItem1.Name = "ordinacijuToolStripMenuItem1";
            this.ordinacijuToolStripMenuItem1.Size = new System.Drawing.Size(152, 26);
            this.ordinacijuToolStripMenuItem1.Text = "Ordinaciju";
            this.ordinacijuToolStripMenuItem1.Click += new System.EventHandler(this.ordinacijuToolStripMenuItem1_Click);
            // 
            // aparatToolStripMenuItem1
            // 
            this.aparatToolStripMenuItem1.Name = "aparatToolStripMenuItem1";
            this.aparatToolStripMenuItem1.Size = new System.Drawing.Size(152, 26);
            this.aparatToolStripMenuItem1.Text = "Aparat";
            // 
            // pregledToolStripMenuItem1
            // 
            this.pregledToolStripMenuItem1.Name = "pregledToolStripMenuItem1";
            this.pregledToolStripMenuItem1.Size = new System.Drawing.Size(152, 26);
            this.pregledToolStripMenuItem1.Text = "Pregled";
            this.pregledToolStripMenuItem1.Click += new System.EventHandler(this.pregledToolStripMenuItem1_Click);
            // 
            // masovniUnosToolStripMenuItem
            // 
            this.masovniUnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izvozPodatakaUDatotekuToolStripMenuItem,
            this.uvozPodatakaIzDatotekeToolStripMenuItem});
            this.masovniUnosToolStripMenuItem.Name = "masovniUnosToolStripMenuItem";
            this.masovniUnosToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.masovniUnosToolStripMenuItem.Text = "Masovni uvoz i izvoz";
            // 
            // izvozPodatakaUDatotekuToolStripMenuItem
            // 
            this.izvozPodatakaUDatotekuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("izvozPodatakaUDatotekuToolStripMenuItem.Image")));
            this.izvozPodatakaUDatotekuToolStripMenuItem.Name = "izvozPodatakaUDatotekuToolStripMenuItem";
            this.izvozPodatakaUDatotekuToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.izvozPodatakaUDatotekuToolStripMenuItem.Text = "Izvoz podataka u datoteku";
            this.izvozPodatakaUDatotekuToolStripMenuItem.Click += new System.EventHandler(this.izvozPodatakaUDatotekuToolStripMenuItem_Click);
            // 
            // uvozPodatakaIzDatotekeToolStripMenuItem
            // 
            this.uvozPodatakaIzDatotekeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("uvozPodatakaIzDatotekeToolStripMenuItem.Image")));
            this.uvozPodatakaIzDatotekeToolStripMenuItem.Name = "uvozPodatakaIzDatotekeToolStripMenuItem";
            this.uvozPodatakaIzDatotekeToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.uvozPodatakaIzDatotekeToolStripMenuItem.Text = "Uvoz podataka iz datoteke";
            this.uvozPodatakaIzDatotekeToolStripMenuItem.Click += new System.EventHandler(this.uvozPodatakaIzDatotekeToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusAdmin});
            this.statusStrip1.Location = new System.Drawing.Point(0, 519);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1079, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusAdmin
            // 
            this.toolStripStatusAdmin.Name = "toolStripStatusAdmin";
            this.toolStripStatusAdmin.Size = new System.Drawing.Size(0, 17);
            // 
            // label_Dobrodosli
            // 
            this.label_Dobrodosli.AutoSize = true;
            this.label_Dobrodosli.Location = new System.Drawing.Point(41, 80);
            this.label_Dobrodosli.Name = "label_Dobrodosli";
            this.label_Dobrodosli.Size = new System.Drawing.Size(95, 20);
            this.label_Dobrodosli.TabIndex = 2;
            this.label_Dobrodosli.Text = "Dobrodošli ";
            // 
            // label_Uloga
            // 
            this.label_Uloga.AutoSize = true;
            this.label_Uloga.Location = new System.Drawing.Point(41, 139);
            this.label_Uloga.Name = "label_Uloga";
            this.label_Uloga.Size = new System.Drawing.Size(145, 20);
            this.label_Uloga.TabIndex = 3;
            this.label_Uloga.Text = "Prijavljeni ste kao ";
            // 
            // label_Datum
            // 
            this.label_Datum.AutoSize = true;
            this.label_Datum.Location = new System.Drawing.Point(41, 18);
            this.label_Datum.Name = "label_Datum";
            this.label_Datum.Size = new System.Drawing.Size(69, 20);
            this.label_Datum.TabIndex = 4;
            this.label_Datum.Text = "Datum: ";
            // 
            // groupBox_Dobrodosli
            // 
            this.groupBox_Dobrodosli.Controls.Add(this.label_Dobrodosli);
            this.groupBox_Dobrodosli.Controls.Add(this.label_Datum);
            this.groupBox_Dobrodosli.Controls.Add(this.label_Uloga);
            this.groupBox_Dobrodosli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_Dobrodosli.Location = new System.Drawing.Point(33, 164);
            this.groupBox_Dobrodosli.Name = "groupBox_Dobrodosli";
            this.groupBox_Dobrodosli.Size = new System.Drawing.Size(355, 187);
            this.groupBox_Dobrodosli.TabIndex = 5;
            this.groupBox_Dobrodosli.TabStop = false;
            // 
            // groupBox_PromjenaLozinke
            // 
            this.groupBox_PromjenaLozinke.Controls.Add(this.buttonPromijeni);
            this.groupBox_PromjenaLozinke.Controls.Add(this.textBox_NovaP);
            this.groupBox_PromjenaLozinke.Controls.Add(this.textBox_Nova);
            this.groupBox_PromjenaLozinke.Controls.Add(this.textBox_Stara);
            this.groupBox_PromjenaLozinke.Controls.Add(this.textBox_Kime);
            this.groupBox_PromjenaLozinke.Controls.Add(this.label_PonoviL);
            this.groupBox_PromjenaLozinke.Controls.Add(this.label_NovaL);
            this.groupBox_PromjenaLozinke.Controls.Add(this.label_StaraL);
            this.groupBox_PromjenaLozinke.Controls.Add(this.label_Kime);
            this.groupBox_PromjenaLozinke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_PromjenaLozinke.Location = new System.Drawing.Point(539, 123);
            this.groupBox_PromjenaLozinke.Name = "groupBox_PromjenaLozinke";
            this.groupBox_PromjenaLozinke.Size = new System.Drawing.Size(471, 295);
            this.groupBox_PromjenaLozinke.TabIndex = 6;
            this.groupBox_PromjenaLozinke.TabStop = false;
            this.groupBox_PromjenaLozinke.Text = "Promijeni lozinku";
            // 
            // buttonPromijeni
            // 
            this.buttonPromijeni.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPromijeni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPromijeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPromijeni.Location = new System.Drawing.Point(196, 235);
            this.buttonPromijeni.Name = "buttonPromijeni";
            this.buttonPromijeni.Size = new System.Drawing.Size(115, 35);
            this.buttonPromijeni.TabIndex = 8;
            this.buttonPromijeni.Text = "&Promijeni";
            this.buttonPromijeni.UseVisualStyleBackColor = false;
            this.buttonPromijeni.Click += new System.EventHandler(this.buttonPromijeni_Click);
            // 
            // textBox_NovaP
            // 
            this.textBox_NovaP.Location = new System.Drawing.Point(196, 157);
            this.textBox_NovaP.Name = "textBox_NovaP";
            this.textBox_NovaP.PasswordChar = '*';
            this.textBox_NovaP.Size = new System.Drawing.Size(212, 27);
            this.textBox_NovaP.TabIndex = 7;
            this.textBox_NovaP.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_NovaP_Validating);
            this.textBox_NovaP.Validated += new System.EventHandler(this.textBox_NovaP_Validated);
            // 
            // textBox_Nova
            // 
            this.textBox_Nova.Location = new System.Drawing.Point(196, 117);
            this.textBox_Nova.Name = "textBox_Nova";
            this.textBox_Nova.PasswordChar = '*';
            this.textBox_Nova.Size = new System.Drawing.Size(212, 27);
            this.textBox_Nova.TabIndex = 6;
            this.textBox_Nova.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Nova_Validating);
            this.textBox_Nova.Validated += new System.EventHandler(this.textBox_Nova_Validated);
            // 
            // textBox_Stara
            // 
            this.textBox_Stara.Location = new System.Drawing.Point(196, 78);
            this.textBox_Stara.Name = "textBox_Stara";
            this.textBox_Stara.PasswordChar = '*';
            this.textBox_Stara.Size = new System.Drawing.Size(212, 27);
            this.textBox_Stara.TabIndex = 5;
            this.textBox_Stara.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Stara_Validating);
            this.textBox_Stara.Validated += new System.EventHandler(this.textBox_Stara_Validated);
            // 
            // textBox_Kime
            // 
            this.textBox_Kime.Location = new System.Drawing.Point(196, 36);
            this.textBox_Kime.Name = "textBox_Kime";
            this.textBox_Kime.ReadOnly = true;
            this.textBox_Kime.Size = new System.Drawing.Size(212, 27);
            this.textBox_Kime.TabIndex = 4;
            // 
            // label_PonoviL
            // 
            this.label_PonoviL.AutoSize = true;
            this.label_PonoviL.Location = new System.Drawing.Point(37, 157);
            this.label_PonoviL.Name = "label_PonoviL";
            this.label_PonoviL.Size = new System.Drawing.Size(113, 20);
            this.label_PonoviL.TabIndex = 3;
            this.label_PonoviL.Text = "Ponovite novu";
            // 
            // label_NovaL
            // 
            this.label_NovaL.AutoSize = true;
            this.label_NovaL.Location = new System.Drawing.Point(37, 120);
            this.label_NovaL.Name = "label_NovaL";
            this.label_NovaL.Size = new System.Drawing.Size(104, 20);
            this.label_NovaL.TabIndex = 2;
            this.label_NovaL.Text = "Nova lozinka";
            this.label_NovaL.Click += new System.EventHandler(this.label_NovaL_Click);
            // 
            // label_StaraL
            // 
            this.label_StaraL.AutoSize = true;
            this.label_StaraL.Location = new System.Drawing.Point(37, 78);
            this.label_StaraL.Name = "label_StaraL";
            this.label_StaraL.Size = new System.Drawing.Size(106, 20);
            this.label_StaraL.TabIndex = 1;
            this.label_StaraL.Text = "Stara lozinka";
            // 
            // label_Kime
            // 
            this.label_Kime.AutoSize = true;
            this.label_Kime.Location = new System.Drawing.Point(37, 36);
            this.label_Kime.Name = "label_Kime";
            this.label_Kime.Size = new System.Drawing.Size(119, 20);
            this.label_Kime.TabIndex = 0;
            this.label_Kime.Text = "Korisničko ime";
            // 
            // errorProvider_StaraLozinka
            // 
            this.errorProvider_StaraLozinka.ContainerControl = this;
            // 
            // button_Odjava
            // 
            this.button_Odjava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Odjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Odjava.Location = new System.Drawing.Point(967, 55);
            this.button_Odjava.Name = "button_Odjava";
            this.button_Odjava.Size = new System.Drawing.Size(100, 32);
            this.button_Odjava.TabIndex = 7;
            this.button_Odjava.Text = "&Odjava";
            this.button_Odjava.UseVisualStyleBackColor = true;
            this.button_Odjava.Click += new System.EventHandler(this.button_Odjava_Click);
            // 
            // button_PromijeniLozinku
            // 
            this.button_PromijeniLozinku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_PromijeniLozinku.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_PromijeniLozinku.Location = new System.Drawing.Point(814, 41);
            this.button_PromijeniLozinku.Name = "button_PromijeniLozinku";
            this.button_PromijeniLozinku.Size = new System.Drawing.Size(100, 60);
            this.button_PromijeniLozinku.TabIndex = 8;
            this.button_PromijeniLozinku.Text = "&Promijeni Lozinku";
            this.button_PromijeniLozinku.UseVisualStyleBackColor = true;
            this.button_PromijeniLozinku.Click += new System.EventHandler(this.button_PromijeniLozinku_Click);
            // 
            // errorProvider_NovaL
            // 
            this.errorProvider_NovaL.ContainerControl = this;
            // 
            // errorProvider_NovaP
            // 
            this.errorProvider_NovaP.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promijeniBojuToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 28);
            // 
            // promijeniBojuToolStripMenuItem
            // 
            this.promijeniBojuToolStripMenuItem.Name = "promijeniBojuToolStripMenuItem";
            this.promijeniBojuToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.promijeniBojuToolStripMenuItem.Text = "Promijeni boju";
            this.promijeniBojuToolStripMenuItem.Click += new System.EventHandler(this.promijeniBojuToolStripMenuItem_Click);
            // 
            // loggerToolStripMenuItem
            // 
            this.loggerToolStripMenuItem.Name = "loggerToolStripMenuItem";
            this.loggerToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.loggerToolStripMenuItem.Text = "Logovi";
            this.loggerToolStripMenuItem.Click += new System.EventHandler(this.loggerToolStripMenuItem_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 541);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button_PromijeniLozinku);
            this.Controls.Add(this.button_Odjava);
            this.Controls.Add(this.groupBox_PromjenaLozinke);
            this.Controls.Add(this.groupBox_Dobrodosli);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox_Dobrodosli.ResumeLayout(false);
            this.groupBox_Dobrodosli.PerformLayout();
            this.groupBox_PromjenaLozinke.ResumeLayout(false);
            this.groupBox_PromjenaLozinke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_StaraLozinka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_NovaL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_NovaP)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osobljeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordinacijuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aparatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urediToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osobljeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ordinacijuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aparatToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusAdmin;
        private System.Windows.Forms.Label label_Dobrodosli;
        private System.Windows.Forms.Label label_Uloga;
        private System.Windows.Forms.Label label_Datum;
        private System.Windows.Forms.GroupBox groupBox_Dobrodosli;
        private System.Windows.Forms.GroupBox groupBox_PromjenaLozinke;
        private System.Windows.Forms.Label label_PonoviL;
        private System.Windows.Forms.Label label_NovaL;
        private System.Windows.Forms.Label label_StaraL;
        private System.Windows.Forms.Label label_Kime;
        private System.Windows.Forms.TextBox textBox_Kime;
        private System.Windows.Forms.TextBox textBox_Nova;
        private System.Windows.Forms.TextBox textBox_Stara;
        private System.Windows.Forms.TextBox textBox_NovaP;
        private System.Windows.Forms.Button buttonPromijeni;
        private System.Windows.Forms.ErrorProvider errorProvider_StaraLozinka;
        private System.Windows.Forms.Button button_Odjava;
        private System.Windows.Forms.Button button_PromijeniLozinku;
        private System.Windows.Forms.ErrorProvider errorProvider_NovaL;
        private System.Windows.Forms.ErrorProvider errorProvider_NovaP;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem promijeniBojuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masovniUnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvozPodatakaUDatotekuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uvozPodatakaIzDatotekeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loggerToolStripMenuItem;
    }
}