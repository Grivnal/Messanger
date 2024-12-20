﻿using System;
using System.Collections.Generic;

namespace ClientApp
{
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
        public List<MyUser> Users { get; set; } = new List<MyUser>();
        public DateTime Time { get; set; }
        public string Data { get; set; }
        public MyUser Admin { get; set; }
        public string Text { get; set; }
        public GroupChat(int id, MyUser admin, string text, DateTime time, string data = null)
        {
            Id = id;
            Admin = admin;
            Text = text;
            Time = time;
            Data = data;
        }
        public void AddUser(MyUser user)
        {
            Users.Add(user);
        }
        public void RemoveUser(MyUser user)
        {
            Users.Remove(user);
        }
        public void UpdateText(string newText)
        {
            Text = newText;
        }
    }
}

