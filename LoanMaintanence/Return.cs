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

namespace ABC.LoanMaintanence
{
    public partial class Return : Template
    {
        
        Models.Loan loan;
        bool damaged;
        public Return()
        {
            InitializeComponent();
        }

        private void SetState(short state)
        {
            switch (state)
            {
                case 1:
                    gbxLoanInfo.Visible = false;
                    gbxResource.Visible = false;
                    gbxStudent.Visible = false;
                    btnReturn.Visible = false;
                    break;
                case 2:
                    gbxLoanInfo.Visible = true;
                    gbxResource.Visible = true;
                    gbxStudent.Visible = true;
                    btnReturn.Visible = true;
                    break;
            }
        }

        private void Return_Load(object sender, EventArgs e)
        {
            Controller.OpenFrom(new ResourceLookUp(), this);
            Controller.ResourcePassed += Controller_ResourcePassed;
            SetState(1);
        }

        private void Controller_ResourcePassed(object sender, EventArgs e)
        {
            LoanBL bl = new LoanBL();
            Models.Loan l = bl.RetrieveLoanByResource((Resource)sender);
            loan = l;
            BindStudent(loan.Student);
            BindResources(l.Resource);
            BindDates();
            SetState(2);
        }
        private void BindDates()
        {
            dtpDateBorrowed.Value = loan.CheckOutDate;
            dtpDueDate.Value = loan.DueDate;
            dtpReturned.Value = DateTime.Now;
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

        private void BindResources(List<Models.Resource> r)
        {
            lstResources.DataSource = r;
            lstResources.DisplayMember = "Title";
        }
        private void ShowResource(Resource r)
        {
            gbxResource.Visible = true;
            lblTitle.Text = r.Title;
            lblType.Text = r.Type.ToString();
            lblResourceStatus.Text = r.Status.ToString();
            lblReserved.Text = r.ReservedBy is null ? "Not reserved" : r.ReservedBy.LastName + ", " + r.ReservedBy.FirstName;
        }

        private void lstResources_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstResources.SelectedItems.Count > 0)
                ShowResource((Resource)lstResources.SelectedItem);
            else
                HideResource();
        }
        private void HideResource()
        {
            gbxResource.Visible = false;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ((Resource)lstResources.SelectedItem).Status =  checkBox1.Checked?ResourceStatus.NotAvailable: ResourceStatus.OnLoan;
            damaged = checkBox1.Checked;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (lstResources.SelectedItems.Count < 1)
                MessageBox.Show("Please select resources to return");
            else 
            {
                string message = "";
                ResourceBL bl = new ResourceBL();
                bool res = true;
                foreach (object o in lstResources.SelectedItems)
                {
                    Resource r = (Resource)o;
                    bool temp = bl.ReturnResource(r);
                    if (!temp)
                        message += "\nResource " + r.Title + " cannot be returned";
                    else
                        loan.Resource.Remove(r);

                    res = temp ? res : false;
                }
                if (res)
                {
                    message = "All Items were successfully returned" + message;
                }
                else
                {
                    message = "Not all Items were successfully returned" + message;
                }
            }
        }

        private void Return_FormClosing(object sender, FormClosingEventArgs e)
        {
            Controller.ResourcePassed -= Controller_ResourcePassed;
        }
    }
}
