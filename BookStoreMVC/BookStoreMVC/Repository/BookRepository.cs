using BookStoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreMVC.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            var result = DataSource().Where(x => x.Author.Contains(authorName) || x.Title.Contains(title)).ToList();
            return result;
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id = 1, Title="MVC", Author= "Nitish"},
                new BookModel(){Id = 2, Title="Dot Net Core", Author= "Nitish"},
                new BookModel(){Id = 3, Title="C#", Author= "Monika"},
                new BookModel(){Id = 4, Title="Java", Author= "Webgentle"},
                new BookModel(){Id = 5, Title="Php", Author= "Webgentle"}
            };
        }
    }
}
