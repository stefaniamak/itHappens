namespace itHappens.UIs.Sidebars.Lists
{
    partial class CreateListPage
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
            this.nameYourNewListLabel = new System.Windows.Forms.Label();
            this.newListLitleLabel = new System.Windows.Forms.TextBox();
            this.createNewListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameYourNewListLabel
            // 
            this.nameYourNewListLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameYourNewListLabel.AutoSize = true;
            this.nameYourNewListLabel.Location = new System.Drawing.Point(7, 8);
            this.nameYourNewListLabel.Name = "nameYourNewListLabel";
            this.nameYourNewListLabel.Size = new System.Drawing.Size(115, 16);
            this.nameYourNewListLabel.TabIndex = 0;
            this.nameYourNewListLabel.Text = "Name your new List:";
            this.nameYourNewListLabel.Click += new System.EventHandler(this.nameYourNewListLabel_Click);
            // 
            // newListLitleLabel
            // 
            this.newListLitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.newListLitleLabel.Location = new System.Drawing.Point(10, 28);
            this.newListLitleLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newListLitleLabel.Name = "newListLitleLabel";
            this.newListLitleLabel.Size = new System.Drawing.Size(116, 21);
            this.newListLitleLabel.TabIndex = 1;
            this.newListLitleLabel.TextChanged += new System.EventHandler(this.newListLitleLabel_TextChanged);
            // 
            // createNewListButton
            // 
            this.createNewListButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.createNewListButton.Location = new System.Drawing.Point(10, 57);
            this.createNewListButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createNewListButton.Name = "createNewListButton";
            this.createNewListButton.Size = new System.Drawing.Size(117, 21);
            this.createNewListButton.TabIndex = 2;
            this.createNewListButton.Text = "CREATE";
            this.createNewListButton.UseVisualStyleBackColor = true;
            this.createNewListButton.Click += new System.EventHandler(this.createNewListButton_Click);
            // 
            // CreateListPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.nameYourNewListLabel);
            this.Controls.Add(this.newListLitleLabel);
            this.Controls.Add(this.createNewListButton);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreateListPage";
            this.Size = new System.Drawing.Size(136, 88);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameYourNewListLabel;
        private System.Windows.Forms.TextBox newListLitleLabel;
        private System.Windows.Forms.Button createNewListButton;
    }
}
