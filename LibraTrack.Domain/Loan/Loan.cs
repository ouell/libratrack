namespace LibraTrack.Domain.Loan;

public class Loan : Entity<LoanId>
{
    private Loan()
    {
    }

    public Loan(LoanId id,
                BookId bookId,
                UserId userId,
                DateOfLoan dateOfLoan,
                ExpectedReturnDate expectedReturnDate,
                Status status) : base(id)
    {
        BookId = bookId;
        UserId = userId;
        DateOfLoan = dateOfLoan;
        ExpectedReturnDate = expectedReturnDate;
        Status = status;
    }

    public BookId BookId { get; private set; }

    public UserId UserId { get; private set; }

    public DateOfLoan DateOfLoan { get; private set; }

    public ExpectedReturnDate ExpectedReturnDate { get; private set; }

    public ReturnDate? ReturnDate { get; private set; }

    public Status Status { get; private set; }

    public Result WasReturned()
    {
        if (Status is Status.Returned) return Result.Failure(LoanErrors.AlreadyReturned);

        ReturnDate = new(DateTime.Now);
        Status = Status.Returned;

        return Result.Success();
    }
}