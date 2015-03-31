using AdaptorsInterfaces.Adapters.Interfaces;
using AdaptorsInterfaces.Data;
using AdaptorsInterfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdaptorsInterfaces.Adapters.Adapters
{
    public class MovieAdapter : IMovieAdapter
    {
        public List<Movie> GetAllMovies()
        {
            List<Movie> Movies;
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                Movies = db.Movies.Include("Reviews").ToList();   
            }
            return Movies;
        }
        public Movie DetailMovie(int id)
        {
            Movie MovieDetail;
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                MovieDetail = db.Movies.Include("Reviews").Where(x=> x.MovieId == id).FirstOrDefault();
            }        
            return MovieDetail;
        }


        public Movie EditMovie(Movie movie)
        {
            Movie EditedMovie;
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                EditedMovie = db.Movies.Where(x => x.MovieId == movie.MovieId).FirstOrDefault();
                EditedMovie.Name = movie.Name;
                EditedMovie.Rating = movie.Rating;
                EditedMovie.ImageUrl = movie.ImageUrl;
                db.SaveChanges();
            }
            return EditedMovie;
        }

        public void AddMovie(Movie newMovie)
        {
          
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                db.Movies.Add(newMovie);
                db.SaveChanges();
            }
            
        }

        public void DeleteMovie(int id)
        {
            Movie delMovie;
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                delMovie = db.Movies.Find(id);
                db.Movies.Remove(delMovie);
                db.SaveChanges();
            }
        }
    }
}
