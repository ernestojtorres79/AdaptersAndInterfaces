using AdaptorsInterfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdaptorsInterfaces.Model
{
    public class _IndexVM
    {
        public List<Movie> Movie { get; set; }
        public List<Review> Review { get; set; }

        public Movie SMovie { get; set; }
        public Review SReview { get; set; }
    }
}