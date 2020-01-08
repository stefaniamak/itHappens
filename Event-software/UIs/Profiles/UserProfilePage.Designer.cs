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
            this.eventsUserWillAttendCarousel = new itHappens.UIs.Common.Carousel();
            this.eventsTheUserWillAttendLabel = new System.Windows.Forms.Label();
            this.vanueLabel = new System.Windows.Forms.Label();
            this.overAtLabel = new System.Windows.Forms.Label();
            this.eventNameLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.upcomingNextPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.categoryColorPanel = new System.Windows.Forms.Panel();
            this.eventShowcasedPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.upNextLabel = new System.Windows.Forms.Label();
            this.PastVisitsTab = new System.Windows.Forms.TabPage();
            this.InterestedUserTab = new System.Windows.Forms.TabPage();
            this.UserStatusTab = new System.Windows.Forms.TabPage();
            this.InvitesUserTab = new System.Windows.Forms.TabPage();
            this.UserEventsTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ovalPictureBox1 = new itHappens.UIs.Common.OvalPictureBox();
            this.backgroundPictureBox = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.eventsUserTab.SuspendLayout();
            this.upcomingNextPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.eventShowcasedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(772, 766);
            this.tabControl1.TabIndex = 12;
            // 
            // eventsUserTab
            // 
            this.eventsUserTab.AutoScroll = true;
            this.eventsUserTab.Controls.Add(this.upNextLabel);
            this.eventsUserTab.Controls.Add(this.eventNameLabel);
            this.eventsUserTab.Controls.Add(this.overAtLabel);
            this.eventsUserTab.Controls.Add(this.vanueLabel);
            this.eventsUserTab.Controls.Add(this.monthLabel);
            this.eventsUserTab.Controls.Add(this.dayLabel);
            this.eventsUserTab.Controls.Add(this.upcomingNextPanel);
            this.eventsUserTab.Controls.Add(this.eventsTheUserWillAttendLabel);
            this.eventsUserTab.Controls.Add(this.eventsUserWillAttendCarousel);
            this.eventsUserTab.Location = new System.Drawing.Point(4, 22);
            this.eventsUserTab.Margin = new System.Windows.Forms.Padding(2);
            this.eventsUserTab.Name = "eventsUserTab";
            this.eventsUserTab.Padding = new System.Windows.Forms.Padding(2);
            this.eventsUserTab.Size = new System.Drawing.Size(764, 740);
            this.eventsUserTab.TabIndex = 0;
            this.eventsUserTab.Text = "EVENTS";
            this.eventsUserTab.UseVisualStyleBackColor = true;
            // 
            // eventsUserWillAttendCarousel
            // 
            this.eventsUserWillAttendCarousel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventsUserWillAttendCarousel.AutoScroll = true;
            this.eventsUserWillAttendCarousel.BackColor = System.Drawing.SystemColors.Control;
            this.eventsUserWillAttendCarousel.Location = new System.Drawing.Point(28, 321);
            this.eventsUserWillAttendCarousel.Name = "eventsUserWillAttendCarousel";
            this.eventsUserWillAttendCarousel.Padding = new System.Windows.Forms.Padding(2);
            this.eventsUserWillAttendCarousel.Size = new System.Drawing.Size(703, 279);
            this.eventsUserWillAttendCarousel.TabIndex = 21;
            // 
            // eventsTheUserWillAttendLabel
            // 
            this.eventsTheUserWillAttendLabel.AutoSize = true;
            this.eventsTheUserWillAttendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsTheUserWillAttendLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.eventsTheUserWillAttendLabel.Location = new System.Drawing.Point(68, 277);
            this.eventsTheUserWillAttendLabel.Name = "eventsTheUserWillAttendLabel";
            this.eventsTheUserWillAttendLabel.Size = new System.Drawing.Size(291, 29);
            this.eventsTheUserWillAttendLabel.TabIndex = 20;
            this.eventsTheUserWillAttendLabel.Text = "Events the user will attend";
            // 
            // vanueLabel
            // 
            this.vanueLabel.AutoSize = true;
            this.vanueLabel.BackColor = System.Drawing.Color.Black;
            this.vanueLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.vanueLabel.Location = new System.Drawing.Point(159, 137);
            this.vanueLabel.Name = "vanueLabel";
            this.vanueLabel.Size = new System.Drawing.Size(48, 13);
            this.vanueLabel.TabIndex = 19;
            this.vanueLabel.Text = "Location";
            // 
            // overAtLabel
            // 
            this.overAtLabel.AutoSize = true;
            this.overAtLabel.BackColor = System.Drawing.Color.Black;
            this.overAtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overAtLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.overAtLabel.Location = new System.Drawing.Point(101, 138);
            this.overAtLabel.Name = "overAtLabel";
            this.overAtLabel.Size = new System.Drawing.Size(45, 13);
            this.overAtLabel.TabIndex = 18;
            this.overAtLabel.Text = "Over at:";
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.eventNameLabel.AutoSize = true;
            this.eventNameLabel.BackColor = System.Drawing.Color.Black;
            this.eventNameLabel.Font = new System.Drawing.Font("Century Gothic", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventNameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.eventNameLabel.Location = new System.Drawing.Point(95, 85);
            this.eventNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(212, 40);
            this.eventNameLabel.TabIndex = 11;
            this.eventNameLabel.Text = "Event Name";
            // 
            // monthLabel
            // 
            this.monthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.monthLabel.AutoSize = true;
            this.monthLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.monthLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.monthLabel.Location = new System.Drawing.Point(506, 133);
            this.monthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(77, 33);
            this.monthLabel.TabIndex = 10;
            this.monthLabel.Text = "NOV";
            // 
            // dayLabel
            // 
            this.dayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dayLabel.AutoSize = true;
            this.dayLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dayLabel.Font = new System.Drawing.Font("Century Gothic", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.dayLabel.Location = new System.Drawing.Point(506, 169);
            this.dayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(77, 57);
            this.dayLabel.TabIndex = 9;
            this.dayLabel.Text = "25";
            // 
            // upcomingNextPanel
            // 
            this.upcomingNextPanel.Controls.Add(this.tableLayoutPanel1);
            this.upcomingNextPanel.Location = new System.Drawing.Point(50, 68);
            this.upcomingNextPanel.Name = "upcomingNextPanel";
            this.upcomingNextPanel.Size = new System.Drawing.Size(545, 171);
            this.upcomingNextPanel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 519F));
            this.tableLayoutPanel1.Controls.Add(this.categoryColorPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.eventShowcasedPanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(545, 171);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // categoryColorPanel
            // 
            this.categoryColorPanel.BackColor = System.Drawing.Color.DarkRed;
            this.categoryColorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryColorPanel.Location = new System.Drawing.Point(3, 3);
            this.categoryColorPanel.Name = "categoryColorPanel";
            this.categoryColorPanel.Size = new System.Drawing.Size(20, 165);
            this.categoryColorPanel.TabIndex = 0;
            // 
            // eventShowcasedPanel
            // 
            this.eventShowcasedPanel.AutoSize = true;
            this.eventShowcasedPanel.Controls.Add(this.pictureBox1);
            this.eventShowcasedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventShowcasedPanel.Location = new System.Drawing.Point(29, 3);
            this.eventShowcasedPanel.Name = "eventShowcasedPanel";
            this.eventShowcasedPanel.Size = new System.Drawing.Size(513, 165);
            this.eventShowcasedPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, -183);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(520, 526);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // upNextLabel
            // 
            this.upNextLabel.AutoSize = true;
            this.upNextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upNextLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.upNextLabel.Location = new System.Drawing.Point(68, 28);
            this.upNextLabel.Name = "upNextLabel";
            this.upNextLabel.Size = new System.Drawing.Size(178, 29);
            this.upNextLabel.TabIndex = 0;
            this.upNextLabel.Text = "Upcoming Next";
            // 
            // PastVisitsTab
            // 
            this.PastVisitsTab.Location = new System.Drawing.Point(4, 22);
            this.PastVisitsTab.Margin = new System.Windows.Forms.Padding(2);
            this.PastVisitsTab.Name = "PastVisitsTab";
            this.PastVisitsTab.Padding = new System.Windows.Forms.Padding(2);
            this.PastVisitsTab.Size = new System.Drawing.Size(764, 740);
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
            this.InterestedUserTab.Size = new System.Drawing.Size(764, 740);
            this.InterestedUserTab.TabIndex = 2;
            this.InterestedUserTab.Text = "INTERESTED";
            this.InterestedUserTab.UseVisualStyleBackColor = true;
            // 
            // UserStatusTab
            // 
            this.UserStatusTab.Location = new System.Drawing.Point(4, 22);
            this.UserStatusTab.Margin = new System.Windows.Forms.Padding(2);
            this.UserStatusTab.Name = "UserStatusTab";
            this.UserStatusTab.Size = new System.Drawing.Size(764, 740);
            this.UserStatusTab.TabIndex = 3;
            this.UserStatusTab.Text = "USER STATUS";
            this.UserStatusTab.UseVisualStyleBackColor = true;
            // 
            // InvitesUserTab
            // 
            this.InvitesUserTab.Location = new System.Drawing.Point(4, 22);
            this.InvitesUserTab.Margin = new System.Windows.Forms.Padding(2);
            this.InvitesUserTab.Name = "InvitesUserTab";
            this.InvitesUserTab.Size = new System.Drawing.Size(764, 740);
            this.InvitesUserTab.TabIndex = 4;
            this.InvitesUserTab.Text = "INVITES";
            this.InvitesUserTab.UseVisualStyleBackColor = true;
            // 
            // UserEventsTab
            // 
            this.UserEventsTab.Location = new System.Drawing.Point(4, 22);
            this.UserEventsTab.Margin = new System.Windows.Forms.Padding(2);
            this.UserEventsTab.Name = "UserEventsTab";
            this.UserEventsTab.Size = new System.Drawing.Size(764, 740);
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
            this.panel1.Size = new System.Drawing.Size(772, 194);
            this.panel1.TabIndex = 13;
            // 
            // ovalPictureBox1
            // 
            this.ovalPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ovalPictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.ovalPictureBox1.Location = new System.Drawing.Point(645, 68);
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
            this.backgroundPictureBox.Size = new System.Drawing.Size(772, 778);
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
            this.Size = new System.Drawing.Size(819, 977);
            this.Load += new System.EventHandler(this.UserProfilePage_Load);
            this.tabControl1.ResumeLayout(false);
            this.eventsUserTab.ResumeLayout(false);
            this.eventsUserTab.PerformLayout();
            this.upcomingNextPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.eventShowcasedPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel upcomingNextPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label upNextLabel;
        private System.Windows.Forms.Panel eventShowcasedPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label eventsTheUserWillAttendLabel;
        private System.Windows.Forms.Label vanueLabel;
        private System.Windows.Forms.Label overAtLabel;
        private System.Windows.Forms.Label eventNameLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label dayLabel;
        private Common.Carousel eventsUserWillAttendCarousel;
        private System.Windows.Forms.Panel categoryColorPanel;
    }
}
