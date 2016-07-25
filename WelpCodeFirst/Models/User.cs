using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WelpCodeFirst.Models
{
    public class User
    {
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
        public virtual Photo Photo { get; set; }
        public virtual Rating Rating { get; set; }
        public virtual Business Business { get; set; }

    }
}