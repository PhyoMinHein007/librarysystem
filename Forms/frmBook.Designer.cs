namespace Library.Forms
{
    partial class frmBook
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
            txtBookId = new TextBox();
            txtISBN = new TextBox();
            txtTitle = new TextBox();
            txtPublisher = new TextBox();
            txtPubYear = new TextBox();
            label7 = new Label();
            cboCategory = new ComboBox();
            cmdSearchByBookId = new Button();
            cmdSearchByISBN = new Button();
            cmdSearchbyTitle = new Button();
            cmdClose = new Button();
            cmdClear = new Button();
            cmdDelete = new Button();
            cmdSave = new Button();
            statusStrip1 = new StatusStrip();
            stMessage = new ToolStripStatusLabel();
            stMode = new ToolStripStatusLabel();
            gbStatus = new GroupBox();
            rdoNotForRentOut = new RadioButton();
            rdoRentOut = new RadioButton();
            rdoCompensated = new RadioButton();
            rdoNoReturned = new RadioButton();
            rdoDamaged = new RadioButton();
            rdoAvailable = new RadioButton();
            rdoNone = new RadioButton();
            dvgAuthors = new DataGridView();
            AuthorComboBox = new DataGridViewComboBoxColumn();
            DeleteButton = new DataGridViewButtonColumn();
            statusStrip1.SuspendLayout();
            gbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgAuthors).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 27);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Book Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(538, 28);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "ISBN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 60);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 2;
            label3.Text = "Title";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 126);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "Publisher";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(474, 131);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 4;
            label5.Text = "Published Year";
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(104, 24);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(123, 27);
            txtBookId.TabIndex = 0;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(594, 27);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(130, 27);
            txtISBN.TabIndex = 2;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(104, 57);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(620, 27);
            txtTitle.TabIndex = 4;
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(104, 124);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(287, 27);
            txtPublisher.TabIndex = 7;
            // 
            // txtPubYear
            // 
            txtPubYear.Location = new Point(598, 127);
            txtPubYear.Name = "txtPubYear";
            txtPubYear.Size = new Size(126, 27);
            txtPubYear.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 93);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 12;
            label7.Text = "Category";
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(104, 90);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(620, 28);
            cboCategory.TabIndex = 6;
            // 
            // cmdSearchByBookId
            // 
            cmdSearchByBookId.Location = new Point(233, 24);
            cmdSearchByBookId.Name = "cmdSearchByBookId";
            cmdSearchByBookId.Size = new Size(94, 29);
            cmdSearchByBookId.TabIndex = 1;
            cmdSearchByBookId.Text = "Search";
            cmdSearchByBookId.UseVisualStyleBackColor = true;
            cmdSearchByBookId.Click += btnSearchById_Click;
            // 
            // cmdSearchByISBN
            // 
            cmdSearchByISBN.Location = new Point(730, 28);
            cmdSearchByISBN.Name = "cmdSearchByISBN";
            cmdSearchByISBN.Size = new Size(94, 29);
            cmdSearchByISBN.TabIndex = 3;
            cmdSearchByISBN.Text = "Search";
            cmdSearchByISBN.UseVisualStyleBackColor = true;
            cmdSearchByISBN.Click += btnSearchByISBN_Click;
            // 
            // cmdSearchbyTitle
            // 
            cmdSearchbyTitle.Location = new Point(730, 56);
            cmdSearchbyTitle.Name = "cmdSearchbyTitle";
            cmdSearchbyTitle.Size = new Size(94, 29);
            cmdSearchbyTitle.TabIndex = 5;
            cmdSearchbyTitle.Text = "Search";
            cmdSearchbyTitle.UseVisualStyleBackColor = true;
            cmdSearchbyTitle.Click += btnSearchByTitle_Click;
            // 
            // cmdClose
            // 
            cmdClose.Location = new Point(394, 405);
            cmdClose.Name = "cmdClose";
            cmdClose.Size = new Size(94, 29);
            cmdClose.TabIndex = 14;
            cmdClose.Text = "Close";
            cmdClose.UseVisualStyleBackColor = true;
            cmdClose.Click += btnClose_Click;
            // 
            // cmdClear
            // 
            cmdClear.Location = new Point(194, 405);
            cmdClear.Name = "cmdClear";
            cmdClear.Size = new Size(94, 29);
            cmdClear.TabIndex = 12;
            cmdClear.Text = "Clear";
            cmdClear.UseVisualStyleBackColor = true;
            cmdClear.Click += btnClear_Click;
            // 
            // cmdDelete
            // 
            cmdDelete.Location = new Point(294, 405);
            cmdDelete.Name = "cmdDelete";
            cmdDelete.Size = new Size(94, 29);
            cmdDelete.TabIndex = 13;
            cmdDelete.Text = "Delete";
            cmdDelete.UseVisualStyleBackColor = true;
            cmdDelete.Click += btnDelete_Click;
            // 
            // cmdSave
            // 
            cmdSave.Location = new Point(94, 405);
            cmdSave.Name = "cmdSave";
            cmdSave.Size = new Size(94, 29);
            cmdSave.TabIndex = 11;
            cmdSave.Text = "Save";
            cmdSave.UseVisualStyleBackColor = true;
            cmdSave.Click += btnSave_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { stMessage, stMode });
            statusStrip1.Location = new Point(0, 507);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(890, 26);
            statusStrip1.TabIndex = 21;
            statusStrip1.Text = "statusStrip1";
            // 
            // stMessage
            // 
            stMessage.AutoSize = false;
            stMessage.Name = "stMessage";
            stMessage.Size = new Size(700, 20);
            stMessage.Text = "You can search by Book id or ISBN";
            // 
            // stMode
            // 
            stMode.Name = "stMode";
            stMode.Size = new Size(75, 20);
            stMode.Text = "***New***";
            // 
            // gbStatus
            // 
            gbStatus.Controls.Add(rdoNotForRentOut);
            gbStatus.Controls.Add(rdoRentOut);
            gbStatus.Controls.Add(rdoCompensated);
            gbStatus.Controls.Add(rdoNoReturned);
            gbStatus.Controls.Add(rdoDamaged);
            gbStatus.Controls.Add(rdoAvailable);
            gbStatus.Controls.Add(rdoNone);
            gbStatus.Location = new Point(575, 180);
            gbStatus.Name = "gbStatus";
            gbStatus.Size = new Size(249, 254);
            gbStatus.TabIndex = 10;
            gbStatus.TabStop = false;
            gbStatus.Text = "Availability Status";
            // 
            // rdoNotForRentOut
            // 
            rdoNotForRentOut.AutoSize = true;
            rdoNotForRentOut.Location = new Point(18, 130);
            rdoNotForRentOut.Name = "rdoNotForRentOut";
            rdoNotForRentOut.Size = new Size(142, 24);
            rdoNotForRentOut.TabIndex = 3;
            rdoNotForRentOut.TabStop = true;
            rdoNotForRentOut.Text = "Not For Rent Out";
            rdoNotForRentOut.UseVisualStyleBackColor = true;
            // 
            // rdoRentOut
            // 
            rdoRentOut.AutoSize = true;
            rdoRentOut.Location = new Point(18, 70);
            rdoRentOut.Name = "rdoRentOut";
            rdoRentOut.Size = new Size(88, 24);
            rdoRentOut.TabIndex = 1;
            rdoRentOut.TabStop = true;
            rdoRentOut.Text = "Rent Out";
            rdoRentOut.UseVisualStyleBackColor = true;
            // 
            // rdoCompensated
            // 
            rdoCompensated.AutoSize = true;
            rdoCompensated.Location = new Point(18, 100);
            rdoCompensated.Name = "rdoCompensated";
            rdoCompensated.Size = new Size(122, 24);
            rdoCompensated.TabIndex = 2;
            rdoCompensated.TabStop = true;
            rdoCompensated.Text = "Compensated";
            rdoCompensated.UseVisualStyleBackColor = true;
            // 
            // rdoNoReturned
            // 
            rdoNoReturned.AutoSize = true;
            rdoNoReturned.Location = new Point(18, 160);
            rdoNoReturned.Name = "rdoNoReturned";
            rdoNoReturned.Size = new Size(119, 24);
            rdoNoReturned.TabIndex = 4;
            rdoNoReturned.TabStop = true;
            rdoNoReturned.Text = "Not Returned";
            rdoNoReturned.UseVisualStyleBackColor = true;
            // 
            // rdoDamaged
            // 
            rdoDamaged.AutoSize = true;
            rdoDamaged.Location = new Point(18, 190);
            rdoDamaged.Name = "rdoDamaged";
            rdoDamaged.Size = new Size(155, 24);
            rdoDamaged.TabIndex = 5;
            rdoDamaged.TabStop = true;
            rdoDamaged.Text = "Damaged in house";
            rdoDamaged.UseVisualStyleBackColor = true;
            // 
            // rdoAvailable
            // 
            rdoAvailable.AutoSize = true;
            rdoAvailable.Location = new Point(18, 39);
            rdoAvailable.Name = "rdoAvailable";
            rdoAvailable.Size = new Size(92, 24);
            rdoAvailable.TabIndex = 0;
            rdoAvailable.TabStop = true;
            rdoAvailable.Text = "Available";
            rdoAvailable.UseVisualStyleBackColor = true;
            // 
            // rdoNone
            // 
            rdoNone.AutoSize = true;
            rdoNone.Location = new Point(18, 220);
            rdoNone.Name = "rdoNone";
            rdoNone.Size = new Size(66, 24);
            rdoNone.TabIndex = 6;
            rdoNone.TabStop = true;
            rdoNone.Text = "None";
            rdoNone.UseVisualStyleBackColor = true;
            // 
            // dvgAuthors
            // 
            dvgAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgAuthors.Columns.AddRange(new DataGridViewColumn[] { AuthorComboBox, DeleteButton });
            dvgAuthors.Location = new Point(75, 196);
            dvgAuthors.Name = "dvgAuthors";
            dvgAuthors.RowHeadersWidth = 51;
            dvgAuthors.RowTemplate.Height = 29;
            dvgAuthors.Size = new Size(429, 188);
            dvgAuthors.TabIndex = 9;
            dvgAuthors.CellClick += dvgAuthors_CellClick;
            // 
            // AuthorComboBox
            // 
            AuthorComboBox.HeaderText = "Author Name";
            AuthorComboBox.MinimumWidth = 6;
            AuthorComboBox.Name = "AuthorComboBox";
            AuthorComboBox.Width = 250;
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
            // frmBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 533);
            Controls.Add(dvgAuthors);
            Controls.Add(gbStatus);
            Controls.Add(statusStrip1);
            Controls.Add(cmdClose);
            Controls.Add(cmdClear);
            Controls.Add(cmdDelete);
            Controls.Add(cmdSave);
            Controls.Add(cmdSearchbyTitle);
            Controls.Add(cmdSearchByISBN);
            Controls.Add(cmdSearchByBookId);
            Controls.Add(cboCategory);
            Controls.Add(label7);
            Controls.Add(txtPubYear);
            Controls.Add(txtPublisher);
            Controls.Add(txtTitle);
            Controls.Add(txtISBN);
            Controls.Add(txtBookId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Entry";
            Load += frmBook_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            gbStatus.ResumeLayout(false);
            gbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgAuthors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtBookId;
        private TextBox txtISBN;
        private TextBox txtTitle;
        private TextBox txtPublisher;
        private TextBox txtPubYear;
        private Label label7;
        private ComboBox cboCategory;
        private Button cmdSearchByBookId;
        private Button cmdSearchByISBN;
        private Button cmdSearchbyTitle;
        private Button cmdClose;
        private Button cmdClear;
        private Button cmdDelete;
        private Button cmdSave;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel stMessage;
        private ToolStripStatusLabel stMode;
        private GroupBox gbStatus;
        private RadioButton rdoNotForRentOut;
        private RadioButton rdoRentOut;
        private RadioButton rdoCompensated;
        private RadioButton rdoNoReturned;
        private RadioButton rdoDamaged;
        private RadioButton rdoAvailable;
        private RadioButton rdoNone;
        private DataGridView dvgAuthors;
        private DataGridViewComboBoxColumn AuthorComboBox;
        private DataGridViewButtonColumn DeleteButton;
    }
}