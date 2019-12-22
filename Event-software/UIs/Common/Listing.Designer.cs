namespace itHappens.UIs.Common
{
    partial class Listing
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
            this.listingFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // listingFlowLayout
            // 
            this.listingFlowLayout.AutoSize = true;
            this.listingFlowLayout.BackColor = System.Drawing.SystemColors.Control;
            this.listingFlowLayout.Location = new System.Drawing.Point(3, 0);
            this.listingFlowLayout.Name = "listingFlowLayout";
            this.listingFlowLayout.Size = new System.Drawing.Size(348, 86);
            this.listingFlowLayout.TabIndex = 1;
            this.listingFlowLayout.TabStop = true;
            // 
            // Listing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.listingFlowLayout);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Listing";
            this.Size = new System.Drawing.Size(354, 89);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel listingFlowLayout;
    }
}
