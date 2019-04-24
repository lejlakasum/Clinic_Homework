using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnamnezaLibrary;

namespace Zadaca1
{
    public partial class Pacijent : Osoba
    {
        public void promijeniDug(double d)
        {
            if (d >= 0) dugPacijenta = d;
        }
        public override string ispisi()
        {
            string poruka="";
            poruka += "\n--Licni podaci pacijenta--\n";
            poruka+=base.ispisi();
            poruka += "\n--Podaci o pregledima--\n";
            poruka+=kartonPacijenta.ispisi();
            poruka += "\n--Terapija koju pacijent koristi trenutno--\n";
            poruka+=terapijaPacijenta.ispisi();
            poruka += "\nTrenutni dug pacijenta iznosi: " + dugPacijenta + " KM\n";

            return poruka;
        }

        public string ispisiLicnePodatke()
        {
            return("--Licni podaci pacijenta--" + base.ispisi());
        }
        public void dodajPregled(Pregled p)
        {
            kartonPacijenta.dodajPregled(p);
        }

        public string ispisiSpisakPregleda()
        {
            if (spisakPregleda.Count == 0) return ("Pacijent trenutno nema zakazanih pregleda");
            string poruka = "";
                int i = 0;
                foreach (KeyValuePair<Pregled, bool> p in spisakPregleda)
                {
                    poruka=poruka+"\nPregled broj "+i+"\nIme pregleda: "+p.Key.NazivPregleda;
                    if (p.Value == false) poruka+=("\nPregled je zavrsen\n");
                    else poruka+=("\nPacijent ceka na pregled\n");
                    i++;
                }

            return poruka;           
        }

        public void kreirajKarton()
        {
            Anamneza anamneza17280_1 = new Anamneza();
            Console.WriteLine("Unesite sljedece podatke za kreiranje anamneze:");
            Console.Write("Ranije bolesti: "); anamneza17280_1.RanijeBolesti = Console.ReadLine();
            Console.Write("Ranije alergije: "); anamneza17280_1.RanijeAlergije = Console.ReadLine();
            Console.Write("Trenutna bolest: "); anamneza17280_1.TrenutnaBolest = Console.ReadLine();
            Console.Write("Trenutne alergije: "); anamneza17280_1.TrenutneAlergije = Console.ReadLine();
            Console.Write("Zdravstveno stanje u porodici: "); anamneza17280_1.ZdravstvenoStanjePorodice = Console.ReadLine();
            kartonPacijenta.AnamnezaP = anamneza17280_1;
            Console.WriteLine("Uspjesno ste kreirali karton");

        }
    }
}