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
            this.groupbox.Controls.Add(this.label);
            this.groupbox.Controls.Add(this.txtRecipientEmail);
            this.groupbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox.Location = new System.Drawing.Point(16, 19);
            this.groupbox.Margin = new System.Windows.Forms.Padding(4);
            this.groupbox.Name = "groupbox";
            this.groupbox.Padding = new System.Windows.Forms.Padding(4);
            this.groupbox.Size = new System.Drawing.Size(571, 100);
            this.groupbox.TabIndex = 2;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "Personal Details";
            this.groupbox.Enter += new System.EventHandler(this.groupBox_Enter);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(28, 52);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(115, 25);
            this.label.TabIndex = 0;
            this.label.Text = "Your email :";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // txtRecipientEmail
            // 
            this.txtRecipientEmail.Location = new System.Drawing.Point(212, 48);
            this.txtRecipientEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtRecipientEmail.Name = "txtRecipientEmail";
            this.txtRecipientEmail.Size = new System.Drawing.Size(349, 30);
            this.txtRecipientEmail.TabIndex = 1;
            // 
            // rtbBody
            // 
            this.rtbBody.Location = new System.Drawing.Point(16, 126);
            this.rtbBody.Name = "rtbBody";
            this.rtbBody.Size = new System.Drawing.Size(561, 223);
            this.rtbBody.TabIndex = 0;
            this.rtbBody.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(16, 378);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(240, 52);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Contact Us";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtbBody);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.groupbox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ContactForm";
            this.Size = new System.Drawing.Size(612, 452);
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
