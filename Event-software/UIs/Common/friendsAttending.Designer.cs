namespace itHappens.UIs.Common
{
    partial class FriendsAttending
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FriendsAttending));
            this.friendnameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.friendPicOvalPictureBox = new itHappens.UIs.Common.OvalPictureBox();
            this.colorControl = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendPicOvalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // friendnameLabel
            // 
            this.friendnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.friendnameLabel.AutoSize = true;
            this.friendnameLabel.Location = new System.Drawing.Point(47, 15);
            this.friendnameLabel.Name = "friendnameLabel";
            this.friendnameLabel.Size = new System.Drawing.Size(67, 13);
            this.friendnameLabel.TabIndex = 1;
            this.friendnameLabel.Text = "Friend Name";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.96491F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.03509F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.Controls.Add(this.friendnameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.friendPicOvalPictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.colorControl, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(144, 43);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // friendPicOvalPictureBox
            // 
            this.friendPicOvalPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.friendPicOvalPictureBox.BackColor = System.Drawing.Color.DarkGray;
            this.friendPicOvalPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("friendPicOvalPictureBox.BackgroundImage")));
            this.friendPicOvalPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.friendPicOvalPictureBox.Location = new System.Drawing.Point(3, 5);
            this.friendPicOvalPictureBox.Name = "friendPicOvalPictureBox";
            this.friendPicOvalPictureBox.Size = new System.Drawing.Size(33, 33);
            this.friendPicOvalPictureBox.TabIndex = 0;
            this.friendPicOvalPictureBox.TabStop = false;
            // 
            // colorControl
            // 
            this.colorControl.BackColor = System.Drawing.Color.PaleGreen;
            this.colorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorControl.Location = new System.Drawing.Point(127, 3);
            this.colorControl.Name = "colorControl";
            this.colorControl.Size = new System.Drawing.Size(14, 37);
            this.colorControl.TabIndex = 2;
            // 
            // FriendsAttending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FriendsAttending";
            this.Size = new System.Drawing.Size(144, 43);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendPicOvalPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OvalPictureBox friendPicOvalPictureBox;
        private System.Windows.Forms.Label friendnameLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel colorControl;
    }
}
