namespace DovizBank.Entity
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
        public string Email { get; set; }
        public double? Balance { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
    }
}
