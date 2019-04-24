using System;

namespace Zadaca1
{
    public class Uposlenik : Osoba
    {
        protected string nazivPozicije;
        protected double plataUposlenika;

        public Uposlenik(string i, string p, string a, DateTime dr, int mBr, Spol s, bracnoStanje bs, string np, double plata)
        {
            ime = i;
            prezime = p;
            adresa = a;
            datumRodjenja = dr;
            maticniBroj = mBr;
            spol = s;
            bStanje = bs;
            nazivPozicije = np;
            plataUposlenika = plata;

        }
        public string NazivPozicije
        {
            get { return nazivPozicije; }
            set { nazivPozicije = value; }
        }
        public double PlataUposlenika
        {
            get { return plataUposlenika; }
            set
            {
                if (value >= 0)
                {
                    plataUposlenika = value;
                }
            }
        }

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
        public string Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }
        public DateTime DatumRodjenja
        {
            get { return datumRodjenja; }
            set { datumRodjenja = value; }
        }
        public int MaticniBroj
        {
            get { return maticniBroj; }
            set { maticniBroj = value; }
        }
        public Spol spoL
        {
            get { return spol; }
            set { spol = value; }

        }
        public bracnoStanje BStanje
        {
            get { return bStanje; }
            set { bStanje = value; }
        }
    }
}
