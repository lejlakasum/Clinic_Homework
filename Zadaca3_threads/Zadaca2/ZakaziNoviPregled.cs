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
    public partial class ZakaziNoviPregled : Form
    {
        int indeksPacijenta;
        public ZakaziNoviPregled(int indeks)
        {
            InitializeComponent();
            indeksPacijenta = indeks;
        }

        private void button_Zatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ZakaziNoviPregled_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Glavna.klinika17280_1.DostupniPregledi.Count; i++)
            {
                checkedListBox_Pregledi.Items.Add(Glavna.klinika17280_1.DostupniPregledi[i].ImePregleda);
            }
        }

        private void button_Zakazi_Click(object sender, EventArgs e)
        {
            Pacijent pacijent17280 = Glavna.klinika17280_1.RegistrovaneOsobe[indeksPacijenta] as Pacijent;
            List<Pregled> listaOdabranihPregleda = new List<Pregled>(); ;
            foreach (KeyValuePair<Pregled, bool> p in pacijent17280.SpisakPregleda)
            {
                if(p.Value==true)
                {
                    listaOdabranihPregleda.Add(p.Key);
                }
            }
            int vecDodani = listaOdabranihPregleda.Count();

            for (int i = 0; i < checkedListBox_Pregledi.CheckedItems.Count; i++)
            {
                Pregled pom = Glavna.klinika17280_1.DostupniPregledi.Find(p => p.ImePregleda == checkedListBox_Pregledi.CheckedItems[i].ToString());
                listaOdabranihPregleda.Add(pom);
                pacijent17280.SpisakPregleda.Add(pom, true);

                int indeksOrdinacije = Glavna.klinika17280_1.KlinickeOrdinacije.FindIndex(o => o.ImeOrdinacije == listaOdabranihPregleda[i+vecDodani].OrdinacijaUKojojSeObavlja.ImeOrdinacije);
                List<Pregled> pom2 = listaOdabranihPregleda.GetRange(0, i+vecDodani);
                if (pom2.Exists(p => p == listaOdabranihPregleda[i+vecDodani]) == false)
                {

                    Glavna.klinika17280_1.KlinickeOrdinacije[indeksOrdinacije].BrojPacijenataNaCekanju++;
                }
                listaOdabranihPregleda[i+vecDodani].OrdinacijaUKojojSeObavlja.PreglediNaCekanju.Add(Tuple.Create(pacijent17280, listaOdabranihPregleda[i+vecDodani]));
            }
            

            //Dodavanje pacijenta u ordinaciju
           
            Glavna.klinika17280_1.RegistrovaneOsobe[indeksPacijenta] = pacijent17280;
            this.Close();
        }
    }
}
