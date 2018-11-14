using System;
using System.Collections.Generic;
using System.Linq;
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
using AlbumLibrary;
using Authorization = AlbumLibrary.Authorization;

namespace AlbumUI
{
    /// <summary>
    /// Interaction logic for LogWindow.xaml
    /// </summary>
    public partial class SignUpWindow : Window
    {
        public Authorization auth = new Authorization();

        public SignUpWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            auth.SignUp("Misha", "kek");


        }

        private void BtnSignUp_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordBoxUser.Password == String.Empty || tbUserName.Text == String.Empty)
                MessageBox.Show("Please fill all fields!");

            else
            {
                if (!auth.SignUp(tbUserName.Text, PasswordBoxUser.Password)) //если такой юзер есть
                {
                    MessageBox.Show("User with that user name already exists!");
                }
                else
                {
                    MessageBox.Show("You have successfully registered and logged in!");
                    var mainWindow = new MainWindow(tbUserName.Text, PasswordBoxUser.Password);
                    mainWindow.Show();
                    Close();
                }
            }
        }

        private void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            var signInWindow = new SignInWindow(auth);
            Close();
            signInWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            signInWindow.ShowDialog();
            
        }
    }
}
