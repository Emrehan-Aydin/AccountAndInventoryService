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
            Console.WriteLine("{0} iteminde {1} Kampanyası başlatılarak %{2} indirim tanımlandı.",product.Name,productDiscount.DiscountName,productDiscount.DiscountValue);
        }
        public void Remove(Product product, ProductDiscount productDiscount)
        {
            product.IfHaveDiscount = null;
            Console.WriteLine("{0} iteminin {1} kampanyası sona erdi", product.Name, productDiscount.DiscountName);
        }
        public void Update(Product product, ProductDiscount productDiscount)
        {
            product.IfHaveDiscount = productDiscount;
            Console.WriteLine("{0} iteminin kampanyası {1} kapmanyası olarak güncellendi.", product.Name, productDiscount.DiscountName, productDiscount.DiscountValue);
        }
    }
}
