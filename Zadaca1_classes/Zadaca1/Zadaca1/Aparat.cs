using System;


namespace Zadaca1
{
    public sealed class Aparat
    {
        bool aktivan;
        private string imeAparata;
        private Ordinacija ordinacijaUKojojSeNalazi;

        public Aparat(bool a, string ime, Ordinacija o)
        {
            aktivan = a;
            imeAparata = ime;
            ordinacijaUKojojSeNalazi = o;
        }
        public string ImeAparata
        {
            get { return imeAparata; }
            set { imeAparata = value; }
        }
        public Ordinacija OrdinacijaUKojojSeNalazi
        {
            get { return ordinacijaUKojojSeNalazi; }
            set { ordinacijaUKojojSeNalazi = value; }
        }
        public bool Aktivan
        {
            get { return aktivan; }
            set { aktivan = value; }
        }
    }
}