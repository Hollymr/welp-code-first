using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WelpCodeFirst.Models
{
    public class Rating
    {
        public int RatingID { get; set; }
        public string TextReview { get; set; }
        public short? StarRating { get; set; }
        public int UserID { get; set; }
        public int BusinessID { get; set; }

        //Navigation properties
        public virtual User User { get; set; }
        public virtual Business Business { get; set; }
    }
}