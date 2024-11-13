namespace ClientApp
{
    public class MyUser
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Passport { get; set; }
        public MyUser(string name, string email, string country, string phone, string passport)
        {
            Name = name;
            Email = email;
            Country = country;
            Phone = phone;
            Passport = passport;
        }
    }
}

