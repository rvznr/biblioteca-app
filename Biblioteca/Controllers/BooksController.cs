using Biblioteca.Data;
using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly BibliotecaDbContext _context;

        public BooksController(BibliotecaDbContext context)
        {
            _context = context;
        }

        // GET: api/Books
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            return await _context.Books.AsNoTracking().ToListAsync();
        }

        // GET: api/Books/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(Guid id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null) return NotFound();
            return book;
        }

        // POST: api/Books
        [HttpPost]
        public async Task<ActionResult<Book>> PostBook(Book book)
        {
            book.Id = Guid.NewGuid();
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetBook), new { id = book.Id }, book);
        }

        // PUT: api/Books/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBook(Guid id, Book updatedBook)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null) return NotFound();

            // Güncellenebilir alanlar
            book.Title = updatedBook.Title;
            book.Author = updatedBook.Author;
            book.Genre = updatedBook.Genre;
            book.Publisher = updatedBook.Publisher;
            book.Summary = updatedBook.Summary;
            book.CoverImage = updatedBook.CoverImage;

            // Notlar
            book.Rating = updatedBook.Rating;
            book.FavoriteQuote = updatedBook.FavoriteQuote;
            book.Notes = updatedBook.Notes;

            await _context.SaveChangesAsync();
            return Ok(book);
        }

        // DELETE: api/Books/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(Guid id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null) return NotFound();

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // GET: api/Books/search?query=orwell&genre=Classic
        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<Book>>> SearchBooks(
            [FromQuery] string? query,
            [FromQuery] string? genre)
        {
            var books = _context.Books.AsQueryable();

            if (!string.IsNullOrEmpty(query))
            {
                books = books.Where(b =>
                    b.Author.Contains(query) ||
                    b.Title.Contains(query));
            }

            if (!string.IsNullOrEmpty(genre))
            {
                books = books.Where(b => b.Genre.Contains(genre));
            }

            return await books.ToListAsync();
        }
        [HttpPost("{id}/upload-cover")]
        public async Task<IActionResult> UploadCover(Guid id, IFormFile file)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null) return NotFound();

            if (file == null || file.Length == 0)
                return BadRequest("No file uploaded.");

            var coversPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "covers");
            if (!Directory.Exists(coversPath))
            {
                Directory.CreateDirectory(coversPath);
            }

            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
            var filePath = Path.Combine(coversPath, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            book.CoverImage = $"covers/{fileName}";
            await _context.SaveChangesAsync();

            return Ok(new { filePath = book.CoverImage });
        }


    }
}
