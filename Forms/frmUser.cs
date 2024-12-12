using LibrarySystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library.Forms
{
    public partial class frmUser : Form
    {
        Library.BizO.User datarow = new();
        List<Library.BizO.UserRole> userRoleList;


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
                txtUserID.Enabled = _isNewRow;
            }
        }

        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {

            userRoleList = Library.Cruder.UserRole.GetAllUserRoleId();
            cboUserRole.DataSource = userRoleList;
            cboUserRole.DisplayMember = "RoleDescription";
            cboUserRole.ValueMember = "UserRoleId";

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
            txtUserID.Text = datarow.UserId;
            txtUserName.Text = datarow.UserName;
            // Check if UserRoleId is valid and exists in the data source
            if (!string.IsNullOrEmpty(datarow.UserRoleId) &&
                userRoleList.Any(x => x.UserRoleId == datarow.UserRoleId))
            {
                cboUserRole.SelectedValue = datarow.UserRoleId;
            }
            else
            {
                cboUserRole.SelectedIndex = -1;
            }
            txtPassword.Text = datarow.Password;
        }

        private void CopyBack()
        {
            datarow.UserId = txtUserID.Text;
            datarow.UserName = txtUserName.Text;
            datarow.UserRoleId = (string)cboUserRole.SelectedValue;
            datarow.Password = txtPassword.Text;
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
            string id = txtUserID.Text;
            if (Library.BR.User.Delete(id))
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
                var existingData = Library.BR.User.GetById(datarow.UserId);
                if (existingData != null)
                {
                    MessageBox.Show("The User ID is already in use. Please choose a different ID.");
                    return;
                }
            }
            if (Library.BR.User.Save(datarow))
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

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            string name = txtUserName.Text;
            if (string.IsNullOrEmpty(name)) return;

            datarow = Library.BR.User.GetByName(name);

            if (datarow == null)
            {
                MessageBox.Show("No User with this name found");
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
            string id = txtUserID.Text;
            if (string.IsNullOrEmpty(id)) return;

            datarow = BR.User.GetById(id);

            if (datarow == null)
            {
                MessageBox.Show("No User with this Id found");
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
