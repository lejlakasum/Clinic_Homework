using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
    [Serializable]
    public class Anamneza
    {
        private string ranijeBolesti;
        private string ranijeAlergije;
        private string trenutnaBolest;
        private string trenutneAlergije;

        public Anamneza() { }
        public Anamneza(string ranijeBolesti, string ranijeAlergije, string trenutnaBolest, string trenutneAlergije)
        {
            RanijeBolesti = ranijeBolesti;
            RanijeAlergije = ranijeAlergije;
            TrenutnaBolest = trenutnaBolest;
            TrenutneAlergije = trenutneAlergije;
        }

        public string RanijeBolesti { get => ranijeBolesti; set => ranijeBolesti = value; }
        public string RanijeAlergije { get => ranijeAlergije; set => ranijeAlergije = value; }
        public string TrenutnaBolest { get => trenutnaBolest; set => trenutnaBolest = value; }
        public string TrenutneAlergije { get => trenutneAlergije; set => trenutneAlergije = value; }

        public override string ToString()
        {
            string rez = "";
            rez += "\nRanije bolesti: " + RanijeBolesti +
                   "\nRanije alergije: " + RanijeAlergije +
                   "\nTrenutna bolest: " + TrenutnaBolest +
                   "\nTrenutne alergije: " + TrenutneAlergije;
            return rez;
        }
    }

    
}
