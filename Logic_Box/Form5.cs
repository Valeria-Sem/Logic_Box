using System;
using System.Drawing;
using System.Windows.Forms;

namespace Logic_Box
{
    public partial class Form5 : Form
    {
        object currObject = null;
        Timer t = new Timer() { Interval = 15000 };

        public Form5()
        {
            InitializeComponent();
            MouseMove += new MouseEventHandler(mouseEvent);
            MouseClick += new MouseEventHandler(mouseClic);
            textBox1.Text = "ЗАДАНИЕ: Необходимо переложить палочки так, чтобы получить ровно 3 квадрата.";
            t.Tick += timer1_Tick;
            button13.Visible = false;
            t.Start();
        }

        private void mouseClic(object sender, MouseEventArgs e)
        {
            currObject = null;
        }

        private void mouseEvent(object sender, MouseEventArgs e)
        {
            if (currObject != null)
                currObject.GetType().GetProperty("Location").SetValue(currObject, new Point(Cursor.Position.X - 300, Cursor.Position.Y - 150));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currObject = sender;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currObject = sender;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currObject = sender;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currObject = sender;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currObject = sender;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currObject = sender;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            currObject = sender;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            currObject = sender;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            currObject = sender;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            currObject = sender;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            currObject = sender;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            currObject = sender;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            if ((button1.Location.X >= 240 && button1.Location.X < 481) && (button1.Location.Y >= 220 && button1.Location.Y < 350) ||
                (button2.Location.X >= 240 && button2.Location.X < 481) && (button2.Location.Y >= 220 && button2.Location.Y < 350) ||
                (button3.Location.X >= 240 && button3.Location.X < 481) && (button3.Location.Y >= 220 && button3.Location.Y < 350) ||
                (button4.Location.X >= 240 && button4.Location.X < 481) && (button4.Location.Y >= 220 && button4.Location.Y < 350) ||
                (button5.Location.X >= 240 && button5.Location.X < 481) && (button5.Location.Y >= 220 && button5.Location.Y < 350) ||
                (button6.Location.X >= 240 && button6.Location.X < 481) && (button6.Location.Y >= 220 && button6.Location.Y < 350) ||
                (button7.Location.X >= 240 && button7.Location.X < 481) && (button7.Location.Y >= 220 && button7.Location.Y < 350) ||
                (button8.Location.X >= 240 && button8.Location.X < 481) && (button8.Location.Y >= 220 && button8.Location.Y < 350) ||
                (button9.Location.X >= 240 && button9.Location.X < 481) && (button9.Location.Y >= 220 && button9.Location.Y < 350) ||
                (button10.Location.X >= 240 && button10.Location.X < 481) && (button10.Location.Y >= 220 && button10.Location.Y < 350) ||
                (button11.Location.X >= 240 && button11.Location.X < 481) && (button11.Location.Y >= 220 && button11.Location.Y < 350) ||
                (button12.Location.X >= 240 && button12.Location.X < 481) && (button12.Location.Y >= 220 && button12.Location.Y < 350))
            {
                Form6 f = new Form6();
                f.Show();
                Close();
            }
            else
                MessageBox.Show("Неверно!!!!!");

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            button13.Visible = true;
            t.Stop();
        }
    }
}
