using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace e_coding.gr.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public DateTime Birthday { get; internal set; }
        public string Gender { get; internal set; }
        public string Name { get; internal set; }
        public string Surname { get; internal set; }
    }
}
