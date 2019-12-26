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
            System.Windows.Forms.TabPage galleryTab;
            this.label1 = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.userProfilePanelv = new System.Windows.Forms.Panel();
            this.venuePictureBox = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainTab = new System.Windows.Forms.TabPage();
            this.eventTab = new System.Windows.Forms.TabPage();
            this.detailsTab = new System.Windows.Forms.TabPage();
            galleryTab = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.venuePictureBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Event Profile";
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(4);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(282, 1042);
            this.menuPanel.TabIndex = 2;
            // 
            // userProfilePanelv
            // 
            this.userProfilePanelv.BackColor = System.Drawing.Color.Salmon;
            this.userProfilePanelv.Dock = System.Windows.Forms.DockStyle.Right;
            this.userProfilePanelv.Location = new System.Drawing.Point(1362, 0);
            this.userProfilePanelv.Margin = new System.Windows.Forms.Padding(4);
            this.userProfilePanelv.Name = "userProfilePanelv";
            this.userProfilePanelv.Size = new System.Drawing.Size(264, 1042);
            this.userProfilePanelv.TabIndex = 3;
            // 
            // venuePictureBox
            // 
            this.venuePictureBox.Location = new System.Drawing.Point(304, 13);
            this.venuePictureBox.Name = "venuePictureBox";
            this.venuePictureBox.Size = new System.Drawing.Size(1030, 303);
            this.venuePictureBox.TabIndex = 4;
            this.venuePictureBox.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mainTab);
            this.tabControl1.Controls.Add(this.eventTab);
            this.tabControl1.Controls.Add(this.detailsTab);
            this.tabControl1.Controls.Add(galleryTab);
            this.tabControl1.Location = new System.Drawing.Point(304, 411);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(26, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1030, 574);
            this.tabControl1.TabIndex = 5;
            // 
            // mainTab
            // 
            this.mainTab.Location = new System.Drawing.Point(8, 39);
            this.mainTab.Name = "mainTab";
            this.mainTab.Padding = new System.Windows.Forms.Padding(3);
            this.mainTab.Size = new System.Drawing.Size(1014, 527);
            this.mainTab.TabIndex = 0;
            this.mainTab.Text = "MAIN";
            this.mainTab.UseVisualStyleBackColor = true;
            // 
            // eventTab
            // 
            this.eventTab.Location = new System.Drawing.Point(8, 39);
            this.eventTab.Name = "eventTab";
            this.eventTab.Padding = new System.Windows.Forms.Padding(3);
            this.eventTab.Size = new System.Drawing.Size(1014, 527);
            this.eventTab.TabIndex = 1;
            this.eventTab.Text = "EVENTS";
            this.eventTab.UseVisualStyleBackColor = true;
            // 
            // detailsTab
            // 
            this.detailsTab.Location = new System.Drawing.Point(8, 39);
            this.detailsTab.Name = "detailsTab";
            this.detailsTab.Size = new System.Drawing.Size(1014, 527);
            this.detailsTab.TabIndex = 2;
            this.detailsTab.Text = "DETAILS";
            this.detailsTab.UseVisualStyleBackColor = true;
            // 
            // galleryTab
            // 
            galleryTab.Location = new System.Drawing.Point(8, 39);
            galleryTab.Name = "galleryTab";
            galleryTab.Size = new System.Drawing.Size(1014, 527);
            galleryTab.TabIndex = 3;
            galleryTab.Text = "GALLERY";
            galleryTab.UseVisualStyleBackColor = true;
            // 
            // EventProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.venuePictureBox);
            this.Controls.Add(this.userProfilePanelv);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EventProfilePage";
            this.Size = new System.Drawing.Size(1626, 1042);
            this.Load += new System.EventHandler(this.EventProfilePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.venuePictureBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel userProfilePanelv;
        private System.Windows.Forms.PictureBox venuePictureBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mainTab;
        private System.Windows.Forms.TabPage eventTab;
        private System.Windows.Forms.TabPage detailsTab;
    }
}
