using MovieManagementLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Library.Data;

public class DataRepo : IDataRepo
{
    private static List<Movie> _movies = new()
    {
        new Movie { Id = 1, Name = "Test 1", Cost = 1234},
        new Movie { Id = 1, Name = "Test 2", Cost = 2345}
    };

    public Movie AddMovie(Movie movie)
    {
        _movies.Add(movie);
        return movie;
    }

    public List<Movie> GetMovies()
    {
        throw new NotImplementedException();
    }
}
