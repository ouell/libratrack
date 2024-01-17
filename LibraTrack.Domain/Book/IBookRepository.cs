namespace LibraTrack.Domain.Book;

public interface IBookRepository
{
    void Update(Book book);
    void Remove(Book book);
    Task AddAsync(Book book, CancellationToken cancellationToken);
    Task<Book?> GetByIdAsync(BookId id, CancellationToken cancellationToken = default);
}