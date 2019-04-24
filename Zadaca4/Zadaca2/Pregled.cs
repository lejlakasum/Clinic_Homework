using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
    [Serializable]
    public class Pregled
    {
        string imePregleda;
        double cijenaPregleda;
        Ordinacija ordinacijaUKojojSeObavlja;

        public Pregled() { }
        public Pregled(string imePregleda, double cijenaPregleda, Ordinacija ordinacijaUKojojSeObavlja)
        {
            ImePregleda = imePregleda;
            CijenaPregleda = cijenaPregleda;
            OrdinacijaUKojojSeObavlja = ordinacijaUKojojSeObavlja;
        }

        public string ImePregleda { get => imePregleda;
            set
            {
                if (String.IsNullOrWhiteSpace(value)) throw new Exception("Polje ne smije biti prazno");
                imePregleda = value;
            }
        }
        public double CijenaPregleda
        {
            get => cijenaPregleda;
            set
            {
                if (value < 0) throw new Exception("Cijena pregleda mora biti pozitivan broj");
                cijenaPregleda = value;
            }
        }
        public Ordinacija OrdinacijaUKojojSeObavlja { get => ordinacijaUKojojSeObavlja; set => ordinacijaUKojojSeObavlja = value; }

        public override string ToString()
        {
            string rez = "";
            rez += "\nIme pregleda: " + ImePregleda +
                 "\nCijena pregleda: " + CijenaPregleda +
                 "\nOrdinacija u kojoj se obavlja: " + OrdinacijaUKojojSeObavlja.ImeOrdinacije;
            return rez;
        }
    }
}
