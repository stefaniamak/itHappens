namespace itHappens.UIs.Common
{
    partial class FriendsWhoHaveVisited
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FriendsWhoHaveVisited));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.friendnameLabel = new System.Windows.Forms.Label();
            this.friendPicOvalPictureBox = new itHappens.UIs.Common.OvalPictureBox();
            this.friendSurnameLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendPicOvalPictureBox)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.78572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.21429F));
            this.tableLayoutPanel1.Controls.Add(this.friendPicOvalPictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-2, 1);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(168, 53);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // friendnameLabel
            // 
            this.friendnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.friendnameLabel.AutoSize = true;
            this.friendnameLabel.Location = new System.Drawing.Point(3, 0);
            this.friendnameLabel.Name = "friendnameLabel";
            this.friendnameLabel.Size = new System.Drawing.Size(41, 16);
            this.friendnameLabel.TabIndex = 1;
            this.friendnameLabel.Text = "Name";
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
            // friendSurnameLabel
            // 
            this.friendSurnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.friendSurnameLabel.AutoSize = true;
            this.friendSurnameLabel.Location = new System.Drawing.Point(50, 0);
            this.friendSurnameLabel.Name = "friendSurnameLabel";
            this.friendSurnameLabel.Size = new System.Drawing.Size(56, 16);
            this.friendSurnameLabel.TabIndex = 2;
            this.friendSurnameLabel.Text = "Surname";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.friendnameLabel);
            this.flowLayoutPanel1.Controls.Add(this.friendSurnameLabel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(48, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(117, 47);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // FriendsWhoHaveVisited
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FriendsWhoHaveVisited";
            this.Size = new System.Drawing.Size(163, 55);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.friendPicOvalPictureBox)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label friendnameLabel;
        private OvalPictureBox friendPicOvalPictureBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label friendSurnameLabel;
    }
}
