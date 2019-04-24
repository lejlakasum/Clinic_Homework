using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
    [Serializable]
    public class Terapija
    {
        private string imeTrapije = null;
        private int trajanjeTerapije;

        public Terapija() { }
        public Terapija(string imeTrapije, int trajanjeTerapije)
        {
            ImeTrapije = imeTrapije;
            TrajanjeTerapije = trajanjeTerapije;
        }

        public string ImeTrapije { get => imeTrapije; set => imeTrapije = value; }
        public int TrajanjeTerapije
        {
            get => trajanjeTerapije;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Trajanje terapije mora biti pozitivan broj");
                trajanjeTerapije = value;
            }
        }

        public override string ToString()
        {
            string rez = "";
            if(ImeTrapije!=null)
            {
                rez += "\nIme terapije: " + ImeTrapije + "\nTrajanje terapije: " + trajanjeTerapije;
            }
            else
            {
                rez = "Pacijent nema propisanu terapiju";
            }

            return rez;
        }
    }
}
