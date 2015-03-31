using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorsInterfaces.Model
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string ReviewUser { get; set; }
        public string ReviewBody { get; set; }
        public DateTime TimePosted { get; set; }
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
