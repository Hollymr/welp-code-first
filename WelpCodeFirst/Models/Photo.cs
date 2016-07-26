using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WelpCodeFirst.Models
{
    public class Photo
    {
        public int PhotoID { get; set; }
        [MaxLength(100)]
        public string PhotoURL { get; set; }

        //Navigation properties
        public virtual User User { get; set; }
        public virtual Business Business { get; set; }
    }
}