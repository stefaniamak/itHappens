namespace itHappens.UIs.andrea
{
    partial class VenueProfilePage
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
            System.Windows.Forms.TabPage galleryTab;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VenueProfilePage));
            this.wholePanel = new System.Windows.Forms.Panel();
            this.venueProfileTabControl = new System.Windows.Forms.TabControl();
            this.mainTab = new System.Windows.Forms.TabPage();
            this.upcomintEventLabel = new System.Windows.Forms.Label();
            this.eventNameLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.upcomingNextPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.categoryColorPanel = new System.Windows.Forms.Panel();
            this.eventShowcasedPanel = new System.Windows.Forms.Panel();
            this.miniEventBackgroundPictureBox = new System.Windows.Forms.PictureBox();
            this.UpcomingVenueEventsLabel = new System.Windows.Forms.Label();
            this.eventsUserWillAttendCarousel = new itHappens.UIs.Common.Carousel();
            this.eventTab = new System.Windows.Forms.TabPage();
            this.detailsTab = new System.Windows.Forms.TabPage();
            this.friendsVisitedPanel = new System.Windows.Forms.Panel();
            this.friendsPVisitedLabel = new System.Windows.Forms.Label();
            this.friendsVisitedFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.venueNameLabel = new System.Windows.Forms.Label();
            this.venueProfilePictureOvalPictureBox = new itHappens.UIs.Common.OvalPictureBox();
            this.backgroundPictureBox = new System.Windows.Forms.PictureBox();
            galleryTab = new System.Windows.Forms.TabPage();
            this.wholePanel.SuspendLayout();
            this.venueProfileTabControl.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.upcomingNextPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.eventShowcasedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.miniEventBackgroundPictureBox)).BeginInit();
            this.friendsVisitedPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.venueProfilePictureOvalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // galleryTab
            // 
            galleryTab.AutoScroll = true;
            galleryTab.Location = new System.Drawing.Point(4, 25);
            galleryTab.Margin = new System.Windows.Forms.Padding(2);
            galleryTab.Name = "galleryTab";
            galleryTab.Size = new System.Drawing.Size(867, 760);
            galleryTab.TabIndex = 3;
            galleryTab.Text = "GALLERY";
            galleryTab.UseVisualStyleBackColor = true;
            // 
            // wholePanel
            // 
            this.wholePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wholePanel.Controls.Add(this.venueProfileTabControl);
            this.wholePanel.Controls.Add(this.friendsVisitedPanel);
            this.wholePanel.Controls.Add(this.topPanel);
            this.wholePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wholePanel.Location = new System.Drawing.Point(0, 0);
            this.wholePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wholePanel.Name = "wholePanel";
            this.wholePanel.Size = new System.Drawing.Size(1122, 1120);
            this.wholePanel.TabIndex = 1;
            // 
            // venueProfileTabControl
            // 
            this.venueProfileTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.venueProfileTabControl.Controls.Add(this.mainTab);
            this.venueProfileTabControl.Controls.Add(this.eventTab);
            this.venueProfileTabControl.Controls.Add(this.detailsTab);
            this.venueProfileTabControl.Controls.Add(galleryTab);
            this.venueProfileTabControl.Location = new System.Drawing.Point(9, 324);
            this.venueProfileTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.venueProfileTabControl.Name = "venueProfileTabControl";
            this.venueProfileTabControl.Padding = new System.Drawing.Point(26, 3);
            this.venueProfileTabControl.SelectedIndex = 0;
            this.venueProfileTabControl.Size = new System.Drawing.Size(875, 789);
            this.venueProfileTabControl.TabIndex = 13;
            // 
            // mainTab
            // 
            this.mainTab.AutoScroll = true;
            this.mainTab.Controls.Add(this.upcomintEventLabel);
            this.mainTab.Controls.Add(this.eventNameLabel);
            this.mainTab.Controls.Add(this.monthLabel);
            this.mainTab.Controls.Add(this.dayLabel);
            this.mainTab.Controls.Add(this.upcomingNextPanel);
            this.mainTab.Controls.Add(this.UpcomingVenueEventsLabel);
            this.mainTab.Controls.Add(this.eventsUserWillAttendCarousel);
            this.mainTab.Location = new System.Drawing.Point(4, 25);
            this.mainTab.Margin = new System.Windows.Forms.Padding(2);
            this.mainTab.Name = "mainTab";
            this.mainTab.Padding = new System.Windows.Forms.Padding(2);
            this.mainTab.Size = new System.Drawing.Size(867, 760);
            this.mainTab.TabIndex = 0;
            this.mainTab.Text = "MAIN";
            this.mainTab.UseVisualStyleBackColor = true;
            // 
            // upcomintEventLabel
            // 
            this.upcomintEventLabel.AutoSize = true;
            this.upcomintEventLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upcomintEventLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.upcomintEventLabel.Location = new System.Drawing.Point(53, 30);
            this.upcomintEventLabel.Name = "upcomintEventLabel";
            this.upcomintEventLabel.Size = new System.Drawing.Size(178, 29);
            this.upcomintEventLabel.TabIndex = 22;
            this.upcomintEventLabel.Text = "Upcoming Next";
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.eventNameLabel.AutoSize = true;
            this.eventNameLabel.BackColor = System.Drawing.Color.Black;
            this.eventNameLabel.Font = new System.Drawing.Font("Century Gothic", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventNameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.eventNameLabel.Location = new System.Drawing.Point(78, 88);
            this.eventNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(212, 40);
            this.eventNameLabel.TabIndex = 28;
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
            this.monthLabel.Location = new System.Drawing.Point(489, 136);
            this.monthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(77, 33);
            this.monthLabel.TabIndex = 27;
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
            this.dayLabel.Location = new System.Drawing.Point(489, 172);
            this.dayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(77, 57);
            this.dayLabel.TabIndex = 26;
            this.dayLabel.Text = "25";
            // 
            // upcomingNextPanel
            // 
            this.upcomingNextPanel.Controls.Add(this.tableLayoutPanel1);
            this.upcomingNextPanel.Location = new System.Drawing.Point(35, 71);
            this.upcomingNextPanel.Name = "upcomingNextPanel";
            this.upcomingNextPanel.Size = new System.Drawing.Size(545, 171);
            this.upcomingNextPanel.TabIndex = 23;
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
            this.eventShowcasedPanel.Controls.Add(this.miniEventBackgroundPictureBox);
            this.eventShowcasedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventShowcasedPanel.Location = new System.Drawing.Point(29, 3);
            this.eventShowcasedPanel.Name = "eventShowcasedPanel";
            this.eventShowcasedPanel.Size = new System.Drawing.Size(513, 165);
            this.eventShowcasedPanel.TabIndex = 1;
            // 
            // miniEventBackgroundPictureBox
            // 
            this.miniEventBackgroundPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.miniEventBackgroundPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.miniEventBackgroundPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("miniEventBackgroundPictureBox.BackgroundImage")));
            this.miniEventBackgroundPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.miniEventBackgroundPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("miniEventBackgroundPictureBox.Image")));
            this.miniEventBackgroundPictureBox.Location = new System.Drawing.Point(-6, -183);
            this.miniEventBackgroundPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.miniEventBackgroundPictureBox.Name = "miniEventBackgroundPictureBox";
            this.miniEventBackgroundPictureBox.Size = new System.Drawing.Size(520, 526);
            this.miniEventBackgroundPictureBox.TabIndex = 4;
            this.miniEventBackgroundPictureBox.TabStop = false;
            // 
            // UpcomingVenueEventsLabel
            // 
            this.UpcomingVenueEventsLabel.AutoSize = true;
            this.UpcomingVenueEventsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpcomingVenueEventsLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.UpcomingVenueEventsLabel.Location = new System.Drawing.Point(55, 290);
            this.UpcomingVenueEventsLabel.Name = "UpcomingVenueEventsLabel";
            this.UpcomingVenueEventsLabel.Size = new System.Drawing.Size(290, 29);
            this.UpcomingVenueEventsLabel.TabIndex = 24;
            this.UpcomingVenueEventsLabel.Text = "Upcoming Venue\'s events";
            // 
            // eventsUserWillAttendCarousel
            // 
            this.eventsUserWillAttendCarousel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventsUserWillAttendCarousel.AutoScroll = true;
            this.eventsUserWillAttendCarousel.BackColor = System.Drawing.SystemColors.Control;
            this.eventsUserWillAttendCarousel.Location = new System.Drawing.Point(35, 337);
            this.eventsUserWillAttendCarousel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eventsUserWillAttendCarousel.Name = "eventsUserWillAttendCarousel";
            this.eventsUserWillAttendCarousel.Padding = new System.Windows.Forms.Padding(2);
            this.eventsUserWillAttendCarousel.Size = new System.Drawing.Size(801, 343);
            this.eventsUserWillAttendCarousel.TabIndex = 25;
            // 
            // eventTab
            // 
            this.eventTab.AutoScroll = true;
            this.eventTab.Location = new System.Drawing.Point(4, 25);
            this.eventTab.Margin = new System.Windows.Forms.Padding(2);
            this.eventTab.Name = "eventTab";
            this.eventTab.Padding = new System.Windows.Forms.Padding(2);
            this.eventTab.Size = new System.Drawing.Size(867, 760);
            this.eventTab.TabIndex = 1;
            this.eventTab.Text = "EVENTS";
            this.eventTab.UseVisualStyleBackColor = true;
            // 
            // detailsTab
            // 
            this.detailsTab.AutoScroll = true;
            this.detailsTab.Location = new System.Drawing.Point(4, 25);
            this.detailsTab.Margin = new System.Windows.Forms.Padding(2);
            this.detailsTab.Name = "detailsTab";
            this.detailsTab.Size = new System.Drawing.Size(867, 760);
            this.detailsTab.TabIndex = 2;
            this.detailsTab.Text = "DETAILS";
            this.detailsTab.UseVisualStyleBackColor = true;
            // 
            // friendsVisitedPanel
            // 
            this.friendsVisitedPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.friendsVisitedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.friendsVisitedPanel.Controls.Add(this.friendsPVisitedLabel);
            this.friendsVisitedPanel.Controls.Add(this.friendsVisitedFlowLayoutPanel);
            this.friendsVisitedPanel.Location = new System.Drawing.Point(906, 351);
            this.friendsVisitedPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.friendsVisitedPanel.Name = "friendsVisitedPanel";
            this.friendsVisitedPanel.Size = new System.Drawing.Size(199, 767);
            this.friendsVisitedPanel.TabIndex = 17;
            // 
            // friendsPVisitedLabel
            // 
            this.friendsPVisitedLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.friendsPVisitedLabel.AutoSize = true;
            this.friendsPVisitedLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendsPVisitedLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.friendsPVisitedLabel.Location = new System.Drawing.Point(6, 10);
            this.friendsPVisitedLabel.Name = "friendsPVisitedLabel";
            this.friendsPVisitedLabel.Size = new System.Drawing.Size(190, 20);
            this.friendsPVisitedLabel.TabIndex = 0;
            this.friendsPVisitedLabel.Text = "Friends who have visited";
            // 
            // friendsVisitedFlowLayoutPanel
            // 
            this.friendsVisitedFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.friendsVisitedFlowLayoutPanel.AutoSize = true;
            this.friendsVisitedFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.friendsVisitedFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.friendsVisitedFlowLayoutPanel.Location = new System.Drawing.Point(10, 57);
            this.friendsVisitedFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.friendsVisitedFlowLayoutPanel.Name = "friendsVisitedFlowLayoutPanel";
            this.friendsVisitedFlowLayoutPanel.Size = new System.Drawing.Size(0, 0);
            this.friendsVisitedFlowLayoutPanel.TabIndex = 1;
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.Controls.Add(this.venueNameLabel);
            this.topPanel.Controls.Add(this.venueProfilePictureOvalPictureBox);
            this.topPanel.Controls.Add(this.backgroundPictureBox);
            this.topPanel.Location = new System.Drawing.Point(14, 7);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1098, 310);
            this.topPanel.TabIndex = 16;
            // 
            // venueNameLabel
            // 
            this.venueNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.venueNameLabel.AutoSize = true;
            this.venueNameLabel.BackColor = System.Drawing.Color.Black;
            this.venueNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venueNameLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.venueNameLabel.Location = new System.Drawing.Point(22, 246);
            this.venueNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.venueNameLabel.Name = "venueNameLabel";
            this.venueNameLabel.Size = new System.Drawing.Size(216, 39);
            this.venueNameLabel.TabIndex = 14;
            this.venueNameLabel.Text = "Venue Name";
            // 
            // venueProfilePictureOvalPictureBox
            // 
            this.venueProfilePictureOvalPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.venueProfilePictureOvalPictureBox.BackColor = System.Drawing.Color.DarkGray;
            this.venueProfilePictureOvalPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("venueProfilePictureOvalPictureBox.BackgroundImage")));
            this.venueProfilePictureOvalPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.venueProfilePictureOvalPictureBox.Location = new System.Drawing.Point(959, 55);
            this.venueProfilePictureOvalPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.venueProfilePictureOvalPictureBox.Name = "venueProfilePictureOvalPictureBox";
            this.venueProfilePictureOvalPictureBox.Size = new System.Drawing.Size(101, 103);
            this.venueProfilePictureOvalPictureBox.TabIndex = 15;
            this.venueProfilePictureOvalPictureBox.TabStop = false;
            // 
            // backgroundPictureBox
            // 
            this.backgroundPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backgroundPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backgroundPictureBox.BackgroundImage")));
            this.backgroundPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backgroundPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("backgroundPictureBox.Image")));
            this.backgroundPictureBox.Location = new System.Drawing.Point(2, -225);
            this.backgroundPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.backgroundPictureBox.Name = "backgroundPictureBox";
            this.backgroundPictureBox.Size = new System.Drawing.Size(1098, 811);
            this.backgroundPictureBox.TabIndex = 4;
            this.backgroundPictureBox.TabStop = false;
            // 
            // VenueProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.wholePanel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VenueProfilePage";
            this.Size = new System.Drawing.Size(1122, 1120);
            this.Load += new System.EventHandler(this.VenueProfilePage_Load);
            this.wholePanel.ResumeLayout(false);
            this.venueProfileTabControl.ResumeLayout(false);
            this.mainTab.ResumeLayout(false);
            this.mainTab.PerformLayout();
            this.upcomingNextPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.eventShowcasedPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.miniEventBackgroundPictureBox)).EndInit();
            this.friendsVisitedPanel.ResumeLayout(false);
            this.friendsVisitedPanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.venueProfilePictureOvalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel wholePanel;
        private System.Windows.Forms.TabControl venueProfileTabControl;
        private System.Windows.Forms.TabPage mainTab;
        private System.Windows.Forms.TabPage eventTab;
        private System.Windows.Forms.TabPage detailsTab;
        private System.Windows.Forms.Panel friendsVisitedPanel;
        private System.Windows.Forms.Label friendsPVisitedLabel;
        private System.Windows.Forms.FlowLayoutPanel friendsVisitedFlowLayoutPanel;
        private Common.OvalPictureBox venueProfilePictureOvalPictureBox;
        private System.Windows.Forms.Label venueNameLabel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox backgroundPictureBox;
        private Common.Carousel eventsUserWillAttendCarousel;
        private System.Windows.Forms.Label UpcomingVenueEventsLabel;
        private System.Windows.Forms.Panel upcomingNextPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel categoryColorPanel;
        private System.Windows.Forms.Panel eventShowcasedPanel;
        private System.Windows.Forms.PictureBox miniEventBackgroundPictureBox;
        private System.Windows.Forms.Label upcomintEventLabel;
        private System.Windows.Forms.Label eventNameLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label dayLabel;
    }
}
