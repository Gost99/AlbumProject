using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AlbumLibrary;


namespace CreatingObjectsForm
{
    public partial class CreatingObjectsForm : Form
    {
        public CreatingObjectsForm()
        {
           InitializeComponent();
           
        }

        List<User> userList = new List<User>();
        List<Album> albumList = new List<Album>();
        List<Photo> photoList = new List<Photo>();

        public PhotoObject alb1 = new Album();

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            
            if (ObjectNameTB.Text == String.Empty)
            {
                MessageBox.Show("Object should have a name!");
            }
            else
            {
                switch (ObjectsComboBox.SelectedIndex)
                {
                    // User 
                    case 0:
                        if (ControlsComboBox.SelectedIndex == 0)
                        {
                            userList.Add(new User(ObjectNameTB.Text));
                            MessageBox.Show("User " + ObjectNameTB.Text + " added.");
                            ShowObjectsTB.Text += String.Concat(("User: " + ObjectNameTB.Text + Environment.NewLine));

                        }
                        else if (ControlsComboBox.SelectedIndex == 1)
                        {
                            var indexToDelete = userList.FindIndex(x => x.Name == ObjectNameTB.Text);
                            if (indexToDelete >= 0) userList.RemoveAt(indexToDelete);
                            MessageBox.Show("User " + ObjectNameTB.Text + " deleted.");
                            
                        }
                        break;

                    // Album
                    case 1:
                        if (ControlsComboBox.SelectedIndex == 0)
                        {
                            albumList.Add(new Album(ObjectNameTB.Text));
                            MessageBox.Show("Album " + ObjectNameTB.Text + " added.");
                            ShowObjectsTB.Text += String.Concat(("Album: " + ObjectNameTB.Text + Environment.NewLine));
                        }
                        else if (ControlsComboBox.SelectedIndex == 1)
                        {
                            var indexToDelete = albumList.FindIndex(x => x.Title == ObjectNameTB.Text);
                            if (indexToDelete >= 0) albumList.RemoveAt(indexToDelete);
                            MessageBox.Show("Album " + ObjectNameTB.Text + "deleted.");
                        }
                        break;
                    // Photo
                    case 2:
                        if (ControlsComboBox.SelectedIndex == 0)
                            new CreatingPhoto(photoList, ObjectNameTB.Text).ShowDialog();
                            
                            //photoList.Add(new Photo(ObjectNameTB.Text));
                        else if (ControlsComboBox.SelectedIndex == 1)
                        {
                            var indexToDelete = photoList.FindIndex(x => x.Title == ObjectNameTB.Text);
                            if (indexToDelete >= 0) photoList.RemoveAt(indexToDelete);
                            MessageBox.Show("Photo " + ObjectNameTB.Text + " deleted.");
                        }
                        break;
                }

            }
            
        }

        private void ShowObjectsTB_TextChanged(object sender, EventArgs e)
        {
            var size = TextRenderer.MeasureText(ShowObjectsTB.Text, ShowObjectsTB.Font);
            
            ShowObjectsTB.Height = size.Height;
        }
       
    }
}
