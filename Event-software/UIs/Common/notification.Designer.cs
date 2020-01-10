namespace itHappens.UIs.Common
{
    partial class notification
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
            this.notificationMessageLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notificationMessageLabel
            // 
            this.notificationMessageLabel.AutoSize = true;
            this.notificationMessageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notificationMessageLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationMessageLabel.Location = new System.Drawing.Point(3, 0);
            this.notificationMessageLabel.Name = "notificationMessageLabel";
            this.notificationMessageLabel.Size = new System.Drawing.Size(56, 16);
            this.notificationMessageLabel.TabIndex = 0;
            this.notificationMessageLabel.Text = "Message";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.notificationMessageLabel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(159, 41);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "notification";
            this.Size = new System.Drawing.Size(159, 41);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label notificationMessageLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
