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
    public partial class Login : Form
    {
        public int Lvl { get; private set; }
        public Login()
        {
            
            InitializeComponent();
        }
        LogInBL bl = new LogInBL();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Lvl = bl.LogIn(txtUsername.Text, txtPassword.Text);
            if (Lvl > 0)
            {
                MessageBox.Show(bl.LogInMessage);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(bl.LogInMessage);
                DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
