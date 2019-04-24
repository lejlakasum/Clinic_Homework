using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnamnezaLibrary;

namespace Zadaca1
{
    public class Karton
    {
        private Anamneza anamnezaPacijenta;
        private List<Pregled> preglediPacijenta;

        public Karton()
        {
            anamnezaPacijenta = new Anamneza();
            preglediPacijenta = new List<Pregled>();
        }
        public Anamneza AnamnezaP
        {
            get { return anamnezaPacijenta; }
            set { anamnezaPacijenta = value; }
        }
        public List<Pregled> PreglediPacijenta
        {
            get { return preglediPacijenta; }
            set { preglediPacijenta = value; }
        }
        public void dodajPregled(Pregled p)
        {
            preglediPacijenta.Add(p);
            p.PregledObavio.BrojPregledanihPacijenata += 1;
        }
        public void izbrisiPregled(int indeks)
        {
            preglediPacijenta.RemoveAt(indeks);
        }
        public void izbrisiSvePreglede()
        {
            preglediPacijenta.RemoveRange(0, preglediPacijenta.Count);
        }
        public string ispisi()
        {
            anamnezaPacijenta.ispisi();
            if (preglediPacijenta.Count == 0) return ("Karton je prazan!");
            string poruka="";
            

                foreach (Pregled p in preglediPacijenta)
                {
                    poruka += p.ispisi();
                }
            
            return poruka;
        }
    }
}