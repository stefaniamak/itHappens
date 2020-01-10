namespace itHappens.UIs
{
    partial class InputOldPassForm
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
            this.OkButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OldPassTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(40, 119);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(94, 23);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(37, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Give your old password:";
            // 
            // OldPassTextBox
            // 
            this.OldPassTextBox.Location = new System.Drawing.Point(40, 46);
            this.OldPassTextBox.Name = "OldPassTextBox";
            this.OldPassTextBox.Size = new System.Drawing.Size(226, 20);
            this.OldPassTextBox.TabIndex = 2;
            this.OldPassTextBox.UseSystemPasswordChar = true;
            this.OldPassTextBox.Enter += new System.EventHandler(this.OldPassTextBox_Enter);
            this.OldPassTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OldPassTextBox_KeyPress);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(160, 119);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // WarningLabel
            // 
            this.WarningLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.WarningLabel.Location = new System.Drawing.Point(40, 87);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(226, 23);
            this.WarningLabel.TabIndex = 4;
            // 
            // InputOldPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 175);
            this.ControlBox = false;
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OldPassTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OkButton);
            this.Name = "InputOldPassForm";
            this.Text = "itHappens";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InputOldPassForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OldPassTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label WarningLabel;
    }
}