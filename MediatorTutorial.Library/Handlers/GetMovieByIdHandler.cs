namespace MediatorTutorial.Library.Handlers;

public class GetMovieByIdHandler : IRequestHandler<GetMovieByIdQuery, Movie>
{
    private readonly IMediator _mediator;
    public GetMovieByIdHandler(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<Movie> Handle(GetMovieByIdQuery request, CancellationToken cancellationToken)
    {
        var movies = await _mediator.Send(new GetMovieListQuery());
        var movie = movies.FirstOrDefault(m => m.Id == request.id);
        return movie;
    }
}
