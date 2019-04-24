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
    public partial class PacijentovPanel : Form
    {
        public PacijentovPanel()
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button_Odjava_Click(object sender, EventArgs e)
        {
            Pacijent pac = Glavna.prijavljeni as Pacijent;
            pac.Slika = slika1.Pciture;
            this.Close();
            Prijava prijava = new Prijava();
            prijava.ShowDialog();
        }

        private void button_PromijeniLozinku_Click(object sender, EventArgs e)
        {
            groupBox_PromjenaLozinke.Visible = true;
        }

      

        private void PacijentovPanel_Load(object sender, EventArgs e)
        {
            //TabPage Profil

            ActiveControl = button_Odjava;
            groupBox_PromjenaLozinke.Visible = false;
            button_Odjava.CausesValidation = false;

            label_Datum.Text = label_Datum.Text + DateTime.Today.ToShortDateString();
            label_Dobrodosli.Text = label_Dobrodosli.Text + Glavna.prijavljeni.Ime + " " + Glavna.prijavljeni.Prezime;
            label_Uloga.Text = label_Uloga.Text + Glavna.prijavljeni.Uloga;

            textBox_Kime.Text = Glavna.prijavljeni.KorisnickoIme;

            toolStripStatusLabelPacijent.ForeColor = Color.Blue;
            toolStripStatusLabelPacijent.Text = "Uspješno ste prijavljeni kao pacijent";

            //TabKarton popunjavanje licnih podataka

            Pacijent pacijent17280 = Glavna.prijavljeni as Pacijent;
            groupBox_Tab1LicniPodaci.Visible = true;
            label_PisiIme.Text = pacijent17280.Ime;
            label_PisiPrezime.Text = pacijent17280.Prezime;
            label_PisiDatumRodjenja.Text = pacijent17280.DatumRodjenja.ToShortDateString();
            label_PisiMaticniBroj.Text = pacijent17280.MaticniBroj;
            label_PisiAdresa.Text = pacijent17280.Adresa;
            label_PisiBracnoStanje.Text = pacijent17280.BracnoStanje.ToString();
            label_PisiEmail.Text = pacijent17280.Email;
            label_PisiSpol.Text = pacijent17280.Spol.ToString();
            label_PisiBrojPosjeta.Text = pacijent17280.ListaRacuna.Count.ToString();
            label_PisiUkupanDug.Text = pacijent17280.DugPacijenta.ToString();
            label_PisiBrojRata.Text = pacijent17280.BrojPreostalihRata.ToString();
            slika1.Pciture = pacijent17280.Slika;

            //Popunjavanje kartona
            foreach (PacijentovPregled p in pacijent17280.KartonPacijenta.ListaPregleda)
            {
                listBox_KartonPregled.Items.Add(p.PregledKojiSeObavlja.ImePregleda + " " + p.DatumPregleda.ToShortDateString());
            }

            //Popunjavanje zauzetosti ordinacija

            foreach(Ordinacija o in Glavna.klinika17280_1.KlinickeOrdinacije)
            {
                listBox_Ordinacije.Items.Add(o.ImeOrdinacije);
                listBox_BrojNaCekanju.Items.Add(o.BrojPacijenataNaCekanju);
            }
        }

        private void textBox_Stara_Validating(object sender, CancelEventArgs e)
        {
            if (Osoba.Kodiraj(textBox_Stara.Text) != Glavna.prijavljeni.Lozinka)
            {
                e.Cancel = true;
            }
            this.errorProvider_StaraLozinka.SetError(textBox_Stara, "Netačna stara lozinka");
        }

        private void textBox_Stara_Validated(object sender, EventArgs e)
        {
            if (Osoba.Kodiraj(textBox_Stara.Text) == Glavna.prijavljeni.Lozinka)
            {
                errorProvider_StaraLozinka.SetError(textBox_Stara, String.Empty);
            }
        }

        private void textBox_Nova_Validating(object sender, CancelEventArgs e)
        {
            if (textBox_Nova.Text.Length < 7)
            {
                e.Cancel = true;

            }
            this.errorProvider_NovaL.SetError(textBox_Nova, "Lozinka mora imati minimalno 7 znakova");
        }

        private void textBox_Nova_Validated(object sender, EventArgs e)
        {
            if (textBox_Nova.Text.Length > 6)
            {
                errorProvider_NovaL.SetError(textBox_Nova, String.Empty);
            }
        }

        private void textBox_NovaP_Validating(object sender, CancelEventArgs e)
        {
            if (textBox_Nova.Text != textBox_NovaP.Text)
            {

                e.Cancel = true;

            }
            errorProvider_NovaP.SetError(textBox_NovaP, "Lozinke se ne poklapaju");
        }

        private void textBox_NovaP_Validated(object sender, EventArgs e)
        {
            if (textBox_Nova.Text == textBox_NovaP.Text)
            {

                errorProvider_NovaP.SetError(textBox_NovaP, String.Empty);
            }
        }

        private void buttonPromijeni_Click(object sender, EventArgs e)
        {
            Glavna.prijavljeni.Lozinka = textBox_Nova.Text;


            toolStripStatusLabelPacijent.Text = "Uspješno ste promijenili lozinku";
        }

        private void listBox_KartonPregled_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Dvostruki klik na željeni pregled daje\ndodatne informacije o pregledu", listBox_KartonPregled);
        }

        private void listBox_KartonPregled_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            Pacijent pac = Glavna.prijavljeni as Pacijent;
            int indeksPregleda = listBox_KartonPregled.SelectedIndex;

            PregledDetaljno pregledDetaljno = new PregledDetaljno(pac.KartonPacijenta.ListaPregleda[indeksPregleda]);
            pregledDetaljno.ShowDialog();
        }

        private void asdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            DialogResult rez = cd.ShowDialog();
            if(rez==DialogResult.OK)
            {
                tabControl_Pacijent.SelectedTab.BackColor = cd.Color;
            }
        }

        private void groupBox_Tab1LicniPodaci_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Izmjena podataka vrši se na klinici\radi potvrde podataka koji se izmjenjuju", groupBox_Tab1LicniPodaci);
        }
    }
}
