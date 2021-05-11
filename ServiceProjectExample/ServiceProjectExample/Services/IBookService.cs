namespace ServiceProjectExample.Services
{
    using ServiceProjectExample.Models;
    public interface IBookService
    {
        Book CreateBook(Book book);
    }
}
