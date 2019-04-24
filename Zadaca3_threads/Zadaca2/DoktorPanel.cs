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
    public partial class DoktorPanel : Form
    {
        Doktor doktorUOrdinaciji;
        Ordinacija trenutnaOrdinacija;
        public DoktorPanel()
        {
            InitializeComponent();
            doktorUOrdinaciji = Glavna.prijavljeni as Doktor;
            trenutnaOrdinacija = doktorUOrdinaciji.OrdinacijaUKojojRadi;
        }

        private void DoktorPanel_Load(object sender, EventArgs e)
        {
            //TabPage Profil

            ActiveControl = button_Odjava;
            groupBox_PromjenaLozinke.Visible = false;
            button_Odjava.CausesValidation = false;

            label_Datum.Text = label_Datum.Text + DateTime.Today.ToShortDateString();
            label_Dobrodosli.Text = label_Dobrodosli.Text + Glavna.prijavljeni.Ime + " " + Glavna.prijavljeni.Prezime;
            label_Uloga.Text = label_Uloga.Text + Glavna.prijavljeni.Uloga;

            textBox_Kime.Text = Glavna.prijavljeni.KorisnickoIme;

            toolStripStatusLabelDoktorPanel.ForeColor = Color.Blue;
            toolStripStatusLabelDoktorPanel.Text = "Uspješno ste prijavljeni kao doktor";

            //TabPage UnosPregleda

            foreach(int indeks in Glavna.IndeksiPacijenataiNaKlinici)
            {
                comboBox_OdaberiPacijenta.Items.Add(Glavna.klinika17280_1.RegistrovaneOsobe[indeks].Ime + " " + Glavna.klinika17280_1.RegistrovaneOsobe[indeks].Prezime);
            }

        }

        private void button_Odjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prijava prijava = new Prijava();
            prijava.ShowDialog();
            this.Close();
        }

        //Izmjena lozinke

        private void button_DajCekanje_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_PretragaPo.SelectedIndex == -1 || comboBox_OdabirPac_Ord.SelectedIndex == -1)
                    throw new Exception("Odaberite opciju da bi se prikazao red čekanja");
                if (comboBox_PretragaPo.SelectedIndex == 1)
                {
                    int indeks = Glavna.IndeksiPacijenataiNaKlinici[comboBox_OdabirPac_Ord.SelectedIndex];
                    Pacijent pacijent17280 = Glavna.klinika17280_1.RegistrovaneOsobe[indeks] as Pacijent;
                    textBox_CekanjePacijent.Clear();
                    textBox_CekanjePacijent.Visible = true;
                    textBox_CekanjePacijent.AppendText("Raspored pregleda sa informacijama o redu\nčekanja");
                    textBox_CekanjePacijent.AppendText(Environment.NewLine);
                    textBox_CekanjePacijent.AppendText("Pacijent: " + pacijent17280.Ime + " " + pacijent17280.Prezime);

                    List<Pregled> listaOdabranihPregleda = pacijent17280.VratiSpisakPregledaNaCekanju();

                    for (int i = 0; i < listaOdabranihPregleda.Count; i++)
                    {
                        int brojIspred = listaOdabranihPregleda[i].OrdinacijaUKojojSeObavlja.BrojPacijenataNaCekanju - 1;
                        textBox_CekanjePacijent.AppendText(Environment.NewLine);
                        textBox_CekanjePacijent.AppendText(i + 1 + ".");
                        textBox_CekanjePacijent.AppendText(Environment.NewLine);
                        textBox_CekanjePacijent.AppendText(listaOdabranihPregleda[i].ImePregleda);
                        textBox_CekanjePacijent.AppendText(Environment.NewLine);
                        textBox_CekanjePacijent.AppendText("Ordinacija: " + listaOdabranihPregleda[i].OrdinacijaUKojojSeObavlja.ImeOrdinacije);
                        textBox_CekanjePacijent.AppendText(Environment.NewLine);
                        textBox_CekanjePacijent.AppendText("Broj osoba ispred: " + brojIspred);
                    }
                }
                else
                {
                    textBox_CekanjeOrdinacija.Clear();
                    textBox_CekanjeOrdinacija.Visible = true;
                    int indeks = Glavna.klinika17280_1.KlinickeOrdinacije.FindIndex(o => o.ImeOrdinacije == comboBox_OdabirPac_Ord.Items[comboBox_OdabirPac_Ord.SelectedIndex].ToString());
                    List<Tuple<Pacijent, Pregled>> redCekanja = Glavna.klinika17280_1.KlinickeOrdinacije[indeks].PreglediNaCekanju;
                    int i = 1;
                    foreach (Tuple<Pacijent, Pregled> p in redCekanja)
                    {
                        textBox_CekanjeOrdinacija.AppendText(i + ") " + p.Item1.Ime + " " + p.Item1.Prezime);
                        textBox_CekanjeOrdinacija.AppendText(Environment.NewLine);
                        textBox_CekanjeOrdinacija.AppendText(p.Item2.ImePregleda);
                        textBox_CekanjeOrdinacija.AppendText(Environment.NewLine);
                    }
                }
            }
            catch(Exception ex)
            {
                Izuzetak iz = new Izuzetak(TipIzuzetka.Rad_sa_UI_kontrolama, DateTime.Now, Glavna.prijavljeni.KorisnickoIme, ex.Message);
                Glavna.DodajIzuzetak(iz);
                toolStripStatusLabelDoktorPanel.ForeColor = Color.Red;
                toolStripStatusLabelDoktorPanel.Text = ex.Message;
            }
        }

        private void comboBox_PretragaPo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox_PretragaPo.SelectedIndex == 0)
            {
                textBox_CekanjePacijent.Visible = false;
                comboBox_OdabirPac_Ord.Items.Clear();
                foreach (Ordinacija o in Glavna.klinika17280_1.KlinickeOrdinacije)
                {

                    comboBox_OdabirPac_Ord.Items.Add(o.ImeOrdinacije);
                }
            }
            else
            {
                textBox_CekanjeOrdinacija.Visible = false;
                comboBox_OdabirPac_Ord.Items.Clear();
                foreach (int indeks in Glavna.IndeksiPacijenataiNaKlinici)
                {
                    comboBox_OdabirPac_Ord.Items.Add(Glavna.klinika17280_1.RegistrovaneOsobe[indeks].Ime + " " +
                    Glavna.klinika17280_1.RegistrovaneOsobe[indeks].Prezime);
                }
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

        private void button_PromijeniLozinku_Click(object sender, EventArgs e)
        {
            groupBox_PromjenaLozinke.Visible = true;
        }

        private void buttonPromijeni_Click(object sender, EventArgs e)
        {
            Glavna.prijavljeni.Lozinka = textBox_Nova.Text;
            toolStripStatusLabelDoktorPanel.Text = "Uspješno ste promijenili lozinku";
        }

        //TabPage UnosPregleda
        private void comboBox_OdaberiPacijenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            int indeks = Glavna.IndeksiPacijenataiNaKlinici[comboBox_OdaberiPacijenta.SelectedIndex];
            Pacijent pac = Glavna.klinika17280_1.RegistrovaneOsobe[indeks] as Pacijent;

            //Ispisivanje licnih podataka
            groupBox_Tab1LicniPodaci.Visible = true;
            label_PisiIme.Text = pac.Ime;
            label_PisiPrezime.Text = pac.Prezime;
            label_PisiSpol.Text = pac.Spol.ToString();
            label_PisiMaticniBroj.Text = pac.MaticniBroj;
            label_PisiEmail.Text = pac.Email;
            label_PisiDatumRodjenja.Text = pac.DatumRodjenja.ToShortDateString();
            label_PisiAdresa.Text = pac.Adresa;
            label_PisiBracnoStanje.Text = pac.BracnoStanje.ToString();
            label_PisiBrojPosjeta.Text = pac.ListaRacuna.Count.ToString();

            groupBox_Karton.Visible = true;
            //Popunjavanje anamneze
            if (pac.KartonPacijenta.AnamnezaPacijenta != null)
            {
                
                textBox_Anamneza.Clear();
                textBox_Anamneza.AppendText("Ranije bolesti:");
                textBox_Anamneza.AppendText(Environment.NewLine);
                textBox_Anamneza.AppendText(pac.KartonPacijenta.AnamnezaPacijenta.RanijeBolesti);
                textBox_Anamneza.AppendText(Environment.NewLine);
                textBox_Anamneza.AppendText("Ranije alergije:");
                textBox_Anamneza.AppendText(Environment.NewLine);
                textBox_Anamneza.AppendText(pac.KartonPacijenta.AnamnezaPacijenta.RanijeAlergije);
                textBox_Anamneza.AppendText(Environment.NewLine);
                textBox_Anamneza.AppendText("Trenutna bolest:");
                textBox_Anamneza.AppendText(Environment.NewLine);
                textBox_Anamneza.AppendText(pac.KartonPacijenta.AnamnezaPacijenta.TrenutnaBolest);
                textBox_Anamneza.AppendText(Environment.NewLine);
                textBox_Anamneza.AppendText("Trenutne alergije:");
                textBox_Anamneza.AppendText(Environment.NewLine);
                textBox_Anamneza.AppendText(pac.KartonPacijenta.AnamnezaPacijenta.TrenutneAlergije);
                textBox_Anamneza.AppendText(Environment.NewLine);
            }
            //Popunjavanje historije pregleda
            listBox_KartonPregled.Items.Clear();
            foreach (PacijentovPregled p in pac.KartonPacijenta.ListaPregleda)
            {
                listBox_KartonPregled.Items.Add(p.PregledKojiSeObavlja.ImePregleda + " " + p.DatumPregleda.ToShortDateString());
            }
            

            //Popunjavanje liste pregleda
            comboBox_OdabirPregleda.Items.Clear();
            foreach (KeyValuePair<Pregled, bool> p in pac.SpisakPregleda)
            {
                if(p.Value==true && p.Key.OrdinacijaUKojojSeObavlja.ImeOrdinacije==trenutnaOrdinacija.ImeOrdinacije)
                {
                    comboBox_OdabirPregleda.Items.Add(p.Key.ImePregleda);
                }
            }
        }

        private void listBox_KartonPregled_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int indeks = Glavna.IndeksiPacijenataiNaKlinici[comboBox_OdaberiPacijenta.SelectedIndex];
            Pacijent pac = Glavna.klinika17280_1.RegistrovaneOsobe[indeks] as Pacijent;
            int indeksPregleda = listBox_KartonPregled.SelectedIndex;

            PregledDetaljno pregledDetaljno = new PregledDetaljno(pac.KartonPacijenta.ListaPregleda[indeksPregleda]);
            pregledDetaljno.ShowDialog();

        }

        private void button_DodajPregled_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(richTextBox_MisljenjeDoktora.Text) || String.IsNullOrEmpty(richTextBox_RezultatPregleda.Text)
                || String.IsNullOrEmpty(textBox_ImeTerapije.Text))
            {
                DialogResult d = MessageBox.Show("Za polja koja su prazna smatrat će se da informacije nisu pružene.\n" +
                    "Jeste li sigurni da želite nastaviti?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (d == DialogResult.Yes)
                {
                    this.DodavanjePregleda();
                    toolStripStatusLabelDoktorPanel.ForeColor = Color.Blue;
                    toolStripStatusLabelDoktorPanel.Text = "Uspješno ste dodali pregled";
                }

            }

            else
            {
                this.DodavanjePregleda();
                toolStripStatusLabelDoktorPanel.ForeColor = Color.Blue;
                toolStripStatusLabelDoktorPanel.Text = "Uspješno ste dodali pregled";
            }
        }

        private void DodavanjePregleda()
        {
           
            int indeks = Glavna.IndeksiPacijenataiNaKlinici[comboBox_OdaberiPacijenta.SelectedIndex];
            Pacijent pac = Glavna.klinika17280_1.RegistrovaneOsobe[indeks] as Pacijent;
            int i = 0;
            Pregled pregledKojiObavlja=null;
            foreach(KeyValuePair<Pregled, bool> p in pac.SpisakPregleda)
            {
                if(i==comboBox_OdabirPregleda.SelectedIndex)
                {
                    
                    pregledKojiObavlja = p.Key;
                    
                    
                    break;
                }
                i++;
            }
            pac.SpisakPregleda[pregledKojiObavlja] = false;
            
            Doktor d = Glavna.prijavljeni as Doktor;
            d.BrojPregledanihPacijenata++;
            Terapija t = null;
            if(!String.IsNullOrEmpty(textBox_ImeTerapije.Text) || !String.IsNullOrWhiteSpace(textBox_ImeTerapije.Text))
            {
                t = new Terapija(textBox_ImeTerapije.Text, (int)numericUpDown_TrajanjeTerapije.Value);
            }
            pac.KartonPacijenta.ListaPregleda.Add(new PacijentovPregled(pregledKojiObavlja, DateTime.Today, d, richTextBox_RezultatPregleda.Text, richTextBox_MisljenjeDoktora.Text, t));

            Glavna.klinika17280_1.RegistrovaneOsobe[indeks] = pac;
            int indeksOrdinacije =  Glavna.klinika17280_1.KlinickeOrdinacije.FindIndex(o => o.ImeOrdinacije == doktorUOrdinaciji.OrdinacijaUKojojRadi.ImeOrdinacije);
            Glavna.klinika17280_1.KlinickeOrdinacije[indeksOrdinacije].BrojObradjenihPacijenata++;
            int k =doktorUOrdinaciji.OrdinacijaUKojojRadi.PreglediNaCekanju.FindIndex(p => p.Item1.MaticniBroj == pac.MaticniBroj && p.Item2 == pregledKojiObavlja);
            Glavna.klinika17280_1.KlinickeOrdinacije[indeksOrdinacije].PreglediNaCekanju.RemoveAt(k);
            bool imaJosPregleda = false;
            foreach(Tuple<Pacijent,Pregled> p in doktorUOrdinaciji.OrdinacijaUKojojRadi.PreglediNaCekanju)
            {
                if(p.Item1.MaticniBroj==pac.MaticniBroj)
                {
                    imaJosPregleda = true; break;
                }
            }
            if(imaJosPregleda==false)
            {
                Glavna.klinika17280_1.KlinickeOrdinacije[indeksOrdinacije].BrojPacijenataNaCekanju--;
            }

            richTextBox_MisljenjeDoktora.Clear();
            richTextBox_RezultatPregleda.Clear();
            textBox_ImeTerapije.Clear();
            numericUpDown_TrajanjeTerapije.Value = 0;

            

        }

        private void listBox_KartonPregled_MouseHover(object sender, EventArgs e)
        {
            toolTip_ListaPregleda.Show("Dvostruki klik na željeni pregled\ndaje detalje pregleda", listBox_KartonPregled);
        }

        private void promijeniBojuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            DialogResult rez = cd.ShowDialog();
            if (rez == DialogResult.OK)
            {
                tabControl_DoktorPanel.SelectedTab.BackColor = cd.Color;
            }
        }
    }
}
