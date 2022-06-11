using MovieManagementLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Library.Data;

internal interface IDataRepo
{
    List<Movie> GetMovies();
    Movie AddMovie(Movie movie);
}
