using System;
using System.Collections.Generic;

#nullable disable

namespace SocialNetworkSite
{
    public partial class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string BirthdayDate { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public byte[] Picture { get; set; }
        public string ColourTheme { get; set; }
    }
}
