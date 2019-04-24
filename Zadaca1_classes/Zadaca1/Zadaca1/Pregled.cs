using System;

namespace Zadaca1
{
    public class Pregled
    {
        private string nazivPregleda;
        private DateTime datumPregleda;
        private string rezultatPregleda;
        private string misljenjeDoktora;
        private Doktor pregledObavio;
        private double cijenaPregleda;
        private Ordinacija ordinacijaUKojojSeObavlja;

        public Pregled(string ime, double cijena, Ordinacija o)
        {
            nazivPregleda = ime;
            datumPregleda = default(DateTime);
            cijenaPregleda = cijena;
            ordinacijaUKojojSeObavlja = o;
        }
        public Pregled()
        {

        }
        Pregled(string n, DateTime d, string r, string m, Doktor p, double c)
        {
            this.nazivPregleda = n;
            this.datumPregleda = d;
            this.rezultatPregleda = r;
            this.misljenjeDoktora = m;
            this.pregledObavio = p;
            this.cijenaPregleda = c;
            ordinacijaUKojojSeObavlja = new Ordinacija();
        }

        public Ordinacija OrdinacijaUKojojSeObavlja
        {
            get { return ordinacijaUKojojSeObavlja; }
            set { ordinacijaUKojojSeObavlja = value; }
        }

        public string NazivPregleda
        {
            get { return nazivPregleda; }
            set { nazivPregleda = value; }
        }
        public DateTime DatumPregleda
        {
            get { return datumPregleda; }
            set { datumPregleda = value; }
        }
        public string RezultatPregleda
        {
            get { return rezultatPregleda; }
            set { rezultatPregleda = value; }
        }
        public string MisljenjeDoktora
        {
            get { return misljenjeDoktora; }
            set { misljenjeDoktora = value; }
        }

        public Doktor PregledObavio
        {
            get { return pregledObavio; }
            set { pregledObavio = value; }
        }
        public double CijenaPregleda
        {
            get { return cijenaPregleda; }
            set
            {
                if (value >= 0) cijenaPregleda = value;
            }
        }

        public string ispisi()
        {
            return("\nPregled: "+ nazivPregleda+
            "\nObavljen na datum: "+ datumPregleda +
            "\nRezultat: "+ rezultatPregleda+
            "\nPregled obavio: "+pregledObavio.Ime + " " + pregledObavio.Prezime+ 
            "\nMisljenje doktora: "+ misljenjeDoktora);
        }
        




    }
}