namespace itHappens.UIs.valentina
{
    partial class ListsContentPage
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
            this.ListsContentTitle = new System.Windows.Forms.Label();
            EventHolderFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ListsContentTitle
            // 
            this.ListsContentTitle.AutoSize = true;
            this.ListsContentTitle.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ListsContentTitle.Location = new System.Drawing.Point(0, 0);
            this.ListsContentTitle.Name = "ListsContentTitle";
            this.ListsContentTitle.Size = new System.Drawing.Size(94, 36);
            this.ListsContentTitle.TabIndex = 35;
            this.ListsContentTitle.Text = "Content";
            // 
            // EventHolderFlowLayoutPanel
            // 
            EventHolderFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            EventHolderFlowLayoutPanel.AutoSize = true;
            EventHolderFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            EventHolderFlowLayoutPanel.Location = new System.Drawing.Point(3, 51);
            EventHolderFlowLayoutPanel.Name = "EventHolderFlowLayoutPanel";
            EventHolderFlowLayoutPanel.Size = new System.Drawing.Size(0, 0);
            EventHolderFlowLayoutPanel.TabIndex = 36;
            // 
            // ListsContentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;



            this.BackColor = System.Drawing.Color.Thistle;

            this.Controls.Add(this.ListsContentTitle);
            this.Controls.Add(EventHolderFlowLayoutPanel);
            this.Name = "ListsContentPage";
            this.Size = new System.Drawing.Size(97, 54);
            this.Load += new System.EventHandler(this.ListsContentPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ListsContentTitle;
        public static System.Windows.Forms.FlowLayoutPanel EventHolderFlowLayoutPanel;
    }
}
