using DataAccess;
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
        MessangerDBContext dbContext;
        public MainWindow()
        {
            InitializeComponent();
            dbContext= new MessangerDBContext();
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User user = new User(NameTb.Text,EmailTb.Text,CounrtyTb.Text,PhoneTb.Text,PasswordTb.Text);
            dbContext.Add(user);
            dbContext.SaveChanges();
        }
    }
}

