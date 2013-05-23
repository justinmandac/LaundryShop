using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LaundryShop.Models;

namespace LaundryShop.Components
{
    public partial class OrderDisplayPanel : UserControl
    {
        public OrderDisplayPanel()
        {
            InitializeComponent();
            
        }
        public OrderDisplayPanel(Order order)
        {          
        
            InitializeComponent();

            //initialize UI components according to Order model.
            this.SelectedServiceLabel.Text = order.ServiceType;
            this.SelectedDueDateLabel.Text = order.DueDate.ToShortDateString();
            this.InputNoClothesLabel.Text = order.NoClothes.ToString();
            this.InputWeightLabel.Text = order.Weight.ToString();
            this.InputItemizationCheckBox.Checked = order.Itemized;
            this.OrderCostLabel.Text = order.Amount.ToString();
        }




    }
}
