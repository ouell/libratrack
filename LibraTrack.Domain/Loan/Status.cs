namespace LibraTrack.Domain.Loan;

public enum Status: byte
{
    Active = 1,
    Returned = 2,
    Late = 3,
}