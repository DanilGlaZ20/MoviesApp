using Microsoft.AspNetCore.Identity;

namespace MoviesApp.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public string UserName { get; set; }
       //public string Email { get; set; }
       // public string PhoneNumber { get; set; }
        //public bool EmailConfirmed { get; set; }
        //public string Id { get; set; }
    }

    
}