namespace itHappens.UIs.Sidebars.FriendList
{
    partial class FriendListMini
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FriendListMini));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ovalPictureBox1 = new itHappens.UIs.Common.OvalPictureBox();
            this.friendNameLabel = new System.Windows.Forms.Label();
            this.eventNameLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.ovalPictureBox1);
            this.panel1.Controls.Add(this.friendNameLabel);
            this.panel1.Controls.Add(this.eventNameLabel);
            this.panel1.Controls.Add(this.locationLabel);
            this.panel1.Controls.Add(this.timeLabel);
            this.panel1.Location = new System.Drawing.Point(5, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 58);
            this.panel1.TabIndex = 7;
            // 
            // ovalPictureBox1
            // 
            this.ovalPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ovalPictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.ovalPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ovalPictureBox1.BackgroundImage")));
            this.ovalPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ovalPictureBox1.Location = new System.Drawing.Point(-3, 6);
            this.ovalPictureBox1.Name = "ovalPictureBox1";
            this.ovalPictureBox1.Size = new System.Drawing.Size(48, 49);
            this.ovalPictureBox1.TabIndex = 7;
            this.ovalPictureBox1.TabStop = false;
            // 
            // friendNameLabel
            // 
            this.friendNameLabel.AutoSize = true;
            this.friendNameLabel.Location = new System.Drawing.Point(51, 6);
            this.friendNameLabel.Name = "friendNameLabel";
            this.friendNameLabel.Size = new System.Drawing.Size(76, 16);
            this.friendNameLabel.TabIndex = 1;
            this.friendNameLabel.Text = "Friend Name";
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventNameLabel.AutoSize = true;
            this.eventNameLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.eventNameLabel.Location = new System.Drawing.Point(55, 23);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(72, 16);
            this.eventNameLabel.TabIndex = 2;
            this.eventNameLabel.Text = "EVENTNAME";
            // 
            // locationLabel
            // 
            this.locationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationLabel.AutoSize = true;
            this.locationLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.locationLabel.Location = new System.Drawing.Point(40, 39);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(55, 16);
            this.locationLabel.TabIndex = 3;
            this.locationLabel.Text = "Location";
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLabel.AutoSize = true;
            this.timeLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.timeLabel.Location = new System.Drawing.Point(92, 39);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(35, 16);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "20:00";
            // 
            // FriendListMini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FriendListMini";
            this.Size = new System.Drawing.Size(141, 62);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label friendNameLabel;
        private System.Windows.Forms.Label eventNameLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label timeLabel;
        private Common.OvalPictureBox ovalPictureBox1;
    }
}
