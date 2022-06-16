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
    public partial class AscIISirelemeFormu : Form
    {
        public AscIISirelemeFormu()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            StringBuilder _builder = new StringBuilder();

            foreach (var i in guna2sifrelenecekmetin.Text)
            {
                _builder.Append(Convert.ToInt32(i) + " ");
            }

            guna2sifrelenmismetin.Text = _builder.ToString();
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
