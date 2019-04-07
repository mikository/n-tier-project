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

namespace ABC
{
    public partial class ResourceLookUp : Template
    {
        public ResourceLookUp(bool ReadOnly = true)
        {
            InitializeComponent();
            SetReadOnly(ReadOnly);
        }
        Resource resource;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ResourceBL bl = new ResourceBL();
                resource = bl.ResourceRetrieve(txtSearch.Text);
                LoadResource(resource);
                SetState(2);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SetReadOnly(bool ReadOnly)
        {
            foreach(Control c in gbxResource.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).ReadOnly = ReadOnly;
                else if (c is ComboBox)
                    ((ComboBox)c).Enabled = !ReadOnly;
                else if (c is DateTimePicker)
                    ((DateTimePicker)c).Enabled = !ReadOnly;
            }
        }
        private void SetState(int state)
        {
            switch(state)
            {
                case 1:
                    gbxSearch.Visible = true;
                    gbxResource.Visible = false;
                    btnAddToLoan.Visible = false ;
                    break;
                case 2:
                    gbxSearch.Visible = true;
                    gbxResource.Visible = true;
                    btnAddToLoan.Visible = true;
                    break;
            }
        }
        
        private void BindCombo()
        {
            cmbStatus.DataSource = Enum.GetValues(typeof(ResourceStatus));
            cmbType.DataSource = Enum.GetValues(typeof(ResourseType));
        }

        private void LoadResource(Resource r)
        {
            txtDescription.Text = r.Description;
            txtID.Text = r.Id.ToString();
            txtPrice.Text = r.Price.ToString("c");
            if (r.ReservedBy != null)
                txtReserved.Text = r.ReservedBy.LastName + ", " + r.ReservedBy.FirstName;
            else
                txtReserved.Text = "Not Reserved";
            txtTitle.Text = r.Title;
            dtpPurchased.Value = r.DatePurchased;
            if (r.DateRemoved != null)
            {
                dtpRemoved.Value = (DateTime)r.DateRemoved;
                lblremoved.Visible = true;
                dtpRemoved.Visible = true;
            }
            else
            {
                lblremoved.Visible = false;
                dtpRemoved.Visible = false;
            }
            cmbStatus.Text = r.Status.ToString();
            cmbType.Text = r.Type.ToString();
        }
        private void Resources_Load(object sender, EventArgs e)
        {
            SetState(1);
            BindCombo();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller.AssignResource(resource);
            this.Close();
        }
    }
}
