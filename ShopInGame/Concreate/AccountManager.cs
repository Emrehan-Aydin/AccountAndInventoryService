using ShopInGame.Abstract;
using ShopInGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopInGame.Concreate
{
    public class AccountManager : IAccountManager
    {
        public void Delete(Account account)
        {
            Console.WriteLine(account.AccountName + " Kullanıcısı Silindi");
        }
        public void Update(Account account)
        {
            Console.WriteLine(account.AccountName + " Kullanıcısı Güncellendi");
        }
    }
}
