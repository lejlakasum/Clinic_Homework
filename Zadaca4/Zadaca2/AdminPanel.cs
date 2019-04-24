using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Zadaca2
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            ActiveControl = button_Odjava;
            groupBox_PromjenaLozinke.Visible = false;
            button_Odjava.CausesValidation = false;
            
            label_Datum.Text = label_Datum.Text + DateTime.Today.ToShortDateString();
            label_Dobrodosli.Text = label_Dobrodosli.Text + Glavna.prijavljeni.Ime + " " + Glavna.prijavljeni.Prezime;
            label_Uloga.Text = label_Uloga.Text + Glavna.prijavljeni.Uloga;

            textBox_Kime.Text = Glavna.prijavljeni.KorisnickoIme;

            toolStripStatusAdmin.ForeColor = Color.Blue;
            toolStripStatusAdmin.Text = "Uspješno ste prijavljeni kao administrator";
        }

        

        private void label_NovaL_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Stara_Validating(object sender, CancelEventArgs e)
        {
            if(Osoba.Kodiraj(textBox_Stara.Text)!=Glavna.prijavljeni.Lozinka)
            {
                e.Cancel = true;
            }
            this.errorProvider_StaraLozinka.SetError(textBox_Stara, "Netačna stara lozinka");
        }

        private void textBox_Stara_Validated(object sender, EventArgs e)
        {
            if(Osoba.Kodiraj(textBox_Stara.Text) == Glavna.prijavljeni.Lozinka)
            {
                errorProvider_StaraLozinka.SetError(textBox_Stara, String.Empty);
            }
        }

        

        private void button_Odjava_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Jeste li sigurni da se želite odjaviti?", "Odjava", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                this.Hide();
                Prijava prijava = new Prijava();
                prijava.ShowDialog();
            }
            
        }

        private void button_PromijeniLozinku_Click(object sender, EventArgs e)
        {
            groupBox_PromjenaLozinke.Visible = true;
        }

        private void textBox_Nova_Validating(object sender, CancelEventArgs e)
        {
            if(textBox_Nova.Text.Length<7)
            {
                e.Cancel = true;

            }
            this.errorProvider_NovaL.SetError(textBox_Nova, "Lozinka mora imati minimalno 7 znakova");
        }

        private void textBox_Nova_Validated(object sender, EventArgs e)
        {
            if(textBox_Nova.Text.Length > 6)
            {
                errorProvider_NovaL.SetError(textBox_Nova, String.Empty);
            }
        }

        private void textBox_NovaP_Validating(object sender, CancelEventArgs e)
        {
            if(textBox_Nova.Text!=textBox_NovaP.Text)
            {
                
                e.Cancel = true;

            }
            errorProvider_NovaP.SetError(textBox_NovaP, "Lozinke se ne poklapaju");
        }

        private void textBox_NovaP_Validated(object sender, EventArgs e)
        {
            if(textBox_Nova.Text == textBox_NovaP.Text)
            {
                
                errorProvider_NovaP.SetError(textBox_NovaP, String.Empty);
            }
        }

        private void buttonPromijeni_Click(object sender, EventArgs e)
        {
            
            Glavna.prijavljeni.Lozinka = textBox_Nova.Text;
            
            
            toolStripStatusAdmin.Text = "Uspješno ste promijenili lozinku";
        }

        private void osobljeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajOsobu dodajOsobu = new DodajOsobu();
            dodajOsobu.ShowDialog();
        }

        private void ordinacijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajOrdinaciju dodajOrdinaciju = new DodajOrdinaciju();
            dodajOrdinaciju.ShowDialog();
        }

        private void aparatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajAparat dodajAparat = new DodajAparat();
            dodajAparat.ShowDialog();
        }

        private void pregledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajPregled dodajpregled = new DodajPregled();
            dodajpregled.ShowDialog();
        }

        private void osobljeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UrediOsobu urediOsobu = new UrediOsobu();
            urediOsobu.ShowDialog();
        }

        private void ordinacijuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UrediOrdinaciju urediOrdinaciju = new UrediOrdinaciju();
            urediOrdinaciju.ShowDialog();
        }

        private void pregledToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UrediPregled urediPregled = new UrediPregled();
            urediPregled.ShowDialog();
        }

        private void promijeniBojuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            DialogResult rez = cd.ShowDialog();
            if (rez == DialogResult.OK)
            {
                this.BackColor = cd.Color;
            }
        }

        private async void izvozPodatakaUDatotekuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog prozor = new SaveFileDialog();
            prozor.Filter = "txt files(*.txt) | *.txt";
            prozor.FileName = "";

            DialogResult d =  prozor.ShowDialog();
            if (d == DialogResult.OK)
            {
                if (Path.GetExtension(prozor.FileName).ToLower() == ".txt") {
                    FileStream fs = new FileStream(Path.GetFullPath(prozor.FileName), FileMode.Create);
                    IFormatter ser = new BinaryFormatter();
                    await Task.Run(() => ser.Serialize(fs, Glavna.klinika17280_1.RegistrovaneOsobe));
                    MessageBox.Show("Podaci su uspješno sačuvani", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fs.Close();
                }

            }
        }

        private void uvozPodatakaIzDatotekeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog prozor = new OpenFileDialog();
                prozor.Filter = "txt files(*.txt) | *.txt";

                DialogResult d = prozor.ShowDialog();
                if (d == DialogResult.OK)
                {
                    FileStream fs = new FileStream(Path.GetFullPath(prozor.FileName), FileMode.Open);
                    UcitavanjeOsoba o = new UcitavanjeOsoba(fs);
                    o.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                Izuzetak iz = new Izuzetak(TipIzuzetka.Rad_sa_datotekama, DateTime.Now, Glavna.prijavljeni.KorisnickoIme, ex.Message );
                Glavna.DodajIzuzetak(iz);  
                toolStripStatusAdmin.ForeColor = Color.Red;
                toolStripStatusAdmin.Text = ex.Message;
            }
        }

        private void loggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logovi log = new Logovi();
            log.ShowDialog();
        }
    }
}
