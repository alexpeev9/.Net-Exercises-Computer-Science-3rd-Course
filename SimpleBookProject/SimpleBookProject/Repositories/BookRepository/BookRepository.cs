namespace SimpleBookProject.Repositories.BookRepository
{
    using Microsoft.EntityFrameworkCore;
    using SimpleBookProject.Data;
    using SimpleBookProject.Models;
    using System.Collections.Generic;
    using System.Linq;
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public BookRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public Book GetBookById(int id) => _appDbContext.Books
                    .AsNoTracking()
                    .SingleOrDefault(x => x.Id == id);
        public IEnumerable<Book> GetAllBooks => _appDbContext.Books
                    .AsNoTracking()
                    .ToList();
        public void Add(Book book)
        {
            _appDbContext.Books.Add(book);
            _appDbContext.SaveChanges();
        }
        public void Edit(Book book)
        {
            // because reflection
            //._appDbContext.Entry(car).State = EntityState.Modified;
            _appDbContext.Books.Update(book);
            _appDbContext.SaveChanges();
        }
        public void Delete(int bookId)
        {
            var book = _appDbContext.Books.SingleOrDefault(x => x.Id == bookId);
            _appDbContext.Books.Remove(book);
            _appDbContext.SaveChanges();
        }
    }
}
