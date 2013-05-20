using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaundryShop.Models
{
    public class Order
    {   // check if Order should be unified for all uses (i.e. for all instances this model will be used)
        //orderID does not identify the order in the Order Database. 
        private ushort orderID;

        public ushort OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }
        private DateTime dueDate;

        public DateTime DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }
        private DateTime orderDate;

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        private ushort noClothes;

        public ushort NoClothes
        {
            get { return noClothes; }
            set { noClothes = value; }
        }
        private float weight;

        public float Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        private float amount;

        public float Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        private String serviceType;

        public String ServiceType
        {
            get { return serviceType; }
            set { serviceType = value; }
        }
    }
}
