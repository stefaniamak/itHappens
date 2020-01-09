namespace itHappens.UIs.Common
{
    partial class CategoryMiniBox
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
            this.categoryLabel = new System.Windows.Forms.Label();
            this.backgroundColorPanel = new System.Windows.Forms.Panel();
            this.backgroundColorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryLabel
            // 
            this.categoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(0, 0);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(120, 32);
            this.categoryLabel.TabIndex = 0;
            this.categoryLabel.Text = "CATEGORY";
            this.categoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundColorPanel
            // 
            this.backgroundColorPanel.AutoSize = true;
            this.backgroundColorPanel.Controls.Add(this.categoryLabel);
            this.backgroundColorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundColorPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundColorPanel.Margin = new System.Windows.Forms.Padding(0);
            this.backgroundColorPanel.Name = "backgroundColorPanel";
            this.backgroundColorPanel.Size = new System.Drawing.Size(120, 32);
            this.backgroundColorPanel.TabIndex = 1;
            // 
            // CategoryMiniBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.backgroundColorPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CategoryMiniBox";
            this.Size = new System.Drawing.Size(120, 32);
            this.backgroundColorPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Panel backgroundColorPanel;
    }
}
