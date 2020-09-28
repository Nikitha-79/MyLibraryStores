using MyLibraryStores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace MyLibraryStores.Repository
{
    public class MockBookRepository : IBookRepository
    {
        public Book GetBookById(int id)
        {
            var books = GetBooks();
            return books.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book{Id=1,BookName="Wings Of Fire",AuthorName="APJ Kalam",ISBN="IS1234",PublishedDate=Convert.ToDateTime("10/10/1998")},
                new Book{Id=2,BookName="Vision of the Past",AuthorName="Michel Madhusudan Dutta",ISBN="IS423",PublishedDate=Convert.ToDateTime("15/08/1980")},
                new Book{Id=3,BookName="Captive Lady",AuthorName="B. Bhattacharia",ISBN="IS984",PublishedDate=Convert.ToDateTime("05/03/1975")},
                new Book{Id=4,BookName="A Nation is Making",AuthorName="Surendra Nath Bandhopadhye",ISBN="IS1674",PublishedDate=Convert.ToDateTime("28/09/2000")},
                new Book{Id=5,BookName="War and Peace",AuthorName="Tolstoy",ISBN="IS14334",PublishedDate=Convert.ToDateTime("16/06/1994")},
            };
        }

        public void AddBook(Book book)
        {

        }
        public void DeleteBook(int? id)
        {

        }

        public void UpdateBook(int? id,Book book)
        {

        }
    }
}
