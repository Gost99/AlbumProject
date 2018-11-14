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
    /// Interaction logic for AddPhotoWindow.xaml
    /// </summary>
    public partial class AddPhotoWindow : Window
    {

        public string directoryToReturn = "";
        private Album _album;

        public AddPhotoWindow(Album album)
        {
            _album = album;
            InitializeComponent();
        }

        private void BtnAddPhoto_Click(object sender, RoutedEventArgs e)
        {
            if (_album != null)
            {
                _album.AddNewPhoto(new Photo(tbPhotoTitle.Text,tbPhotoDescription.Text, directoryToReturn, Tags.None));
            }
            else
            {
                MessageBox.Show("IDI NAHUY!");
            }
            Close();
        }

        private void BtnBrowseDirectory_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog 
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".png";
            dlg.Filter = "JPG Files (*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|GIF Files (*.gif)|*.gif";

            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();


            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                tbChooseDirectory.Text = filename;
                directoryToReturn = filename;
                mediaElPhotoChose.Source = new Uri(tbChooseDirectory.Text);
            }
        }
    }
}
