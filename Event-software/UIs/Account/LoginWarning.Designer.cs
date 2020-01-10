namespace itHappens.UIs.Main
{
    partial class LoginWarning
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
            this.warningMessageLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.warningMessageLabel.Location = new System.Drawing.Point(0, 0);
            this.warningMessageLabel.Name = "warningMessageLabel";
            this.warningMessageLabel.Size = new System.Drawing.Size(346, 293);
            this.warningMessageLabel.TabIndex = 0;
            this.warningMessageLabel.Text = "Please Login to see feature!";
            this.warningMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.warningMessageLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "LoginWarning";
            this.Size = new System.Drawing.Size(347, 296);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label warningMessageLabel;
    }
}
