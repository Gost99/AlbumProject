﻿using System;
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
    /// Interaction logic for AddFriendWindow.xaml
    /// </summary>
    public partial class AddFriendWindow : Window
    {
        public AddFriendWindow()
        {
            InitializeComponent();
            usersList.ItemsSource = User.Users;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
