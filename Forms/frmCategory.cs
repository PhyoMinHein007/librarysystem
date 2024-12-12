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
    public partial class frmCategory : Form
    {
        Library.BizO.BookCategory datarow = new();

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
                txtCatID.Enabled = _isNewRow;
            }
        }

        public frmCategory()
        {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
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
            txtCatID.Text = datarow.CatId;
            txtCatName.Text = datarow.CatName;
        }

        private void CopyBack()
        {
            datarow.CatId = txtCatID.Text;
            datarow.CatName = txtCatName.Text;
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
            string id = txtCatID.Text;
            if (Library.BR.BookCategory.Delete(id))
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
                var existingCategory = Library.BR.BookCategory.GetById(datarow.CatId);
                if (existingCategory != null)
                {
                    MessageBox.Show("The Category ID is already in use. Please choose a different ID.");
                    return;
                }
            }
            if (Library.BR.BookCategory.Save(datarow))
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
            string name = txtCatName.Text;
            if (string.IsNullOrEmpty(name)) return;

            datarow = Library.BR.BookCategory.GetByName(name);

            if (datarow == null)
            {
                MessageBox.Show("No category with this name found");
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
            string id = txtCatID.Text;
            if (string.IsNullOrEmpty(id)) return;

            datarow = BR.BookCategory.GetById(id);

            if (datarow == null)
            {
                MessageBox.Show("No Book Category with this Id found");
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
