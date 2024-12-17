namespace Library.Forms
{
    partial class frmMemberSelection
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
            dataGridViewMembers = new DataGridView();
            btnOk = new Button();
            btnCancel = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMembers).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewMembers
            // 
            dataGridViewMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMembers.Location = new Point(48, 46);
            dataGridViewMembers.Name = "dataGridViewMembers";
            dataGridViewMembers.RowHeadersWidth = 51;
            dataGridViewMembers.RowTemplate.Height = 29;
            dataGridViewMembers.Size = new Size(978, 342);
            dataGridViewMembers.TabIndex = 0;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(707, 423);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 1;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(807, 423);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 473);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1077, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.RightToLeft = RightToLeft.No;
            toolStripStatusLabel1.Size = new Size(277, 20);
            toolStripStatusLabel1.Text = "You may select a member and press 'Ok'.";
            // 
            // frmMemberSelection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 499);
            Controls.Add(statusStrip1);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(dataGridViewMembers);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMemberSelection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Selection";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMembers).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewMembers;
        private Button btnOk;
        private Button btnCancel;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}