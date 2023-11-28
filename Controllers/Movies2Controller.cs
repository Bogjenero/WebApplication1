using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class Movies2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public MoviesService MoviesService { get; set; }
        public Movies2Controller(MoviesService moviesService)
        {
            MoviesService = moviesService;
        }
        [HttpPost]
        public IActionResult AddBook([FromBody] MovieVM book)
        {
            MoviesService.AddMovie(book);
            return Ok();

        }
        [HttpGet]
        public IActionResult GetAllMovies()
        {
            var allMovies = MoviesService.GetAllMovies();
            return Ok(allMovies);
        }
        [HttpGet("id")]
        public IActionResult GetBookById([FromQuery] int id)
        {
            var movie = MoviesService.GetMovieById(id);
            return Ok(movie);
        }

        [HttpPut("id")]
        public IActionResult UpdateBookById([FromQuery] int id,
        [FromBody] MovieVM movieVM)
        {
            var updatedMovie = MoviesService.UpdateMovieById(id, movieVM);
            return Ok(updatedMovie);
        }
    }
}
