namespace Library.Forms
{
    partial class frmMember
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMemberID = new TextBox();
            txtMemberName = new TextBox();
            txtPhoneNumber = new TextBox();
            txteMail = new TextBox();
            cbMemberTypeID = new ComboBox();
            numCurrentRentCount = new NumericUpDown();
            btnSearchByMemberID = new Button();
            btnSearchByName = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            btnSave = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)numCurrentRentCount).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 31);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "Member ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 109);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 1;
            label2.Text = "Member Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 153);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 2;
            label3.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 196);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 3;
            label4.Text = "eMail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 69);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 4;
            label5.Text = "Member Type ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(363, 69);
            label6.Name = "label6";
            label6.Size = new Size(134, 20);
            label6.TabIndex = 5;
            label6.Text = "Current Rent Count";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(186, 27);
            txtMemberID.Margin = new Padding(3, 4, 3, 4);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(157, 27);
            txtMemberID.TabIndex = 0;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(186, 105);
            txtMemberName.Margin = new Padding(3, 4, 3, 4);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(444, 27);
            txtMemberName.TabIndex = 4;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(186, 149);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(444, 27);
            txtPhoneNumber.TabIndex = 6;
            // 
            // txteMail
            // 
            txteMail.Location = new Point(186, 192);
            txteMail.Margin = new Padding(3, 4, 3, 4);
            txteMail.Name = "txteMail";
            txteMail.Size = new Size(444, 27);
            txteMail.TabIndex = 7;
            // 
            // cbMemberTypeID
            // 
            cbMemberTypeID.FormattingEnabled = true;
            cbMemberTypeID.Location = new Point(186, 65);
            cbMemberTypeID.Margin = new Padding(3, 4, 3, 4);
            cbMemberTypeID.Name = "cbMemberTypeID";
            cbMemberTypeID.Size = new Size(157, 28);
            cbMemberTypeID.TabIndex = 2;
            // 
            // numCurrentRentCount
            // 
            numCurrentRentCount.Location = new Point(499, 67);
            numCurrentRentCount.Margin = new Padding(3, 4, 3, 4);
            numCurrentRentCount.Name = "numCurrentRentCount";
            numCurrentRentCount.Size = new Size(131, 27);
            numCurrentRentCount.TabIndex = 3;
            // 
            // btnSearchByMemberID
            // 
            btnSearchByMemberID.Location = new Point(370, 27);
            btnSearchByMemberID.Margin = new Padding(3, 4, 3, 4);
            btnSearchByMemberID.Name = "btnSearchByMemberID";
            btnSearchByMemberID.Size = new Size(86, 31);
            btnSearchByMemberID.TabIndex = 1;
            btnSearchByMemberID.Text = "Search";
            btnSearchByMemberID.UseVisualStyleBackColor = true;
            btnSearchByMemberID.Click += btnSearchById_Click;
            // 
            // btnSearchByName
            // 
            btnSearchByName.Location = new Point(640, 105);
            btnSearchByName.Margin = new Padding(3, 4, 3, 4);
            btnSearchByName.Name = "btnSearchByName";
            btnSearchByName.Size = new Size(86, 31);
            btnSearchByName.TabIndex = 5;
            btnSearchByName.Text = "Search";
            btnSearchByName.UseVisualStyleBackColor = true;
            btnSearchByName.Click += btnSearchByName_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 333);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(767, 26);
            statusStrip1.TabIndex = 27;
            statusStrip1.Text = "You can search either by Book ID or ISBN number.";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.AutoSize = false;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(550, 20);
            toolStripStatusLabel1.Text = "You can search either by member ID or Name.";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(78, 20);
            toolStripStatusLabel2.Text = "***NEW***";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(332, 264);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(432, 264);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(532, 264);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(632, 264);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 359);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(statusStrip1);
            Controls.Add(btnSearchByName);
            Controls.Add(btnSearchByMemberID);
            Controls.Add(numCurrentRentCount);
            Controls.Add(cbMemberTypeID);
            Controls.Add(txteMail);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtMemberName);
            Controls.Add(txtMemberID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMember";
            Load += frmMember_Load;
            ((System.ComponentModel.ISupportInitialize)numCurrentRentCount).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMemberID;
        private TextBox txtMemberName;
        private TextBox txtPhoneNumber;
        private TextBox txteMail;
        private ComboBox cbMemberTypeID;
        private NumericUpDown numCurrentRentCount;
        private Button btnSearchByMemberID;
        private Button btnSearchByName;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private Button btnSave;
        private Button btnClear;
        private Button btnDelete;
        private Button btnClose;
    }
}