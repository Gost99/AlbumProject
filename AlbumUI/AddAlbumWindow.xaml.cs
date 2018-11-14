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
    /// Interaction logic for AddAlbumWindow.xaml
    /// </summary>
    public partial class AddAlbumWindow : Window
    {
        private User _user;
        public AddAlbumWindow(User userToAddAlbum)
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            _user = userToAddAlbum;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            if (_user != null)
            {
                _user.CreateAlbum(tbNewAlbumTitle.Text);
                Close();
            }
            else
            {
                MessageBox.Show("WRONG MAZAFAKA");
            }

        }
    }
}
