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
            this.usernameLable = new System.Windows.Forms.Label();
            this.profilePicPictureBox1 = new System.Windows.Forms.PictureBox();
            this.bellNotificationPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bellNotificationPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLable
            // 
            this.usernameLable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernameLable.AutoSize = true;
            this.usernameLable.Location = new System.Drawing.Point(31, 106);
            this.usernameLable.Name = "usernameLable";
            this.usernameLable.Size = new System.Drawing.Size(80, 13);
            this.usernameLable.TabIndex = 1;
            this.usernameLable.Text = "Name Surname";
            // 
            // profilePicPictureBox1
            // 
            this.profilePicPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.profilePicPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profilePicPictureBox1.BackgroundImage")));
            this.profilePicPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.profilePicPictureBox1.Location = new System.Drawing.Point(47, 48);
            this.profilePicPictureBox1.Name = "profilePicPictureBox1";
            this.profilePicPictureBox1.Size = new System.Drawing.Size(51, 50);
            this.profilePicPictureBox1.TabIndex = 2;
            this.profilePicPictureBox1.TabStop = false;
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
            // 
            // ProfileSidebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.Controls.Add(this.bellNotificationPictureBox);
            this.Controls.Add(this.profilePicPictureBox1);
            this.Controls.Add(this.usernameLable);
            this.Name = "ProfileSidebar";
            this.Size = new System.Drawing.Size(142, 175);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bellNotificationPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLable;
        private System.Windows.Forms.PictureBox profilePicPictureBox1;
        private System.Windows.Forms.PictureBox bellNotificationPictureBox;
    }
}
