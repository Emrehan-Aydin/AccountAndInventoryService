using ShopInGame.Abstract;
using ShopInGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopInGame.Concreate
{
    class DiscountManager : IDiscountManagerService
    {
        public void Add(Product product,ProductDiscount productDiscount)
        {
            product.ifHaveDiscount = productDiscount;
        }
    }
}
