using PhoneBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Mocks
{
   /// <summary>
   /// Для хранения без sql Базы данных
   /// </summary>
    public class MockPhoneBook : IAllPhoneBook
    {
        public IEnumerable<PhoneBooks> phoneBooks {

            get => new List<PhoneBooks> {
                new PhoneBooks{
                    FirstName= "Ivanov" ,
                    LastName = "Petr",
                    MiddleName = "Petrovich",
                    Email = "email@mail.ru",
                    TelephonNumber = 88007001111,
                    Submit= "/img/good.jpg"}
              ,
             new PhoneBooks{
                    FirstName= "Petrov" ,
                    LastName = "Ivan",
                    MiddleName = "Ivanovich",
                    Email = "email@YANDEX.ru",
                    TelephonNumber = 88001001111,
                    Submit= "/img/norm.jpg"
             }
             ,
             new PhoneBooks{
                    FirstName= "Sidorov" ,
                    LastName = "Gena",
                    MiddleName = "Kozlovskiy",
                    Email = "email@gmail.ru",
                    TelephonNumber = 88911001111,
                    Submit= "/img/bad.jpg"
             }
            };
        }

        public PhoneBooks GetPhoneBooks(int phoneBookID)
        {
            throw new NotImplementedException();
        }
    }
}
