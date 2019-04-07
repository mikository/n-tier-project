using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using sql = System.Data.SqlClient;

namespace MyLibrary
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        internal void color()
        {
            foreach(Control a in this.Controls)
            {
                a.BackColor = Color.DarkBlue;
            }
        }

        internal DataSet GetData(string sqlStatement, string tableName = "table")
        {
            sql.SqlConnection cnn = new sql.SqlConnection(Properties.Settings.Default.cnnString);
            sql.SqlCommand stmnt = new sql.SqlCommand(sqlStatement, cnn);
            sql.SqlDataAdapter da = new sql.SqlDataAdapter(stmnt);
            DataSet ds = new DataSet();
            da.Fill(ds, tableName);
            return ds;
        }

        internal void SendData(string sqlStatement)
        {
            sql.SqlConnection cnn = new sql.SqlConnection(Properties.Settings.Default.cnnString);
            sql.SqlCommand stmnt = new sql.SqlCommand(sqlStatement, cnn);
            using (cnn)
            {
                cnn.Open();
                int count = stmnt.ExecuteNonQuery();
                cnn.Close();
            }
        }

        internal int SendDataWithParms(string SQLStatement, ArrayList theNames, ArrayList theValues)
        {
            sql.SqlConnection cnn = new sql.SqlConnection(Properties.Settings.Default.cnnString);
            sql.SqlCommand cmd = new sql.SqlCommand();
           

            cmd.Connection = cnn;
            cmd.CommandText = SQLStatement;
            for (int i = 0; i <= theNames.Count - 1; i++)
            {
                cmd.Parameters.AddWithValue(Convert.ToString(theNames[i]), theValues[i]);
            }
            using (cnn)
            {
                cnn.Open();
                return (int)cmd.ExecuteNonQuery();
            }
        }

        internal void gridFormOpen(Panel Dest, string select)
        {
            splRight.Panel2.Controls.Clear();
            splRight.Panel1.Controls.Clear();
            grid myOrders = new grid(this, select);
            myOrders.TopLevel = false;
            myOrders.ShowInTaskbar = false;
            myOrders.ControlBox = false;
            myOrders.Text = "";
            myOrders.FormBorderStyle = FormBorderStyle.None;
            Dest.Controls.Add(myOrders);
            myOrders.Show();
        }

        internal void openForm(Panel Dest, inquiry2 myInq)                //inquary overload
        {
            splRight.Panel2.Controls.Clear();
            splRight.Panel1.Controls.Clear();
            Dest.Controls.Clear();
            myInq.TopLevel = false;
            myInq.ShowInTaskbar = false;
            myInq.ControlBox = false;
            myInq.Text = "";
            myInq.FormBorderStyle = FormBorderStyle.None;
            Dest.Controls.Add(myInq);
            myInq.Show();

        }

        internal void openForm(Panel Dest, inquiry myInq)                //inquary overload
        {
            splRight.Panel2.Controls.Clear();
            splRight.Panel1.Controls.Clear();
            Dest.Controls.Clear();
            myInq.TopLevel = false;
            myInq.ShowInTaskbar = false;
            myInq.ControlBox = false;
            myInq.Text = "";
            myInq.FormBorderStyle = FormBorderStyle.None;
            Dest.Controls.Add(myInq);
            myInq.Show();

        }

        internal void openForm(Panel Dest, grid myGrid)                //grid overload
        {
            splRight.Panel2.Controls.Clear();
            splRight.Panel1.Controls.Clear();
            Dest.Controls.Clear();
            myGrid.TopLevel = false;
            myGrid.ShowInTaskbar = false;
            myGrid.ControlBox = false;
            myGrid.Text = "";
            myGrid.FormBorderStyle = FormBorderStyle.None;
            Dest.Controls.Add(myGrid);
            myGrid.Show();
            
        }

        internal void openForm(Panel Dest, books myBooks)               //books overload
        {
            splRight.Panel2.Controls.Clear();
            Dest.Controls.Clear();
            myBooks.TopLevel = false;
            myBooks.ShowInTaskbar = false;
            myBooks.ControlBox = false;
            myBooks.Text = "";
            myBooks.FormBorderStyle = FormBorderStyle.None;
            Dest.Controls.Add(myBooks);
            myBooks.Show();
        }

        internal void openForm(Panel Dest, Customer myCustomer)    //customer overload
        {
            splRight.Panel2.Controls.Clear();
            Dest.Controls.Clear();
            myCustomer.TopLevel = false;
            myCustomer.ShowInTaskbar = false;
            myCustomer.ControlBox = false;
            myCustomer.Text = "";
            myCustomer.FormBorderStyle = FormBorderStyle.None;
            Dest.Controls.Add(myCustomer);
            myCustomer.Show();
        } 

        internal void openForm(Panel Dest, CustomGrid myGrid)
        {
            splRight.Panel2.Controls.Clear();
            Dest.Controls.Clear();
            myGrid.TopLevel = false;
            myGrid.ShowInTaskbar = false;
            myGrid.ControlBox = false;
            myGrid.Text = "";
            myGrid.FormBorderStyle = FormBorderStyle.None;
            Dest.Controls.Add(myGrid);
            myGrid.Show();
        }

        internal void openForm(Panel Dest, OrderDetails od)
        {
            Dest.Controls.Clear();
            od.TopLevel = false;
            od.ShowInTaskbar = false;
            od.ControlBox = false;
            od.Text = "";
            od.FormBorderStyle = FormBorderStyle.None;
            Dest.Controls.Add(od);
            od.Show();
        }

        internal void clearPanel(Panel pan)
        {
            pan.Controls.Clear();
        }

        internal string ButtonType = "";

        private void BooksFormOpen(Panel dest)
        {
            //books myBooks = new books(this);
            //myBooks.TopLevel = false;
            //myBooks.ShowInTaskbar = false;
            //myBooks.ControlBox = false;
            //myBooks.Text = "";
            //myBooks.FormBorderStyle = FormBorderStyle.None;
           //dest.Controls.Add(myBooks);
            //myBooks.Show();
        }

        private void CustomerFormOpen(Panel Dest)
        {
            //Customer myCustomer = new Customer(this);
            //myCustomer.TopLevel = false;
            //myCustomer.ShowInTaskbar = false;
            //myCustomer.ControlBox = false;
            //myCustomer.Text = "";
            //myCustomer.FormBorderStyle = FormBorderStyle.None;
            //Dest.Controls.Add(myCustomer);
            //myCustomer.Show();
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClearRightPanels()
        {
            splRight.Panel2.Controls.Clear();
            splRight.Panel1.Controls.Clear();
            splRight.Panel2.Controls.Clear();
        }

        private void temp()
        {
            //gridFormOpen(splMain1.Panel1,"books");
            //BooksFormOpen(splRight.Panel1);
            //CustomerFormOpen(splRight.Panel2);
            books myBooks = new books(this, "");
            openForm(splMain1.Panel1, myBooks);


            ButtonType = "Orders";
        }
        internal string UserName = "";

        private void MainForm_Load(object sender, EventArgs e)
        {

            //color();
            //openForm(splRight.Panel1, new OrderDetails(this));
            Splash mySplash = new Splash();

            mySplash.ShowDialog();

            LogIn myLog = new LogIn(this);

            myLog.ShowDialog();
            if (myLog.DialogResult != DialogResult.OK)
            this.Close();

            //temp();

            //ClearRightPanels();
            toolStripStatusLabel3.Text = "Ready...";
            toolStripStatusLabel2.Text = UserName;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
      
            openForm(splMain1.Panel1, new grid(this, "Books"));
            clearPanel(splRight.Panel1);
            clearPanel(splRight.Panel2);
            //  OrdersFormOpen(splMain1.Panel1);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            openForm(splMain1.Panel1, new grid(this, "Orders"));
            clearPanel(splRight.Panel1);
            clearPanel(splRight.Panel2);
            //OrdersFormOpen(splMain1.Panel1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = System.DateTime.Now.ToShortTimeString();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            openForm(splMain1.Panel1, new grid(this, "Customers"));
            clearPanel(splRight.Panel1);
            clearPanel(splRight.Panel2);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AboutBox1 myAbout = new AboutBox1();
            myAbout.ShowDialog();
        }

        private void customerStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inquiry myInq = new inquiry(this);
            openForm(splMain1.Panel1, myInq);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            inquiry2 newInq = new inquiry2(this);
            openForm(splMain1.Panel1, newInq);
        }
    }
}
