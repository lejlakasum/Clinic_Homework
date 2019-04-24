using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnamnezaLibrary
{
    public class Anamneza
    {
        private string ranijeBolesti;
        private string ranijeAlergije;
        private string trenutnaBolest;
        private string trenutneAlergije;
        private string zdravstvenoStanjePorodice;

        public string RanijeBolesti
        {
            get { return ranijeBolesti; }
            set { ranijeBolesti = value; }
        }
        public string RanijeAlergije
        {
            get { return ranijeAlergije; }
            set { ranijeAlergije = value; }
        }
        public string TrenutnaBolest
        {
            get { return trenutnaBolest; }
            set { trenutnaBolest = value; }
        }
        public string TrenutneAlergije
        {
            get { return trenutneAlergije; }
            set { trenutneAlergije = value; }
        }
        public string ZdravstvenoStanjePorodice
        {
            get { return zdravstvenoStanjePorodice; }
            set { zdravstvenoStanjePorodice = value; }
        }
        public void ispisi()
        {
            Console.WriteLine("Ranije bolesti pacijenta: {0}", ranijeBolesti);
            Console.WriteLine("Ranije alergije pacijenta: {0}", ranijeAlergije);
            Console.WriteLine("Trenutne bolesti pacijenta: {0}", trenutnaBolest);
            Console.WriteLine("Trenutne alergije pacijenta: {0}", trenutneAlergije);
            Console.WriteLine("Zdravstveno stanje u porodici pacijenta: {0}", zdravstvenoStanjePorodice);
        }

    }
}
