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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfilePage));
            this.userNameLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.eventsUserTab = new System.Windows.Forms.TabPage();
            this.PastVisitsTab = new System.Windows.Forms.TabPage();
            this.InterestedUserTab = new System.Windows.Forms.TabPage();
            this.UserStatusTab = new System.Windows.Forms.TabPage();
            this.InvitesUserTab = new System.Windows.Forms.TabPage();
            this.UserEventsTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ovalPictureBox1 = new itHappens.UIs.Common.OvalPictureBox();
            this.backgroundPictureBox = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.Black;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.userNameLabel.Location = new System.Drawing.Point(25, 141);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(174, 39);
            this.userNameLabel.TabIndex = 9;
            this.userNameLabel.Text = "Username";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.eventsUserTab);
            this.tabControl1.Controls.Add(this.PastVisitsTab);
            this.tabControl1.Controls.Add(this.InterestedUserTab);
            this.tabControl1.Controls.Add(this.UserStatusTab);
            this.tabControl1.Controls.Add(this.InvitesUserTab);
            this.tabControl1.Controls.Add(this.UserEventsTab);
            this.tabControl1.Location = new System.Drawing.Point(19, 211);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(25, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(766, 331);
            this.tabControl1.TabIndex = 12;
            // 
            // eventsUserTab
            // 
            this.eventsUserTab.Location = new System.Drawing.Point(4, 22);
            this.eventsUserTab.Margin = new System.Windows.Forms.Padding(2);
            this.eventsUserTab.Name = "eventsUserTab";
            this.eventsUserTab.Padding = new System.Windows.Forms.Padding(2);
            this.eventsUserTab.Size = new System.Drawing.Size(758, 305);
            this.eventsUserTab.TabIndex = 0;
            this.eventsUserTab.Text = "EVENTS";
            this.eventsUserTab.UseVisualStyleBackColor = true;
            // 
            // PastVisitsTab
            // 
            this.PastVisitsTab.Location = new System.Drawing.Point(4, 22);
            this.PastVisitsTab.Margin = new System.Windows.Forms.Padding(2);
            this.PastVisitsTab.Name = "PastVisitsTab";
            this.PastVisitsTab.Padding = new System.Windows.Forms.Padding(2);
            this.PastVisitsTab.Size = new System.Drawing.Size(758, 305);
            this.PastVisitsTab.TabIndex = 1;
            this.PastVisitsTab.Text = "PAST VISITS";
            this.PastVisitsTab.UseVisualStyleBackColor = true;
            // 
            // InterestedUserTab
            // 
            this.InterestedUserTab.Location = new System.Drawing.Point(4, 22);
            this.InterestedUserTab.Margin = new System.Windows.Forms.Padding(2);
            this.InterestedUserTab.Name = "InterestedUserTab";
            this.InterestedUserTab.Padding = new System.Windows.Forms.Padding(2);
            this.InterestedUserTab.Size = new System.Drawing.Size(758, 305);
            this.InterestedUserTab.TabIndex = 2;
            this.InterestedUserTab.Text = "INTERESTED";
            this.InterestedUserTab.UseVisualStyleBackColor = true;
            // 
            // UserStatusTab
            // 
            this.UserStatusTab.Location = new System.Drawing.Point(4, 22);
            this.UserStatusTab.Margin = new System.Windows.Forms.Padding(2);
            this.UserStatusTab.Name = "UserStatusTab";
            this.UserStatusTab.Size = new System.Drawing.Size(758, 305);
            this.UserStatusTab.TabIndex = 3;
            this.UserStatusTab.Text = "USER STATUS";
            this.UserStatusTab.UseVisualStyleBackColor = true;
            // 
            // InvitesUserTab
            // 
            this.InvitesUserTab.Location = new System.Drawing.Point(4, 22);
            this.InvitesUserTab.Margin = new System.Windows.Forms.Padding(2);
            this.InvitesUserTab.Name = "InvitesUserTab";
            this.InvitesUserTab.Size = new System.Drawing.Size(758, 305);
            this.InvitesUserTab.TabIndex = 4;
            this.InvitesUserTab.Text = "INVITES";
            this.InvitesUserTab.UseVisualStyleBackColor = true;
            // 
            // UserEventsTab
            // 
            this.UserEventsTab.Location = new System.Drawing.Point(4, 22);
            this.UserEventsTab.Margin = new System.Windows.Forms.Padding(2);
            this.UserEventsTab.Name = "UserEventsTab";
            this.UserEventsTab.Size = new System.Drawing.Size(758, 305);
            this.UserEventsTab.TabIndex = 5;
            this.UserEventsTab.Text = "USERS EVENTS";
            this.UserEventsTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.userNameLabel);
            this.panel1.Controls.Add(this.ovalPictureBox1);
            this.panel1.Controls.Add(this.backgroundPictureBox);
            this.panel1.Location = new System.Drawing.Point(19, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 194);
            this.panel1.TabIndex = 13;
            // 
            // ovalPictureBox1
            // 
            this.ovalPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ovalPictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.ovalPictureBox1.Location = new System.Drawing.Point(639, 68);
            this.ovalPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.ovalPictureBox1.Name = "ovalPictureBox1";
            this.ovalPictureBox1.Size = new System.Drawing.Size(90, 92);
            this.ovalPictureBox1.TabIndex = 11;
            this.ovalPictureBox1.TabStop = false;
            // 
            // backgroundPictureBox
            // 
            this.backgroundPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backgroundPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backgroundPictureBox.BackgroundImage")));
            this.backgroundPictureBox.Location = new System.Drawing.Point(0, -273);
            this.backgroundPictureBox.Name = "backgroundPictureBox";
            this.backgroundPictureBox.Size = new System.Drawing.Size(766, 778);
            this.backgroundPictureBox.TabIndex = 12;
            this.backgroundPictureBox.TabStop = false;
            // 
            // UserProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "UserProfilePage";
            this.Size = new System.Drawing.Size(813, 542);
            this.Load += new System.EventHandler(this.UserProfilePage_Load);
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label userNameLabel;
        private Common.OvalPictureBox ovalPictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage eventsUserTab;
        private System.Windows.Forms.TabPage PastVisitsTab;
        private System.Windows.Forms.TabPage InterestedUserTab;
        private System.Windows.Forms.TabPage UserStatusTab;
        private System.Windows.Forms.TabPage InvitesUserTab;
        private System.Windows.Forms.TabPage UserEventsTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox backgroundPictureBox;
    }
}
