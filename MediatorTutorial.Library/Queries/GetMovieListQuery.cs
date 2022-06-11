namespace MediatorTutorial.Library.Queries;

public record GetMovieListQuery : IRequest<IEnumerable<Movie>>;
