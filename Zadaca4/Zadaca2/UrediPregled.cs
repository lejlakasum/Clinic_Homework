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
    public partial class UrediPregled : Form
    {
        public UrediPregled()
        {
            InitializeComponent();
        }

        private void UrediPregled_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Glavna.klinika17280_1.KlinickeOrdinacije.Count; i++)
            {
                comboBox_Ordinacija.Items.Add(Glavna.klinika17280_1.KlinickeOrdinacije[i].ImeOrdinacije);
            }
            comboBox_Ordinacija.SelectedIndex = 0;

            for (int i = 0; i < Glavna.klinika17280_1.DostupniPregledi.Count; i++)
            {
                comboBox_Pregledi.Items.Add(Glavna.klinika17280_1.DostupniPregledi[i].ImePregleda);
            }
            comboBox_Pregledi.SelectedIndex = 0;
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

        private void button_Dodaj_Click(object sender, EventArgs e)
        {
            try
            {
                Glavna.klinika17280_1.DostupniPregledi[comboBox_Pregledi.SelectedIndex].ImePregleda = textBox_NazivPregleda.Text;
                Glavna.klinika17280_1.DostupniPregledi[comboBox_Pregledi.SelectedIndex].CijenaPregleda = (double)numericUpDown_Cijena.Value;
                Glavna.klinika17280_1.KlinickiAparati[comboBox_Pregledi.SelectedIndex].OrdinacijaUKojojSeNalazi =
                    Glavna.klinika17280_1.KlinickeOrdinacije[comboBox_Ordinacija.SelectedIndex];
                toolStripStatusLabelUredjivanjePregleda.ForeColor = Color.Blue;
                toolStripStatusLabelUredjivanjePregleda.Text = "Uspješno ste izmjenili pregled";
            }
            catch(Exception ex)
            {
                Izuzetak iz = new Izuzetak(TipIzuzetka.Rad_sa_UI_kontrolama, DateTime.Now, Glavna.prijavljeni.KorisnickoIme, ex.Message);
                Glavna.DodajIzuzetak(iz);
                toolStripStatusLabelUredjivanjePregleda.ForeColor = Color.Red;
                toolStripStatusLabelUredjivanjePregleda.Text = ex.Message;
            }
        }

        private void comboBox_Pregledi_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_NazivPregleda.Text = Glavna.klinika17280_1.DostupniPregledi[comboBox_Pregledi.SelectedIndex].ImePregleda;
            numericUpDown_Cijena.Value = (decimal)Glavna.klinika17280_1.DostupniPregledi[comboBox_Pregledi.SelectedIndex].CijenaPregleda;
        }

        private void button_Obrisi_Click(object sender, EventArgs e)
        {
            Glavna.klinika17280_1.DostupniPregledi.RemoveAt(comboBox_Pregledi.SelectedIndex);
            comboBox_Pregledi.Items.RemoveAt(comboBox_Pregledi.SelectedIndex);
        }
    }
}
