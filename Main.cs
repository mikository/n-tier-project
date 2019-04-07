
using ABC.LoanMaintanence;
using ABC.Resources;
using ABC.Student;
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
    public partial class Main : Form
    {
        private int lvl;
        public Main()
        {
            InitializeComponent();
            Controller.FormOpened += Controller_FormOpened;
            Controller.FormClosed += Controller_FormClosed;
        }

        private void Controller_FormClosed(object sender, EventArgs e)
        {
            Template t = (Template)sender;
            if (t.panel == 3)
                t.Close();
            else if(t.panel == 2)
            {
                t.Close();
                panel3.Controls.Clear();
            }
            else
            {
                t.Close();
                panel2.Controls.Clear();
                panel3.Controls.Clear();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Splash s = new Splash();
            s.ShowDialog();
            Login l = new Login();
            l.ShowDialog();
            if (l.DialogResult != DialogResult.OK) 
            this.Close();
            lvl = l.Lvl;
        }

        private void Controller_FormOpened(object sender, FormEventArgs e)
        {
            OpenForm((Template)sender);
        }

        internal void OpenForm(Template f)
        {
            switch (f.panel)
            {
                case 1:
                    open(panel1, f);
                    break;
                case 2:
                    open(panel2, f);
                    break;
                case 3:
                    open(panel3, f);
                    break;
                default:
                    open(panel1, f);
                    break;
            }
        }
        private void open(Panel p, Template t)
        {
            foreach (Control c in p.Controls)
                ((Template)c).Close();
            p.Controls.Add(t);
            t.Show();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loan l = new Loan(1);
            Controller.OpenFrom(l, null);
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controller.OpenFrom(new Return());
        }

        private void insertStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controller.OpenFrom(new SingleStudent('c'));
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controller.OpenFrom(new SingleStudent('r'));
        }

        private void reserveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controller.OpenFrom(new Reserve());
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controller.OpenFrom(new AddResource());
        }
    }
}
