namespace MediatorTutorial.Library.Data;

public interface IDataRepo
{
    IEnumerable<Movie> GetMovies();
    Movie AddMovie(Movie movie);
}
