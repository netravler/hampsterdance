using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//
using System.Net;
using System.Net.NetworkInformation;
using System.IO;
using System.Diagnostics;
using System.Threading;


namespace hampsterdance
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void getOnTheWheelToolStripMenuItem_Click(object sender, EventArgs e)
        {


            //string[] testURL = {"https://www.netteller.com/releasetest9325","https://www2.netteller.com/releasetest9325","https://www.netteller.com/techbank8897","https://www2.netteller.com/sym6404" };

            // Create web client and condition it
            WebClient client = new WebClient();
            client.Proxy = null;

            // Download string.
            this.Text = "Hamster Dance - Running!";

            // ok tell the master hamster the time it started
            DateTime currentTime = DateTime.Now;
            textBox3.Text = currentTime.ToString();
            textBox3.Refresh();

            Stopwatch sw = new Stopwatch();

            foreach (string URLtest in textBox2.Lines)
            {
                try
                {

                    sw.Start(); // timing this activity
                    string value = client.DownloadString(@URLtest);
                    sw.Stop();

                    // Write values.
                    textBox1.AppendText(URLtest + "|" + value.Length + "|" + client.BaseAddress.ToString() + "Time elasped: " + sw.Elapsed.TotalSeconds + "\n");
                    sw.Reset();
                }
                catch
                {
                    textBox1.AppendText(URLtest + "|" + "NO Workie" + "\n");
                }
            }
            this.Text = "Hamster Dance";

            // close time
            currentTime = DateTime.Now;
            textBox4.Text = currentTime.ToString();
            textBox4.Refresh();
        }

        public string[] toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dr = new OpenFileDialog();
            DialogResult drOut = dr.ShowDialog();

            if (drOut == DialogResult.Cancel)
            {
                dr.Dispose();
                return null;
            }
            else if (drOut == DialogResult.OK)
            {
                string pathIN = dr.FileName;
                string[] URLout = System.IO.File.ReadAllLines(@pathIN);
                dr.Dispose();
                return URLout;
            }
            return null;
        }

        private void toolStripMenuItem1_Click()
        {

        }

        public string [] loadListOfURLsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.Cancel)
            {
                openFileDialog1.Dispose();
                return null;
            }
            else if (dr == DialogResult.OK)
            {
                string pathIN = openFileDialog1.FileName;
                string[] URLout = System.IO.File.ReadAllLines(@pathIN);
                openFileDialog1.Dispose();
                return URLout;
            }
            return null;
        }

        private void loadURLsToTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.Cancel)
            {
                openFileDialog1.Dispose();
            }
            else if (dr == DialogResult.OK)
            {
                string pathIN = openFileDialog1.FileName;
                string[] URLout = System.IO.File.ReadAllLines(@pathIN);

                 // load textBox2
                foreach (string urlLine in URLout)
                {
                    textBox2.AppendText(urlLine + "\n");
                }

                openFileDialog1.Dispose();
            }
        }

        private void copyOutTheResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfOut = new SaveFileDialog();
            sfOut.FileName = "mystuffOut.csv";

            DialogResult putHereBaby = sfOut.ShowDialog();
            string filename = sfOut.FileName;

            try
            {
                //load textbox1 to the file selected
                File.WriteAllLines(filename, textBox1.Lines);
            }
            catch
            {
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

   }
}
