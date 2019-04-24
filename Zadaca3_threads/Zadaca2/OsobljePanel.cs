using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Web.UI.WebControls;

namespace Zadaca2
{
    public partial class OsobljePanel : Form
    {
        Pacijent klasPac;
        public OsobljePanel()
        {
            InitializeComponent();
        }

        private void OsobljePanel_Load(object sender, EventArgs e)
        {
            //TabPage Profil

            ActiveControl = button_Odjava;
            groupBox_PromjenaLozinke.Visible = false;
            button_Odjava.CausesValidation = false;

            label_Datum.Text = label_Datum.Text + DateTime.Today.ToShortDateString();
            label_Dobrodosli.Text = label_Dobrodosli.Text + Glavna.prijavljeni.Ime + " " + Glavna.prijavljeni.Prezime;
            label_Uloga.Text = label_Uloga.Text + Glavna.prijavljeni.Uloga;

            textBox_Kime.Text = Glavna.prijavljeni.KorisnickoIme;

            toolStripStatusLabelOsoblje.ForeColor = Color.Blue;
            toolStripStatusLabelOsoblje.Text = "Uspješno ste prijavljeni kao medicinsko osoblje";




            //tabControl_Osoblje.SelectedTab = tabControl_Osoblje.TabPages[5];
            // ActiveControl = textBox_MaticniBrojRegistracija;
            toolStripStatusLabelOsoblje.ForeColor = Color.Blue;
            toolStripStatusLabelOsoblje.Text = "Uspješno ste prijavljeni kao medicinsko osoblje";

            comboBox_PretragaPo.SelectedIndex = 0;
            radioButton_Gotovina.Checked = true;
            

            //Postavljanje taba za registraciju pregleda

            for (int i = 0; i < Glavna.klinika17280_1.DostupniPregledi.Count; i++)
            {
                checkedListBox_Pregledi.Items.Add(Glavna.klinika17280_1.DostupniPregledi[i].ImePregleda);
            }
            
            //Postavljanje taba za registraciju pacijenata
            radioButton_Musko.Checked = true;
            string[] bracnaStanja = { "Zarucen_a", "Ozenjen_Udata", "Neozenjen_Neudata", "Razveden_a", "Udovac_ica" };
            comboBox_BracnoStanje.Items.AddRange(bracnaStanja);
            comboBox_BracnoStanje.SelectedIndex = 2;

            button_Print.BringToFront();

            //Postavljanje tab izdavanje racuna

            for(int i=0; i<Glavna.IndeksiPacijenataiNaKlinici.Count; i++)
            {
                int k = Glavna.IndeksiPacijenataiNaKlinici[i];
                listBox_TabRacun_Pacijent.Items.Add(Glavna.klinika17280_1.RegistrovaneOsobe[k].Ime + " " + Glavna.klinika17280_1.RegistrovaneOsobe[k].Prezime);
                listBox_TabRacun_MaticniBroj.Items.Add(Glavna.klinika17280_1.RegistrovaneOsobe[k].MaticniBroj);
            }
            
        }

        private void button_PonistiUnos_Click(object sender, EventArgs e)
        {
            textBox_Ime.Clear();
            textBox_Prezime.Clear();
            textBox_MaticniBroj.Clear();
            textBox_Email.Clear();
            textBox_Adresa.Clear();
        }

        

        

        private void button_DodajPacijenta_Click(object sender, EventArgs e)
        {
            try
            {
                Spol spol = Spol.Musko;
                if (radioButton_Musko.Checked == false) spol = Spol.Zensko;
                int i = comboBox_BracnoStanje.SelectedIndex;
                BracnoStanje stanje = BracnoStanje.Zarucen_a;
                switch (i)
                {
                    case 1: stanje = BracnoStanje.Ozenjen_Udata; break;
                    case 2: stanje = BracnoStanje.Neozenjen_Neudata; break;
                    case 3: stanje = BracnoStanje.Razveden_a; break;
                    case 4: stanje = BracnoStanje.Udovac_ica; break;

                }

                Pacijent pacijent17280 = new Pacijent(textBox_Ime.Text, textBox_Prezime.Text, dateTimePicker1.Value, textBox_MaticniBroj.Text
                    , textBox_Adresa.Text, spol, stanje, textBox_Email.Text);
                pacijent17280.Slika = slika1.Pciture;
                if(checkBox_SmrtniSlucaj.Checked==true)
                {
                    pacijent17280.PodaciOSmrti = new PodaciOSmrti(dateTimePicker_VrijemeSmrti.Value, dateTimePicker_VrijemeObdukcije.Value, richTextBox1.Text);
                    pacijent17280.NaPregledu = false;
                    Glavna.klinika17280_1.registrujPacijenta(pacijent17280);
                }
                else
                {
                    Glavna.klinika17280_1.registrujPacijenta(pacijent17280);
                }
                toolStripStatusLabelOsoblje.ForeColor = Color.Blue;
                toolStripStatusLabelOsoblje.Text = "Uspješno ste registrovali pacijenta na kliniku";
            }
            catch(Exception ex)
            {
                Izuzetak iz = new Izuzetak(TipIzuzetka.Rad_sa_UI_kontrolama, DateTime.Now, Glavna.prijavljeni.KorisnickoIme, ex.Message);
                Glavna.DodajIzuzetak(iz);
                toolStripStatusLabelOsoblje.ForeColor = Color.Red;
                toolStripStatusLabelOsoblje.Text = ex.Message;
            }
        }

