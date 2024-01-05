namespace LibraTrack.Domain.Book;

public record class BookId(Guid Value)
{
    public static BookId New() => new(Guid.NewGuid());
}