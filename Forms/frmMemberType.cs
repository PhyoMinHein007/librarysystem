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
    public partial class frmMemberType : Form
    {
        Library.BizO.MemberType datarow = new();

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
                txtMemberTypeId.Enabled = _isNewRow;
            }
        }

        public frmMemberType()
        {
            InitializeComponent();
        }

        private void frmMemberType_Load(object sender, EventArgs e)
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
            txtMemberTypeId.Text = datarow.MemberTypeId;
            numDayAllow.Value = datarow.DaysAllowed;
            numMaxBookAllowed.Value = datarow.MaxBookAllowed;
        }

        private void CopyBack()
        {
            datarow.MemberTypeId = txtMemberTypeId.Text;
            datarow.DaysAllowed = (int)numDayAllow.Value;
            datarow.MaxBookAllowed = (int)numMaxBookAllowed.Value;
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
            string id = txtMemberTypeId.Text;
            if (Library.BR.MemberType.Delete(id))
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
                var existingData = Library.BR.MemberType.GetById(datarow.MemberTypeId);
                if (existingData != null)
                {
                    MessageBox.Show("The Member Type ID is already in use. Please choose a different ID.");
                    return;
                }
            }
            if (Library.BR.MemberType.Save(datarow))
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

        private void btnSearchById_Click(object sender, EventArgs e)
        {
            string id = txtMemberTypeId.Text;
            if (string.IsNullOrEmpty(id)) return;

            datarow = BR.MemberType.GetById(id);

            if (datarow == null)
            {
                MessageBox.Show("No Member Type with this Id found");
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
