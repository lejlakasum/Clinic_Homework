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
    public partial class DodajAparat : Form
    {
        public DodajAparat()
        {
            InitializeComponent();
        }

        private void groupBox_Aktivnost_MouseHover(object sender, EventArgs e)
        {
            toolTip_Aktivan.Show("Označava pokvaren aparat ili aparat\nkoji je isključen", groupBox_Aktivnost);
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

        private void DodajAparat_Load(object sender, EventArgs e)
        {
            
            for(int i=0; i<Glavna.klinika17280_1.KlinickeOrdinacije.Count; i++)
            {
                comboBox_Ordinacija.Items.Add(Glavna.klinika17280_1.KlinickeOrdinacije[i].ImeOrdinacije);
            }
            comboBox_Ordinacija.SelectedIndex = 0;
        }

        private void textBox_NazivOrdinacije_Validating(object sender, CancelEventArgs e)
        {
            if(String.IsNullOrEmpty(textBox_NazivOrdinacije.Text))
            {
                e.Cancel = true;
            }
            errorProvider_NazivAparata.SetError(textBox_NazivOrdinacije, "Polje ne smije biti prazno");
        }

        private void textBox_NazivOrdinacije_Validated(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_NazivOrdinacije.Text))
            {
                errorProvider_NazivAparata.SetError(textBox_NazivOrdinacije, String.Empty);
            }
            else
            {
                errorProvider_NazivAparata.SetError(textBox_NazivOrdinacije, "Polje ne smije biti prazno");
            }
        }

        private void button_Dodaj_Click(object sender, EventArgs e)
        {
            Ordinacija o = new Ordinacija();
            for(int i=0; i<Glavna.klinika17280_1.KlinickeOrdinacije.Count; i++)
            {
                if(comboBox_Ordinacija.SelectedItem.ToString()==Glavna.klinika17280_1.KlinickeOrdinacije[i].ImeOrdinacije)
                {
                    o = Glavna.klinika17280_1.KlinickeOrdinacije[i];
                    break;
                }
            }
            Glavna.klinika17280_1.KlinickiAparati.Add(new Aparat(radioButton_Aktivna.Checked,
                textBox_NazivOrdinacije.Text, o));

            toolStripStatusLabelDodajAparat.ForeColor = Color.Blue;
            toolStripStatusLabelDodajAparat.Text = "Uspješno ste dodali novi aparat";
            textBox_NazivOrdinacije.Clear();
                       
        }
    }
}
