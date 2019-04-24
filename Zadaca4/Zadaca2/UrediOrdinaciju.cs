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
    public partial class UrediOrdinaciju : Form
    {
        public UrediOrdinaciju()
        {
            InitializeComponent();
        }

        private void UrediOrdinaciju_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Glavna.klinika17280_1.KlinickeOrdinacije.Count; i++)
            {
                comboBox_Ordinacija.Items.Add(Glavna.klinika17280_1.KlinickeOrdinacije[i].ImeOrdinacije);
            }
            comboBox_Ordinacija.SelectedIndex = 0;
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
                
                for (int i = 0; i < Glavna.klinika17280_1.KlinickeOrdinacije.Count; i++)
                {
                    if (Glavna.klinika17280_1.KlinickeOrdinacije[i].ImeOrdinacije==comboBox_Ordinacija.SelectedItem.ToString())
                    {
                        Glavna.klinika17280_1.KlinickeOrdinacije[i].ImeOrdinacije = textBox_NazivOrdinacije.Text;
                        Glavna.klinika17280_1.KlinickeOrdinacije[i].Aktivna = radioButton_Aktivna.Checked;
                        break;
                    }
                }
                toolStripStatusLabelUredjivanjeOrdinacije.ForeColor = Color.Blue;
                toolStripStatusLabelUredjivanjeOrdinacije.Text = "Uspješno ste izmjenili ordinaciju";

                textBox_NazivOrdinacije.Clear();
            }
            catch(Exception ex)
            {
                Izuzetak iz = new Izuzetak(TipIzuzetka.Rad_sa_UI_kontrolama, DateTime.Now, Glavna.prijavljeni.KorisnickoIme, ex.Message);
                Glavna.DodajIzuzetak(iz);
                toolStripStatusLabelUredjivanjeOrdinacije.ForeColor = Color.Red;
                toolStripStatusLabelUredjivanjeOrdinacije.Text = ex.Message;
            }
        }
        
        private void button_Obrisi_Click(object sender, EventArgs e)
        {
            Glavna.klinika17280_1.KlinickeOrdinacije.RemoveAt(comboBox_Ordinacija.SelectedIndex);
            comboBox_Ordinacija.Items.RemoveAt(comboBox_Ordinacija.SelectedIndex);
        }
    }
}
