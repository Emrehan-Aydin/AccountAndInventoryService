using ShopInGame.Concreate;
using ShopInGame.Entities;
using System;

namespace ShopInGame
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Kayıt olma Servisi oluştur
            RegisterManager register = new RegisterManager(new CheckRealPerson());
            
            //Hesap Kimlik servisi oluştur
            AccountManager accountManager = new AccountManager();
            
            //market sistemi oluştur
            ShopManager shopManager = new ShopManager();

            //Ürün Kampanya sistemi oluşturuldu
            DiscountManager discountManager = new DiscountManager();


            //Kampanya oluştur
            ProductDiscount KisIndirimi = new ProductDiscount()
            {
                DiscountName = "Kış İndirimi", // kampanya adı
                DiscountValue = 50, // % indirim oranı
            };
            ProductDiscount YazIndirimi = new ProductDiscount()
            {
                DiscountName = "Yaz İndirimi", // kampanya adı
                DiscountValue = 75, // % indirim oranı
            };
            //Kış indirimli adlı %10 luk indirim kampanyası

            //oyun içi ürün oluştur
            Product DolunayKilici = new Product()
            {
                ItemId = 1,
                ItemName = "+9 Dolunay Kılıcı", // aga be :)
                ProductPrice = 50,
            };
            // Gerçek Oyuncu Oluştur.
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
            
            // Kullanıcı Ürünü satın alır.
            shopManager.Buy(uye1,DolunayKilici);
            
            //Ürüne Kampanya eklenir.
            discountManager.Add(DolunayKilici, KisIndirimi);
            
            // Kullanıcı Kampanya Almış Ürünü satın alır.
            shopManager.Buy(uye1, DolunayKilici);
            
            //Ürüne Kampanya eklenir.
            discountManager.Remove(DolunayKilici, KisIndirimi);

            // Kullanıcı Kampanya Almış Ürünü satın alır.
            shopManager.Buy(uye1, DolunayKilici);
            
            //Ürüne Kampanya eklenir.
            discountManager.Update(DolunayKilici, YazIndirimi);

            // Kullanıcı Kampanya Almış Ürünü satın alır.
            shopManager.Buy(uye1, DolunayKilici);

            // Kullanıcı sil
            accountManager.Delete(uye1);

        }
    }
}
