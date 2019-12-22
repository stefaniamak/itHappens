namespace itHappens.UIs.Common
{
    partial class SearchFormTest
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
            this.usersLocationLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.mostFrequentLabel = new System.Windows.Forms.Label();
            this.allCategoriesLabel = new System.Windows.Forms.Label();
            this.machesLabel = new System.Windows.Forms.Label();
            this.mostFrequentList = new itHappens.UIs.Common.Listing();
            this.allCategoriesList = new itHappens.UIs.Common.Listing();
            this.matchesList = new itHappens.UIs.Common.Listing();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usersLocationLabel
            // 
            this.usersLocationLabel.AutoSize = true;
            this.usersLocationLabel.Location = new System.Drawing.Point(15, 23);
            this.usersLocationLabel.Name = "usersLocationLabel";
            this.usersLocationLabel.Size = new System.Drawing.Size(80, 13);
            this.usersLocationLabel.TabIndex = 10;
            this.usersLocationLabel.Text = "User\'s Location";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(16, 37);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(199, 20);
            this.searchTextBox.TabIndex = 11;
            // 
            // mostFrequentLabel
            // 
            this.mostFrequentLabel.AutoSize = true;
            this.mostFrequentLabel.Location = new System.Drawing.Point(16, 90);
            this.mostFrequentLabel.Name = "mostFrequentLabel";
            this.mostFrequentLabel.Size = new System.Drawing.Size(84, 13);
            this.mostFrequentLabel.TabIndex = 12;
            this.mostFrequentLabel.Text = "Most Frequent...";
            // 
            // allCategoriesLabel
            // 
            this.allCategoriesLabel.AutoSize = true;
            this.allCategoriesLabel.Location = new System.Drawing.Point(19, 271);
            this.allCategoriesLabel.Name = "allCategoriesLabel";
            this.allCategoriesLabel.Size = new System.Drawing.Size(80, 13);
            this.allCategoriesLabel.TabIndex = 13;
            this.allCategoriesLabel.Text = "All Categories...";
            // 
            // machesLabel
            // 
            this.machesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.machesLabel.AutoSize = true;
            this.machesLabel.Location = new System.Drawing.Point(16, 482);
            this.machesLabel.Name = "machesLabel";
            this.machesLabel.Size = new System.Drawing.Size(48, 13);
            this.machesLabel.TabIndex = 14;
            this.machesLabel.Text = "Matches";
            // 
            // mostFrequentList
            // 
            this.mostFrequentList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mostFrequentList.AutoSize = true;
            this.mostFrequentList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mostFrequentList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mostFrequentList.Location = new System.Drawing.Point(18, 251);
            this.mostFrequentList.Margin = new System.Windows.Forms.Padding(0);
            this.mostFrequentList.Name = "mostFrequentList";
            this.mostFrequentList.Size = new System.Drawing.Size(354, 89);
            this.mostFrequentList.TabIndex = 15;
            // 
            // allCategoriesList
            // 
            this.allCategoriesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allCategoriesList.AutoSize = true;
            this.allCategoriesList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.allCategoriesList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.allCategoriesList.Location = new System.Drawing.Point(18, 319);
            this.allCategoriesList.Margin = new System.Windows.Forms.Padding(0);
            this.allCategoriesList.Name = "allCategoriesList";
            this.allCategoriesList.Size = new System.Drawing.Size(354, 89);
            this.allCategoriesList.TabIndex = 16;
            // 
            // matchesList
            // 
            this.matchesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchesList.AutoSize = true;
            this.matchesList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matchesList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.matchesList.Location = new System.Drawing.Point(16, 528);
            this.matchesList.Margin = new System.Windows.Forms.Padding(0);
            this.matchesList.Name = "matchesList";
            this.matchesList.Size = new System.Drawing.Size(354, 89);
            this.matchesList.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.mostFrequentList);
            this.panel1.Controls.Add(this.usersLocationLabel);
            this.panel1.Controls.Add(this.matchesList);
            this.panel1.Controls.Add(this.searchTextBox);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 127);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // SearchFormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.Controls.Add(this.panel1);
            this.Name = "SearchFormTest";
            this.Size = new System.Drawing.Size(529, 646);
            this.Load += new System.EventHandler(this.SearchFormTest_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label usersLocationLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label mostFrequentLabel;
        private System.Windows.Forms.Label allCategoriesLabel;
        private System.Windows.Forms.Label machesLabel;
        private Common.Listing mostFrequentList;
        private Common.Listing allCategoriesList;
        private Common.Listing matchesList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
