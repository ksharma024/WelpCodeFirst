using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WelpCodeFirst.Models
{
    public class BusinessType
    {
        public int BusinessTypeID { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<Business> Businesses { get; set; }

    }
}