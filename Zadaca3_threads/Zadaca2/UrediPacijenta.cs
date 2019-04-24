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
    public partial class UrediPacijenta : Form
    {
        public Pacijent pacijent17280;
        public UrediPacijenta()
        {
            InitializeComponent();
        }

        public UrediPacijenta(Pacijent pac)
        {
            InitializeComponent();
            pacijent17280 = pac;
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

        private void UrediPacijenta_Load(object sender, EventArgs e)
        {
            
            textBox_Ime.Text = pacijent17280.Ime;
            textBox_Prezime.Text = pacijent17280.Prezime;
            dateTimePicker1.Value = pacijent17280.DatumRodjenja;
            textBox_MaticniBroj.Text = pacijent17280.MaticniBroj;
            textBox_Adresa.Text = pacijent17280.Adresa;
            textBox_Email.Text = pacijent17280.Email;
            if (pacijent17280.Spol == Spol.Musko) radioButton_Musko.Checked = true;
            else
            {
                radioButton_Zensko.Checked = true;
            }
            string[] bracnaStanja = { "Zarucen_a", "Ozenjen_Udata", "Neozenjen_Neudata", "Razveden_a", "Udovac_ica" };
            comboBox_BracnoStanje.Items.AddRange(bracnaStanja);
            int i = 0;
            string stanje = pacijent17280.BracnoStanje.ToString();
            foreach(string s in bracnaStanja)
            {
                if(stanje==s)
                {
                    comboBox_BracnoStanje.SelectedIndex = i;
                    break;
                }
                i++;
            }
        }

        private void button_IzmjeniPacijenta_Click(object sender, EventArgs e)
        {
            try
            {
                Spol spol = Spol.Zensko;
                if (radioButton_Musko.Checked == true) spol = Spol.Musko;
                int i = comboBox_BracnoStanje.SelectedIndex;
                BracnoStanje stanje = BracnoStanje.Zarucen_a;
                switch (i)
                {
                    case 1: stanje = BracnoStanje.Ozenjen_Udata; break;
                    case 2: stanje = BracnoStanje.Neozenjen_Neudata; break;
                    case 3: stanje = BracnoStanje.Razveden_a; break;
                    case 4: stanje = BracnoStanje.Udovac_ica; break;
                }
               int indeksOsobe=Glavna.klinika17280_1.RegistrovaneOsobe.FindIndex(o => o.MaticniBroj == pacijent17280.MaticniBroj);
                Glavna.klinika17280_1.RegistrovaneOsobe[indeksOsobe] = 
                    new Pacijent(textBox_Ime.Text, textBox_Prezime.Text, dateTimePicker1.Value, textBox_MaticniBroj.Text,
                    textBox_Adresa.Text, spol, stanje, textBox_Email.Text);
                toolStripStatusLabelIzmjeniPacijenta.ForeColor = Color.Blue;
                toolStripStatusLabelIzmjeniPacijenta.Text = "Uspješno ste izmjenili podatke o pacijentu";
            }
            catch (Exception ex)
            {
                Izuzetak iz = new Izuzetak(TipIzuzetka.Rad_sa_UI_kontrolama, DateTime.Now, Glavna.prijavljeni.KorisnickoIme, ex.Message);
                Glavna.DodajIzuzetak(iz);
                toolStripStatusLabelIzmjeniPacijenta.ForeColor = Color.Red;
                toolStripStatusLabelIzmjeniPacijenta.Text = ex.Message;
            }
        }
    }
}
