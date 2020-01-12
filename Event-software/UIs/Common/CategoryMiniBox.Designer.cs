namespace itHappens.UIs.Common
{
    partial class CategoryMiniBox
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
            this.categoryLabel = new System.Windows.Forms.Label();
            this.backgroundColorPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.upperPanel = new System.Windows.Forms.Panel();
            this.categoryStrikeoutLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.upperPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryLabel
            // 
            this.categoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.categoryLabel.Location = new System.Drawing.Point(0, 0);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(119, 40);
            this.categoryLabel.TabIndex = 0;
            this.categoryLabel.Text = "CATEGORY";
            this.categoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.categoryLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.categoryLabel_MouseClick);
            // 
            // backgroundColorPanel
            // 
            this.backgroundColorPanel.AutoSize = true;
            this.backgroundColorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundColorPanel.Location = new System.Drawing.Point(0, 40);
            this.backgroundColorPanel.Margin = new System.Windows.Forms.Padding(0);
            this.backgroundColorPanel.Name = "backgroundColorPanel";
            this.backgroundColorPanel.Size = new System.Drawing.Size(119, 12);
            this.backgroundColorPanel.TabIndex = 1;
            this.backgroundColorPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backgroundColorPanel_MouseClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.backgroundColorPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.upperPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.125F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.875F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(119, 52);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseClick);
            // 
            // upperPanel
            // 
            this.upperPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.upperPanel.Controls.Add(this.categoryLabel);
            this.upperPanel.Controls.Add(this.categoryStrikeoutLabel);
            this.upperPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upperPanel.Location = new System.Drawing.Point(0, 0);
            this.upperPanel.Margin = new System.Windows.Forms.Padding(0);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(119, 40);
            this.upperPanel.TabIndex = 2;
            this.upperPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // categoryStrikeoutLabel
            // 
            this.categoryStrikeoutLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryStrikeoutLabel.Font = new System.Drawing.Font("Century Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryStrikeoutLabel.ForeColor = System.Drawing.Color.Gray;
            this.categoryStrikeoutLabel.Location = new System.Drawing.Point(0, 0);
            this.categoryStrikeoutLabel.Margin = new System.Windows.Forms.Padding(0);
            this.categoryStrikeoutLabel.Name = "categoryStrikeoutLabel";
            this.categoryStrikeoutLabel.Size = new System.Drawing.Size(119, 40);
            this.categoryStrikeoutLabel.TabIndex = 1;
            this.categoryStrikeoutLabel.Text = "CATEGORY";
            this.categoryStrikeoutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.categoryStrikeoutLabel.Visible = false;
            this.categoryStrikeoutLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.categoryStrikeoutLabel_MouseClick);
            // 
            // CategoryMiniBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.Name = "CategoryMiniBox";
            this.Size = new System.Drawing.Size(119, 52);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CategoryMiniBox_MouseClick);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.upperPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Panel backgroundColorPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel upperPanel;
        private System.Windows.Forms.Label categoryStrikeoutLabel;
    }
}
