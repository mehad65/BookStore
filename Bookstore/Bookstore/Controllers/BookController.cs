using Bookstore.Models;
using Bookstore.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Controllers
{
    public class BookController : Controller
    {
        public readonly BookRepository BookRepo = null;
        public BookController()
        {
            BookRepo = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var data= BookRepo.GetAllBooks();
            return View();
        }
        public BookModel GetBookById(int id)
        {
            return BookRepo.GetBookById(id);
        }
        public List<BookModel> SearchBooks(string bookname,string author)
        {
            return BookRepo.SearchBooks(bookname,author);
        }
    }
}
