namespace Library.Forms
{
    partial class frmRental
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
            txtRentalID = new TextBox();
            txtMemberID = new TextBox();
            txtLibrarianID = new TextBox();
            dtRental = new DateTimePicker();
            dtToReturn = new DateTimePicker();
            cmdSearchByRentalId = new Button();
            dgvRentalDetail = new DataGridView();
            gcBookId = new DataGridViewTextBoxColumn();
            gcIsReturned = new DataGridViewComboBoxColumn();
            gcReturnedDate = new DataGridViewTextBoxColumn();
            gcReturnStatus = new DataGridViewComboBoxColumn();
            DeleteButton = new DataGridViewButtonColumn();
            cmdClose = new Button();
            cmdClear = new Button();
            cmdDelete = new Button();
            cmdSave = new Button();
            toolStrip1 = new ToolStrip();
            statusStrip1 = new StatusStrip();
            stMessage = new ToolStripStatusLabel();
            stMode = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)dgvRentalDetail).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 45);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Rental Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(651, 45);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "Rental Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 78);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 2;
            label3.Text = "Member Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(628, 99);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 3;
            label4.Text = "Date To Return";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 116);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 4;
            label5.Text = "Librarian Id";
            // 
            // txtRentalID
            // 
            txtRentalID.Location = new Point(123, 40);
            txtRentalID.Name = "txtRentalID";
            txtRentalID.Size = new Size(174, 27);
            txtRentalID.TabIndex = 0;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(123, 74);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(174, 27);
            txtMemberID.TabIndex = 2;
            // 
            // txtLibrarianID
            // 
            txtLibrarianID.Location = new Point(123, 113);
            txtLibrarianID.Name = "txtLibrarianID";
            txtLibrarianID.Size = new Size(174, 27);
            txtLibrarianID.TabIndex = 3;
            // 
            // dtRental
            // 
            dtRental.Format = DateTimePickerFormat.Short;
            dtRental.Location = new Point(747, 40);
            dtRental.Name = "dtRental";
            dtRental.Size = new Size(149, 27);
            dtRental.TabIndex = 4;
            // 
            // dtToReturn
            // 
            dtToReturn.Format = DateTimePickerFormat.Short;
            dtToReturn.Location = new Point(747, 97);
            dtToReturn.Name = "dtToReturn";
            dtToReturn.Size = new Size(149, 27);
            dtToReturn.TabIndex = 5;
            // 
            // cmdSearchByRentalId
            // 
            cmdSearchByRentalId.Location = new Point(303, 39);
            cmdSearchByRentalId.Name = "cmdSearchByRentalId";
            cmdSearchByRentalId.Size = new Size(90, 29);
            cmdSearchByRentalId.TabIndex = 1;
            cmdSearchByRentalId.Text = "Search";
            cmdSearchByRentalId.UseVisualStyleBackColor = true;
            cmdSearchByRentalId.Click += btnSearchById_Click;
            // 
            // dgvRentalDetail
            // 
            dgvRentalDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentalDetail.Columns.AddRange(new DataGridViewColumn[] { gcBookId, gcIsReturned, gcReturnedDate, gcReturnStatus, DeleteButton });
            dgvRentalDetail.Location = new Point(104, 186);
            dgvRentalDetail.Name = "dgvRentalDetail";
            dgvRentalDetail.RowHeadersWidth = 51;
            dgvRentalDetail.RowTemplate.Height = 29;
            dgvRentalDetail.Size = new Size(728, 278);
            dgvRentalDetail.TabIndex = 6;
            dgvRentalDetail.CellBeginEdit += dgvRentalDetail_CellBeginEdit;
            dgvRentalDetail.CellClick += dgvRentalDetail_CellClick;
            // 
            // gcBookId
            // 
            gcBookId.DataPropertyName = "BookId";
            gcBookId.HeaderText = "Book Id";
            gcBookId.MinimumWidth = 6;
            gcBookId.Name = "gcBookId";
            gcBookId.Width = 125;
            // 
            // gcIsReturned
            // 
            gcIsReturned.DataPropertyName = "IsReturned";
            gcIsReturned.HeaderText = "IsReturned";
            gcIsReturned.MinimumWidth = 6;
            gcIsReturned.Name = "gcIsReturned";
            gcIsReturned.Resizable = DataGridViewTriState.True;
            gcIsReturned.SortMode = DataGridViewColumnSortMode.Automatic;
            gcIsReturned.Width = 125;
            // 
            // gcReturnedDate
            // 
            gcReturnedDate.DataPropertyName = "ReturnedDate";
            gcReturnedDate.HeaderText = "Returned Date";
            gcReturnedDate.MinimumWidth = 6;
            gcReturnedDate.Name = "gcReturnedDate";
            gcReturnedDate.Width = 125;
            // 
            // gcReturnStatus
            // 
            gcReturnStatus.DataPropertyName = "ReturnStatus";
            gcReturnStatus.HeaderText = "ReturnStatus";
            gcReturnStatus.MinimumWidth = 6;
            gcReturnStatus.Name = "gcReturnStatus";
            gcReturnStatus.Resizable = DataGridViewTriState.True;
            gcReturnStatus.SortMode = DataGridViewColumnSortMode.Automatic;
            gcReturnStatus.Width = 175;
            // 
            // DeleteButton
            // 
            DeleteButton.HeaderText = "Delete";
            DeleteButton.MinimumWidth = 6;
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Text = "Remove";
            DeleteButton.UseColumnTextForButtonValue = true;
            DeleteButton.Width = 125;
            // 
            // cmdClose
            // 
            cmdClose.Location = new Point(556, 523);
            cmdClose.Name = "cmdClose";
            cmdClose.Size = new Size(94, 29);
            cmdClose.TabIndex = 10;
            cmdClose.Text = "Close";
            cmdClose.UseVisualStyleBackColor = true;
            cmdClose.Click += btnClose_Click;
            // 
            // cmdClear
            // 
            cmdClear.Location = new Point(456, 523);
            cmdClear.Name = "cmdClear";
            cmdClear.Size = new Size(94, 29);
            cmdClear.TabIndex = 8;
            cmdClear.Text = "Clear";
            cmdClear.UseVisualStyleBackColor = true;
            cmdClear.Click += btnClear_Click;
            // 
            // cmdDelete
            // 
            cmdDelete.Location = new Point(356, 523);
            cmdDelete.Name = "cmdDelete";
            cmdDelete.Size = new Size(94, 29);
            cmdDelete.TabIndex = 9;
            cmdDelete.Text = "Delete";
            cmdDelete.UseVisualStyleBackColor = true;
            cmdDelete.Click += btnDelete_Click;
            // 
            // cmdSave
            // 
            cmdSave.Location = new Point(256, 523);
            cmdSave.Name = "cmdSave";
            cmdSave.Size = new Size(94, 29);
            cmdSave.TabIndex = 7;
            cmdSave.Text = "Save";
            cmdSave.UseVisualStyleBackColor = true;
            cmdSave.Click += btnSave_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(940, 25);
            toolStrip1.TabIndex = 18;
            toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { stMessage, stMode });
            statusStrip1.Location = new Point(0, 605);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(940, 26);
            statusStrip1.TabIndex = 19;
            statusStrip1.Text = "statusStrip1";
            // 
            // stMessage
            // 
            stMessage.AutoSize = false;
            stMessage.Name = "stMessage";
            stMessage.Size = new Size(600, 20);
            stMessage.Text = "You can search by Rental Id or Member Id or Librian Id";
            // 
            // stMode
            // 
            stMode.Name = "stMode";
            stMode.Size = new Size(75, 20);
            stMode.Text = "***New***";
            // 
            // frmRental
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 631);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(cmdClose);
            Controls.Add(cmdClear);
            Controls.Add(cmdDelete);
            Controls.Add(cmdSave);
            Controls.Add(dgvRentalDetail);
            Controls.Add(cmdSearchByRentalId);
            Controls.Add(dtToReturn);
            Controls.Add(dtRental);
            Controls.Add(txtLibrarianID);
            Controls.Add(txtMemberID);
            Controls.Add(txtRentalID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRental";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rental Entry";
            Load += frmRental_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRentalDetail).EndInit();
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
        private TextBox txtRentalID;
        private TextBox txtMemberID;
        private TextBox txtLibrarianID;
        private DateTimePicker dtRental;
        private DateTimePicker dtToReturn;
        private Button cmdSearchByRentalId;
        private DataGridView dgvRentalDetail;
        private Button cmdClose;
        private Button cmdClear;
        private Button cmdDelete;
        private Button cmdSave;
        private ToolStrip toolStrip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel stMessage;
        private ToolStripStatusLabel stMode;
        private DataGridViewTextBoxColumn gcBookId;
        private DataGridViewComboBoxColumn gcIsReturned;
        private DataGridViewTextBoxColumn gcReturnedDate;
        private DataGridViewComboBoxColumn gcReturnStatus;
        private DataGridViewButtonColumn DeleteButton;
    }
}