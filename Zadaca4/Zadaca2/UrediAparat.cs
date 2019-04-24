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
    public partial class UrediAparat : Form
    {
        public UrediAparat()
        {
            InitializeComponent();
        }

        private void UrediAparat_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Glavna.klinika17280_1.KlinickeOrdinacije.Count; i++)
            {
                comboBox_Ordinacija.Items.Add(Glavna.klinika17280_1.KlinickeOrdinacije[i].ImeOrdinacije);
            }
            comboBox_Ordinacija.SelectedIndex = 0;
            

            for (int i = 0; i < Glavna.klinika17280_1.KlinickiAparati.Count; i++)
            {
                comboBox_Aparati.Items.Add(Glavna.klinika17280_1.KlinickiAparati[i].ImeAparata);
            }
            comboBox_Aparati.SelectedIndex = 0;
            
        }

        private void comboBox_Aparati_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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

        private void button_Izmjeni_Click(object sender, EventArgs e)
        {
            try
            {
                Glavna.klinika17280_1.KlinickiAparati[comboBox_Aparati.SelectedIndex].ImeAparata = textBox_NazivAparata.Text;
                Glavna.klinika17280_1.KlinickiAparati[comboBox_Aparati.SelectedIndex].Aktivan = radioButton_Aktivna.Checked;
                Glavna.klinika17280_1.KlinickiAparati[comboBox_Aparati.SelectedIndex].OrdinacijaUKojojSeNalazi =
                    Glavna.klinika17280_1.KlinickeOrdinacije[comboBox_Ordinacija.SelectedIndex];
                toolStripStatusLabelUredjivanjeAparata.ForeColor = Color.Blue;
                toolStripStatusLabelUredjivanjeAparata.Text = "Uspješno ste izmjenili aparat";
            }
            catch(Exception ex)
            {
                Izuzetak iz = new Izuzetak(TipIzuzetka.Rad_sa_UI_kontrolama, DateTime.Now, Glavna.prijavljeni.KorisnickoIme, ex.Message);
                Glavna.DodajIzuzetak(iz);
                toolStripStatusLabelUredjivanjeAparata.ForeColor = Color.Red;
                toolStripStatusLabelUredjivanjeAparata.Text = ex.Message;
            }
        }

        private void button_Obrisi_Click(object sender, EventArgs e)
        {
            Glavna.klinika17280_1.KlinickiAparati.RemoveAt(comboBox_Aparati.SelectedIndex);
            comboBox_Aparati.Items.RemoveAt(comboBox_Aparati.SelectedIndex);
        }
    }
}
