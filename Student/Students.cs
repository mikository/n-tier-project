
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC
{
    public partial class Students :Template
    {
        public Students()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
        {

        }
        List<Models.Student> students = new List<Models.Student>();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            StudentsBL bl = new StudentsBL();
            students = bl.Search(txtSearch.Text);
            dgvResult.DataSource = students;
            
            foreach(DataGridViewColumn c in dgvResult.Columns)
            {
                c.Visible = false;
            }
            dgvResult.Columns["Id"].Visible = true;
            dgvResult.Columns["Id"].Width = 68;
            dgvResult.Columns["LastName"].Visible = true;
            dgvResult.Columns["LastName"].Width = 95;
            dgvResult.Columns["FirstName"].Visible = true;
            dgvResult.Columns["FirstName"].Width = 77;
            dgvResult.Columns["Status"].Visible = true;
            dgvResult.Columns["Status"].Width = 77;
            dgvResult.RowHeadersVisible = false;
        }

        private void dgvResult_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Controller.AssignStudent(students[e.RowIndex]);
            this.Close();
        }
    }
}
