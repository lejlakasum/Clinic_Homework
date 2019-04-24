using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnamnezaLibrary;

namespace Zadaca1
{
    public class Racun
    {
        private double ukupanIznos;
        private int brojRata;

        Dictionary<Pregled, bool> listaPregleda;

        public int BrojRata
        {
            get { return brojRata; }
            set { brojRata = value; }
        }
        public Racun()
        {
            listaPregleda = new Dictionary<Pregled, bool>();
        }
        public Double UkupanIznos
        {
            get { return ukupanIznos; }
            set { ukupanIznos = value; }
        }

        public Dictionary<Pregled, bool> ListaPregleda
        {
            get { return listaPregleda; }
            set { listaPregleda = value; }
        }


        public string ispisi()
        {
            string poruka = "";
            poruka+="\nNasa Mala Klinika            Racun\n";
            foreach (KeyValuePair<Pregled, bool> p in listaPregleda)
            {
                poruka += p.Key.NazivPregleda + "      " + p.Key.CijenaPregleda;
            }
            poruka+=("\n-----------------------------------------\n");
            poruka+=("\nUKUPAN IZNOS ZA NAPLATU: "+ ukupanIznos);
            if (brojRata > 1)
                poruka+=("Placena je prva rata. Broj preostalih rata je "+ (brojRata - 1));

            return poruka;
        }
    }
}
