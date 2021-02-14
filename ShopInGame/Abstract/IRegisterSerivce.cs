using ShopInGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopInGame.Abstract
{
    public interface IRegisterSerivce
    {
        void Save(Account account);
    }
}
