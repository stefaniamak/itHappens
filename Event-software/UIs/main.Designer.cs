namespace itHappens.UIs
{
    partial class main
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
            this.slitterLeft = new System.Windows.Forms.Splitter();
            this.slitterRightFriendList = new System.Windows.Forms.Splitter();
            this.mainPage = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // slitterLeft
            // 
            this.slitterLeft.Location = new System.Drawing.Point(0, 0);
            this.slitterLeft.Name = "slitterLeft";
            this.slitterLeft.Size = new System.Drawing.Size(153, 469);
            this.slitterLeft.TabIndex = 1;
            this.slitterLeft.TabStop = false;
            // 
            // slitterRightFriendList
            // 
            this.slitterRightFriendList.Dock = System.Windows.Forms.DockStyle.Right;
            this.slitterRightFriendList.Location = new System.Drawing.Point(734, 0);
            this.slitterRightFriendList.Name = "slitterRightFriendList";
            this.slitterRightFriendList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.slitterRightFriendList.Size = new System.Drawing.Size(123, 469);
            this.slitterRightFriendList.TabIndex = 2;
            this.slitterRightFriendList.TabStop = false;
            // 
            // mainPage
            // 
            this.mainPage.AutoSize = true;
            this.mainPage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPage.Location = new System.Drawing.Point(153, 0);
            this.mainPage.Name = "mainPage";
            this.mainPage.Size = new System.Drawing.Size(581, 469);
            this.mainPage.TabIndex = 4;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(153, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 469);
            this.splitter2.TabIndex = 5;
            this.splitter2.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 469);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.mainPage);
            this.Controls.Add(this.slitterRightFriendList);
            this.Controls.Add(this.slitterLeft);
            this.Name = "main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter slitterLeft;
        private System.Windows.Forms.Splitter slitterRightFriendList;
        private System.Windows.Forms.Panel mainPage;
        private System.Windows.Forms.Splitter splitter2;
    }
}