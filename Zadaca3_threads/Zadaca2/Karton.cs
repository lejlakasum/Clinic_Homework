using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
    [Serializable]
    public class Karton
    {
        Anamneza anamnezaPacijenta;
        List<PacijentovPregled> listaPregleda;

        public Karton()
        {
            AnamnezaPacijenta = new Anamneza();
            ListaPregleda = new List<PacijentovPregled>();
        }

        public Anamneza AnamnezaPacijenta { get => anamnezaPacijenta; set => anamnezaPacijenta = value; }
        public List<PacijentovPregled> ListaPregleda { get => listaPregleda; set => listaPregleda = value; }

        public void dodajPregled(PacijentovPregled p)
        {
            ListaPregleda.Add(p);
            p.PregledObavio.BrojPregledanihPacijenata += 1;
        }
        public void izbrisiPregled(int indeks)
        {
            ListaPregleda.RemoveAt(indeks);
        }
        public void izbrisiSvePreglede()
        {
            ListaPregleda.RemoveRange(0, ListaPregleda.Count);
        }

        public override string ToString()
        {
            string rez = "";
            rez += AnamnezaPacijenta.ToString();
            for(int i=0; i<ListaPregleda.Count(); i++)
            {
                rez += "\n";
                rez += ListaPregleda[i].ToString();
            }
            return rez;
        }
    }
}
