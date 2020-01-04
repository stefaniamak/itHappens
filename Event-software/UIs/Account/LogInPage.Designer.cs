namespace itHappens.UIs.anna
{
    partial class LogInPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInPage));
            this.GooglePictureBox = new System.Windows.Forms.PictureBox();
            this.UserPictureBox = new System.Windows.Forms.PictureBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.createAccountLabel = new System.Windows.Forms.LinkLabel();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.itHappensLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GooglePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GooglePictureBox
            // 
            this.GooglePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GooglePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("GooglePictureBox.Image")));
            this.GooglePictureBox.Location = new System.Drawing.Point(194, 467);
            this.GooglePictureBox.Name = "GooglePictureBox";
            this.GooglePictureBox.Size = new System.Drawing.Size(250, 37);
            this.GooglePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GooglePictureBox.TabIndex = 16;
            this.GooglePictureBox.TabStop = false;
            // 
            // UserPictureBox
            // 
            this.UserPictureBox.BackColor = System.Drawing.Color.DimGray;
            this.UserPictureBox.BackgroundImage = global::itHappens.Properties.Resources.LOGOPLSS;
            this.UserPictureBox.Location = new System.Drawing.Point(279, 78);
            this.UserPictureBox.Name = "UserPictureBox";
            this.UserPictureBox.Size = new System.Drawing.Size(83, 81);
            this.UserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserPictureBox.TabIndex = 15;
            this.UserPictureBox.TabStop = false;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Turquoise;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.LoginButton.Location = new System.Drawing.Point(194, 389);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(250, 37);
            this.LoginButton.TabIndex = 14;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // createAccountLabel
            // 
            this.createAccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.createAccountLabel.LinkColor = System.Drawing.Color.Cyan;
            this.createAccountLabel.Location = new System.Drawing.Point(191, 536);
            this.createAccountLabel.Name = "createAccountLabel";
            this.createAccountLabel.Size = new System.Drawing.Size(250, 19);
            this.createAccountLabel.TabIndex = 13;
            this.createAccountLabel.TabStop = true;
            this.createAccountLabel.Text = "Create new account";
            this.createAccountLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.createAccountLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createAccountLabel_LinkClicked_1);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.LightGray;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PasswordTextBox.Location = new System.Drawing.Point(194, 317);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(250, 26);
            this.PasswordTextBox.TabIndex = 12;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordTextBox_KeyPress);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.Color.LightGray;
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.UsernameTextBox.Location = new System.Drawing.Point(194, 240);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(250, 26);
            this.UsernameTextBox.TabIndex = 11;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.Turquoise;
            this.PasswordLabel.Location = new System.Drawing.Point(194, 288);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(106, 24);
            this.PasswordLabel.TabIndex = 10;
            this.PasswordLabel.Text = "Password:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.Turquoise;
            this.UsernameLabel.Location = new System.Drawing.Point(194, 211);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(111, 24);
            this.UsernameLabel.TabIndex = 9;
            this.UsernameLabel.Text = "Username:";
            // 
            // itHappensLabel
            // 
            this.itHappensLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.itHappensLabel.BackColor = System.Drawing.Color.Transparent;
            this.itHappensLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.itHappensLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.itHappensLabel.Location = new System.Drawing.Point(234, 10);
            this.itHappensLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itHappensLabel.Name = "itHappensLabel";
            this.itHappensLabel.Size = new System.Drawing.Size(183, 47);
            this.itHappensLabel.TabIndex = 43;
            this.itHappensLabel.Text = "itHappens";
            this.itHappensLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.itHappensLabel);
            this.Controls.Add(this.GooglePictureBox);
            this.Controls.Add(this.UserPictureBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.createAccountLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Name = "LogInPage";
            this.Size = new System.Drawing.Size(650, 604);
            ((System.ComponentModel.ISupportInitialize)(this.GooglePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox GooglePictureBox;
        private System.Windows.Forms.PictureBox UserPictureBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.LinkLabel createAccountLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label itHappensLabel;
    }
}
