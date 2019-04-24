using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
    public enum TipIzuzetka {Rad_sa_datotekama, Rad_sa_bazom, Rad_sa_UI_kontrolama }

    [Serializable]
    public class Izuzetak
    {

        private TipIzuzetka tip;
        DateTime vrijemeNastanka;
        string izazvao;
        string tekstIzuzetka;

        public Izuzetak(TipIzuzetka tip, DateTime vrijemeNastanka, string o, string s)
        {
            Tip = tip;
            VrijemeNastanka = vrijemeNastanka;
            Izazvao = o;
            TekstIzuzetka = s;
            
        }
        public Izuzetak() { }

        public TipIzuzetka Tip { get => tip; set => tip = value; }
        public DateTime VrijemeNastanka { get => vrijemeNastanka; set => vrijemeNastanka = value; }
        public string Izazvao { get => izazvao; set => izazvao = value; }
        public string TekstIzuzetka { get => tekstIzuzetka; set => tekstIzuzetka = value; }

        public override string ToString()
        {
            string rez = "";
            rez += "\nTip: " + Tip.ToString() +
                 "\nVrijeme: " + VrijemeNastanka.ToString() +
                 "\nIzazvao: " + izazvao +
                 "\nGreska: " + TekstIzuzetka;

            return rez;
        }
    }
}
