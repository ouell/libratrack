namespace LibraTrack.Domain.Book;

public interface IBookRepository
{
    void Add(Book booking);
    Task<Book?> GetByIdAsync(BookId id, CancellationToken cancellationToken = default);
}