namespace itHappens.UIs.Common
{
    partial class TestSplitForm
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
            this.leftSplitContainer = new System.Windows.Forms.SplitContainer();
            this.rightSplitContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.leftSplitContainer)).BeginInit();
            this.leftSplitContainer.Panel2.SuspendLayout();
            this.leftSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightSplitContainer)).BeginInit();
            this.rightSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftSplitContainer
            // 
            this.leftSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.leftSplitContainer.Location = new System.Drawing.Point(2, 3);
            this.leftSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.leftSplitContainer.Name = "leftSplitContainer";
            // 
            // leftSplitContainer.Panel1
            // 
            this.leftSplitContainer.Panel1.BackColor = System.Drawing.Color.Gold;
            this.leftSplitContainer.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // leftSplitContainer.Panel2
            // 
            this.leftSplitContainer.Panel2.Controls.Add(this.rightSplitContainer);
            this.leftSplitContainer.Size = new System.Drawing.Size(857, 550);
            this.leftSplitContainer.SplitterDistance = 157;
            this.leftSplitContainer.TabIndex = 0;
            // 
            // rightSplitContainer
            // 
            this.rightSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.rightSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.rightSplitContainer.Name = "rightSplitContainer";
            // 
            // rightSplitContainer.Panel1
            // 
            this.rightSplitContainer.Panel1.BackColor = System.Drawing.Color.Maroon;
            // 
            // rightSplitContainer.Panel2
            // 
            this.rightSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rightSplitContainer.Size = new System.Drawing.Size(696, 550);
            this.rightSplitContainer.SplitterDistance = 602;
            this.rightSplitContainer.TabIndex = 0;
            // 
            // TestSplitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 556);
            this.Controls.Add(this.leftSplitContainer);
            this.Name = "TestSplitForm";
            this.Text = "TestSplitForm";
            this.Load += new System.EventHandler(this.TestSplitForm_Load);
            this.leftSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leftSplitContainer)).EndInit();
            this.leftSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rightSplitContainer)).EndInit();
            this.rightSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer leftSplitContainer;
        private System.Windows.Forms.SplitContainer rightSplitContainer;
    }
}