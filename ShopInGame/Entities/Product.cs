using ShopInGame.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopInGame.Entities
{
    public class Product:Item
    {
        public Product(){}
        private double price;
        public double Price { get { return price; } set { price = value; } }

        private double discountPrice;
        public double DiscountPrice // Kapmanyalı fiyat
        {
            get // İlk oluşturulan ürünler kampanyasız bir şekilde oluşturulurlarsa gerçek fiyatı korur. Bir önlem.
            {
                if (ifHaveDiscount == null)
                {
                    return price;
                }
                else
                {
                    return discountPrice;
                }
            }
            set
            {
                discountPrice = value;
            }
        }
        private ProductDiscount ifHaveDiscount;
        public ProductDiscount IfHaveDiscount // Ürünün kampanyası üzerinde değişiklik yapıldığında ürünün kampanya fiyatını günceller.
        {
            get
            {
                return ifHaveDiscount;
            } 
            set
            {
                ifHaveDiscount = value;
                if (ifHaveDiscount == null)
                {
                    discountPrice = Price;
                }
                else
                {
                    discountPrice = price - (price * ifHaveDiscount.DiscountValue / 100);
                }
                
            }
        }
    }
}
