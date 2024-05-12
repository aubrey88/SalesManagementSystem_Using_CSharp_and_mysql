
namespace DB2_PROJECT
{
    partial class item
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sortcmb = new System.Windows.Forms.ComboBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchtb = new System.Windows.Forms.TextBox();
            this.editbtn = new System.Windows.Forms.Button();
            this.newbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.categoryidtb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.categorytb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.brandtb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chooseimgbtn = new System.Windows.Forms.Button();
            this.itemimagepb = new System.Windows.Forms.PictureBox();
            this.quantitytb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.costtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descriptiontb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nametb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.categorybtn = new System.Windows.Forms.Button();
            this.orderitembtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datav1 = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemimagepb)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datav1)).BeginInit();
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
            "Item ID",
            "Item Name",
            "Item Brand",
            "Category",
            "Cost per item",
            "Quantity"});
            this.sortcmb.Location = new System.Drawing.Point(31, 24);
            this.sortcmb.Name = "sortcmb";
            this.sortcmb.Size = new System.Drawing.Size(233, 25);
            this.sortcmb.TabIndex = 4;
            this.sortcmb.Text = "Sort by";
            this.sortcmb.SelectedIndexChanged += new System.EventHandler(this.sortcmb_SelectedIndexChanged);
            // 
            // searchbtn
            // 
            this.searchbtn.BackgroundImage = global::DB2_PROJECT.Properties.Resource1.search1;
            this.searchbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchbtn.Image = global::DB2_PROJECT.Properties.Resource1.search;
            this.searchbtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.searchbtn.Location = new System.Drawing.Point(557, 24);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(34, 25);
            this.searchbtn.TabIndex = 3;
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchtb
            // 
            this.searchtb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchtb.Location = new System.Drawing.Point(353, 24);
            this.searchtb.Name = "searchtb";
            this.searchtb.Size = new System.Drawing.Size(198, 25);
            this.searchtb.TabIndex = 2;
            this.searchtb.Text = "search for an item";
            this.searchtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchtb.TextChanged += new System.EventHandler(this.searchtb_TextChanged);
            // 
            // editbtn
            // 
            this.editbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editbtn.Location = new System.Drawing.Point(21, 138);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(121, 43);
            this.editbtn.TabIndex = 0;
            this.editbtn.Text = "Edit Item";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // newbtn
            // 
            this.newbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newbtn.Location = new System.Drawing.Point(21, 209);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(121, 43);
            this.newbtn.TabIndex = 1;
            this.newbtn.Text = "Add new Item";
            this.newbtn.UseVisualStyleBackColor = true;
            this.newbtn.Click += new System.EventHandler(this.newbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deletebtn.Location = new System.Drawing.Point(21, 282);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(121, 43);
            this.deletebtn.TabIndex = 2;
            this.deletebtn.Text = "Delete item";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // clear
            // 
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clear.Location = new System.Drawing.Point(21, 355);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(121, 43);
            this.clear.TabIndex = 3;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.categoryidtb);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.categorytb);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.brandtb);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.chooseimgbtn);
            this.groupBox2.Controls.Add(this.itemimagepb);
            this.groupBox2.Controls.Add(this.quantitytb);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.costtb);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.descriptiontb);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nametb);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(164, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 536);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // categoryidtb
            // 
            this.categoryidtb.Location = new System.Drawing.Point(21, 450);
            this.categoryidtb.Name = "categoryidtb";
            this.categoryidtb.Size = new System.Drawing.Size(175, 23);
            this.categoryidtb.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(205, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Category Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(229, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Item image:";
            // 
            // categorytb
            // 
            this.categorytb.Enabled = false;
            this.categorytb.Location = new System.Drawing.Point(205, 450);
            this.categorytb.Name = "categorytb";
            this.categorytb.Size = new System.Drawing.Size(175, 23);
            this.categorytb.TabIndex = 16;
            this.categorytb.TextChanged += new System.EventHandler(this.categorytb_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(21, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Category ID:";
            // 
            // brandtb
            // 
            this.brandtb.Location = new System.Drawing.Point(21, 373);
            this.brandtb.Name = "brandtb";
            this.brandtb.Size = new System.Drawing.Size(175, 23);
            this.brandtb.TabIndex = 14;
            this.brandtb.TextChanged += new System.EventHandler(this.brandtb_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(21, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Item brand:";
            // 
            // chooseimgbtn
            // 
            this.chooseimgbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chooseimgbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseimgbtn.Location = new System.Drawing.Point(229, 312);
            this.chooseimgbtn.Name = "chooseimgbtn";
            this.chooseimgbtn.Size = new System.Drawing.Size(134, 32);
            this.chooseimgbtn.TabIndex = 5;
            this.chooseimgbtn.Text = "Choose image";
            this.chooseimgbtn.UseVisualStyleBackColor = true;
            this.chooseimgbtn.Click += new System.EventHandler(this.chooseimgbtn_Click);
            // 
            // itemimagepb
            // 
            this.itemimagepb.BackColor = System.Drawing.Color.RosyBrown;
            this.itemimagepb.Location = new System.Drawing.Point(229, 177);
            this.itemimagepb.Name = "itemimagepb";
            this.itemimagepb.Size = new System.Drawing.Size(134, 129);
            this.itemimagepb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.itemimagepb.TabIndex = 8;
            this.itemimagepb.TabStop = false;
            // 
            // quantitytb
            // 
            this.quantitytb.Location = new System.Drawing.Point(21, 300);
            this.quantitytb.Name = "quantitytb";
            this.quantitytb.Size = new System.Drawing.Size(175, 23);
            this.quantitytb.TabIndex = 7;
            this.quantitytb.TextChanged += new System.EventHandler(this.quantitytb_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity:";
            // 
            // costtb
            // 
            this.costtb.Location = new System.Drawing.Point(21, 227);
            this.costtb.Name = "costtb";
            this.costtb.Size = new System.Drawing.Size(175, 23);
            this.costtb.TabIndex = 5;
            this.costtb.TextChanged += new System.EventHandler(this.costtb_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cost per item:";
            // 
            // descriptiontb
            // 
            this.descriptiontb.Location = new System.Drawing.Point(21, 146);
            this.descriptiontb.Name = "descriptiontb";
            this.descriptiontb.Size = new System.Drawing.Size(175, 23);
            this.descriptiontb.TabIndex = 3;
            this.descriptiontb.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            // 
            // nametb
            // 
            this.nametb.Location = new System.Drawing.Point(21, 76);
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(175, 23);
            this.nametb.TabIndex = 1;
            this.nametb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item name:";
            // 
            // categorybtn
            // 
            this.categorybtn.BackColor = System.Drawing.Color.Teal;
            this.categorybtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categorybtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categorybtn.Location = new System.Drawing.Point(21, 491);
            this.categorybtn.Name = "categorybtn";
            this.categorybtn.Size = new System.Drawing.Size(121, 43);
            this.categorybtn.TabIndex = 5;
            this.categorybtn.Text = "View categories";
            this.categorybtn.UseVisualStyleBackColor = false;
            this.categorybtn.Click += new System.EventHandler(this.categorybtn_Click);
            // 
            // orderitembtn
            // 
            this.orderitembtn.BackColor = System.Drawing.Color.Teal;
            this.orderitembtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderitembtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderitembtn.Location = new System.Drawing.Point(21, 435);
            this.orderitembtn.Name = "orderitembtn";
            this.orderitembtn.Size = new System.Drawing.Size(121, 43);
            this.orderitembtn.TabIndex = 6;
            this.orderitembtn.Text = "Order item";
            this.orderitembtn.UseVisualStyleBackColor = false;
            this.orderitembtn.Click += new System.EventHandler(this.orderitembtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.orderitembtn);
            this.groupBox1.Controls.Add(this.categorybtn);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Controls.Add(this.deletebtn);
            this.groupBox1.Controls.Add(this.newbtn);
            this.groupBox1.Controls.Add(this.editbtn);
            this.groupBox1.Location = new System.Drawing.Point(795, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 564);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modifications";
            // 
            // datav1
            // 
            this.datav1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datav1.DefaultCellStyle = dataGridViewCellStyle1;
            this.datav1.Location = new System.Drawing.Point(12, 81);
            this.datav1.Name = "datav1";
            this.datav1.RowTemplate.Height = 25;
            this.datav1.Size = new System.Drawing.Size(756, 495);
            this.datav1.TabIndex = 0;
            this.datav1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datav1_CellContentClick);
            this.datav1.SelectionChanged += new System.EventHandler(this.datav1_SelectionChanged);
            // 
            // item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 588);
            this.Controls.Add(this.sortcmb);
            this.Controls.Add(this.datav1);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchtb);
            this.Controls.Add(this.groupBox1);
            this.Name = "item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "item";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.item_FormClosing);
            this.Load += new System.EventHandler(this.item_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemimagepb)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datav1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sortcmb;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchtb;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button newbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox categoryidtb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox categorytb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox brandtb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button chooseimgbtn;
        private System.Windows.Forms.PictureBox itemimagepb;
        private System.Windows.Forms.TextBox quantitytb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox costtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descriptiontb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button categorybtn;
        private System.Windows.Forms.Button orderitembtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView datav1;
    }
}