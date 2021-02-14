using System;
using System.Collections.Generic;
using System.Text;

namespace ShopInGame.Entities
{
    public class Member:Account
    {
        public string TcNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateBirth { get; set; }
    }
}
