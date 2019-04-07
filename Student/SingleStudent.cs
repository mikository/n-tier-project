using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC.Student
{
    public partial class SingleStudent : Template
    {

        Models.Student student;

        public SingleStudent(char state)
        {
            InitializeComponent();
            SetState(state);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void SetState(char state)
        {
            switch(state)
            {
                case 'c':
                    label11.Visible = false;
                    btnInsert.Visible = true;
                    btnDelete.Visible = false;
                    btnUpdate.Visible = false;
                    groupBox1.Visible = true;
                    break;
                case 'r':
                    label11.Visible = true;
                    btnInsert.Visible = false;
                    btnDelete.Visible = true;
                    btnUpdate.Visible = true;
                    groupBox1.Visible = false;
                    Controller.OpenFrom(new Students(), this);
                    break;
            }
        }

        private Models.Student BuildStudent()
        {
            Models.Student s = new Models.Student() ;
            s.Id = txtID.Text;
             s.FirstName = txtFName.Text;
             s.LastName = txtLName.Text;
            s.Address = txtAddress.Text;
            s.City = txtCity.Text;
            s.PostalCode = txtPostal.Text;
            s.PhoneNumber = txtPhone.Text;
            s.StartDate = dtpStart.Value;
            s.EndDate = dtpEnd.Value;
            s.Program = cmbProgram.SelectedItem.ToString();
            s.Status = (StudentStatus)cmbStatus.SelectedItem;
            return s;
        }

        private void SingleStudent_Load(object sender, EventArgs e)
        {
            Controller.StudentPassed += Controller_StudentPassed;
            LoadCombo();
        }

        private void BindStudent(Models.Student s)
        {
            label11.Visible = false;
            groupBox1.Visible = true;
            student = s;
            txtID.Text = s.Id;
            txtFName.Text = s.FirstName;
            txtLName.Text = s.LastName;
            txtAddress.Text = s.Address;
            txtCity.Text = s.City;
            txtPostal.Text = s.PostalCode;
            txtPhone.Text = s.PhoneNumber;
            dtpStart.Value = s.StartDate;
            dtpEnd.Value = s.EndDate;
            cmbProgram.SelectedItem = s.Program;
            cmbStatus.SelectedItem = s.Status;
            lblBlance.Text = s.BalanceDue.ToString("c");
        }

        private void LoadCombo()
        {
            cmbStatus.DataSource = Enum.GetValues(typeof(StudentStatus));
            cmbProgram.DataSource = new string[]{ "ful", "par"};
        }

        private void Controller_StudentPassed(object sender, EventArgs e)
        {
            BindStudent((Models.Student)sender);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            StudentsBL bl = new StudentsBL();
            if (bl.StudentUpdate(BuildStudent()))
            {
                MessageBox.Show("Updated successfully");
            }
            else
            {
                MessageBox.Show("Not Updated");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                StudentsBL bl = new StudentsBL();
                if(bl.StudentDelete(BuildStudent()))
                {
                    MessageBox.Show("Deleted successfully");
                }
                else
                {
                    MessageBox.Show("Not Deleted");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                StudentsBL bl = new StudentsBL();
                if (bl.StudentInsert(BuildStudent()))
                {
                    MessageBox.Show("Inserted successfully");
                }
                else
                {
                    MessageBox.Show("Not Inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtID_Validating(object sender, CancelEventArgs e)
        {
            if(txtID.Text.Length != 8 || !int.TryParse(txtID.Text, out int a))
            {
                err.SetError(txtID, "Invalid ID");
            }
            else
            {
                err.SetError(txtID, "");
            }
        }
        private void txt_emptyValidation(object sender, CancelEventArgs e)
        {
            if (((TextBox)sender).Text.Length < 1)
            {
                err.SetError((Control)sender, "Cannot be empty");
            }
            else
            {
                err.SetError((Control)sender, "");
            }
        }

        private void txtPostal_Validating(object sender, CancelEventArgs e)
        {
            //string regexp = @"/^[A - Za - z]\d[A - Za - z][-] ?\d[A - Za - z]\d$/";
            Regex r = new Regex("[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ][0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]");
            Match m = r.Match(txtPostal.Text);
            if (m.Success)
                err.SetError(txtPostal, "");
            else
                err.SetError(txtPostal, "Postal Code is no in a correct format");
        }

        private void SingleStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Controller.StudentPassed -= Controller_StudentPassed;
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (txtPhone.Text.Length != 11 || !Regex.IsMatch(txtPhone.Text, @"^\d+$"))
            {
                err.SetError(txtPhone, "Phone number incorrect format");
            }
            else
            {
                err.SetError(txtPhone, "");
            }
        }
    }
}
