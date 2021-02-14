using ShopInGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopInGame.Abstract
{
    public interface IShopManagerService
    {
        void Buy(Account account,Product product);  
    }
}
