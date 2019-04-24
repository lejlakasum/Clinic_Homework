using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Zadaca2
{
    public partial class PretragaDirektorija : Form
    {
        public PretragaDirektorija()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            DialogResult d = f.ShowDialog();

            if (d == DialogResult.OK)
            {
                DirectoryInfo fol = new DirectoryInfo(Path.GetFullPath(f.SelectedPath));
                FileInfo[] files = fol.GetFiles();
                DirectoryInfo[] dir = fol.GetDirectories();

                List<string> cijelifol = new List<string>();

                foreach (FileInfo file in files)
                {
                    cijelifol.Add(file.Name);
                }
                foreach (DirectoryInfo direc in dir)
                {
                    cijelifol.Add(direc.Name);
                }

                cijelifol.Sort();

                Thread t = new Thread(new ThreadStart(() => ispisi(cijelifol)));
                t.Start();

            }
        }

        public async void ispisi(List<string> l)
        {
            for (int i = 0; i < l.Count; i++)
            {
                await Task.Delay(500);
                this.Invoke(new Action(() => listBox1.Items.Add(l[i])));
            }

            this.Invoke(new Action(() => toolStripStatusLabel1.ForeColor=Color.Blue));
            this.Invoke(new Action(() => toolStripStatusLabel1.Text = "Izlistani su svi fajlovi i direktoriji"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
