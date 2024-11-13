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
        MyUser user;
        MyUser userlogin;
        public AutoWindow()
        {
            InitializeComponent();
            DBContext= new MessangerDBContext();
            user = new MyUser("seal", "emial", "ukrain", "85498545", "passwor");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            userlogin = new MyUser(NameTb.Text, EmailTb.Text, CounrtyTb.Text, PhoneTb.Text, PasswordTb.Text);
            if (userlogin.Name==user.Name)
            {
                WindowMain mainW= new WindowMain();  
                mainW.Show();
                this.Hide();
            }
            //if(DBContext.Users.Where(U=>U.Name==user.Name) !=null)
            //{
            
            //}
        }
    }
}
