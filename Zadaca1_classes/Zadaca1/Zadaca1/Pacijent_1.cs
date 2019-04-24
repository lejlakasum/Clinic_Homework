using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnamnezaLibrary;

namespace Zadaca1
{


    public partial class Pacijent : Osoba
    {
        protected bool naPregledu;
        protected Karton kartonPacijenta;
        protected Terapija terapijaPacijenta;
        protected double dugPacijenta;
        protected int brojPreostalihRata;
        protected Dictionary<Pregled, bool> spisakPregleda;

        public Pacijent()
        {
            ime = default(string);
            prezime = default(string);
            adresa = default(string);
            datumRodjenja = default(DateTime);
            maticniBroj = default(int);
            spol = default(Spol);
            bStanje = default(bracnoStanje);
            NaPregledu = default(bool);
            kartonPacijenta = new Karton();
            terapijaPacijenta = new Terapija();
            dugPacijenta = default(double);
            brojPreostalihRata = 0;
            spisakPregleda = new Dictionary<Pregled, bool>();

        }

        public int BrojPreostalihRata
        {
            get { return brojPreostalihRata; }
            set { brojPreostalihRata = value; }
        }
        public Dictionary<Pregled, bool> SpisakPregleda
        {
            get { return spisakPregleda; }
            set { spisakPregleda = value; }
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
        public bool NaPregledu
        {
            get { return naPregledu; }
            set { naPregledu = value; }
        }
        public Karton KartonPacijenta
        {
            get { return kartonPacijenta; }
            set { kartonPacijenta = value; }
        }
        public Terapija TerapijaPacijenta
        {
            get { return terapijaPacijenta; }
            set { terapijaPacijenta = value; }
        }
        public double DugPacijenta
        {
            get { return dugPacijenta; }
            set
            {
                if (value >= 0) dugPacijenta = value;
            }
        }



    }
}
