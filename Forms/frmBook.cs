using Library.Base;
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
using static Library.Utilities.Flags;

namespace Library.Forms
{
    public partial class frmBook : Form
    {
        Library.BizO.Book datarow = new();
        List<Library.BizO.BookCategory> categoryList;

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
                txtBookId.Enabled = _isNewRow;
            }
        }

        public frmBook()
        {
            InitializeComponent();
        }

        private void frmBook_Load(object sender, EventArgs e)
        {
            DataGridViewComboBoxColumn authorComboBox = (DataGridViewComboBoxColumn)dvgAuthors.Columns["AuthorComboBox"];

            authorComboBox.DataSource = Library.Cruder.Author.GetAllAuthors();
            authorComboBox.DisplayMember = "AuthorName";
            authorComboBox.ValueMember = "AuthorId";

            categoryList = Library.Cruder.BookCategory.GetAllCategory();
            cboCategory.DataSource = categoryList;
            cboCategory.DisplayMember = "CatName";
            cboCategory.ValueMember = "CatId";

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
            txtBookId.Text = datarow.BookId;
            txtTitle.Text = datarow.Title;
            txtISBN.Text = datarow.ISBN;
            txtPublisher.Text = datarow.Publisher;
            txtPubYear.Text = datarow.YearPublished;
            if (!string.IsNullOrEmpty(datarow.CatId) &&
                categoryList.Any(x => x.CatId == datarow.CatId))
            {
                cboCategory.SelectedValue = datarow.CatId;
            }
            else
            {
                cboCategory.SelectedIndex = -1;
            }

            BindAvailabilityStatus();

            dvgAuthors.Rows.Clear();

            var bookAuthors = Library.Cruder.BookAuthor.GetByBookId(datarow.BookId);
            foreach (var bookAuthor in bookAuthors)
            {
                var rowIndex = dvgAuthors.Rows.Add();
                var row = dvgAuthors.Rows[rowIndex];


                row.Cells["AuthorComboBox"].Value = bookAuthor.AuthorId;
            }
        }

        private void CopyBack()
        {
            datarow.BookId = txtBookId.Text;
            datarow.Title = txtTitle.Text;
            datarow.ISBN = txtISBN.Text;
            datarow.Publisher = txtPublisher.Text;
            datarow.YearPublished = txtPubYear.Text;
            datarow.CatId = cboCategory.SelectedValue?.ToString();

            if (rdoAvailable.Checked)
                datarow.AvailabilityStatus = AvailabilityStatus.Available;
            else if (rdoRentOut.Checked)
                datarow.AvailabilityStatus = AvailabilityStatus.RentOut;
            else if (rdoCompensated.Checked)
                datarow.AvailabilityStatus = AvailabilityStatus.Compensated;
            else if (rdoNotForRentOut.Checked)
                datarow.AvailabilityStatus = AvailabilityStatus.NotForRentOut;
            else if (rdoNoReturned.Checked)
                datarow.AvailabilityStatus = AvailabilityStatus.NotReturned;
            else if (rdoDamaged.Checked)
                datarow.AvailabilityStatus = AvailabilityStatus.Damaged;
            else
                datarow.AvailabilityStatus = AvailabilityStatus.None;
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
            string id = txtBookId.Text;
            if (Library.BR.Book.Delete(id))
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
                var existingData = Library.BR.Book.GetById(datarow.BookId);
                if (existingData != null)
                {
                    MessageBox.Show("The Book ID is already in use. Please choose a different ID.");
                    return;
                }

                if (!Library.BR.Book.Save(datarow))
                {
                    MessageBox.Show("Unable to save the book.");
                    return;
                }
            }
            else
            {
                if (!Library.BR.Book.Save(datarow))
                {
                    MessageBox.Show("Unable to update the book.");
                    return;
                }
            }
            SaveAuthors();

            MessageBox.Show("Saved Successfully");
            CreateNewRow();
        }


        private void btnSearchByTitle_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            if (string.IsNullOrEmpty(title)) return;

            datarow = Library.BR.Book.GetByTitle(title);

            if (datarow == null)
            {
                MessageBox.Show("No book with this title found");
                CreateNewRow();
            }
            else
            {
                IsNewRow = false;
                FillData();
            }

        }

        private void btnSearchByISBN_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN.Text;
            if (string.IsNullOrEmpty(isbn)) return;

            datarow = Library.BR.Book.GetByISBN(isbn);

            if (datarow == null)
            {
                MessageBox.Show("No book with this ISBN found");
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
            string id = txtBookId.Text;
            if (string.IsNullOrEmpty(id)) return;

            datarow = BR.Book.GetById(id);

            if (datarow == null)
            {
                MessageBox.Show("No Book with this Id found");
                CreateNewRow();
            }
            else
            {
                IsNewRow = false;
                FillData();
            }

        }

        private void BindAvailabilityStatus()
        {
            // Map enum values to radio buttons
            switch (datarow.AvailabilityStatus)
            {
                case AvailabilityStatus.Available:
                    rdoAvailable.Checked = true;
                    break;
                case AvailabilityStatus.RentOut:
                    rdoRentOut.Checked = true;
                    break;
                case AvailabilityStatus.Compensated:
                    rdoCompensated.Checked = true;
                    break;
                case AvailabilityStatus.NotForRentOut:
                    rdoNotForRentOut.Checked = true;
                    break;
                case AvailabilityStatus.NotReturned:
                    rdoNoReturned.Checked = true;
                    break;
                case AvailabilityStatus.Damaged:
                    rdoDamaged.Checked = true;
                    break;
                case AvailabilityStatus.None:
                default:
                    rdoNone.Checked = true;
                    break;
            }
        }

        private void dvgAuthors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dvgAuthors.Columns["DeleteButton"].Index && e.RowIndex >= 0)
            {
                string authorId = dvgAuthors.Rows[e.RowIndex].Cells["AuthorComboBox"].Value.ToString();

                Library.BR.BookAuthor.Delete(datarow.BookId, authorId);

                dvgAuthors.Rows.RemoveAt(e.RowIndex);

                MessageBox.Show("Author removed successfully.");
            }
        }

        private void SaveAuthors()
        {
            // Get the existing BookAuthors for the book
            var existingAuthors = Library.Cruder.BookAuthor.GetByBookId(datarow.BookId);
            var selectedAuthorIds = new HashSet<string>(); // Track selected authors as strings

            foreach (DataGridViewRow row in dvgAuthors.Rows)
            {
                if (row.Cells["AuthorComboBox"].Value != null)
                {
                    string selectedAuthorId = row.Cells["AuthorComboBox"].Value.ToString();
                    selectedAuthorIds.Add(selectedAuthorId);

                    // Check if this relationship already exists
                    var existingAuthor = existingAuthors.FirstOrDefault(x => x.AuthorId == selectedAuthorId);
                    if (existingAuthor == null)
                    {

                        var newBookAuthor = new Library.BizO.BookAuthor
                        {
                            BookId = datarow.BookId,
                            AuthorId = selectedAuthorId
                        };
                        Library.BR.BookAuthor.Save(newBookAuthor);
                    }
                }
            }

            // Remove any relationships that are no longer selected
            foreach (var existingAuthor in existingAuthors)
            {
                if (!selectedAuthorIds.Contains(existingAuthor.AuthorId))
                {
                    Library.BR.BookAuthor.Delete(existingAuthor.BookId, existingAuthor.AuthorId);
                }
            }
        }


    }
}
