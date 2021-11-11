using PhoneBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook
{
    public interface IAllPhoneBook
    {
        IEnumerable<PhoneBooks> phoneBooks { get;}
        PhoneBooks GetPhoneBooks(int phoneBookID);
    }
}
