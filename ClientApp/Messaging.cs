using System;

namespace ClientApp
{
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
}

