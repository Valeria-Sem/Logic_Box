using System;
using System.Windows.Forms;

namespace Logic_Box
{
    public partial class Form6 : Form
    {
        Timer t = new Timer() { Interval = 20000 };

        public Form6()
        {
            InitializeComponent();
            t.Tick += timer1_Tick;
            button25.Visible = false;
            t.Start();
            textBox1.Text = "ЗАДАНИЕ: Перед Вами девять маленьких квадратов, образованных двадцатью четырьмя палочками. Уберите 8 палочек, не трогая остальных," +
                " \nчтобы осталось всего лишь 2 квадрата. Нажимайте на палочки, чтобы они исчезли.";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.Visible = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.Visible = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.Visible = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button25.Visible = true;
            t.Stop();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Close();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if ((button8.Visible == false && button1.Visible == false && button15.Visible == false && button14.Visible == false &&
                button7.Visible == false && button3.Visible == false && button22.Visible == false && button20.Visible == false) ||
                (button8.Visible == false && button1.Visible == false && button18.Visible == false && button11.Visible == false &&
                button7.Visible == false && button14.Visible == false && button22.Visible == false && button20.Visible == false))
            {
                Form7 f = new Form7();
                f.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Неверно!!!!!");

                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;
                button9.Visible = true;
                button10.Visible = true;
                button11.Visible = true;
                button12.Visible = true;
                button13.Visible = true;
                button14.Visible = true;
                button15.Visible = true;
                button16.Visible = true;
                button17.Visible = true;
                button18.Visible = true;
                button19.Visible = true;
                button20.Visible = true;
                button21.Visible = true;
                button22.Visible = true;
                button23.Visible = true;
                button24.Visible = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Visible = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.Visible = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.Visible = false;
        }
    }
}
