namespace itHappens.UIs.anna
{
    partial class ContactForm
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
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.label = new System.Windows.Forms.Label();
            this.txtRecipientEmail = new System.Windows.Forms.TextBox();
            this.rtbBody = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox
            // 
            this.groupbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupbox.Controls.Add(this.label);
            this.groupbox.Controls.Add(this.txtRecipientEmail);
            this.groupbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox.Location = new System.Drawing.Point(14, 18);
            this.groupbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupbox.Name = "groupbox";
            this.groupbox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupbox.Size = new System.Drawing.Size(499, 100);
            this.groupbox.TabIndex = 2;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "Personal Details";
            this.groupbox.Enter += new System.EventHandler(this.groupBox_Enter);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.Color.DarkOrange;
            this.label.Location = new System.Drawing.Point(24, 52);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(100, 21);
            this.label.TabIndex = 0;
            this.label.Text = "Your email :";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // txtRecipientEmail
            // 
            this.txtRecipientEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecipientEmail.Location = new System.Drawing.Point(142, 49);
            this.txtRecipientEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRecipientEmail.Name = "txtRecipientEmail";
            this.txtRecipientEmail.Size = new System.Drawing.Size(329, 27);
            this.txtRecipientEmail.TabIndex = 1;
            // 
            // rtbBody
            // 
            this.rtbBody.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbBody.Location = new System.Drawing.Point(14, 126);
            this.rtbBody.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbBody.Name = "rtbBody";
            this.rtbBody.Size = new System.Drawing.Size(492, 223);
            this.rtbBody.TabIndex = 0;
            this.rtbBody.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(303, 381);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(210, 52);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Contact Us";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.rtbBody);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.groupbox);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ContactForm";
            this.Size = new System.Drawing.Size(535, 452);
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtRecipientEmail;
        private System.Windows.Forms.RichTextBox rtbBody;
        private System.Windows.Forms.Button btnSend;
    }
}
