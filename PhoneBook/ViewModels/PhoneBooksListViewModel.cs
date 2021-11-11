using PhoneBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.ViewModels
{
    public class PhoneBooksListViewModel
    {
        public IEnumerable<PhoneBooks> AllPhoneBooks { get; set; }
        
        public string CurrCategory { get; set; }

    }
}
