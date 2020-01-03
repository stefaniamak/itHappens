namespace itHappens.UIs.Common
{
    partial class SearchPage
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
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.mostFrequentLabel = new System.Windows.Forms.Label();
            this.machesLabel = new System.Windows.Forms.Label();
            this.allCategoriesLabel = new System.Windows.Forms.Label();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            fullPageflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            fullPageflowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            flowLayoutPanel1.Size = new System.Drawing.Size(84, 10);
            flowLayoutPanel1.TabIndex = 18;
            // 
            // mostFrequentLabel
            // 
            this.mostFrequentLabel.AutoSize = true;
            this.mostFrequentLabel.Location = new System.Drawing.Point(3, 0);
            this.mostFrequentLabel.Name = "mostFrequentLabel";
            this.mostFrequentLabel.Size = new System.Drawing.Size(84, 13);
            this.mostFrequentLabel.TabIndex = 12;
            this.mostFrequentLabel.Text = "Most Frequent...";
            // 
            // machesLabel
            // 
            this.machesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.machesLabel.AutoSize = true;
            this.machesLabel.Location = new System.Drawing.Point(3, 48);
            this.machesLabel.Name = "machesLabel";
            this.machesLabel.Size = new System.Drawing.Size(84, 13);
            this.machesLabel.TabIndex = 14;
            this.machesLabel.Text = "Matches";
            // 
            // allCategoriesLabel
            // 
            this.allCategoriesLabel.AutoSize = true;
            this.allCategoriesLabel.Location = new System.Drawing.Point(3, 29);
            this.allCategoriesLabel.Name = "allCategoriesLabel";
            this.allCategoriesLabel.Size = new System.Drawing.Size(80, 13);
            this.allCategoriesLabel.TabIndex = 13;
            this.allCategoriesLabel.Text = "All Categories...";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            flowLayoutPanel2.Location = new System.Drawing.Point(3, 45);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(84, 0);
            flowLayoutPanel2.TabIndex = 19;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel3.BackColor = System.Drawing.SystemColors.Control;
            flowLayoutPanel3.Location = new System.Drawing.Point(3, 64);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new System.Drawing.Size(84, 0);
            flowLayoutPanel3.TabIndex = 20;
            // 
            // fullPageflowLayoutPanel
            // 
            fullPageflowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            fullPageflowLayoutPanel.AutoSize = true;
            fullPageflowLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            fullPageflowLayoutPanel.Controls.Add(this.mostFrequentLabel);
            fullPageflowLayoutPanel.Controls.Add(flowLayoutPanel1);
            fullPageflowLayoutPanel.Controls.Add(allCategoriesLabel);
            fullPageflowLayoutPanel.Controls.Add(flowLayoutPanel2);
            fullPageflowLayoutPanel.Controls.Add(machesLabel);
            fullPageflowLayoutPanel.Controls.Add(flowLayoutPanel3);
            fullPageflowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            fullPageflowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            fullPageflowLayoutPanel.Name = "fullPageflowLayoutPanel";
            fullPageflowLayoutPanel.Size = new System.Drawing.Size(331, 646);
            fullPageflowLayoutPanel.TabIndex = 21;
            // 
            // SearchPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.Controls.Add(fullPageflowLayoutPanel);
            this.Name = "SearchPage";
            this.Size = new System.Drawing.Size(331, 646);
            this.Load += new System.EventHandler(this.SearchFormTest_Load);
            fullPageflowLayoutPanel.ResumeLayout(false);
            fullPageflowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public static System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public static System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        public static  System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label mostFrequentLabel;
        private System.Windows.Forms.Label machesLabel;
        private System.Windows.Forms.Label allCategoriesLabel;
        public static System.Windows.Forms.FlowLayoutPanel fullPageflowLayoutPanel;
    }
}
