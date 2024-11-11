namespace ClientApp
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Passport { get; set; }
        public ICollection<Messaging> Messagings { get; set; }
        public User(string name, string email, string country, string phone, string passport)
        {
            Name = name;
            Email = email;
            Country = country;
            Phone = phone;
            Passport = passport;
        }
    }
}

