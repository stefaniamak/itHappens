namespace itHappens.UIs.Common
{
    partial class MainSplitForm
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
            this.leftSplitContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.CreateEvent = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainInterfaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stefaniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valentinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.madeForYouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stefaniaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightSplitContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.leftSplitContainer)).BeginInit();
            this.leftSplitContainer.Panel1.SuspendLayout();
            this.leftSplitContainer.Panel2.SuspendLayout();
            this.leftSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightSplitContainer)).BeginInit();
            this.rightSplitContainer.Panel2.SuspendLayout();
            this.rightSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftSplitContainer
            // 
            this.leftSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.leftSplitContainer.Location = new System.Drawing.Point(2, 3);
            this.leftSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.leftSplitContainer.Name = "leftSplitContainer";
            // 
            // leftSplitContainer.Panel1
            // 
            this.leftSplitContainer.Panel1.BackColor = System.Drawing.Color.Gold;
            this.leftSplitContainer.Panel1.Controls.Add(this.splitContainer2);
            this.leftSplitContainer.Panel1.Controls.Add(this.menuStrip1);
            // 
            // leftSplitContainer.Panel2
            // 
            this.leftSplitContainer.Panel2.Controls.Add(this.rightSplitContainer);
            this.leftSplitContainer.Size = new System.Drawing.Size(899, 556);
            this.leftSplitContainer.SplitterDistance = 157;
            this.leftSplitContainer.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 24);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.CreateEvent);
            this.splitContainer2.Size = new System.Drawing.Size(157, 532);
            this.splitContainer2.SplitterDistance = 487;
            this.splitContainer2.TabIndex = 2;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.AutoScroll = true;
            this.splitContainer3.Panel1.BackColor = System.Drawing.Color.HotPink;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.AutoScroll = true;
            this.splitContainer3.Size = new System.Drawing.Size(157, 487);
            this.splitContainer3.SplitterDistance = 169;
            this.splitContainer3.TabIndex = 0;
            // 
            // CreateEvent
            // 
            this.CreateEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateEvent.Location = new System.Drawing.Point(0, 0);
            this.CreateEvent.Name = "CreateEvent";
            this.CreateEvent.Size = new System.Drawing.Size(157, 41);
            this.CreateEvent.TabIndex = 0;
            this.CreateEvent.Text = "Create Event";
            this.CreateEvent.UseVisualStyleBackColor = true;
            this.CreateEvent.Click += new System.EventHandler(this.CreateEvent_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainInterfaceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(157, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainInterfaceToolStripMenuItem
            // 
            this.mainInterfaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stefaniaToolStripMenuItem,
            this.annaToolStripMenuItem,
            this.valentinaToolStripMenuItem,
            this.stefaniaToolStripMenuItem1});
            this.mainInterfaceToolStripMenuItem.Name = "mainInterfaceToolStripMenuItem";
            this.mainInterfaceToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.mainInterfaceToolStripMenuItem.Text = "Interfaces";
            // 
            // stefaniaToolStripMenuItem
            // 
            this.stefaniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.eventsProfileToolStripMenuItem});
            this.stefaniaToolStripMenuItem.Name = "stefaniaToolStripMenuItem";
            this.stefaniaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.stefaniaToolStripMenuItem.Text = "Andreas";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.mainToolStripMenuItem.Text = "User\'s Profile";
            this.mainToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.searchToolStripMenuItem.Text = "Venue\'s Profile";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // eventsProfileToolStripMenuItem
            // 
            this.eventsProfileToolStripMenuItem.Name = "eventsProfileToolStripMenuItem";
            this.eventsProfileToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.eventsProfileToolStripMenuItem.Text = "Event\'s Profile";
            this.eventsProfileToolStripMenuItem.Click += new System.EventHandler(this.eventsProfileToolStripMenuItem_Click);
            // 
            // annaToolStripMenuItem
            // 
            this.annaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem,
            this.signUpToolStripMenuItem,
            this.createEventToolStripMenuItem});
            this.annaToolStripMenuItem.Name = "annaToolStripMenuItem";
            this.annaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.annaToolStripMenuItem.Text = "Anna";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.logInToolStripMenuItem.Text = "Log in";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // signUpToolStripMenuItem
            // 
            this.signUpToolStripMenuItem.Name = "signUpToolStripMenuItem";
            this.signUpToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.signUpToolStripMenuItem.Text = "Sign up";
            this.signUpToolStripMenuItem.Click += new System.EventHandler(this.signUpToolStripMenuItem_Click);
            // 
            // createEventToolStripMenuItem
            // 
            this.createEventToolStripMenuItem.Name = "createEventToolStripMenuItem";
            this.createEventToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.createEventToolStripMenuItem.Text = "Create event";
            this.createEventToolStripMenuItem.Click += new System.EventHandler(this.createEventToolStripMenuItem_Click);
            // 
            // valentinaToolStripMenuItem
            // 
            this.valentinaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listToolStripMenuItem,
            this.madeForYouToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.valentinaToolStripMenuItem.Name = "valentinaToolStripMenuItem";
            this.valentinaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.valentinaToolStripMenuItem.Text = "Valentina";
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // madeForYouToolStripMenuItem
            // 
            this.madeForYouToolStripMenuItem.Name = "madeForYouToolStripMenuItem";
            this.madeForYouToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.madeForYouToolStripMenuItem.Text = "Made for you";
            this.madeForYouToolStripMenuItem.Click += new System.EventHandler(this.madeForYouToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // stefaniaToolStripMenuItem1
            // 
            this.stefaniaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainPageToolStripMenuItem,
            this.searchPageToolStripMenuItem});
            this.stefaniaToolStripMenuItem1.Name = "stefaniaToolStripMenuItem1";
            this.stefaniaToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.stefaniaToolStripMenuItem1.Text = "Stefania";
            // 
            // mainPageToolStripMenuItem
            // 
            this.mainPageToolStripMenuItem.Name = "mainPageToolStripMenuItem";
            this.mainPageToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.mainPageToolStripMenuItem.Text = "Main page";
            this.mainPageToolStripMenuItem.Click += new System.EventHandler(this.mainPageToolStripMenuItem_Click);
            // 
            // searchPageToolStripMenuItem
            // 
            this.searchPageToolStripMenuItem.Name = "searchPageToolStripMenuItem";
            this.searchPageToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.searchPageToolStripMenuItem.Text = "Search page";
            this.searchPageToolStripMenuItem.Click += new System.EventHandler(this.searchPageToolStripMenuItem_Click);
            // 
            // rightSplitContainer
            // 
            this.rightSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.rightSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.rightSplitContainer.Name = "rightSplitContainer";
            // 
            // rightSplitContainer.Panel1
            // 
            this.rightSplitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // rightSplitContainer.Panel2
            // 
            this.rightSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rightSplitContainer.Panel2.Controls.Add(this.splitContainer1);
            this.rightSplitContainer.Size = new System.Drawing.Size(738, 556);
            this.rightSplitContainer.SplitterDistance = 536;
            this.rightSplitContainer.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.Coral;
            this.splitContainer1.Location = new System.Drawing.Point(-6, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Cyan;
            this.splitContainer1.Size = new System.Drawing.Size(204, 664);
            this.splitContainer1.SplitterDistance = 218;
            this.splitContainer1.TabIndex = 6;
            // 
            // MainSplitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 562);
            this.Controls.Add(this.leftSplitContainer);
            this.Name = "MainSplitForm";
            this.Text = "itHappened";
            this.Load += new System.EventHandler(this.TestSplitForm_Load);
            this.leftSplitContainer.Panel1.ResumeLayout(false);
            this.leftSplitContainer.Panel1.PerformLayout();
            this.leftSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leftSplitContainer)).EndInit();
            this.leftSplitContainer.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.rightSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rightSplitContainer)).EndInit();
            this.rightSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer leftSplitContainer;
        private System.Windows.Forms.SplitContainer rightSplitContainer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainInterfaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stefaniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valentinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem madeForYouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stefaniaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mainPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchPageToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button CreateEvent;
    }
}