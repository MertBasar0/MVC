using System.ComponentModel.DataAnnotations;

namespace WebApplication14_FluentValidation.Models
{
    public class Person
    {
        //NotNull
        //a ile başlamalı
        public string ıd { get; set; }

        //uzunluğu max 10
        public string Name { get; set; }

        //Email doğrulaması
        public string Email { get; set; }

        //Telefon doğrulaması
        [Phone]
        public string Telefon { get; set; }

        //Yas 18 ile 90 yas arasında olma
        public int Yas { get; set; }

        //kart doğrulaması
        public int CreditCard { get; set; }
    }
}
