namespace ABC.Resources
{
    partial class Reserve
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.gbxResource = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblResourceStatus = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblReserved = new System.Windows.Forms.Label();
            this.imgImage = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbxStudent = new System.Windows.Forms.GroupBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblProgram = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lstResources = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddResource = new System.Windows.Forms.Button();
            this.gbxResource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgImage)).BeginInit();
            this.gbxStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(457, 676);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(128, 45);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Reserve";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // gbxResource
            // 
            this.gbxResource.Controls.Add(this.lblTitle);
            this.gbxResource.Controls.Add(this.lblResourceStatus);
            this.gbxResource.Controls.Add(this.lblType);
            this.gbxResource.Controls.Add(this.lblReserved);
            this.gbxResource.Controls.Add(this.imgImage);
            this.gbxResource.Controls.Add(this.button2);
            this.gbxResource.Controls.Add(this.label5);
            this.gbxResource.Controls.Add(this.label6);
            this.gbxResource.Controls.Add(this.label7);
            this.gbxResource.Controls.Add(this.label8);
            this.gbxResource.Location = new System.Drawing.Point(12, 364);
            this.gbxResource.Name = "gbxResource";
            this.gbxResource.Size = new System.Drawing.Size(579, 243);
            this.gbxResource.TabIndex = 6;
            this.gbxResource.TabStop = false;
            this.gbxResource.Text = "Resource";
            // 
            // lblTitle
            // 
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Location = new System.Drawing.Point(82, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(197, 17);
            this.lblTitle.TabIndex = 16;
            // 
            // lblResourceStatus
            // 
            this.lblResourceStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResourceStatus.Location = new System.Drawing.Point(82, 74);
            this.lblResourceStatus.Name = "lblResourceStatus";
            this.lblResourceStatus.Size = new System.Drawing.Size(197, 17);
            this.lblResourceStatus.TabIndex = 15;
            // 
            // lblType
            // 
            this.lblType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblType.Location = new System.Drawing.Point(82, 140);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(197, 17);
            this.lblType.TabIndex = 14;
            // 
            // lblReserved
            // 
            this.lblReserved.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReserved.Location = new System.Drawing.Point(82, 108);
            this.lblReserved.Name = "lblReserved";
            this.lblReserved.Size = new System.Drawing.Size(196, 17);
            this.lblReserved.TabIndex = 13;
            // 
            // imgImage
            // 
            this.imgImage.Location = new System.Drawing.Point(409, 44);
            this.imgImage.Name = "imgImage";
            this.imgImage.Size = new System.Drawing.Size(113, 140);
            this.imgImage.TabIndex = 12;
            this.imgImage.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(472, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 28);
            this.button2.TabIndex = 11;
            this.button2.Text = "Show info";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Reserve:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Title:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Type:";
            // 
            // gbxStudent
            // 
            this.gbxStudent.Controls.Add(this.lblEnd);
            this.gbxStudent.Controls.Add(this.lblStart);
            this.gbxStudent.Controls.Add(this.lblProgram);
            this.gbxStudent.Controls.Add(this.lblLName);
            this.gbxStudent.Controls.Add(this.lblBalance);
            this.gbxStudent.Controls.Add(this.lblStatus);
            this.gbxStudent.Controls.Add(this.lblFName);
            this.gbxStudent.Controls.Add(this.lstResources);
            this.gbxStudent.Controls.Add(this.label12);
            this.gbxStudent.Controls.Add(this.label11);
            this.gbxStudent.Controls.Add(this.label10);
            this.gbxStudent.Controls.Add(this.btnShowInfo);
            this.gbxStudent.Controls.Add(this.label4);
            this.gbxStudent.Controls.Add(this.label3);
            this.gbxStudent.Controls.Add(this.label2);
            this.gbxStudent.Controls.Add(this.label1);
            this.gbxStudent.Location = new System.Drawing.Point(12, 42);
            this.gbxStudent.Name = "gbxStudent";
            this.gbxStudent.Size = new System.Drawing.Size(579, 242);
            this.gbxStudent.TabIndex = 5;
            this.gbxStudent.TabStop = false;
            this.gbxStudent.Text = "Student";
            // 
            // lblEnd
            // 
            this.lblEnd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEnd.Location = new System.Drawing.Point(64, 195);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(137, 17);
            this.lblEnd.TabIndex = 17;
            // 
            // lblStart
            // 
            this.lblStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStart.Location = new System.Drawing.Point(64, 159);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(137, 16);
            this.lblStart.TabIndex = 16;
            // 
            // lblProgram
            // 
            this.lblProgram.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProgram.Location = new System.Drawing.Point(288, 73);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(80, 17);
            this.lblProgram.TabIndex = 15;
            // 
            // lblLName
            // 
            this.lblLName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLName.Location = new System.Drawing.Point(288, 28);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(80, 17);
            this.lblLName.TabIndex = 14;
            // 
            // lblBalance
            // 
            this.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBalance.Location = new System.Drawing.Point(94, 120);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(80, 17);
            this.lblBalance.TabIndex = 13;
            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.Location = new System.Drawing.Point(94, 82);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(80, 17);
            this.lblStatus.TabIndex = 12;
            // 
            // lblFName
            // 
            this.lblFName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFName.Location = new System.Drawing.Point(94, 32);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(80, 17);
            this.lblFName.TabIndex = 5;
            // 
            // lstResources
            // 
            this.lstResources.FormattingEnabled = true;
            this.lstResources.ItemHeight = 16;
            this.lstResources.Location = new System.Drawing.Point(409, 28);
            this.lstResources.Name = "lstResources";
            this.lstResources.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstResources.Size = new System.Drawing.Size(164, 132);
            this.lstResources.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "End:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Start:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Balance:";
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Location = new System.Drawing.Point(472, 208);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(101, 28);
            this.btnShowInfo.TabIndex = 7;
            this.btnShowInfo.Text = "Show info";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Program:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Last Name:";
            // 
            // btnAddResource
            // 
            this.btnAddResource.Location = new System.Drawing.Point(226, 303);
            this.btnAddResource.Name = "btnAddResource";
            this.btnAddResource.Size = new System.Drawing.Size(171, 46);
            this.btnAddResource.TabIndex = 8;
            this.btnAddResource.Text = "Add Resource";
            this.btnAddResource.UseVisualStyleBackColor = true;
            this.btnAddResource.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 762);
            this.Controls.Add(this.btnAddResource);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.gbxResource);
            this.Controls.Add(this.gbxStudent);
            this.Name = "Reserve";
            this.Text = "Reserve";
            this.Load += new System.EventHandler(this.Reserve_Load);
            this.Controls.SetChildIndex(this.gbxStudent, 0);
            this.Controls.SetChildIndex(this.gbxResource, 0);
            this.Controls.SetChildIndex(this.btnReturn, 0);
            this.Controls.SetChildIndex(this.btnAddResource, 0);
            this.gbxResource.ResumeLayout(false);
            this.gbxResource.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgImage)).EndInit();
            this.gbxStudent.ResumeLayout(false);
            this.gbxStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.GroupBox gbxResource;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblResourceStatus;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblReserved;
        private System.Windows.Forms.PictureBox imgImage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbxStudent;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.ListBox lstResources;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddResource;
    }
}