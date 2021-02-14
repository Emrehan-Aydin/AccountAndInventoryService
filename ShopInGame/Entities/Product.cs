using ShopInGame.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopInGame.Entities
{
    public class Product:Item
    {
        public Product()
        {
        }
        public double ProductPrice { get; set; }
        private double ProductDiscountPrice;
        public double productDiscountPrice // Kapmanyalı fiyat
        {
            get // İlk oluşturulan ürünler kampanyasız bir şekilde oluşturulurlarsa gerçek fiyatı korur. Bir önlem.
            {
                if (IfHaveDiscount == null)
                {
                    return ProductPrice;
                }
                else
                {
                    return ProductDiscountPrice;
                }

            }
            set
            {
                ProductDiscountPrice = value;
            }
        }
        private ProductDiscount IfHaveDiscount;
        public ProductDiscount ifHaveDiscount // Ürünün kampanyası üzerinde değişiklik yapıldığında ürünün kampanya fiyatını günceller.
        {
            get
            {
                return IfHaveDiscount;
            } 
            set
            {
                IfHaveDiscount = value;
                if (ifHaveDiscount == null)
                {
                    ProductDiscountPrice = ProductPrice;
                }
                else
                {
                    ProductDiscountPrice = ProductPrice - (ProductPrice * ifHaveDiscount.DiscountValue / 100);
                }
            }
        }
    }
}
