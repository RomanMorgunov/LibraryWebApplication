using System;
using Microsoft.AspNetCore.Identity;

namespace LibraryWebApplicationUI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() { }

        public ApplicationUser(string userName)
            : base(userName) { }

        [PersonalData]
        public string FirstName { get; set; }

        [PersonalData]
        public string SecondName { get; set; }

        [PersonalData]
        public DateTime Birthdate { get; set; }
    }
}
