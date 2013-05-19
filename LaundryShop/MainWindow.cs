using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LaundryShop.Components;
using LaundryShop.Models;
/*
   Work to be done:
 *  - Prevent the user from switching views using the tabs on the main tab control.
 *  
 */
namespace LaundryShop
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            
            
        }

        private void MakeNextButton_Click(object sender, EventArgs e)
        {
            //Move selected tab to the next.
            //Add error checking (i.e. at least one order has been added).
            
            MainTabControl.SelectedIndex = 1;

        }

        private void MakeAddButton_Click(object sender, EventArgs e)
        {
            //Add order to a queue. 
            //initialize a new tab page for the order tab control.
            //constructor parameter should come from a counter. Start from 0. 
            OrderTabPage temp = new OrderTabPage("Order # 2");
            OrderListTabControl.Controls.Add(temp);
        }
    }
}
