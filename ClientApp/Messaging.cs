using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClientApp
{
    public class Messaging
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }
        public string Data { get; set; }

        public Messaging(  string text, DateTime time, string data = null)
        {
          
            Text = text;
            Time = time;
            Data = data;
        }
        public override string ToString()
        {
            return $"{Text} . Date : {Data}";
        }
    }
}

