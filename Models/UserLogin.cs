namespace Login.Models
{
    public class UserLogin
    {
        public string UserId { get; set; }

        public string ProviderName { get; set; }

        public string ProviderUserId { get; set; }

        public User User { get; set; }
    }
}
