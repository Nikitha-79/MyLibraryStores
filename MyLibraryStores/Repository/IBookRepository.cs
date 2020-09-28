using MyLibraryStores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibraryStores.Repository
{
  public  interface IBookRepository
    {
        IEnumerable<Book> GetBooks();

        Book GetBookById(int id);
        void AddBook(Book book );
        void UpdateBook(int? id,Book book );
        void DeleteBook(int? id);
    }
}
