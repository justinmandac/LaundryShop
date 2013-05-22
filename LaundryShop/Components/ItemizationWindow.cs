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
            this.Close();
        }
    }
}
