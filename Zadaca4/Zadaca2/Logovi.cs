using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Zadaca2
{
    public partial class Logovi : Form
    {
        public Logovi()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) groupBox1.Visible = false;
            else
            {
                comboBox1.SelectedIndex = 0;
                groupBox1.Visible = true;
                dateTimePicker_POC.Format = DateTimePickerFormat.Custom;
               dateTimePicker_POC.CustomFormat = "dd/MM/yyyy hh:mm:ss";
                dateTimePicker_KRAJ.Format = DateTimePickerFormat.Custom;
                dateTimePicker_KRAJ.CustomFormat = "dd/MM/yyyy hh:mm:ss";
                
            }
        }

        private void button_Zatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Logovi_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            checkBox1.Checked = true;
            
        }

        private void button_Prikazi_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            PrikazLogovaAsync();
        }

        public async void PrikazLogovaAsync()
        {
            try
            {
                var path = String.Format("{0}\\Logs.txt", AppDomain.CurrentDomain.BaseDirectory);
                FileStream f = new FileStream(path, FileMode.Open);

                StreamReader citac = new StreamReader(f);
                string red = "";
                List<Izuzetak> logovi = new List<Izuzetak>();
                while ((await Task.Run(()=> red = citac.ReadLine()) != null))
                {
                    string[] izuzetak = red.Split(',');
                    string tip = izuzetak[0];
                    TipIzuzetka t = new TipIzuzetka();
                    switch (tip)
                    {
                        case "Rad_sa_bazom": t = TipIzuzetka.Rad_sa_bazom; break;
                        case "Rad_sa_datotekama": t = TipIzuzetka.Rad_sa_datotekama; break;
                        case "Rad_sa_UI_kontrolama": t = TipIzuzetka.Rad_sa_UI_kontrolama; break;
                    }
                    logovi.Add(new Izuzetak(t, Convert.ToDateTime(izuzetak[1]), izuzetak[2], izuzetak[3])); 
                }

                f.Close();
                richTextBox1.Clear();
                if (checkBox1.Checked == true)
                {
                    for (int i = 0; i < logovi.Count; i++)
                    {
                        this.Invoke(new Action(() => richTextBox1.Text += logovi[i].ToString() + "\n"));                        
                    }
                }
                else
                {
                    int indeks = comboBox1.SelectedIndex;
                    TipIzuzetka t = new TipIzuzetka();
                    switch (indeks)
                    {
                        case 1: t = TipIzuzetka.Rad_sa_datotekama; break;
                        case 2: t = TipIzuzetka.Rad_sa_bazom; break;
                        case 3: t = TipIzuzetka.Rad_sa_UI_kontrolama; break;

                    }
                    DateTime poc = dateTimePicker_POC.Value;
                    DateTime kraj = dateTimePicker_KRAJ.Value;
                    if (indeks == 0)
                    {
                        for (int i = 0; i < logovi.Count; i++)
                        {
                            await Task.Delay(500);
                            if (logovi[i].VrijemeNastanka >= poc && logovi[i].VrijemeNastanka <= kraj)
                                this.Invoke(new Action(() => richTextBox1.Text += logovi[i].ToString() + "\n"));
                        }
                    }
                    else
                    {
                        for (int i = 0; i < logovi.Count; i++)
                        {
                            if (logovi[i].VrijemeNastanka >= poc && logovi[i].VrijemeNastanka <= kraj && logovi[i].Tip == t)
                                this.Invoke(new Action(() => richTextBox1.Text += logovi[i].ToString() + "\n"));
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                Izuzetak iz = new Izuzetak(TipIzuzetka.Rad_sa_datotekama, DateTime.Now, Glavna.prijavljeni.KorisnickoIme, ex.Message);
                Glavna.DodajIzuzetak(iz);
            }
        }
    }
}
