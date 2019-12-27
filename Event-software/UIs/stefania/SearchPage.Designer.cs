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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.matchesList = new itHappens.UIs.Common.Listing();
            this.allCategoriesList = new itHappens.UIs.Common.Listing();
            this.mostFrequentLabel = new System.Windows.Forms.Label();
            this.machesLabel = new System.Windows.Forms.Label();
            this.allCategoriesLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.matchesList);
            this.panel1.Controls.Add(this.allCategoriesList);
            this.panel1.Controls.Add(this.mostFrequentLabel);
            this.panel1.Controls.Add(this.machesLabel);
            this.panel1.Controls.Add(this.allCategoriesLabel);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 640);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Red;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(30, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // matchesList
            // 
            this.matchesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchesList.AutoSize = true;
            this.matchesList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matchesList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.matchesList.Location = new System.Drawing.Point(24, 464);
            this.matchesList.Margin = new System.Windows.Forms.Padding(0);
            this.matchesList.Name = "matchesList";
            this.matchesList.Size = new System.Drawing.Size(354, 89);
            this.matchesList.TabIndex = 17;
            // 
            // allCategoriesList
            // 
            this.allCategoriesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allCategoriesList.AutoSize = true;
            this.allCategoriesList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.allCategoriesList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.allCategoriesList.Location = new System.Drawing.Point(26, 255);
            this.allCategoriesList.Margin = new System.Windows.Forms.Padding(0);
            this.allCategoriesList.Name = "allCategoriesList";
            this.allCategoriesList.Size = new System.Drawing.Size(354, 89);
            this.allCategoriesList.TabIndex = 16;
            // 
            // mostFrequentLabel
            // 
            this.mostFrequentLabel.AutoSize = true;
            this.mostFrequentLabel.Location = new System.Drawing.Point(24, 26);
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
            this.machesLabel.Location = new System.Drawing.Point(24, 418);
            this.machesLabel.Name = "machesLabel";
            this.machesLabel.Size = new System.Drawing.Size(48, 13);
            this.machesLabel.TabIndex = 14;
            this.machesLabel.Text = "Matches";
            // 
            // allCategoriesLabel
            // 
            this.allCategoriesLabel.AutoSize = true;
            this.allCategoriesLabel.Location = new System.Drawing.Point(27, 207);
            this.allCategoriesLabel.Name = "allCategoriesLabel";
            this.allCategoriesLabel.Size = new System.Drawing.Size(80, 13);
            this.allCategoriesLabel.TabIndex = 13;
            this.allCategoriesLabel.Text = "All Categories...";
            // 
            // SearchPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.Controls.Add(this.panel1);
            this.Name = "SearchPage";
            this.Size = new System.Drawing.Size(529, 646);
            this.Load += new System.EventHandler(this.SearchFormTest_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Listing matchesList;
        private Listing allCategoriesList;
        private System.Windows.Forms.Label mostFrequentLabel;
        private System.Windows.Forms.Label machesLabel;
        private System.Windows.Forms.Label allCategoriesLabel;
    }
}
