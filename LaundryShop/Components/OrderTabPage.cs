using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LaundryShop.Models;

namespace LaundryShop.Components
{
    class OrderTabPage : TabPage
    {
        private OrderDisplayPanel orderPanel;
        private ushort id;
        private Order _order;

        public Order Order
        {
            get { return _order; }
            
        } 
        public ushort ID
        {
            get { return id; }
            set { id = value; }
        } 

        public OrderTabPage(String name)
        {
            
            this.Text = name;
            orderPanel = new OrderDisplayPanel();
            this.Controls.Add(orderPanel);
            
        }
        public OrderTabPage(String name, Order order)
        {
            _order = order;
            this.Text = name;
            orderPanel = new OrderDisplayPanel(order);
            this.Controls.Add(orderPanel);

        }

        public float Amount()
        {
            return _order.Amount;
        }

    }
}
