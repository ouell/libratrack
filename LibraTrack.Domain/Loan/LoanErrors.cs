namespace LibraTrack.Domain.Loan;

public static class LoanErrors
{
    public static Error AlreadyReturned = new("Loan.AlreadyReturned",
                                              "The book has already returned");
}