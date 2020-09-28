using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using MyLibraryStores.Models;
using MyLibraryStores.Repository;

namespace MyLibraryStores.Controllers
{
    public class BooksController : Controller
    {
        private IBookRepository _bookrepository = null;

        public BooksController(IBookRepository bookRepository)
        {
            _bookrepository = bookRepository;
        }
        public IActionResult Index()
        {
            var books = _bookrepository.GetBooks();
            return View(books);
        }
        public IActionResult Details(int id)
        {
            var book = _bookrepository.GetBookById(id);
            return View(book);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]

        public IActionResult Create(Book book)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            _bookrepository.AddBook(book);
            return RedirectToAction("Index", "Books");
        }

        [HttpPost]
        public IActionResult Delete(int? id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _bookrepository.DeleteBook(id);
            return RedirectToAction("Index","Books");
        }
        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update( int? id, Book book)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _bookrepository.UpdateBook(id,book);

            return RedirectToAction("Index", "Books");
        }

    }
}
