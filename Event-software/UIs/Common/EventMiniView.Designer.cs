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
            this.categoryColorPanel = new System.Windows.Forms.Panel();
            this.hoverOverPanel = new System.Windows.Forms.Panel();

            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.eventTitleLabel = new System.Windows.Forms.Label();
            this.detailsButton = new System.Windows.Forms.Button();

            this.intrestedListOvalPictureBox = new itHappens.UIs.Common.OvalPictureBox();
            this.goingListOvalPictureBox = new itHappens.UIs.Common.OvalPictureBox();
            this.eventPictureBox = new System.Windows.Forms.PictureBox();
            this.eventTableLayout.SuspendLayout();
            this.hoverOverPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intrestedListOvalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goingListOvalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventPictureBox)).BeginInit();
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
            this.eventTableLayout.Location = new System.Drawing.Point(1, 1);
            this.eventTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.eventTableLayout.Name = "eventTableLayout";
            this.eventTableLayout.RowCount = 2;
            this.eventTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.eventTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.eventTableLayout.Size = new System.Drawing.Size(144, 221);
            this.eventTableLayout.TabIndex = 0;
            this.eventTableLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.eventTableLayout_Paint);
            //
            // categoryColorPanel
            //
            this.categoryColorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryColorPanel.Location = new System.Drawing.Point(3, 199);
            this.categoryColorPanel.Name = "categoryColorPanel";
            this.categoryColorPanel.Size = new System.Drawing.Size(138, 19);
            this.categoryColorPanel.TabIndex = 1;
            //
            // hoverOverPanel
            //
            this.hoverOverPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hoverOverPanel.BackColor = System.Drawing.Color.Silver;
            this.hoverOverPanel.Controls.Add(this.flowLayoutPanel1);
            this.hoverOverPanel.Controls.Add(this.intrestedListOvalPictureBox);
            this.hoverOverPanel.Controls.Add(this.goingListOvalPictureBox);
            this.hoverOverPanel.Controls.Add(this.detailsButton);
            this.hoverOverPanel.Location = new System.Drawing.Point(0, 0);
            this.hoverOverPanel.Name = "hoverOverPanel";
            this.hoverOverPanel.Size = new System.Drawing.Size(146, 197);
            this.hoverOverPanel.TabIndex = 0;
            this.hoverOverPanel.MouseLeave += new System.EventHandler(this.hoverOverPanel_MouseLeave);
            this.hoverOverPanel.MouseHover += new System.EventHandler(this.hoverOverPanel_MouseHover);
            //
            // flowLayoutPanel1
            //
            this.flowLayoutPanel1.Controls.Add(this.eventTitleLabel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(18, 8);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(183, 82);
            this.flowLayoutPanel1.TabIndex = 3;
            //
            // eventTitleLabel
            //
            this.eventTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.eventTitleLabel.AutoSize = true;
            this.eventTitleLabel.Location = new System.Drawing.Point(4, 0);
            this.eventTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eventTitleLabel.Name = "eventTitleLabel";
            this.eventTitleLabel.Size = new System.Drawing.Size(0, 20);
            this.eventTitleLabel.TabIndex = 0;
            // detailsButton
            //
            this.detailsButton.Location = new System.Drawing.Point(12, 64);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(122, 36);
            this.detailsButton.TabIndex = 0;
            this.detailsButton.Text = "DETAILS";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            this.detailsButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.detailsButton_MouseClick);
            // 
            // intrestedListOvalPictureBox
            //
            this.intrestedListOvalPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.intrestedListOvalPictureBox.BackgroundImage = global::itHappens.Properties.Resources.plus_yellow;
            this.intrestedListOvalPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.intrestedListOvalPictureBox.Location = new System.Drawing.Point(10, 106);
            this.intrestedListOvalPictureBox.Name = "intrestedListOvalPictureBox";
            this.intrestedListOvalPictureBox.Size = new System.Drawing.Size(65, 64);
            this.intrestedListOvalPictureBox.TabIndex = 1;
            this.intrestedListOvalPictureBox.TabStop = false;
            this.intrestedListOvalPictureBox.Click += new System.EventHandler(this.intrestedListOvalPictureBox_Click);
            this.intrestedListOvalPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.intrestedListOvalPictureBox_MouseClick);
            //
            // goingListOvalPictureBox
            //
            this.goingListOvalPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.goingListOvalPictureBox.BackgroundImage = global::itHappens.Properties.Resources.check_lime;
            this.goingListOvalPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.goingListOvalPictureBox.Location = new System.Drawing.Point(73, 106);
            this.goingListOvalPictureBox.Name = "goingListOvalPictureBox";
            this.goingListOvalPictureBox.Size = new System.Drawing.Size(62, 64);
            this.goingListOvalPictureBox.TabIndex = 2;
            this.goingListOvalPictureBox.TabStop = false;
            this.goingListOvalPictureBox.Click += new System.EventHandler(this.goingListOvalPictureBox_Click);
            this.goingListOvalPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.goingListOvalPictureBox_MouseClick);
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
            this.eventPictureBox.Size = new System.Drawing.Size(144, 196);
            this.eventPictureBox.TabIndex = 0;
            this.eventPictureBox.TabStop = false;
            this.eventPictureBox.MouseEnter += new System.EventHandler(this.eventPictureBox_MouseEnter);
            //
            // EventMiniView
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.hoverOverPanel);
            this.Controls.Add(this.eventTableLayout);
            this.Margin = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.Name = "EventMiniView";
            this.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Size = new System.Drawing.Size(146, 223);
            this.MouseHover += new System.EventHandler(this.EventMiniView_MouseHover);
            this.eventTableLayout.ResumeLayout(false);
            this.hoverOverPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intrestedListOvalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goingListOvalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventPictureBox)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label eventTitleLabel;
    }
}
