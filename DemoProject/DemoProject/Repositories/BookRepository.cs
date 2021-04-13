namespace DemoProject.Repositories
{
    using DemoProject.Data;
    using DemoProject.Models;
    using DemoProject.Repositories.Interfaces;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;

    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public BookRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public Book GetBookById(int id) => _appDbContext.Books.AsNoTracking().SingleOrDefault(x => x.Id == id);
        public IEnumerable<Book> GetAllBooks => _appDbContext.Books.AsNoTracking().ToList();
        public void Add(Book book)
        {
            _appDbContext.Books.Add(book);
            _appDbContext.SaveChanges();
        }
        public void Update(Book book)
        {
            _appDbContext.Entry(book).State = EntityState.Modified;
            _appDbContext.SaveChanges();
        }
        public void Delete(int Id)
        {
            Book book = GetBookById(Id);
            _appDbContext.Books.Remove(book);
            _appDbContext.SaveChanges();
        }
    }
}
