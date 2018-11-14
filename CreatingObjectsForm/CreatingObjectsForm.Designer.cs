namespace CreatingObjectsForm
{
    partial class CreatingObjectsForm
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
            this.ObjectNameTB = new System.Windows.Forms.TextBox();
            this.ObjectsComboBox = new System.Windows.Forms.ComboBox();
            this.ControlsComboBox = new System.Windows.Forms.ComboBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.OperationLabel = new System.Windows.Forms.Label();
            this.ShowObjectsTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ObjectNameTB
            // 
            this.ObjectNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ObjectNameTB.Location = new System.Drawing.Point(552, 313);
            this.ObjectNameTB.Name = "ObjectNameTB";
            this.ObjectNameTB.Size = new System.Drawing.Size(100, 38);
            this.ObjectNameTB.TabIndex = 1;
            this.ObjectNameTB.Text = "Name...";
            // 
            // ObjectsComboBox
            // 
            this.ObjectsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ObjectsComboBox.FormattingEnabled = true;
            this.ObjectsComboBox.Items.AddRange(new object[] {
            "User",
            "Album",
            "Photo"});
            this.ObjectsComboBox.Location = new System.Drawing.Point(404, 313);
            this.ObjectsComboBox.Name = "ObjectsComboBox";
            this.ObjectsComboBox.Size = new System.Drawing.Size(142, 39);
            this.ObjectsComboBox.TabIndex = 2;
            // 
            // ControlsComboBox
            // 
            this.ControlsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ControlsComboBox.FormattingEnabled = true;
            this.ControlsComboBox.Items.AddRange(new object[] {
            "Creating",
            "Removing"});
            this.ControlsComboBox.Location = new System.Drawing.Point(658, 314);
            this.ControlsComboBox.Name = "ControlsComboBox";
            this.ControlsComboBox.Size = new System.Drawing.Size(171, 39);
            this.ControlsComboBox.TabIndex = 3;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateBtn.Location = new System.Drawing.Point(835, 313);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(147, 40);
            this.CreateBtn.TabIndex = 4;
            this.CreateBtn.Text = "Do it!";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogoLabel.Location = new System.Drawing.Point(366, 155);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(655, 80);
            this.LogoLabel.TabIndex = 5;
            this.LogoLabel.Text = "Create your own object!";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeLabel.Location = new System.Drawing.Point(295, 358);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(106, 39);
            this.TypeLabel.TabIndex = 6;
            this.TypeLabel.Text = "Type ↗";
            // 
            // OperationLabel
            // 
            this.OperationLabel.AutoSize = true;
            this.OperationLabel.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OperationLabel.Location = new System.Drawing.Point(734, 385);
            this.OperationLabel.Name = "OperationLabel";
            this.OperationLabel.Size = new System.Drawing.Size(153, 36);
            this.OperationLabel.TabIndex = 7;
            this.OperationLabel.Text = "↑ Operation";
            // 
            // ShowObjectsTB
            // 
            this.ShowObjectsTB.Location = new System.Drawing.Point(404, 526);
            this.ShowObjectsTB.Multiline = true;
            this.ShowObjectsTB.Name = "ShowObjectsTB";
            this.ShowObjectsTB.Size = new System.Drawing.Size(578, 20);
            this.ShowObjectsTB.TabIndex = 8;
            this.ShowObjectsTB.TextChanged += new System.EventHandler(this.ShowObjectsTB_TextChanged);
            // 
            // CreatingObjectsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1327, 561);
            this.Controls.Add(this.ShowObjectsTB);
            this.Controls.Add(this.OperationLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.LogoLabel);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.ControlsComboBox);
            this.Controls.Add(this.ObjectsComboBox);
            this.Controls.Add(this.ObjectNameTB);
            this.Name = "CreatingObjectsForm";
            this.Text = "CreatingObjects";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ObjectNameTB;
        private System.Windows.Forms.ComboBox ObjectsComboBox;
        private System.Windows.Forms.ComboBox ControlsComboBox;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label OperationLabel;
        private System.Windows.Forms.TextBox ShowObjectsTB;
    }
}

