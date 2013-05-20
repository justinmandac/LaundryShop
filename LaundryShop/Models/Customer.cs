using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaundryShop.Models
{
    public class Customer
    {
        private ushort iD;

        public ushort ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string surName;

        public string SurName
        {
            get { return surName; }
            set { surName = value; }
        }

        private string address; //temporarily set as a string. structure needs to be defined.

        private string phoneNumber;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

    }
}
