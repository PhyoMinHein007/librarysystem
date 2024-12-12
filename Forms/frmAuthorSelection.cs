using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.Forms
{
    public partial class frmAuthorSelection : Form
    {
        public Library.BizO.Author SelectedAuthor { get; private set; }

        public frmAuthorSelection(List<Library.BizO.Author> authors)
        {
            InitializeComponent();
            dataGridViewAuthors.DataSource = authors;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (dataGridViewAuthors.SelectedRows.Count > 0)
            {
                SelectedAuthor = (Library.BizO.Author)dataGridViewAuthors.SelectedRows[0].DataBoundItem;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select an author.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
