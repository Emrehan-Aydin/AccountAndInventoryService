using ShopInGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopInGame.Abstract
{
    public interface ICheckRealPerson
    {
        public bool CheckRealPerson(Account account)
        {
            return true;
        }
    }
}
