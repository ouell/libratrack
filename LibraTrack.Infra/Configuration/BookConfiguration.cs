namespace LibraTrack.Infra.Configuration;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.ToTable("Books");

        builder.HasKey(book => book.Id);

        builder.Property(book => book.Id)
               .HasConversion(bookId => bookId.Value, value => new(value));
        
        builder.Property(book => book.Isbn)
               .HasMaxLength(25)
               .HasConversion(isbn => isbn.Value, value => new(value));
        
        builder.Property(book => book.Title)
               .HasMaxLength(120)
               .HasConversion(title => title.Value, value => new(value));
        
        builder.Property(book => book.Author)
               .HasMaxLength(200)
               .HasConversion(author => author.Value, value => new(value));
        
        builder.Property(book => book.Amount)
               .HasConversion(amount => amount.Value, value => new(value));
        
        builder.Property(book => book.Category)
               .HasConversion(new EnumToStringConverter<Category>());
        
        builder.Property(book => book.Description)
               .HasMaxLength(300)
               .HasConversion(description => description.Value, value => new(value));
        
        builder.Property(book => book.YearOfPublication)
               .HasConversion(yearOfPublication => yearOfPublication.Value, value => new(value));
        
        
        
        
    }
}