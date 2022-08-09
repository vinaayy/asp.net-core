using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBooksApp.Data.Services;
using MyBooksApp.Data.ViewModels;

namespace MyBooksApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BooksService _booksService;
        public BooksController(BooksService bookservices)
        {
            _booksService = bookservices;
        }
        [HttpPost("add-book")]
        public IActionResult AddBook([FromBody]BookVM books)
        {
            _booksService.AddBook(books);
            return Ok();
        }
        [HttpGet ("get-all-books")]
        public IActionResult GetAllBooks()
        {
            var books = _booksService.GetAllBooks();
            return Ok(books);
        }
        [HttpGet("get-all-book-by-id/{Id}")]
        public IActionResult GetBookById(int Id)
        {
            var book = _booksService.GetBookById(Id);
            return Ok(book);
        }
        [HttpPut("update-book-by-id/{Id}")]
        public IActionResult UpdateBookById(int Id , [FromBody]BookVM book)
        {
            var updateBook = _booksService.UpdateBookById(Id , book);
            return Ok(updateBook);
        }
        [HttpDelete("delete-book-by-id/{Id}")]
        public IActionResult DeleteBookById(int Id)
        {
            _booksService.DeleteBookById(Id);
            return Ok();
        }
    }
}
