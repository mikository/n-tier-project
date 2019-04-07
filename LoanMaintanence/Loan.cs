using ABC;
using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC
{
    public partial class Loan :  Template
    {
        int state;
        public Loan(int s)
        {
            InitializeComponent();
            state = s;
        }
        Models.Student student;
        ObservableCollection<Resource> resources = new ObservableCollection<Resource>();
        private void Loan_Load(object sender, EventArgs e)
        {
            Controller.StudentPassed += Controller_StudentPassed;
            Controller.ResourcePassed += Controller_ResourcePassed;
            Controller.OpenFrom(new Students(), this);
            SetState(0);
            BindResources();
        }
        private void BindResources()
        {
            //lstResourcesToOrder.BindingContext = new BindingContext();
            lstResourcesToOrder.DisplayMember = "Title";
            lstResourcesToOrder.ValueMember = "Id";
            //lstResourcesToOrder.DataSource = resources;
        }
        private bool CheckPassedResource(Resource r)
        {
            foreach(Resource re in lstResourcesToOrder.Items.Cast<Resource>())
            {
                if (re.Id == r.Id || re.Type == r.Type)
                    return false;
            }
            return true;
        }
        private void Controller_ResourcePassed(object sender, EventArgs e)
        {
            if (CheckPassedResource((Resource)sender))
            {
                resources.Add((Resource)sender);
                lstResourcesToOrder.Items.Add((Resource)sender);
                SetState(2);
                ShowResource((Resource)sender);
            }
            else
            {
                MessageBox.Show("The resource or the resource of the same type is already in the loan");
            }
        }

        private void Controller_StudentPassed(object sender, EventArgs e)
        {
            student = (Models.Student)sender;
            BindStudent();
            SetState(1);
        }
        private void BindStudent()
        {
            try
            {
                ResourceBL bl = new ResourceBL();
                lblFName.Text = student.FirstName;
                lblLName.Text = student.LastName;
                lblProgram.Text = student.Program;
                lblBalance.Text = student.BalanceDue.ToString("c");
                lblEnd.Text = student.EndDate.ToShortDateString();
                lblStart.Text = student.StartDate.ToShortDateString();
                lblStatus.Text = student.Status.ToString();
                lstResources.DataSource = bl.ResourcesByStudent(student);
                lstResources.DisplayMember = "Title";
                //go to bl to get llist of resources here
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SetState(int state)
        {
            if (this.state == 1)
            {
                switch (state)
                {
                    case 0:
                        lstResourcesToOrder.Visible = false;
                        btnRemove.Visible = false;
                        gbxResource.Visible = false;
                        gbxStudent.Visible = false;
                        btnAddResource.Visible = false;
                        btnAddStudent.Visible = true;
                        btnProceed.Enabled = false;
                        break;
                    case 1:
                        lstResourcesToOrder.Visible = true;
                        btnRemove.Visible = false;
                        gbxResource.Visible = false;
                        gbxStudent.Visible = true;
                        btnAddResource.Visible = true;
                        btnAddStudent.Visible = false;
                        btnProceed.Enabled = false;
                        break;
                    case 2:
                        lstResourcesToOrder.Visible = true;
                        btnRemove.Visible = true;
                        gbxResource.Visible = true;
                        gbxStudent.Visible = true;
                        btnAddResource.Visible = true;
                        btnAddStudent.Visible = false;
                        btnProceed.Enabled = true;
                        break;
                }
            }
            else if(this.state == 2)
            {

            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Controller.OpenFrom(new Students(), this);
        }

        private void btnAddResource_Click(object sender, EventArgs e)
        {
            Controller.OpenFrom(new ResourceLookUp(), this);
        }
        private void ShowResource(Resource r)
        {
            lblTitle.Text = r.Title;
            lblType.Text = r.Type.ToString();
            lblResourceStatus.Text = r.Status.ToString();
            lblReserved.Text = r.ReservedBy is null ? "Not reserved" : r.ReservedBy.LastName + ", " + r.ReservedBy.FirstName;
        }
        private void lstResourcesToOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((Resource)lstResourcesToOrder.SelectedItem != null)
            {
                ShowResource((Resource)lstResourcesToOrder.SelectedItem);
                SetState(2);
            }
        }
        private Models.Loan PopulateLoan()
        {
            Models.Loan res = new Models.Loan();
            res.Student = student;
            res.Resource = lstResourcesToOrder.Items.Cast<Models.Resource>().ToList<Models.Resource>();
            res.CheckOutDate = DateTime.Now;
            return res;
        }
        private void btnProceed_Click(object sender, EventArgs e)
        {
            try
            {
                LoanBL bl = new LoanBL();
                MessageBox.Show(bl.CreateLoan(PopulateLoan()));
                Controller.CloseFrom(this);
            }
            catch(LoanCreateException ex)
            {
                MessageBox.Show("Loan did not pass validation: " + ex.Message);
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstResourcesToOrder.SelectedItem != null)
            {
                lstResourcesToOrder.Items.Remove(lstResourcesToOrder.SelectedItem);
                gbxResource.Visible = false;
            }
        }

        private void Loan_FormClosing(object sender, FormClosingEventArgs e)
        {
            Controller.ResourcePassed -= Controller_ResourcePassed;
            Controller.StudentPassed -= Controller_StudentPassed;
        }
    }
}
