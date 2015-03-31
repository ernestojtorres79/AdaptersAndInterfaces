using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using AdaptorsInterfaces.Model;

namespace AdaptorsInterfaces.Data
{
    public static class Seeder
    {
        public static void Seed(ApplicationDbContext context, bool movies = false, bool reviews = false)
        {
            if (movies) SeedMovies(context);
            if (reviews) SeedReviews(context);
        }
        private static void SeedMovies(ApplicationDbContext context)
        {
            context.Movies.AddOrUpdate(x => x.Name,
                new Movie() { Name = "Star Wars 1", ImageUrl = "http://atomicanxiety.files.wordpress.com/2013/12/star-wars-episode-1-poster.jpg", Rating = Rating.FiveStar },
                new Movie() { Name = "Star Wars 2", ImageUrl = "http://img1.wikia.nocookie.net/__cb20130822173923/starwars/images/2/24/EPII_AotC_poster.png", Rating = Rating.ThreeStar },
                new Movie() { Name = "Star Wars 3", ImageUrl = "https://siam-movie.com/wp-content/uploads/2014/03/Star-Wars-3-Revenge-of-the-Sith-%E0%B8%8B%E0%B8%B4%E0%B8%98%E0%B8%8A%E0%B8%B3%E0%B8%A3%E0%B8%B0%E0%B9%81%E0%B8%84%E0%B9%89%E0%B8%99.jpg", Rating = Rating.FourStar },
                new Movie() { Name = "Lord of the Rings", ImageUrl = "http://3.bp.blogspot.com/-0X2hjtqjTxY/T9v-0Lmon7I/AAAAAAAAB7M/_eAEbiwDc9Q/s1600/animaatjes-lord-of-the-rings-56960.jpg", Rating = Rating.FiveStar },
                new Movie() { Name = "Barbie Princess Castle", ImageUrl = "http://images5.fanpop.com/image/photos/31600000/Barbie-And-The-Diamond-Castle-barbie-princess-31680902-1024-768.jpg", Rating = Rating.OneStar },
                new Movie() { Name = "Dumbo", ImageUrl = "http://img1.wikia.nocookie.net/__cb20130717205847/disney/images/f/f2/Dumbo_poster.png", Rating = Rating.FiveStar },
                new Movie() { Name = "Old Yeller", ImageUrl = "http://cdnvideo.dolimg.com/cdn_assets/a194ba8037f42266c69213833a44408d6d9606a1.jpg", Rating = Rating.FiveStar });
            context.SaveChanges();
        }
        private static void SeedReviews(ApplicationDbContext context)
        {
            context.Reviews.AddOrUpdate(x => x.ReviewBody,
                new Review() { ReviewUser = "John", ReviewBody = "This LOTR is the best of the whole trilogy", TimePosted = DateTime.Now, MovieId = 5 },
                new Review() { ReviewUser = "Ariana", ReviewBody = "I love elephants, Dumbo is so cute", TimePosted = DateTime.Now, MovieId = 7 },
                new Review() { ReviewUser = "John", ReviewBody = "This LOTR is the best of the whole trilogy", TimePosted = DateTime.Now, MovieId = 5 },
                new Review() { ReviewUser = "Ariana", ReviewBody = "I love elephants, Dumbo is so cute", TimePosted = DateTime.Now, MovieId = 7 },
                new Review() { ReviewUser = "John", ReviewBody = "This LOTR is the best of the whole trilogy", TimePosted = DateTime.Now, MovieId = 5 },
                new Review() { ReviewUser = "Ariana", ReviewBody = "I love elephants, Dumbo is so cute", TimePosted = DateTime.Now, MovieId = 7 });
            context.SaveChanges();
        }
    }
}
