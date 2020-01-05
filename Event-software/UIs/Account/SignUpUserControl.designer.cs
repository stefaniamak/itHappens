namespace itHappens.UIs
{
    partial class SignUpUserControl
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
            this.areaValLabel = new System.Windows.Forms.Label();
            this.repassValLabel = new System.Windows.Forms.Label();
            this.passwordValLabel = new System.Windows.Forms.Label();
            this.usernameValLabel = new System.Windows.Forms.Label();
            this.emailValLabel = new System.Windows.Forms.Label();
            this.surnameValLabel = new System.Windows.Forms.Label();
            this.nameValLabel = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.itHappensLabel = new System.Windows.Forms.Label();
            this.areaComboBox = new System.Windows.Forms.ComboBox();
            this.areaLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.repassTextBox = new System.Windows.Forms.TextBox();
            this.repassLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // areaValLabel
            // 
            this.areaValLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.areaValLabel.Location = new System.Drawing.Point(397, 498);
            this.areaValLabel.Name = "areaValLabel";
            this.areaValLabel.Size = new System.Drawing.Size(176, 25);
            this.areaValLabel.TabIndex = 50;
            // 
            // repassValLabel
            // 
            this.repassValLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.repassValLabel.Location = new System.Drawing.Point(475, 387);
            this.repassValLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.repassValLabel.Name = "repassValLabel";
            this.repassValLabel.Size = new System.Drawing.Size(223, 28);
            this.repassValLabel.TabIndex = 49;
            this.repassValLabel.Validating += new System.ComponentModel.CancelEventHandler(this.repassTextBox_Validating);
            this.repassValLabel.Validated += new System.EventHandler(this.repassTextBox_Validated);
            // 
            // passwordValLabel
            // 
            this.passwordValLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.passwordValLabel.Location = new System.Drawing.Point(475, 333);
            this.passwordValLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordValLabel.Name = "passwordValLabel";
            this.passwordValLabel.Size = new System.Drawing.Size(223, 28);
            this.passwordValLabel.TabIndex = 48;
            this.passwordValLabel.Validating += new System.ComponentModel.CancelEventHandler(this.passwordTextBox_Validating);
            this.passwordValLabel.Validated += new System.EventHandler(this.passwordTextBox_Validated);
            // 
            // usernameValLabel
            // 
            this.usernameValLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.usernameValLabel.Location = new System.Drawing.Point(475, 270);
            this.usernameValLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameValLabel.Name = "usernameValLabel";
            this.usernameValLabel.Size = new System.Drawing.Size(223, 28);
            this.usernameValLabel.TabIndex = 47;
            this.usernameValLabel.Validating += new System.ComponentModel.CancelEventHandler(this.usernameTextBox_Validating);
            this.usernameValLabel.Validated += new System.EventHandler(this.usernameTextBox_Validated);
            // 
            // emailValLabel
            // 
            this.emailValLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.emailValLabel.Location = new System.Drawing.Point(475, 217);
            this.emailValLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailValLabel.Name = "emailValLabel";
            this.emailValLabel.Size = new System.Drawing.Size(223, 28);
            this.emailValLabel.TabIndex = 46;
            this.emailValLabel.Validating += new System.ComponentModel.CancelEventHandler(this.emailTextBox_Validating);
            this.emailValLabel.Validated += new System.EventHandler(this.emailTextBox_Validated);
            // 
            // surnameValLabel
            // 
            this.surnameValLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.surnameValLabel.Location = new System.Drawing.Point(475, 157);
            this.surnameValLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surnameValLabel.Name = "surnameValLabel";
            this.surnameValLabel.Size = new System.Drawing.Size(223, 28);
            this.surnameValLabel.TabIndex = 45;
            this.surnameValLabel.Validating += new System.ComponentModel.CancelEventHandler(this.surnameTextBox_Validating);
            this.surnameValLabel.Validated += new System.EventHandler(this.surnameTextBox_Validated);
            // 
            // nameValLabel
            // 
            this.nameValLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.nameValLabel.Location = new System.Drawing.Point(475, 99);
            this.nameValLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameValLabel.Name = "nameValLabel";
            this.nameValLabel.Size = new System.Drawing.Size(223, 28);
            this.nameValLabel.TabIndex = 44;
            this.nameValLabel.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextBox_Validating);
            this.nameValLabel.Validated += new System.EventHandler(this.nameTextBox_Validated);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(189, 445);
            this.numericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown.Minimum = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.ReadOnly = true;
            this.numericUpDown.Size = new System.Drawing.Size(160, 20);
            this.numericUpDown.TabIndex = 43;
            this.numericUpDown.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            // 
            // itHappensLabel
            // 
            this.itHappensLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.itHappensLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itHappensLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.itHappensLabel.Location = new System.Drawing.Point(271, 13);
            this.itHappensLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itHappensLabel.Name = "itHappensLabel";
            this.itHappensLabel.Size = new System.Drawing.Size(183, 47);
            this.itHappensLabel.TabIndex = 42;
            this.itHappensLabel.Text = "itHappens";
            this.itHappensLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // areaComboBox
            // 
            this.areaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.areaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.areaComboBox.Location = new System.Drawing.Point(189, 500);
            this.areaComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.areaComboBox.Name = "areaComboBox";
            this.areaComboBox.Size = new System.Drawing.Size(160, 23);
            this.areaComboBox.TabIndex = 41;
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.areaLabel.Location = new System.Drawing.Point(117, 500);
            this.areaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(40, 16);
            this.areaLabel.TabIndex = 40;
            this.areaLabel.Text = "Area:";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ageLabel.Location = new System.Drawing.Point(121, 445);
            this.ageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(36, 16);
            this.ageLabel.TabIndex = 39;
            this.ageLabel.Text = "Age:";
            // 
            // repassTextBox
            // 
            this.repassTextBox.Location = new System.Drawing.Point(189, 391);
            this.repassTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.repassTextBox.Name = "repassTextBox";
            this.repassTextBox.Size = new System.Drawing.Size(262, 20);
            this.repassTextBox.TabIndex = 38;
            this.repassTextBox.UseSystemPasswordChar = true;
            // 
            // repassLabel
            // 
            this.repassLabel.AutoSize = true;
            this.repassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.repassLabel.Location = new System.Drawing.Point(34, 394);
            this.repassLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.repassLabel.Name = "repassLabel";
            this.repassLabel.Size = new System.Drawing.Size(128, 16);
            this.repassLabel.TabIndex = 37;
            this.repassLabel.Text = "Re-Type Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(189, 337);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(262, 20);
            this.passwordTextBox.TabIndex = 36;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.passwordLabel.Location = new System.Drawing.Point(89, 337);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(71, 16);
            this.passwordLabel.TabIndex = 35;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(192, 274);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(262, 20);
            this.usernameTextBox.TabIndex = 34;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.usernameLabel.Location = new System.Drawing.Point(90, 274);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(74, 16);
            this.usernameLabel.TabIndex = 33;
            this.usernameLabel.Text = "Username:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(192, 217);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(262, 20);
            this.emailTextBox.TabIndex = 32;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.emailLabel.Location = new System.Drawing.Point(117, 221);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(45, 16);
            this.emailLabel.TabIndex = 31;
            this.emailLabel.Text = "Email:";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(192, 161);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(262, 20);
            this.surnameTextBox.TabIndex = 30;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(192, 99);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(262, 20);
            this.nameTextBox.TabIndex = 29;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.surnameLabel.Location = new System.Drawing.Point(98, 164);
            this.surnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(65, 16);
            this.surnameLabel.TabIndex = 28;
            this.surnameLabel.Text = "Surname:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nameLabel.Location = new System.Drawing.Point(117, 103);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(48, 16);
            this.nameLabel.TabIndex = 27;
            this.nameLabel.Text = "Name:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(211, 572);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(252, 51);
            this.submitButton.TabIndex = 26;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // SignUpUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.Controls.Add(this.areaValLabel);
            this.Controls.Add(this.repassValLabel);
            this.Controls.Add(this.passwordValLabel);
            this.Controls.Add(this.usernameValLabel);
            this.Controls.Add(this.emailValLabel);
            this.Controls.Add(this.surnameValLabel);
            this.Controls.Add(this.nameValLabel);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.itHappensLabel);
            this.Controls.Add(this.areaComboBox);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.repassTextBox);
            this.Controls.Add(this.repassLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.submitButton);
            this.Name = "SignUpUserControl";
            this.Size = new System.Drawing.Size(732, 636);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label areaValLabel;
        public System.Windows.Forms.Label repassValLabel;
        public System.Windows.Forms.Label passwordValLabel;
        public System.Windows.Forms.Label usernameValLabel;
        public System.Windows.Forms.Label emailValLabel;
        public System.Windows.Forms.Label surnameValLabel;
        public System.Windows.Forms.Label nameValLabel;
        public System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label itHappensLabel;
        public System.Windows.Forms.ComboBox areaComboBox;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Label ageLabel;
        public System.Windows.Forms.TextBox repassTextBox;
        private System.Windows.Forms.Label repassLabel;
        public System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        public System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        public System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        public System.Windows.Forms.TextBox surnameTextBox;
        public System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button submitButton;
    }
}
