namespace itHappens.UIs.Sidebars
{
    partial class FriendListSidebar
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
            this.title = new System.Windows.Forms.Label();
            this.friendListsPanel = new System.Windows.Forms.Panel();
            this.friendListsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.friendListsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(58, 10);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(55, 13);
            this.title.TabIndex = 0;
            this.title.Text = "Friend List";
            // 
            // friendListsPanel
            // 
            this.friendListsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.friendListsPanel.AutoScroll = true;
            this.friendListsPanel.Controls.Add(this.friendListsFlowLayoutPanel);
            this.friendListsPanel.Location = new System.Drawing.Point(0, 26);
            this.friendListsPanel.Name = "friendListsPanel";
            this.friendListsPanel.Size = new System.Drawing.Size(174, 181);
            this.friendListsPanel.TabIndex = 2;
            // 
            // friendListsFlowLayoutPanel
            // 
            this.friendListsFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.friendListsFlowLayoutPanel.AutoSize = true;
            this.friendListsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.friendListsFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.friendListsFlowLayoutPanel.Name = "friendListsFlowLayoutPanel";
            this.friendListsFlowLayoutPanel.Size = new System.Drawing.Size(24, 0);
            this.friendListsFlowLayoutPanel.TabIndex = 0;
            // 
            // FriendListSidebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.Controls.Add(this.friendListsPanel);
            this.Controls.Add(this.title);
            this.Name = "FriendListSidebar";
            this.Size = new System.Drawing.Size(174, 207);
            this.friendListsPanel.ResumeLayout(false);
            this.friendListsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel friendListsPanel;
        private System.Windows.Forms.FlowLayoutPanel friendListsFlowLayoutPanel;
    }
}
