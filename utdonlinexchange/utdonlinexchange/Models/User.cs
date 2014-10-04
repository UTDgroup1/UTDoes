using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace utdonlinexchange.Models
{
    public class User
    {
        [Required]
        public int NetId { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Address_line1 { get; set; }
        public string Address_line2 { get; set; }
        public string phone { get; set; }
        public string zipcode { get; set; }

        public string password { get; set; }

    
    }
}

