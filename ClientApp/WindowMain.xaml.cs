using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Configuration;

namespace ClientApp
{
    /// <summary>
    /// Interaction logic for WindowMain.xaml
    /// </summary>
    public partial class WindowMain : Window
    {
        IPEndPoint serverEndPoint;
    
        UdpClient client;
        ObservableCollection<Messaging> messages = new ObservableCollection<Messaging>();
        public WindowMain()
        {
            InitializeComponent();
            this.DataContext = messages;
            client = new UdpClient();
            string address = ConfigurationManager.AppSettings["ServerAddress"]!;
            short port = short.Parse(ConfigurationManager.AppSettings["ServerPort"]!);
            serverEndPoint = new IPEndPoint(IPAddress.Parse(address), port);
            
        }
        private async void SendMessage(string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            await client.SendAsync(data, serverEndPoint);
        }
        private async void Listen()
        {
            while (true)
            {
                var data = await client.ReceiveAsync();
                string message = Encoding.UTF8.GetString(data.Buffer);
                messages.Add(new Messaging(message, DateTime.Now));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string message = msgText.Text;
            SendMessage(message);
            //MessageBox.Show("kkjsdhjsdg", "Error", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string message = "$<join>";
            SendMessage(message);
            Listen();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
