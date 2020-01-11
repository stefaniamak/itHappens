namespace itHappens.UIs.Common
{
    partial class EventMiniView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventMiniView));
            this.eventTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.eventPictureBox = new System.Windows.Forms.PictureBox();
            this.categoryColorPanel = new System.Windows.Forms.Panel();
            this.hoverOverPanel = new System.Windows.Forms.Panel();
            this.intrestedListOvalPictureBox = new itHappens.UIs.Common.OvalPictureBox();
            this.goingListOvalPictureBox = new itHappens.UIs.Common.OvalPictureBox();
            this.detailsButton = new System.Windows.Forms.Button();
            this.eventTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventPictureBox)).BeginInit();
            this.hoverOverPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intrestedListOvalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goingListOvalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // eventTableLayout
            // 
            this.eventTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventTableLayout.BackColor = System.Drawing.SystemColors.Control;
            this.eventTableLayout.ColumnCount = 1;
            this.eventTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.eventTableLayout.Controls.Add(this.eventPictureBox, 0, 0);
            this.eventTableLayout.Controls.Add(this.categoryColorPanel, 0, 1);
            this.eventTableLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.eventTableLayout.Location = new System.Drawing.Point(2, 2);
            this.eventTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.eventTableLayout.Name = "eventTableLayout";
            this.eventTableLayout.RowCount = 2;
            this.eventTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.eventTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.eventTableLayout.Size = new System.Drawing.Size(216, 340);
            this.eventTableLayout.TabIndex = 0;
            this.eventTableLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.eventTableLayout_Paint);
            // 
            // eventPictureBox
            // 
            this.eventPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eventPictureBox.BackgroundImage")));
            this.eventPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eventPictureBox.Location = new System.Drawing.Point(0, 0);
            this.eventPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.eventPictureBox.Name = "eventPictureBox";
            this.eventPictureBox.Size = new System.Drawing.Size(216, 302);
            this.eventPictureBox.TabIndex = 0;
            this.eventPictureBox.TabStop = false;
            this.eventPictureBox.MouseEnter += new System.EventHandler(this.eventPictureBox_MouseEnter);
            // 
            // categoryColorPanel
            // 
            this.categoryColorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryColorPanel.Location = new System.Drawing.Point(4, 307);
            this.categoryColorPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.categoryColorPanel.Name = "categoryColorPanel";
            this.categoryColorPanel.Size = new System.Drawing.Size(208, 28);
            this.categoryColorPanel.TabIndex = 1;
            // 
            // hoverOverPanel
            // 
            this.hoverOverPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hoverOverPanel.BackColor = System.Drawing.Color.Silver;
            this.hoverOverPanel.Controls.Add(this.intrestedListOvalPictureBox);
            this.hoverOverPanel.Controls.Add(this.goingListOvalPictureBox);
            this.hoverOverPanel.Controls.Add(this.detailsButton);
            this.hoverOverPanel.Location = new System.Drawing.Point(0, 0);
            this.hoverOverPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hoverOverPanel.Name = "hoverOverPanel";
            this.hoverOverPanel.Size = new System.Drawing.Size(219, 303);
            this.hoverOverPanel.TabIndex = 0;
            this.hoverOverPanel.MouseLeave += new System.EventHandler(this.hoverOverPanel_MouseLeave);
            this.hoverOverPanel.MouseHover += new System.EventHandler(this.hoverOverPanel_MouseHover);
            // 
            // intrestedListOvalPictureBox
            // 
            this.intrestedListOvalPictureBox.BackColor = System.Drawing.Color.Yellow;
            this.intrestedListOvalPictureBox.Location = new System.Drawing.Point(18, 188);
            this.intrestedListOvalPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.intrestedListOvalPictureBox.Name = "intrestedListOvalPictureBox";
            this.intrestedListOvalPictureBox.Size = new System.Drawing.Size(76, 74);
            this.intrestedListOvalPictureBox.TabIndex = 1;
            this.intrestedListOvalPictureBox.TabStop = false;
            this.intrestedListOvalPictureBox.Click += new System.EventHandler(this.intrestedListOvalPictureBox_Click);
            this.intrestedListOvalPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.intrestedListOvalPictureBox_MouseClick);
            // 
            // goingListOvalPictureBox
            // 
            this.goingListOvalPictureBox.BackColor = System.Drawing.Color.Lime;
            this.goingListOvalPictureBox.Location = new System.Drawing.Point(124, 188);
            this.goingListOvalPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.goingListOvalPictureBox.Name = "goingListOvalPictureBox";
            this.goingListOvalPictureBox.Size = new System.Drawing.Size(76, 74);
            this.goingListOvalPictureBox.TabIndex = 2;
            this.goingListOvalPictureBox.TabStop = false;
            this.goingListOvalPictureBox.Click += new System.EventHandler(this.goingListOvalPictureBox_Click);
            this.goingListOvalPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.goingListOvalPictureBox_MouseClick);
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(18, 98);
            this.detailsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(183, 55);
            this.detailsButton.TabIndex = 0;
            this.detailsButton.Text = "DETAILS";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            this.detailsButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.detailsButton_MouseClick);
            // 
            // EventMiniView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.hoverOverPanel);
            this.Controls.Add(this.eventTableLayout);
            this.Margin = new System.Windows.Forms.Padding(15, 3, 0, 3);
            this.Name = "EventMiniView";
            this.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Size = new System.Drawing.Size(219, 343);
            this.MouseHover += new System.EventHandler(this.EventMiniView_MouseHover);
            this.eventTableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventPictureBox)).EndInit();
            this.hoverOverPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.intrestedListOvalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goingListOvalPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel eventTableLayout;
        private System.Windows.Forms.PictureBox eventPictureBox;
        private System.Windows.Forms.Panel categoryColorPanel;
        private System.Windows.Forms.Panel hoverOverPanel;
        private System.Windows.Forms.Button detailsButton;
        private OvalPictureBox intrestedListOvalPictureBox;
        private OvalPictureBox goingListOvalPictureBox;
    }
}
