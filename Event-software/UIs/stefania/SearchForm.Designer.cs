namespace itHappens.UIs
{
    partial class SearchForm
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.usersLocationLabel = new System.Windows.Forms.Label();
            this.mostFrequentLabel = new System.Windows.Forms.Label();
            this.allCategoriesLabel = new System.Windows.Forms.Label();
            this.machesLabel = new System.Windows.Forms.Label();
            this.matchesList = new itHappens.UIs.Common.Listing();
            this.allCategoriesList = new itHappens.UIs.Common.Listing();
            this.mostFrequentList = new itHappens.UIs.Common.Listing();
            this.panel1 = new System.Windows.Forms.Panel();
            this.allCategoriesFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(58, 51);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(199, 20);
            this.searchTextBox.TabIndex = 3;
            // 
            // usersLocationLabel
            // 
            this.usersLocationLabel.AutoSize = true;
            this.usersLocationLabel.Location = new System.Drawing.Point(57, 37);
            this.usersLocationLabel.Name = "usersLocationLabel";
            this.usersLocationLabel.Size = new System.Drawing.Size(80, 13);
            this.usersLocationLabel.TabIndex = 2;
            this.usersLocationLabel.Text = "User\'s Location";
            // 
            // mostFrequentLabel
            // 
            this.mostFrequentLabel.AutoSize = true;
            this.mostFrequentLabel.Location = new System.Drawing.Point(58, 104);
            this.mostFrequentLabel.Name = "mostFrequentLabel";
            this.mostFrequentLabel.Size = new System.Drawing.Size(84, 13);
            this.mostFrequentLabel.TabIndex = 4;
            this.mostFrequentLabel.Text = "Most Frequent...";
            // 
            // allCategoriesLabel
            // 
            this.allCategoriesLabel.AutoSize = true;
            this.allCategoriesLabel.Location = new System.Drawing.Point(61, 285);
            this.allCategoriesLabel.Name = "allCategoriesLabel";
            this.allCategoriesLabel.Size = new System.Drawing.Size(80, 13);
            this.allCategoriesLabel.TabIndex = 5;
            this.allCategoriesLabel.Text = "All Categories...";
            // 
            // machesLabel
            // 
            this.machesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.machesLabel.AutoSize = true;
            this.machesLabel.Location = new System.Drawing.Point(58, 496);
            this.machesLabel.Name = "machesLabel";
            this.machesLabel.Size = new System.Drawing.Size(48, 13);
            this.machesLabel.TabIndex = 6;
            this.machesLabel.Text = "Matches";
            // 
            // matchesList
            // 
            this.matchesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchesList.AutoSize = true;
            this.matchesList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matchesList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.matchesList.Location = new System.Drawing.Point(58, 542);
            this.matchesList.Margin = new System.Windows.Forms.Padding(0);
            this.matchesList.Name = "matchesList";
            this.matchesList.Size = new System.Drawing.Size(354, 89);
            this.matchesList.TabIndex = 9;
            // 
            // allCategoriesList
            // 
            this.allCategoriesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allCategoriesList.AutoSize = true;
            this.allCategoriesList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.allCategoriesList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.allCategoriesList.Location = new System.Drawing.Point(60, 395);
            this.allCategoriesList.Margin = new System.Windows.Forms.Padding(0);
            this.allCategoriesList.Name = "allCategoriesList";
            this.allCategoriesList.Size = new System.Drawing.Size(354, 89);
            this.allCategoriesList.TabIndex = 8;
            // 
            // mostFrequentList
            // 
            this.mostFrequentList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mostFrequentList.AutoSize = true;
            this.mostFrequentList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mostFrequentList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mostFrequentList.Location = new System.Drawing.Point(58, 140);
            this.mostFrequentList.Margin = new System.Windows.Forms.Padding(0);
            this.mostFrequentList.Name = "mostFrequentList";
            this.mostFrequentList.Size = new System.Drawing.Size(354, 89);
            this.mostFrequentList.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.allCategoriesFlowPanel);
            this.panel1.Controls.Add(this.usersLocationLabel);
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Controls.Add(this.mostFrequentLabel);
            this.panel1.Controls.Add(this.allCategoriesLabel);
            this.panel1.Controls.Add(this.machesLabel);
            this.panel1.Controls.Add(this.mostFrequentList);
            this.panel1.Controls.Add(this.allCategoriesList);
            this.panel1.Controls.Add(this.matchesList);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 757);
            this.panel1.TabIndex = 10;
            // 
            // allCategoriesFlowPanel
            // 
            this.allCategoriesFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allCategoriesFlowPanel.AutoSize = true;
            this.allCategoriesFlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.allCategoriesFlowPanel.Location = new System.Drawing.Point(64, 330);
            this.allCategoriesFlowPanel.Name = "allCategoriesFlowPanel";
            this.allCategoriesFlowPanel.Size = new System.Drawing.Size(0, 0);
            this.allCategoriesFlowPanel.TabIndex = 10;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 753);
            this.Controls.Add(this.panel1);
            this.Name = "SearchForm";
            this.Text = "Matches";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label usersLocationLabel;
        private System.Windows.Forms.Label mostFrequentLabel;
        private System.Windows.Forms.Label allCategoriesLabel;
        private System.Windows.Forms.Label machesLabel;
        private Common.Listing mostFrequentList;
        private Common.Listing allCategoriesList;
        private Common.Listing matchesList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel allCategoriesFlowPanel;
    }
}