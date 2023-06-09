using Microsoft.AspNetCore.Identity;
using System;

namespace Bioskop.Models.Login
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime DatumRegistracije { get; set; }
    }
}
