using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace SifrelemeAlgoritmalari
{
    public partial class AnimatedSpashScreen : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect,
        int RightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
        );

        public AnimatedSpashScreen()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            cpbar1.Value = 0;
        }

        private void AnimatedSpashScreen_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cpbar1.Value += 1;
            cpbar1.Text = cpbar1.Value.ToString() + "%";

            if (cpbar1.Value == 100)
            {
                timer1.Enabled = false;
                Form1 _formagit = new Form1();
                _formagit.Show();
                this.Hide();
            }
        }
    }
}
