using System;
using System.Collections.Generic;
using System.Text;
 

namespace Assignment8
{
    public class Shop
    {

        public string ShopName { get; set; }
        public string ShopAddress { get; set; }
        public string ContactDetails { get; set; }

        private List<CustomerInfo> ShoppingCustomers { get; set; }
        public string V { get; }

        public Shop() 
        {
        }



        public Shop(string shopName, string contactDetails, string shopAddress)
        {
            ShopName = shopName;
            ContactDetails = contactDetails;
            ShopAddress = shopAddress;
        }

        public Shop(string v)
        {
            V = v;
        }

        public void AddOrder(CustomerInfo newOrder)
        {
            ShoppingCustomers.Add(newOrder);
        }

    }
}
