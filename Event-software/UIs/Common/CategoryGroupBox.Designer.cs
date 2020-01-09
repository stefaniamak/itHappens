namespace itHappens.UIs.Common
{
    partial class CategoryGroupBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryGroupBox));
            this.categoryNameLabel = new System.Windows.Forms.Label();
            this.firstEventimagePictureBox = new System.Windows.Forms.PictureBox();
            this.secondEventimagePictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.categoryColorControl = new itHappens.UIs.Common.Carousel();
            this.eventImagesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.topPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.firstEventimagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondEventimagePictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.eventImagesTableLayoutPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryNameLabel
            // 
            this.categoryNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.categoryNameLabel.AutoSize = true;
            this.categoryNameLabel.BackColor = System.Drawing.Color.Silver;
            this.categoryNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryNameLabel.Location = new System.Drawing.Point(56, 11);
            this.categoryNameLabel.Name = "categoryNameLabel";
            this.categoryNameLabel.Size = new System.Drawing.Size(105, 29);
            this.categoryNameLabel.TabIndex = 0;
            this.categoryNameLabel.Text = "category";
            this.categoryNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.categoryNameLabel.Click += new System.EventHandler(this.categoryName_Click);
            // 
            // firstEventimagePictureBox
            // 
            this.firstEventimagePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstEventimagePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("firstEventimagePictureBox.BackgroundImage")));
            this.firstEventimagePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.firstEventimagePictureBox.Location = new System.Drawing.Point(3, 3);
            this.firstEventimagePictureBox.Name = "firstEventimagePictureBox";
            this.firstEventimagePictureBox.Size = new System.Drawing.Size(99, 123);
            this.firstEventimagePictureBox.TabIndex = 1;
            this.firstEventimagePictureBox.TabStop = false;
            // 
            // secondEventimagePictureBox
            // 
            this.secondEventimagePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.secondEventimagePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("secondEventimagePictureBox.BackgroundImage")));
            this.secondEventimagePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.secondEventimagePictureBox.Location = new System.Drawing.Point(108, 3);
            this.secondEventimagePictureBox.Name = "secondEventimagePictureBox";
            this.secondEventimagePictureBox.Size = new System.Drawing.Size(100, 123);
            this.secondEventimagePictureBox.TabIndex = 2;
            this.secondEventimagePictureBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.topPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.eventImagesTableLayoutPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.categoryColorControl, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.73171F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.2683F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(217, 223);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // categoryColorControl
            // 
            this.categoryColorControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryColorControl.AutoScroll = true;
            this.categoryColorControl.BackColor = System.Drawing.Color.DarkRed;
            this.categoryColorControl.Location = new System.Drawing.Point(0, 195);
            this.categoryColorControl.Margin = new System.Windows.Forms.Padding(0);
            this.categoryColorControl.Name = "categoryColorControl";
            this.categoryColorControl.Padding = new System.Windows.Forms.Padding(2);
            this.categoryColorControl.Size = new System.Drawing.Size(217, 28);
            this.categoryColorControl.TabIndex = 2;
            // 
            // eventImagesTableLayoutPanel
            // 
            this.eventImagesTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventImagesTableLayoutPanel.BackColor = System.Drawing.Color.Silver;
            this.eventImagesTableLayoutPanel.ColumnCount = 2;
            this.eventImagesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.eventImagesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.eventImagesTableLayoutPanel.Controls.Add(this.firstEventimagePictureBox, 0, 0);
            this.eventImagesTableLayoutPanel.Controls.Add(this.secondEventimagePictureBox, 1, 0);
            this.eventImagesTableLayoutPanel.Location = new System.Drawing.Point(3, 63);
            this.eventImagesTableLayoutPanel.Name = "eventImagesTableLayoutPanel";
            this.eventImagesTableLayoutPanel.RowCount = 1;
            this.eventImagesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.eventImagesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.eventImagesTableLayoutPanel.Size = new System.Drawing.Size(211, 129);
            this.eventImagesTableLayoutPanel.TabIndex = 1;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.categoryNameLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topPanel.Location = new System.Drawing.Point(3, 3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(211, 54);
            this.topPanel.TabIndex = 3;
            // 
            // CategoryGroupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.Name = "CategoryGroupBox";
            this.Size = new System.Drawing.Size(217, 223);
            ((System.ComponentModel.ISupportInitialize)(this.firstEventimagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondEventimagePictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.eventImagesTableLayoutPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label categoryNameLabel;
        private System.Windows.Forms.PictureBox firstEventimagePictureBox;
        private System.Windows.Forms.PictureBox secondEventimagePictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel eventImagesTableLayoutPanel;
        private Carousel categoryColorControl;
        private System.Windows.Forms.Panel topPanel;
    }
}
