using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaundryShop.Models
{
    // Item Model
    // Item == Piece of clothing
    public class Item
    {
        private string brand;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
