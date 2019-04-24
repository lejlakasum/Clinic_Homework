using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
   public class Klinika
    {
        private double stanjeRacuna;
        private List<Ordinacija> klinickeOrdinacije;
        private List<Aparat> klinickiAparati;
        private List<Osoba> registrovaneOsobe;
        private List<Pregled> dostupniPregledi;

        public Klinika()
        {
            stanjeRacuna = 0;
            KlinickeOrdinacije = new List<Ordinacija>();
            KlinickiAparati = new List<Aparat>();
            RegistrovaneOsobe = new List<Osoba>();
            DostupniPregledi = new List<Pregled>();
        }

        public Klinika(double stanjeRacuna, List<Ordinacija> klinickeOrdinacije, List<Aparat> klinickiAparati, List<Osoba> registrovaneOsobe, List<Pregled> dostupniPregledi)
        {
            StanjeRacuna = stanjeRacuna;
            KlinickeOrdinacije = klinickeOrdinacije;
            KlinickiAparati = klinickiAparati;
            RegistrovaneOsobe = registrovaneOsobe;
            DostupniPregledi = dostupniPregledi;
        }

        public double StanjeRacuna { get => stanjeRacuna; set => stanjeRacuna = value; }
        public List<Ordinacija> KlinickeOrdinacije { get => klinickeOrdinacije; set => klinickeOrdinacije = value; }
        public List<Aparat> KlinickiAparati { get => klinickiAparati; set => klinickiAparati = value; }
        public List<Osoba> RegistrovaneOsobe { get => registrovaneOsobe; set => registrovaneOsobe = value; }
        public List<Pregled> DostupniPregledi { get => dostupniPregledi; set => dostupniPregledi = value; }

        public void registrujPacijenta(Pacijent pacijent17280_1)
        {           
            registrovaneOsobe.Add(pacijent17280_1);           
        }
    }
}
