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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainTab = new System.Windows.Forms.TabPage();
            this.eventTab = new System.Windows.Forms.TabPage();
            this.detailsTab = new System.Windows.Forms.TabPage();
            this.friendsVisitedPanel = new System.Windows.Forms.Panel();
            this.friendsPVisitedLabel = new System.Windows.Forms.Label();
            this.friendsVisitedFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ovalPictureBox1 = new itHappens.UIs.Common.OvalPictureBox();
            this.venueNameLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.venuePictureBox = new System.Windows.Forms.PictureBox();
            galleryTab = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.friendsVisitedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.venuePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // galleryTab
            // 
            galleryTab.AutoScroll = true;
            galleryTab.Location = new System.Drawing.Point(4, 22);
            galleryTab.Margin = new System.Windows.Forms.Padding(2);
            galleryTab.Name = "galleryTab";
            galleryTab.Size = new System.Drawing.Size(727, 348);
            galleryTab.TabIndex = 3;
            galleryTab.Text = "GALLERY";
            galleryTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.friendsVisitedPanel);
            this.panel1.Controls.Add(this.ovalPictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 705);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.mainTab);
            this.tabControl1.Controls.Add(this.eventTab);
            this.tabControl1.Controls.Add(this.detailsTab);
            this.tabControl1.Controls.Add(galleryTab);
            this.tabControl1.Location = new System.Drawing.Point(9, 324);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(26, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(735, 374);
            this.tabControl1.TabIndex = 13;
            // 
            // mainTab
            // 
            this.mainTab.AutoScroll = true;
            this.mainTab.Location = new System.Drawing.Point(4, 25);
            this.mainTab.Margin = new System.Windows.Forms.Padding(2);
            this.mainTab.Name = "mainTab";
            this.mainTab.Padding = new System.Windows.Forms.Padding(2);
            this.mainTab.Size = new System.Drawing.Size(727, 345);
            this.mainTab.TabIndex = 0;
            this.mainTab.Text = "MAIN";
            this.mainTab.UseVisualStyleBackColor = true;
            // 
            // eventTab
            // 
            this.eventTab.AutoScroll = true;
            this.eventTab.Location = new System.Drawing.Point(4, 22);
            this.eventTab.Margin = new System.Windows.Forms.Padding(2);
            this.eventTab.Name = "eventTab";
            this.eventTab.Padding = new System.Windows.Forms.Padding(2);
            this.eventTab.Size = new System.Drawing.Size(727, 348);
            this.eventTab.TabIndex = 1;
            this.eventTab.Text = "EVENTS";
            this.eventTab.UseVisualStyleBackColor = true;
            // 
            // detailsTab
            // 
            this.detailsTab.AutoScroll = true;
            this.detailsTab.Location = new System.Drawing.Point(4, 22);
            this.detailsTab.Margin = new System.Windows.Forms.Padding(2);
            this.detailsTab.Name = "detailsTab";
            this.detailsTab.Size = new System.Drawing.Size(727, 348);
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
            this.friendsVisitedPanel.Location = new System.Drawing.Point(766, 351);
            this.friendsVisitedPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.friendsVisitedPanel.Name = "friendsVisitedPanel";
            this.friendsVisitedPanel.Size = new System.Drawing.Size(199, 352);
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
            this.friendsVisitedFlowLayoutPanel.Location = new System.Drawing.Point(0, 55);
            this.friendsVisitedFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.friendsVisitedFlowLayoutPanel.Name = "friendsVisitedFlowLayoutPanel";
            this.friendsVisitedFlowLayoutPanel.Size = new System.Drawing.Size(0, 0);
            this.friendsVisitedFlowLayoutPanel.TabIndex = 1;
            // 
            // ovalPictureBox1
            // 
            this.ovalPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ovalPictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.ovalPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ovalPictureBox1.BackgroundImage")));
            this.ovalPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ovalPictureBox1.Location = new System.Drawing.Point(819, 55);
            this.ovalPictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ovalPictureBox1.Name = "ovalPictureBox1";
            this.ovalPictureBox1.Size = new System.Drawing.Size(101, 103);
            this.ovalPictureBox1.TabIndex = 15;
            this.ovalPictureBox1.TabStop = false;
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.venueNameLabel);
            this.panel2.Controls.Add(this.venuePictureBox);
            this.panel2.Location = new System.Drawing.Point(14, 7);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(958, 310);
            this.panel2.TabIndex = 16;
            // 
            // venuePictureBox
            // 
            this.venuePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.venuePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("venuePictureBox.BackgroundImage")));
            this.venuePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.venuePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("venuePictureBox.Image")));
            this.venuePictureBox.Location = new System.Drawing.Point(2, -225);
            this.venuePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.venuePictureBox.Name = "venuePictureBox";
            this.venuePictureBox.Size = new System.Drawing.Size(958, 811);
            this.venuePictureBox.TabIndex = 4;
            this.venuePictureBox.TabStop = false;
            // 
            // VenueProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VenueProfilePage";
            this.Size = new System.Drawing.Size(982, 705);
            this.Load += new System.EventHandler(this.VenueProfilePage_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.friendsVisitedPanel.ResumeLayout(false);
            this.friendsVisitedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.venuePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mainTab;
        private System.Windows.Forms.TabPage eventTab;
        private System.Windows.Forms.TabPage detailsTab;
        private System.Windows.Forms.Panel friendsVisitedPanel;
        private System.Windows.Forms.Label friendsPVisitedLabel;
        private System.Windows.Forms.FlowLayoutPanel friendsVisitedFlowLayoutPanel;
        private Common.OvalPictureBox ovalPictureBox1;
        private System.Windows.Forms.Label venueNameLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox venuePictureBox;
    }
}
