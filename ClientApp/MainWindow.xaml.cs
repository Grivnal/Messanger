using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClientApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Console.WriteLine(message1.User);
            //Console.WriteLine(message1.Text);
            //Console.WriteLine(message1.Time);
            //Console.WriteLine(message1.Data);

            //Messaging message1 = new Messaging(1, "Alice", "Hello there!", DateTime.Now, "Text Message");
            //Console.WriteLine(user1.Name);
            //Console.WriteLine(user1.Email);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }





    public class Messaging
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }
        public string Data { get; set; }

        public Messaging(int id, string user, string text, DateTime time, string data = null)
        {
            Id = id;
            User = user;
            Text = text;
            Time = time;
            Data = data;
        }
    }

    //public class User
    //{
    //    public string Name { get; set; }
    //    public string Email { get; set; }
    //    public string Country { get; set; }
    //    public string Phone { get; set; }
    //    public string Passport { get; set; }

    //    public User(string name, string email, string country, string phone, string passport)
    //    {
    //        Name = name;
    //        Email = email;
    //        Country = country;
    //        Phone = phone;
    //        Passport = passport;
    //    }
    //}
    public class GroupChat
    {
        public int Id { get; set; }
        public List<User> Users { get; set; } = new List<User>();
        public DateTime Time { get; set; }
        public string Data { get; set; }
        public User Admin { get; set; }
        public string Text { get; set; }
        public GroupChat(int id, User admin, string text, DateTime time, string data = null)
        {
            Id = id;
            Admin = admin;
            Text = text;
            Time = time;
            Data = data;
        }
        public void AddUser(User user)
        {
            Users.Add(user);
        }
        public void RemoveUser(User user)
        {
            Users.Remove(user);
        }
        public void UpdateText(string newText)
        {
            Text = newText;
        }
    }
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Passport { get; set; }
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

