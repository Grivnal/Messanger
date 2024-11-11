using DataAccess;
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
using System.Windows.Shapes;

namespace ClientApp
{
    /// <summary>
    /// Interaction logic for AutoWindow.xaml
    /// </summary>
    public partial class AutoWindow : Window
    {
        MessangerDBContext DBContext;
        public AutoWindow()
        {
            InitializeComponent();
            DBContext= new MessangerDBContext();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User user = new User(NameTb.Text, EmailTb.Text, CounrtyTb.Text, PhoneTb.Text, PasswordTb.Text);
            if(DBContext.Users.Where(U=>U.Name==user.Name) !=null)
            {
            
            }
        }
    }
}
