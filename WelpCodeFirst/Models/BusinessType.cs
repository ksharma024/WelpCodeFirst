using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WelpCodeFirst.Models
{
    public class BusinessType
    {
        public int BusinessTypeID { get; set; }
        [MaxLength(50)]
        public string BusinessTypeName { get; set; }

        public virtual ICollection<Business> Businesses { get; set; }

    }
}