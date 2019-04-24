using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Zadaca2
{
    public class Glavna
    {
        //Glavna klinika
        public static Klinika klinika17280_1 = new Klinika();
        //Osoba koja je prijavljena na aplikaciju
        public static Osoba prijavljeni = new Osoba();
        //Lista indeksa pacijenata koji su registrovani na portirnici i nalaze se na klinici, a brisu se nakon izdavanja racuna
        //Cuvaju se indeksi umjesto samih pacijenata jer ce omoguciti laksi pronalazak kasnije pacijenta koji konkretno treba
        public static List<int> IndeksiPacijenataiNaKlinici = new List<int>();


        public static void DodajIzuzetak(Izuzetak ex)
        {
            var path = String.Format("{0}\\Logs.txt", AppDomain.CurrentDomain.BaseDirectory);
            if (!File.Exists(path))
            {
                FileStream fs = new FileStream(path.ToString(), FileMode.Create);
                fs.Close();
            }
            FileStream f = new FileStream(path.ToString(), FileMode.Append, FileAccess.Write);
            TextWriter pisac = new StreamWriter(f);
            pisac.WriteLine("{0},{1},{2},{3}", ex.Tip.ToString(), ex.VrijemeNastanka.ToString(), ex.Izazvao, ex.TekstIzuzetka);
            pisac.Flush();
            f.Close();
        }
        public static void registracija()
        {
            klinika17280_1.KlinickeOrdinacije = new List<Ordinacija>
            {
                new Ordinacija(true, "Ordinacija za opstu medicinu"),
                new Ordinacija(true, "Hitna sluzba"),
                new Ordinacija(true, "Ortopedija"),
                new Ordinacija(true, "Kardiologija"),
                new Ordinacija(true, "Dermatologija"),
                new Ordinacija(true, "Internisticka ordinacija"),
                new Ordinacija(true, "Otorinolaringologija"),
                new Ordinacija(true, "Oftamologija"),
                new Ordinacija(true, "Laboratorija"),
                new Ordinacija(true, "Stomatologija")
            };
            klinika17280_1.KlinickeOrdinacije[0].BrojObradjenihPacijenata = 25;
            klinika17280_1.KlinickeOrdinacije[1].BrojObradjenihPacijenata = 17;
            klinika17280_1.KlinickeOrdinacije[4].BrojObradjenihPacijenata = 13;
            klinika17280_1.KlinickeOrdinacije[5].BrojObradjenihPacijenata = 40;
            klinika17280_1.KlinickeOrdinacije[6].BrojObradjenihPacijenata = 17;
            klinika17280_1.KlinickeOrdinacije[7].BrojObradjenihPacijenata = 21;
            klinika17280_1.KlinickeOrdinacije[8].BrojObradjenihPacijenata = 22;
            klinika17280_1.KlinickeOrdinacije[9].BrojObradjenihPacijenata = 11;

            klinika17280_1.KlinickiAparati = new List<Aparat>
            {
                new Aparat(true, "Mjerac krvnog pritiska", klinika17280_1.KlinickeOrdinacije[0]),
                new Aparat(true, "Spirometar", klinika17280_1.KlinickeOrdinacije[0]),
                new Aparat(true, "Ultrazvucni uredjaj", klinika17280_1.KlinickeOrdinacije[0]),
                new Aparat(true, "Aspirator", klinika17280_1.KlinickeOrdinacije[1]),
                new Aparat(true, "Defibrilator", klinika17280_1.KlinickeOrdinacije[1]),
                new Aparat(true, "EKG uredjaj sa monitorom u hitnoj sluzbi", klinika17280_1.KlinickeOrdinacije[1]),
                new Aparat(true, "Artroskop", klinika17280_1.KlinickeOrdinacije[2]),
                new Aparat(true, "EKG uredjaj sa monitorom na kardiologiji", klinika17280_1.KlinickeOrdinacije[3]),
                new Aparat(true, "Ergometar", klinika17280_1.KlinickeOrdinacije[3]),
                new Aparat(true, "Laser", klinika17280_1.KlinickeOrdinacije[4]),
                new Aparat(true, "Ultrazvucni uredjaj", klinika17280_1.KlinickeOrdinacije[5]),
                new Aparat(true, "Audiometar", klinika17280_1.KlinickeOrdinacije[6]),
                new Aparat(true, "Timpanometar", klinika17280_1.KlinickeOrdinacije[6]),
                new Aparat(true, "Perimetar", klinika17280_1.KlinickeOrdinacije[7]),
                new Aparat(true, "Adaptometar", klinika17280_1.KlinickeOrdinacije[7]),
                new Aparat(true, "Optotip", klinika17280_1.KlinickeOrdinacije[7]),
                new Aparat(true, "Mikroskop", klinika17280_1.KlinickeOrdinacije[8]),
                new Aparat(true, "Biohemijski analizator", klinika17280_1.KlinickeOrdinacije[8]),
                new Aparat(true, "Mikroskop", klinika17280_1.KlinickeOrdinacije[8]),
                new Aparat(true, "RTG aparat", klinika17280_1.KlinickeOrdinacije[9]),
                new Aparat(true, "Mikroskop", klinika17280_1.KlinickeOrdinacije[9])
            };

            klinika17280_1.RegistrovaneOsobe = new List<Osoba>
            {
                new Osoba("Admin", "Admin", new DateTime(1995,8,9), "0908199612345","Nikole Tesle 3", Spol.Zensko, BracnoStanje.Neozenjen_Neudata, "l@ba.com", Uloga.Administrator),
                new Doktor("Pete", "Sampras", "Ulica Mister Bina", new DateTime(1960,8,7), "0708196012345", Spol.Musko, BracnoStanje.Zarucen_a, "ps@ba.com", Uloga.Doktor, "Doktor", 2500, klinika17280_1.KlinickeOrdinacije[0], 0 ),
                new Doktor("Maria", "Sharapova", "Ulica Pere Kvrzice", new DateTime(1968,3,1), "0103196812345", Spol.Zensko, BracnoStanje.Neozenjen_Neudata, "ms@ba.com", Uloga.Doktor, "Doktor", 2700, klinika17280_1.KlinickeOrdinacije[1], 0 ),
                new Doktor("Roger", "Federer", "Alpska Ulica", new DateTime(1986,8,8), "0808198612345", Spol.Musko, BracnoStanje.Ozenjen_Udata, "rf@ba.com", Uloga.Doktor, "Doktor", 3500, klinika17280_1.KlinickeOrdinacije[2], 15 ),
                new Doktor("Steffi", "Graf", "Ulica leptirovih krila", new DateTime(1955,11,23), "2311195512345", Spol.Zensko, BracnoStanje.Razveden_a, "sg@ba.com", Uloga.Doktor, "Doktor", 3000, klinika17280_1.KlinickeOrdinacije[3], 13 ),
                new Doktor("Rafael", "Nadal", "Ulica Mahatma Ghandija", new DateTime(1975,5,3), "0305197512345", Spol.Musko, BracnoStanje.Zarucen_a, "rn@ba.com", Uloga.Doktor, "Doktor", 3200, klinika17280_1.KlinickeOrdinacije[4], 7 ),
                new Doktor("Serena", "Wiliams", "Ulica Ive Andrica", new DateTime(1971,10,7), "0710197112345", Spol.Zensko, BracnoStanje.Razveden_a, "sw@ba.com", Uloga.Doktor, "Doktor", 4500, klinika17280_1.KlinickeOrdinacije[5], 25 ),
                new Doktor("Novak", "Djokovic", "Ulica Nelsona Mandele", new DateTime(1949,4,15), "1504194912345", Spol.Musko, BracnoStanje.Ozenjen_Udata, "ndj@ba.com", Uloga.Doktor, "Doktor", 4000, klinika17280_1.KlinickeOrdinacije[6], 45 ),
                new Doktor("Simona", "Halep", "Ulica Martina Luthera Kinga", new DateTime(1966,2,4), "0402196612345", Spol.Zensko, BracnoStanje.Ozenjen_Udata, "sh@ba.com", Uloga.Doktor, "Doktor", 3700, klinika17280_1.KlinickeOrdinacije[7], 1 ),
                new Doktor("Damir", "Dzumhur", "Ulica visockih piramida", new DateTime(1958,12,1), "0112195812345", Spol.Musko, BracnoStanje.Neozenjen_Neudata, "ddz@ba.com", Uloga.Doktor, "Doktor", 5200, klinika17280_1.KlinickeOrdinacije[8], 0 ),
                new Doktor("Monica", "Seles", "Ulica Margaret Court", new DateTime(1960,9,27), "2709196012345", Spol.Zensko, BracnoStanje.Zarucen_a, "mms@ba.com", Uloga.Doktor, "Doktor", 3850, klinika17280_1.KlinickeOrdinacije[9], 0 ),
                new Uposlenik("Kei", "Nishikori", "Drinska", new DateTime(1985,3,2), "0203198512345", Spol.Musko, BracnoStanje.Zarucen_a, "kn@ba.com", Uloga.Medicinsko_osoblje, "Medicinski Tehnicar", 1200),
                new Uposlenik("Martina", "Navratilova", "Ulica Mese Selimovica", new DateTime(1985,3,25), "2503198512345", Spol.Zensko, BracnoStanje.Razveden_a, "mn@ba.com", Uloga.Medicinsko_osoblje, "Medicinski Tehnicar", 1300),
                new Uposlenik("Boris", "Becker", "Ulica Andrea Agassija", new DateTime(1990,12,17), "1712199012345", Spol.Musko, BracnoStanje.Zarucen_a, "bb@ba.com", Uloga.Uprava, "Finansijski direktor", 4200),
                new Uposlenik("Justin", "Henein", "Ulica Stari Most", new DateTime(1988,6,2), "0206198812345", Spol.Zensko, BracnoStanje.Zarucen_a, "jh@ba.com", Uloga.Ostali_Korisnici, "Odnosi s javnoscu", 1800),
                new Uposlenik("Dustin", "Brown", "Rooseveltova", new DateTime(1975,6,16), "1606197512345", Spol.Musko, BracnoStanje.Udovac_ica,"db@ba.com", Uloga.Ostali_Korisnici, "Cistac", 1000),
                new Pacijent("Neko", "Novi", new DateTime(1996,9,9), "1234567891234", "adresa mu njegova", Spol.Musko, BracnoStanje.Ozenjen_Udata, "email@ba.com"),
                new Pacijent("Toni", "Tonic", new DateTime(1996,9,9), "1111111111111", "adresa mu njegova", Spol.Musko, BracnoStanje.Ozenjen_Udata, "email@ba.com")
            };
            
            klinika17280_1.RegistrovaneOsobe[0].Lozinka = "1234567";
            klinika17280_1.RegistrovaneOsobe[12].Lozinka = "1234567";
            klinika17280_1.RegistrovaneOsobe[3].Lozinka = "1234567";
            klinika17280_1.RegistrovaneOsobe[17].Lozinka = "1234567";
            klinika17280_1.RegistrovaneOsobe[13].Lozinka = "1234567";
            Pacijent p = klinika17280_1.RegistrovaneOsobe[17] as Pacijent;
            p.DugPacijenta = 200;
            Glavna.klinika17280_1.StanjeRacuna = 100000;
            


            klinika17280_1.DostupniPregledi = new List<Pregled>
            {
                new Pregled("Sistematski", 150, klinika17280_1.KlinickeOrdinacije[0]),
                new Pregled("Mjerenje krvnog pritiska", 20, klinika17280_1.KlinickeOrdinacije[0]),
                new Pregled("Pruzanje hitne medicinske pomoci", 200, klinika17280_1.KlinickeOrdinacije[1]),
                new Pregled("Ultrazvucni pregled", 100, klinika17280_1.KlinickeOrdinacije[2]),
                new Pregled("Artroskopija", 550, klinika17280_1.KlinickeOrdinacije[2]),
                new Pregled("EKG", 150, klinika17280_1.KlinickeOrdinacije[3]),
                new Pregled("Pregled srca i krvnih sudova", 250, klinika17280_1.KlinickeOrdinacije[3]),
                new Pregled("Dermatoskopski pregled", 200, klinika17280_1.KlinickeOrdinacije[4]),
                new Pregled("Estetske intervencije", 500, klinika17280_1.KlinickeOrdinacije[4]),
                new Pregled("Internisticki pregled", 300, klinika17280_1.KlinickeOrdinacije[5]),
                new Pregled("Pregled uha", 50, klinika17280_1.KlinickeOrdinacije[6]),
                new Pregled("Pregled grla", 70, klinika17280_1.KlinickeOrdinacije[6]),
                new Pregled("Pregled nosa", 50, klinika17280_1.KlinickeOrdinacije[6]),
                new Pregled("Dioptrijski pregled", 150, klinika17280_1.KlinickeOrdinacije[7]),
                new Pregled("Kompletan oftamoloski pregled", 250, klinika17280_1.KlinickeOrdinacije[7]),
                new Pregled("Nalazi krvi", 30, klinika17280_1.KlinickeOrdinacije[8]),
                new Pregled("Stomatoloski pregled", 80, klinika17280_1.KlinickeOrdinacije[9]),
                new Pregled("Popravka", 100, klinika17280_1.KlinickeOrdinacije[9])

            };
        }
        public static Klinika Klinika17280_1 { get => klinika17280_1; set => klinika17280_1 = value; }
    }
}
