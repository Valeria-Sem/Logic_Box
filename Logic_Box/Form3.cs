using System;
using System.Windows.Forms;

namespace Logic_Box
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show();
            Close();
        }
    }
}
