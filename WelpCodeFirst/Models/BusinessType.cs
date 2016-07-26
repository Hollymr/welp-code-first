using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WelpCodeFirst.Models
{
    public class BusinessType
    {
        public int BusinessTypeID { get; set; }
        [MaxLength(50)]
        public string TypeName { get; set; }

        //Navigation properties
        public virtual ICollection<Business> Businesses { get; set; }
      
    }
}