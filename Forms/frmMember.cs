using Library.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library.Forms
{
    public partial class frmMember : Form
    {
        Library.BizO.Member datarow = new();
        List<BizO.MemberType> memberTypeIdList;

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
                txtMemberID.Enabled = _isNewRow;
            }
        }

        public frmMember()
        {
            InitializeComponent();
        }

        private void frmMember_Load(object sender, EventArgs e)
        {
            memberTypeIdList = Cruder.MemberType.GetAllMemberTypeId();
            cbMemberTypeID.DataSource = memberTypeIdList;
            cbMemberTypeID.DisplayMember = "MemberTypeId";
            cbMemberTypeID.ValueMember = "MemberTypeId";

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
            txtMemberID.Text = datarow.MemberId;
            txtMemberName.Text = datarow.Name;
            numCurrentRentCount.Value = (int)datarow.CurrentRentOutCount;
            cbMemberTypeID.Text = datarow.MemberTypeId;
            txtPhoneNumber.Text = datarow.PhoneNo;
            txteMail.Text = datarow.EMail;
        }

        private void CopyBack()
        {
            datarow.MemberId = txtMemberID.Text;
            datarow.Name = txtMemberName.Text;
            datarow.CurrentRentOutCount = (int)numCurrentRentCount.Value;
            datarow.MemberTypeId = (string)cbMemberTypeID.SelectedValue;
            datarow.PhoneNo = txtPhoneNumber.Text;
            datarow.EMail = txteMail.Text;
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
            string id = txtMemberID.Text;
            if (Library.BR.Member.Delete(id))
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
                var existingData = Library.BR.Member.GetById(datarow.MemberId);
                if (existingData != null)
                {
                    MessageBox.Show("The Member ID is already in use. Please choose a different ID.");
                    return;
                }
            }
            if (Library.BR.Member.Save(datarow))
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
            string name = txtMemberName.Text;
            if (string.IsNullOrEmpty(name)) return;

            List<Library.BizO.Member> recList = Library.BR.Member.GetByName(name);

            if (recList == null || recList.Count == 0)
            {
                MessageBox.Show("No Author with this name found");
                CreateNewRow();
            }
            else if (recList.Count == 1)
            {
                datarow = recList[0];
                IsNewRow = false;
                FillData();
            }
            else
            {
                using (frmMemberSelection selectionForm = new frmMemberSelection(recList))
                {
                    if (selectionForm.ShowDialog() == DialogResult.OK)
                    {
                        datarow = selectionForm.SelectedMember;
                        IsNewRow = false;
                        FillData();
                    }
                }
            }

        }

        private void btnSearchById_Click(object sender, EventArgs e)
        {
            string id = txtMemberID.Text;
            if (string.IsNullOrEmpty(id)) return;

            datarow = BR.Member.GetById(id);

            if (datarow == null)
            {
                MessageBox.Show("No Member with this Id found");
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
