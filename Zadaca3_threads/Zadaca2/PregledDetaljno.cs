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
    public partial class PregledDetaljno : Form
    {
        PacijentovPregled pregled;
        public PregledDetaljno(PacijentovPregled p)
        {
            InitializeComponent();
            pregled = p;
        }

        private void PregledDetaljno_Load(object sender, EventArgs e)
        {
            label_NazivPregleda.Text = pregled.PregledKojiSeObavlja.ImePregleda;
            label_DatumPregleda.Text = pregled.DatumPregleda.ToShortDateString();
            label_PregledObavio.Text = pregled.PregledObavio.Ime + " " + pregled.PregledObavio.Prezime;
            richTextBox_RezultatPregleda.Text = pregled.RezultatPregleda;
            richTextBox_MisljenjeDoktora.Text = pregled.MisljenjeDoktora;
            if(pregled.TerapijaUzPregled!=null)
            {
                groupBox_Terapija.Visible = true;
                label_ImeTerapije.Text = pregled.TerapijaUzPregled.ImeTrapije;
                label_TrajanjeTerapije.Text = pregled.TerapijaUzPregled.TrajanjeTerapije.ToString();
            }
        }

        private void button_ZatvoriPregled_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

       
    }
}
