using ShopInGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopInGame.Abstract
{
    public interface IAccountManager
    {
        void Delete(Account account);
        void Update(Account account);
    }
}
