namespace LibraTrack.Application.Books.DeleteBook;

public sealed record DeleteBookCommand(Guid Id) : ICommand;