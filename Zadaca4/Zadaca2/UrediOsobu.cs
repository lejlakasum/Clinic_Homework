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
    public partial class UrediOsobu : Form
    {
        public UrediOsobu()
        {
            InitializeComponent();
        }

        private void UrediOsobu_Load(object sender, EventArgs e)
        {
            string[] uloge = { "Administrator", "Uprava", "Doktor", "Medicinsko osoblje", "Ostali korisnici" };
            comboBox_OdabirUloge.Items.AddRange(uloge);
            for (int i = 0; i < Glavna.klinika17280_1.KlinickeOrdinacije.Count; i++)
            {
                comboBox_Ordinacija.Items.Add(Glavna.klinika17280_1.KlinickeOrdinacije[i].ImeOrdinacije);
            }
            comboBoxUloga.Items.AddRange(uloge);
            comboBoxUloga.SelectedIndex = 0;
            string[] bracnaStanja = { "Zarucen_a", "Ozenjen_Udata", "Neozenjen_Neudata", "Razveden_a", "Udovac_ica" };
            comboBox_BracnoStanje.Items.AddRange(bracnaStanja);
            comboBox_BracnoStanje.SelectedIndex = 2;
            radioButton_Musko.Checked = true;

        }

        private void comboBox_OdabirUloge_SelectedIndexChanged(object sender, EventArgs e)
        {


            int i = comboBox_OdabirUloge.SelectedIndex;

            switch (i)
            {
                case 0:
                    listBox_Osoblje.Items.Clear();
                    listBoxMaticniBroj.Items.Clear();
                    for (int j = 0; j < Glavna.klinika17280_1.RegistrovaneOsobe.Count; j++)
                    {
                        if (Glavna.klinika17280_1.RegistrovaneOsobe[j].Uloga == Uloga.Administrator)
                        {
                            string ime = Glavna.klinika17280_1.RegistrovaneOsobe[j].Ime;
                            ime += " " + Glavna.klinika17280_1.RegistrovaneOsobe[j].Prezime;
                            listBox_Osoblje.Items.Add(ime);
                            listBoxMaticniBroj.Items.Add(Glavna.klinika17280_1.RegistrovaneOsobe[j].MaticniBroj);
                        }
                    }
                    break;
                case 1:
                    listBoxMaticniBroj.Items.Clear();
                    listBox_Osoblje.Items.Clear();
                    for (int j = 0; j < Glavna.klinika17280_1.RegistrovaneOsobe.Count; j++)
                    {
                        if (Glavna.klinika17280_1.RegistrovaneOsobe[j].Uloga == Uloga.Uprava)
                        {
                            string ime = Glavna.klinika17280_1.RegistrovaneOsobe[j].Ime;
                            ime += " " + Glavna.klinika17280_1.RegistrovaneOsobe[j].Prezime;
                            listBox_Osoblje.Items.Add(ime);
                            listBoxMaticniBroj.Items.Add(Glavna.klinika17280_1.RegistrovaneOsobe[j].MaticniBroj);
                        }
                    }
                    break;
                case 2:
                    listBoxMaticniBroj.Items.Clear();
                    listBox_Osoblje.Items.Clear();
                    for (int j = 0; j < Glavna.klinika17280_1.RegistrovaneOsobe.Count; j++)
                    {
                        if (Glavna.klinika17280_1.RegistrovaneOsobe[j].Uloga == Uloga.Doktor)
                        {
                            string ime = Glavna.klinika17280_1.RegistrovaneOsobe[j].Ime;
                            ime += " " + Glavna.klinika17280_1.RegistrovaneOsobe[j].Prezime;
                            listBox_Osoblje.Items.Add(ime);
                            listBoxMaticniBroj.Items.Add(Glavna.klinika17280_1.RegistrovaneOsobe[j].MaticniBroj);
                        }
                    }
                    break;
                case 3:
                    listBoxMaticniBroj.Items.Clear();
                    listBox_Osoblje.Items.Clear();
                    for (int j = 0; j < Glavna.klinika17280_1.RegistrovaneOsobe.Count; j++)
                    {
                        if (Glavna.klinika17280_1.RegistrovaneOsobe[j].Uloga == Uloga.Medicinsko_osoblje)
                        {
                            string ime = Glavna.klinika17280_1.RegistrovaneOsobe[j].Ime;
                            ime += " " + Glavna.klinika17280_1.RegistrovaneOsobe[j].Prezime;
                            listBox_Osoblje.Items.Add(ime);
                            listBoxMaticniBroj.Items.Add(Glavna.klinika17280_1.RegistrovaneOsobe[j].MaticniBroj);
                        }
                    }
                    break;
                case 4:
                    listBoxMaticniBroj.Items.Clear();
                    listBox_Osoblje.Items.Clear();
                    for (int j = 0; j < Glavna.klinika17280_1.RegistrovaneOsobe.Count; j++)
                    {
                        if (Glavna.klinika17280_1.RegistrovaneOsobe[j].Uloga == Uloga.Ostali_Korisnici)
                        {
                            string ime = Glavna.klinika17280_1.RegistrovaneOsobe[j].Ime;
                            ime += " " + Glavna.klinika17280_1.RegistrovaneOsobe[j].Prezime;
                            listBox_Osoblje.Items.Add(ime);
                            listBoxMaticniBroj.Items.Add(Glavna.klinika17280_1.RegistrovaneOsobe[j].MaticniBroj);
                        }
                    }
                    break;
            }

        }

        private void listBox_Osoblje_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxMaticniBroj.SelectedIndex = listBox_Osoblje.SelectedIndex;

        }

        private void button_Obrisi_Click(object sender, EventArgs e)
        {
            if (listBox_Osoblje.SelectedIndex < 0)
            {
                MessageBox.Show("Nije odabrana niti jedna osoba", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < Glavna.klinika17280_1.RegistrovaneOsobe.Count; i++)
                {
                    if (Glavna.klinika17280_1.RegistrovaneOsobe[i].MaticniBroj == listBoxMaticniBroj.SelectedItem.ToString())
                    {
                        Glavna.klinika17280_1.RegistrovaneOsobe.RemoveAt(i);
                        toolStripStatusLabelUredjivanjeOsobe.ForeColor = Color.Blue;
                        toolStripStatusLabelUredjivanjeOsobe.Text = "Uspješno ste obrisali osobu";
                        listBoxMaticniBroj.Items.RemoveAt(listBoxMaticniBroj.SelectedIndex);
                        listBox_Osoblje.Items.RemoveAt(listBox_Osoblje.SelectedIndex);
                        break;

                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox_Izmjena.Visible = true;
            this.ActiveControl = button_Zavrsi;

            Osoba o = new Osoba();
            int indeks=0;
            for (int i = 0; i < Glavna.klinika17280_1.RegistrovaneOsobe.Count; i++)
            {
                if (Glavna.klinika17280_1.RegistrovaneOsobe[i].MaticniBroj == listBoxMaticniBroj.SelectedItem.ToString())
                {
                    o = Glavna.klinika17280_1.RegistrovaneOsobe[i];
                    indeks = i;
                    break;
                }
            }
            comboBoxUloga.SelectedIndex = comboBox_OdabirUloge.SelectedIndex;
           
            textBox_Ime.Text = o.Ime; textBox_Prezime.Text = o.Prezime;
            dateTimePicker1.Value = o.DatumRodjenja;
            textBox_MaticniBroj.Text = o.MaticniBroj;
            textBox_Adresa.Text = o.Adresa;
            textBox_Email.Text = o.Email;
            string stanje = o.BracnoStanje.ToString();
            for(int i=0; i<comboBox_BracnoStanje.Items.Count; i++)
            {
                comboBox_BracnoStanje.SelectedIndex = i;
                if (stanje == comboBox_BracnoStanje.SelectedItem.ToString()) break;
            }
            if (o.Spol == Spol.Zensko)
            {
                radioButton_Musko.Checked = false;
                radioButton_Zensko.Checked = true;
            }
            else radioButton_Musko.Checked = true;
            if(o.Uloga!=Uloga.Doktor && o.Uloga!=Uloga.Administrator)
            {
                Uposlenik u =  Glavna.klinika17280_1.RegistrovaneOsobe[indeks] as Uposlenik;
                groupBox_OstaleInfo.Show();
                label_Ordinacija.Visible = false;
                comboBox_Ordinacija.Visible = false;
                comboBox_NazivPozicije.Text = u.NazivPozicije;
                numericUpDown_Plata.Value = (decimal)u.PlataUposlenika;
            }
            else if(o.Uloga==Uloga.Doktor)
            {
                Doktor u = Glavna.klinika17280_1.RegistrovaneOsobe[indeks] as Doktor;
                groupBox_OstaleInfo.Show();
                label_Ordinacija.Visible = true;
                comboBox_Ordinacija.Visible = true;
                comboBox_NazivPozicije.Text = u.NazivPozicije;
                numericUpDown_Plata.Value = (decimal)u.PlataUposlenika;
                string ordinacija=u.OrdinacijaUKojojRadi.ImeOrdinacije;
                for (int i = 0; i < comboBox_Ordinacija.Items.Count; i++)
                {
                    comboBox_Ordinacija.SelectedIndex = i;
                    if (ordinacija == comboBox_Ordinacija.SelectedItem.ToString()) break;
                }
            }

        }

        private void button_Zatvori_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Jeste li sigurni da želite zatvoriti?\nUneseni podaci neće biti spašeni",
               "Zatvori", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button_Zavrsi_Click(object sender, EventArgs e)
        {
            try
            {
                int indeks = 0;
                for (int k = 0; k < Glavna.klinika17280_1.RegistrovaneOsobe.Count; k++)
                {
                    if (Glavna.klinika17280_1.RegistrovaneOsobe[k].MaticniBroj == listBoxMaticniBroj.SelectedItem.ToString())
                    {
                        indeks = k;
                        break;
                    }
                }
                Spol spol = Spol.Musko;
                if (radioButton_Musko.Checked == false) spol = Spol.Zensko;
                int i = comboBoxUloga.SelectedIndex;
                Uloga uloga = Uloga.Administrator;
                switch (i)
                {
                    case 1: uloga = Uloga.Uprava; break;
                    case 2: uloga = Uloga.Doktor; break;
                    case 3: uloga = Uloga.Medicinsko_osoblje; break;
                    case 4: uloga = Uloga.Ostali_Korisnici; break;
                }
                i = comboBox_BracnoStanje.SelectedIndex;
                BracnoStanje stanje = BracnoStanje.Zarucen_a;
                switch (i)
                {
                    case 1: stanje = BracnoStanje.Ozenjen_Udata; break;
                    case 2: stanje = BracnoStanje.Neozenjen_Neudata; break;
                    case 3: stanje = BracnoStanje.Razveden_a; break;
                    case 4: stanje = BracnoStanje.Udovac_ica; break;

                }

                if (comboBoxUloga.SelectedIndex == 0)
                {
                    Glavna.klinika17280_1.RegistrovaneOsobe[indeks]=(new Osoba(textBox_Ime.Text, textBox_Prezime.Text, dateTimePicker1.Value
                        , textBox_MaticniBroj.Text, textBox_Adresa.Text, spol, stanje, textBox_Email.Text, uloga));
                }
                else if (comboBoxUloga.SelectedIndex == 2)
                {
                    for (int j = 0; j < Glavna.klinika17280_1.KlinickeOrdinacije.Count(); j++)
                    {
                        Ordinacija o = new Ordinacija();
                        if (comboBox_Ordinacija.SelectedItem.ToString() == Glavna.klinika17280_1.KlinickeOrdinacije[i].ImeOrdinacije)
                        {
                            o = Glavna.klinika17280_1.KlinickeOrdinacije[i];
                            break;
                        }
                        Glavna.klinika17280_1.RegistrovaneOsobe[indeks]=(new Doktor(textBox_Ime.Text, textBox_Prezime.Text, textBox_Adresa.Text, dateTimePicker1.Value
                        , textBox_MaticniBroj.Text, spol, stanje, textBox_Email.Text, uloga, comboBox_NazivPozicije.SelectedItem.ToString(), (double)numericUpDown_Plata.Value, o, 0));
                    }
                }
                else
                {
                    Glavna.klinika17280_1.RegistrovaneOsobe[indeks]=(new Uposlenik(textBox_Ime.Text, textBox_Prezime.Text, textBox_Adresa.Text, dateTimePicker1.Value
                                        , textBox_MaticniBroj.Text, spol, stanje, textBox_Email.Text, uloga, comboBox_NazivPozicije.SelectedItem.ToString(), (double)numericUpDown_Plata.Value));
                }
                toolStripStatusLabelUredjivanjeOsobe.ForeColor = Color.Blue;
                toolStripStatusLabelUredjivanjeOsobe.Text = "Uspješno ste izmjenili informacije o osobi";

                textBox_Adresa.Clear();
                textBox_Email.Clear();
                textBox_Ime.Clear();
                textBox_MaticniBroj.Clear();
                textBox_Prezime.Clear();
               
            }
            catch(Exception ex)
            {
                Izuzetak iz = new Izuzetak(TipIzuzetka.Rad_sa_UI_kontrolama, DateTime.Now, Glavna.prijavljeni.KorisnickoIme, ex.Message);
                Glavna.DodajIzuzetak(iz);
                toolStripStatusLabelUredjivanjeOsobe.ForeColor = Color.Red;
                toolStripStatusLabelUredjivanjeOsobe.Text = ex.Message;
            }
        }
    }
}
