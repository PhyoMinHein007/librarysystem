namespace Library.Forms
{
    partial class frmUser
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
            label1 = new Label();
            txtUserID = new TextBox();
            label2 = new Label();
            txtUserName = new TextBox();
            label3 = new Label();
            btnClose = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnSave = new Button();
            btnSearchUserName = new Button();
            btnSearchUserID = new Button();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripLabel2 = new ToolStripLabel();
            cboUserRole = new ComboBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 52);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "UserID";
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(133, 48);
            txtUserID.Margin = new Padding(3, 4, 3, 4);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(270, 27);
            txtUserID.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 87);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 2;
            label2.Text = "UserName";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(133, 83);
            txtUserName.Margin = new Padding(3, 4, 3, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(270, 27);
            txtUserName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 157);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 4;
            label3.Text = "UserRole";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(357, 242);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(86, 31);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(264, 242);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(172, 242);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 31);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(79, 242);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 31);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnSearchUserName
            // 
            btnSearchUserName.Location = new Point(424, 79);
            btnSearchUserName.Margin = new Padding(3, 4, 3, 4);
            btnSearchUserName.Name = "btnSearchUserName";
            btnSearchUserName.Size = new Size(86, 31);
            btnSearchUserName.TabIndex = 3;
            btnSearchUserName.Text = "Search";
            btnSearchUserName.UseVisualStyleBackColor = true;
            btnSearchUserName.Click += btnSearchByName_Click;
            // 
            // btnSearchUserID
            // 
            btnSearchUserID.Location = new Point(424, 47);
            btnSearchUserID.Margin = new Padding(3, 4, 3, 4);
            btnSearchUserID.Name = "btnSearchUserID";
            btnSearchUserID.Size = new Size(86, 31);
            btnSearchUserID.TabIndex = 1;
            btnSearchUserID.Text = "Search";
            btnSearchUserID.UseVisualStyleBackColor = true;
            btnSearchUserID.Click += btnSearchById_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripLabel2 });
            toolStrip1.Location = new Point(0, 320);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(543, 25);
            toolStrip1.TabIndex = 20;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.AutoSize = false;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(360, 22);
            toolStripLabel1.Text = "You may search by UserID and User Name.";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(75, 22);
            toolStripLabel2.Text = "***New***";
            // 
            // cboUserRole
            // 
            cboUserRole.FormattingEnabled = true;
            cboUserRole.Location = new Point(132, 157);
            cboUserRole.Name = "cboUserRole";
            cboUserRole.Size = new Size(270, 28);
            cboUserRole.TabIndex = 5;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(38, 125);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 22;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(132, 122);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(271, 27);
            txtPassword.TabIndex = 4;
            // 
            // frmUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 345);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(cboUserRole);
            Controls.Add(toolStrip1);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(btnSearchUserName);
            Controls.Add(btnSearchUserID);
            Controls.Add(label3);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(txtUserID);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Entry";
            Load += frmUser_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUserID;
        private Label label2;
        private TextBox txtUserName;
        private Label label3;
        private Button btnClose;
        private Button btnDelete;
        private Button btnClear;
        private Button btnSave;
        private Button btnSearchUserName;
        private Button btnSearchUserID;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel toolStripLabel2;
        private ComboBox cboUserRole;
        private Label lblPassword;
        private TextBox txtPassword;
    }
}