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
using AlbumLibrary;

namespace AlbumUI
{
    /// <summary>
    /// Interaction logic for SignInWindow.xaml
    /// </summary>
    public partial class SignInWindow : Window
    {
        private Authorization _auth;
        public SignInWindow(Authorization getAuth)
        {
            _auth = getAuth;
            InitializeComponent();
            tbUserName.Text = "Misha";
            PasswordBoxUser.Password = "kek";
        }

        private void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordBoxUser.Password == String.Empty || tbUserName.Text == String.Empty)
                MessageBox.Show("Please fill all fields!");
            
            else
            {
                if (_auth.SignIn(tbUserName.Text, PasswordBoxUser.Password))
                {
                    MessageBox.Show("You have successfully logged in!");
                    var mainWindow = new MainWindow(tbUserName.Text, PasswordBoxUser.Password);
                    mainWindow.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("User name or password is incorrect!");
                }
            }
        }
    }
}
