using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Zadaca2
{
    public partial class UcitavanjeOsoba : Form
    {
        public FileStream dat;
        List<Osoba> osobe = new List<Osoba>();

        public UcitavanjeOsoba(FileStream fs)
        {
            InitializeComponent();
            dat = fs;
        }

        private void UcitavanjeOsoba_Load(object sender, EventArgs e)
        {
            try
            {
                IFormatter dser = new BinaryFormatter();
                osobe = dser.Deserialize(dat) as List<Osoba>;
                for (int i = 0; i < osobe.Count; i++)
                {
                    dataGridView1.Rows.Add(osobe[i].Ime, osobe[i].Prezime, osobe[i].DatumRodjenja.ToShortDateString(),
                                            osobe[i].MaticniBroj, osobe[i].Adresa, osobe[i].Spol.ToString(),
                                            osobe[i].BracnoStanje.ToString(), osobe[i].Email, osobe[i].Uloga.ToString());
                }
            }
            catch(Exception ex)
            {
                Izuzetak iz = new Izuzetak(TipIzuzetka.Rad_sa_datotekama, DateTime.Now, Glavna.prijavljeni.KorisnickoIme, ex.Message);
                Glavna.DodajIzuzetak(iz);
                toolStripStatusLabel1.ForeColor = Color.Red;
                toolStripStatusLabel1.Text = ex.Message;
            }
        }

        private void DodajOsobe_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < osobe.Count; i++)
                {
                    string u = osobe[i].Uloga.ToString();
                    switch (u)
                    {
                        case "Administrator":
                            Glavna.klinika17280_1.RegistrovaneOsobe.Add(osobe[i]);
                            break;
                        case "Uprava":
                            Uposlenik up = osobe[i] as Uposlenik;
                            Glavna.klinika17280_1.RegistrovaneOsobe.Add(up);
                            break;
                        case "Doktor":
                            Doktor d = osobe[i] as Doktor;
                            Glavna.klinika17280_1.RegistrovaneOsobe.Add(d);
                            break;
                        case "Medicinsko_osoblje":
                            Uposlenik m = osobe[i] as Uposlenik;
                            Glavna.klinika17280_1.RegistrovaneOsobe.Add(m);
                            break;
                        case "Pacijent":
                            Pacijent p = osobe[i] as Pacijent;
                            Glavna.klinika17280_1.RegistrovaneOsobe.Add(p);
                            break;

                    }
                }
                this.Close();
                MessageBox.Show("Osobe su uspješno dodane u kliniku", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                Izuzetak iz = new Izuzetak(TipIzuzetka.Rad_sa_datotekama, DateTime.Now, Glavna.prijavljeni.KorisnickoIme, ex.Message);
                Glavna.DodajIzuzetak(iz);
                toolStripStatusLabel1.ForeColor = Color.Red;
                toolStripStatusLabel1.Text = ex.Message;
            }
        }

        private void Zatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
