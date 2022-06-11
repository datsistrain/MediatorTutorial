namespace MediatorTutorial.Library.Commands;

public record AddMovieCommand(Movie movie) : IRequest<Movie>;
