namespace MediatorTutorial.Library.Handlers;

public class AddMovieHandler : IRequestHandler<AddMovieCommand, Movie>
{
    private readonly IDataRepo _dataRepo;
    public AddMovieHandler(IDataRepo dataRepo)
    {
        _dataRepo = dataRepo;
    }

    public Task<Movie> Handle(AddMovieCommand request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_dataRepo.AddMovie(request.movie));
    }
}
