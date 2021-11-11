using PhoneBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Data
{
    public class PhoneBookRepository : IAllPhoneBook
    {
        private readonly AppDbContext appDbContext;
        public PhoneBookRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<PhoneBooks> phoneBooks => appDbContext.phoneBooks; //.Include(c => c.FirstName);

        public PhoneBooks GetPhoneBooks(int phoneBookID) => appDbContext.phoneBooks.FirstOrDefault(p => p.Id == phoneBookID);
    }
}
