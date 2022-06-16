using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SifrelemeAlgoritmalari
{
    public partial class SezarŞifrelemeForm : Form
    {
        public SezarŞifrelemeForm()
        {
            InitializeComponent();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Form1 _formadon = new Form1();
            _formadon.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string _veri = "";
            _veri = guna2sifrelenecekmetin.Text;
            char[] karakterler = _veri.ToCharArray();

            foreach (var i in karakterler)
            {
                guna2sifrelenmismetin.Text += Convert.ToChar(i + 3).ToString();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string _veri = "";
            _veri = guna2sifrelenmismetin.Text;
            char[] karakterler = _veri.ToCharArray();

            foreach (var i in karakterler)
            {
                guna2sifrelenecekmetin.Text += Convert.ToChar(i - 3).ToString();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2sifrelenecekmetin.Clear();
            guna2sifrelenmismetin.Clear();
 }
    }
}
