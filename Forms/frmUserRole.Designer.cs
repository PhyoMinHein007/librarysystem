namespace Library.Forms
{
    partial class frmUserRole
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
            label2 = new Label();
            txtUserRoleID = new TextBox();
            txtRoleDescription = new TextBox();
            btnSearchByUserRoleID = new Button();
            btnClose = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnSave = new Button();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripLabel2 = new ToolStripLabel();
            btnSerachByRoleDescription = new Button();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 49);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "User Role ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 86);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 1;
            label2.Text = "Role Description";
            // 
            // txtUserRoleID
            // 
            txtUserRoleID.Location = new Point(153, 44);
            txtUserRoleID.Margin = new Padding(3, 4, 3, 4);
            txtUserRoleID.Name = "txtUserRoleID";
            txtUserRoleID.Size = new Size(262, 27);
            txtUserRoleID.TabIndex = 0;
            // 
            // txtRoleDescription
            // 
            txtRoleDescription.Location = new Point(153, 86);
            txtRoleDescription.Margin = new Padding(3, 4, 3, 4);
            txtRoleDescription.Name = "txtRoleDescription";
            txtRoleDescription.Size = new Size(262, 27);
            txtRoleDescription.TabIndex = 2;
            // 
            // btnSearchByUserRoleID
            // 
            btnSearchByUserRoleID.Location = new Point(451, 44);
            btnSearchByUserRoleID.Margin = new Padding(3, 4, 3, 4);
            btnSearchByUserRoleID.Name = "btnSearchByUserRoleID";
            btnSearchByUserRoleID.Size = new Size(86, 31);
            btnSearchByUserRoleID.TabIndex = 1;
            btnSearchByUserRoleID.Text = "Search";
            btnSearchByUserRoleID.UseVisualStyleBackColor = true;
            btnSearchByUserRoleID.Click += btnSearchById_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(451, 165);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(86, 30);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(359, 165);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 30);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(267, 165);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 30);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(175, 165);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 30);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripLabel2 });
            toolStrip1.Location = new Point(0, 245);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(613, 25);
            toolStrip1.TabIndex = 27;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.AutoSize = false;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(390, 22);
            toolStripLabel1.Text = "You can search by User Role Id or Role Description.";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.AutoSize = false;
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(61, 22);
            toolStripLabel2.Text = "***New***";
            // 
            // btnSerachByRoleDescription
            // 
            btnSerachByRoleDescription.Location = new Point(451, 86);
            btnSerachByRoleDescription.Margin = new Padding(3, 4, 3, 4);
            btnSerachByRoleDescription.Name = "btnSerachByRoleDescription";
            btnSerachByRoleDescription.Size = new Size(86, 31);
            btnSerachByRoleDescription.TabIndex = 3;
            btnSerachByRoleDescription.Text = "Search";
            btnSerachByRoleDescription.UseVisualStyleBackColor = true;
            btnSerachByRoleDescription.Click += btnSearchByRoleDescription_Click;
            // 
            // frmUserRole
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 270);
            Controls.Add(btnSerachByRoleDescription);
            Controls.Add(toolStrip1);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(btnSearchByUserRoleID);
            Controls.Add(txtRoleDescription);
            Controls.Add(txtUserRoleID);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmUserRole";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUserRole";
            Load += frmUserRole_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUserRoleID;
        private TextBox txtRoleDescription;
        private Button btnSearchByUserRoleID;
        private Button btnClose;
        private Button btnDelete;
        private Button btnClear;
        private Button btnSave;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel toolStripLabel2;
        private Button btnSerachByRoleDescription;
    }
}