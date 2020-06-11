using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pass
{
    public partial class Form1 : Form
    {
        //Vars
        int speed = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Buttons(speed);
            Pictures(speed);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void Pictures(int f)
        {
            f += 10;
            pictureBox1.Left += f;
            if (pictureBox1.Left > 1000)
                pictureBox1.Left = -70;

            if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
                Swap(ref pictureBox1, ref pictureBox2);


            s1.Text = "SPEED = " + f;
        }
        private void Buttons(int s)
        {
            s += 10;
            button1.Left -= s;
            if (button1.Right < 0)
                button1.Left = 1000;

            if (button1.Bounds.IntersectsWith(button2.Bounds))
                Swap(ref button1, ref button2);

            s2.Text = "SPEED = " + s;

        }

        private void Swap<t>(ref t a, ref t b)
        {
            t temp = a;
            a = b;
            b = temp;
        }

    }
}
