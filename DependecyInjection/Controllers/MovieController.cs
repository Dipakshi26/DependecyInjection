using DependecyInjection.Models;
using DependecyInjection.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DependecyInjection.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepository _movieRepo;
        public List <Movie> movies { get; set; } = new List<Movie>();
        //Dependency injected.
        public MovieController (IMovieRepository movieRepo)
        {
            _movieRepo = movieRepo;

        }
        public IActionResult Index()
        {

            movies = _movieRepo.GetAll();
            return View(movies);
        }
        

    }
}
