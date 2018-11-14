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
using AlbumLibrary;

namespace AlbumUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private User _currUser;
        public MainWindow(string userName, string password)
        {
            _currUser = User.Users.Find(x => x.Name == userName);
            _currUser.CreateAlbum("Friends");
            _currUser.CreateAlbum("Family");
            _currUser.CreateAlbum("Parties");

            _currUser.albumList[0].AddComment(new User("alex","lol"),"Perfect photo!");

            InitializeComponent();

            RefreshAlbumLists();
            tblckCurrUser.Text = _currUser.Name;
            
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }


        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            if (_currUser != null)
            {
                var addAlb = new AddAlbumWindow(_currUser);
                addAlb.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                addAlb.ShowDialog();
            }

            RefreshAlbumLists();
        }

        private void RefreshAlbumLists()
        {
            var indexToSave = cbUserAlbums.SelectedIndex;
            var usersCollectionView = new ListCollectionView(_currUser.albumList);
            albumsGrid.ItemsSource = null;
            cbUserAlbums.ItemsSource = null;
            if (_currUser != null)
            {
                albumsGrid.ItemsSource = _currUser.albumList;
                cbUserAlbums.ItemsSource = usersCollectionView;
            }

            cbUserAlbums.SelectedIndex = indexToSave;
        }


        private void BtnAddPhoto_Click(object sender, RoutedEventArgs e)
        {
            if (!cbUserAlbums.Items.IsEmpty)
            {
                var addPhotoWin = new AddPhotoWindow((Album) cbUserAlbums.SelectedItem);
                addPhotoWin.ShowDialog();
                AddImageToWrapPanel(addPhotoWin.directoryToReturn);
            }
            
        }

        private void BtnLogOut_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            var logWin = new SignUpWindow();
            logWin.ShowDialog();
        }

        private void BtnAddFriend_Click(object sender, RoutedEventArgs e)
        {
            new AddFriendWindow().ShowDialog();
        }

        //private void CbUserAlbums_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    // После добавления фото слетает выбор, фото не прикрепляются к чекбокс итему.
        //    Album selectedItem = null;

        //    if(cbUserAlbums.SelectedIndex >= 0)
        //        selectedItem = _currUser.albumList[cbUserAlbums.SelectedIndex];
            
        //    if (selectedItem != null)
        //    {
        //        PhotosWrap.Children.Clear();
        //        foreach (Photo photo in selectedItem)
        //        {
        //            AddImageToWrapPanel(photo.Path);
        //        }
        //    }

            
        //}


        private void AddImageToWrapPanel(string pathToAdd)
        {
            var resImg = new Image();
            if (pathToAdd == "")
                return;
            resImg.Source = new BitmapImage(new Uri(pathToAdd));
            var resGrid = new Grid();
            resGrid.Children.Add(resImg);
            PhotosWrap.Children.Add(resGrid);
            RefreshAlbumLists();
        }
    }
}
