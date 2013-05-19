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
        private Order Order; 
        public OrderDisplayPanel()
        {
            InitializeComponent();
            
        }
        public OrderDisplayPanel(Order order)
        {
            Order = order;
            InitializeComponent();
            //initialize UI components according to Order model.
        }

        public ushort getID()
        {
            return Order.OrderID;
        }


    }
}
