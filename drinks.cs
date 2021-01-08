using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood
{
    public partial class drinks : UserControl
    {
        public drinks()
        {
            InitializeComponent();
        }
        public static int x, count_drinks = 0;
        private int a, b, c, d, z, f;
        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            x = 15;
            a++;
            count_drinks += x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = 19;
            b++;
            count_drinks += x;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            x = 25;
            c++;
            count_drinks += x;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            x = 27;
            d++;
            count_drinks += x;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = 6;
            z++;
            count_drinks += x;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            x = 15;
            if (a != 0)
            {
                count_drinks -= x;
                a--;
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            x = 19;
            if (b != 0)
            {
                count_drinks -= x;
                b--;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            x = 25;
            if (c != 0)
            {
                count_drinks -= x;
                c--;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            x = 27;
            if (d != 0)
            {
                count_drinks -= x;
                d--;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            x = 6;
            if (z!= 0)
            {
                count_drinks -= x;
                z--;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            x = 8;
            if (f != 0)
            {
                count_drinks -= x;
                z--;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            x = 8;
            f++;
            count_drinks += x;
        }
    }
}
