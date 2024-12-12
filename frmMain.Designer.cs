namespace Library
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnuMain = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuAuthor = new ToolStripMenuItem();
            mnuBookEntry = new ToolStripMenuItem();
            mnuBookCategory = new ToolStripMenuItem();
            mnuMembers = new ToolStripMenuItem();
            mnuMemberTypes = new ToolStripMenuItem();
            mnuUser = new ToolStripMenuItem();
            mnuUserRoles = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            mnuDatabaseSetup = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            mnuExit = new ToolStripMenuItem();
            mnuRental = new ToolStripMenuItem();
            rentalManagementToolStripMenuItem = new ToolStripMenuItem();
            mnuMain.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.ImageScalingSize = new Size(20, 20);
            mnuMain.Items.AddRange(new ToolStripItem[] { mnuFile, mnuRental });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(800, 28);
            mnuMain.TabIndex = 0;
            mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuAuthor, mnuBookEntry, mnuBookCategory, mnuMembers, mnuMemberTypes, mnuUser, mnuUserRoles, toolStripMenuItem1, mnuDatabaseSetup, toolStripMenuItem2, mnuExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(46, 24);
            mnuFile.Text = "File";
            // 
            // mnuAuthor
            // 
            mnuAuthor.Name = "mnuAuthor";
            mnuAuthor.Size = new Size(224, 26);
            mnuAuthor.Text = "Author Entry";
            mnuAuthor.Click += mnuAuthor_Click;
            // 
            // mnuBookEntry
            // 
            mnuBookEntry.Name = "mnuBookEntry";
            mnuBookEntry.Size = new Size(224, 26);
            mnuBookEntry.Text = "Book Entry";
            mnuBookEntry.Click += mnuBookEntry_Click;
            // 
            // mnuBookCategory
            // 
            mnuBookCategory.Name = "mnuBookCategory";
            mnuBookCategory.Size = new Size(224, 26);
            mnuBookCategory.Text = "Book Category";
            mnuBookCategory.Click += mnuBookCategory_Click;
            // 
            // mnuMembers
            // 
            mnuMembers.Name = "mnuMembers";
            mnuMembers.Size = new Size(224, 26);
            mnuMembers.Text = "Members";
            mnuMembers.Click += mnuMembers_Click;
            // 
            // mnuMemberTypes
            // 
            mnuMemberTypes.Name = "mnuMemberTypes";
            mnuMemberTypes.Size = new Size(224, 26);
            mnuMemberTypes.Text = "Member Types";
            mnuMemberTypes.Click += mnuMemberTypes_Click;
            // 
            // mnuUser
            // 
            mnuUser.Name = "mnuUser";
            mnuUser.Size = new Size(224, 26);
            mnuUser.Text = "User";
            mnuUser.Click += mnuUser_Click;
            // 
            // mnuUserRoles
            // 
            mnuUserRoles.Name = "mnuUserRoles";
            mnuUserRoles.Size = new Size(224, 26);
            mnuUserRoles.Text = "User Roles";
            mnuUserRoles.Click += mnuUserRoles_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(221, 6);
            // 
            // mnuDatabaseSetup
            // 
            mnuDatabaseSetup.Name = "mnuDatabaseSetup";
            mnuDatabaseSetup.Size = new Size(224, 26);
            mnuDatabaseSetup.Text = "Database Setup";
            mnuDatabaseSetup.Click += mnuDatabaseSetup_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(221, 6);
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(224, 26);
            mnuExit.Text = "Exit";
            mnuExit.Click += mnuExit_Click;
            // 
            // mnuRental
            // 
            mnuRental.DropDownItems.AddRange(new ToolStripItem[] { rentalManagementToolStripMenuItem });
            mnuRental.Name = "mnuRental";
            mnuRental.Size = new Size(65, 24);
            mnuRental.Text = "Rental";
            // 
            // rentalManagementToolStripMenuItem
            // 
            rentalManagementToolStripMenuItem.Name = "rentalManagementToolStripMenuItem";
            rentalManagementToolStripMenuItem.Size = new Size(226, 26);
            rentalManagementToolStripMenuItem.Text = "Rental Management";
            rentalManagementToolStripMenuItem.Click += rentalManagementToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mnuMain);
            MainMenuStrip = mnuMain;
            Name = "frmMain";
            Text = "Library Management System";
            WindowState = FormWindowState.Maximized;
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuAuthor;
        private ToolStripMenuItem mnuBookEntry;
        private ToolStripMenuItem mnuBookCategory;
        private ToolStripMenuItem mnuMembers;
        private ToolStripMenuItem mnuMemberTypes;
        private ToolStripMenuItem mnuUser;
        private ToolStripMenuItem mnuUserRoles;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem mnuDatabaseSetup;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuRental;
        private ToolStripMenuItem rentalManagementToolStripMenuItem;
    }
}