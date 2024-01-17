using LibraTrack.Domain.Book.Events;

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

    public static Book Create(Isbn isbn, 
                              Title title, 
                              Author author, 
                              Amount amount, 
                              Category category, 
                              Description description, 
                              YearOfPublication yearOfPublication)
    {
        var book = new Book(BookId.New(), isbn, title, author, amount, category, description, yearOfPublication);
        
        book.RaiseDomainEvent(new BookCreateDomainEvent(book.Id));

        return book;
    }
}