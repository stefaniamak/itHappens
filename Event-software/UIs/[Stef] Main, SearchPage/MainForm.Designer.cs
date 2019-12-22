namespace itHappens.UIs
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.usersLocationLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.todayLabel = new System.Windows.Forms.Label();
            this.madeForYouLabel = new System.Windows.Forms.Label();
            this.madeForYouCarusel = new itHappens.UIs.Common.Carousel();
            this.todayEventsCarousel = new itHappens.UIs.Common.Carousel();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // usersLocationLabel
            // 
            this.usersLocationLabel.AutoSize = true;
            this.usersLocationLabel.Location = new System.Drawing.Point(56, 33);
            this.usersLocationLabel.Name = "usersLocationLabel";
            this.usersLocationLabel.Size = new System.Drawing.Size(80, 13);
            this.usersLocationLabel.TabIndex = 0;
            this.usersLocationLabel.Text = "User\'s Location";
            this.usersLocationLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(57, 47);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(199, 20);
            this.searchTextBox.TabIndex = 1;
            // 
            // todayLabel
            // 
            this.todayLabel.AutoSize = true;
            this.todayLabel.Location = new System.Drawing.Point(59, 122);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(37, 13);
            this.todayLabel.TabIndex = 2;
            this.todayLabel.Text = "Today";
            // 
            // madeForYouLabel
            // 
            this.madeForYouLabel.AutoSize = true;
            this.madeForYouLabel.Location = new System.Drawing.Point(54, 476);
            this.madeForYouLabel.Name = "madeForYouLabel";
            this.madeForYouLabel.Size = new System.Drawing.Size(74, 13);
            this.madeForYouLabel.TabIndex = 5;
            this.madeForYouLabel.Text = "Made For You";
            // 
            // madeForYouCarusel
            // 
            this.madeForYouCarusel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.madeForYouCarusel.AutoScroll = true;
            this.madeForYouCarusel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.madeForYouCarusel.Location = new System.Drawing.Point(15, 502);
            this.madeForYouCarusel.Name = "madeForYouCarusel";
            this.madeForYouCarusel.Padding = new System.Windows.Forms.Padding(2);
            this.madeForYouCarusel.Size = new System.Drawing.Size(924, 279);
            this.madeForYouCarusel.TabIndex = 4;
            // 
            // todayEventsCarousel
            // 
            this.todayEventsCarousel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.todayEventsCarousel.AutoScroll = true;
            this.todayEventsCarousel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.todayEventsCarousel.Location = new System.Drawing.Point(15, 152);
            this.todayEventsCarousel.Name = "todayEventsCarousel";
            this.todayEventsCarousel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.todayEventsCarousel.Size = new System.Drawing.Size(924, 300);
            this.todayEventsCarousel.TabIndex = 3;
            this.todayEventsCarousel.TabStop = false;
            this.todayEventsCarousel.Load += new System.EventHandler(this.todayEventsCarousel_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(944, 804);
            this.Controls.Add(this.madeForYouLabel);
            this.Controls.Add(this.madeForYouCarusel);
            this.Controls.Add(this.todayEventsCarousel);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.usersLocationLabel);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label usersLocationLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label todayLabel;
        private Common.Carousel todayEventsCarousel;
        private Common.Carousel madeForYouCarusel;
        private System.Windows.Forms.Label madeForYouLabel;
    }
}