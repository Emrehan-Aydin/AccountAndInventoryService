using ShopInGame.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopInGame.Entities
{
    public class Account
    {
        public Account()
        {
            InventoryItems = new List<Item>();    
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public List<Item> InventoryItems { get; set; }
    }
}
