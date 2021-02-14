using ShopInGame.Abstract;
using ShopInGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopInGame.Concreate
{
    public class RegisterManager : IRegisterSerivce
    {
        private ICheckRealPerson _checkRealPerson;
        public RegisterManager(ICheckRealPerson checkRealPerson)
        {
            _checkRealPerson = checkRealPerson;
        }
        public void Save(Account account)
        {
            if(_checkRealPerson.CheckRealPerson(account))
            {  
                Console.WriteLine(account.Name +" Adlı kullanıcı Kayıt Edildi");
            }
            else
            {
                Console.WriteLine("Belirtilen kullanıcı kriterlere uymuyor!");
            }
        }
    }
}
