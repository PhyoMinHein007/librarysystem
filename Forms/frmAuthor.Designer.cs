namespace Library.Forms
{
    partial class frmAuthor
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
            txtid = new TextBox();
            txtName = new TextBox();
            txtEmail = new TextBox();
            btnSave = new Button();
            btnSearchById = new Button();
            btnSearchByName = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnClose = new Button();
            statusStrip1 = new StatusStrip();
            stMessage = new ToolStripStatusLabel();
            stMode = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 53);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Author id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 88);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 121);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "eMail";
            // 
            // txtid
            // 
            txtid.Location = new Point(178, 50);
            txtid.Name = "txtid";
            txtid.Size = new Size(143, 27);
            txtid.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(178, 85);
            txtName.Name = "txtName";
            txtName.Size = new Size(462, 27);
            txtName.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(178, 118);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(462, 27);
            txtEmail.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(346, 165);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnSearchById
            // 
            btnSearchById.Location = new Point(340, 50);
            btnSearchById.Name = "btnSearchById";
            btnSearchById.Size = new Size(94, 29);
            btnSearchById.TabIndex = 1;
            btnSearchById.Text = "Search";
            btnSearchById.UseVisualStyleBackColor = true;
            btnSearchById.Click += btnSearchById_Click;
            // 
            // btnSearchByName
            // 
            btnSearchByName.Location = new Point(646, 83);
            btnSearchByName.Name = "btnSearchByName";
            btnSearchByName.Size = new Size(94, 29);
            btnSearchByName.TabIndex = 3;
            btnSearchByName.Text = "Search";
            btnSearchByName.UseVisualStyleBackColor = true;
            btnSearchByName.Click += btnSearchByName_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(546, 165);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(446, 165);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(646, 165);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { stMessage, stMode });
            statusStrip1.Location = new Point(0, 244);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 12;
            statusStrip1.Text = "statusStrip1";
            // 
            // stMessage
            // 
            stMessage.AutoSize = false;
            stMessage.Name = "stMessage";
            stMessage.Size = new Size(450, 20);
            stMessage.Text = "You may search by Author id or Author Name.";
            // 
            // stMode
            // 
            stMode.Name = "stMode";
            stMode.Size = new Size(75, 20);
            stMode.Text = "***New***";
            // 
            // frmAuthor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 270);
            Controls.Add(statusStrip1);
            Controls.Add(btnClose);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnSearchByName);
            Controls.Add(btnSearchById);
            Controls.Add(btnSave);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(txtid);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAuthor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Author Entry";
            Load += frmAuthor_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtid;
        private TextBox txtName;
        private TextBox txtEmail;
        private Button btnSave;
        private Button btnSearchById;
        private Button btnSearchByName;
        private Button btnDelete;
        private Button btnClear;
        private Button btnClose;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel stMessage;
        private ToolStripStatusLabel stMode;
    }
}