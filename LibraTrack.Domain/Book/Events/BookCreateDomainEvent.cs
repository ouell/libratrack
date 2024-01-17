namespace LibraTrack.Domain.Book.Events;

public sealed record BookCreateDomainEvent(BookId BookId) : IDomainEvent;