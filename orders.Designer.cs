
namespace DB2_PROJECT
{
    partial class orders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datav1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.makepaymentbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.amounttb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.quantitytb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.itemnametb = new System.Windows.Forms.TextBox();
            this.lbllastname = new System.Windows.Forms.Label();
            this.itemidtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.orderdatetb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.orderidtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clearbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sortcmb = new System.Windows.Forms.ComboBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchtb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datav1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // datav1
            // 
            this.datav1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datav1.DefaultCellStyle = dataGridViewCellStyle5;
            this.datav1.Location = new System.Drawing.Point(12, 70);
            this.datav1.Name = "datav1";
            this.datav1.RowTemplate.Height = 25;
            this.datav1.Size = new System.Drawing.Size(493, 497);
            this.datav1.TabIndex = 22;
            this.datav1.SelectionChanged += new System.EventHandler(this.datav1_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.makepaymentbtn);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.clearbtn);
            this.groupBox1.Controls.Add(this.deletebtn);
            this.groupBox1.Location = new System.Drawing.Point(511, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 497);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modifications";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(14, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 63);
            this.button1.TabIndex = 7;
            this.button1.Text = "Edit Order";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // makepaymentbtn
            // 
            this.makepaymentbtn.BackColor = System.Drawing.Color.Teal;
            this.makepaymentbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.makepaymentbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.makepaymentbtn.Location = new System.Drawing.Point(14, 366);
            this.makepaymentbtn.Name = "makepaymentbtn";
            this.makepaymentbtn.Size = new System.Drawing.Size(121, 63);
            this.makepaymentbtn.TabIndex = 6;
            this.makepaymentbtn.Text = "Make Payment";
            this.makepaymentbtn.UseVisualStyleBackColor = false;
            this.makepaymentbtn.Click += new System.EventHandler(this.makepaymentbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.amounttb);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.quantitytb);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.itemnametb);
            this.groupBox2.Controls.Add(this.lbllastname);
            this.groupBox2.Controls.Add(this.itemidtb);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.orderdatetb);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.orderidtb);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(153, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 469);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // amounttb
            // 
            this.amounttb.Enabled = false;
            this.amounttb.Location = new System.Drawing.Point(8, 428);
            this.amounttb.Name = "amounttb";
            this.amounttb.Size = new System.Drawing.Size(175, 23);
            this.amounttb.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Payment amount:";
            // 
            // quantitytb
            // 
            this.quantitytb.Location = new System.Drawing.Point(6, 353);
            this.quantitytb.Name = "quantitytb";
            this.quantitytb.Size = new System.Drawing.Size(175, 23);
            this.quantitytb.TabIndex = 14;
            this.quantitytb.TextChanged += new System.EventHandler(this.quantitytb_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(8, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Item ID:";
            // 
            // itemnametb
            // 
            this.itemnametb.Enabled = false;
            this.itemnametb.Location = new System.Drawing.Point(4, 290);
            this.itemnametb.Name = "itemnametb";
            this.itemnametb.Size = new System.Drawing.Size(175, 23);
            this.itemnametb.TabIndex = 7;
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbllastname.Location = new System.Drawing.Point(6, 324);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(70, 21);
            this.lbllastname.TabIndex = 6;
            this.lbllastname.Text = "Quantity";
            // 
            // itemidtb
            // 
            this.itemidtb.Enabled = false;
            this.itemidtb.Location = new System.Drawing.Point(6, 221);
            this.itemidtb.Name = "itemidtb";
            this.itemidtb.Size = new System.Drawing.Size(175, 23);
            this.itemidtb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(4, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item Name:";
            // 
            // orderdatetb
            // 
            this.orderdatetb.Enabled = false;
            this.orderdatetb.Location = new System.Drawing.Point(6, 140);
            this.orderdatetb.Name = "orderdatetb";
            this.orderdatetb.Size = new System.Drawing.Size(175, 23);
            this.orderdatetb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order date:";
            // 
            // orderidtb
            // 
            this.orderidtb.Enabled = false;
            this.orderidtb.Location = new System.Drawing.Point(6, 68);
            this.orderidtb.Name = "orderidtb";
            this.orderidtb.Size = new System.Drawing.Size(175, 23);
            this.orderidtb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order ID:";
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
            this.deletebtn.Text = "Delete Order";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(160, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Username";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sortcmb);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.searchbtn);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.searchtb);
            this.groupBox3.Location = new System.Drawing.Point(13, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(893, 63);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(23, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "View your orders, ";
            // 
            // sortcmb
            // 
            this.sortcmb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sortcmb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortcmb.FormattingEnabled = true;
            this.sortcmb.Items.AddRange(new object[] {
            "Order ID",
            "Order Date",
            "Item ID",
            "Item Name",
            "Quantity",
            "Total amount"});
            this.sortcmb.Location = new System.Drawing.Point(308, 21);
            this.sortcmb.Name = "sortcmb";
            this.sortcmb.Size = new System.Drawing.Size(184, 25);
            this.sortcmb.TabIndex = 10;
            this.sortcmb.Text = "Sort Orders by";
            this.sortcmb.SelectedIndexChanged += new System.EventHandler(this.sortcmb_SelectedIndexChanged);
            // 
            // searchbtn
            // 
            this.searchbtn.BackgroundImage = global::DB2_PROJECT.Properties.Resource1.search1;
            this.searchbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchbtn.Image = global::DB2_PROJECT.Properties.Resource1.search;
            this.searchbtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.searchbtn.Location = new System.Drawing.Point(817, 21);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(34, 25);
            this.searchbtn.TabIndex = 9;
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchtb
            // 
            this.searchtb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchtb.Location = new System.Drawing.Point(613, 21);
            this.searchtb.Name = "searchtb";
            this.searchtb.Size = new System.Drawing.Size(198, 25);
            this.searchtb.TabIndex = 8;
            this.searchtb.Text = "search for an order";
            this.searchtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchtb.TextChanged += new System.EventHandler(this.searchtb_TextChanged);
            // 
            // orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 606);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datav1);
            this.Name = "orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "orders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.orders_FormClosing);
            this.Load += new System.EventHandler(this.orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datav1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datav1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button makepaymentbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox quantitytb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox itemnametb;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.TextBox itemidtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox orderdatetb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox orderidtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox amounttb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox sortcmb;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchtb;
    }
}