
namespace DB2_PROJECT
{
    partial class viewCustomers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sortcmb = new System.Windows.Forms.ComboBox();
            this.datav1 = new System.Windows.Forms.DataGridView();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchtb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.viewcustomerorderbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.phonenumbertb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gendertb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.emailtb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.addresstb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dobtb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.datecreatedtb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lastnametb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.customerimagepb = new System.Windows.Forms.PictureBox();
            this.firstnametb = new System.Windows.Forms.TextBox();
            this.lbllastname = new System.Windows.Forms.Label();
            this.usernametb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.useridtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customeridtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clearbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datav1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerimagepb)).BeginInit();
            this.SuspendLayout();
            // 
            // sortcmb
            // 
            this.sortcmb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sortcmb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortcmb.FormattingEnabled = true;
            this.sortcmb.Items.AddRange(new object[] {
            "Customer ID",
            "User ID",
            "Username",
            "First Name",
            "Last Name",
            "Gender",
            "Email",
            "Address"});
            this.sortcmb.Location = new System.Drawing.Point(12, 22);
            this.sortcmb.Name = "sortcmb";
            this.sortcmb.Size = new System.Drawing.Size(240, 25);
            this.sortcmb.TabIndex = 25;
            this.sortcmb.Text = "Sort by";
            this.sortcmb.SelectedIndexChanged += new System.EventHandler(this.sortcmb_SelectedIndexChanged);
            // 
            // datav1
            // 
            this.datav1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datav1.DefaultCellStyle = dataGridViewCellStyle2;
            this.datav1.Location = new System.Drawing.Point(5, 70);
            this.datav1.Name = "datav1";
            this.datav1.RowTemplate.Height = 25;
            this.datav1.Size = new System.Drawing.Size(636, 543);
            this.datav1.TabIndex = 21;
            this.datav1.SelectionChanged += new System.EventHandler(this.datav1_SelectionChanged);
            // 
            // searchbtn
            // 
            this.searchbtn.BackgroundImage = global::DB2_PROJECT.Properties.Resource1.search1;
            this.searchbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchbtn.Image = global::DB2_PROJECT.Properties.Resource1.search;
            this.searchbtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.searchbtn.Location = new System.Drawing.Point(512, 22);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(34, 25);
            this.searchbtn.TabIndex = 24;
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchtb
            // 
            this.searchtb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchtb.Location = new System.Drawing.Point(308, 22);
            this.searchtb.Name = "searchtb";
            this.searchtb.Size = new System.Drawing.Size(198, 25);
            this.searchtb.TabIndex = 23;
            this.searchtb.Text = "search for a customer";
            this.searchtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchtb.TextChanged += new System.EventHandler(this.searchtb_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.viewcustomerorderbtn);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.clearbtn);
            this.groupBox1.Controls.Add(this.deletebtn);
            this.groupBox1.Location = new System.Drawing.Point(647, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 601);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modifications";
            // 
            // viewcustomerorderbtn
            // 
            this.viewcustomerorderbtn.BackColor = System.Drawing.Color.Teal;
            this.viewcustomerorderbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewcustomerorderbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewcustomerorderbtn.Location = new System.Drawing.Point(14, 346);
            this.viewcustomerorderbtn.Name = "viewcustomerorderbtn";
            this.viewcustomerorderbtn.Size = new System.Drawing.Size(121, 63);
            this.viewcustomerorderbtn.TabIndex = 6;
            this.viewcustomerorderbtn.Text = "View Customer\'s orders";
            this.viewcustomerorderbtn.UseVisualStyleBackColor = false;
            this.viewcustomerorderbtn.Click += new System.EventHandler(this.viewcustomerorderbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.phonenumbertb);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.gendertb);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.emailtb);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.addresstb);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dobtb);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.datecreatedtb);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lastnametb);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.customerimagepb);
            this.groupBox2.Controls.Add(this.firstnametb);
            this.groupBox2.Controls.Add(this.lbllastname);
            this.groupBox2.Controls.Add(this.usernametb);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.useridtb);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.customeridtb);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(148, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 573);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // phonenumbertb
            // 
            this.phonenumbertb.Location = new System.Drawing.Point(250, 321);
            this.phonenumbertb.Name = "phonenumbertb";
            this.phonenumbertb.Size = new System.Drawing.Size(175, 23);
            this.phonenumbertb.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(250, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "Phone Number:";
            // 
            // gendertb
            // 
            this.gendertb.Location = new System.Drawing.Point(250, 384);
            this.gendertb.Name = "gendertb";
            this.gendertb.Size = new System.Drawing.Size(175, 23);
            this.gendertb.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(250, 355);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 21);
            this.label11.TabIndex = 26;
            this.label11.Text = "Gender";
            // 
            // emailtb
            // 
            this.emailtb.Location = new System.Drawing.Point(8, 538);
            this.emailtb.Name = "emailtb";
            this.emailtb.Size = new System.Drawing.Size(175, 23);
            this.emailtb.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(250, 501);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 21);
            this.label9.TabIndex = 24;
            this.label9.Text = "Address:";
            // 
            // addresstb
            // 
            this.addresstb.Enabled = false;
            this.addresstb.Location = new System.Drawing.Point(250, 538);
            this.addresstb.Name = "addresstb";
            this.addresstb.Size = new System.Drawing.Size(175, 23);
            this.addresstb.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(8, 501);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 21);
            this.label10.TabIndex = 22;
            this.label10.Text = "Email:";
            // 
            // dobtb
            // 
            this.dobtb.Location = new System.Drawing.Point(8, 461);
            this.dobtb.Name = "dobtb";
            this.dobtb.Size = new System.Drawing.Size(175, 23);
            this.dobtb.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(250, 424);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Date created:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(285, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Customer Image:";
            // 
            // datecreatedtb
            // 
            this.datecreatedtb.Enabled = false;
            this.datecreatedtb.Location = new System.Drawing.Point(250, 461);
            this.datecreatedtb.Name = "datecreatedtb";
            this.datecreatedtb.Size = new System.Drawing.Size(175, 23);
            this.datecreatedtb.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(8, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Date of birth:";
            // 
            // lastnametb
            // 
            this.lastnametb.Location = new System.Drawing.Point(8, 384);
            this.lastnametb.Name = "lastnametb";
            this.lastnametb.Size = new System.Drawing.Size(175, 23);
            this.lastnametb.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(10, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Username:";
            // 
            // customerimagepb
            // 
            this.customerimagepb.BackColor = System.Drawing.Color.RosyBrown;
            this.customerimagepb.Location = new System.Drawing.Point(223, 53);
            this.customerimagepb.Name = "customerimagepb";
            this.customerimagepb.Size = new System.Drawing.Size(245, 228);
            this.customerimagepb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.customerimagepb.TabIndex = 8;
            this.customerimagepb.TabStop = false;
            // 
            // firstnametb
            // 
            this.firstnametb.Location = new System.Drawing.Point(6, 321);
            this.firstnametb.Name = "firstnametb";
            this.firstnametb.Size = new System.Drawing.Size(175, 23);
            this.firstnametb.TabIndex = 7;
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbllastname.Location = new System.Drawing.Point(8, 355);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(87, 21);
            this.lbllastname.TabIndex = 6;
            this.lbllastname.Text = "Last Name:";
            // 
            // usernametb
            // 
            this.usernametb.Location = new System.Drawing.Point(8, 235);
            this.usernametb.Name = "usernametb";
            this.usernametb.Size = new System.Drawing.Size(175, 23);
            this.usernametb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "First Name:";
            // 
            // useridtb
            // 
            this.useridtb.Location = new System.Drawing.Point(8, 154);
            this.useridtb.Name = "useridtb";
            this.useridtb.Size = new System.Drawing.Size(175, 23);
            this.useridtb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "User ID:";
            // 
            // customeridtb
            // 
            this.customeridtb.Location = new System.Drawing.Point(8, 82);
            this.customeridtb.Name = "customeridtb";
            this.customeridtb.Size = new System.Drawing.Size(175, 23);
            this.customeridtb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID:";
            // 
            // clearbtn
            // 
            this.clearbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearbtn.Location = new System.Drawing.Point(14, 277);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(121, 63);
            this.clearbtn.TabIndex = 3;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deletebtn.Location = new System.Drawing.Point(14, 208);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(121, 63);
            this.deletebtn.TabIndex = 2;
            this.deletebtn.Text = "Delete Customer";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // viewCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 625);
            this.Controls.Add(this.sortcmb);
            this.Controls.Add(this.datav1);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchtb);
            this.Controls.Add(this.groupBox1);
            this.Name = "viewCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewCustomers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.viewCustomers_FormClosing);
            this.Load += new System.EventHandler(this.viewCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datav1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerimagepb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sortcmb;
        private System.Windows.Forms.DataGridView datav1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchtb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button viewcustomerorderbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox gendertb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox emailtb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox addresstb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox dobtb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox datecreatedtb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lastnametb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox customerimagepb;
        private System.Windows.Forms.TextBox firstnametb;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.TextBox usernametb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox useridtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customeridtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.TextBox phonenumbertb;
        private System.Windows.Forms.Label label4;
    }
}