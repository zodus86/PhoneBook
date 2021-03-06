using Microsoft.AspNetCore.Mvc;
using PhoneBook.ViewModels;
using PhoneBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhoneBook.Data;

namespace PhoneBook.Controllers
{
    public class PhoneBooksController : Controller
    {
        private readonly IAllPhoneBook _allPhoneBooks;
        public PhoneBooksController (IAllPhoneBook iAllPhoneBook)
        {
            _allPhoneBooks = iAllPhoneBook;
        }

        public IActionResult List()
        {
            ViewBag.Title = "Cтраница с контактами";

            PhoneBooksListViewModel obj = new PhoneBooksListViewModel();
            obj.AllPhoneBooks = _allPhoneBooks.phoneBooks;
            obj.CurrCategory = "Все контанты";

            return View(obj);
        }

        public IActionResult GetContactInfo (int id)
        {

            PhoneBooks model = _allPhoneBooks.GetPhoneBooks(id);
            return View(model);
        }
        public IActionResult AllInfa()
        {
            PhoneBooksListViewModel obj = new PhoneBooksListViewModel();
            obj.AllPhoneBooks = _allPhoneBooks.phoneBooks;
            obj.CurrCategory = "Все контанты";

            return View(obj);
        }
    }
}
