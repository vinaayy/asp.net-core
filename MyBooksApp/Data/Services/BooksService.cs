using System.Collections.Generic;
using System.Linq;
using MyBooksApp.Data.Model;
using MyBooksApp.Data.ViewModels;

namespace MyBooksApp.Data.Services
{
    public class BooksService
    {
        private AppDbContext _dbContext;
        public BooksService(AppDbContext context)
        {
            _dbContext = context;
        }
        public void AddBook(BookVM book)
        {
            var _book = new Book()
            {
                Title = book.Title,
                Description = book.Description,
                isRead = book.isRead,
                Rate = book.isRead ? book.Rate : null,
                Genre = book.Genre,
                Author = book.Author,
                CoverURL = book.CoverURL,
                DateAdded = System.DateTime.Now
            };
            _dbContext.Books.Add(_book);
            _dbContext.SaveChanges();
        }

        public List<Book> GetAllBooks()
        {
            var allBooks = _dbContext.Books.ToList();
            return allBooks;
        }
        public Book GetBookById(int bookId)
        {
           return _dbContext.Books.FirstOrDefault(n=>n.Id==bookId);  
        }

        public Book UpdateBookById(int bookId , BookVM book)
        {
            var _book = _dbContext.Books.FirstOrDefault(n => n.Id == bookId);
            if(_book != null)
            {
                _book.Title = book.Title;
                _book.Description = book.Description;
                _book.isRead = book.isRead;
                _book.Rate = book.isRead ? book.Rate : null;
                _book.Genre = book.Genre;
                _book.Author = book.Author;
                _book.CoverURL = book.CoverURL;

                _dbContext.SaveChanges();
            }
            return _book;
        }
        public void DeleteBookById(int bookId)
        {
            var _book = _dbContext.Books.FirstOrDefault(n => n.Id == bookId);
            if (_book != null)
            {
                _dbContext.Books.Remove(_book);
                _dbContext.SaveChanges();
            }
        }
    }
}
