using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FacebookPoster
{
    public partial class Form1 : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        string sciezkaDoZdjecia = "";
        List<string> grupy;
        string email;
        string haslo;
        string post;
        public Form1()
        {
            InitializeComponent();
            textPost.Multiline = true;
            textPost.ScrollBars = ScrollBars.Vertical;
            textPost.Width = 300;
            textPost.Height = 200;
            //Poster poster = new Poster();
            //poster.start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grupy = new List<string>();
            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            var plik = new FileInfo(ofd.FileName);
            if (plik.Extension != ".txt")
            {
                MessageBox.Show("Dozwolone rozszerzenie to \"TXT\"");
                return;
            }
            labelPlik.Text = plik.FullName;
            var wiersze = File.ReadAllLines(ofd.FileName);
            foreach (var wiersz in wiersze)
            {
                var dane = wiersz.Trim().Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var dana in dane)
                {
                    var tmp = dana.Trim();
                    grupy.Add(tmp);
                }
            }
        }

        private void btnZdjecie_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            var plik = new FileInfo(ofd.FileName);
            sciezkaDoZdjecia = plik.FullName;
        }

        private void btnWystaw_Click(object sender, EventArgs e)
        {
            email = textEmail.Text;
            haslo = textHaslo.Text;
            post = textPost.Text;
            Poster poster = new Poster(grupy,email,haslo,post,sciezkaDoZdjecia);
            poster.start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
