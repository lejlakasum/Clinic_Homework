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
    public partial class Prijava : Form
    {
        public Prijava()
        {
            InitializeComponent();
        }

        private void Prijava_Load(object sender, EventArgs e)
        {
            toolStripStatusPrijava.ForeColor = Color.Blue;
            toolStripStatusPrijava.Text = "Dobrodošli";
            this.ActiveControl = textBox_KorisnickoIme;

        }

        private void button_Zatvori_Click(object sender, EventArgs e)
        {
           
            this.Close();
          
        }

        private void statusStrip_Prijava_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void button_Prijava_Click(object sender, EventArgs e)
        {
            string kime = textBox_KorisnickoIme.Text;
            string lozinka = Osoba.Kodiraj(textBoxLozinka.Text);

           
                
            int i;
            for (i=0; i<Glavna.Klinika17280_1.RegistrovaneOsobe.Count(); i++)
            {
                if(Glavna.Klinika17280_1.RegistrovaneOsobe[i].KorisnickoIme==kime &&
                    Glavna.Klinika17280_1.RegistrovaneOsobe[i].Lozinka==lozinka)
                {
                    Glavna.prijavljeni = Glavna.klinika17280_1.RegistrovaneOsobe[i];
                    if (Glavna.klinika17280_1.RegistrovaneOsobe[i].Uloga == Uloga.Administrator)
                    {
                        AdminPanel adminForma = new AdminPanel();
                        this.Hide();
                        adminForma.ShowDialog();
                    }
                    else if(Glavna.klinika17280_1.RegistrovaneOsobe[i].Uloga==Uloga.Medicinsko_osoblje)
                    {
                        OsobljePanel osobljePanel = new OsobljePanel();
                        this.Hide();
                        osobljePanel.ShowDialog();
                    }
                    else if (Glavna.klinika17280_1.RegistrovaneOsobe[i].Uloga == Uloga.Doktor)
                    {
                        DoktorPanel doktorPanel = new DoktorPanel();
                        this.Hide();
                        doktorPanel.ShowDialog();
                    }
                    else if (Glavna.klinika17280_1.RegistrovaneOsobe[i].Uloga == Uloga.Pacijent)
                    {
                        PacijentovPanel pacPanel = new PacijentovPanel();
                        this.Hide();
                        pacPanel.ShowDialog();
                    }
                    else if (Glavna.klinika17280_1.RegistrovaneOsobe[i].Uloga == Uloga.Uprava)
                    {
                        UpravaPanel uprava = new UpravaPanel();
                        this.Hide();
                        uprava.ShowDialog();
                    }

                }

            }

            toolStripStatusPrijava.ForeColor = Color.Red;
            toolStripStatusPrijava.Text = ("Pogresni pristupni podaci");
            
        }

        private void Prijava_Paint(object sender, PaintEventArgs e)
        {
            Graphics logo;
            logo = this.CreateGraphics();

            Pen olovka = new Pen(Color.DarkRed, 5);
            olovka.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
           
            logo.DrawEllipse(olovka, 20, 70, 200, 150);
            //logo.FillEllipse(b, 105, 130, 30, 30);

            olovka = new Pen(Color.DarkRed, 2);
            logo.DrawLine(olovka, 20, 130, 35 ,160 );
            logo.DrawLine(olovka, 35, 160, 45, 110);
            logo.DrawLine(olovka, 45, 110, 60, 180);
            logo.DrawLine(olovka, 60, 180, 70, 120);
            logo.DrawLine(olovka, 70, 120, 80, 145);
            olovka = new Pen(Color.DarkRed, 15);
            logo.DrawLine(olovka, 80, 145, 150, 145);
            olovka = new Pen(Color.DarkRed, 2);
            logo.DrawLine(olovka, 150, 145, 160, 115);
            logo.DrawLine(olovka, 160, 115, 170, 175);
            logo.DrawLine(olovka, 170, 175, 180, 100);
            logo.DrawLine(olovka, 180, 100, 195, 145);
            logo.DrawLine(olovka,195, 145, 220, 145);
            olovka = new Pen(Color.DarkRed, 15);
            logo.DrawLine(olovka, 115, 110, 115, 180);
        }

        private void button_Info_Click(object sender, EventArgs e)
        {
            Info i = new Info();
            i.ShowDialog();
        }
    }
}
