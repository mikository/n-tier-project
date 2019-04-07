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
    public partial class AddResource : Template
    {
        public AddResource()
        {
            InitializeComponent();
            SetUpCombo();
        }

        private void SetUpCombo()
        {
            cmbStatus.DataSource = Enum.GetValues(typeof(ResourceStatus));
            cmbType.DataSource = Enum.GetValues(typeof(ResourseType));
        }

        

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (txtTitle.Text.Length < 1)
                err.SetError(txtTitle, "Title cannot be empty");
            else
                err.SetError(txtTitle, "");
        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprice_Validating(object sender, CancelEventArgs e)
        {
            if (txtprice.Text.Length < 1 || !double.TryParse(txtprice.Text, out double a))
                err.SetError(txtprice, "Price invalid");
            else
                err.SetError(txtprice, "");
        }

        private Resource BuildResource()
        {
            Resource r = new Resource();
            r.DatePurchased = DateTime.Now;
            r.Description = txtDescription.Text;
            r.Price = Convert.ToDouble(txtprice.Text);
            r.Status = (ResourceStatus)cmbStatus.SelectedItem;
            r.Title = txtTitle.Text;
            r.Type = (ResourseType)cmbType.SelectedValue;
            return r;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ResourceBL bL = new ResourceBL();
            try
            {
               string id = bL.ResourceInsert(BuildResource());
                MessageBox.Show("Resource is successfully inserted. The id is " +  id);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
