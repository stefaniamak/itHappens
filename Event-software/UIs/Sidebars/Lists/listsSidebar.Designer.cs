namespace itHappens.UIs.Sidebars
{
    partial class ListsSidebar
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
            this.label1 = new System.Windows.Forms.Label();
            this.listsPanel = new System.Windows.Forms.Panel();
            this.listsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.listsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(63, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lists";
            // 
            // listsPanel
            // 
            this.listsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listsPanel.AutoScroll = true;
            this.listsPanel.Controls.Add(this.listsFlowLayoutPanel);
            this.listsPanel.Location = new System.Drawing.Point(0, 21);
            this.listsPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listsPanel.Name = "listsPanel";
            this.listsPanel.Size = new System.Drawing.Size(175, 164);
            this.listsPanel.TabIndex = 1;
            // 
            // listsFlowLayoutPanel
            // 
            this.listsFlowLayoutPanel.AutoSize = true;
            this.listsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.listsFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.listsFlowLayoutPanel.Name = "listsFlowLayoutPanel";
            this.listsFlowLayoutPanel.Size = new System.Drawing.Size(0, 0);
            this.listsFlowLayoutPanel.TabIndex = 0;
            // 
            // ListsSidebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listsPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ListsSidebar";
            this.Size = new System.Drawing.Size(175, 185);
            this.listsPanel.ResumeLayout(false);
            this.listsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel listsPanel;
        private System.Windows.Forms.FlowLayoutPanel listsFlowLayoutPanel;
    }
}
