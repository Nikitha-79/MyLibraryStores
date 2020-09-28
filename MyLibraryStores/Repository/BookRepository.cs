using MyLibraryStores.Data;
using MyLibraryStores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace MyLibraryStores.Repository
{
    public class BookRepository : IBookRepository
    {
        private ApplicationDbContext _dbcontext = null;
        public BookRepository(ApplicationDbContext dbContext)
        {
            _dbcontext = dbContext;
        }

        public Book GetBookById(int id)
        {
            return _dbcontext.Books.ToList().SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<Book> GetBooks()
        {
            return _dbcontext.Books.ToList();
        }

        public void AddBook(Book book)
        {
            _dbcontext.Add(book);
            _dbcontext.SaveChanges();
        }

        public void DeleteBook(int? id)
        {
            var book = _dbcontext.Books.SingleOrDefault(b => b.Id == id.Value);
            _dbcontext.Books.Remove(book);
            _dbcontext.SaveChanges();
        }

       
        public void UpdateBook(int? id, Book book)
        {
            var book1 = _dbcontext.Books.SingleOrDefault(b => b.Id == id.Value);
            book1.BookName = book.BookName;
            book1.AuthorName = book.AuthorName;
            book1.ISBN = book.ISBN;
            book1.Genre = book.Genre;
            book1.PublishedDate = book.PublishedDate;
            _dbcontext.SaveChanges();

        }
    }
}
