namespace LibraTrack.Domain.Loan;

public interface ILoanRepository
{
    Task AddAsync(Loan loan, CancellationToken cancellationToken);
    Task<Loan?> GetByIdAsync(LoanId id, CancellationToken cancellationToken = default);
}