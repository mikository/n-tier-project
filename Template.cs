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
    public partial class Template : Form
    {
        internal int panel = 1;
        public Template()
        {
            InitializeComponent();
            this.TopLevel = false;
        }

        private void TemplateForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Controller.CloseFrom(this);
        }
    }
}
