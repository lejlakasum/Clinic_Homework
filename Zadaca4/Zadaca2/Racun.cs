using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
    [Serializable]
    public class Racun
    {
        double ukupanIznos;
        int brojRata;
        double popust;
        List<Pregled> artikli;

        public Racun()
        {
            Artikli = new List<Pregled>();
            BrojRata = 0;
            popust = 0.0;
        }

        public double UkupanIznos
        {
            get => ukupanIznos;
            set
            {
                if (value < 0) throw new Exception("Ukupan iznos mora biti pozitivan broj");
                ukupanIznos = value;
            }
        }
        public int BrojRata { get => brojRata;
            set
            {
                if (value < 0) throw new Exception("Broj rata mora biti pozitivan broj");
                brojRata = value;
            }
            }
        public double Popust { get => popust; set => popust = value; }
        public List<Pregled> Artikli { get => artikli; set => artikli = value; }

        public override string ToString()
        {
            string rez = "";
            foreach(Pregled p in Artikli)
            {
                rez += "\n" + p.ImePregleda + " " + p.CijenaPregleda;
            }
            rez += "\n-----------------------------------------------\n" +
                "Ukupan iznos: " + UkupanIznos +
                "\nBroj preostalih rata: " + BrojRata;
            return rez;
        }
    }
}
