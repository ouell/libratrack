﻿namespace LibraTrack.Domain.Loan;

public record LoanId(Guid Value)
{
    public static LoanId New() => new(Guid.NewGuid());
}