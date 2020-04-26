using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Models
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            Messages = new HashSet<Message>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
