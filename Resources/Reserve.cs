using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC.Resources
{
    public partial class Reserve : Template
    {
        public Reserve()
        {
            InitializeComponent();
        }
        Resource resource;
        Models.Student student;
        private void Reserve_Load(object sender, EventArgs e)
        {
            Controller.OpenFrom(new Students(), this);
            Controller.StudentPassed += Controller_StudentPassed;
            Controller.ResourcePassed += Controller_ResourcePassed;
            SetState(1);
        }
        private void BindStudent(Models.Student s)
        {
            try
            {
                lblFName.Text = s.FirstName;
                lblLName.Text = s.LastName;
                lblProgram.Text = s.Program;
                lblBalance.Text = s.BalanceDue.ToString("c");
                lblEnd.Text = s.EndDate.ToShortDateString();
                lblStart.Text = s.StartDate.ToShortDateString();
                lblStatus.Text = s.Status.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ShowResource(Resource r)
        {
            gbxResource.Visible = true;
            lblTitle.Text = r.Title;
            lblType.Text = r.Type.ToString();
            lblResourceStatus.Text = r.Status.ToString();
            lblReserved.Text = r.ReservedBy is null ? "Not reserved" : r.ReservedBy.LastName + ", " + r.ReservedBy.FirstName;
        }
        private void SetState(int state)
        {
            switch (state)
            {
                case 1:
                    foreach (Control c in this.Controls)
                        c.Visible = false;
                    break;
                case 2:
                    gbxStudent.Visible = true;
                    gbxResource.Visible = false;
                    btnAddResource.Visible = true;
                    btnReturn.Visible = false;
                    break;
                case 3:
                    gbxStudent.Visible = true;
                    gbxResource.Visible = true;
                    btnAddResource.Visible = true;
                    btnReturn.Visible = true;
                    break;
            }
        }
        private void Controller_ResourcePassed(object sender, EventArgs e)
        {
            resource = (Resource)sender;
            ShowResource(resource);
            SetState(3);
        }

        private void Controller_StudentPassed(object sender, EventArgs e)
        {
            student = (Models.Student)sender;
            BindStudent(student);
            SetState(2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller.OpenFrom(new ResourceLookUp(), this);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ResourceBL bl = new ResourceBL();
            if(bl.Reserve(resource, student))
            {
                MessageBox.Show("Resource reserved successfully");
            }
            else
            {
                MessageBox.Show("The resource was not reserved:\n" + bl.message);
            }
        }
    }
}
