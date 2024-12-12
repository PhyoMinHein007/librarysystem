namespace Library.Forms
{
    partial class frmCategory
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
            txtCatID = new TextBox();
            txtCatName = new TextBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            btnSearchById = new Button();
            btnSearchByName = new Button();
            btnSave = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 53);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 0;
            label1.Text = "Category ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 103);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 1;
            label2.Text = "Category Name";
            // 
            // txtCatID
            // 
            txtCatID.Location = new Point(173, 43);
            txtCatID.Margin = new Padding(3, 4, 3, 4);
            txtCatID.Name = "txtCatID";
            txtCatID.Size = new Size(322, 27);
            txtCatID.TabIndex = 0;
            // 
            // txtCatName
            // 
            txtCatName.Location = new Point(173, 92);
            txtCatName.Margin = new Padding(3, 4, 3, 4);
            txtCatName.Name = "txtCatName";
            txtCatName.Size = new Size(322, 27);
            txtCatName.TabIndex = 2;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 235);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(653, 26);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.AutoSize = false;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(450, 20);
            toolStripStatusLabel1.Text = "You can search By Category ID or Name.";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(78, 20);
            toolStripStatusLabel2.Text = "***NEW***";
            // 
            // btnSearchById
            // 
            btnSearchById.Location = new Point(527, 41);
            btnSearchById.Margin = new Padding(3, 4, 3, 4);
            btnSearchById.Name = "btnSearchById";
            btnSearchById.Size = new Size(86, 31);
            btnSearchById.TabIndex = 1;
            btnSearchById.Text = "Search";
            btnSearchById.UseVisualStyleBackColor = true;
            btnSearchById.Click += btnSearchById_Click;
            // 
            // btnSearchByName
            // 
            btnSearchByName.Location = new Point(527, 91);
            btnSearchByName.Margin = new Padding(3, 4, 3, 4);
            btnSearchByName.Name = "btnSearchByName";
            btnSearchByName.Size = new Size(86, 31);
            btnSearchByName.TabIndex = 3;
            btnSearchByName.Text = "Search";
            btnSearchByName.UseVisualStyleBackColor = true;
            btnSearchByName.Click += btnSearchByName_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(219, 169);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(319, 169);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(419, 169);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(519, 169);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 261);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(btnSearchByName);
            Controls.Add(btnSearchById);
            Controls.Add(statusStrip1);
            Controls.Add(txtCatName);
            Controls.Add(txtCatID);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCategory";
            Load += frmCategory_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCatID;
        private TextBox txtCatName;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private Button btnSearchById;
        private Button btnSearchByName;
        private Button btnSave;
        private Button btnClear;
        private Button btnDelete;
        private Button btnClose;
    }
}