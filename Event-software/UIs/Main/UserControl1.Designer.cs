namespace itHappens.UIs.Main
{
    partial class UserControl1
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
            this.warningMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // warningMessageLabel
            // 
            this.warningMessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.warningMessageLabel.AutoSize = true;
            this.warningMessageLabel.Location = new System.Drawing.Point(18, 82);
            this.warningMessageLabel.Name = "warningMessageLabel";
            this.warningMessageLabel.Size = new System.Drawing.Size(139, 13);
            this.warningMessageLabel.TabIndex = 0;
            this.warningMessageLabel.Text = "Please Login to see feature!";
            this.warningMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.warningMessageLabel);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(180, 180);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label warningMessageLabel;
    }
}
