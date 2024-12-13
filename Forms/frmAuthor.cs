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
using static System.Net.Mime.MediaTypeNames;

namespace Library.Forms
{
    public partial class frmAuthor : Form
    {
        Library.BizO.Author datarow = new();

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
                txtid.Enabled = _isNewRow;
            }
        }
        public frmAuthor()
        {
            InitializeComponent();
        }


        private void frmAuthor_Load(object sender, EventArgs e)
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
            txtid.Text = datarow.AuthorId;
            txtName.Text = datarow.AuthorName;
            txtEmail.Text = datarow.EMail;
        }

        private void CopyBack()
        {
            datarow.AuthorId = txtid.Text;
            datarow.AuthorName = txtName.Text;
            datarow.EMail = txtEmail.Text;
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
            string id = txtid.Text;
            if (Library.BR.Author.Delete(id))
            {
                MessageBox.Show("Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Fail to delete");
            }
            CreateNewRow();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CopyBack();
            if (IsNewRow)
            {
                var existingAuthor = Library.BR.Author.GetById(datarow.AuthorId);
                if (existingAuthor != null)
                {
                    MessageBox.Show("The Author ID is already in use. Please choose a different ID.");
                    return;
                }
            }
            if (Library.BR.Author.Save(datarow))
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
            string name = txtName.Text;
            if (string.IsNullOrEmpty(name)) return;

            List<Library.BizO.Author> recList = Library.BR.Author.GetByName(name);

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
                using (frmAuthorSelection selectionForm = new frmAuthorSelection(recList))
                {
                    if (selectionForm.ShowDialog() == DialogResult.OK)
                    {
                        datarow = selectionForm.SelectedAuthor;
                        IsNewRow = false;
                        FillData();
                    }
                }
            }

        }

        private void btnSearchById_Click(object sender, EventArgs e)
        {
            string id = txtid.Text;
            if (string.IsNullOrEmpty(id)) return;
            datarow = BR.Author.GetById(id);
            if (datarow == null)
            {
                MessageBox.Show("No Author with this Id found");
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
