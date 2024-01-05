namespace LibraTrack.Domain.Book;

public sealed class Book : Entity<BookId>
{
    public Book(BookId id,
                Isbn isbn,
                Title title,
                Author author,
                Amount amount,
                Category category,
                Description description,
                YearOfPublication yearOfPublication) : base(id)
    {
        Isbn = isbn;
        Title = title;
        Author = author;
        Amount = amount;
        Category = category;
        Description = description;
        YearOfPublication = yearOfPublication;
    }

    private Book()
    {
    }

    public Isbn Isbn { get; private set; }

    public Title Title { get; private set; }

    public Author Author { get; private set; }

    public Amount Amount { get; private set; }

    public Category Category { get; private set; }

    public Description Description { get; private set; }

    public YearOfPublication YearOfPublication { get; private set; }
}