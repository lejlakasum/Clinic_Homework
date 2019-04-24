using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
    [Serializable]
    public class Aparat
    {
        private bool aktivan;
        private string imeAparata;
        private Ordinacija ordinacijaUKojojSeNalazi;
        private bool @checked;
        private string text;
        private object selectedItem;

        public Aparat() { }
        public Aparat(bool aktivan, string imeAparata, Ordinacija ordinacijaUKojojSeNalazi)
        {
            Aktivan = aktivan;
            ImeAparata = imeAparata;
            OrdinacijaUKojojSeNalazi = ordinacijaUKojojSeNalazi;
        }

        public Aparat(bool @checked, string text, object selectedItem)
        {
            this.@checked = @checked;
            this.text = text;
            this.selectedItem = selectedItem;
        }

        public bool Aktivan { get => aktivan; set => aktivan = value; }
        public string ImeAparata { get => imeAparata;
            set {
                if (String.IsNullOrWhiteSpace(value)) throw new Exception("Polje ne smije biti prazno");
                imeAparata = value;
                 }
        }
        public Ordinacija OrdinacijaUKojojSeNalazi { get => ordinacijaUKojojSeNalazi; set => ordinacijaUKojojSeNalazi = value; }

        public override string ToString()
        {
            string rez = "";
            rez += "\nIme aparata: " + ImeAparata +
                "\nOrdinacija u koju je smjesten: " + ordinacijaUKojojSeNalazi.ImeOrdinacije;
            if (Aktivan == true) rez += "\nAktivan";
            else rez += "\nNekativan";
        
            return rez;
        }
    }
}
