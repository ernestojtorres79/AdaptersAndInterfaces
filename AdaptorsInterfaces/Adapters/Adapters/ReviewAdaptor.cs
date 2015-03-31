using AdaptorsInterfaces.Adapters.Interfaces;
using AdaptorsInterfaces.Data;
using AdaptorsInterfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdaptorsInterfaces.Adapters.Adapters
{
    public class ReviewAdaptor : IReviewAdaptor
    {
        public _IndexVM GetAllReviews()
        {
            _IndexVM Reviews = new _IndexVM();
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                Reviews.Review = db.Reviews.ToList();
            }
            return Reviews;
        }
        public Review AddReview(Review review)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                db.Reviews.Add(review);
                db.SaveChanges();
            }
            return review;
        }
    }
}