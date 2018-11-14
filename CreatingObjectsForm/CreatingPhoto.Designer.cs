namespace CreatingObjectsForm
{
    partial class CreatingPhoto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PhotoPB = new System.Windows.Forms.PictureBox();
            this.TitleTB = new System.Windows.Forms.TextBox();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.ChooseImageBtn = new System.Windows.Forms.Button();
            this.PhotoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CreatePhotoBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PhotoPB
            // 
            this.PhotoPB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhotoPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhotoPB.Location = new System.Drawing.Point(282, 0);
            this.PhotoPB.Name = "PhotoPB";
            this.PhotoPB.Size = new System.Drawing.Size(1042, 600);
            this.PhotoPB.TabIndex = 0;
            this.PhotoPB.TabStop = false;
            // 
            // TitleTB
            // 
            this.TitleTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleTB.Location = new System.Drawing.Point(43, 41);
            this.TitleTB.Name = "TitleTB";
            this.TitleTB.Size = new System.Drawing.Size(212, 38);
            this.TitleTB.TabIndex = 1;
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionTB.Location = new System.Drawing.Point(43, 97);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(212, 38);
            this.DescriptionTB.TabIndex = 2;
            this.DescriptionTB.Text = "Description...";
            // 
            // ChooseImageBtn
            // 
            this.ChooseImageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseImageBtn.Location = new System.Drawing.Point(43, 151);
            this.ChooseImageBtn.Name = "ChooseImageBtn";
            this.ChooseImageBtn.Size = new System.Drawing.Size(212, 41);
            this.ChooseImageBtn.TabIndex = 3;
            this.ChooseImageBtn.Text = "Choose Image";
            this.ChooseImageBtn.UseVisualStyleBackColor = true;
            this.ChooseImageBtn.Click += new System.EventHandler(this.ChooseImageBtn_Click);
            // 
            // PhotoDateTimePicker
            // 
            this.PhotoDateTimePicker.Location = new System.Drawing.Point(43, 211);
            this.PhotoDateTimePicker.Name = "PhotoDateTimePicker";
            this.PhotoDateTimePicker.Size = new System.Drawing.Size(212, 20);
            this.PhotoDateTimePicker.TabIndex = 4;
            // 
            // CreatePhotoBtn
            // 
            this.CreatePhotoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatePhotoBtn.Location = new System.Drawing.Point(43, 337);
            this.CreatePhotoBtn.Name = "CreatePhotoBtn";
            this.CreatePhotoBtn.Size = new System.Drawing.Size(212, 41);
            this.CreatePhotoBtn.TabIndex = 5;
            this.CreatePhotoBtn.Text = "Create";
            this.CreatePhotoBtn.UseVisualStyleBackColor = true;
            this.CreatePhotoBtn.Click += new System.EventHandler(this.CreatePhotoBtn_Click);
            // 
            // CreatingPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 609);
            this.Controls.Add(this.CreatePhotoBtn);
            this.Controls.Add(this.PhotoDateTimePicker);
            this.Controls.Add(this.ChooseImageBtn);
            this.Controls.Add(this.DescriptionTB);
            this.Controls.Add(this.TitleTB);
            this.Controls.Add(this.PhotoPB);
            this.Name = "CreatingPhoto";
            this.Text = "CreatingPhoto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox PhotoPB;
        private System.Windows.Forms.TextBox TitleTB;
        private System.Windows.Forms.TextBox DescriptionTB;
        private System.Windows.Forms.Button ChooseImageBtn;
        private System.Windows.Forms.DateTimePicker PhotoDateTimePicker;
        private System.Windows.Forms.Button CreatePhotoBtn;
    }
}