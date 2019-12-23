namespace itHappens.UIs.stefania
{
    partial class MainPage
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
            this.madeForYouLabel = new System.Windows.Forms.Label();
            this.todayLabel = new System.Windows.Forms.Label();
            this.madeForYouCarusel = new itHappens.UIs.Common.Carousel();
            this.todayEventsCarousel = new itHappens.UIs.Common.Carousel();
            this.SuspendLayout();
            // 
            // madeForYouLabel
            // 
            this.madeForYouLabel.AutoSize = true;
            this.madeForYouLabel.Location = new System.Drawing.Point(51, 378);
            this.madeForYouLabel.Name = "madeForYouLabel";
            this.madeForYouLabel.Size = new System.Drawing.Size(74, 13);
            this.madeForYouLabel.TabIndex = 9;
            this.madeForYouLabel.Text = "Made For You";
            // 
            // todayLabel
            // 
            this.todayLabel.AutoSize = true;
            this.todayLabel.Location = new System.Drawing.Point(56, 24);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(37, 13);
            this.todayLabel.TabIndex = 6;
            this.todayLabel.Text = "Today";
            // 
            // madeForYouCarusel
            // 
            this.madeForYouCarusel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.madeForYouCarusel.AutoScroll = true;
            this.madeForYouCarusel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.madeForYouCarusel.Location = new System.Drawing.Point(12, 404);
            this.madeForYouCarusel.Name = "madeForYouCarusel";
            this.madeForYouCarusel.Padding = new System.Windows.Forms.Padding(2);
            this.madeForYouCarusel.Size = new System.Drawing.Size(442, 279);
            this.madeForYouCarusel.TabIndex = 8;
            // 
            // todayEventsCarousel
            // 
            this.todayEventsCarousel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.todayEventsCarousel.AutoScroll = true;
            this.todayEventsCarousel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.todayEventsCarousel.Location = new System.Drawing.Point(12, 54);
            this.todayEventsCarousel.Name = "todayEventsCarousel";
            this.todayEventsCarousel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.todayEventsCarousel.Size = new System.Drawing.Size(442, 286);
            this.todayEventsCarousel.TabIndex = 7;
            this.todayEventsCarousel.TabStop = false;
            this.todayEventsCarousel.Load += new System.EventHandler(this.todayEventsCarousel_Load);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Salmon;
            this.Controls.Add(this.madeForYouLabel);
            this.Controls.Add(this.madeForYouCarusel);
            this.Controls.Add(this.todayEventsCarousel);
            this.Controls.Add(this.todayLabel);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(466, 703);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label madeForYouLabel;
        private Common.Carousel madeForYouCarusel;
        private Common.Carousel todayEventsCarousel;
        private System.Windows.Forms.Label todayLabel;
    }
}
