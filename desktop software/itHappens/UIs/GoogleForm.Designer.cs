namespace CreateLogin
{
    partial class GoogleForm
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
            this.GoogleWebBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // GoogleWebBrowser
            // 
            this.GoogleWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GoogleWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.GoogleWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.GoogleWebBrowser.Name = "GoogleWebBrowser";
            this.GoogleWebBrowser.Size = new System.Drawing.Size(626, 651);
            this.GoogleWebBrowser.TabIndex = 0;
           
            // 
            // GoogleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 651);
            this.Controls.Add(this.GoogleWebBrowser);
            this.Name = "GoogleForm";
            this.Text = "GoogleForm";
            this.Load += new System.EventHandler(this.GoogleForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser GoogleWebBrowser;
        

    }
}