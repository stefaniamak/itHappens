namespace itHappens.UIs.Common
{
    partial class NotificationBox
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
            this.notificationFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // notificationFlowLayoutPanel
            // 
            this.notificationFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notificationFlowLayoutPanel.AutoSize = true;
            this.notificationFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.notificationFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.notificationFlowLayoutPanel.Name = "notificationFlowLayoutPanel";
            this.notificationFlowLayoutPanel.Size = new System.Drawing.Size(150, 150);
            this.notificationFlowLayoutPanel.TabIndex = 0;
            // 
            // NotificationBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.notificationFlowLayoutPanel);
            this.Name = "NotificationBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel notificationFlowLayoutPanel;
    }
}
