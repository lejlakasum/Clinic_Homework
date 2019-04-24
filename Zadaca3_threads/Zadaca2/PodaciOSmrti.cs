using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
    [Serializable]
    public class PodaciOSmrti
    {
        DateTime vrijemeSmrti;
        DateTime vrijemeObdukcije;
        string uzrokSmrti;

        public PodaciOSmrti() { }
        public PodaciOSmrti(DateTime vrijemeSmrti, DateTime vrijemeObdukcije, string uzrokSmrti)
        {
            VrijemeSmrti = vrijemeSmrti;
            VrijemeObdukcije = vrijemeObdukcije;
            UzrokSmrti = uzrokSmrti;
        }

        public DateTime VrijemeSmrti { get => vrijemeSmrti; set => vrijemeSmrti = value; }
        public DateTime VrijemeObdukcije { get => vrijemeObdukcije; set => vrijemeObdukcije = value; }
        public string UzrokSmrti { get => uzrokSmrti; set => uzrokSmrti = value; }

        public override string ToString()
        {
            string rez = "";
            rez += "\nVrijeme smrti: " + VrijemeSmrti.ToShortDateString() +
                 "\nVrijeme obdukcije: " + VrijemeObdukcije.ToShortDateString() +
                 "\nUzrok smrti: " + UzrokSmrti;
            return rez;
        }
    }
}
