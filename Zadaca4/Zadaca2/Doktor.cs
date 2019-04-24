using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
    [Serializable]
    public class Doktor : Uposlenik
    {
        private Ordinacija ordinacijaUKojojRadi;
        private int brojPregledanihPacijenata;

        public Doktor(string i, string p, string a, DateTime dr, string mBr, Spol s, BracnoStanje bs, string e, Uloga u, string np, double plata, Ordinacija o, int br) : base(i, p, a, dr, mBr, s, bs, e, u, np, plata)
        {
            OrdinacijaUKojojRadi = o;
            BrojPregledanihPacijenata = br;
        }
        public Doktor() : base() { }
        public Ordinacija OrdinacijaUKojojRadi { get => ordinacijaUKojojRadi; set => ordinacijaUKojojRadi = value; }
        public int BrojPregledanihPacijenata
        {
            get => brojPregledanihPacijenata;
            set
            {
                if (value < 0) throw new Exception("Broj pregledanih pacijenata mora biti pozitivan broj");
                brojPregledanihPacijenata = value;
            }
        }

        public override string ToString()
        {
            string rez = "";
            rez += base.ToString() + "\nOrdinacija u kojoj je zaposlen: " + OrdinacijaUKojojRadi.ImeOrdinacije;
            return rez;
        }
    }
}
