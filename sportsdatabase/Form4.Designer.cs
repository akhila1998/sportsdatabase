namespace sportsdatabase
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sportInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stadiumInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tournamentDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topPlayersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.topPlayersToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Matura MT Script Capitals", 14F);
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sportInformationToolStripMenuItem,
            this.playerInformationToolStripMenuItem,
            this.stadiumInformationToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(184, 30);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // sportInformationToolStripMenuItem
            // 
            this.sportInformationToolStripMenuItem.Name = "sportInformationToolStripMenuItem";
            this.sportInformationToolStripMenuItem.Size = new System.Drawing.Size(247, 30);
            this.sportInformationToolStripMenuItem.Text = "sport information";
            this.sportInformationToolStripMenuItem.Click += new System.EventHandler(this.sportInformationToolStripMenuItem_Click);
            // 
            // playerInformationToolStripMenuItem
            // 
            this.playerInformationToolStripMenuItem.Name = "playerInformationToolStripMenuItem";
            this.playerInformationToolStripMenuItem.Size = new System.Drawing.Size(247, 30);
            this.playerInformationToolStripMenuItem.Text = "player information";
            this.playerInformationToolStripMenuItem.Click += new System.EventHandler(this.playerInformationToolStripMenuItem_Click);
            // 
            // stadiumInformationToolStripMenuItem
            // 
            this.stadiumInformationToolStripMenuItem.Name = "stadiumInformationToolStripMenuItem";
            this.stadiumInformationToolStripMenuItem.Size = new System.Drawing.Size(247, 30);
            this.stadiumInformationToolStripMenuItem.Text = "stadium information";
            this.stadiumInformationToolStripMenuItem.Click += new System.EventHandler(this.stadiumInformationToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sportToolStripMenuItem,
            this.playerToolStripMenuItem,
            this.tournamentDateToolStripMenuItem,
            this.nationToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(184, 30);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // sportToolStripMenuItem
            // 
            this.sportToolStripMenuItem.Name = "sportToolStripMenuItem";
            this.sportToolStripMenuItem.Size = new System.Drawing.Size(183, 30);
            this.sportToolStripMenuItem.Text = "Sport";
            this.sportToolStripMenuItem.Click += new System.EventHandler(this.sportToolStripMenuItem_Click);
            // 
            // playerToolStripMenuItem
            // 
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            this.playerToolStripMenuItem.Size = new System.Drawing.Size(183, 30);
            this.playerToolStripMenuItem.Text = "Player";
            this.playerToolStripMenuItem.Click += new System.EventHandler(this.playerToolStripMenuItem_Click);
            // 
            // tournamentDateToolStripMenuItem
            // 
            this.tournamentDateToolStripMenuItem.Name = "tournamentDateToolStripMenuItem";
            this.tournamentDateToolStripMenuItem.Size = new System.Drawing.Size(183, 30);
            this.tournamentDateToolStripMenuItem.Text = "Tournament";
            this.tournamentDateToolStripMenuItem.Click += new System.EventHandler(this.tournamentDateToolStripMenuItem_Click);
            // 
            // nationToolStripMenuItem
            // 
            this.nationToolStripMenuItem.Name = "nationToolStripMenuItem";
            this.nationToolStripMenuItem.Size = new System.Drawing.Size(183, 30);
            this.nationToolStripMenuItem.Text = "Nation";
            this.nationToolStripMenuItem.Click += new System.EventHandler(this.nationToolStripMenuItem_Click);
            // 
            // topPlayersToolStripMenuItem
            // 
            this.topPlayersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sportToolStripMenuItem1});
            this.topPlayersToolStripMenuItem.Name = "topPlayersToolStripMenuItem";
            this.topPlayersToolStripMenuItem.Size = new System.Drawing.Size(184, 30);
            this.topPlayersToolStripMenuItem.Text = "Top players";
            // 
            // sportToolStripMenuItem1
            // 
            this.sportToolStripMenuItem1.Name = "sportToolStripMenuItem1";
            this.sportToolStripMenuItem1.Size = new System.Drawing.Size(152, 30);
            this.sportToolStripMenuItem1.Text = "Sport";
            this.sportToolStripMenuItem1.Click += new System.EventHandler(this.sportToolStripMenuItem1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sportInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topPlayersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stadiumInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tournamentDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sportToolStripMenuItem1;
    }
}