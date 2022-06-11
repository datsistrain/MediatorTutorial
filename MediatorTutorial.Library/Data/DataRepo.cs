namespace MediatorTutorial.Library.Data;

public class DataRepo : IDataRepo
{
    private static List<Movie> _movies = new()
    {
        new Movie { Id = 1, Name = "Test 1", Cost = 200},
        new Movie { Id = 2, Name = "Test 2", Cost = 201}
    };

    public Movie AddMovie(Movie movie)
    {
        _movies.Add(movie);
        return movie;
    }

    public IEnumerable<Movie> GetMovies()
    {
        return _movies;
    }
}
