namespace LibraTrack.Domain.Loan;

public interface ILoanRepository
{
    void Add(Loan loan);
    Task<Loan?> GetByIdAsync(LoanId id, CancellationToken cancellationToken = default);
}