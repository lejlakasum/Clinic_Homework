using System;

namespace Zadaca1 { 

        public class SmrtniSlucaj : Pacijent
        {
            private DateTime datumVrijemeSmrti;
            private string uzrokSmrti;
            private DateTime vrijemeObdukcije;

            public DateTime DatumVrijemeSmrti
            {
                get { return datumVrijemeSmrti; }
                set { datumVrijemeSmrti = value; }
            }
            public string UzrokSmrti
            {
                get { return uzrokSmrti; }
                set { uzrokSmrti = value; }
            }
            public DateTime VrijemeObdukcije
            {
                get { return vrijemeObdukcije; }
                set { vrijemeObdukcije = value; }
            }
            public override string ispisi()
            {
            string poruka = "";
                poruka+=("\n"+ime+" "+prezime+" je premuninuo/la dana "+DatumVrijemeSmrti.Date+" u "+DatumVrijemeSmrti.TimeOfDay+" Preliminarni uzrok smrti: \n" +uzrokSmrti);
                if (vrijemeObdukcije != default(DateTime))
                {
                    poruka+="\nZakazano vrijeme obdukcije je: "+ vrijemeObdukcije;
                }
            return poruka;
            }
        }
}
