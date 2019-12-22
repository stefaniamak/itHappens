namespace CreateLogin.UIs
{
    partial class Form1
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
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.picemail = new System.Windows.Forms.PictureBox();
            this.picpass = new System.Windows.Forms.PictureBox();
            this.picuser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picemail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picpass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picuser)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameBox
            // 
            this.UsernameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.UsernameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameBox.ForeColor = System.Drawing.Color.White;
            this.UsernameBox.HideSelection = false;
            this.UsernameBox.Location = new System.Drawing.Point(109, 162);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(209, 13);
            this.UsernameBox.TabIndex = 1;
            this.UsernameBox.TabStop = false;
            this.UsernameBox.Text = "Username";
            this.UsernameBox.Click += new System.EventHandler(this.UsernameBox_Click);
 
            // 
            // PassBox
            // 
            this.PassBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.PassBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassBox.ForeColor = System.Drawing.Color.White;
            this.PassBox.HideSelection = false;
            this.PassBox.Location = new System.Drawing.Point(109, 229);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(209, 13);
            this.PassBox.TabIndex = 3;
            this.PassBox.TabStop = false;
            this.PassBox.Text = "Password";
            this.PassBox.Click += new System.EventHandler(this.PassBox_Click);
            this.PassBox.TextChanged += new System.EventHandler(this.PassBox_TextChanged);
            // 
            // EmailBox
            // 
            this.EmailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.EmailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailBox.ForeColor = System.Drawing.Color.White;
            this.EmailBox.HideSelection = false;
            this.EmailBox.Location = new System.Drawing.Point(109, 296);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(209, 13);
            this.EmailBox.TabIndex = 5;
            this.EmailBox.TabStop = false;
            this.EmailBox.Text = "Email";
            this.EmailBox.Click += new System.EventHandler(this.EmailBox_Click);
            this.EmailBox.TextChanged += new System.EventHandler(this.EmailBox_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(128, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 44);
            this.button2.TabIndex = 8;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(73, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 1);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(73, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 1);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(73, 322);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 1);
            this.panel3.TabIndex = 11;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::CreateLogin.Properties.Resources.LOGOPLSS;
            this.pictureBox4.Location = new System.Drawing.Point(161, 29);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(82, 80);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // picemail
            // 
            this.picemail.BackgroundImage = global::CreateLogin.Properties.Resources.email1;
            this.picemail.Location = new System.Drawing.Point(73, 286);
            this.picemail.Name = "picemail";
            this.picemail.Size = new System.Drawing.Size(30, 30);
            this.picemail.TabIndex = 4;
            this.picemail.TabStop = false;
            // 
            // picpass
            // 
            this.picpass.BackgroundImage = global::CreateLogin.Properties.Resources.pass1;
            this.picpass.Location = new System.Drawing.Point(73, 219);
            this.picpass.Name = "picpass";
            this.picpass.Size = new System.Drawing.Size(30, 30);
            this.picpass.TabIndex = 2;
            this.picpass.TabStop = false;
            this.picpass.Click += new System.EventHandler(this.picpass_Click);
            // 
            // picuser
            // 
            this.picuser.BackgroundImage = global::CreateLogin.Properties.Resources.user1;
            this.picuser.Location = new System.Drawing.Point(73, 153);
            this.picuser.Name = "picuser";
            this.picuser.Size = new System.Drawing.Size(30, 30);
            this.picuser.TabIndex = 0;
            this.picuser.TabStop = false;
            this.picuser.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(404, 514);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.picemail);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.picpass);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.picuser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picemail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picpass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picuser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.PictureBox picuser;
        private System.Windows.Forms.PictureBox picpass;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.PictureBox picemail;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}