namespace itHappens.UIs
{
    partial class SampleForm
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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.middlePanel = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 615);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainInterfaceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(184, 24);
            this.menuStrip1.TabIndex = 0;
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
            this.mainInterfaceToolStripMenuItem.Click += new System.EventHandler(this.mainInterfaceToolStripMenuItem_Click);
            // 
            // stefaniaToolStripMenuItem
            // 
            this.stefaniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.eventsProfileToolStripMenuItem});
            this.stefaniaToolStripMenuItem.Name = "stefaniaToolStripMenuItem";
            this.stefaniaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stefaniaToolStripMenuItem.Text = "Andreas";
            this.stefaniaToolStripMenuItem.Click += new System.EventHandler(this.stefaniaToolStripMenuItem_Click);
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mainToolStripMenuItem.Text = "User\'s Profile";
            this.mainToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchToolStripMenuItem.Text = "Venue\'s Profile";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // eventsProfileToolStripMenuItem
            // 
            this.eventsProfileToolStripMenuItem.Name = "eventsProfileToolStripMenuItem";
            this.eventsProfileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.annaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.signUpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.signUpToolStripMenuItem.Text = "Sign up";
            this.signUpToolStripMenuItem.Click += new System.EventHandler(this.signUpToolStripMenuItem_Click);
            // 
            // createEventToolStripMenuItem
            // 
            this.createEventToolStripMenuItem.Name = "createEventToolStripMenuItem";
            this.createEventToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.valentinaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.valentinaToolStripMenuItem.Text = "Valentina";
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // madeForYouToolStripMenuItem
            // 
            this.madeForYouToolStripMenuItem.Name = "madeForYouToolStripMenuItem";
            this.madeForYouToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.madeForYouToolStripMenuItem.Text = "Made for you";
            this.madeForYouToolStripMenuItem.Click += new System.EventHandler(this.madeForYouToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // stefaniaToolStripMenuItem1
            // 
            this.stefaniaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainPageToolStripMenuItem,
            this.searchPageToolStripMenuItem});
            this.stefaniaToolStripMenuItem1.Name = "stefaniaToolStripMenuItem1";
            this.stefaniaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
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
            this.searchPageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchPageToolStripMenuItem.Text = "Search page";
            this.searchPageToolStripMenuItem.Click += new System.EventHandler(this.searchPageToolStripMenuItem_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 615);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Coral;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitContainer1.Location = new System.Drawing.Point(889, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(150, 615);
            this.splitContainer1.SplitterDistance = 166;
            this.splitContainer1.TabIndex = 5;
            // 
            // middlePanel
            // 
            this.middlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.middlePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.middlePanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.middlePanel.Location = new System.Drawing.Point(180, 0);
            this.middlePanel.Name = "middlePanel";
            this.middlePanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.middlePanel.Size = new System.Drawing.Size(693, 615);
            this.middlePanel.TabIndex = 4;
            this.middlePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPage_Paint_1);
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(879, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(10, 615);
            this.splitter2.TabIndex = 6;
            this.splitter2.TabStop = false;
            this.splitter2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter2_SplitterMoved);
            // 
            // SampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 615);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.middlePanel);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SampleForm";
            this.Text = "SampleForm";
            this.Load += new System.EventHandler(this.SampleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel middlePanel;
        private System.Windows.Forms.Splitter splitter2;
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
    }
}