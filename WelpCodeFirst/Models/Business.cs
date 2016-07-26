using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WelpCodeFirst.Models
{
    public class Business
    {
        public int BusinessID { get; set; }
        public int BusinessTypeID { get; set; }
        public int UserID { get; set; }
        public string BusinessName { get; set; }
        public string Address { get; set; }
        public string Hours { get; set; }
        public string Phone { get; set; }
        public string Menu { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }

        public virtual User User { get; set; }
        public virtual BusinessType BusinessType { get; set; }
    }
}