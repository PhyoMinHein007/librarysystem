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
    public partial class frmMemberSelection : Form
    {
        public Library.BizO.Member SelectedMember { get; private set; }

        public frmMemberSelection(List<Library.BizO.Member> members)
        {
            InitializeComponent();
            dataGridViewMembers.DataSource = members;
            dataGridViewMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMembers.Columns[dataGridViewMembers.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (dataGridViewMembers.SelectedRows.Count > 0)
            {
                SelectedMember = (Library.BizO.Member)dataGridViewMembers.SelectedRows[0].DataBoundItem;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a member.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
