using ShopInGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopInGame.Abstract
{
    public interface ICheckRealPerson
    {
        public bool CheckRealPerson(Account account)// Gerçek bir kullanıcı mı ? 
        {
            return true; // true gerçek kullanıcı ; false fake kullanıc
        }
    }
}
