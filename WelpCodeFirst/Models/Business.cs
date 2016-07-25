using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WelpCodeFirst.Models
{
    public class Business
    {
        public int BusinessID { get; set; }
        [MaxLength(50)]
        public string BusinessName { get; set; }
        public int BusinessTypeID { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        [MaxLength(100)]
        private string Hours { get; set; }
        [MaxLength(50)]
        public string Phone { get; set; }
        private string Menu { get; set; }
        public int UserID { get; set; }

        //Navigation properties
        //used when * is pointing toward it
        public virtual ICollection<BusinessType> BusinessTypes { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual Photo Photo { get; set; }
        public virtual Rating Rating { get; set; }
    }
}