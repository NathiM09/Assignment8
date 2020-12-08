using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SQLite;

namespace Assignment8
{
   public class OrderDatabase
    {
        private  SQLiteConnection _database;
        public OrderDatabase()
        {

            var path = GetDbPath();
            _database = new SQLiteConnection(path);

            _database.CreateTable<Order>();
            
        }

        public string GetDbPath()
        {
            var path = Path.Combine(Environment.GetFolderPath(folder: Environment.SpecialFolder.LocalApplicationData),"database.db");

                return path;
        }
        public void OrderDatadase()
        {
            Shop ShopName = new Shop();
            CustomerInfo myNewOrder = new CustomerInfo();
                ShopName.AddOrder(myNewOrder);
        }

            

    }
}
