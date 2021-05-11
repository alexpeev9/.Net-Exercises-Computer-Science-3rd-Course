namespace ServiceProjectExample.Repositories
{
    using ServiceProjectExample.Data;
    using ServiceProjectExample.Models;
    using System.Collections.Generic;
    using System.Linq;
    public class BookRepository : IBookRepository
    {
        private readonly BookDbContext _bookDbContext;
        public BookRepository(BookDbContext bookDbContext)
        {
            _bookDbContext = bookDbContext;
        }
        //public Book Book(int id) => _bookDbContext.Books.SingleOrDefault(x => x.Id == id);
        //public IEnumerable<Book> Books => _bookDbContext.Books.ToList();

        public void Add(Book book)
        {
            _bookDbContext.Books.Add(book);
            _bookDbContext.SaveChanges();
        }
        //public void Update(Book book)
        //{
        //    //_bookDbContext.Entry(book).State = EntityState.Modified;
        //    _bookDbContext.Books.Update(book);
        //    _bookDbContext.SaveChanges();
        //}
        //public void Delete(int id)
        //{
        //    //_bookDbContext.Books.SingleOrDefault(x => x.Id == id);
        //    _bookDbContext.Books.Remove(Book(id));
        //    _bookDbContext.SaveChanges();
        //}
    }
}
