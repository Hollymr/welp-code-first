using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WelpCodeFirst.Models
{
    public class Rating
    {
        public int RatingID { get; set; }
        public string TextReviw { get; set; }
        public int StarRating { get; set; }

        //Navigation properties
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Business> Busninesses { get; set; }
    }
}