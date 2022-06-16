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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AscIISirelemeFormu _formagit = new AscIISirelemeFormu();
            _formagit.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SezarŞifrelemeForm _formagit = new SezarŞifrelemeForm();
            _formagit.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            _1ToBase64Şifreleme _formagit = new _1ToBase64Şifreleme();
            _formagit.Show();
            this.Hide();

        }
    }
}
