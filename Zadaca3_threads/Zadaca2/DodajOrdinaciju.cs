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
    public partial class DodajOrdinaciju : Form
    {
        public DodajOrdinaciju()
        {
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if(String.IsNullOrEmpty(textBox_NazivOrdinacije.Text))
            {
                e.Cancel = true;
            }
            errorProvider_NazivOrdinacije.SetError(textBox_NazivOrdinacije, "Polje ne smije biti prazno");
        }

        private void textBox_NazivOrdinacije_Validated(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_NazivOrdinacije.Text))
            {
                errorProvider_NazivOrdinacije.SetError(textBox_NazivOrdinacije, String.Empty);
            }
            else
            {
                errorProvider_NazivOrdinacije.SetError(textBox_NazivOrdinacije, "Polje ne smije biti prazno");
            }
        }

        private void groupBox_Aktivnost_MouseHover(object sender, EventArgs e)
        {
            toolTip_Aktivnost.Show("Ordinacija je zatvorena u slučaju kvara na aparatu, ili odustsva doktora",groupBox_Aktivnost);
        }

        private void radioButton_Aktivna_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DodajOrdinaciju_Load(object sender, EventArgs e)
        {

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
            if(radioButton_Aktivna.Checked)
            {
                Glavna.klinika17280_1.KlinickeOrdinacije.Add(new Ordinacija(true, textBox_NazivOrdinacije.Text));
            }
            else
            {
                Glavna.klinika17280_1.KlinickeOrdinacije.Add(new Ordinacija(false, textBox_NazivOrdinacije.Text));
            }
            textBox_NazivOrdinacije.Clear();
            toolStripStatusLabelDodavanjeOrdinacije.ForeColor = Color.Blue;
            toolStripStatusLabelDodavanjeOrdinacije.Text = "Uspješno ste dodali novu ordinaciju";
        }
    }
}
