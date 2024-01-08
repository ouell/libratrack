namespace LibraTrack.Infra.Repositories;

internal sealed class LoanRepository : Repository<Loan, LoanId>, ILoanRepository
{
    public LoanRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}