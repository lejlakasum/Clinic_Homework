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
    public partial class DodajPregled : Form
    {
        public DodajPregled()
        {
            InitializeComponent();
        }

        private void DodajPregled_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Glavna.klinika17280_1.KlinickeOrdinacije.Count; i++)
            {
                comboBox_Ordinacija.Items.Add(Glavna.klinika17280_1.KlinickeOrdinacije[i].ImeOrdinacije);
            }
            comboBox_Ordinacija.SelectedIndex = 0;
        }

        private void textBox_NazivPregleda_Validating(object sender, CancelEventArgs e)
        {
            if(String.IsNullOrWhiteSpace(textBox_NazivPregleda.Text))
            {
                e.Cancel = true;
            }
            errorProvider_NazivPregleda.SetError(textBox_NazivPregleda, "Polje ne smije biti prazno");
        }

        private void textBox_NazivPregleda_Validated(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBox_NazivPregleda.Text))
            {
                errorProvider_NazivPregleda.SetError(textBox_NazivPregleda, String.Empty);
            }
            else
            {
                errorProvider_NazivPregleda.SetError(textBox_NazivPregleda, "Polje ne smije biti prazno");
            }
        }

        private void button_Zatvori_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Jeste li sigurni da želite zatvoriti?\nUneseni podaci neće biti spašeni",
                "Zatvori", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void button_Dodaj_Click(object sender, EventArgs e)
        {
            Ordinacija o = new Ordinacija();
            for (int i = 0; i < Glavna.klinika17280_1.KlinickeOrdinacije.Count; i++)
            {
                if (comboBox_Ordinacija.SelectedItem.ToString() == Glavna.klinika17280_1.KlinickeOrdinacije[i].ImeOrdinacije)
                {
                    o = Glavna.klinika17280_1.KlinickeOrdinacije[i];
                    break;
                }
            }
            Glavna.klinika17280_1.DostupniPregledi.Add(new Pregled(textBox_NazivPregleda.Text, (double)numericUpDown_Cijena.Value, o));

            toolStripStatusLabelDodajPregled.ForeColor = Color.Blue;
            toolStripStatusLabelDodajPregled.Text = "Uspješno ste dodali novi pregled";
            textBox_NazivPregleda.Clear();
            numericUpDown_Cijena.Value = 0;
        }
    }
}
