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
    public partial class appetizers : UserControl
    {
        public appetizers()
        {
            InitializeComponent();
        }
        public static int x, count_Appetizer = 0;
        private int a, b, c = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            x = 20;
            a++;
            count_Appetizer = (count_Appetizer + x);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = 26;
            b++;
            count_Appetizer = (count_Appetizer + x);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = 12;
            c++;
            count_Appetizer = (count_Appetizer + x);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            x = 20;
            if (a!= 0)
            {
                count_Appetizer = (count_Appetizer - x);
                a--;
            } 
        }

        private void appetizers_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            x = 26;
            if (b != 0)
            {
                count_Appetizer = (count_Appetizer - x);
                b--;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            x = 12;
            if (c != 0)
            {
                count_Appetizer = (count_Appetizer - x);
                c--;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }
    }
}
