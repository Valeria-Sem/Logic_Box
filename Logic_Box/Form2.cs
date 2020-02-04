using System;
using System.Drawing;
using System.Windows.Forms;

namespace Logic_Box
{
    public partial class Form2 : Form
    {
        object currObject = null;
        Timer t = new Timer() { Interval = 15000 };

        public Form2()
        {
            InitializeComponent();
            MouseMove += new MouseEventHandler(mouseEvent);
            MouseClick += new MouseEventHandler(mouseClic);
            textBox1.Text = "ЗАДАНИЕ: Переставьте палочки так, чтобы рыбка поплыла в обратном направлении. Другими словами, нужно повернуть рыбу .";
            GenerateMape();
            t.Tick += timer1_Tick;
            button10.Visible = false;
            t.Start();
        }

        private void mouseClic(object sender, MouseEventArgs e)
        {
            currObject = null;
        }

        private void mouseEvent(object sender, MouseEventArgs e)
        {
            if(currObject != null)
            currObject.GetType().GetProperty("Location").SetValue(currObject, new Point(Cursor.Position.X - 300, Cursor.Position.Y-150)); 
        }

        private void GenerateMape()
        {
            for (int i = 0; i < 2; i++)
            {
                PictureBox picture = new PictureBox();
                picture.Location = new Point(i * 100, 100);
                picture.Size = new Size(1, 300);
                picture.BackColor = Color.Black;
                Controls.Add(picture);
            }

            for (int i = 0; i < 2; i++)
            {
                PictureBox picture = new PictureBox();
                picture.Location = new Point(100, i * 100);
                picture.Size = new Size(600, 1);
                picture.BackColor = Color.Black;
                Controls.Add(picture);
            }

            for (int i = 0; i < 2; i++)
            {
                PictureBox picture = new PictureBox();
                picture.Location = new Point(i *700, 100);
                picture.Size = new Size(1, 300);
                picture.BackColor = Color.Black;
                Controls.Add(picture);
            }

            for (int i = 0; i < 2; i++)
            {
                PictureBox picture = new PictureBox();
                picture.Location = new Point(100, i * 400);
                picture.Size = new Size(600, 1);
                picture.BackColor = Color.Black;
                Controls.Add(picture);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currObject = sender;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currObject = sender;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            currObject = sender;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            currObject = sender;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currObject = sender;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currObject = sender;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currObject = sender;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currObject = sender;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if((button1.Location.X == 420 && button1.Location.Y == 292) &&
                (button6.Location.X == 308 && button6.Location.Y == 292) &&
                (button7.Location.X == 242 && button7.Location.Y == 239) &&
                (button8.Location.X == 378 && button8.Location.Y == 192) &&
                (button3.Location.X == 449 && button3.Location.Y == 239) &&
                (button5.Location.X == 271 && button5.Location.Y == 192) )
            {
                MessageBox.Show("Неверно!!!!!");
            }
            else
             if ((button1.Location.X >= 240 && button1.Location.X < 481) && (button1.Location.Y >= 220 && button1.Location.Y < 350) ||
                 (button6.Location.X >= 240 && button6.Location.X < 481) && (button6.Location.Y >= 220 && button6.Location.Y < 350) ||
                 (button7.Location.X >= 240 && button7.Location.X < 481) && (button7.Location.Y >= 220 && button7.Location.Y < 350) ||
                 (button3.Location.X >= 240 && button3.Location.X < 481) && (button3.Location.Y >= 220 && button3.Location.Y < 350) ||
                 (button8.Location.X >= 240 && button8.Location.X < 481) && (button8.Location.Y >= 220 && button8.Location.Y < 350) ||
                 (button5.Location.X >= 240 && button5.Location.X < 481) && (button5.Location.Y >= 220 && button5.Location.Y < 350))
             {
                Form5 f = new Form5();
                f.Show();
                Close();
             }
            else
                MessageBox.Show("Неверно!!!!!");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button10.Visible = true;
            t.Stop();
        }
    }
}
