using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LaundryShop.Components
{
    public partial class ItemizationWindow : Form
    {
        private ushort quantity;

        public ushort Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public ItemizationWindow()
        {
            InitializeComponent();
        }

        public ItemizationWindow(ushort quant)
        {
            InitializeComponent();
            quantity = quant;

            ItemizationTable.Rows.Add(quantity);
        }
        private void ItemizationCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ItemizationDoneButton_Click(object sender, EventArgs e)
        {
            ushort _quantity;

            quantity = (ushort)ItemizationTable.Rows.Count;
            
            this.Close();
        }

        private bool check()
        {
            //check if every row has been filled. 
            
            ushort prod;

            

            return true;
        }
    }
}
