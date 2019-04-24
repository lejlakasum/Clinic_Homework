using System;

namespace Zadaca1
{
    public class Doktor : Uposlenik
    {
        private Ordinacija ordinacijaUKojojRadi;
        private int brojPregledanihPacijenata;

        public Doktor(string i, string p, string a, DateTime dr, int mBr, Spol s, bracnoStanje bs, string np, double plata, Ordinacija o, int br) : base(i, p, a, dr, mBr, s, bs, np, plata)
        {
            ordinacijaUKojojRadi = o;
            brojPregledanihPacijenata = br;
        }
        public Ordinacija OrdinacijaUKojojRadi
        {
            get { return ordinacijaUKojojRadi; }
            set { ordinacijaUKojojRadi = value; }
        }
        public int BrojPregledanihPacijenata
        {
            get { return brojPregledanihPacijenata; }
            set
            {
                if (value >= 0)
                {
                    brojPregledanihPacijenata = value;
                }
            }
        }
    }
}
