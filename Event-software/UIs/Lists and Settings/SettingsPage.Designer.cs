namespace itHappens.UIs.valentina
{
    partial class SettingsPage
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
            this.SettingsTab = new System.Windows.Forms.TabControl();
            this.ProfileSettingsTab = new System.Windows.Forms.TabPage();
            this.ProfileTitleLabel = new System.Windows.Forms.Label();
            this.RegionSettingsTextBox = new System.Windows.Forms.TextBox();
            this.RegionSettingsLabel = new System.Windows.Forms.Label();
            this.ProfilePictureBoxEdit = new System.Windows.Forms.PictureBox();
            this.UpdateChangesButton = new System.Windows.Forms.Button();
            this.NameSettingsTextBox = new System.Windows.Forms.TextBox();
            this.RepeatNewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ProfilePictureLabel = new System.Windows.Forms.Label();
            this.NewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.EditPictureButton = new System.Windows.Forms.Button();
            this.PasswordSettingsLabel = new System.Windows.Forms.Label();
            this.NameSettingsLabel = new System.Windows.Forms.Label();
            this.LanguageSettingsComboBox = new System.Windows.Forms.ComboBox();
            this.EmailSettingsLabel = new System.Windows.Forms.Label();
            this.EmailSettingsTextBox = new System.Windows.Forms.TextBox();
            this.LanguageSettingsLabel = new System.Windows.Forms.Label();
            this.NotificationsTabPage = new System.Windows.Forms.TabPage();
            this.EventsNearbyNoticeCheckBox = new System.Windows.Forms.CheckBox();
            this.FriendAttendsCheckBox = new System.Windows.Forms.CheckBox();
            this.NewEventNoticeCheckBox = new System.Windows.Forms.CheckBox();
            this.FollowNoticeCheckBox = new System.Windows.Forms.CheckBox();
            this.EventsNearbyLabel = new System.Windows.Forms.Label();
            this.FriendAttendsNoticeLabel = new System.Windows.Forms.Label();
            this.NewEventsNoticeLabel = new System.Windows.Forms.Label();
            this.FollowNoticeLabel = new System.Windows.Forms.Label();
            this.PushNotificationsLabel = new System.Windows.Forms.Label();
            this.LinkedAccountsTabPage = new System.Windows.Forms.TabPage();
            this.ConnectFacebookButton = new System.Windows.Forms.Button();
            this.FacebookLabel = new System.Windows.Forms.Label();
            this.LinkedAccountsLabel = new System.Windows.Forms.Label();
            this.DeleteAccountTabPage = new System.Windows.Forms.TabPage();
            this.DangerZoneLabel = new System.Windows.Forms.Label();
            this.DeleteAccountButton = new System.Windows.Forms.Button();
            this.AccountLabel = new System.Windows.Forms.Label();
            this.SettingsTab.SuspendLayout();
            this.ProfileSettingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBoxEdit)).BeginInit();
            this.NotificationsTabPage.SuspendLayout();
            this.LinkedAccountsTabPage.SuspendLayout();
            this.DeleteAccountTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsTab
            // 
            this.SettingsTab.AccessibleDescription = "";
            this.SettingsTab.AccessibleName = "";
            this.SettingsTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsTab.Controls.Add(this.ProfileSettingsTab);
            this.SettingsTab.Controls.Add(this.NotificationsTabPage);
            this.SettingsTab.Controls.Add(this.LinkedAccountsTabPage);
            this.SettingsTab.Controls.Add(this.DeleteAccountTabPage);
            this.SettingsTab.Location = new System.Drawing.Point(0, 1);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.SelectedIndex = 0;
            this.SettingsTab.Size = new System.Drawing.Size(836, 541);
            this.SettingsTab.TabIndex = 45;
            // 
            // ProfileSettingsTab
            // 
            this.ProfileSettingsTab.AutoScroll = true;
            this.ProfileSettingsTab.Controls.Add(this.ProfileTitleLabel);
            this.ProfileSettingsTab.Controls.Add(this.RegionSettingsTextBox);
            this.ProfileSettingsTab.Controls.Add(this.RegionSettingsLabel);
            this.ProfileSettingsTab.Controls.Add(this.ProfilePictureBoxEdit);
            this.ProfileSettingsTab.Controls.Add(this.UpdateChangesButton);
            this.ProfileSettingsTab.Controls.Add(this.NameSettingsTextBox);
            this.ProfileSettingsTab.Controls.Add(this.RepeatNewPasswordTextBox);
            this.ProfileSettingsTab.Controls.Add(this.ProfilePictureLabel);
            this.ProfileSettingsTab.Controls.Add(this.NewPasswordTextBox);
            this.ProfileSettingsTab.Controls.Add(this.EditPictureButton);
            this.ProfileSettingsTab.Controls.Add(this.PasswordSettingsLabel);
            this.ProfileSettingsTab.Controls.Add(this.NameSettingsLabel);
            this.ProfileSettingsTab.Controls.Add(this.LanguageSettingsComboBox);
            this.ProfileSettingsTab.Controls.Add(this.EmailSettingsLabel);
            this.ProfileSettingsTab.Controls.Add(this.EmailSettingsTextBox);
            this.ProfileSettingsTab.Controls.Add(this.LanguageSettingsLabel);
            this.ProfileSettingsTab.Location = new System.Drawing.Point(4, 22);
            this.ProfileSettingsTab.Name = "ProfileSettingsTab";
            this.ProfileSettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProfileSettingsTab.Size = new System.Drawing.Size(828, 515);
            this.ProfileSettingsTab.TabIndex = 0;
            this.ProfileSettingsTab.Text = "Profile";
            this.ProfileSettingsTab.UseVisualStyleBackColor = true;
            // 
            // ProfileTitleLabel
            // 
            this.ProfileTitleLabel.AutoSize = true;
            this.ProfileTitleLabel.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileTitleLabel.Location = new System.Drawing.Point(285, 51);
            this.ProfileTitleLabel.Name = "ProfileTitleLabel";
            this.ProfileTitleLabel.Size = new System.Drawing.Size(104, 31);
            this.ProfileTitleLabel.TabIndex = 19;
            this.ProfileTitleLabel.Text = "Profile";
            this.ProfileTitleLabel.Click += new System.EventHandler(this.ProfileTitleSettings_Click);
            // 
            // RegionSettingsTextBox
            // 
            this.RegionSettingsTextBox.Location = new System.Drawing.Point(291, 467);
            this.RegionSettingsTextBox.Name = "RegionSettingsTextBox";
            this.RegionSettingsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.RegionSettingsTextBox.Size = new System.Drawing.Size(136, 20);
            this.RegionSettingsTextBox.TabIndex = 16;
            // 
            // RegionSettingsLabel
            // 
            this.RegionSettingsLabel.AutoSize = true;
            this.RegionSettingsLabel.Location = new System.Drawing.Point(288, 451);
            this.RegionSettingsLabel.Name = "RegionSettingsLabel";
            this.RegionSettingsLabel.Size = new System.Drawing.Size(41, 13);
            this.RegionSettingsLabel.TabIndex = 15;
            this.RegionSettingsLabel.Text = "Region";
            // 
            // ProfilePictureBoxEdit
            // 
            this.ProfilePictureBoxEdit.Location = new System.Drawing.Point(291, 143);
            this.ProfilePictureBoxEdit.Name = "ProfilePictureBoxEdit";
            this.ProfilePictureBoxEdit.Size = new System.Drawing.Size(100, 99);
            this.ProfilePictureBoxEdit.TabIndex = 2;
            this.ProfilePictureBoxEdit.TabStop = false;
            // 
            // UpdateChangesButton
            // 
            this.UpdateChangesButton.Location = new System.Drawing.Point(292, 580);
            this.UpdateChangesButton.Name = "UpdateChangesButton";
            this.UpdateChangesButton.Size = new System.Drawing.Size(198, 32);
            this.UpdateChangesButton.TabIndex = 14;
            this.UpdateChangesButton.Text = "Update Changes";
            this.UpdateChangesButton.UseVisualStyleBackColor = true;
            // 
            // NameSettingsTextBox
            // 
            this.NameSettingsTextBox.Location = new System.Drawing.Point(291, 289);
            this.NameSettingsTextBox.Name = "NameSettingsTextBox";
            this.NameSettingsTextBox.Size = new System.Drawing.Size(136, 20);
            this.NameSettingsTextBox.TabIndex = 1;
            // 
            // RepeatNewPasswordTextBox
            // 
            this.RepeatNewPasswordTextBox.Location = new System.Drawing.Point(291, 365);
            this.RepeatNewPasswordTextBox.Name = "RepeatNewPasswordTextBox";
            this.RepeatNewPasswordTextBox.Size = new System.Drawing.Size(136, 20);
            this.RepeatNewPasswordTextBox.TabIndex = 13;
            // 
            // ProfilePictureLabel
            // 
            this.ProfilePictureLabel.AutoSize = true;
            this.ProfilePictureLabel.Location = new System.Drawing.Point(288, 127);
            this.ProfilePictureLabel.Name = "ProfilePictureLabel";
            this.ProfilePictureLabel.Size = new System.Drawing.Size(72, 13);
            this.ProfilePictureLabel.TabIndex = 3;
            this.ProfilePictureLabel.Text = "Profile Picture";
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.Location = new System.Drawing.Point(291, 339);
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.Size = new System.Drawing.Size(136, 20);
            this.NewPasswordTextBox.TabIndex = 12;
            // 
            // EditPictureButton
            // 
            this.EditPictureButton.Location = new System.Drawing.Point(414, 219);
            this.EditPictureButton.Name = "EditPictureButton";
            this.EditPictureButton.Size = new System.Drawing.Size(75, 23);
            this.EditPictureButton.TabIndex = 4;
            this.EditPictureButton.Text = "Edit";
            this.EditPictureButton.UseVisualStyleBackColor = true;
            // 
            // PasswordSettingsLabel
            // 
            this.PasswordSettingsLabel.AutoSize = true;
            this.PasswordSettingsLabel.Location = new System.Drawing.Point(288, 323);
            this.PasswordSettingsLabel.Name = "PasswordSettingsLabel";
            this.PasswordSettingsLabel.Size = new System.Drawing.Size(115, 13);
            this.PasswordSettingsLabel.TabIndex = 11;
            this.PasswordSettingsLabel.Text = "Change your password";
            // 
            // NameSettingsLabel
            // 
            this.NameSettingsLabel.AutoSize = true;
            this.NameSettingsLabel.Location = new System.Drawing.Point(288, 273);
            this.NameSettingsLabel.Name = "NameSettingsLabel";
            this.NameSettingsLabel.Size = new System.Drawing.Size(35, 13);
            this.NameSettingsLabel.TabIndex = 5;
            this.NameSettingsLabel.Text = "Name";
            // 
            // LanguageSettingsComboBox
            // 
            this.LanguageSettingsComboBox.FormattingEnabled = true;
            this.LanguageSettingsComboBox.Location = new System.Drawing.Point(291, 524);
            this.LanguageSettingsComboBox.Name = "LanguageSettingsComboBox";
            this.LanguageSettingsComboBox.Size = new System.Drawing.Size(136, 21);
            this.LanguageSettingsComboBox.TabIndex = 10;
            // 
            // EmailSettingsLabel
            // 
            this.EmailSettingsLabel.AutoSize = true;
            this.EmailSettingsLabel.Location = new System.Drawing.Point(288, 397);
            this.EmailSettingsLabel.Name = "EmailSettingsLabel";
            this.EmailSettingsLabel.Size = new System.Drawing.Size(32, 13);
            this.EmailSettingsLabel.TabIndex = 6;
            this.EmailSettingsLabel.Text = "Email";
            // 
            // EmailSettingsTextBox
            // 
            this.EmailSettingsTextBox.Location = new System.Drawing.Point(291, 413);
            this.EmailSettingsTextBox.Name = "EmailSettingsTextBox";
            this.EmailSettingsTextBox.Size = new System.Drawing.Size(136, 20);
            this.EmailSettingsTextBox.TabIndex = 8;
            // 
            // LanguageSettingsLabel
            // 
            this.LanguageSettingsLabel.AutoSize = true;
            this.LanguageSettingsLabel.Location = new System.Drawing.Point(288, 508);
            this.LanguageSettingsLabel.Name = "LanguageSettingsLabel";
            this.LanguageSettingsLabel.Size = new System.Drawing.Size(55, 13);
            this.LanguageSettingsLabel.TabIndex = 7;
            this.LanguageSettingsLabel.Text = "Language";
            // 
            // NotificationsTabPage
            // 
            this.NotificationsTabPage.Controls.Add(this.EventsNearbyNoticeCheckBox);
            this.NotificationsTabPage.Controls.Add(this.FriendAttendsCheckBox);
            this.NotificationsTabPage.Controls.Add(this.NewEventNoticeCheckBox);
            this.NotificationsTabPage.Controls.Add(this.FollowNoticeCheckBox);
            this.NotificationsTabPage.Controls.Add(this.EventsNearbyLabel);
            this.NotificationsTabPage.Controls.Add(this.FriendAttendsNoticeLabel);
            this.NotificationsTabPage.Controls.Add(this.NewEventsNoticeLabel);
            this.NotificationsTabPage.Controls.Add(this.FollowNoticeLabel);
            this.NotificationsTabPage.Controls.Add(this.PushNotificationsLabel);
            this.NotificationsTabPage.Location = new System.Drawing.Point(4, 22);
            this.NotificationsTabPage.Name = "NotificationsTabPage";
            this.NotificationsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.NotificationsTabPage.Size = new System.Drawing.Size(828, 515);
            this.NotificationsTabPage.TabIndex = 1;
            this.NotificationsTabPage.Text = "Notifications";
            this.NotificationsTabPage.UseVisualStyleBackColor = true;
            // 
            // EventsNearbyNoticeCheckBox
            // 
            this.EventsNearbyNoticeCheckBox.AutoSize = true;
            this.EventsNearbyNoticeCheckBox.Location = new System.Drawing.Point(526, 270);
            this.EventsNearbyNoticeCheckBox.Name = "EventsNearbyNoticeCheckBox";
            this.EventsNearbyNoticeCheckBox.Size = new System.Drawing.Size(15, 14);
            this.EventsNearbyNoticeCheckBox.TabIndex = 8;
            this.EventsNearbyNoticeCheckBox.UseVisualStyleBackColor = true;
            // 
            // FriendAttendsCheckBox
            // 
            this.FriendAttendsCheckBox.AutoSize = true;
            this.FriendAttendsCheckBox.Location = new System.Drawing.Point(526, 225);
            this.FriendAttendsCheckBox.Name = "FriendAttendsCheckBox";
            this.FriendAttendsCheckBox.Size = new System.Drawing.Size(15, 14);
            this.FriendAttendsCheckBox.TabIndex = 7;
            this.FriendAttendsCheckBox.UseVisualStyleBackColor = true;
            // 
            // NewEventNoticeCheckBox
            // 
            this.NewEventNoticeCheckBox.AutoSize = true;
            this.NewEventNoticeCheckBox.Location = new System.Drawing.Point(526, 174);
            this.NewEventNoticeCheckBox.Name = "NewEventNoticeCheckBox";
            this.NewEventNoticeCheckBox.Size = new System.Drawing.Size(15, 14);
            this.NewEventNoticeCheckBox.TabIndex = 6;
            this.NewEventNoticeCheckBox.UseVisualStyleBackColor = true;
            // 
            // FollowNoticeCheckBox
            // 
            this.FollowNoticeCheckBox.AutoSize = true;
            this.FollowNoticeCheckBox.Location = new System.Drawing.Point(526, 132);
            this.FollowNoticeCheckBox.Name = "FollowNoticeCheckBox";
            this.FollowNoticeCheckBox.Size = new System.Drawing.Size(15, 14);
            this.FollowNoticeCheckBox.TabIndex = 5;
            this.FollowNoticeCheckBox.UseVisualStyleBackColor = true;
            // 
            // EventsNearbyLabel
            // 
            this.EventsNearbyLabel.AutoSize = true;
            this.EventsNearbyLabel.Location = new System.Drawing.Point(287, 271);
            this.EventsNearbyLabel.Name = "EventsNearbyLabel";
            this.EventsNearbyLabel.Size = new System.Drawing.Size(77, 13);
            this.EventsNearbyLabel.TabIndex = 4;
            this.EventsNearbyLabel.Text = "Events Nearby";
            // 
            // FriendAttendsNoticeLabel
            // 
            this.FriendAttendsNoticeLabel.AutoSize = true;
            this.FriendAttendsNoticeLabel.Location = new System.Drawing.Point(287, 226);
            this.FriendAttendsNoticeLabel.Name = "FriendAttendsNoticeLabel";
            this.FriendAttendsNoticeLabel.Size = new System.Drawing.Size(207, 13);
            this.FriendAttendsNoticeLabel.TabIndex = 3;
            this.FriendAttendsNoticeLabel.Text = "A friend is coming to an event you\'re going";
            // 
            // NewEventsNoticeLabel
            // 
            this.NewEventsNoticeLabel.AutoSize = true;
            this.NewEventsNoticeLabel.Location = new System.Drawing.Point(287, 174);
            this.NewEventsNoticeLabel.Name = "NewEventsNoticeLabel";
            this.NewEventsNoticeLabel.Size = new System.Drawing.Size(109, 13);
            this.NewEventsNoticeLabel.TabIndex = 2;
            this.NewEventsNoticeLabel.Text = "New events to check";
            // 
            // FollowNoticeLabel
            // 
            this.FollowNoticeLabel.AutoSize = true;
            this.FollowNoticeLabel.Location = new System.Drawing.Point(287, 132);
            this.FollowNoticeLabel.Name = "FollowNoticeLabel";
            this.FollowNoticeLabel.Size = new System.Drawing.Size(104, 13);
            this.FollowNoticeLabel.TabIndex = 1;
            this.FollowNoticeLabel.Text = "Someone follows me";
            // 
            // PushNotificationsLabel
            // 
            this.PushNotificationsLabel.AutoSize = true;
            this.PushNotificationsLabel.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PushNotificationsLabel.Location = new System.Drawing.Point(284, 51);
            this.PushNotificationsLabel.Name = "PushNotificationsLabel";
            this.PushNotificationsLabel.Size = new System.Drawing.Size(241, 31);
            this.PushNotificationsLabel.TabIndex = 0;
            this.PushNotificationsLabel.Text = "Push Notificaions";
            // 
            // LinkedAccountsTabPage
            // 
            this.LinkedAccountsTabPage.Controls.Add(this.ConnectFacebookButton);
            this.LinkedAccountsTabPage.Controls.Add(this.FacebookLabel);
            this.LinkedAccountsTabPage.Controls.Add(this.LinkedAccountsLabel);
            this.LinkedAccountsTabPage.Location = new System.Drawing.Point(4, 22);
            this.LinkedAccountsTabPage.Name = "LinkedAccountsTabPage";
            this.LinkedAccountsTabPage.Size = new System.Drawing.Size(828, 515);
            this.LinkedAccountsTabPage.TabIndex = 2;
            this.LinkedAccountsTabPage.Text = "Linked Accounts";
            this.LinkedAccountsTabPage.UseVisualStyleBackColor = true;
            // 
            // ConnectFacebookButton
            // 
            this.ConnectFacebookButton.Location = new System.Drawing.Point(429, 133);
            this.ConnectFacebookButton.Name = "ConnectFacebookButton";
            this.ConnectFacebookButton.Size = new System.Drawing.Size(140, 29);
            this.ConnectFacebookButton.TabIndex = 2;
            this.ConnectFacebookButton.Text = "Connect Facebook";
            this.ConnectFacebookButton.UseVisualStyleBackColor = true;
            // 
            // FacebookLabel
            // 
            this.FacebookLabel.AutoSize = true;
            this.FacebookLabel.Location = new System.Drawing.Point(289, 141);
            this.FacebookLabel.Name = "FacebookLabel";
            this.FacebookLabel.Size = new System.Drawing.Size(55, 13);
            this.FacebookLabel.TabIndex = 1;
            this.FacebookLabel.Text = "Facebook";
            // 
            // LinkedAccountsLabel
            // 
            this.LinkedAccountsLabel.AutoSize = true;
            this.LinkedAccountsLabel.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkedAccountsLabel.Location = new System.Drawing.Point(286, 53);
            this.LinkedAccountsLabel.Name = "LinkedAccountsLabel";
            this.LinkedAccountsLabel.Size = new System.Drawing.Size(228, 31);
            this.LinkedAccountsLabel.TabIndex = 0;
            this.LinkedAccountsLabel.Text = "Linked Accounts";
            // 
            // DeleteAccountTabPage
            // 
            this.DeleteAccountTabPage.Controls.Add(this.DangerZoneLabel);
            this.DeleteAccountTabPage.Controls.Add(this.DeleteAccountButton);
            this.DeleteAccountTabPage.Controls.Add(this.AccountLabel);
            this.DeleteAccountTabPage.Location = new System.Drawing.Point(4, 22);
            this.DeleteAccountTabPage.Name = "DeleteAccountTabPage";
            this.DeleteAccountTabPage.Size = new System.Drawing.Size(828, 515);
            this.DeleteAccountTabPage.TabIndex = 3;
            this.DeleteAccountTabPage.Text = "Account";
            this.DeleteAccountTabPage.UseVisualStyleBackColor = true;
            // 
            // DangerZoneLabel
            // 
            this.DangerZoneLabel.AutoSize = true;
            this.DangerZoneLabel.Location = new System.Drawing.Point(289, 130);
            this.DangerZoneLabel.Name = "DangerZoneLabel";
            this.DangerZoneLabel.Size = new System.Drawing.Size(246, 13);
            this.DangerZoneLabel.TabIndex = 2;
            this.DangerZoneLabel.Text = "Danger Zone! Deleting your account is irreversible.";
            // 
            // DeleteAccountButton
            // 
            this.DeleteAccountButton.BackColor = System.Drawing.Color.Red;
            this.DeleteAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.DeleteAccountButton.Location = new System.Drawing.Point(289, 149);
            this.DeleteAccountButton.Name = "DeleteAccountButton";
            this.DeleteAccountButton.Size = new System.Drawing.Size(278, 42);
            this.DeleteAccountButton.TabIndex = 1;
            this.DeleteAccountButton.Text = "Delete Account";
            this.DeleteAccountButton.UseVisualStyleBackColor = false;
            // 
            // AccountLabel
            // 
            this.AccountLabel.AutoSize = true;
            this.AccountLabel.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountLabel.Location = new System.Drawing.Point(286, 56);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.Size = new System.Drawing.Size(116, 31);
            this.AccountLabel.TabIndex = 0;
            this.AccountLabel.Text = "Account";
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.SettingsTab);
            this.Name = "SettingsPage";
            this.Size = new System.Drawing.Size(839, 545);
            this.SettingsTab.ResumeLayout(false);
            this.ProfileSettingsTab.ResumeLayout(false);
            this.ProfileSettingsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBoxEdit)).EndInit();
            this.NotificationsTabPage.ResumeLayout(false);
            this.NotificationsTabPage.PerformLayout();
            this.LinkedAccountsTabPage.ResumeLayout(false);
            this.LinkedAccountsTabPage.PerformLayout();
            this.DeleteAccountTabPage.ResumeLayout(false);
            this.DeleteAccountTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl SettingsTab;
        private System.Windows.Forms.TabPage ProfileSettingsTab;
        private System.Windows.Forms.Label ProfileTitleLabel;
        private System.Windows.Forms.TextBox RegionSettingsTextBox;
        private System.Windows.Forms.Label RegionSettingsLabel;
        private System.Windows.Forms.PictureBox ProfilePictureBoxEdit;
        private System.Windows.Forms.Button UpdateChangesButton;
        private System.Windows.Forms.TextBox NameSettingsTextBox;
        private System.Windows.Forms.TextBox RepeatNewPasswordTextBox;
        private System.Windows.Forms.Label ProfilePictureLabel;
        private System.Windows.Forms.TextBox NewPasswordTextBox;
        private System.Windows.Forms.Button EditPictureButton;
        private System.Windows.Forms.Label PasswordSettingsLabel;
        private System.Windows.Forms.Label NameSettingsLabel;
        private System.Windows.Forms.ComboBox LanguageSettingsComboBox;
        private System.Windows.Forms.Label EmailSettingsLabel;
        private System.Windows.Forms.TextBox EmailSettingsTextBox;
        private System.Windows.Forms.Label LanguageSettingsLabel;
        private System.Windows.Forms.TabPage NotificationsTabPage;
        private System.Windows.Forms.CheckBox EventsNearbyNoticeCheckBox;
        private System.Windows.Forms.CheckBox FriendAttendsCheckBox;
        private System.Windows.Forms.CheckBox NewEventNoticeCheckBox;
        private System.Windows.Forms.CheckBox FollowNoticeCheckBox;
        private System.Windows.Forms.Label EventsNearbyLabel;
        private System.Windows.Forms.Label FriendAttendsNoticeLabel;
        private System.Windows.Forms.Label NewEventsNoticeLabel;
        private System.Windows.Forms.Label FollowNoticeLabel;
        private System.Windows.Forms.Label PushNotificationsLabel;
        private System.Windows.Forms.TabPage LinkedAccountsTabPage;
        private System.Windows.Forms.Button ConnectFacebookButton;
        private System.Windows.Forms.Label FacebookLabel;
        private System.Windows.Forms.Label LinkedAccountsLabel;
        private System.Windows.Forms.TabPage DeleteAccountTabPage;
        private System.Windows.Forms.Label DangerZoneLabel;
        private System.Windows.Forms.Button DeleteAccountButton;
        private System.Windows.Forms.Label AccountLabel;
    }
}
