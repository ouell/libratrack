namespace LibraTrack.Infra.Repositories;

internal sealed class BookRepository : Repository<Book, BookId>, IBookRepository

{
    public BookRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}