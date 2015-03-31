using AdaptorsInterfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorsInterfaces.Adapters.Interfaces
{
    public interface IReviewAdaptor
    {
        _IndexVM GetAllReviews();
        Review AddReview(Review review);
    }
}
