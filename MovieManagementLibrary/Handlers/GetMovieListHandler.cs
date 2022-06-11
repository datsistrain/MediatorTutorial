using MediatR;
using MovieManagementLibrary.Data;
using MovieManagementLibrary.Models;
using MovieManagementLibrary.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagementLibrary.Handlers;

public class GetMovieListHandler : IRequestHandler<GetMovieListQuery, List<Movie>>
{
    private readonly IDataRepo _dataRepo;
    public GetMovieListHandler(IDataRepo dataRepo)
    {
        _dataRepo = dataRepo;
    }

    public Task<List<Movie>> Handle(GetMovieListQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_dataRepo.GetMovies());
    }
}
