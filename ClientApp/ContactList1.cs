using System;
using System.Collections.Generic;

namespace ClientApp
{
    public class ContactList1
    {
        private List<MyUser> users = new List<MyUser>();

        public void AddUser(MyUser user)
        {
            users.Add(user);
        }

        public void RemoveUser(MyUser user)
        {
            users.Remove(user);
        }

        public void PrintAllUsers()
        {
            foreach (MyUser user in users)
            {
                Console.WriteLine($"Name: {user.Name}, Email: {user.Email}, Country: {user.Country}, Phone: {user.Phone}, Passport: {user.Passport}");
            }
        }
    }
}

