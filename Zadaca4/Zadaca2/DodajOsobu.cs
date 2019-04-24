using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Zadaca2
{
    public partial class DodajOsobu : Form
    {
        public DodajOsobu()
        {
            InitializeComponent();
        }

        private void DodajOsobu_Load(object sender, EventArgs e)
        {
            for(int i=0; i<Glavna.klinika17280_1.KlinickeOrdinacije.Count; i++)
            {
                comboBox_Ordinacija.Items.Add(Glavna.klinika17280_1.KlinickeOrdinacije[i].ImeOrdinacije);
            }
            string[] uloge = { "Administrator", "Uprava", "Doktor", "Medicinsko osoblje", "Ostali korisnici" };
            comboBox_Uloga.Items.AddRange(uloge);
            comboBox_Uloga.SelectedIndex = 0;
            string[] bracnaStanja = { "Zarucen_a", "Ozenjen_Udata", "Neozenjen_Neudata", "Razveden_a", "Udovac_ica" };
            comboBox_BracnoStanje.Items.AddRange(bracnaStanja);
            comboBox_BracnoStanje.SelectedIndex = 2;
            radioButton_Musko.Checked = true;
            
        }

        private void textBox_MaticniBroj_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Osoba fiktivna = new Osoba();
                fiktivna.MaticniBroj = textBox_MaticniBroj.Text;
            }
            catch (Exception izuzetak)
            {
                Izuzetak iz = new Izuzetak(TipIzuzetka.Rad_sa_UI_kontrolama, DateTime.Now, Glavna.prijavljeni.KorisnickoIme, izuzetak.Message);
                Glavna.DodajIzuzetak(iz);
                e.Cancel = true;
                errorProvider_MaticniBroj.SetError(textBox_MaticniBroj, izuzetak.Message);
            }
            
        }

        private void textBox_MaticniBroj_Validated(object sender, EventArgs e)
        {
            try
            {
                Osoba fiktivna = new Osoba();
                fiktivna.MaticniBroj = textBox_MaticniBroj.Text;
            }
            catch (Exception izuzetak)
            {
                Izuzetak iz = new Izuzetak(TipIzuzetka.Rad_sa_UI_kontrolama, DateTime.Now, Glavna.prijavljeni.KorisnickoIme, izuzetak.Message);
                Glavna.DodajIzuzetak(iz);
                errorProvider_MaticniBroj.SetError(textBox_MaticniBroj, izuzetak.Message);
            }
            errorProvider_MaticniBroj.SetError(textBox_MaticniBroj, String.Empty);
        }

        private void textBox_Email_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Osoba fiktivna = new Osoba();
                fiktivna.Email = textBox_Email.Text;
            }
            catch (Exception ex)
            {
                Izuzetak iz = new Izuzetak(TipIzuzetka.Rad_sa_UI_kontrolama, DateTime.Now, Glavna.prijavljeni.KorisnickoIme, ex.Message);
                Glavna.DodajIzuzetak(iz);
                e.Cancel = true;
                errorProvider_Email.SetError(textBox_Email, ex.Message);
            }
        }

        private void textBox_Email_Validated(object sender, EventArgs e)
        {
            try
            {
                Osoba fiktivna = new Osoba();
                fiktivna.Email = textBox_Email.Text;
            }
            catch (Exception ex)
            {
                Izuzetak iz = new Izuzetak(TipIzuzetka.Rad_sa_UI_kontrolama, DateTime.Now, Glavna.prijavljeni.KorisnickoIme, ex.Message);
                Glavna.DodajIzuzetak(iz);
                errorProvider_Email.SetError(textBox_Email, ex.Message);
            }
            errorProvider_Email.SetError(textBox_Email, String.Empty);
        }

        private void comboBox_Uloga_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_Uloga.SelectedIndex==0)
            {
                groupBox_OstaleInfo.Visible = false;
            }
            if (comboBox_Uloga.SelectedIndex == 2)
            {
                groupBox_OstaleInfo.Visible = true;
                label_Ordinacija.Visible = true; comboBox_Ordinacija.Visible = true;
            }
            else if (comboBox_Uloga.SelectedIndex == 1 || comboBox_Uloga.SelectedIndex == 3 || comboBox_Uloga.SelectedIndex == 4)
            {
                label_Ordinacija.Visible = false; comboBox_Ordinacija.Visible = false;
                groupBox_OstaleInfo.Visible = true;
            }
        }

        private void textBox_Ime_Validating(object sender, CancelEventArgs e)
        {
            if(String.IsNullOrWhiteSpace(textBox_Ime.Text))
                {
                e.Cancel = true;
            }
            errorProvider_Ime.SetError(textBox_Ime, "Polje ne smije biti prazno");
        }

        private void textBox_Prezime_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox_Prezime.Text))
            {
                e.Cancel = true;
            }
            errorProvider_Prezime.SetError(textBox_Prezime, "Polje ne smije biti prazno");
        }

        private void textBox_Adresa_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox_Adresa.Text))
            {
                e.Cancel = true;
            }
            errorProviderAdresa.SetError(textBox_Adresa, "Polje ne smije biti prazno");
        }

        private void textBox_Ime_Validated(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBox_Ime.Text))
            {
                errorProvider_Ime.SetError(textBox_Ime, String.Empty);
            }
            
            
        }

        private void textBox_Prezime_Validated(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBox_Prezime.Text))
            {
                errorProvider_Prezime.SetError(textBox_Prezime, String.Empty);
            }
        }

        private void textBox_Adresa_Validated(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBox_Adresa.Text))
            {
                errorProviderAdresa.SetError(textBox_Adresa, String.Empty);
            }
        }

        private void button_Zatvori_Click(object sender, EventArgs e)
        {
           DialogResult d = MessageBox.Show("Jeste li sigurni da želite zatvoriti?\nUneseni podaci neće biti spašeni",
                "Zatvori", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(d==DialogResult.Yes)
            {
                this.Hide();
                
            }
        }

        private void button_Dodaj_Click(object sender, EventArgs e)
        {
            Spol spol = Spol.Musko;
            if (radioButton_Musko.Checked == false) spol = Spol.Zensko;
            int i = comboBox_Uloga.SelectedIndex;
            Uloga uloga = Uloga.Administrator;
            switch(i) {
                case 1 : uloga = Uloga.Uprava; break;
                case 2 : uloga = Uloga.Doktor; break;
                case 3 : uloga = Uloga.Medicinsko_osoblje; break;
                case 4 : uloga = Uloga.Ostali_Korisnici; break;
            }
            i = comboBox_BracnoStanje.SelectedIndex;
            BracnoStanje stanje = BracnoStanje.Zarucen_a;
            switch(i)
            {
                case 1: stanje = BracnoStanje.Ozenjen_Udata; break;
                case 2: stanje = BracnoStanje.Neozenjen_Neudata; break;
                case 3: stanje = BracnoStanje.Razveden_a; break;
                case 4: stanje = BracnoStanje.Udovac_ica; break;

            }

            if(comboBox_Uloga.SelectedIndex==0)
            {
                Glavna.klinika17280_1.RegistrovaneOsobe.Add(new Osoba(textBox_Ime.Text, textBox_Prezime.Text, dateTimePicker1.Value
                    , textBox_MaticniBroj.Text, textBox_Adresa.Text, spol, stanje, textBox_Email.Text, uloga));
            }
            else if(comboBox_Uloga.SelectedIndex==2)
            {
                for(int j=0; j<Glavna.klinika17280_1.KlinickeOrdinacije.Count(); j++)
                {
                    Ordinacija o=new Ordinacija();
                    if(comboBox_Ordinacija.SelectedItem.ToString()==Glavna.klinika17280_1.KlinickeOrdinacije[i].ImeOrdinacije)
                    {
                        o = Glavna.klinika17280_1.KlinickeOrdinacije[i];
                        break;
                    }
                    Glavna.klinika17280_1.RegistrovaneOsobe.Add(new Doktor(textBox_Ime.Text, textBox_Prezime.Text, textBox_Adresa.Text, dateTimePicker1.Value
                    , textBox_MaticniBroj.Text, spol, stanje, textBox_Email.Text, uloga, comboBox_NazivPozicije.SelectedItem.ToString(),  (double)numericUpDown_Plata.Value, o, 0));
                }
            }
            else
            {
                Glavna.klinika17280_1.RegistrovaneOsobe.Add(new Uposlenik(textBox_Ime.Text, textBox_Prezime.Text, textBox_Adresa.Text, dateTimePicker1.Value
                                    , textBox_MaticniBroj.Text, spol, stanje, textBox_Email.Text, uloga, comboBox_NazivPozicije.SelectedItem.ToString(), (double)numericUpDown_Plata.Value));
            }
            toolStripStatusDodavanjeOsobe.ForeColor = Color.Blue;
            toolStripStatusDodavanjeOsobe.Text = "Uspješno ste dodali novu osobu";

            textBox_Adresa.Clear();
            textBox_Email.Clear();
            textBox_Ime.Clear();
            textBox_MaticniBroj.Clear();
            textBox_Prezime.Clear();
            
        }
    }
}
