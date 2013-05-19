using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LaundryShop.Components
{
    class OrderTabPage : TabPage
    {
        private OrderDisplayPanel orderPanel;
        private ushort id;

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

    }
}
