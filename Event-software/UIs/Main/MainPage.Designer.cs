namespace itHappens.UIs.Main
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
            madeForYouCarusel = new itHappens.UIs.Common.Carousel();
            todayEventsCarousel = new itHappens.UIs.Common.Carousel();
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
            madeForYouCarusel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            madeForYouCarusel.AutoScroll = true;
            madeForYouCarusel.BackColor = System.Drawing.SystemColors.ControlLight;
            madeForYouCarusel.Location = new System.Drawing.Point(12, 404);
            madeForYouCarusel.Name = "madeForYouCarusel";
            madeForYouCarusel.Padding = new System.Windows.Forms.Padding(2);
            madeForYouCarusel.Size = new System.Drawing.Size(442, 279);
            madeForYouCarusel.TabIndex = 8;
            // 
            // todayEventsCarousel
            // 
            todayEventsCarousel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            todayEventsCarousel.AutoScroll = true;
            todayEventsCarousel.BackColor = System.Drawing.SystemColors.ControlLight;
            todayEventsCarousel.Location = new System.Drawing.Point(12, 54);
            todayEventsCarousel.Name = "todayEventsCarousel";
            todayEventsCarousel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            todayEventsCarousel.Size = new System.Drawing.Size(442, 286);
            todayEventsCarousel.TabIndex = 7;
            todayEventsCarousel.TabStop = false;
            todayEventsCarousel.Load += new System.EventHandler(this.todayEventsCarousel_Load);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.madeForYouLabel);
            this.Controls.Add(madeForYouCarusel);
            this.Controls.Add(todayEventsCarousel);
            this.Controls.Add(this.todayLabel);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(466, 703);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label madeForYouLabel;
        private System.Windows.Forms.Label todayLabel;
        public static Common.Carousel madeForYouCarusel;
        public static Common.Carousel todayEventsCarousel;
    }
}
