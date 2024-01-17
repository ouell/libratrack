namespace LibraTrack.Application.Books.EditBook;

public sealed record EditBookCommand(Guid BookId,
                                     int Amount,
                                     string description) : ICommand<Guid>;
