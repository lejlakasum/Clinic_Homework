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
    public partial class UpravaPanel : Form
    {
        public UpravaPanel()
        {
            InitializeComponent();
        }

        private void UpravaPanel_Load(object sender, EventArgs e)
        {
            chart1.Series["Serija"].IsVisibleInLegend = false;
            panel1.BackColor = Color.DeepSkyBlue;
           
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            chart1.Titles[0].Name = "Posjećenost ordinacija";
            chart1.Visible = true;
            foreach(Ordinacija o in Glavna.klinika17280_1.KlinickeOrdinacije)
            {

                chart1.Series["Serija"].Points.AddXY(o.ImeOrdinacije, o.BrojObradjenihPacijenata);
                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prijava p = new Prijava();
            p.ShowDialog();
            
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            chart1.Titles[0].Name = "Posjećenost doktora";
            chart1.Visible = true;

            foreach (Osoba o in Glavna.klinika17280_1.RegistrovaneOsobe)
            {
                if (o is Doktor)
                {
                    Doktor d = o as Doktor;
                    chart1.Series["Serija"].Points.AddXY(d.Ime+ " " + d.Prezime, d.BrojPregledanihPacijenata);
                    chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            chart1.Visible = false;

            List<Pacijent> pacijenti= new List<Pacijent>();
            foreach(Osoba o in Glavna.klinika17280_1.RegistrovaneOsobe)
            {
                if(o is Pacijent)
                {
                    pacijenti.Add(o as Pacijent);
                }
            }
            pacijenti.Sort(delegate (Pacijent prvi, Pacijent drugi)
            {
                return prvi.ListaRacuna.Count.CompareTo(drugi.ListaRacuna.Count);
            });
            label1.Text = pacijenti[pacijenti.Count - 1].Ime;
            label2.Text = pacijenti[pacijenti.Count - 1].Prezime;
            label3.Text = pacijenti[pacijenti.Count - 1].ListaRacuna.Count.ToString();

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            chart1.Titles[0].Name = "Dug pacijenata";
            chart1.Visible = true;
            foreach (Osoba o in Glavna.klinika17280_1.RegistrovaneOsobe)
            {
                if (o is Pacijent)
                {
                    Pacijent p = o as Pacijent;
                    chart1.Series["Serija"].Points.AddXY(p.Ime + " " + p.Prezime, p.DugPacijenta);
                    chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            chart1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;

            label3.Text = Glavna.klinika17280_1.StanjeRacuna.ToString();
            label3.Visible = true;
        }

        private void button_ObracunajMjesec_Click(object sender, EventArgs e)
        {
            chart1.Visible = false;
            double ukupnoRashodi = 0;
            double ukupnoPrihodi = 0;


                int i = 0;
                foreach(Osoba o in Glavna.klinika17280_1.RegistrovaneOsobe.ToList())
                {
                    if (o is Pacijent)
                    {
                        Pacijent p = o as Pacijent;
                    if (p.BrojPreostalihRata > 0)
                    {
                        ukupnoPrihodi += p.DugPacijenta / p.BrojPreostalihRata;
                        p.DugPacijenta -= p.DugPacijenta / p.BrojPreostalihRata;
                        p.BrojPreostalihRata--;
                        Glavna.klinika17280_1.RegistrovaneOsobe[i] = p;
                    }
                    }
                i++;
                }

            i = 0;
            foreach(Osoba o in Glavna.klinika17280_1.RegistrovaneOsobe.ToList())
            {
                if (o is Doktor)
                {
                    Doktor d = o as Doktor;
                    if (d.BrojPregledanihPacijenata <= 20)
                    {
                        ukupnoRashodi += d.PlataUposlenika + d.BrojPregledanihPacijenata * 20;
                    }
                    else
                    {
                        ukupnoRashodi += d.PlataUposlenika + 400;
                    }
                    Glavna.klinika17280_1.RegistrovaneOsobe[i] = d;
                }
                i++;

            }
            foreach(Osoba o in Glavna.klinika17280_1.RegistrovaneOsobe)
            {
                if (o is Uposlenik)
                {
                    Uposlenik u = o as Uposlenik;
                    ukupnoRashodi += u.PlataUposlenika;
                }
            }
            Glavna.klinika17280_1.StanjeRacuna += ukupnoPrihodi - ukupnoRashodi;

            label1.Text = "Rashodi: " + ukupnoRashodi;
            label2.Text = "Prihodi: " + ukupnoPrihodi;
            label3.Text = "Stanje: " + Glavna.klinika17280_1.StanjeRacuna;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;


        }
    }
}
