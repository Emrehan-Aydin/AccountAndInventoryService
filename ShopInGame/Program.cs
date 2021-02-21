using ShopInGame.Abstract;
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
            IAccountManager accountManager = new AccountManager();
            
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
            //Yaz indirimi adlı %50 lik indirim kampanyası
            ProductDiscount YazIndirimi = new ProductDiscount()
            {
                DiscountName = "Yaz İndirimi", // kampanya adı
                DiscountValue = 75, // % indirim oranı
            };
            //Kış indirimi adlı %75 luk indirim kampanyası

            //oyun içi ürün oluştur
            Product DolunayKilici = new Product()
            {
                Id = 1,
                Name = "+9 Dolunay Kılıcı", // aga be :)
                Price = 50,
            };
            // Gerçek Oyuncu Oluştur.
            Account uye1 = new Member
            {
                TcNo = "olmbakgit",
                ID = 1,
                Name = "ChaossEater",
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
            
            // Kullanıcı Ürünü satın alır.
            shopManager.Buy(uye1, DolunayKilici);
            
            //Ürüne Kampanya eklenir.
            discountManager.Remove(DolunayKilici, KisIndirimi);

            // Kullanıcı Ürünü satın alır.
            shopManager.Buy(uye1, DolunayKilici);
            
            //Ürün Kampanyası güncellenir.
            discountManager.Update(DolunayKilici, YazIndirimi);

            // Kullanıcı Ürünü satın alır.
            shopManager.Buy(uye1, DolunayKilici);

            // Kullanıcı sil
            accountManager.Delete(uye1);

        }
    }
}
