using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Zadaca2
{
    
    [Serializable]
    public class Pacijent : Osoba
    {
        private bool naPregledu;
        private Karton kartonPacijenta;
        
        private double dugPacijenta;
        private int brojPreostalihRata;
        private Dictionary<Pregled, bool> spisakPregleda;
        PodaciOSmrti podaciOSmrti = null;
        List<Racun> listaRacuna;

        private Image slika; 

        public Pacijent() : base() { }
        public Pacijent(string i, string p, DateTime dr, string mB, string a, Spol s, BracnoStanje bs, string e)
            :base(i,p,dr,mB,a,s,bs, e, Uloga.Pacijent)
        {
           
            SpisakPregleda = new Dictionary<Pregled, bool>();
            ListaRacuna = new List<Racun>();
            NaPregledu = false;
            DugPacijenta = 0;
            BrojPreostalihRata = 0;
            KartonPacijenta = new Karton();
        } 

        public PodaciOSmrti PodaciOSmrti { get => podaciOSmrti; set => podaciOSmrti = value; }
        public bool NaPregledu { get => naPregledu; set => naPregledu = value; }
        public Karton KartonPacijenta { get => kartonPacijenta; set => kartonPacijenta = value; }
        public double DugPacijenta
        {
            get => dugPacijenta;
            set
            {
                if (value < 0) throw new Exception("Dug mora biti pozitivan broj");
                dugPacijenta = value;
            }
        }
        public int BrojPreostalihRata { get => brojPreostalihRata;
            set
            {
                if (value < 0) throw new Exception("Broj rata mora biti pozitivan broj");
                brojPreostalihRata = value;
            }
            }
        public Dictionary<Pregled, bool> SpisakPregleda { get => spisakPregleda; set => spisakPregleda = value; }
        public List<Racun> ListaRacuna { get => listaRacuna; set => listaRacuna = value; }
        public Image Slika { get => slika; set => slika = value; }

        //Metode

        public override string ToString()
        {
            string rez = "";
            rez+="\n-Licni podaci pacijenta-" + base.ToString() +
                 "\n-Pacijentov karton-" + KartonPacijenta.ToString() +
                 "\n-Dug pacijenta-\n" + DugPacijenta;
            return rez;
        }

        
        
        public void promijeniDug(double d)
        {
            try
            {
                DugPacijenta = d;
            }
            catch(Exception e)
            {
                throw e;
            }
        }
         public void dodajPregled(PacijentovPregled p)
        {
            kartonPacijenta.dodajPregled(p);
        }                
        
        public List<Pregled> VratiSpisakPregledaNaCekanju()
        {
            List<Pregled> novaLista = new List<Pregled>();
            foreach(KeyValuePair<Pregled, bool> p in SpisakPregleda)
            {
                if(p.Value==true)
                {
                    novaLista.Add(p.Key);
                }
            }
            return novaLista;
        }
        public List<Pregled> VratiSpisakObavljenihPregleda()
        {
            List<Pregled> novaLista = new List<Pregled>();
            foreach (KeyValuePair<Pregled, bool> p in SpisakPregleda)
            {
                if (p.Value == false)
                {
                    novaLista.Add(p.Key);
                }
            }
            return novaLista;
        }
        public List<Pregled> VratiSpisakPregleda()
        {
            List<Pregled> novaLista = new List<Pregled>();
            foreach (KeyValuePair<Pregled, bool> p in SpisakPregleda)
            {             
                    novaLista.Add(p.Key);              
            }
            return novaLista;
        }

        public Racun KreirajRacun(int rate)
        {
            Racun r = new Racun();

            r.Artikli = VratiSpisakObavljenihPregleda();
            r.BrojRata = rate;
            if(listaRacuna.Count>=3 && rate==0)
            {
                r.Popust = -0.1;
            }
            else if(listaRacuna.Count<3 && rate>0)
            {
                r.Popust = 0.15;
            }
            BrojPreostalihRata = BrojPreostalihRata + rate;
            
            this.ListaRacuna.Add(r);
            r.UkupanIznos = SaberiCijene(r.Artikli);
            r.UkupanIznos = r.UkupanIznos + r.UkupanIznos * r.Popust;
            
            
            return r;            
        }

        public static double SaberiCijene(List<Pregled> p)
        {
            double suma = 0;
            for(int i=0; i<p.Count; i++)
            {
                suma += p[i].CijenaPregleda;
            }
            return suma;
        }
    }
}
