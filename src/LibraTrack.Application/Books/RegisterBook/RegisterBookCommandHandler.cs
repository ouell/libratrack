namespace LibraTrack.Application.Books.RegisterBook;

internal sealed class RegisterBookCommandHandler(IUnitOfWork unitOfWork, IBookRepository bookRepository)
    : ICommandHandler<RegisterBookCommand, Guid>
{
    public async Task<Result<Guid>> Handle(RegisterBookCommand request, CancellationToken cancellationToken)
    {
        var book = Book.Create(new(request.Isbn),
                                           new(request.Title),
                                           new(request.Author),
                                           new(request.Amount),
                                           request.Category,
                                           new(request.Description),
                                           new(request.YearOfPublication));
        
        bookRepository.Add(book);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return book.Id.Value;
    }
}