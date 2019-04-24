using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnamnezaLibrary;

namespace Zadaca1
{
    public class Ordinacija
    {
        bool aktivna;
        private string imeOrdinacije;
        private int brojPacijenataNaCekanju;
        private int brojObradjenihPacijenata;
        Dictionary<Pacijent, Pregled> preglediNaCekanju;

        public Ordinacija() { }
        public Ordinacija(bool a, string ime, int br)
        {
            aktivna = a;
            imeOrdinacije = ime;
            brojPacijenataNaCekanju = br;
            preglediNaCekanju = new Dictionary<Pacijent, Pregled>();
            brojObradjenihPacijenata = 0;
        }
        public int BrojObradjenihPacijenata
        {
            get { return brojObradjenihPacijenata; }
            set { brojObradjenihPacijenata = value; }
        }
        public Dictionary<Pacijent, Pregled> PreglediNaCekanju
        {
            get { return preglediNaCekanju; }
            set { preglediNaCekanju = value; }
        }
        public bool Aktivna
        {
            get { return aktivna; }
            set { aktivna = value; }
        }
        public string ImeOrdinacije
        {
            get { return imeOrdinacije; }
            set { imeOrdinacije = value; }
        }
        public int BrojPacijenataNaCekanju
        {
            get { return brojPacijenataNaCekanju; }
            set
            {
                if (value >= 0) brojPacijenataNaCekanju = value;
            }
        }
        public string ispisiListuCekanja()
        {
            if (preglediNaCekanju.Count == 0) return ("Lista cekanja je prazna");

            string poruka = "";
           foreach (KeyValuePair<Pacijent, Pregled> p in preglediNaCekanju)
           {
               poruka+=("\nIme i prezime: "+p.Key.Ime+" "+ p.Key.Prezime+"\nPregled: "+p.Value.NazivPregleda+"\n");
           }
            return poruka; 
        }
    }

}
