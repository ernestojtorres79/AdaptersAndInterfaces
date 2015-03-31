using AdaptorsInterfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorsInterfaces.Adapters.Interfaces
{
    public interface IMovieAdapter
    {
        List<Movie> GetAllMovies();

        Movie DetailMovie(int id);

        Movie EditMovie(Movie movie);

        void AddMovie(Movie newMovie);

        void DeleteMovie(int id);
    }
}
