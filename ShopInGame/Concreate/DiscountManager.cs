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
            product.IfHaveDiscount = productDiscount;
            Console.WriteLine("{0} Adlı ürüne {1} Adlı kampanya uygulanarak %{2} indirim tanımlandı",product.ItemName,productDiscount.DiscountName,productDiscount.DiscountValue);
        }
    }
}
