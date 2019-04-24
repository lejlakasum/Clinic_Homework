using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{

   
    [Serializable]
    public class Uposlenik : Osoba
    {
        private double plataUposlenika;
        private string nazivPozicije;

        public Uposlenik() : base() { }
        public Uposlenik(string i, string p, string a, DateTime dr, string mBr, Spol s, BracnoStanje bs, string e, Uloga u, string np, double plata)
            :base(i,p,dr,mBr,a, s, bs, e, u)
        {
            NazivPozicije = np;
            PlataUposlenika = plata;
        }

        public string NazivPozicije { get => nazivPozicije; set => nazivPozicije = value; }

        public double PlataUposlenika
        {
            get => plataUposlenika;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Plata mora biti pozitivan broj");
                plataUposlenika = value;
            }
        }
    }
}
