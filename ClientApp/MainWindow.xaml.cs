using System;
using System.Collections.Generic;
using System.Linq;
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

namespace ClientApp{
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
        }
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
  
