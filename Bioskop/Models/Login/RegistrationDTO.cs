using System;
using System.ComponentModel.DataAnnotations;

namespace Bioskop.Models.Login
{
    public class RegistrationDTO
    {
        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }

    }
}
