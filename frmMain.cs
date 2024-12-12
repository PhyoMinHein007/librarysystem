namespace Library
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit from the application?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
                this.Close();
        }

        private void mnuDatabaseSetup_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Database will be deleted if exists and created. Are you sure to continute?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
                return;
            Cruder.DbSetup.CreateDb();
            MessageBox.Show("Database is created successfully.");
        }

        private void mnuAuthor_Click(object sender, EventArgs e)
        {
            Form frm = new Library.Forms.frmAuthor();
            frm.Show();
        }

        private void mnuBookCategory_Click(object sender, EventArgs e)
        {
            Form frm = new Library.Forms.frmCategory();
            frm.Show();
        }

        private void mnuUserRoles_Click(object sender, EventArgs e)
        {
            Form frm = new Library.Forms.frmUserRole();
            frm.Show();
        }

        private void mnuMemberTypes_Click(object sender, EventArgs e)
        {
            Form frm = new Library.Forms.frmMemberType();
            frm.Show();
        }

        private void mnuMembers_Click(object sender, EventArgs e)
        {
            Form frm = new Library.Forms.frmMember();
            frm.Show();
        }

        private void mnuUser_Click(object sender, EventArgs e)
        {
            Form frm = new Library.Forms.frmUser();
            frm.Show();
        }

        private void mnuBookEntry_Click(object sender, EventArgs e)
        {
            Form frm = new Library.Forms.frmBook();
            frm.Show();
        }

        private void rentalManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Library.Forms.frmRental();
            frm.Show();
        }
    }
}