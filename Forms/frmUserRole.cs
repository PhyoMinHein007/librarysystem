namespace Library.Forms
{
    public partial class frmUserRole : Form
    {
        Library.BizO.UserRole datarow = new();

        private bool _isNewRow;
        private bool IsNewRow
        {
            get
            {
                return _isNewRow;
            }
            set
            {
                _isNewRow = value;
                txtUserRoleID.Enabled = _isNewRow;
            }
        }

        public frmUserRole()
        {
            InitializeComponent();
        }

        private void frmUserRole_Load(object sender, EventArgs e)
        {
            CreateNewRow();
        }

        private void CreateNewRow()
        {
            datarow = new();
            IsNewRow = true;
            FillData();
        }

        private void FillData()
        {
            txtUserRoleID.Text = datarow.UserRoleId;
            txtRoleDescription.Text = datarow.RoleDescription;
        }

        private void CopyBack()
        {
            datarow.UserRoleId = txtUserRoleID.Text;
            datarow.RoleDescription = txtRoleDescription.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CreateNewRow();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtUserRoleID.Text;
            if (Library.BR.UserRole.Delete(id))
            {
                MessageBox.Show("Deleted Successfully");
                CreateNewRow();
            }
            else
            {
                MessageBox.Show("Fail to delete");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CopyBack();
            if (IsNewRow)
            {
                var existingUserRole = Library.BR.UserRole.GetById(datarow.UserRoleId);
                if (existingUserRole != null)
                {
                    MessageBox.Show("The UserRole ID is already in use. Please choose a different ID.");
                    return;
                }
            }
            if (Library.BR.UserRole.Save(datarow))
            {
                MessageBox.Show("Saved Successfully");
                CreateNewRow();
            }
            else
            {
                MessageBox.Show("Unable to save");
                FillData();
            }
        }

        private void btnSearchByRoleDescription_Click(object sender, EventArgs e)
        {
            string description = txtRoleDescription.Text;
            if (string.IsNullOrEmpty(description)) return;

            datarow = Library.BR.UserRole.GetByRoleDescription(description);

            if (datarow == null)
            {
                MessageBox.Show("No user role with this description found");
                CreateNewRow();
            }
            else
            {
                IsNewRow = false;
                FillData();
            }

        }

        private void btnSearchById_Click(object sender, EventArgs e)
        {
            string id = txtUserRoleID.Text;
            if (string.IsNullOrEmpty(id)) return;

            datarow = BR.UserRole.GetById(id);

            if (datarow == null)
            {
                MessageBox.Show("No User Role with this Id found");
                CreateNewRow();
            }
            else
            {
                IsNewRow = false;
                FillData();
            }

        }

    }
}
