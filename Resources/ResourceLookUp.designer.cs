namespace ABC
{
    partial class ResourceLookUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxResource = new System.Windows.Forms.GroupBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dtpRemoved = new System.Windows.Forms.DateTimePicker();
            this.dtpPurchased = new System.Windows.Forms.DateTimePicker();
            this.txtReserved = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblremoved = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imgImage = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.btnAddToLoan = new System.Windows.Forms.Button();
            this.gbxResource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgImage)).BeginInit();
            this.gbxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(289, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(77, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(180, 22);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbxResource
            // 
            this.gbxResource.Controls.Add(this.cmbStatus);
            this.gbxResource.Controls.Add(this.cmbType);
            this.gbxResource.Controls.Add(this.txtDescription);
            this.gbxResource.Controls.Add(this.dtpRemoved);
            this.gbxResource.Controls.Add(this.dtpPurchased);
            this.gbxResource.Controls.Add(this.txtReserved);
            this.gbxResource.Controls.Add(this.txtPrice);
            this.gbxResource.Controls.Add(this.txtTitle);
            this.gbxResource.Controls.Add(this.txtID);
            this.gbxResource.Controls.Add(this.label10);
            this.gbxResource.Controls.Add(this.label9);
            this.gbxResource.Controls.Add(this.lblremoved);
            this.gbxResource.Controls.Add(this.label3);
            this.gbxResource.Controls.Add(this.label2);
            this.gbxResource.Controls.Add(this.imgImage);
            this.gbxResource.Controls.Add(this.label5);
            this.gbxResource.Controls.Add(this.label6);
            this.gbxResource.Controls.Add(this.label7);
            this.gbxResource.Controls.Add(this.label8);
            this.gbxResource.Location = new System.Drawing.Point(12, 104);
            this.gbxResource.Name = "gbxResource";
            this.gbxResource.Size = new System.Drawing.Size(579, 408);
            this.gbxResource.TabIndex = 7;
            this.gbxResource.TabStop = false;
            this.gbxResource.Text = "Resource";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(108, 167);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(210, 24);
            this.cmbStatus.TabIndex = 26;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(108, 100);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(210, 24);
            this.cmbType.TabIndex = 25;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(134, 332);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(312, 60);
            this.txtDescription.TabIndex = 24;
            // 
            // dtpRemoved
            // 
            this.dtpRemoved.Location = new System.Drawing.Point(134, 283);
            this.dtpRemoved.Name = "dtpRemoved";
            this.dtpRemoved.Size = new System.Drawing.Size(230, 22);
            this.dtpRemoved.TabIndex = 23;
            // 
            // dtpPurchased
            // 
            this.dtpPurchased.Location = new System.Drawing.Point(134, 252);
            this.dtpPurchased.Name = "dtpPurchased";
            this.dtpPurchased.Size = new System.Drawing.Size(230, 22);
            this.dtpPurchased.TabIndex = 22;
            // 
            // txtReserved
            // 
            this.txtReserved.Location = new System.Drawing.Point(108, 197);
            this.txtReserved.Name = "txtReserved";
            this.txtReserved.Size = new System.Drawing.Size(210, 22);
            this.txtReserved.TabIndex = 21;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(108, 136);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(210, 22);
            this.txtPrice.TabIndex = 20;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(108, 67);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(210, 22);
            this.txtTitle.TabIndex = 19;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(108, 31);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(210, 22);
            this.txtID.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Description:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Price:";
            // 
            // lblremoved
            // 
            this.lblremoved.AutoSize = true;
            this.lblremoved.Location = new System.Drawing.Point(22, 288);
            this.lblremoved.Name = "lblremoved";
            this.lblremoved.Size = new System.Drawing.Size(106, 17);
            this.lblremoved.TabIndex = 15;
            this.lblremoved.Text = "Date Removed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Date Purchased:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID:";
            // 
            // imgImage
            // 
            this.imgImage.Location = new System.Drawing.Point(433, 35);
            this.imgImage.Name = "imgImage";
            this.imgImage.Size = new System.Drawing.Size(140, 180);
            this.imgImage.TabIndex = 12;
            this.imgImage.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Reserve:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Title:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Type:";
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.btnSearch);
            this.gbxSearch.Controls.Add(this.label1);
            this.gbxSearch.Controls.Add(this.txtSearch);
            this.gbxSearch.Location = new System.Drawing.Point(12, 12);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(391, 70);
            this.gbxSearch.TabIndex = 8;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search";
            // 
            // btnAddToLoan
            // 
            this.btnAddToLoan.Location = new System.Drawing.Point(417, 666);
            this.btnAddToLoan.Name = "btnAddToLoan";
            this.btnAddToLoan.Size = new System.Drawing.Size(155, 48);
            this.btnAddToLoan.TabIndex = 9;
            this.btnAddToLoan.Text = "Add to Loan";
            this.btnAddToLoan.UseVisualStyleBackColor = true;
            this.btnAddToLoan.Click += new System.EventHandler(this.button1_Click);
            // 
            // Resources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 762);
            this.Controls.Add(this.btnAddToLoan);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxResource);
            this.Name = "Resources";
            this.Text = "Resources";
            this.Load += new System.EventHandler(this.Resources_Load);
            this.Controls.SetChildIndex(this.gbxResource, 0);
            this.Controls.SetChildIndex(this.gbxSearch, 0);
            this.Controls.SetChildIndex(this.btnAddToLoan, 0);
            this.gbxResource.ResumeLayout(false);
            this.gbxResource.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgImage)).EndInit();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxResource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblremoved;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imgImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtReserved;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtpRemoved;
        private System.Windows.Forms.DateTimePicker dtpPurchased;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.Button btnAddToLoan;
    }
}