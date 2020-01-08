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
            this.friendnameLabel.Location = new System.Drawing.Point(54, 18);
            this.friendnameLabel.Name = "friendnameLabel";
            this.friendnameLabel.Size = new System.Drawing.Size(76, 16);
            this.friendnameLabel.TabIndex = 1;
            this.friendnameLabel.Text = "Friend Name";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.96491F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.03509F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Controls.Add(this.friendnameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.friendPicOvalPictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.colorControl, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(168, 53);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // friendPicOvalPictureBox
            // 
            this.friendPicOvalPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.friendPicOvalPictureBox.BackColor = System.Drawing.Color.DarkGray;
            this.friendPicOvalPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("friendPicOvalPictureBox.BackgroundImage")));
            this.friendPicOvalPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.friendPicOvalPictureBox.Location = new System.Drawing.Point(3, 6);
            this.friendPicOvalPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.friendPicOvalPictureBox.Name = "friendPicOvalPictureBox";
            this.friendPicOvalPictureBox.Size = new System.Drawing.Size(38, 41);
            this.friendPicOvalPictureBox.TabIndex = 0;
            this.friendPicOvalPictureBox.TabStop = false;
            // 
            // colorControl
            // 
            this.colorControl.BackColor = System.Drawing.Color.PaleGreen;
            this.colorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorControl.Location = new System.Drawing.Point(146, 4);
            this.colorControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.colorControl.Name = "colorControl";
            this.colorControl.Size = new System.Drawing.Size(19, 45);
            this.colorControl.TabIndex = 2;
            // 
            // FriendsAttending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FriendsAttending";
            this.Size = new System.Drawing.Size(168, 53);
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
