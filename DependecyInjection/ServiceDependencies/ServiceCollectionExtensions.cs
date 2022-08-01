using DependecyInjection.Repositories;
using DependecyInjection.Repositories.Interfaces;

namespace DependecyInjection.ServiceDependencies
{
    public static class ServiceCollectionExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<IMovieRepository, MovieRepository>();

        }
    }
}
