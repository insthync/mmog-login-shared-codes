using System;
using System.Collections.Generic;

namespace Login.Models
{
    public class User
    {
        public string UserId { get; set; }

        public string Username { get; set; }

        public string NormalizedUsername { get; set; }

        public string Email { get; set; }

        public string NormalizedEmail { get; set; }

        public bool EmailConfirmed { get; set; }

        public string PasswordHash { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime? LastLogin { get; set; }

        public ICollection<UserLogin> UserLogins { get; set; }
    }
}
