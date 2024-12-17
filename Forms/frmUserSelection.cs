using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Forms
{
    public partial class frmUserSelection : Form
    {
        public Library.BizO.User SelectedUser { get; private set; }
        public frmUserSelection(List<Library.BizO.User> users)
        {
            InitializeComponent();
            dataGridViewUsers.DataSource = users;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                SelectedUser = (Library.BizO.User)dataGridViewUsers.SelectedRows[0].DataBoundItem;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a user.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
