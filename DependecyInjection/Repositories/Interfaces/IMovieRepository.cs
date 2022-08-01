using DependecyInjection.Models;

namespace DependecyInjection.Repositories.Interfaces
{
    public interface IMovieRepository
    {
        List<Movie> GetAll();
        Movie GetByID(int id);
    }
}
