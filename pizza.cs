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
    public partial class pizza : UserControl
    {
        public pizza()
        {
            InitializeComponent();
        }
        public static int x, count_Pizza = 0;
        private int a, b, c, d, f, g;
        
        
            
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = 13;
            a++;
            count_Pizza = (count_Pizza + x);



        }

        private void Pizza_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = 23;
            b++;
            count_Pizza = (count_Pizza + x);
        }

        private void button7_Click(object sender, EventArgs e)
        {

           
            
        }

        public void label14_Click(object sender, EventArgs e)
        {
            
        }

       private void button7_Click_1(object sender, EventArgs e)
        {
           
            
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            x = 18;
            c++;
            count_Pizza = (count_Pizza + x);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            x = 27;
            d++;
            count_Pizza = (count_Pizza + x);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            x = 35;
            f++;
            count_Pizza = (count_Pizza + x);
        }

        private void button7_Click_2(object sender, EventArgs e)
        {
            x = 13;
            if (a != 0)
            {
                count_Pizza = (count_Pizza - x);
                a--;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            x = 23;
            if (b != 0)
            {
                count_Pizza = (count_Pizza - x);
                b--;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            x = 45;
            if (g != 0)
            {
                count_Pizza = (count_Pizza - x);
                g--;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            x = 35;
            if (f != 0)
            {
                count_Pizza = (count_Pizza - x);
                f--;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            x = 27;
            if (d != 0)
            {
                count_Pizza = (count_Pizza - x);
                d--;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            x = 18;
            if (c != 0)
            {
                count_Pizza = (count_Pizza - x);
                c--;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            x = 45;
            g++;
            count_Pizza = (count_Pizza + x);
        }
    }
}
