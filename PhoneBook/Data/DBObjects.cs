using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PhoneBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Data
{
    public class DBObjects
    {
        public static void Initial(AppDbContext context)
        {

            if (!context.phoneBooks.Any())
            {
                context.phoneBooks.AddRange(
               new PhoneBooks
               {
                  FirstName = "Ivanov",
                  LastName = "Petr",
                  MiddleName = "Petrovich",
                  Email = "email@mail.ru",
                  TelephonNumber = 88007001111,
                  Submit = "/img/good.jpg"
               }
              ,
             new PhoneBooks
             {
                 FirstName = "Petrov",
                 LastName = "Ivan",
                 MiddleName = "Ivanovich",
                 Email = "email@YANDEX.ru",
                 TelephonNumber = 88001001111,
                 Submit = "/img/norm.jpg"
             }
             ,
             new PhoneBooks
             {
                 FirstName = "Sidorov",
                 LastName = "Gena",
                 MiddleName = "Kozlovskiy",
                 Email = "email@gmail.ru",
                 TelephonNumber = 88911001111,
                 Submit = "/img/bad.jpg"
             }

            );
            }
            context.SaveChanges();
        }

        
    }
}
