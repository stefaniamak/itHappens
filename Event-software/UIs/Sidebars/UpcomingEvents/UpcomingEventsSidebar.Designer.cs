namespace itHappens.UIs.Sidebars
{
    partial class UpcomingEventsSidebar
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
            this.upcomingEventsFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(51, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(91, 13);
            this.title.TabIndex = 0;
            this.title.Text = "Upcoming Events";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // upcomingEventsFlowLayout
            // 
            this.upcomingEventsFlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.upcomingEventsFlowLayout.AutoSize = true;
            this.upcomingEventsFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.upcomingEventsFlowLayout.Location = new System.Drawing.Point(3, 25);
            this.upcomingEventsFlowLayout.Name = "upcomingEventsFlowLayout";
            this.upcomingEventsFlowLayout.Size = new System.Drawing.Size(0, 0);
            this.upcomingEventsFlowLayout.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.upcomingEventsFlowLayout);
            this.panel1.Location = new System.Drawing.Point(0, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 237);
            this.panel1.TabIndex = 2;
            // 
            // UpcomingEventsSidebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightPink;
            this.Controls.Add(this.title);
            this.Controls.Add(this.panel1);
            this.Name = "UpcomingEventsSidebar";
            this.Size = new System.Drawing.Size(205, 253);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.FlowLayoutPanel upcomingEventsFlowLayout;
        private System.Windows.Forms.Panel panel1;
    }
}
