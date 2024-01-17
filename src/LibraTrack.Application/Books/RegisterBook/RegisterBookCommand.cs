namespace LibraTrack.Application.Books.RegisterBook;

public sealed record RegisterBookCommand(string Isbn,
                                         string Title,
                                         string Author,
                                         int Amount,
                                         Category Category,
                                         string Description,
                                         int YearOfPublication) : ICommand<Guid>;