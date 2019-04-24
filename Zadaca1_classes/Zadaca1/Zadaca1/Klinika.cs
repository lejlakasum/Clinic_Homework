using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnamnezaLibrary;

namespace Zadaca1
{
    public class Klinika
    {
        private double stanjeRacuna;
        private List<Ordinacija> klinickeOrdinacije;
        private List<Aparat> klinickiAparati;
        private List<Doktor> klinickiDoktori;
        private List<Uposlenik> ostaliUposlenici;
        private List<Pacijent> evidentiraniPacijenti;
        private List<Pregled> dostupniPregledi;

        public double StanjeRacuna
        {
            get { return stanjeRacuna; }
            set { stanjeRacuna = value; }
        }
        public Klinika()
        {
            this.klinickeOrdinacije = new List<Ordinacija>();
            this.klinickiAparati = new List<Aparat>();
            this.klinickiDoktori = new List<Doktor>();
            this.ostaliUposlenici = new List<Uposlenik>();
            this.evidentiraniPacijenti = new List<Pacijent>();
            dostupniPregledi = new List<Pregled>();
            stanjeRacuna = 0;
        }
        public Klinika(List<Ordinacija> o, List<Aparat> a, List<Doktor> d, List<Uposlenik> u, List<Pacijent> p)
        {
            klinickeOrdinacije = o;
            klinickiAparati = a;
            klinickiDoktori = d;
            ostaliUposlenici = u;
            evidentiraniPacijenti = p;

        }
        public List<Ordinacija> KlinickeOrdinacije
        {
            get { return klinickeOrdinacije; }
            set { klinickeOrdinacije = value; }
        }
        public List<Aparat> KlinickiAparati
        {
            get { return klinickiAparati; }
            set { klinickiAparati = value; }
        }
        public List<Doktor> KlinickiDoktori
        {
            get { return klinickiDoktori; }
            set { klinickiDoktori = value; }
        }
        public List<Uposlenik> OstaliUposlenici
        {
            get { return ostaliUposlenici; }
            set { ostaliUposlenici = value; }
        }
        public List<Pacijent> EvidentiraniPacijenti
        {
            get { return evidentiraniPacijenti; }
            set { evidentiraniPacijenti = value; }
        }

        public List<Pregled> DostupniPregledi
        {
            get { return dostupniPregledi; }
            set { dostupniPregledi = value; }
        }

        public void dodajPacijenta(Pacijent pacijent17280_1)
        {
            evidentiraniPacijenti.Add(pacijent17280_1);
        }

        public string prikaziSpisakPacijenata()
        {
            string poruka = "";

            for (int i = 0; i < evidentiraniPacijenti.Count; i++)
            {
                poruka += ("Broj " + 1 + ")\n" +
                         evidentiraniPacijenti[i].Ime + "\n" +
                         evidentiraniPacijenti[i].Prezime + "\n" +
                         evidentiraniPacijenti[i].MaticniBroj + "\n");
                if (evidentiraniPacijenti[i].NaPregledu == true) poruka+=("\nPacijent je trenutno na pregledima\n");
                else poruka+=("\nPacijent trenutno nije u klinici\n");
            }
            return poruka;
        }

        public string prikaziSpisakAktivnihPacijenata()
        {
            int brojac = 0; string poruka = "";
            for (int i = 0; i < evidentiraniPacijenti.Count; i++)

                if (evidentiraniPacijenti[i].NaPregledu == true)
                {
                    brojac++;
                    poruka += ("Broj " + i + ")\n" +
                                  evidentiraniPacijenti[i].Ime + "\n" +
                                  evidentiraniPacijenti[i].Prezime + "\n" +
                                  evidentiraniPacijenti[i].MaticniBroj + "\n");
                }
            if (brojac == 0) { return("Nema pacijenata koji cekaju na preglede!");  }
            return poruka;
        }
        public string prikaziSpisakDostupnihPregleda()
        {
            string poruka = "";
            for (int i = 0; i < dostupniPregledi.Count; i++)
            {
                poruka+=("\nPregled broj: "+i+ " "+dostupniPregledi[i].NazivPregleda);
            }
            return poruka;
        }


        public string ispisiDoktore()
        {
            int i = 0; string poruka = "";
            foreach (Doktor d in klinickiDoktori)
            {
                poruka+=("\nBroj "+i+"\n"+d.Ime+" "+d.Prezime);
                i++;
            }
            return poruka;
        }

        public string ispisiOrdinacije()
        {
            string poruka = "";
            for (int i = 0; i < klinickeOrdinacije.Count; i++)
            {
                poruka+=("\nOrdinacija broj "+i+"\n{"+klinickeOrdinacije[i].ImeOrdinacije);
            }
            return poruka;
        }

        public string ispisiAparate()
        {
            string poruka = "";
            for (int i = 0; i < klinickiAparati.Count; i++)
            {
                poruka+=("\nOrdinacija broj "+i+"\n"+ klinickiAparati[i].ImeAparata);
            }
            return poruka;
        }

    }
}
