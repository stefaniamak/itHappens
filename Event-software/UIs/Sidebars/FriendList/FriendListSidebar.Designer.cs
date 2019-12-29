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
            this.friendListsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(39, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(55, 13);
            this.title.TabIndex = 0;
            this.title.Text = "Friend List";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // friendListsFlowLayoutPanel
            // 
            this.friendListsFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.friendListsFlowLayoutPanel.AutoSize = true;
            this.friendListsFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.friendListsFlowLayoutPanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.friendListsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.friendListsFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.friendListsFlowLayoutPanel.Name = "friendListsFlowLayoutPanel";
            this.friendListsFlowLayoutPanel.Size = new System.Drawing.Size(0, 0);
            this.friendListsFlowLayoutPanel.TabIndex = 0;
            this.friendListsFlowLayoutPanel.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.friendListsFlowLayoutPanel);
            this.panel1.Location = new System.Drawing.Point(3, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 182);
            this.panel1.TabIndex = 1;
            // 
            // FriendListSidebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.Controls.Add(this.title);
            this.Controls.Add(this.panel1);
            this.Name = "FriendListSidebar";
            this.Size = new System.Drawing.Size(140, 219);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.FlowLayoutPanel friendListsFlowLayoutPanel;
        private System.Windows.Forms.Panel panel1;
    }
}
