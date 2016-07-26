using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WelpCodeFirst.Models
{
    public class Rating
    {
        public int RatingID { get; set; }
        public int UserID { get; set; }
        public int BusinessID { get; set; }
        public short? StarReview { get; set; }
        //short = tinyint
        //putting a ? means optional or leaving blank/nulls if applicable
        public string TextReview { get; set; }

        //navigation properties
        // public virtual (name of class) (name of property associated)
        public virtual User User { get; set; }
        public virtual Business Business { get; set; }
    }
}