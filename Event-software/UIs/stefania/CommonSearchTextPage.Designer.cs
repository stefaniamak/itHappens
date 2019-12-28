namespace itHappens.UIs.stefania
{
    partial class CommonSearchTextPage
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
            this.usersLocationLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            hostPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // usersLocationLabel
            // 
            this.usersLocationLabel.AutoSize = true;
            this.usersLocationLabel.Location = new System.Drawing.Point(15, 22);
            this.usersLocationLabel.Name = "usersLocationLabel";
            this.usersLocationLabel.Size = new System.Drawing.Size(80, 13);
            this.usersLocationLabel.TabIndex = 4;
            this.usersLocationLabel.Text = "User\'s Location";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(16, 36);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(199, 20);
            this.searchTextBox.TabIndex = 5;
            // 
            // hostPanel
            // 
            hostPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            hostPanel.AutoScroll = true;
            hostPanel.BackColor = System.Drawing.Color.Indigo;
            hostPanel.Location = new System.Drawing.Point(0, 77);
            hostPanel.Name = "hostPanel";
            hostPanel.Size = new System.Drawing.Size(468, 340);
            hostPanel.TabIndex = 6;
            hostPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.hostPanel_Paint);
            // 
            // CommonSearchTextPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(hostPanel);
            this.Controls.Add(this.usersLocationLabel);
            this.Controls.Add(this.searchTextBox);
            this.Name = "CommonSearchTextPage";
            this.Size = new System.Drawing.Size(468, 417);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usersLocationLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        public static System.Windows.Forms.Panel hostPanel;
    }
}
