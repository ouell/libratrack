namespace LibraTrack.Domain.Users;

public record UserId(Guid Value)
{
    public static UserId New()
    {
        return new(Guid.NewGuid());
    }
}