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
    public partial class frmRental : Form
    {
        Library.BizO.Rental datarow = new();

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
                txtRentalID.Enabled = _isNewRow;
                
            }
        }

        public frmRental()
        {
            InitializeComponent();
        }

        private void frmRental_Load(object sender, EventArgs e)
        {
            ConfigureRentalDetailGrid();
            CreateNewRow();
        }

        private void CreateNewRow()
        {
            datarow = new();
            datarow.RentalDetails = new();
            IsNewRow = true;
            FillData();
        }

        private void FillData()
        {
            txtRentalID.Text = datarow.RentalId;
            txtMemberID.Text = datarow.MemberId;
            txtLibrarianID.Text = datarow.UserId;
            dgvRentalDetail.Rows.Clear();
            if (!IsNewRow)
            {
                dtRental.Value = datarow.RentalDate;
                if (datarow.DateToReturn < dtToReturn.MinDate)
                {
                    dtToReturn.MinDate = DateTime.Today.AddDays(1); 
                    dtToReturn.Value = dtToReturn.MinDate; 
                }
                else
                {
                    dtToReturn.Value = datarow.DateToReturn;
                }


                foreach (var rentalDetail in datarow.RentalDetails)
                {
                    int rowIdx = dgvRentalDetail.Rows.Add();
                    DataGridViewRow row = dgvRentalDetail.Rows[rowIdx];

                    row.Cells["gcBookId"].Value = rentalDetail.BookId;
                    row.Cells["gcIsReturned"].Value = rentalDetail.IsReturned;
                    if ((bool)rentalDetail.IsReturned && rentalDetail.ReturnDate != DateTime.MinValue)
                    {
                        row.Cells["gcReturnedDate"].Value = rentalDetail.ReturnDate;
                    }
                    else
                    {
                        row.Cells["gcReturnedDate"].Value = null;
                    }
                    row.Cells["gcReturnStatus"].Value = rentalDetail.ReturnStatus;
                }
            }
            else
            {
                dtRental.Value = DateTime.Today;
                dtToReturn.MinDate = DateTime.Today.AddDays(1);
                dtToReturn.Value = dtToReturn.MinDate;
            }

        }

        private bool CopyBack()
        {
            try
            {
                datarow.RentalId = txtRentalID.Text;
                datarow.MemberId = txtMemberID.Text;
                datarow.UserId = txtLibrarianID.Text;
                datarow.RentalDate = dtRental.Value;
                datarow.DateToReturn = dtToReturn.Value;

                List<BizO.RentalDetail> tempRentalDetails = new();

                foreach (DataGridViewRow row in dgvRentalDetail.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        BizO.RentalDetail rentalDetail = new()
                        {
                            BookId = row.Cells["gcBookId"].Value?.ToString() ?? "Unknown",
                            IsReturned = row.Cells["gcIsReturned"].Value != null
                                        && (bool)row.Cells["gcIsReturned"].Value,
                            ReturnDate = row.Cells["gcReturnedDate"].Value == null
                                        ? DateTime.MinValue
                                        : ParseDate(row.Cells["gcReturnedDate"].Value),
                            ReturnStatus = row.Cells["gcReturnStatus"].Value != null
                                        ? (ReturnStatus)row.Cells["gcReturnStatus"].Value
                                        : ReturnStatus.None
                        };

                        tempRentalDetails.Add(rentalDetail);
                    }
                }

                datarow.RentalDetails = tempRentalDetails;

                return true;
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Please enter the dates in the correct format (e.g., 'MM/dd/yyyy').");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false; 
        }



        private DateTime ParseDate(object cellValue)
        {
            if (DateTime.TryParse(cellValue.ToString(), out DateTime parsedDate))
            {
                return parsedDate;
            }
            else
            {
                throw new FormatException($"The value '{cellValue}' is not a valid date.");
            }
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
            string id = txtRentalID.Text;
            if (Library.BR.Rental.Delete(id))
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
            if (!CopyBack())
            {
                return;
            }

            if (IsNewRow)
            {
                var existingData = Library.BR.Rental.GetById(datarow.RentalId);
                if (existingData != null)
                {
                    MessageBox.Show("The Rental ID is already in use. Please choose a different ID.");
                    return;
                }
            }

            if (Library.BR.Rental.SaveOrUpdate(datarow, IsNewRow))
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
            string id = txtRentalID.Text;
            if (string.IsNullOrEmpty(id)) return;

            datarow = BR.Rental.GetById(id);

            if (datarow == null)
            {
                MessageBox.Show("No Rental with this Id found");
                CreateNewRow();
            }
            else
            {
                IsNewRow = false;
                FillData();
            }

        }

        private void ConfigureRentalDetailGrid()
        {
            dgvRentalDetail.Columns["gcReturnedDate"].DefaultCellStyle = new DataGridViewCellStyle
            {
                Format = "d"
            };

           
            var isReturnedSource = new Dictionary<bool, string>
                {
                    { true, "Yes" },
                    { false, "No" }
                };

            ((DataGridViewComboBoxColumn)dgvRentalDetail.Columns["gcIsReturned"]).DataSource = new BindingSource(isReturnedSource, null);
            ((DataGridViewComboBoxColumn)dgvRentalDetail.Columns["gcIsReturned"]).DisplayMember = "Value";
            ((DataGridViewComboBoxColumn)dgvRentalDetail.Columns["gcIsReturned"]).ValueMember = "Key";

            // Configure "ReturnStatus" column
            ((DataGridViewComboBoxColumn)dgvRentalDetail.Columns["gcReturnStatus"]).DataSource = Enum.GetValues(typeof(ReturnStatus));
            ((DataGridViewComboBoxColumn)dgvRentalDetail.Columns["gcReturnStatus"]).ValueType = typeof(ReturnStatus);
        }


        private void dgvRentalDetail_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvRentalDetail.Columns[e.ColumnIndex].Name == "gcReturnedDate")
            {
                // Get the corresponding "IsReturned" value for the current row
                var isReturnedValue = dgvRentalDetail.Rows[e.RowIndex].Cells["gcIsReturned"].Value;

                // If "IsReturned" is null or not true, cancel the edit
                if (isReturnedValue == null || !(bool)isReturnedValue)
                {
                    MessageBox.Show("You can only enter the Returned Date if 'Is Returned' is set to true.");
                    e.Cancel = true;
                }
            }
        }




    }
}
