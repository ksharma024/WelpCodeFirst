using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WelpCodeFirst.Models
{
    public class Rating
    {
        public int RatingID { get; set; }
        public int UserID { get; set; }
        public int BusinessID { get; set; }
        public double StarRating { get; set; }
        public string Review { get; set; }

        public virtual User User { get; set; }
        public virtual Business Business { get; set; }
    }
}