namespace LibraTrack.Domain.Book;

public static class BookErrors
{
    public static Error NotFound = new("Error.NotFound", "The book with the specified identifier was not found");
}