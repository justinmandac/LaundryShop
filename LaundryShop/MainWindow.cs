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
        private ushort orderCount;
        private ushort currentPage; 

        public MainWindow()
        {
            InitializeComponent();
            orderCount = 0;
            currentPage = 0; 
            
        }

        private void MakeNextButton_Click(object sender, EventArgs e)
        {
            //Move selected tab to the next.
            //Add error checking (i.e. at least one order has been added).
            
            MainTabControl.SelectedIndex = 1;
            currentPage = 2;
        }

        private void MakeAddButton_Click(object sender, EventArgs e)
        {
            //Add order to a queue. 
            //Add error checking for fields.
            //initialize a new tab page for the order tab control.
            
            OrderTabPage temp = new OrderTabPage("Order # "+(++orderCount).ToString());
            OrderListTabControl.Controls.Add(temp);

            ResetOrderFields();
        }

        private void ConfirmNextButton_Click(object sender, EventArgs e)
        {
            //Move to Log-in tab.
            MainTabControl.SelectedIndex = 2;
            currentPage = 3; 
        }

        private void ForwardOrderButton_Click(object sender, EventArgs e)
        {
            if (OrderListTabControl.SelectedIndex < OrderListTabControl.Controls.Count)
                OrderListTabControl.SelectedIndex++;
        }

        private void BackwardOrderButton_Click(object sender, EventArgs e)
        {
            if (OrderListTabControl.SelectedIndex > 0 )
                OrderListTabControl.SelectedIndex--;
        }

        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //restrict changing of pages using the tab control's tab pane.
            //MainTabControl.SelectedIndex = currentPage;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            //reset fields for a particular order
            ResetOrderFields();
        }

        private void CancelOrderButton_Click(object sender, EventArgs e)
        {   // removes the order being reviewed from the order list. 
            OrderListTabControl.Controls.Remove(OrderListTabControl.SelectedTab);
        }

        private void ResetOrderFields()
        {
            NoClothesTextBox.Text = "";
            WeightTextBox.Text = "";
            ServiceComboBox.SelectedIndex = 0;
            DueDateCalendar.SetDate(DateTime.Today);
            ItemizeCheckBox.Checked = false; 
        }

        private void ItemizeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ItemizeCheckBox.Checked)
            {
                ItemizeButton.Enabled = true;
            }
            else
            {
                ItemizeButton.Enabled = false;
            }
        }

        private void ItemizeButton_Click(object sender, EventArgs e)
        {
            ushort quant = ushort.Parse(this.NoClothesTextBox.Text);
            ItemizationWindow temp = new ItemizationWindow(quant);
            temp.ShowDialog();
        }
    }
}
