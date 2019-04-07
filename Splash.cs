using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace ABC
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            
        }
        private void Splash_Load(object sender, EventArgs e)
        {

            label1.Text = "ABC Resources";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
