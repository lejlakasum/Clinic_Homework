using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadaca2
{
    public partial class Slika : UserControl
    {

        private KlasaSlika slikaSDatumom;
        public Slika()
        {
            InitializeComponent();
            slikaSDatumom = new KlasaSlika();
        }

        public Image Pciture
        {
            get
            {
               return slikaSDatumom.OdabranaSlika;
            }
            set
            {
                slikaSDatumom.OdabranaSlika = value;
            }
        }

        

        public DateTime Date
        {
            get
            {
                return slikaSDatumom.DatumSlikanja;
            }
            set
            {
                slikaSDatumom.DatumSlikanja = value;
            }
        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            if(DateTime.Today.Date.AddMonths(-6)>dateTimePicker1.Value.Date)
            {
                e.Cancel = true;
            }
            errorProvider1.SetError(dateTimePicker1, "Slika ne smije biti starija od šest mjeseci");
        }

        private void dateTimePicker1_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(dateTimePicker1, String.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog folder = new OpenFileDialog();
            folder.Filter = "jpg files(*.jpg)|*.jpg";

            DialogResult d = folder.ShowDialog();

            pictureBox1.Image = Image.FromFile(folder.FileName);
            //slikaSDatumom.OdabranaSlika = Image.FromFile(folder.FileName);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            slikaSDatumom.DatumSlikanja = dateTimePicker1.Value;
        }

        private void Slika_Load(object sender, EventArgs e)
        {

        }
    }
}
