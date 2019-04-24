using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
    [Serializable]
    public class Ordinacija
    {
        private bool aktivna;
        private string imeOrdinacije;
        private int brojPacijenataNaCekanju = 0;
        private int brojObradjenihPacijenata = 0;
        private List<Tuple<Pacijent,Pregled>> preglediNaCekanju;

        public Ordinacija(bool aktivna, string imeOrdinacije)
        {
            Aktivna = aktivna;
            ImeOrdinacije = imeOrdinacije;
            BrojPacijenataNaCekanju = 0;
            BrojObradjenihPacijenata = 0;
            PreglediNaCekanju = new List<Tuple<Pacijent, Pregled>>();
            
        }
        public Ordinacija()
        {
            BrojPacijenataNaCekanju = 0;
            BrojObradjenihPacijenata = 0;
            PreglediNaCekanju = new List<Tuple<Pacijent, Pregled>>();
        }

        public bool Aktivna { get => aktivna; set => aktivna = value; }
        public string ImeOrdinacije
        {
            get => imeOrdinacije;
            set {
                if (String.IsNullOrWhiteSpace(value)) throw new Exception("Polje ne smije biti prazno");
                imeOrdinacije = value; }
        }

        public int BrojPacijenataNaCekanju
        {
            get => brojPacijenataNaCekanju;
            set
            {
                if (value < 0) throw new Exception("Broj pacijenata na cekanju mora biti pozitivan broj");
                brojPacijenataNaCekanju = value;
            }
        }

        public List<Tuple<Pacijent, Pregled>> PreglediNaCekanju { get => preglediNaCekanju; set => preglediNaCekanju = value; }
        public int BrojObradjenihPacijenata { get => brojObradjenihPacijenata; set => brojObradjenihPacijenata = value; }

        public List<Pacijent> PacijentiNaCekanju()
        {
            List<Pacijent> nova = new List<Pacijent>();
            foreach(Tuple<Pacijent, Pregled> p in PreglediNaCekanju)
            {
                nova.Add(p.Item1);
            }
            return nova;
        }
        public override string ToString()
        {
            string rez = "";
            rez += "Ordinacija: " + ImeOrdinacije;
            return rez;
        }
    }
}
