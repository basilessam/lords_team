using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = Home.Height;
            SidePanel.Top = Home.Top;
            home1.BringToFront();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Home.Height;
            SidePanel.Top = Home.Top;
            home1.BringToFront();
        }

        private void Eatin_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Eatin.Height;
            SidePanel.Top = Eatin.Top;
            eat_In1.BringToFront();
        }

        private void collections_Click(object sender, EventArgs e)
        {
            SidePanel.Height = collections.Height;
            SidePanel.Top = collections.Top;
            collections1.BringToFront();
        }

        private void Delivery_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Delivery.Height;
            SidePanel.Top = Delivery.Top;
            delivery1.BringToFront();
        }

        private void takeaway_Click(object sender, EventArgs e)
        {
            SidePanel.Height = takeaway.Height;
            SidePanel.Top = takeaway.Top;
            take_Away1.BringToFront();
        }

        private void driverpayment_Click(object sender, EventArgs e)
        {
            SidePanel.Height = driverpayment.Height;
            SidePanel.Top = driverpayment.Top;
            driver_Payment1.BringToFront();
        }

        private void customers_Click(object sender, EventArgs e)
        {
            SidePanel.Height = customers.Height;
            SidePanel.Top = customers.Top;
            customers1.BringToFront();
        }

        private void home1_Load(object sender, EventArgs e)
        {

        }
        //Thanks For Watching//
        //Like and Subscribe//
        //Muhammad Shafique//
    }
}
