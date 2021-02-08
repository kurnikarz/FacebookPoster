using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookPoster
{
    public partial class Form1 : Form
    {
        List<string> groups = new List<string>();
        string grupy;

        public Form1()
        {
            InitializeComponent();
            textBox1.Multiline = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Width = 400;
            textBox1.Height = 200;
            //Poster poster = new Poster();
            //poster.start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //groups.Add(textBox1.Text);
            grupy = textBox1.Text;
            string[] g = grupy.Split('\n');
            for (int i=0;i<groups.Count;i++)
            {
                groups[i].Split('\n');
                Console.WriteLine("grupa "+i+": " +groups[i]);
            }
        }
    }
}
