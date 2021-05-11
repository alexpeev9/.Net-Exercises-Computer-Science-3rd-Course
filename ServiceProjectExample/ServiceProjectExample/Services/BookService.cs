namespace ServiceProjectExample.Services
{
    using ServiceProjectExample.Models;
    using ServiceProjectExample.Repositories;
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public Book CreateBook (Book book)
        {
            _bookRepository.Add(book);
            return book;
        }
    }
}
