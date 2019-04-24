using System;

namespace Zadaca1
{



    public enum Spol { Musko, Zensko };
    public enum bracnoStanje { Zarucen_a, Ozenjen_Udata, Neozenjen_Neudata, Razveden_a, Udovac_ica };
    public interface Ispisi
    {
        string ispisi();

    }
    public abstract class Osoba : Ispisi
    {
        protected string ime { get; set; }
        protected string prezime { get; set; }
        protected string adresa { get; set; }
        protected DateTime datumRodjenja { get; set; }
        protected int maticniBroj { get; set; }
        protected Spol spol { get; set; }
        protected bracnoStanje bStanje { get; set; }

        public virtual string ispisi()
        {
            return ("\nIme i prezime: "+ime+" "+prezime+
            "\nDatum rodjenja: "+ datumRodjenja.Date +
            "\nMaticni broj: " + maticniBroj +
            "\nAdresa: "+ adresa +
            "\nSpol: "+ spol +
            "\nBracno stanje: "+ bStanje);
        }
    }
}