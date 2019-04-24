using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnamnezaLibrary;


namespace Zadaca1
{
    class GlavniProgram
    { 

        
               
        static void Main(string[] args)
        {
            Klinika klinika17280_1=new Klinika();
            klinika17280_1.KlinickeOrdinacije = new List<Ordinacija>
            {
                new Ordinacija(true, "Ordinacija za opstu medicinu", 0),
                new Ordinacija(true, "Hitna sluzba",0),
                new Ordinacija(true, "Ortopedija", 0),
                new Ordinacija(true, "Kardiologija", 0),
                new Ordinacija(true, "Dermatologija", 0),
                new Ordinacija(true, "Internisticka ordinacija", 0),
                new Ordinacija(true, "Otorinolaringologija", 0),
                new Ordinacija(true, "Oftamologija", 0),
                new Ordinacija(true, "Laboratorija", 0),
                new Ordinacija(true, "Stomatologija", 0)
            };
            
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

            klinika17280_1.KlinickiDoktori = new List<Doktor>
            {
                new Doktor("Pete", "Sampras", "Ulica Mister Bina", new DateTime(1960,8,7), 07081960, Spol.Musko, bracnoStanje.Zarucen_a, "Doktor", 2500, klinika17280_1.KlinickeOrdinacije[0], 0 ),
                new Doktor("Maria", "Sharapova", "Ulica Pere Kvrzice", new DateTime(1968,3,1), 01031968, Spol.Zensko, bracnoStanje.Neozenjen_Neudata, "Doktor", 2700, klinika17280_1.KlinickeOrdinacije[1], 0 ),
                new Doktor("Roger", "Federer", "Alpska Ulica", new DateTime(1986,8,8), 08081986, Spol.Musko, bracnoStanje.Ozenjen_Udata, "Doktor", 3500, klinika17280_1.KlinickeOrdinacije[2], 0 ),
                new Doktor("Steffi", "Graf", "Ulica leptirovih krila", new DateTime(1955,11,23), 23111955, Spol.Zensko, bracnoStanje.Razveden_a, "Doktor", 3000, klinika17280_1.KlinickeOrdinacije[3], 0 ),
                new Doktor("Rafael", "Nadal", "Ulica Mahatma Ghandija", new DateTime(1975,5,3), 03051975, Spol.Musko, bracnoStanje.Zarucen_a, "Doktor", 3200, klinika17280_1.KlinickeOrdinacije[4], 0 ),
                new Doktor("Serena", "Wiliams", "Ulica Ive Andrica", new DateTime(1971,10,7), 07101971, Spol.Zensko, bracnoStanje.Razveden_a, "Doktor", 4500, klinika17280_1.KlinickeOrdinacije[5], 0 ),
                new Doktor("Novak", "Djokovic", "Ulica Nelsona Mandele", new DateTime(1949,4,15), 1541949, Spol.Musko, bracnoStanje.Ozenjen_Udata, "Doktor", 4000, klinika17280_1.KlinickeOrdinacije[6], 0 ),
                new Doktor("Simona", "Halep", "Ulica Martina Luthera Kinga", new DateTime(1966,2,4), 04021966, Spol.Zensko, bracnoStanje.Ozenjen_Udata, "Doktor", 3700, klinika17280_1.KlinickeOrdinacije[7], 0 ),
                new Doktor("Damir", "Dzumhur", "Ulica visockih piramida", new DateTime(1958,12,1), 01121958, Spol.Musko, bracnoStanje.Neozenjen_Neudata, "Doktor", 5200, klinika17280_1.KlinickeOrdinacije[8], 0 ),
                new Doktor("Monica", "Seles", "Ulica Margaret Court", new DateTime(1960,9,27), 27091960, Spol.Zensko, bracnoStanje.Zarucen_a, "Doktor", 3850, klinika17280_1.KlinickeOrdinacije[9], 0 )

            };

            klinika17280_1.OstaliUposlenici = new List<Uposlenik>
            {
                new Uposlenik("Kei", "Nishikori", "Drinska", new DateTime(1985,3,2), 02031985, Spol.Musko, bracnoStanje.Zarucen_a, "Medicinski Tehnicar", 1200),
                new Uposlenik("Martina", "Navratilova", "Ulica Mese Selimovica", new DateTime(1985,3,25), 25031985, Spol.Zensko, bracnoStanje.Razveden_a, "Medicinski Tehnicar", 1300),
                new Uposlenik("Boris", "Becker", "Ulica Andrea Agassija", new DateTime(1990,12,17), 17121990, Spol.Musko, bracnoStanje.Zarucen_a, "Finansijski direktor", 4200),
                new Uposlenik("Justin", "Henein", "Ulica Stari Most", new DateTime(1988,6,2), 02061988, Spol.Zensko, bracnoStanje.Zarucen_a, "Odnosi s javnoscu", 1800),
                new Uposlenik("Dustin", "Brown", "Rooseveltova", new DateTime(1975,6,16), 16061975, Spol.Musko, bracnoStanje.Udovac_ica, "Cistac", 1000)
            };

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
            

            int odabir;
            do
            {
                Console.WriteLine("Dobrodosli! Odaberite jednu od opcija:\n" +
                                  "1. Registruj/Brisi pacijenta\n" +
                                  "2. Prikazi raspored pregleda pacijenta\n" +
                                  "3. Kreiranje kartona pacijenta\n" +
                                  "4. Pretraga kartona pacijenta\n" +
                                  "5. Registruj novi pregled\n" +
                                  "6. Analiza sadrzaja\n" +
                                  "7. Naplata\n" +
                                  "8. Izlaz\n" +
                                  "9. Dodatne opcije");

                string ulaz;
                
                do
                {

                    ulaz = Console.ReadLine();
                }
                while (!int.TryParse(ulaz, out odabir) || odabir<1 || odabir>9);

                if (odabir == 1)
                {
                    do
                    {
                        Console.WriteLine("Odaberite opciju:\n" +
                                          "0. Zakazi pregled pacijentu koji je registrovan od ranije\n" +
                                          "1. Dodaj novog pacijenta\n" +
                                          "2. Dodaj smrtni slucaj\n" +
                                          "3. Obrisi pacijenta\n" +
                                          "4. Izlaz");


                        do
                        {
                            ulaz = Console.ReadLine();
                        }
                        while (!int.TryParse(ulaz, out odabir) || odabir<0 || odabir>4);

                        if(odabir==0)
                        {
                            Console.WriteLine("Odaberite pacijenta kojem zelite zakazati pregled:");
                            Console.WriteLine( klinika17280_1.prikaziSpisakPacijenata());
                            
                            int br;
                            do {
                                
                            } while (!int.TryParse(Console.ReadLine(), out br) || br<0 || br>klinika17280_1.EvidentiraniPacijenti.Count  );
                            int br2;
                            do
                            {
                                Console.WriteLine("Odaberite broj pregleda kojeg pacijent zeli obaviti (-1 za kraj): ");

                                Console.WriteLine( klinika17280_1.prikaziSpisakDostupnihPregleda());
                                do
                                {

                                } while (!int.TryParse(Console.ReadLine(), out br2) || br < 0 || br > klinika17280_1.DostupniPregledi.Count);
                                if (br2 == -1) continue;
                                if (klinika17280_1.DostupniPregledi[br2].OrdinacijaUKojojSeObavlja.Aktivna == false)
                                {
                                    Console.WriteLine("Nazalost aparat nije u funkciji. Nije moguce zakaziviti preglede u ovoj ordinaciji.");
                                    continue;
                                }

                                klinika17280_1.DostupniPregledi[br2].OrdinacijaUKojojSeObavlja.BrojPacijenataNaCekanju += 1;
                                Pregled pregled17280_1 = klinika17280_1.DostupniPregledi[br2];
                                pregled17280_1.DatumPregleda = DateTime.Now;
                                klinika17280_1.EvidentiraniPacijenti[br].SpisakPregleda.Add(pregled17280_1, true);
                                pregled17280_1.OrdinacijaUKojojSeObavlja.PreglediNaCekanju.Add(klinika17280_1.EvidentiraniPacijenti[br], pregled17280_1);
                            }

                            while (br2 != -1);

                            List<KeyValuePair<Pregled, bool>> lista17280_1 = klinika17280_1.EvidentiraniPacijenti[br].SpisakPregleda.ToList();

                            lista17280_1.Sort(delegate (KeyValuePair<Pregled, bool> prvi, KeyValuePair<Pregled, bool> drugi)
                            {
                                return prvi.Key.OrdinacijaUKojojSeObavlja.BrojPacijenataNaCekanju.CompareTo(drugi.Key.OrdinacijaUKojojSeObavlja.BrojPacijenataNaCekanju);
                            });

                            klinika17280_1.EvidentiraniPacijenti[br].SpisakPregleda = lista17280_1.ToDictionary(prvi => prvi.Key, prvi => prvi.Value);

                            

                            Console.WriteLine("Spisak pregleda nalazi se ispod");
                            Console.WriteLine( klinika17280_1.EvidentiraniPacijenti[br].ispisiSpisakPregleda());

                        }

                        if (odabir == 1)
                        {

                            Pacijent pacijent17280_1 = new Pacijent();
                            Console.WriteLine("Unesite sljedece podatke:");
                            Console.Write("Ime: "); pacijent17280_1.Ime = Console.ReadLine();
                            Console.Write("Prezime: "); pacijent17280_1.Prezime = Console.ReadLine();
                            Console.Write("Adresa: "); pacijent17280_1.Adresa = Console.ReadLine();
                            Console.Write("Dan rodjenja: "); int dan;
                            do { }
                            while(!int.TryParse(Console.ReadLine(), out dan));
                            Console.Write("Mjesec rodjenja: "); int mjesec;
                            do { }
                            while(!int.TryParse(Console.ReadLine(), out mjesec));
                            Console.Write("Godinu rodjenja: "); int godina;
                            do { }
                            while(!int.TryParse(Console.ReadLine(), out godina));
                            
                                pacijent17280_1.DatumRodjenja = new DateTime(godina, mjesec, dan);
                            
                            Console.Write("Maticni broj: "); int m; int.TryParse(Console.ReadLine(), out m);
                            pacijent17280_1.MaticniBroj = m;
                            Console.Write("Spol: Unesite 1 za Musko, 2 za Zensko\n"); int br;
                            int.TryParse(Console.ReadLine(), out br);
                            if (br == 1) pacijent17280_1.spoL = Spol.Musko; else pacijent17280_1.spoL = Spol.Zensko;
                            Console.Write("Bracno Stanje: Unesite 1 - Zarucen/a, 2 - Ozenje/Udata, " +
                                          "3 - Neozenjen/Neudata,\n 4 - Razveden/a, 5 - Udovac/ica\n"); int.TryParse(Console.ReadLine(), out br);
                            if (br == 1) pacijent17280_1.BStanje = bracnoStanje.Zarucen_a;
                            else if (br == 2) pacijent17280_1.BStanje = bracnoStanje.Ozenjen_Udata;
                            else if (br == 3) pacijent17280_1.BStanje = bracnoStanje.Neozenjen_Neudata;
                            else if (br == 4) pacijent17280_1.BStanje = bracnoStanje.Razveden_a;
                            else if (br == 5) pacijent17280_1.BStanje = bracnoStanje.Udovac_ica;
                            pacijent17280_1.NaPregledu = true;
                            int br2;                          
                            
                                do {
                                    Console.WriteLine("Odaberite broj pregleda kojeg pacijent zeli obaviti (-1 za kraj): ");

                                    Console.WriteLine( klinika17280_1.prikaziSpisakDostupnihPregleda());
                                    int.TryParse(Console.ReadLine(), out br2);
                                    if (br2 == -1) continue;
                                    if (klinika17280_1.DostupniPregledi[br2].OrdinacijaUKojojSeObavlja.Aktivna == false)
                                    {
                                        Console.WriteLine("Nazalost aparat nije u funkciji. Nije moguce zakaziviti preglede u ovoj ordinaciji.");
                                        continue;
                                    }

                                    klinika17280_1.DostupniPregledi[br2].OrdinacijaUKojojSeObavlja.BrojPacijenataNaCekanju += 1;
                                    Pregled pregled17280_1 = klinika17280_1.DostupniPregledi[br2];                                   
                                    pregled17280_1.DatumPregleda = DateTime.Now;
                                    pacijent17280_1.SpisakPregleda.Add(pregled17280_1, true);
                                    pregled17280_1.OrdinacijaUKojojSeObavlja.PreglediNaCekanju.Add(pacijent17280_1, pregled17280_1);
                                }

                                while (br2 != -1);
                            
                            List<KeyValuePair<Pregled, bool>> lista17280_1 = pacijent17280_1.SpisakPregleda.ToList();

                            lista17280_1.Sort(delegate (KeyValuePair<Pregled, bool> prvi, KeyValuePair<Pregled, bool> drugi)
                            {
                                return prvi.Key.OrdinacijaUKojojSeObavlja.BrojPacijenataNaCekanju.CompareTo(drugi.Key.OrdinacijaUKojojSeObavlja.BrojPacijenataNaCekanju);
                            });

                            pacijent17280_1.SpisakPregleda=lista17280_1.ToDictionary(prvi=>prvi.Key, prvi => prvi.Value );


                            klinika17280_1.dodajPacijenta(pacijent17280_1);

                            Console.WriteLine("Uspjesno ste unijeli pacijenta\nNjegov spisak pregleda nalazi se ispod");
                            Console.WriteLine(pacijent17280_1.ispisiSpisakPregleda());


                        }
                        else if (odabir == 2)
                        {
                            SmrtniSlucaj smrtnislucaj17280_1 = new SmrtniSlucaj();
                            Console.WriteLine("Unesite sljedece podatke:");
                            Console.Write("Ime: "); smrtnislucaj17280_1.Ime = Console.ReadLine();
                            Console.Write("Prezime: "); smrtnislucaj17280_1.Prezime = Console.ReadLine();
                            Console.Write("Adresa: "); smrtnislucaj17280_1.Adresa = Console.ReadLine();
                            Console.Write("Dan rodjenja: "); int dan; int.TryParse(Console.ReadLine(), out dan);
                            Console.Write("Mjesec rodjenja: "); int mjesec; int.TryParse(Console.ReadLine(), out mjesec);
                            Console.Write("Godinu rodjenja: "); int godina; int.TryParse(Console.ReadLine(), out godina);
                            smrtnislucaj17280_1.DatumRodjenja = new DateTime(godina, mjesec, dan);
                            Console.Write("Maticni broj: "); int m; int.TryParse(Console.ReadLine(), out m);
                            smrtnislucaj17280_1.MaticniBroj = m;
                            Console.Write("Spol: Unesite 1 za Musko, 2 za Zensko\n"); int br; int.TryParse(Console.ReadLine(), out br);
                            if (br == 1) smrtnislucaj17280_1.spoL = Spol.Musko; else smrtnislucaj17280_1.spoL = Spol.Zensko;
                            Console.Write("Bracno Stanje: Unesite 1 - Zarucen/a, 2 - Ozenje/Udata, " +
                                          "3 - Neozenjen/Neudata,\n 4 - Razveden/a, 5 - Udovac/ica\n"); int.TryParse(Console.ReadLine(), out br);
                            if (br == 1) smrtnislucaj17280_1.BStanje = bracnoStanje.Zarucen_a;
                            else if (br == 2) smrtnislucaj17280_1.BStanje = bracnoStanje.Ozenjen_Udata;
                            else if (br == 3) smrtnislucaj17280_1.BStanje = bracnoStanje.Neozenjen_Neudata;
                            else if (br == 4) smrtnislucaj17280_1.BStanje = bracnoStanje.Razveden_a;
                            else if (br == 5) smrtnislucaj17280_1.BStanje = bracnoStanje.Udovac_ica;
                            smrtnislucaj17280_1.NaPregledu = false;
                            Console.Write("Unesite datum i vrijeme smrti u formatu ' DAN/MJESEC/GODINA HH:MM:SS ': ");
                            DateTime pom; DateTime.TryParse(Console.ReadLine(), out pom); smrtnislucaj17280_1.DatumVrijemeSmrti = pom;
                            Console.Write("Unesite uzrok smrti: "); smrtnislucaj17280_1.UzrokSmrti = Console.ReadLine();
                            Console.Write("Zakazite datum i vrijeme obdukcije u formatu ' DAN/MJESEC/GODINA HH:MM:SS ': ");
                            DateTime.TryParse(Console.ReadLine(), out pom); smrtnislucaj17280_1.VrijemeObdukcije = pom;

                            klinika17280_1.EvidentiraniPacijenti.Add(smrtnislucaj17280_1);

                        }

                        else if (odabir == 3)
                        {
                            if (klinika17280_1.EvidentiraniPacijenti.Count == 0) Console.WriteLine("Klinika je prazna");
                            else
                            {
                                Console.WriteLine("Odaberite broj pacijenta kojeg zelite obrisati");
                                Console.WriteLine( klinika17280_1.prikaziSpisakPacijenata());
                                int br; int.TryParse(Console.ReadLine(), out br);
                                klinika17280_1.EvidentiraniPacijenti.RemoveAt(br);
                            }


                        }
                    }
                    while (odabir != 4);
                }

                else if (odabir == 2)
                {
                    string poruka = klinika17280_1.prikaziSpisakAktivnihPacijenata();
                    
                    if (poruka[0]!='N')
                    {
                        Console.WriteLine(klinika17280_1.prikaziSpisakAktivnihPacijenata());
                        Console.WriteLine("Odaberite broj pacijenta za kojeg zelite vidjeti raspored pregleda");
                        int br; int.TryParse(Console.ReadLine(), out br);
                        Console.WriteLine( klinika17280_1.EvidentiraniPacijenti[br].ispisiSpisakPregleda());
                    }
                }

                else if (odabir == 3)
                {
                    string poruka = klinika17280_1.prikaziSpisakAktivnihPacijenata();
                    if (poruka[0] != 'N')
                    {
                        Console.WriteLine(klinika17280_1.prikaziSpisakAktivnihPacijenata());
                        Console.WriteLine("Odaberite pacijenta za kojeg zelite kreirati karton");
                        int br; int.TryParse(Console.ReadLine(), out br);
                        klinika17280_1.EvidentiraniPacijenti[br].kreirajKarton();
                    }
                }

                else if (odabir == 4)
                {
                    Console.WriteLine(klinika17280_1.prikaziSpisakPacijenata());
                    
                        Console.WriteLine("Odaberite pacijenta za kojeg zelite pregledati karton");
                        int br; int.TryParse(Console.ReadLine(), out br);
                        Console.WriteLine( klinika17280_1.EvidentiraniPacijenti[br].KartonPacijenta.ispisi());
                        Console.WriteLine( klinika17280_1.EvidentiraniPacijenti[br].TerapijaPacijenta.ispisi());
                    
                }

                else if (odabir == 5)
                {
                    Console.WriteLine("1. Zavrsiti zakazani pregled\n2. Zakazati novi pregled");
                    int.TryParse(Console.ReadLine(), out odabir);
                    if (odabir == 1)
                    {
                        string poruka = klinika17280_1.prikaziSpisakAktivnihPacijenata();
                        if (poruka[0]!='N')
                        { 

                            Console.WriteLine(klinika17280_1.prikaziSpisakAktivnihPacijenata());
                            Console.WriteLine("Odaberite pacijenta u ciji karton zelite dodati pregled");
                            int br; int.TryParse(Console.ReadLine(), out br);
                            Console.WriteLine("Odaberite pregled koji zelite unijeti u karton sa spiska pregleda trazenog pacijenta");
                            Console.WriteLine( klinika17280_1.EvidentiraniPacijenti[br].ispisiSpisakPregleda());
                            int br2; int.TryParse(Console.ReadLine(), out br2);
                            int i = 0;
                            Pregled pregled17280_1 = new Pregled();
                            foreach (KeyValuePair<Pregled, bool> p in klinika17280_1.EvidentiraniPacijenti[br].SpisakPregleda)
                            {
                                if (i == br2) pregled17280_1 = p.Key;
                                i++;
                            }
                            klinika17280_1.EvidentiraniPacijenti[br].SpisakPregleda[pregled17280_1] = false;

                            Console.WriteLine("Unesite sljedece podatke:");
                            Console.Write("Rezultat pregleda: "); pregled17280_1.RezultatPregleda = Console.ReadLine();
                            Console.Write("Misljenje doktora: "); pregled17280_1.MisljenjeDoktora = Console.ReadLine();
                            Console.WriteLine("Odaberite doktora koji je obavio pregled:");
                            Console.WriteLine( klinika17280_1.ispisiDoktore());
                            int.TryParse(Console.ReadLine(), out br2);
                            pregled17280_1.PregledObavio = klinika17280_1.KlinickiDoktori[br];
                            klinika17280_1.KlinickiDoktori[br].BrojPregledanihPacijenata += 1;
                            klinika17280_1.EvidentiraniPacijenti[br].KartonPacijenta.PreglediPacijenta.Add(pregled17280_1);
                            klinika17280_1.DostupniPregledi[br2].OrdinacijaUKojojSeObavlja.PreglediNaCekanju.Remove(klinika17280_1.EvidentiraniPacijenti[br]);
                            klinika17280_1.DostupniPregledi[br2].OrdinacijaUKojojSeObavlja.BrojObradjenihPacijenata++;
                            klinika17280_1.DostupniPregledi[br2].OrdinacijaUKojojSeObavlja.BrojPacijenataNaCekanju--;
                            Console.WriteLine("Unesite terapiju pacijentu (0 za preskakanje 1 za unos):");
                            int n; int.TryParse(Console.ReadLine(), out n);
                            if (n != 0)
                            {
                                Terapija terapija17280_1 = new Terapija();
                                Console.Write("Ime terapije: "); terapija17280_1.ImeTerapije = Console.ReadLine();
                                Console.Write("Trajanje terapije: "); int t; int.TryParse(Console.ReadLine(), out t);
                                terapija17280_1.TrajanjeTerapije = t;
                                klinika17280_1.EvidentiraniPacijenti[br].TerapijaPacijenta = terapija17280_1;
                            }
                        }
                    }
                    if(odabir==2)
                    {
                        string poruka = klinika17280_1.prikaziSpisakAktivnihPacijenata();
                        if (poruka[0]!='N')
                        {

                        Console.WriteLine(klinika17280_1.prikaziSpisakAktivnihPacijenata());
                        Console.WriteLine("Odaberite pacijenta kojem zelite zakazati pregled");
                            int br; int.TryParse(Console.ReadLine(), out br);
                            int br2;
                            do
                            {
                                Console.WriteLine("Odaberite broj pregleda kojeg pacijent zeli obaviti (-1 za kraj): ");

                                Console.WriteLine( klinika17280_1.prikaziSpisakDostupnihPregleda());
                                int.TryParse(Console.ReadLine(), out br2);
                                if (br2 == -1) continue;
                                if (klinika17280_1.DostupniPregledi[br2].OrdinacijaUKojojSeObavlja.Aktivna == false)
                                {
                                    Console.WriteLine("Nazalost aparat nije u funkciji. Nije moguce zakaziviti preglede u ovoj ordinaciji.");
                                    continue;
                                }

                                klinika17280_1.DostupniPregledi[br2].OrdinacijaUKojojSeObavlja.BrojPacijenataNaCekanju += 1;
                                Pregled pregled17280_1 = klinika17280_1.DostupniPregledi[br2];
                                pregled17280_1.DatumPregleda = DateTime.Now;
                                klinika17280_1.EvidentiraniPacijenti[br].SpisakPregleda.Add(pregled17280_1, true);
                                pregled17280_1.OrdinacijaUKojojSeObavlja.PreglediNaCekanju.Add(klinika17280_1.EvidentiraniPacijenti[br], pregled17280_1);
                            }                           
                            while (br2 != -1);
                        }
                    }
                }

                else if (odabir == 6)
                {
                    do
                    {
                        Console.WriteLine("1. Prikazi ordinacije sortirane po posjecenosti\n" +
                                          "2. Prikazi najposjecenijeg doktora\n" +
                                          "3. Prikazi pacijenta sa najvecim dugom prema klinici\n" +
                                          "4. Prikazi ukupan dug svih pacijenata\n" +
                                          "5. Prikazi stanje racuna klinike\n" +
                                          "6. Obracunaj mjesec\n" +
                                          "7. Izlaz");
                        int.TryParse(Console.ReadLine(), out odabir);

                        if(odabir==1)
                        {
                            List < Ordinacija > lista17280_1 = klinika17280_1.KlinickeOrdinacije;
                            lista17280_1.Sort(delegate (Ordinacija ordinacija17280_1, Ordinacija ordinacija17280_2)
                            {
                                return ordinacija17280_1.BrojObradjenihPacijenata.CompareTo(ordinacija17280_2.BrojObradjenihPacijenata);
                            });
                            foreach(Ordinacija o in lista17280_1)
                            {
                                Console.WriteLine("{0} sa brojem posjeta {1}", o.ImeOrdinacije, o.BrojObradjenihPacijenata);
                            }
                        }

                        else if(odabir==2)
                        {
                            List<Doktor> lista17280_1 = klinika17280_1.KlinickiDoktori;
                            lista17280_1.Sort(delegate (Doktor prvi, Doktor drugi)
                            {
                                return prvi.BrojPregledanihPacijenata.CompareTo(drugi.BrojPregledanihPacijenata);
                            });
                            Console.WriteLine("Doktor koji je pregledao najvise pacijenata je: {0} {1}", lista17280_1[lista17280_1.Count - 1].Ime, lista17280_1[lista17280_1.Count - 1].Prezime);
                        }

                        else if(odabir==3)
                        {
                            List<Pacijent> lista17280_1 = klinika17280_1.EvidentiraniPacijenti;
                            lista17280_1.Sort(delegate (Pacijent prvi, Pacijent drugi)
                            {
                                return prvi.DugPacijenta.CompareTo(drugi.DugPacijenta);
                            });
                            Console.WriteLine("Pacijent sa najvise duga je: {0} {1}, sa ukupnim dugom {2} KM", lista17280_1[lista17280_1.Count - 1].Ime, lista17280_1[lista17280_1.Count - 1].Prezime, lista17280_1[lista17280_1.Count - 1].DugPacijenta);
                        }

                        else if(odabir == 4)
                        {
                            double ukupno=0;
                            foreach(Pacijent pacijent17280_1 in klinika17280_1.EvidentiraniPacijenti)
                            {
                                ukupno += pacijent17280_1.DugPacijenta;
                            }
                            Console.WriteLine("Ukupan dug prema klinici iznosi: {0} KM", ukupno);
                        }

                        else if(odabir==5)
                        {
                            Console.WriteLine("Na racunu se trenutno nalazi: {0} KM", klinika17280_1.StanjeRacuna);
                        }

                        else if(odabir==6)
                        {
                            double ukupnoRashodi=0;
                            double ukupnoPrihodi=0;

                            for(int i=0; i<klinika17280_1.EvidentiraniPacijenti.Count; i++)
                            {
                                if (klinika17280_1.EvidentiraniPacijenti[i].BrojPreostalihRata > 0)
                                {
                                    ukupnoPrihodi += klinika17280_1.EvidentiraniPacijenti[i].DugPacijenta / klinika17280_1.EvidentiraniPacijenti[i].BrojPreostalihRata;
                                    klinika17280_1.EvidentiraniPacijenti[i].DugPacijenta-= klinika17280_1.EvidentiraniPacijenti[i].DugPacijenta / klinika17280_1.EvidentiraniPacijenti[i].BrojPreostalihRata;
                                    klinika17280_1.EvidentiraniPacijenti[i].BrojPreostalihRata--;
                                }
                            }

                            for(int i=0; i<klinika17280_1.KlinickiDoktori.Count; i++)
                            {
                                if(klinika17280_1.KlinickiDoktori[i].BrojPregledanihPacijenata<=20)
                                {
                                    ukupnoRashodi += klinika17280_1.KlinickiDoktori[i].PlataUposlenika + klinika17280_1.KlinickiDoktori[i].BrojPregledanihPacijenata * 20;
                                }
                                else
                                {
                                    ukupnoRashodi += klinika17280_1.KlinickiDoktori[i].PlataUposlenika + 400;
                                }
                                klinika17280_1.KlinickiDoktori[i].BrojPregledanihPacijenata = 0;
                                
                            }
                            for(int i=0; i<klinika17280_1.OstaliUposlenici.Count; i++)
                            {
                                ukupnoRashodi += klinika17280_1.OstaliUposlenici[i].PlataUposlenika;
                            }
                            klinika17280_1.StanjeRacuna += ukupnoPrihodi - ukupnoRashodi;
                            Console.WriteLine("Ukupan broj prihoda ovaj mjesec iznosio je: {0} KM\n" +
                                              "Ukupan broj rashoda ovaj mjesec iznosio je: {1} KM", ukupnoPrihodi, ukupnoRashodi);
                        }
                    }
                    while (odabir != 7);

                }

                else if (odabir == 7)
                {
                    if ((klinika17280_1.prikaziSpisakAktivnihPacijenata())[0]!='N')
                    {
                    Console.WriteLine(klinika17280_1.prikaziSpisakAktivnihPacijenata());
                    Console.WriteLine("Odaberite pacijenta za naplatu:");
                        int br; int.TryParse(Console.ReadLine(), out br);
                        Racun racun17280_1 = new Racun();
                        Console.WriteLine("Odaberite vrstu placanja:\n1) Gotovinsko\n2) Na rate");
                        int br2; int.TryParse(Console.ReadLine(), out br2);

                        if (br2 == 1)
                        {

                            double ukupno = 0;
                            foreach (KeyValuePair<Pregled, bool> p in klinika17280_1.EvidentiraniPacijenti[br].SpisakPregleda)
                            {
                                ukupno += p.Key.CijenaPregleda;
                            }
                            if (klinika17280_1.EvidentiraniPacijenti[br].KartonPacijenta.PreglediPacijenta.Count > 3)
                            {
                                racun17280_1.UkupanIznos = ukupno - (ukupno * 0.10);

                            }
                            else
                            {
                                racun17280_1.UkupanIznos = ukupno;

                            }
                            racun17280_1.ListaPregleda = klinika17280_1.EvidentiraniPacijenti[br].SpisakPregleda;
                            racun17280_1.ispisi();
                            klinika17280_1.StanjeRacuna = klinika17280_1.StanjeRacuna + ukupno;
                            

                        }

                        if (br2 == 2)
                        {
                            Console.WriteLine("Unesite broj rata: ");
                            int br3; int.TryParse(Console.ReadLine(), out br3);
                            racun17280_1.BrojRata = br3;
                            klinika17280_1.EvidentiraniPacijenti[br].BrojPreostalihRata = br3 - 1;
                            double ukupno = 0;
                            foreach (KeyValuePair<Pregled, bool> p in klinika17280_1.EvidentiraniPacijenti[br].SpisakPregleda)
                            {
                                ukupno += p.Key.CijenaPregleda;
                            }
                            if (klinika17280_1.EvidentiraniPacijenti[br].KartonPacijenta.PreglediPacijenta.Count > 3)
                            {
                                racun17280_1.UkupanIznos = ukupno;

                            }
                            else
                            {
                                racun17280_1.UkupanIznos = ukupno + (ukupno * 0.15);

                            }
                            racun17280_1.ListaPregleda = klinika17280_1.EvidentiraniPacijenti[br].SpisakPregleda;
                            klinika17280_1.StanjeRacuna = klinika17280_1.StanjeRacuna + ukupno / br3;
                            klinika17280_1.EvidentiraniPacijenti[br].DugPacijenta = ukupno - ukupno / br3;
                            racun17280_1.ispisi();

                        }
                        klinika17280_1.EvidentiraniPacijenti[br].NaPregledu = false;
                        klinika17280_1.EvidentiraniPacijenti[br].SpisakPregleda.Clear();
                    }
                }

                else if(odabir == 9)
                {
                    do
                    {
                        Console.WriteLine("1. Prikazi listu cekanja za ordinaciju\n2. Prijavi pokvaren aparat\n" +
                            "3. Prijavi popravljen aparat\n4. Oznaci zatvorenu ordinaciju\n5. Oznaci otvorenu ordinaciju\n6. Izlaz");
                        int.TryParse(Console.ReadLine(), out odabir);

                        if (odabir == 1)
                        {
                            Console.WriteLine("Odaberite ordinaciju za koju zelite vidjeti listu cekanja:");
                            Console.WriteLine( klinika17280_1.ispisiOrdinacije());
                            int br; int.TryParse(Console.ReadLine(), out br);
                            Console.WriteLine( klinika17280_1.KlinickeOrdinacije[br].ispisiListuCekanja());
                        }

                        else if (odabir == 2)
                        {
                            Console.WriteLine("Odaberite aparat koji je pokvaren:");
                            Console.WriteLine( klinika17280_1.ispisiAparate());
                            int br; int.TryParse(Console.ReadLine(), out br);
                            klinika17280_1.KlinickiAparati[br].Aktivan = false;
                            klinika17280_1.KlinickiAparati[br].OrdinacijaUKojojSeNalazi.Aktivna = false;
                        }
                        else if (odabir == 3)
                        {
                            Console.WriteLine("Odaberite aparat koji je popravljen:");
                            Console.WriteLine( klinika17280_1.ispisiAparate());
                            int br; int.TryParse(Console.ReadLine(), out br);
                            klinika17280_1.KlinickiAparati[br].Aktivan = true;
                            klinika17280_1.KlinickiAparati[br].OrdinacijaUKojojSeNalazi.Aktivna = true;
                        }
                        else if (odabir == 4)
                        {
                            Console.WriteLine("Odaberite ordinaciju koja se zatvara:");
                            Console.WriteLine( klinika17280_1.ispisiOrdinacije());
                            int br; int.TryParse(Console.ReadLine(), out br);
                            klinika17280_1.KlinickeOrdinacije[br].Aktivna = false;
                        }
                        else if (odabir == 5)
                        {
                            Console.WriteLine("Odaberite ordinaciju koja se otvara:");
                            Console.WriteLine( klinika17280_1.ispisiOrdinacije());
                            int br; int.TryParse(Console.ReadLine(), out br);
                            klinika17280_1.KlinickeOrdinacije[br].Aktivna = true;
                        }
                        }
                    while (odabir != 6);
                }

            }
            while (odabir != 8);
            
        }
    }
}
