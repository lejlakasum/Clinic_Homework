using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Zadaca2
{
    [Serializable]
    public class KlasaSlika
    {
        Image odabranaSlika;
        DateTime datumSlikanja;

        public KlasaSlika()
        {

        }
        public Image OdabranaSlika { get => odabranaSlika; set => odabranaSlika = value; }
        public DateTime DatumSlikanja { get => datumSlikanja; set => datumSlikanja = value; }
    }
}
