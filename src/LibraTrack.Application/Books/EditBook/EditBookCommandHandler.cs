namespace LibraTrack.Application.Books.EditBook;

internal sealed class EditBookCommandHandler(IUnitOfWork unitOfWork, IBookRepository bookRepository)
    : ICommandHandler<EditBookCommand, Guid>
{
    public async Task<Result<Guid>> Handle(EditBookCommand request, CancellationToken cancellationToken)
    {
        var book = await bookRepository.GetByIdAsync(new(request.BookId), cancellationToken);

        if (book is null)
            return Result.Failure<Guid>(BookErrors.NotFound);

        book.Edit(new(request.Amount),
                  new(request.description));

        bookRepository.Update(book);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return book.Id.Value;
    }
}