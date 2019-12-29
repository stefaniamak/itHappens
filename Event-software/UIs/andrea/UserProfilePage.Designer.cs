namespace itHappens.UIs.andrea
{
    partial class UserProfilePage
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
            this.profileCoverBox = new System.Windows.Forms.PictureBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.ovalPictureBox1 = new itHappens.UIs.Common.OvalPictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.eventsUserTab = new System.Windows.Forms.TabPage();
            this.PastVisitsTab = new System.Windows.Forms.TabPage();
            this.InterestedUserTab = new System.Windows.Forms.TabPage();
            this.UserStatusTab = new System.Windows.Forms.TabPage();
            this.InvitesUserTab = new System.Windows.Forms.TabPage();
            this.UserEventsTab = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.profileCoverBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // profileCoverBox
            // 
            this.profileCoverBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.profileCoverBox.Location = new System.Drawing.Point(75, 14);
            this.profileCoverBox.Margin = new System.Windows.Forms.Padding(4);
            this.profileCoverBox.Name = "profileCoverBox";
            this.profileCoverBox.Size = new System.Drawing.Size(1396, 308);
            this.profileCoverBox.TabIndex = 4;
            this.profileCoverBox.TabStop = false;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(179, 248);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(247, 55);
            this.userNameLabel.TabIndex = 9;
            this.userNameLabel.Text = "Username";
            // 
            // ovalPictureBox1
            // 
            this.ovalPictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.ovalPictureBox1.Location = new System.Drawing.Point(189, 32);
            this.ovalPictureBox1.Name = "ovalPictureBox1";
            this.ovalPictureBox1.Size = new System.Drawing.Size(180, 176);
            this.ovalPictureBox1.TabIndex = 11;
            this.ovalPictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.eventsUserTab);
            this.tabControl1.Controls.Add(this.PastVisitsTab);
            this.tabControl1.Controls.Add(this.InterestedUserTab);
            this.tabControl1.Controls.Add(this.UserStatusTab);
            this.tabControl1.Controls.Add(this.InvitesUserTab);
            this.tabControl1.Controls.Add(this.UserEventsTab);
            this.tabControl1.Location = new System.Drawing.Point(75, 428);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(25, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1420, 555);
            this.tabControl1.TabIndex = 12;
            // 
            // eventsUserTab
            // 
            this.eventsUserTab.Location = new System.Drawing.Point(8, 39);
            this.eventsUserTab.Name = "eventsUserTab";
            this.eventsUserTab.Padding = new System.Windows.Forms.Padding(3);
            this.eventsUserTab.Size = new System.Drawing.Size(1404, 508);
            this.eventsUserTab.TabIndex = 0;
            this.eventsUserTab.Text = "EVENTS";
            this.eventsUserTab.UseVisualStyleBackColor = true;
            // 
            // PastVisitsTab
            // 
            this.PastVisitsTab.Location = new System.Drawing.Point(8, 39);
            this.PastVisitsTab.Name = "PastVisitsTab";
            this.PastVisitsTab.Padding = new System.Windows.Forms.Padding(3);
            this.PastVisitsTab.Size = new System.Drawing.Size(1404, 508);
            this.PastVisitsTab.TabIndex = 1;
            this.PastVisitsTab.Text = "PAST VISITS";
            this.PastVisitsTab.UseVisualStyleBackColor = true;
            // 
            // InterestedUserTab
            // 
            this.InterestedUserTab.Location = new System.Drawing.Point(8, 39);
            this.InterestedUserTab.Name = "InterestedUserTab";
            this.InterestedUserTab.Padding = new System.Windows.Forms.Padding(3);
            this.InterestedUserTab.Size = new System.Drawing.Size(1404, 508);
            this.InterestedUserTab.TabIndex = 2;
            this.InterestedUserTab.Text = "INTERESTED";
            this.InterestedUserTab.UseVisualStyleBackColor = true;
            // 
            // UserStatusTab
            // 
            this.UserStatusTab.Location = new System.Drawing.Point(8, 39);
            this.UserStatusTab.Name = "UserStatusTab";
            this.UserStatusTab.Size = new System.Drawing.Size(1404, 508);
            this.UserStatusTab.TabIndex = 3;
            this.UserStatusTab.Text = "USER STATUS";
            this.UserStatusTab.UseVisualStyleBackColor = true;
            // 
            // InvitesUserTab
            // 
            this.InvitesUserTab.Location = new System.Drawing.Point(8, 39);
            this.InvitesUserTab.Name = "InvitesUserTab";
            this.InvitesUserTab.Size = new System.Drawing.Size(1404, 508);
            this.InvitesUserTab.TabIndex = 4;
            this.InvitesUserTab.Text = "INVITES";
            this.InvitesUserTab.UseVisualStyleBackColor = true;
            // 
            // UserEventsTab
            // 
            this.UserEventsTab.Location = new System.Drawing.Point(8, 39);
            this.UserEventsTab.Name = "UserEventsTab";
            this.UserEventsTab.Size = new System.Drawing.Size(1404, 508);
            this.UserEventsTab.TabIndex = 5;
            this.UserEventsTab.Text = "USERS EVENTS";
            this.UserEventsTab.UseVisualStyleBackColor = true;
            // 
            // UserProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ovalPictureBox1);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.profileCoverBox);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "UserProfilePage";
            this.Size = new System.Drawing.Size(1626, 1042);
            this.Load += new System.EventHandler(this.UserProfilePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profileCoverBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox profileCoverBox;
        private System.Windows.Forms.Label userNameLabel;
        private Common.OvalPictureBox ovalPictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage eventsUserTab;
        private System.Windows.Forms.TabPage PastVisitsTab;
        private System.Windows.Forms.TabPage InterestedUserTab;
        private System.Windows.Forms.TabPage UserStatusTab;
        private System.Windows.Forms.TabPage InvitesUserTab;
        private System.Windows.Forms.TabPage UserEventsTab;
    }
}
