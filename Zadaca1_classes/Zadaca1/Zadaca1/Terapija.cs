using System;

namespace Zadaca1
{
    public class Terapija
    {
        private string imeTerapije = null;
        private int trajanjeTerapije;

        public Terapija(string ime, int trajanje)
        {
            this.imeTerapije = ime;
            this.trajanjeTerapije = trajanje;
        }
        public Terapija()
        {
            imeTerapije = default(string);
            trajanjeTerapije = default(int);
        }

        public string ImeTerapije
        {
            get { return imeTerapije; }
            set { imeTerapije = value; }
        }
        public int TrajanjeTerapije
        {
            get { return trajanjeTerapije; }
            set
            {
                if (value >= 0) trajanjeTerapije = value;
            }
        }
        public string ispisi()
        {
            if (imeTerapije == null) return("\nTrenutno nema terapija!\n");
            
                return("Terapija " +imeTerapije + " traje " + trajanjeTerapije +" (dani).");

        }
    }
}