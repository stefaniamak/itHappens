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
            this.madeForYouLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.madeForYouLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.madeForYouLabel.Location = new System.Drawing.Point(50, 457);
            this.madeForYouLabel.Name = "madeForYouLabel";
            this.madeForYouLabel.Size = new System.Drawing.Size(164, 29);
            this.madeForYouLabel.TabIndex = 9;
            this.madeForYouLabel.Text = "Made for you";
            // 
            // todayLabel
            // 
            this.todayLabel.AutoSize = true;
            this.todayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.todayLabel.Location = new System.Drawing.Point(50, 28);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(86, 29);
            this.todayLabel.TabIndex = 6;
            this.todayLabel.Text = "Today";
            // 
            // madeForYouCarusel
            // 
            madeForYouCarusel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            madeForYouCarusel.AutoScroll = true;
            madeForYouCarusel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            madeForYouCarusel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            madeForYouCarusel.Location = new System.Drawing.Point(5, 492);
            madeForYouCarusel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            madeForYouCarusel.Name = "madeForYouCarusel";
            madeForYouCarusel.Padding = new System.Windows.Forms.Padding(2);
            madeForYouCarusel.Size = new System.Drawing.Size(534, 322);
            madeForYouCarusel.TabIndex = 8;
            // 
            // todayEventsCarousel
            // 
            todayEventsCarousel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            todayEventsCarousel.AutoScroll = true;
            todayEventsCarousel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            todayEventsCarousel.Location = new System.Drawing.Point(5, 63);
            todayEventsCarousel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            todayEventsCarousel.Name = "todayEventsCarousel";
            todayEventsCarousel.Padding = new System.Windows.Forms.Padding(2, 2, 2, 37);
            todayEventsCarousel.Size = new System.Drawing.Size(534, 330);
            todayEventsCarousel.TabIndex = 7;
            todayEventsCarousel.TabStop = false;
            todayEventsCarousel.Load += new System.EventHandler(this.todayEventsCarousel_Load);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(todayEventsCarousel);
            this.Controls.Add(this.madeForYouLabel);
            this.Controls.Add(madeForYouCarusel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(544, 1001);
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
