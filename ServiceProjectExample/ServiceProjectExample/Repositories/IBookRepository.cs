namespace ServiceProjectExample.Repositories
{
    using ServiceProjectExample.Models;
    using System.Collections.Generic;
    public interface IBookRepository
    {
        //Book Book(int id);
        //IEnumerable<Book> Books { get; }
        void Add(Book book);
        //void Update(Book book);
        //void Delete(int id);
    }
}
