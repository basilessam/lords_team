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
    public partial class payment : UserControl
    {
        public payment()
        {
            InitializeComponent();
        }
     
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int total = pizza.count_Pizza + appetizers.count_Appetizer + drinks.count_drinks + dessert.count_Dessert;

            label1.Text = total.ToString() + " $ ";
        }
    }
}
