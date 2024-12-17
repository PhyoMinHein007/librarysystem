namespace Library.Forms
{
    partial class frmMemberType
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
            label3 = new Label();
            numMaxBookAllowed = new NumericUpDown();
            btnSearchByMemberTypeID = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            numDayAllow = new NumericUpDown();
            txtMemberTypeId = new TextBox();
            btnSave = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)numMaxBookAllowed).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDayAllow).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 43);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "Member Type ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 81);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 1;
            label2.Text = "Day Allowed";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 120);
            label3.Name = "label3";
            label3.Size = new Size(172, 20);
            label3.TabIndex = 2;
            label3.Text = "Maximum Book Allowed";
            // 
            // numMaxBookAllowed
            // 
            numMaxBookAllowed.Location = new Point(241, 117);
            numMaxBookAllowed.Margin = new Padding(3, 4, 3, 4);
            numMaxBookAllowed.Name = "numMaxBookAllowed";
            numMaxBookAllowed.Size = new Size(214, 27);
            numMaxBookAllowed.TabIndex = 3;
            // 
            // btnSearchByMemberTypeID
            // 
            btnSearchByMemberTypeID.Location = new Point(461, 40);
            btnSearchByMemberTypeID.Margin = new Padding(3, 4, 3, 4);
            btnSearchByMemberTypeID.Name = "btnSearchByMemberTypeID";
            btnSearchByMemberTypeID.Size = new Size(86, 31);
            btnSearchByMemberTypeID.TabIndex = 1;
            btnSearchByMemberTypeID.Text = "Search";
            btnSearchByMemberTypeID.UseVisualStyleBackColor = true;
            btnSearchByMemberTypeID.Click += btnSearchById_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 267);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(624, 26);
            statusStrip1.TabIndex = 32;
            statusStrip1.Text = "You can search either by Book ID or ISBN number.";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.AutoSize = false;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(350, 20);
            toolStripStatusLabel1.Text = "You can search by Member Type ID";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(78, 20);
            toolStripStatusLabel2.Text = "***NEW***";
            // 
            // numDayAllow
            // 
            numDayAllow.Location = new Point(241, 79);
            numDayAllow.Margin = new Padding(3, 4, 3, 4);
            numDayAllow.Name = "numDayAllow";
            numDayAllow.Size = new Size(214, 27);
            numDayAllow.TabIndex = 2;
            // 
            // txtMemberTypeId
            // 
            txtMemberTypeId.Location = new Point(241, 40);
            txtMemberTypeId.Margin = new Padding(3, 4, 3, 4);
            txtMemberTypeId.Name = "txtMemberTypeId";
            txtMemberTypeId.Size = new Size(213, 27);
            txtMemberTypeId.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(161, 180);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(261, 180);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(361, 180);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(461, 180);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmMemberType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 293);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(txtMemberTypeId);
            Controls.Add(numDayAllow);
            Controls.Add(statusStrip1);
            Controls.Add(btnSearchByMemberTypeID);
            Controls.Add(numMaxBookAllowed);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMemberType";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Type Entry";
            Load += frmMemberType_Load;
            ((System.ComponentModel.ISupportInitialize)numMaxBookAllowed).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDayAllow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numMaxBookAllowed;
        private Button btnSearchByMemberTypeID;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private NumericUpDown numDayAllow;
        private TextBox txtMemberTypeId;
        private Button btnSave;
        private Button btnClear;
        private Button btnDelete;
        private Button btnClose;
    }
}