namespace DatingApp.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; } //hashes and stores
        public byte[] PasswordSalt { get; set; } //acts as key & compares against string
    }
}