namespace DemoProject.Repositories.Interfaces
{
    using DemoProject.Models;
    using System.Collections.Generic;
    public interface IBookRepository
    {
        Book GetBookById(int id);
        IEnumerable<Book> GetAllBooks { get;}
        void Add(Book book);
        void Edit(Book book);
        void Delete(int id);
    }
}
