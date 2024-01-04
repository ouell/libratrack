namespace LibraTrack.Domain.Users.Events;

public sealed record UserCreateDomainEvent(UserId UserId) : IDomainEvent;