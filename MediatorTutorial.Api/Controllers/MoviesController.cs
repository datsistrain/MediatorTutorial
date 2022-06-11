namespace MediatorTutorial.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MoviesController : Controller
{
    private readonly IMediator _mediator;
    public MoviesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("list")]
    public async Task<IEnumerable<Movie>> GetMovies()
    {
        return await _mediator.Send(new GetMovieListQuery());
    }

    [HttpGet("result")]
    public IActionResult GetMoviesEnum()
    {
        return Ok(_mediator.Send(new GetMovieListQuery()));
    }

    [HttpGet("{id}")]
    public async Task<Movie> GetMovieById(int id)
    {
        return await _mediator.Send(new GetMovieByIdQuery(id));
    }

    [HttpPost]
    public async Task<Movie> PostMovie(Movie movie)
    {
        return await _mediator.Send(new AddMovieCommand(movie));
    }
}
