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
        /*
         * OrderList will be used to hold the FINAL orders (i.e. to be submitted to the database)
         * Will be populated by retrieving the Order objects in each tab page in OrderListTabControl.
         */
        private LinkedList<Order> OrderList;
       
        public MainWindow()
        {
            InitializeComponent();
            orderCount  = 0;
            currentPage = 0;
            serviceID   = 0;
            AddOrderLabel.Text = "";
            OrderList = new LinkedList<Order>();
     
        }

        private void MakeNextButton_Click(object sender, EventArgs e)
        {
            //Move selected tab to the next.

            if (OrderListTabControl.TabCount > 0) //At least one order must be added to proceed to the next page.
            {
                MainTabControl.SelectedIndex = 1;
                currentPage = 2;
            }
            else
            {
                AddOrderLabel.Text = "Place an order first.";
            }
        }

        private void MakeAddButton_Click(object sender, EventArgs e)
        {
            bool error = false;
            Order _ord = new Order();

            try
            {
                
                _ord.OrderID = ++orderCount;
                _ord.ServiceType = ServiceListBox.SelectedItem.ToString();
                _ord.OrderDate = DateTime.Today;
                _ord.DueDate = DueDateCalendar.SelectionStart;
                _ord.NoClothes = ushort.Parse(NoClothesTextBox.Text); 
                _ord.Weight = float.Parse(WeightTextBox.Text); 
                _ord.Itemized = ItemizeCheckBox.Checked;
                _ord.Amount = 100; // temporary value

                //add error checking here.

            }
            catch (Exception ex)
            {
                //add handling for parsing exceptions here (i.e. dialog boxes).
                error = true;
                Console.Out.WriteLine(ex.InnerException);
            }

            //initialize a new tab page for the order tab control.
            if (!error)
            {
                OrderTabPage temp = new OrderTabPage("Order # " + _ord.OrderID.ToString(), _ord);

                OrderListTabControl.Controls.Add(temp);
                AddOrderLabel.Text = "Order Added to list!";

                ResetOrderFields();
            }
            else
            {
                AddOrderLabel.Text = "Error!";
            }
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

                NoClothesTextBox.Text = temp.Quantity.ToString();

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.Message);
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
        //Carpet cleaning service is selected.
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
            //Update Descriptio Box
            ServiceDescriptionTextBox.Text = tmp;
        }

        private void LogInYesButton_Click(object sender, EventArgs e)
        {
            LogInDetailsPanel.Enabled = true;
            SignUpDetailsPanel.Enabled = false;
            ExistingUserPanel.BackColor = System.Drawing.Color.DarkGray;
            NewUserPanel.BackColor = Control.DefaultBackColor;
        }

        private void LogInNoButton_Click(object sender, EventArgs e)
        {
            SignUpDetailsPanel.Enabled = true;
            LogInDetailsPanel.Enabled  = false;
            ExistingUserPanel.BackColor = Control.DefaultBackColor;
            NewUserPanel.BackColor = System.Drawing.Color.DarkGray;
        }

        private void ConfirmPage_Enter(object sender, EventArgs e)
        {
            //Compute total cost when page gains focus. 
            float totalCost = 0;

            for (int x = 0; x < OrderListTabControl.TabPages.Count; x++)
            {
                totalCost+= OrderListTabControl.TabPages.Cast<OrderTabPage>().ElementAt(x).Amount();
                
            }

            ConfirmTotalCostLabel.Text = "Total Cost: " + totalCost.ToString() + " Php";
        }
    }
}
