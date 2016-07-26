using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WelpCodeFirst.Models
{
    public class User
    {   // properties
        public int UserID { get; set; }
        [MaxLength(50)]
        public string UserName { get; set; }        
        [MaxLength(50)]
        public string Password { get; set; }
        [MaxLength(50)]
        private string Email { get; set; }
        [MaxLength(50)]
        public string Location { get; set; }

        //Navigation properties       
      
        // each user has access to more than one rating and more than one business 
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<Business> Businesses { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }

    }
}