namespace itHappens.UIs.valentina
{
    partial class ListPage
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
            this.label7 = new System.Windows.Forms.Label();
            this.ListsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.Location = new System.Drawing.Point(3, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 36);
            this.label7.TabIndex = 72;
            this.label7.Text = "Lists";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // ListsFlowLayoutPanel
            // 
            this.ListsFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListsFlowLayoutPanel.AutoSize = true;
            this.ListsFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ListsFlowLayoutPanel.Location = new System.Drawing.Point(-1, 61);
            this.ListsFlowLayoutPanel.Name = "ListsFlowLayoutPanel";
            this.ListsFlowLayoutPanel.Size = new System.Drawing.Size(0, 0);
            this.ListsFlowLayoutPanel.TabIndex = 73;
            // 
            // ListPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.ListsFlowLayoutPanel);
            this.Controls.Add(this.label7);
            this.Name = "ListPage";
            this.Size = new System.Drawing.Size(72, 64);
            this.Load += new System.EventHandler(this.ListPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel ListsFlowLayoutPanel;
    }
}
