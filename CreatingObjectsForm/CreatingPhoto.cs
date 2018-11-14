using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AlbumLibrary;

namespace CreatingObjectsForm
{
    public partial class CreatingPhoto : Form
    {
        bool CreatePhotoBtnWasClicked;
        public CreatingPhoto(List<Photo> photoList, string photoTitle)
        {
            InitializeComponent();
            CreatePhotoBtnWasClicked = false;
            TitleTB.Text = photoTitle;
            PhotoDateTimePicker.MinDate = DateTime.Now;

            if (CreatePhotoBtnWasClicked == true)
            {
                Photo newPhoto = new Photo(TitleTB.Text, DescriptionTB.Text, PhotoPath, Tags.None);
                photoList.Add(newPhoto);
                
            }
        }

        public string PhotoPath;

        public string ChooseFolder()
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                return sFileName;
            }
            else
                return "";
        }

        private void ChooseImageBtn_Click(object sender, EventArgs e)
        {
            PhotoPath = ChooseFolder();
            var newImage = Image.FromFile(PhotoPath);
            PhotoPB.Image = newImage;
            PhotoPB.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void CreatePhotoBtn_Click(object sender, EventArgs e)
        {
            CreatePhotoBtnWasClicked = true;
            MessageBox.Show("Photo " + TitleTB.Text + " added.");
            Close();
        }

    }
}
