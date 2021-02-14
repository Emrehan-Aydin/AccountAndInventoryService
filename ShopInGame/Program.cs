using ShopInGame.Concreate;
using ShopInGame.Entities;
using System;

namespace ShopInGame
{
    class Program
    {
        static void Main(string[] args)
        {
            RegisterManager register = new RegisterManager(new CheckRealPerson());
            AccountManager accountManager = new AccountManager();
            
            //Kampanya oluşturulur
            ProductDiscount KisIndirimi = new ProductDiscount()
            {
                DiscountName = "Kış İndirimi", // kampanya adı
                DiscountValue = 50, // % indirim oranı
            };
            //Kış indirimli adlı %10 luk indirim kampanyası

            //oyun içi ürün ekle
            Product DolunayKilici = new Product()
            {
                ItemId = 1,
                ItemName = "+9 Dolunay Kılıcı :)",
                ProductPrice = 50,
            };

            //market sistemi oluştur
            ShopManager shopManager = new ShopManager();
            
            //Ürün Kampanya sistemi oluşturuldu
            DiscountManager discountManager = new DiscountManager();
            
            // sisteme gerçek bir kullanıcı ve hesap ekle(simule)
            Account uye1 = new Member
            {
                TcNo = "11651651",
                AccountID = 1,
                AccountName = "ChaossEater",
                Password = "123",
                FirstName = "Emrehan",
                LastName = "Aydın",
                DateBirth = new DateTime(1999, 8, 11)
            };
            
            // simule edilmiş özellikler.
            // kontrol et ve kullanıcıyı sisteme ekle
            register.Save(uye1);
            
            // kullanıcıyı güncelleştir
            accountManager.Update(uye1);
            
            // Kullanıcı sil
            accountManager.Delete(uye1);
            
            // Kullanıcı Ürünü satın alır.
            shopManager.Buy(uye1,DolunayKilici);
            
            //Ürüne Kampanya eklenir.
            discountManager.Add(DolunayKilici, KisIndirimi);
            
            // Kullanıcı Kampanya Almış Ürünü satın alır.
            shopManager.Buy(uye1, DolunayKilici);


        }
    }
}
