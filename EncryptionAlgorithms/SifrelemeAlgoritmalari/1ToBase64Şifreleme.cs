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
    public partial class _1ToBase64Şifreleme : Form
    {
        public _1ToBase64Şifreleme()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string _anametin = guna2sifrelenecekmetin.Text;
            byte[] _veridizisi = ASCIIEncoding.ASCII.GetBytes(_anametin);
            string _sifrelimetin = Convert.ToBase64String(_veridizisi);
            guna2sifrelenmismetin.Text = _sifrelimetin;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string _metincoz = guna2sifrelenmismetin.Text;
            byte[] _veridizisicozulen = Convert.FromBase64String(_metincoz);
            string _anametin = ASCIIEncoding.ASCII.GetString(_veridizisicozulen);
            guna2sifrelenecekmetin.Text = _anametin;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2sifrelenecekmetin.Clear();
            guna2sifrelenmismetin.Clear();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Form1 _formadon = new Form1();
            _formadon.Show();
            this.Hide();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
