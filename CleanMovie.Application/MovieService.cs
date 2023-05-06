using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movierepository;
        public MovieService(IMovieRepository movieRepository)
        {
            _movierepository = movieRepository;
        }
        public List<Movie> GetAllMovies()
        {
            var movies = _movierepository.GetAllMovies();

            return movies;
        }
    }
}
