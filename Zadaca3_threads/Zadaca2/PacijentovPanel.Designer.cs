namespace Zadaca2
{
    partial class PacijentovPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PacijentovPanel));
            this.tabControl_Pacijent = new System.Windows.Forms.TabControl();
            this.tabPage_Profil = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.asdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_Dobrodosli = new System.Windows.Forms.GroupBox();
            this.label_Dobrodosli = new System.Windows.Forms.Label();
            this.label_Datum = new System.Windows.Forms.Label();
            this.label_Uloga = new System.Windows.Forms.Label();
            this.button_PromijeniLozinku = new System.Windows.Forms.Button();
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
            this.tabPage_Karton = new System.Windows.Forms.TabPage();
            this.groupBox_Tab1LicniPodaci = new System.Windows.Forms.GroupBox();
            this.label_PisiBrojRata = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_PisiUkupanDug = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_PisiBrojPosjeta = new System.Windows.Forms.Label();
            this.label_PisiSpol = new System.Windows.Forms.Label();
            this.label_PisiMaticniBroj = new System.Windows.Forms.Label();
            this.label_PisiAdresa = new System.Windows.Forms.Label();
            this.label_PisiEmail = new System.Windows.Forms.Label();
            this.label_PisiBracnoStanje = new System.Windows.Forms.Label();
            this.label_PisiPrezime = new System.Windows.Forms.Label();
            this.label_PisiDatumRodjenja = new System.Windows.Forms.Label();
            this.label_Tab1BrojPosjeta = new System.Windows.Forms.Label();
            this.label_PisiIme = new System.Windows.Forms.Label();
            this.label_Tab1Spol = new System.Windows.Forms.Label();
            this.label_Tab1Email = new System.Windows.Forms.Label();
            this.label_Tab1BracnoStanje = new System.Windows.Forms.Label();
            this.label_Tab1Adresa = new System.Windows.Forms.Label();
            this.label_Tab1MaticniBroj = new System.Windows.Forms.Label();
            this.label_Tab1DatumRodjenja = new System.Windows.Forms.Label();
            this.label_Tab1Prezime = new System.Windows.Forms.Label();
            this.label_Tab1Ime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_KartonPregled = new System.Windows.Forms.ListBox();
            this.slika1 = new Zadaca2.Slika();
            this.tabPage_ZauzetostOrdinacija = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox_BrojNaCekanju = new System.Windows.Forms.ListBox();
            this.listBox_Ordinacije = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelPacijent = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_Odjava = new System.Windows.Forms.Button();
            this.errorProvider_StaraLozinka = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_NovaL = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_NovaP = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl_Pacijent.SuspendLayout();
            this.tabPage_Profil.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox_Dobrodosli.SuspendLayout();
            this.groupBox_PromjenaLozinke.SuspendLayout();
            this.tabPage_Karton.SuspendLayout();
            this.groupBox_Tab1LicniPodaci.SuspendLayout();
            this.tabPage_ZauzetostOrdinacija.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_StaraLozinka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_NovaL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_NovaP)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_Pacijent
            // 
            this.tabControl_Pacijent.CausesValidation = false;
            this.tabControl_Pacijent.Controls.Add(this.tabPage_Profil);
            this.tabControl_Pacijent.Controls.Add(this.tabPage_Karton);
            this.tabControl_Pacijent.Controls.Add(this.tabPage_ZauzetostOrdinacija);
            this.tabControl_Pacijent.Location = new System.Drawing.Point(0, 13);
            this.tabControl_Pacijent.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl_Pacijent.Name = "tabControl_Pacijent";
            this.tabControl_Pacijent.SelectedIndex = 0;
            this.tabControl_Pacijent.Size = new System.Drawing.Size(1117, 575);
            this.tabControl_Pacijent.TabIndex = 0;
            // 
            // tabPage_Profil
            // 
            this.tabPage_Profil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage_Profil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage_Profil.ContextMenuStrip = this.contextMenuStrip1;
            this.tabPage_Profil.Controls.Add(this.groupBox_Dobrodosli);
            this.tabPage_Profil.Controls.Add(this.button_PromijeniLozinku);
            this.tabPage_Profil.Controls.Add(this.groupBox_PromjenaLozinke);
            this.tabPage_Profil.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Profil.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_Profil.Name = "tabPage_Profil";
            this.tabPage_Profil.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_Profil.Size = new System.Drawing.Size(1109, 542);
            this.tabPage_Profil.TabIndex = 0;
            this.tabPage_Profil.Text = "Profil";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 28);
            // 
            // asdToolStripMenuItem
            // 
            this.asdToolStripMenuItem.Name = "asdToolStripMenuItem";
            this.asdToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.asdToolStripMenuItem.Text = "Promijeni boju";
            this.asdToolStripMenuItem.Click += new System.EventHandler(this.asdToolStripMenuItem_Click);
            // 
            // groupBox_Dobrodosli
            // 
            this.groupBox_Dobrodosli.Controls.Add(this.label_Dobrodosli);
            this.groupBox_Dobrodosli.Controls.Add(this.label_Datum);
            this.groupBox_Dobrodosli.Controls.Add(this.label_Uloga);
            this.groupBox_Dobrodosli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_Dobrodosli.Location = new System.Drawing.Point(61, 185);
            this.groupBox_Dobrodosli.Name = "groupBox_Dobrodosli";
            this.groupBox_Dobrodosli.Size = new System.Drawing.Size(385, 199);
            this.groupBox_Dobrodosli.TabIndex = 15;
            this.groupBox_Dobrodosli.TabStop = false;
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
            // label_Datum
            // 
            this.label_Datum.AutoSize = true;
            this.label_Datum.Location = new System.Drawing.Point(41, 18);
            this.label_Datum.Name = "label_Datum";
            this.label_Datum.Size = new System.Drawing.Size(69, 20);
            this.label_Datum.TabIndex = 4;
            this.label_Datum.Text = "Datum: ";
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
            // button_PromijeniLozinku
            // 
            this.button_PromijeniLozinku.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_PromijeniLozinku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_PromijeniLozinku.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_PromijeniLozinku.Location = new System.Drawing.Point(1002, 7);
            this.button_PromijeniLozinku.Name = "button_PromijeniLozinku";
            this.button_PromijeniLozinku.Size = new System.Drawing.Size(100, 60);
            this.button_PromijeniLozinku.TabIndex = 14;
            this.button_PromijeniLozinku.Text = "&Promijeni Lozinku";
            this.button_PromijeniLozinku.UseVisualStyleBackColor = false;
            this.button_PromijeniLozinku.Click += new System.EventHandler(this.button_PromijeniLozinku_Click);
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
            this.groupBox_PromjenaLozinke.Location = new System.Drawing.Point(627, 135);
            this.groupBox_PromjenaLozinke.Name = "groupBox_PromjenaLozinke";
            this.groupBox_PromjenaLozinke.Size = new System.Drawing.Size(471, 295);
            this.groupBox_PromjenaLozinke.TabIndex = 13;
            this.groupBox_PromjenaLozinke.TabStop = false;
            this.groupBox_PromjenaLozinke.Text = "Promijeni lozinku";
            this.groupBox_PromjenaLozinke.Visible = false;
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
            // tabPage_Karton
            // 
            this.tabPage_Karton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage_Karton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage_Karton.ContextMenuStrip = this.contextMenuStrip1;
            this.tabPage_Karton.Controls.Add(this.groupBox_Tab1LicniPodaci);
            this.tabPage_Karton.Controls.Add(this.label1);
            this.tabPage_Karton.Controls.Add(this.listBox_KartonPregled);
            this.tabPage_Karton.Controls.Add(this.slika1);
            this.tabPage_Karton.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Karton.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_Karton.Name = "tabPage_Karton";
            this.tabPage_Karton.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_Karton.Size = new System.Drawing.Size(1109, 542);
            this.tabPage_Karton.TabIndex = 1;
            this.tabPage_Karton.Text = "Karton";
            // 
            // groupBox_Tab1LicniPodaci
            // 
            this.groupBox_Tab1LicniPodaci.BackColor = System.Drawing.Color.Silver;
            this.groupBox_Tab1LicniPodaci.Controls.Add(this.label_PisiBrojRata);
            this.groupBox_Tab1LicniPodaci.Controls.Add(this.label3);
            this.groupBox_Tab1LicniPodaci.Controls.Add(this.label_PisiUkupanDug);
            this.groupBox_Tab1LicniPodaci.Controls.Add(this.label2);
            this.groupBox_Tab1LicniPodaci.Controls.Add(this.label_PisiBrojPosjeta);
            this.groupBox_Tab1LicniPodaci.Controls.Add(this.label_PisiSpol);
            this.groupBox_Tab1LicniPodaci.Controls.Add(this.label_PisiMaticniBroj);
            this.groupBox_Tab1LicniPodaci.Controls.Add(this.label_PisiAdresa);
            this.groupBox_Tab1LicniPodaci.Controls.Add(this.label_PisiEmail);
            this.groupBox_Tab1LicniPodaci.Controls.Add(this.label_PisiBracnoStanje);
            this.groupBox_Tab1LicniPodaci.Controls.Add(this.label_PisiPrezime);
            this.groupBox_Tab1LicniPodaci.Controls.Add(this.label_PisiDatumRodjenja);
            this.groupBox_Tab1LicniPodaci.Controls.Add(this.label_Tab1BrojPosjeta);
            this.groupBox_Tab1LicniPodaci.Controls.Add(this.label_PisiIme);
            this.groupBox_Tab1LicniPodaci.Controls.Add(this.label_Tab1Spol);
            this.groupBox_Tab1LicniPodaci.Controls.Add(this.label_Tab1Email);
            this.groupBox_Tab1LicniPodaci.Controls.Add(this.label_Tab1BracnoStanje);
            this.groupBox_Tab1LicniPodaci.Controls.Add(this.label_Tab1Adresa);
            this.groupBox_Tab1LicniPodaci.Controls.Add(this.label_Tab1MaticniBroj);
            this.groupBox_Tab1LicniPodaci.Controls.Add(this.label_Tab1DatumRodjenja);
            this.groupBox_Tab1LicniPodaci.Controls.Add(this.label_Tab1Prezime);
            this.groupBox_Tab1LicniPodaci.Controls.Add(this.label_Tab1Ime);
            this.groupBox_Tab1LicniPodaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_Tab1LicniPodaci.Location = new System.Drawing.Point(7, 7);
            this.groupBox_Tab1LicniPodaci.Name = "groupBox_Tab1LicniPodaci";
            this.groupBox_Tab1LicniPodaci.Size = new System.Drawing.Size(376, 528);
            this.groupBox_Tab1LicniPodaci.TabIndex = 16;
            this.groupBox_Tab1LicniPodaci.TabStop = false;
            this.groupBox_Tab1LicniPodaci.Text = "Lični podaci";
            this.groupBox_Tab1LicniPodaci.MouseHover += new System.EventHandler(this.groupBox_Tab1LicniPodaci_MouseHover);
            // 
            // label_PisiBrojRata
            // 
            this.label_PisiBrojRata.AutoSize = true;
            this.label_PisiBrojRata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_PisiBrojRata.Location = new System.Drawing.Point(195, 489);
            this.label_PisiBrojRata.Name = "label_PisiBrojRata";
            this.label_PisiBrojRata.Size = new System.Drawing.Size(0, 20);
            this.label_PisiBrojRata.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Broj preostalih rata";
            // 
            // label_PisiUkupanDug
            // 
            this.label_PisiUkupanDug.AutoSize = true;
            this.label_PisiUkupanDug.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_PisiUkupanDug.Location = new System.Drawing.Point(195, 446);
            this.label_PisiUkupanDug.Name = "label_PisiUkupanDug";
            this.label_PisiUkupanDug.Size = new System.Drawing.Size(0, 20);
            this.label_PisiUkupanDug.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Ukupan dug";
            // 
            // label_PisiBrojPosjeta
            // 
            this.label_PisiBrojPosjeta.AutoSize = true;
            this.label_PisiBrojPosjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_PisiBrojPosjeta.Location = new System.Drawing.Point(195, 402);
            this.label_PisiBrojPosjeta.Name = "label_PisiBrojPosjeta";
            this.label_PisiBrojPosjeta.Size = new System.Drawing.Size(0, 20);
            this.label_PisiBrojPosjeta.TabIndex = 26;
            // 
            // label_PisiSpol
            // 
            this.label_PisiSpol.AutoSize = true;
            this.label_PisiSpol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_PisiSpol.Location = new System.Drawing.Point(195, 357);
            this.label_PisiSpol.Name = "label_PisiSpol";
            this.label_PisiSpol.Size = new System.Drawing.Size(0, 20);
            this.label_PisiSpol.TabIndex = 25;
            // 
            // label_PisiMaticniBroj
            // 
            this.label_PisiMaticniBroj.AutoSize = true;
            this.label_PisiMaticniBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_PisiMaticniBroj.Location = new System.Drawing.Point(195, 175);
            this.label_PisiMaticniBroj.Name = "label_PisiMaticniBroj";
            this.label_PisiMaticniBroj.Size = new System.Drawing.Size(0, 20);
            this.label_PisiMaticniBroj.TabIndex = 24;
            // 
            // label_PisiAdresa
            // 
            this.label_PisiAdresa.AutoSize = true;
            this.label_PisiAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_PisiAdresa.Location = new System.Drawing.Point(195, 223);
            this.label_PisiAdresa.Name = "label_PisiAdresa";
            this.label_PisiAdresa.Size = new System.Drawing.Size(0, 20);
            this.label_PisiAdresa.TabIndex = 23;
            // 
            // label_PisiEmail
            // 
            this.label_PisiEmail.AutoSize = true;
            this.label_PisiEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_PisiEmail.Location = new System.Drawing.Point(195, 311);
            this.label_PisiEmail.Name = "label_PisiEmail";
            this.label_PisiEmail.Size = new System.Drawing.Size(0, 20);
            this.label_PisiEmail.TabIndex = 22;
            // 
            // label_PisiBracnoStanje
            // 
            this.label_PisiBracnoStanje.AutoSize = true;
            this.label_PisiBracnoStanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_PisiBracnoStanje.Location = new System.Drawing.Point(195, 266);
            this.label_PisiBracnoStanje.Name = "label_PisiBracnoStanje";
            this.label_PisiBracnoStanje.Size = new System.Drawing.Size(0, 20);
            this.label_PisiBracnoStanje.TabIndex = 21;
            // 
            // label_PisiPrezime
            // 
            this.label_PisiPrezime.AutoSize = true;
            this.label_PisiPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_PisiPrezime.Location = new System.Drawing.Point(195, 85);
            this.label_PisiPrezime.Name = "label_PisiPrezime";
            this.label_PisiPrezime.Size = new System.Drawing.Size(0, 20);
            this.label_PisiPrezime.TabIndex = 20;
            // 
            // label_PisiDatumRodjenja
            // 
            this.label_PisiDatumRodjenja.AutoSize = true;
            this.label_PisiDatumRodjenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_PisiDatumRodjenja.Location = new System.Drawing.Point(195, 128);
            this.label_PisiDatumRodjenja.Name = "label_PisiDatumRodjenja";
            this.label_PisiDatumRodjenja.Size = new System.Drawing.Size(0, 20);
            this.label_PisiDatumRodjenja.TabIndex = 19;
            // 
            // label_Tab1BrojPosjeta
            // 
            this.label_Tab1BrojPosjeta.AutoSize = true;
            this.label_Tab1BrojPosjeta.Location = new System.Drawing.Point(18, 402);
            this.label_Tab1BrojPosjeta.Name = "label_Tab1BrojPosjeta";
            this.label_Tab1BrojPosjeta.Size = new System.Drawing.Size(99, 20);
            this.label_Tab1BrojPosjeta.TabIndex = 18;
            this.label_Tab1BrojPosjeta.Text = "Broj posjeta";
            // 
            // label_PisiIme
            // 
            this.label_PisiIme.AutoSize = true;
            this.label_PisiIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_PisiIme.Location = new System.Drawing.Point(195, 40);
            this.label_PisiIme.Name = "label_PisiIme";
            this.label_PisiIme.Size = new System.Drawing.Size(0, 20);
            this.label_PisiIme.TabIndex = 17;
            // 
            // label_Tab1Spol
            // 
            this.label_Tab1Spol.AutoSize = true;
            this.label_Tab1Spol.Location = new System.Drawing.Point(18, 357);
            this.label_Tab1Spol.Name = "label_Tab1Spol";
            this.label_Tab1Spol.Size = new System.Drawing.Size(42, 20);
            this.label_Tab1Spol.TabIndex = 16;
            this.label_Tab1Spol.Text = "Spol";
            // 
            // label_Tab1Email
            // 
            this.label_Tab1Email.AutoSize = true;
            this.label_Tab1Email.Location = new System.Drawing.Point(18, 311);
            this.label_Tab1Email.Name = "label_Tab1Email";
            this.label_Tab1Email.Size = new System.Drawing.Size(113, 20);
            this.label_Tab1Email.TabIndex = 15;
            this.label_Tab1Email.Text = "E-mail adresa";
            // 
            // label_Tab1BracnoStanje
            // 
            this.label_Tab1BracnoStanje.AutoSize = true;
            this.label_Tab1BracnoStanje.Location = new System.Drawing.Point(18, 266);
            this.label_Tab1BracnoStanje.Name = "label_Tab1BracnoStanje";
            this.label_Tab1BracnoStanje.Size = new System.Drawing.Size(113, 20);
            this.label_Tab1BracnoStanje.TabIndex = 7;
            this.label_Tab1BracnoStanje.Text = "Bračno stanje";
            // 
            // label_Tab1Adresa
            // 
            this.label_Tab1Adresa.AutoSize = true;
            this.label_Tab1Adresa.Location = new System.Drawing.Point(18, 223);
            this.label_Tab1Adresa.Name = "label_Tab1Adresa";
            this.label_Tab1Adresa.Size = new System.Drawing.Size(62, 20);
            this.label_Tab1Adresa.TabIndex = 6;
            this.label_Tab1Adresa.Text = "Adresa";
            // 
            // label_Tab1MaticniBroj
            // 
            this.label_Tab1MaticniBroj.AutoSize = true;
            this.label_Tab1MaticniBroj.Location = new System.Drawing.Point(18, 175);
            this.label_Tab1MaticniBroj.Name = "label_Tab1MaticniBroj";
            this.label_Tab1MaticniBroj.Size = new System.Drawing.Size(96, 20);
            this.label_Tab1MaticniBroj.TabIndex = 5;
            this.label_Tab1MaticniBroj.Text = "Matični broj";
            // 
            // label_Tab1DatumRodjenja
            // 
            this.label_Tab1DatumRodjenja.AutoSize = true;
            this.label_Tab1DatumRodjenja.Location = new System.Drawing.Point(18, 128);
            this.label_Tab1DatumRodjenja.Name = "label_Tab1DatumRodjenja";
            this.label_Tab1DatumRodjenja.Size = new System.Drawing.Size(119, 20);
            this.label_Tab1DatumRodjenja.TabIndex = 4;
            this.label_Tab1DatumRodjenja.Text = "Datum rođenja";
            // 
            // label_Tab1Prezime
            // 
            this.label_Tab1Prezime.AutoSize = true;
            this.label_Tab1Prezime.Location = new System.Drawing.Point(18, 85);
            this.label_Tab1Prezime.Name = "label_Tab1Prezime";
            this.label_Tab1Prezime.Size = new System.Drawing.Size(71, 20);
            this.label_Tab1Prezime.TabIndex = 3;
            this.label_Tab1Prezime.Text = "Prezime";
            // 
            // label_Tab1Ime
            // 
            this.label_Tab1Ime.AutoSize = true;
            this.label_Tab1Ime.Location = new System.Drawing.Point(18, 40);
            this.label_Tab1Ime.Name = "label_Tab1Ime";
            this.label_Tab1Ime.Size = new System.Drawing.Size(36, 20);
            this.label_Tab1Ime.TabIndex = 2;
            this.label_Tab1Ime.Text = "Ime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(593, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Prijašnji pregledi";
            // 
            // listBox_KartonPregled
            // 
            this.listBox_KartonPregled.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBox_KartonPregled.FormattingEnabled = true;
            this.listBox_KartonPregled.ItemHeight = 20;
            this.listBox_KartonPregled.Location = new System.Drawing.Point(593, 47);
            this.listBox_KartonPregled.Name = "listBox_KartonPregled";
            this.listBox_KartonPregled.Size = new System.Drawing.Size(505, 284);
            this.listBox_KartonPregled.TabIndex = 14;
            this.listBox_KartonPregled.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_KartonPregled_MouseDoubleClick);
            this.listBox_KartonPregled.MouseHover += new System.EventHandler(this.listBox_KartonPregled_MouseHover);
            // 
            // slika1
            // 
            this.slika1.Date = new System.DateTime(((long)(0)));
            this.slika1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.slika1.Location = new System.Drawing.Point(389, 67);
            this.slika1.Name = "slika1";
            this.slika1.Pciture = null;
            this.slika1.Size = new System.Drawing.Size(268, 301);
            this.slika1.TabIndex = 17;
            // 
            // tabPage_ZauzetostOrdinacija
            // 
            this.tabPage_ZauzetostOrdinacija.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage_ZauzetostOrdinacija.ContextMenuStrip = this.contextMenuStrip1;
            this.tabPage_ZauzetostOrdinacija.Controls.Add(this.label5);
            this.tabPage_ZauzetostOrdinacija.Controls.Add(this.listBox_BrojNaCekanju);
            this.tabPage_ZauzetostOrdinacija.Controls.Add(this.listBox_Ordinacije);
            this.tabPage_ZauzetostOrdinacija.Location = new System.Drawing.Point(4, 29);
            this.tabPage_ZauzetostOrdinacija.Name = "tabPage_ZauzetostOrdinacija";
            this.tabPage_ZauzetostOrdinacija.Size = new System.Drawing.Size(1109, 542);
            this.tabPage_ZauzetostOrdinacija.TabIndex = 2;
            this.tabPage_ZauzetostOrdinacija.Text = "Zauzetost ordinacija";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Red čekanja u ordinacijama";
            // 
            // listBox_BrojNaCekanju
            // 
            this.listBox_BrojNaCekanju.FormattingEnabled = true;
            this.listBox_BrojNaCekanju.ItemHeight = 20;
            this.listBox_BrojNaCekanju.Location = new System.Drawing.Point(608, 110);
            this.listBox_BrojNaCekanju.Name = "listBox_BrojNaCekanju";
            this.listBox_BrojNaCekanju.Size = new System.Drawing.Size(56, 344);
            this.listBox_BrojNaCekanju.TabIndex = 1;
            // 
            // listBox_Ordinacije
            // 
            this.listBox_Ordinacije.FormattingEnabled = true;
            this.listBox_Ordinacije.ItemHeight = 20;
            this.listBox_Ordinacije.Location = new System.Drawing.Point(374, 110);
            this.listBox_Ordinacije.Name = "listBox_Ordinacije";
            this.listBox_Ordinacije.Size = new System.Drawing.Size(237, 344);
            this.listBox_Ordinacije.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelPacijent});
            this.statusStrip1.Location = new System.Drawing.Point(0, 589);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1124, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabelPacijent
            // 
            this.toolStripStatusLabelPacijent.Name = "toolStripStatusLabelPacijent";
            this.toolStripStatusLabelPacijent.Size = new System.Drawing.Size(0, 17);
            // 
            // button_Odjava
            // 
            this.button_Odjava.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Odjava.CausesValidation = false;
            this.button_Odjava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Odjava.Location = new System.Drawing.Point(1008, 3);
            this.button_Odjava.Name = "button_Odjava";
            this.button_Odjava.Size = new System.Drawing.Size(105, 37);
            this.button_Odjava.TabIndex = 0;
            this.button_Odjava.Text = "&Odjava";
            this.button_Odjava.UseVisualStyleBackColor = false;
            this.button_Odjava.Click += new System.EventHandler(this.button_Odjava_Click);
            // 
            // errorProvider_StaraLozinka
            // 
            this.errorProvider_StaraLozinka.ContainerControl = this;
            // 
            // errorProvider_NovaL
            // 
            this.errorProvider_NovaL.ContainerControl = this;
            // 
            // errorProvider_NovaP
            // 
            this.errorProvider_NovaP.ContainerControl = this;
            // 
            // PacijentovPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 611);
            this.Controls.Add(this.button_Odjava);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl_Pacijent);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "PacijentovPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacijent";
            this.Load += new System.EventHandler(this.PacijentovPanel_Load);
            this.tabControl_Pacijent.ResumeLayout(false);
            this.tabPage_Profil.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox_Dobrodosli.ResumeLayout(false);
            this.groupBox_Dobrodosli.PerformLayout();
            this.groupBox_PromjenaLozinke.ResumeLayout(false);
            this.groupBox_PromjenaLozinke.PerformLayout();
            this.tabPage_Karton.ResumeLayout(false);
            this.tabPage_Karton.PerformLayout();
            this.groupBox_Tab1LicniPodaci.ResumeLayout(false);
            this.groupBox_Tab1LicniPodaci.PerformLayout();
            this.tabPage_ZauzetostOrdinacija.ResumeLayout(false);
            this.tabPage_ZauzetostOrdinacija.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_StaraLozinka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_NovaL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_NovaP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Pacijent;
        private System.Windows.Forms.TabPage tabPage_Profil;
        private System.Windows.Forms.TabPage tabPage_Karton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPacijent;
        private System.Windows.Forms.Button button_Odjava;
        private System.Windows.Forms.Button button_PromijeniLozinku;
        private System.Windows.Forms.GroupBox groupBox_PromjenaLozinke;
        private System.Windows.Forms.Button buttonPromijeni;
        private System.Windows.Forms.TextBox textBox_NovaP;
        private System.Windows.Forms.TextBox textBox_Nova;
        private System.Windows.Forms.TextBox textBox_Stara;
        private System.Windows.Forms.TextBox textBox_Kime;
        private System.Windows.Forms.Label label_PonoviL;
        private System.Windows.Forms.Label label_NovaL;
        private System.Windows.Forms.Label label_StaraL;
        private System.Windows.Forms.Label label_Kime;
        private System.Windows.Forms.TabPage tabPage_ZauzetostOrdinacija;
        private System.Windows.Forms.GroupBox groupBox_Tab1LicniPodaci;
        private System.Windows.Forms.Label label_PisiBrojRata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_PisiUkupanDug;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_PisiBrojPosjeta;
        private System.Windows.Forms.Label label_PisiSpol;
        private System.Windows.Forms.Label label_PisiMaticniBroj;
        private System.Windows.Forms.Label label_PisiAdresa;
        private System.Windows.Forms.Label label_PisiEmail;
        private System.Windows.Forms.Label label_PisiBracnoStanje;
        private System.Windows.Forms.Label label_PisiPrezime;
        private System.Windows.Forms.Label label_PisiDatumRodjenja;
        private System.Windows.Forms.Label label_Tab1BrojPosjeta;
        private System.Windows.Forms.Label label_PisiIme;
        private System.Windows.Forms.Label label_Tab1Spol;
        private System.Windows.Forms.Label label_Tab1Email;
        private System.Windows.Forms.Label label_Tab1BracnoStanje;
        private System.Windows.Forms.Label label_Tab1Adresa;
        private System.Windows.Forms.Label label_Tab1MaticniBroj;
        private System.Windows.Forms.Label label_Tab1DatumRodjenja;
        private System.Windows.Forms.Label label_Tab1Prezime;
        private System.Windows.Forms.Label label_Tab1Ime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_KartonPregled;
        private Slika slika1;
        private System.Windows.Forms.GroupBox groupBox_Dobrodosli;
        private System.Windows.Forms.Label label_Dobrodosli;
        private System.Windows.Forms.Label label_Datum;
        private System.Windows.Forms.Label label_Uloga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox_BrojNaCekanju;
        private System.Windows.Forms.ListBox listBox_Ordinacije;
        private System.Windows.Forms.ErrorProvider errorProvider_StaraLozinka;
        private System.Windows.Forms.ErrorProvider errorProvider_NovaL;
        private System.Windows.Forms.ErrorProvider errorProvider_NovaP;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}