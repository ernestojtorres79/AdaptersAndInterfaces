using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorsInterfaces.Model
{
    public class Movie
    { 
        public int MovieId {get;set;}
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public Rating Rating { get; set; }
        public int NumReview { get; set; }
        public double AveRating { get; set; }
        public virtual List<Review> Reviews { get; set; }

    }
    public enum Rating
    {
        OneStar = 1,
        TwoStar = 2,
        ThreeStar = 3,
        FourStar = 4,
        FiveStar = 5
    }
}
