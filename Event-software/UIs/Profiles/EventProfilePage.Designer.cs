namespace itHappens.UIs.andrea
{
    partial class EventProfilePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventProfilePage));
            this.panel3 = new System.Windows.Forms.Panel();
            this.topBarPanel = new System.Windows.Forms.Panel();
            this.eventNameLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.backgroundPictureBox = new System.Windows.Forms.PictureBox();
            this.menuTabControl = new System.Windows.Forms.TabControl();
            this.eventsTabPage = new System.Windows.Forms.TabPage();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.organizerTextBox = new System.Windows.Forms.TextBox();
            this.dayTimeTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.galleryTabPage = new System.Windows.Forms.TabPage();
            this.visitorsabPage = new System.Windows.Forms.TabPage();
            this.detailsTabPage = new System.Windows.Forms.TabPage();
            this.friendsAttendingPanel = new System.Windows.Forms.Panel();
            this.friendsAttendingLabel = new System.Windows.Forms.Label();
            this.friendsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.goingButton = new System.Windows.Forms.Button();
            this.interestedButton = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.topBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).BeginInit();
            this.menuTabControl.SuspendLayout();
            this.eventsTabPage.SuspendLayout();
            this.friendsAttendingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.topBarPanel);
            this.panel3.Controls.Add(this.menuTabControl);
            this.panel3.Controls.Add(this.friendsAttendingPanel);
            this.panel3.Controls.Add(this.goingButton);
            this.panel3.Controls.Add(this.interestedButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(837, 577);
            this.panel3.TabIndex = 1;
            // 
            // topBarPanel
            // 
            this.topBarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topBarPanel.Controls.Add(this.eventNameLabel);
            this.topBarPanel.Controls.Add(this.dayLabel);
            this.topBarPanel.Controls.Add(this.monthLabel);
            this.topBarPanel.Controls.Add(this.backgroundPictureBox);
            this.topBarPanel.Location = new System.Drawing.Point(15, 8);
            this.topBarPanel.Name = "topBarPanel";
            this.topBarPanel.Size = new System.Drawing.Size(808, 209);
            this.topBarPanel.TabIndex = 17;
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.eventNameLabel.AutoSize = true;
            this.eventNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventNameLabel.Location = new System.Drawing.Point(22, 152);
            this.eventNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(144, 29);
            this.eventNameLabel.TabIndex = 8;
            this.eventNameLabel.Text = "Event Name";
            // 
            // dayLabel
            // 
            this.dayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dayLabel.AutoSize = true;
            this.dayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLabel.Location = new System.Drawing.Point(733, 11);
            this.dayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(55, 39);
            this.dayLabel.TabIndex = 4;
            this.dayLabel.Text = "25";
            // 
            // monthLabel
            // 
            this.monthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthLabel.AutoSize = true;
            this.monthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLabel.Location = new System.Drawing.Point(744, 50);
            this.monthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(44, 24);
            this.monthLabel.TabIndex = 5;
            this.monthLabel.Text = "Nov";
            // 
            // backgroundPictureBox
            // 
            this.backgroundPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backgroundPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backgroundPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backgroundPictureBox.BackgroundImage")));
            this.backgroundPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backgroundPictureBox.Location = new System.Drawing.Point(0, -209);
            this.backgroundPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.backgroundPictureBox.Name = "backgroundPictureBox";
            this.backgroundPictureBox.Size = new System.Drawing.Size(808, 613);
            this.backgroundPictureBox.TabIndex = 3;
            this.backgroundPictureBox.TabStop = false;
            // 
            // menuTabControl
            // 
            this.menuTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuTabControl.Controls.Add(this.eventsTabPage);
            this.menuTabControl.Controls.Add(this.galleryTabPage);
            this.menuTabControl.Controls.Add(this.visitorsabPage);
            this.menuTabControl.Controls.Add(this.detailsTabPage);
            this.menuTabControl.Location = new System.Drawing.Point(15, 222);
            this.menuTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.menuTabControl.Name = "menuTabControl";
            this.menuTabControl.Padding = new System.Drawing.Point(26, 3);
            this.menuTabControl.SelectedIndex = 0;
            this.menuTabControl.Size = new System.Drawing.Size(618, 355);
            this.menuTabControl.TabIndex = 16;
            // 
            // eventsTabPage
            // 
            this.eventsTabPage.AutoScroll = true;
            this.eventsTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.eventsTabPage.Controls.Add(this.detailsLabel);
            this.eventsTabPage.Controls.Add(this.locationTextBox);
            this.eventsTabPage.Controls.Add(this.organizerTextBox);
            this.eventsTabPage.Controls.Add(this.descriptionTextBox);
            this.eventsTabPage.Controls.Add(this.dayTimeTextBox);
            this.eventsTabPage.Controls.Add(this.descriptionLabel);
            this.eventsTabPage.Location = new System.Drawing.Point(4, 22);
            this.eventsTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.eventsTabPage.Name = "eventsTabPage";
            this.eventsTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.eventsTabPage.Size = new System.Drawing.Size(610, 329);
            this.eventsTabPage.TabIndex = 0;
            this.eventsTabPage.Text = "EVENTS";
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Location = new System.Drawing.Point(32, 16);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(39, 13);
            this.detailsLabel.TabIndex = 0;
            this.detailsLabel.Text = "Details";
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(23, 42);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(142, 20);
            this.locationTextBox.TabIndex = 1;
            this.locationTextBox.Text = "Location";
            // 
            // organizerTextBox
            // 
            this.organizerTextBox.Location = new System.Drawing.Point(23, 68);
            this.organizerTextBox.Name = "organizerTextBox";
            this.organizerTextBox.Size = new System.Drawing.Size(142, 20);
            this.organizerTextBox.TabIndex = 2;
            this.organizerTextBox.Text = "Organizer";
            // 
            // dayTimeTextBox
            // 
            this.dayTimeTextBox.Location = new System.Drawing.Point(23, 94);
            this.dayTimeTextBox.Name = "dayTimeTextBox";
            this.dayTimeTextBox.Size = new System.Drawing.Size(142, 20);
            this.dayTimeTextBox.TabIndex = 3;
            this.dayTimeTextBox.Text = "Date | Time";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(32, 134);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Description";
            this.descriptionLabel.Click += new System.EventHandler(this.descriptionLabel_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.Location = new System.Drawing.Point(23, 160);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(572, 153);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // galleryTabPage
            // 
            this.galleryTabPage.AutoScroll = true;
            this.galleryTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.galleryTabPage.Location = new System.Drawing.Point(4, 22);
            this.galleryTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.galleryTabPage.Name = "galleryTabPage";
            this.galleryTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.galleryTabPage.Size = new System.Drawing.Size(610, 320);
            this.galleryTabPage.TabIndex = 3;
            this.galleryTabPage.Text = "GALLERY";
            // 
            // visitorsabPage
            // 
            this.visitorsabPage.AutoScroll = true;
            this.visitorsabPage.BackColor = System.Drawing.SystemColors.Control;
            this.visitorsabPage.Location = new System.Drawing.Point(4, 22);
            this.visitorsabPage.Margin = new System.Windows.Forms.Padding(2);
            this.visitorsabPage.Name = "visitorsabPage";
            this.visitorsabPage.Padding = new System.Windows.Forms.Padding(2);
            this.visitorsabPage.Size = new System.Drawing.Size(610, 320);
            this.visitorsabPage.TabIndex = 2;
            this.visitorsabPage.Text = "VISITORS ALSO LIKE";
            // 
            // detailsTabPage
            // 
            this.detailsTabPage.AutoScroll = true;
            this.detailsTabPage.Location = new System.Drawing.Point(4, 22);
            this.detailsTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.detailsTabPage.Name = "detailsTabPage";
            this.detailsTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.detailsTabPage.Size = new System.Drawing.Size(610, 320);
            this.detailsTabPage.TabIndex = 1;
            this.detailsTabPage.Text = "DETAILS";
            this.detailsTabPage.UseVisualStyleBackColor = true;
            // 
            // friendsAttendingPanel
            // 
            this.friendsAttendingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.friendsAttendingPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.friendsAttendingPanel.Controls.Add(this.friendsAttendingLabel);
            this.friendsAttendingPanel.Controls.Add(this.friendsFlowPanel);
            this.friendsAttendingPanel.Location = new System.Drawing.Point(657, 286);
            this.friendsAttendingPanel.Margin = new System.Windows.Forms.Padding(2);
            this.friendsAttendingPanel.Name = "friendsAttendingPanel";
            this.friendsAttendingPanel.Size = new System.Drawing.Size(166, 291);
            this.friendsAttendingPanel.TabIndex = 15;
            // 
            // friendsAttendingLabel
            // 
            this.friendsAttendingLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.friendsAttendingLabel.AutoSize = true;
            this.friendsAttendingLabel.Location = new System.Drawing.Point(37, 10);
            this.friendsAttendingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.friendsAttendingLabel.Name = "friendsAttendingLabel";
            this.friendsAttendingLabel.Size = new System.Drawing.Size(89, 13);
            this.friendsAttendingLabel.TabIndex = 0;
            this.friendsAttendingLabel.Text = "Friends Attending";
            // 
            // friendsFlowPanel
            // 
            this.friendsFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.friendsFlowPanel.AutoSize = true;
            this.friendsFlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.friendsFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.friendsFlowPanel.Location = new System.Drawing.Point(3, 36);
            this.friendsFlowPanel.Name = "friendsFlowPanel";
            this.friendsFlowPanel.Size = new System.Drawing.Size(0, 0);
            this.friendsFlowPanel.TabIndex = 1;
            // 
            // goingButton
            // 
            this.goingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goingButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.goingButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.goingButton.Location = new System.Drawing.Point(743, 244);
            this.goingButton.Margin = new System.Windows.Forms.Padding(2);
            this.goingButton.Name = "goingButton";
            this.goingButton.Size = new System.Drawing.Size(80, 23);
            this.goingButton.TabIndex = 14;
            this.goingButton.Text = "Going";
            this.goingButton.UseVisualStyleBackColor = false;
            // 
            // interestedButton
            // 
            this.interestedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.interestedButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.interestedButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.interestedButton.Location = new System.Drawing.Point(657, 244);
            this.interestedButton.Margin = new System.Windows.Forms.Padding(2);
            this.interestedButton.Name = "interestedButton";
            this.interestedButton.Size = new System.Drawing.Size(80, 24);
            this.interestedButton.TabIndex = 13;
            this.interestedButton.Text = "Interested";
            this.interestedButton.UseVisualStyleBackColor = false;
            // 
            // EventProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panel3);
            this.Name = "EventProfilePage";
            this.Size = new System.Drawing.Size(837, 577);
            this.Load += new System.EventHandler(this.EventProfilePage_Load);
            this.panel3.ResumeLayout(false);
            this.topBarPanel.ResumeLayout(false);
            this.topBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).EndInit();
            this.menuTabControl.ResumeLayout(false);
            this.eventsTabPage.ResumeLayout(false);
            this.eventsTabPage.PerformLayout();
            this.friendsAttendingPanel.ResumeLayout(false);
            this.friendsAttendingPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel topBarPanel;
        private System.Windows.Forms.Label eventNameLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.PictureBox backgroundPictureBox;
        private System.Windows.Forms.TabControl menuTabControl;
        private System.Windows.Forms.TabPage eventsTabPage;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox organizerTextBox;
        private System.Windows.Forms.TextBox dayTimeTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TabPage galleryTabPage;
        private System.Windows.Forms.TabPage visitorsabPage;
        private System.Windows.Forms.TabPage detailsTabPage;
        private System.Windows.Forms.Panel friendsAttendingPanel;
        private System.Windows.Forms.Label friendsAttendingLabel;
        private System.Windows.Forms.FlowLayoutPanel friendsFlowPanel;
        private System.Windows.Forms.Button goingButton;
        private System.Windows.Forms.Button interestedButton;
    }
}
