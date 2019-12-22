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
            this.categoryColorControl = new itHappens.UIs.Common.Carousel();
            this.eventTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // eventTableLayout
            // 
            this.eventTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventTableLayout.AutoSize = true;
            this.eventTableLayout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.eventTableLayout.ColumnCount = 1;
            this.eventTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.eventTableLayout.Controls.Add(this.eventPictureBox, 0, 0);
            this.eventTableLayout.Controls.Add(this.categoryColorControl, 0, 1);
            this.eventTableLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.eventTableLayout.Location = new System.Drawing.Point(1, 1);
            this.eventTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.eventTableLayout.Name = "eventTableLayout";
            this.eventTableLayout.RowCount = 2;
            this.eventTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.eventTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.eventTableLayout.Size = new System.Drawing.Size(173, 273);
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
            this.eventPictureBox.Size = new System.Drawing.Size(173, 248);
            this.eventPictureBox.TabIndex = 0;
            this.eventPictureBox.TabStop = false;
            // 
            // categoryColorControl
            // 
            this.categoryColorControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryColorControl.AutoScroll = true;
            this.categoryColorControl.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.categoryColorControl.Location = new System.Drawing.Point(0, 248);
            this.categoryColorControl.Margin = new System.Windows.Forms.Padding(0);
            this.categoryColorControl.Name = "categoryColorControl";
            this.categoryColorControl.Padding = new System.Windows.Forms.Padding(2);
            this.categoryColorControl.Size = new System.Drawing.Size(173, 25);
            this.categoryColorControl.TabIndex = 1;
            // 
            // EventMiniView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.Controls.Add(this.eventTableLayout);
            this.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.Name = "EventMiniView";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(175, 275);
            this.MouseHover += new System.EventHandler(this.EventMiniView_MouseHover);
            this.eventTableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel eventTableLayout;
        private System.Windows.Forms.PictureBox eventPictureBox;
        private Common.Carousel categoryColorControl;
    }
}
