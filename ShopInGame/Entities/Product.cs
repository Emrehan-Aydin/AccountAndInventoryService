using ShopInGame.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopInGame.Entities
{
    public class Product:Item
    {
        public Product(){}
        private double productPrice;
        public double ProductPrice { get { return productPrice; } set { productPrice = value; } }

        private double productDiscountPrice;
        public double ProductDiscountPrice // Kapmanyalı fiyat
        {
            get // İlk oluşturulan ürünler kampanyasız bir şekilde oluşturulurlarsa gerçek fiyatı korur. Bir önlem.
            {
                if (ifHaveDiscount == null)
                {
                    return productPrice;
                }
                else
                {
                    return productDiscountPrice;
                }
            }
            set
            {
                productDiscountPrice = value;
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
                    productDiscountPrice = productPrice;
                }
                else
                {
                    productDiscountPrice = productPrice - (productPrice * ifHaveDiscount.DiscountValue / 100);
                }
                
            }
        }
    }
}
