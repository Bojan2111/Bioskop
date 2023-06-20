using Microsoft.AspNetCore.Identity;
using System;

namespace Bioskop.Models.Login
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime RegistrationDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ProfileImage { get; set; }
        public bool Deleted { get; set; } = false;
    }
}
