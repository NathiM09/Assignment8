using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Assignment8
{
    public class CustomerInfo
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Tshirtsize { get; set; }
        public string TshirtColor { get; set; }

        public string ShippingAddress { get; set; }








    }
}
