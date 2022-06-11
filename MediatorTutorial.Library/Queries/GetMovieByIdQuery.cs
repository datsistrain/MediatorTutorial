namespace MediatorTutorial.Library.Queries;

public record GetMovieByIdQuery(int id) : IRequest<Movie>;
