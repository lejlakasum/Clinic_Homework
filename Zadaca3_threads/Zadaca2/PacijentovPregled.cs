using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
    [Serializable]
    public class PacijentovPregled 
    {
        [System.Xml.Serialization.XmlIgnore]
        Pregled pregledKojiSeObavlja;
        DateTime datumPregleda;
        Doktor pregledObavio;
        string rezultatPregleda;
        string misljenjeDoktora;
        Terapija terapijaUzPregled;

        public PacijentovPregled() { }
        public PacijentovPregled(Pregled pregledKojiSeObavlja, DateTime datumPregleda, Doktor pregledObavio, string rezultatPregleda, string misljenjeDoktora, Terapija t)
        {
            PregledKojiSeObavlja = pregledKojiSeObavlja;
            DatumPregleda = datumPregleda;
            PregledObavio = pregledObavio;
            RezultatPregleda = rezultatPregleda;
            MisljenjeDoktora = misljenjeDoktora;
            TerapijaUzPregled = t;
        }

        public DateTime DatumPregleda { get => datumPregleda; set => datumPregleda = value; }
        public Doktor PregledObavio { get => pregledObavio; set => pregledObavio = value; }
        public string RezultatPregleda { get => rezultatPregleda; set => rezultatPregleda = value; }
        public string MisljenjeDoktora { get => misljenjeDoktora; set => misljenjeDoktora = value; }
        public Pregled PregledKojiSeObavlja { get => pregledKojiSeObavlja; set => pregledKojiSeObavlja = value; }
        public Terapija TerapijaUzPregled { get => terapijaUzPregled; set => terapijaUzPregled = value; }

        public override string ToString()
        {
            string rez = "";
            rez += "\nPregled: " + pregledKojiSeObavlja.ImePregleda +
                   "\nDatum pregleda: " + DatumPregleda.ToShortDateString() +
                   "\nDoktor: " + PregledObavio.Ime +
                   "\nRezultat pregleda: " + RezultatPregleda +
                   "\nMisljenje doktora: " + MisljenjeDoktora;
            return rez;
        }
    }
}
