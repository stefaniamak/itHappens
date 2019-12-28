namespace itHappens.UIs.Sidebars.UpcomingEvents
{
    partial class UpcomingEventMini
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
            this.eventName = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.Label();
            this.upcomingEventDetails = new System.Windows.Forms.Panel();
            this.upcomingEventDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventName
            // 
            this.eventName.AutoSize = true;
            this.eventName.Location = new System.Drawing.Point(7, 10);
            this.eventName.Name = "eventName";
            this.eventName.Size = new System.Drawing.Size(66, 13);
            this.eventName.TabIndex = 0;
            this.eventName.Text = "Event Name";
            this.eventName.Click += new System.EventHandler(this.eventName_Click);
            // 
            // month
            // 
            this.month.AutoSize = true;
            this.month.Location = new System.Drawing.Point(89, 10);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(37, 13);
            this.month.TabIndex = 1;
            this.month.Text = "Month";
            this.month.Click += new System.EventHandler(this.month_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(98, 33);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(28, 13);
            this.date.TabIndex = 2;
            this.date.Text = "date";
            this.date.Click += new System.EventHandler(this.date_Click);
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.Location = new System.Drawing.Point(7, 33);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(44, 13);
            this.location.TabIndex = 3;
            this.location.Text = "location";
            this.location.Click += new System.EventHandler(this.location_Click);
            // 
            // upcomingEventDetails
            // 
            this.upcomingEventDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.upcomingEventDetails.Controls.Add(this.location);
            this.upcomingEventDetails.Controls.Add(this.date);
            this.upcomingEventDetails.Controls.Add(this.month);
            this.upcomingEventDetails.Controls.Add(this.eventName);
            this.upcomingEventDetails.Location = new System.Drawing.Point(0, 0);
            this.upcomingEventDetails.Name = "upcomingEventDetails";
            this.upcomingEventDetails.Size = new System.Drawing.Size(138, 55);
            this.upcomingEventDetails.TabIndex = 4;
            // 
            // UpcomingEventMini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.upcomingEventDetails);
            this.Name = "UpcomingEventMini";
            this.Size = new System.Drawing.Size(138, 55);
            this.upcomingEventDetails.ResumeLayout(false);
            this.upcomingEventDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label eventName;
        private System.Windows.Forms.Label month;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Panel upcomingEventDetails;
    }
}
