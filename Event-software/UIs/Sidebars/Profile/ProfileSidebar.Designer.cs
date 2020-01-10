namespace itHappens.UIs.Sidebars
{
    partial class ProfileSidebar
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileSidebar));
            usernameLable = new System.Windows.Forms.Label();
            this.bellNotificationPictureBox = new System.Windows.Forms.PictureBox();
            LogoutButton = new System.Windows.Forms.Button();
            this.ovalPictureBox1 = new itHappens.UIs.Common.OvalPictureBox();
            this.notificationBox = new itHappens.UIs.Common.NotificationBox();
            ((System.ComponentModel.ISupportInitialize)(this.bellNotificationPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLable
            // 
            usernameLable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            usernameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usernameLable.ForeColor = System.Drawing.Color.DarkOrange;
            usernameLable.Location = new System.Drawing.Point(17, 101);
            usernameLable.Name = "usernameLable";
            usernameLable.Size = new System.Drawing.Size(104, 18);
            usernameLable.TabIndex = 1;
            usernameLable.Text = "Username";
            usernameLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bellNotificationPictureBox
            // 
            this.bellNotificationPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bellNotificationPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bellNotificationPictureBox.BackgroundImage")));
            this.bellNotificationPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bellNotificationPictureBox.Location = new System.Drawing.Point(114, 0);
            this.bellNotificationPictureBox.Name = "bellNotificationPictureBox";
            this.bellNotificationPictureBox.Size = new System.Drawing.Size(27, 26);
            this.bellNotificationPictureBox.TabIndex = 3;
            this.bellNotificationPictureBox.TabStop = false;
            this.bellNotificationPictureBox.Click += new System.EventHandler(this.bellNotificationPictureBox_Click);
            // 
            // LogoutButton
            // 
            LogoutButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            LogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            LogoutButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            LogoutButton.Location = new System.Drawing.Point(35, 136);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new System.Drawing.Size(77, 21);
            LogoutButton.TabIndex = 4;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = false;
            LogoutButton.Visible = false;
            LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // ovalPictureBox1
            // 
            this.ovalPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ovalPictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.ovalPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ovalPictureBox1.BackgroundImage")));
            this.ovalPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ovalPictureBox1.Location = new System.Drawing.Point(47, 49);
            this.ovalPictureBox1.Name = "ovalPictureBox1";
            this.ovalPictureBox1.Size = new System.Drawing.Size(48, 49);
            this.ovalPictureBox1.TabIndex = 4;
            this.ovalPictureBox1.TabStop = false;
            // 
            // notificationBox
            // 
            this.notificationBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.notificationBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.notificationBox.Location = new System.Drawing.Point(0, 25);
            this.notificationBox.Name = "notificationBox";
            this.notificationBox.Size = new System.Drawing.Size(142, 150);
            this.notificationBox.TabIndex = 5;
            this.notificationBox.Visible = false;
            // 
            // ProfileSidebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.notificationBox);
            this.Controls.Add(this.ovalPictureBox1);
            this.Controls.Add(LogoutButton);
            this.Controls.Add(this.bellNotificationPictureBox);
            this.Controls.Add(usernameLable);
            this.Name = "ProfileSidebar";
            this.Size = new System.Drawing.Size(142, 175);
            ((System.ComponentModel.ISupportInitialize)(this.bellNotificationPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Common.OvalPictureBox ovalPictureBox1;

        private System.Windows.Forms.PictureBox bellNotificationPictureBox;
        private Common.NotificationBox notificationBox;
        public static System.Windows.Forms.Button LogoutButton;
        public static System.Windows.Forms.Label usernameLable;
    }
}
