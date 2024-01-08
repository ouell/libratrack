namespace LibraTrack.Infra.Configuration;

public class LoanConfiguration : IEntityTypeConfiguration<Loan>
{
    public void Configure(EntityTypeBuilder<Loan> builder)
    {
        builder.ToTable("Loans");

        builder.HasKey(loan => loan.Id);
        
        builder.Property(loan => loan.DateOfLoan)
               .HasConversion(dateOfLoan => dateOfLoan.Value, value => new(value));
        
        builder.Property(loan => loan.ExpectedReturnDate)
               .HasConversion(expectedReturnDate => expectedReturnDate.Value, value => new(value));
        
        builder.Property(loan => loan.ReturnDate)
               .HasConversion(returnDate => returnDate.Value, value => new(value));
        
        builder.Property(loan => loan.Status)
               .HasConversion(new EnumToStringConverter<Status>());

        builder.HasOne<Book>()
               .WithMany()
               .HasForeignKey(loan => loan.BookId);

        builder.HasOne<User>()
               .WithMany()
               .HasForeignKey(loan => loan.UserId);
    }
}