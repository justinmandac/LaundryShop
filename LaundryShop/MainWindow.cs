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
 *  - Add Thank you page.
 */
namespace LaundryShop
{
    public partial class MainWindow : Form
    {
        private ushort orderCount;
        private ushort currentPage;
        private ushort serviceID; 
        private string[] LaundryList = {"Wash and Fold","Wash and Press","Press Only",
                                       "Handwash","Comforter"};
        private string[] DryCleanList = { "Barong/Coat","Gown"};
        

        public MainWindow()
        {
            InitializeComponent();
            orderCount  = 0;
            currentPage = 0;
            serviceID   = 0;
            AddOrderLabel.Text = "";
            
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
            AddOrderLabel.Text = "Order Added to list!";

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
            DueDateCalendar.SetDate(DateTime.Today);
            ItemizeCheckBox.Checked = false;
            ServiceListBox.Items.Clear();
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
            try
            {
                ushort quant = ushort.Parse(this.NoClothesTextBox.Text);
                ItemizationWindow temp = new ItemizationWindow(quant);
                temp.ShowDialog();
            }
            catch (Exception ex)
            {

            }
         
        }

        // Laundry Service is selected.
        private void LaundryButton_Click(object sender, EventArgs e)
        {
            serviceID = 0;
            AddItemsToListBox(LaundryList);
           
        }
        // Dry Cleaning service is selected.
        private void DryCleanButton_Click(object sender, EventArgs e)
        {

            serviceID = 1;
            AddItemsToListBox(DryCleanList);
           
        }


        private void CarpetButton_Click(object sender, EventArgs e)
        {
            serviceID = 2;
            ServiceListBox.Items.Clear();
            //ServiceDescriptionTextBox.Text = "We clean yo carpet.";
            ServiceDescriptionTextBox.Text = Properties.Resources.CarpetCleanDescription;

        }

        //add items to ListBox
        private void AddItemsToListBox(string[] arr)
        {
            int size = arr.Length;

            ServiceListBox.Items.Clear();
            for (int x = 0; x < size; x++)
            {
                ServiceListBox.Items.Add(arr[x]);
            }
            //Clears AddOrder Label if the user has a new order. 
            AddOrderLabel.Text = "";
        }


        private void ServiceListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            //Changes the service type description. Each main category has a service ID which,
            //for this case, simplifies the process of finding the correct description. 
            //Only Laundry and Dry-Clean categories are considered as they have sub-categories. 
 
            string tmp = "";
            switch (serviceID)
            {
                case 0: // Laundry
                    switch (ServiceListBox.SelectedIndex) 
                    {
                        case 0:
                            tmp = Properties.Resources.WashFoldDescription;
                            break;
                        case 1:
                            tmp = Properties.Resources.WashPressDescription;
                            break;
                        case 2:
                            tmp = Properties.Resources.PressDescription;
                            break;
                        case 3:
                            tmp = Properties.Resources.HandWashDescription;
                            break;
                        case 4:
                            tmp = Properties.Resources.Comforter;
                            break;
                    }
                    break;
                case 1: // Dry-Clean
                    switch (ServiceListBox.SelectedIndex)
                    {
                        case 0: break;
                        case 1: break;
                    }
                    break;
             
                

            }

            ServiceDescriptionTextBox.Text = tmp;
        }
    }
}
