using ShopInGame.Abstract;
using ShopInGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopInGame.Concreate
{
    public class CheckRealPerson : ICheckRealPerson
    {
        public bool CheckIfRealPerson(Account account)
        {
            return true;
        }
    }
}
