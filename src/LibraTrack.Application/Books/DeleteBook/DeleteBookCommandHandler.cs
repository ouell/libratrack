namespace LibraTrack.Application.Books.DeleteBook;

internal sealed class DeleteBookCommandHandler(IBookRepository bookRepository, 
                                               IUnitOfWork unitOfWork)
    : ICommandHandler<DeleteBookCommand>
{
    public async Task<Result> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
    {
        var book = await bookRepository.GetByIdAsync(new(request.Id), cancellationToken);

        if (book is null)
        {
            return Result.Failure(BookErrors.NotFound);
        }
        
        
        
        return Result.Success();
    }
}