        private void button_Odjava_Click(object sender, EventArgs e)
        {
            
            DialogResult d = MessageBox.Show("Jeste li sigurni da se želite odjaviti?", "Odjava", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                this.Hide();
                Prijava prijava = new Prijava();
                prijava.ShowDialog();
                this.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_SmrtniSlucaj.Checked)
            {
                groupBox_PodaciOSmrti.Visible = true;
            }
            else
            {
                groupBox_PodaciOSmrti.Visible = false;
            }
        }

        private void richTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if(String.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                e.Cancel = true;
            }
            errorProvider_UzrokSmrti.SetError(richTextBox1, "Polje ne smije biti prazno");
        }

        private void richTextBox1_Validated(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                errorProvider_UzrokSmrti.SetError(richTextBox1, String.Empty);
            }
            else
            {
                errorProvider_UzrokSmrti.SetError(richTextBox1, "Polje ne smije biti prazno");
            }
        }

        private void checkedListBox_Pregledi_MouseHover(object sender, EventArgs e)
        {
            toolTip_Pregledi.Show("Označite sve preglede koje pacijent\nželi obaviti", checkedListBox_Pregledi);
        }

 
        private void button_Registruj_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkedListBox_Pregledi.SelectedItems.Count==0)
                    throw new Exception("Nije odabran niti jedan pregled");
                int indeks = Glavna.klinika17280_1.RegistrovaneOsobe.FindIndex(pac => pac.MaticniBroj == textBox_MaticniBrojRegistracija.Text && pac.Uloga == Uloga.Pacijent);
                Pacijent pacijent17280 = Glavna.klinika17280_1.RegistrovaneOsobe.Find(pac => pac.MaticniBroj == textBox_MaticniBrojRegistracija.Text) as Pacijent;
                klasPac = pacijent17280;
                if (pacijent17280 == null)
                {
                    toolStripStatusLabelOsoblje.ForeColor = Color.Red;
                    toolStripStatusLabelOsoblje.Text = "Pacijent sa unesenim JMBG nije pronađen";

                }

                else
                {

                    //Registracija pregleda
                    List<Pregled> listaOdabranihPregleda = new List<Pregled>();

                    for (int i = 0; i < checkedListBox_Pregledi.CheckedItems.Count; i++)
                    {
                        listaOdabranihPregleda.Add(Glavna.klinika17280_1.DostupniPregledi.Find(p => p.ImePregleda == checkedListBox_Pregledi.CheckedItems[i].ToString()));
                        listaOdabranihPregleda[i].OrdinacijaUKojojSeObavlja.PreglediNaCekanju.Add(Tuple.Create(pacijent17280, listaOdabranihPregleda[i]));
                    }

                    listaOdabranihPregleda.Sort(delegate (Pregled prvi, Pregled drugi)
                    {
                        return prvi.OrdinacijaUKojojSeObavlja.BrojPacijenataNaCekanju.CompareTo(drugi.OrdinacijaUKojojSeObavlja.BrojPacijenataNaCekanju);
                    });


                    Dictionary<Pregled, bool> spisak = new Dictionary<Pregled, bool>();

                    for (int i = 0; i < listaOdabranihPregleda.Count; i++)
                    {
                        spisak.Add(listaOdabranihPregleda[i], true);
                    }
                    pacijent17280.SpisakPregleda = spisak;

                    //Pravljenje rasporeda posjeta
                    textBox_RedCekanja.Clear();
                    groupBox_RedCekanja.Visible = true;
                    textBox_RedCekanja.AppendText("Raspored pregleda sa informacijama o redu\nčekanja");
                    textBox_RedCekanja.AppendText(Environment.NewLine);
                    textBox_RedCekanja.AppendText("Pacijent: " + pacijent17280.Ime + " " + pacijent17280.Prezime);


                    for (int i = 0; i < listaOdabranihPregleda.Count; i++)
                    {
                        textBox_RedCekanja.AppendText(Environment.NewLine);
                        textBox_RedCekanja.AppendText(i + 1 + ".");
                        textBox_RedCekanja.AppendText(Environment.NewLine);
                        textBox_RedCekanja.AppendText(listaOdabranihPregleda[i].ImePregleda);
                        textBox_RedCekanja.AppendText(Environment.NewLine);
                        textBox_RedCekanja.AppendText("Ordinacija: " + listaOdabranihPregleda[i].OrdinacijaUKojojSeObavlja.ImeOrdinacije);
                        textBox_RedCekanja.AppendText(Environment.NewLine);
                        textBox_RedCekanja.AppendText("Broj osoba ispred: " + listaOdabranihPregleda[i].OrdinacijaUKojojSeObavlja.BrojPacijenataNaCekanju);
                    }


                    //Dodavanje pacijenta u ordinaciju
                    for (int i = 0; i < listaOdabranihPregleda.Count; i++)
                    {
                        int indeksOrdinacije = Glavna.klinika17280_1.KlinickeOrdinacije.FindIndex(o => o.ImeOrdinacije == listaOdabranihPregleda[i].OrdinacijaUKojojSeObavlja.ImeOrdinacije);
                        List<Pregled> pom = listaOdabranihPregleda.GetRange(0, i);
                        if (pom.Exists(p => p == listaOdabranihPregleda[i]) == false)
                        {

                            Glavna.klinika17280_1.KlinickeOrdinacije[indeksOrdinacije].BrojPacijenataNaCekanju++;
                        }
                    }

                    //Aktivacija pacijenta na klinici
                    pacijent17280.NaPregledu = true;
                    Glavna.IndeksiPacijenataiNaKlinici.Add(indeks);
                    listBox_AktivniPacijenti.Items.Add(Glavna.klinika17280_1.RegistrovaneOsobe[indeks].Ime + " " + Glavna.klinika17280_1.RegistrovaneOsobe[indeks].Prezime);
                    listBox_AktivniMaticniBroj.Items.Add(Glavna.klinika17280_1.RegistrovaneOsobe[indeks].MaticniBroj);
                    listBox_TabRacun_Pacijent.Items.Add(Glavna.klinika17280_1.RegistrovaneOsobe[indeks].Ime + " " + Glavna.klinika17280_1.RegistrovaneOsobe[indeks].Prezime);
                    listBox_TabRacun_MaticniBroj.Items.Add(Glavna.klinika17280_1.RegistrovaneOsobe[indeks].MaticniBroj);

                    //Poruke o uspjesnosti registracije
                    toolStripStatusLabelOsoblje.ForeColor = Color.Blue;
                    toolStripStatusLabelOsoblje.Text = "Uspješno ste registrovali preglede pacijentu";

                    textBox_MaticniBrojRegistracija.Clear();
                    checkedListBox_Pregledi.ClearSelected();
                    pacijent17280.KartonPacijenta.AnamnezaPacijenta = null;
                    Glavna.klinika17280_1.RegistrovaneOsobe[indeks] = pacijent17280;
                }
            }
            catch(Exception ex)
            {
                Izuzetak iz = new Izuzetak(TipIzuzetka.Rad_sa_UI_kontrolama, DateTime.Now, Glavna.prijavljeni.KorisnickoIme, ex.Message);
                Glavna.DodajIzuzetak(iz);
                toolStripStatusLabelOsoblje.ForeColor = Color.Red;
                toolStripStatusLabelOsoblje.Text = ex.Message;
            }
            
        }


        private void button_Print_Click(object sender, EventArgs e)
        {
            printPreviewDialog_RedCekanja.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            e.Graphics.DrawString(textBox_RedCekanja.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 100));
        }

        private void button_IzmjeniPacijenta_Click(object sender, EventArgs e)
        {
            UrediPacijenta urediPacijenta = new UrediPacijenta(klasPac);
            urediPacijenta.ShowDialog();
            
        }

        private void listBox_AktivniPacijenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_AktivniMaticniBroj.SelectedIndex = listBox_AktivniPacijenti.SelectedIndex;
        }

        private void listBox_AktivniPacijenti_Validating(object sender, CancelEventArgs e)
        {
            if(listBox_AktivniPacijenti.SelectedIndex==-1)
            {
                e.Cancel = true;
            }
            toolStripStatusLabelOsoblje.ForeColor = Color.Red;
            toolStripStatusLabelOsoblje.Text = "Nije odabran niti jedan pacijent";
        }

        private void listBox_AktivniPacijenti_Validated(object sender, EventArgs e)
        {
            toolStripStatusLabelOsoblje.Text = String.Empty;
        }

        private void listBox_AktivniMaticniBroj_Validating(object sender, CancelEventArgs e)
        {
            if(listBox_AktivniMaticniBroj.SelectedIndex!=-1 && listBox_AktivniPacijenti.SelectedIndex==-1)
            {
                toolStripStatusLabelOsoblje.ForeColor = Color.Red;
                toolStripStatusLabelOsoblje.Text = "Odaberite ime i prezime";
            }
        }

        private void UzimanjeAnamneze_Click(object sender, EventArgs e)
        {
            ActiveControl = listBox_AktivniPacijenti;
        }

        private void button_DodajAnamnezu_Click(object sender, EventArgs e)
        {
            try
            {

                if (listBox_AktivniPacijenti.SelectedIndex == -1)
                    throw new Exception("Nije odabran niti jedan pacijent");
                if (String.IsNullOrEmpty(richTextBox_RanijeAlergije.Text) || String.IsNullOrEmpty(richTextBox_RanijeBolesti.Text)
                    || String.IsNullOrEmpty(richTextBox_TrenutneAlergije.Text) || String.IsNullOrEmpty(richTextBox_TrenutneBolesti.Text))
                {
                    DialogResult d = MessageBox.Show("Za polja koja su prazna smatrat će se da informacije nisu pružene.\n" +
                        "Jeste li sigurni da želite nastaviti?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (d == DialogResult.Yes)
                    {
                        this.DodavanjeAnamneze();
                    }

                }

                else
                {
                    this.DodavanjeAnamneze();
                }
            }
            catch(Exception ex)
            {
                Izuzetak iz = new Izuzetak(TipIzuzetka.Rad_sa_UI_kontrolama, DateTime.Now, Glavna.prijavljeni.KorisnickoIme, ex.Message);
                Glavna.DodajIzuzetak(iz);
                toolStripStatusLabelOsoblje.ForeColor = Color.Red;
                toolStripStatusLabelOsoblje.Text = ex.Message;
            }
        }

        private void DodavanjeAnamneze()
        {
            int indeks = Glavna.klinika17280_1.RegistrovaneOsobe.FindIndex(pac =>
                                    pac.MaticniBroj == listBox_AktivniMaticniBroj.Items[listBox_AktivniMaticniBroj.SelectedIndex].ToString());

            Pacijent pom = Glavna.klinika17280_1.RegistrovaneOsobe[indeks] as Pacijent;
            pom.KartonPacijenta.AnamnezaPacijenta = new Anamneza(richTextBox_RanijeBolesti.Text,
                richTextBox_RanijeAlergije.Text, richTextBox_TrenutneBolesti.Text, richTextBox_TrenutneAlergije.Text);
            Glavna.klinika17280_1.RegistrovaneOsobe[indeks] = pom;

            toolStripStatusLabelOsoblje.ForeColor = Color.Blue;
            toolStripStatusLabelOsoblje.Text = "Uspješno ste unijeli anamnezu za pacijenta";
            listBox_AktivniMaticniBroj.Items.RemoveAt(listBox_AktivniMaticniBroj.SelectedIndex);
            listBox_AktivniPacijenti.Items.RemoveAt(listBox_AktivniPacijenti.SelectedIndex);
            richTextBox_RanijeAlergije.Clear();
            richTextBox_RanijeBolesti.Clear();
            richTextBox_TrenutneAlergije.Clear();
            richTextBox_TrenutneBolesti.Clear();
        }

        private void tabControl_Osoblje_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            int i = tabControl_Osoblje.SelectedIndex;
            switch(i)
            {
                case 0: ActiveControl = textBox_MaticniBrojRegistracija; break;
                case 1: ActiveControl = textBox_Ime; break;
                case 2: ActiveControl = listBox_AktivniPacijenti; break;
                case 3: ActiveControl = listBox_TabRacun_Pacijent; break;
            }*/
        }

        private void listBox_TabRacun_Pacijent_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_TabRacun_MaticniBroj.SelectedIndex = listBox_TabRacun_Pacijent.SelectedIndex;
        }

        private void listBox_TabRacun_Pacijent_Validating(object sender, CancelEventArgs e)
        {
            if (listBox_TabRacun_Pacijent.SelectedIndex == -1)
            {
                e.Cancel = true;
            }
            toolStripStatusLabelOsoblje.ForeColor = Color.Red;
            toolStripStatusLabelOsoblje.Text = "Nije odabran niti jedan pacijent";
        }

        private void listBox_TabRacun_Pacijent_Validated(object sender, EventArgs e)
        {
            toolStripStatusLabelOsoblje.Text = String.Empty;
        }

        private void listBox_TabRacun_MaticniBroj_Validating(object sender, CancelEventArgs e)
        {
            if (listBox_TabRacun_MaticniBroj.SelectedIndex != -1 && listBox_TabRacun_Pacijent.SelectedIndex == -1)
            {
                toolStripStatusLabelOsoblje.ForeColor = Color.Red;
                toolStripStatusLabelOsoblje.Text = "Odaberite ime i prezime";
            }
        }

        private void listBox_TabRacun_MaticniBroj_Validated(object sender, EventArgs e)
        {
            toolStripStatusLabelOsoblje.Text = String.Empty;
        }

        private void comboBox_PretragaPo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_PretragaPo.SelectedIndex==0)
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

        private void button_DajCekanje_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_PretragaPo.SelectedIndex == -1 || comboBox_OdabirPac_Ord.SelectedIndex == -1)
                    throw new Exception("Odaberite ispravne opcije");
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
                toolStripStatusLabelOsoblje.ForeColor = Color.Red;
                toolStripStatusLabelOsoblje.Text = ex.Message;
            }
        }

        private void radioButton_Rate_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_Rate.Checked==true)
            {
                radioButton_2rate.Checked = true;
                groupBox_OdabirRata.Visible = true;
            }
        }

        private void button_IzdatiRacun_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox_TabRacun_Pacijent.SelectedIndex == -1) throw new Exception("Nije odabran niti jedan pacijent");
                textBox_Racun.Clear();
                textBox_Racun.Visible = true;
                int indeks = Glavna.klinika17280_1.RegistrovaneOsobe.FindIndex(o => o.MaticniBroj == listBox_TabRacun_MaticniBroj.SelectedItem.ToString());
                Pacijent p = Glavna.klinika17280_1.RegistrovaneOsobe[indeks] as Pacijent;
                int rate = 0;
                if (radioButton_Rate.Checked == true)
                {
                    rate = 2;
                    if (radioButton_3rate.Checked == true) rate = 3;
                    else if (radioButton_6rata.Checked == true) rate = 6;
                }
                Racun r = p.KreirajRacun(rate);



                for (int i = 0; i < r.Artikli.Count; i++)
                {
                    textBox_Racun.AppendText(r.Artikli[i].ImePregleda);
                    textBox_Racun.AppendText(Environment.NewLine);
                    textBox_Racun.AppendText("Cijena: " + r.Artikli[i].CijenaPregleda);
                    textBox_Racun.AppendText(Environment.NewLine);
                }
                textBox_Racun.AppendText("---------------------------------------");
                textBox_Racun.AppendText(Environment.NewLine);
                textBox_Racun.AppendText("Ukupno za platiti: " + r.UkupanIznos);
                if (rate > 0)
                {
                    textBox_Racun.AppendText(Environment.NewLine);
                    textBox_Racun.AppendText("Platit odmah: " + r.UkupanIznos / rate);
                    Glavna.klinika17280_1.StanjeRacuna += r.UkupanIznos / rate;
                }
                else
                {
                    Glavna.klinika17280_1.StanjeRacuna += r.UkupanIznos;
                }
                textBox_Racun.AppendText(Environment.NewLine);
                if (rate > 0)
                {
                    textBox_Racun.AppendText("Broj rata: " + r.BrojRata);
                    textBox_Racun.AppendText(Environment.NewLine);
                }
                double popust = r.Popust * 100;
                if (popust <= 0)
                    textBox_Racun.AppendText("Popust: " + popust + "%");
                else
                {
                    textBox_Racun.AppendText("Uvecanje: " + popust + "%");
                }
                textBox_Racun.AppendText(Environment.NewLine);
                textBox_Racun.AppendText("Napomena: Popust/Uvecanje su uračunati u ukupan iznos");

                Glavna.IndeksiPacijenataiNaKlinici.RemoveAt(Glavna.IndeksiPacijenataiNaKlinici.FindIndex(i => i == indeks));
                p.NaPregledu = false;
                p.SpisakPregleda.Clear();
                Glavna.klinika17280_1.RegistrovaneOsobe[indeks] = p;
                listBox_TabRacun_MaticniBroj.Items.RemoveAt(listBox_TabRacun_MaticniBroj.SelectedIndex);
                listBox_TabRacun_Pacijent.Items.RemoveAt(listBox_TabRacun_Pacijent.SelectedIndex);

                if (rate > 0)
                {
                    p.DugPacijenta += r.UkupanIznos - r.UkupanIznos / rate;
                    p.BrojPreostalihRata--;
                }
                Glavna.klinika17280_1.RegistrovaneOsobe[indeks] = p;


                toolStripStatusLabelOsoblje.ForeColor = Color.Blue;
                toolStripStatusLabelOsoblje.Text = "Izdali ste račun";
            }
            catch(Exception ex)
            {
                Izuzetak iz = new Izuzetak(TipIzuzetka.Rad_sa_UI_kontrolama, DateTime.Now, Glavna.prijavljeni.KorisnickoIme, ex.Message);
                Glavna.DodajIzuzetak(iz);
                toolStripStatusLabelOsoblje.ForeColor = Color.Red;
                toolStripStatusLabelOsoblje.Text = ex.Message;
            }
        }

        private void button_PromijeniLozinku_Click(object sender, EventArgs e)
        {
            groupBox_PromjenaLozinke.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Jeste li sigurni da se želite odjaviti?", "Odjava", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                this.Hide();
                Prijava prijava = new Prijava();
                prijava.ShowDialog();
            }
        }

        private void buttonPromijeni_Click(object sender, EventArgs e)
        {
            Glavna.prijavljeni.Lozinka = textBox_Nova.Text;


            toolStripStatusLabelOsoblje.Text = "Uspješno ste promijenili lozinku";
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

        private void radioButton_Gotovina_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_Gotovina.Checked==true)
            {
                groupBox_OdabirRata.Visible = false;
            }
        }

        private void promijeniBojuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            DialogResult rez = cd.ShowDialog();
            if (rez == DialogResult.OK)
            {
                tabControl_Osoblje.SelectedTab.BackColor = cd.Color;
            }
        }

        private void button_ObrisiPacijenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBox_MaticniBrojRegistracija.Text)) throw new Exception("Unesite pacijenta");
                DialogResult d = MessageBox.Show("Jeste li sigurni da želite obrisati osobu?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    int indeks = Glavna.klinika17280_1.RegistrovaneOsobe.FindIndex(o => o.MaticniBroj == textBox_MaticniBrojRegistracija.Text);
                    Glavna.klinika17280_1.RegistrovaneOsobe.RemoveAt(indeks);
                    toolStripStatusLabelOsoblje.ForeColor = Color.Blue;
                    toolStripStatusLabelOsoblje.Text = "Obrisali ste pacijenta iz klinike";
                }
            }
            catch(Exception ex)
            {
                Izuzetak iz = new Izuzetak(TipIzuzetka.Rad_sa_UI_kontrolama, DateTime.Now, Glavna.prijavljeni.KorisnickoIme, ex.Message);
                Glavna.DodajIzuzetak(iz);
                toolStripStatusLabelOsoblje.ForeColor = Color.Red;
                toolStripStatusLabelOsoblje.Text = ex.Message;
            }

        }

        private void textBox_MaticniBrojRegistracija_TextChanged(object sender, EventArgs e)
        {
            //Prikazivanje licnih podataka radi potvrde da je unesen ispravan maticni broj
            if (Glavna.klinika17280_1.RegistrovaneOsobe.FindIndex(o => o.MaticniBroj == textBox_MaticniBrojRegistracija.Text)!=-1)
            {
                Pacijent pacijent17280 = Glavna.klinika17280_1.RegistrovaneOsobe.Find(pac => pac.MaticniBroj == textBox_MaticniBrojRegistracija.Text) as Pacijent;
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
            }
        }
    }
}
