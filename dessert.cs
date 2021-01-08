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
    public partial class dessert : UserControl
    {
        public dessert()
        {
            InitializeComponent();
        }
        public static int x, count_Dessert = 0;
        private int a, b, c, d, f, g, h, i, j;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            x = 5;
            count_Dessert += x;
            a++;
        }

        private void dessert_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            x = 5;
            count_Dessert += x;
            c++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            x = 7;
            count_Dessert += x;
            f++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            x = 8;
            count_Dessert += x;
            i++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            x = 4;
            count_Dessert += x;
            b++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            x = 3;
            count_Dessert += x;
            d++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = 6;
            count_Dessert += x;
            g++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            x = 4;
            count_Dessert += x;
            j++;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            x = 5;
            count_Dessert += x;
            h++;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            x = 4;
            if (b != 0)
            {
                count_Dessert -= x;
                b--;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            x = 5;
            if (c != 0)
            {
                count_Dessert -= x;
                c--;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            x = 5;
            if (a != 0)
            {
                count_Dessert -= x;
                a--;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            x = 3;
            if (d != 0)
            {
                count_Dessert -= x;
                d--;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            x = 7;
            if (f != 0)
            {
                count_Dessert -= x;
                f--;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            x = 6;
            if (g != 0)
            {
                count_Dessert -= x;
                g--;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            x = 5;
            if (h != 0)
            {
                count_Dessert -= x;
                h--;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            x = 8;
            if (i != 0)
            {
                count_Dessert -= x;
                i--;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            x = 4;
            if (j != 0)
            {
                count_Dessert -= x;
                j--;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label17.Text = count_Dessert.ToString();
        }
    }
}
