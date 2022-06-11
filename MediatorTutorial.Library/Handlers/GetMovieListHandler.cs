namespace MediatorTutorial.Library.Handlers;

public class GetMovieListHandler : IRequestHandler<GetMovieListQuery, IEnumerable<Movie>>
{
    private readonly IDataRepo _dataRepo;
    public GetMovieListHandler(IDataRepo dataRepo)
    {
        _dataRepo = dataRepo;
    }

    public Task<IEnumerable<Movie>> Handle(GetMovieListQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_dataRepo.GetMovies());
    }
}
