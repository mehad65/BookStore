using Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Repository
{
    public class BookRepository
    {
        public BookModel GetBookById(int id)
        {
           return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public List<BookModel> SearchBooks(string title, string author)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(author)).ToList();
        }
        public List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel()
                {
                    Id=1,
                    Title="History",
                    Author="RameshChandra"
                },
                new BookModel()
                {
                    Id=2,
                    Title="Math",
                    Author="Mathera"
                },
                new BookModel()
                {
                    Id=3,
                    Title="Science",
                    Author="Niuton"
                },
                new BookModel()
                {
                    Id=4,
                    Title="Chemistry",
                    Author="JohnDalton"
                },
                new BookModel()
                {
                    Id=5,
                    Title="Physics",
                    Author="Sir Ainstine"
                }

            };
        }
    }
}
