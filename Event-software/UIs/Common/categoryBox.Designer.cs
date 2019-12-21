namespace itHappens.UIs.Common
{
    partial class categoryBox
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
            this.categoryName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // categoryName
            // 
            this.categoryName.AutoSize = true;
            this.categoryName.Location = new System.Drawing.Point(94, 20);
            this.categoryName.Name = "categoryName";
            this.categoryName.Size = new System.Drawing.Size(49, 13);
            this.categoryName.TabIndex = 0;
            this.categoryName.Text = "Category";
            // 
            // categoryBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.categoryName);
            this.Name = "categoryBox";
            this.Size = new System.Drawing.Size(240, 233);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label categoryName;
    }
}
