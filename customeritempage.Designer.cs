
namespace DB2_PROJECT
{
    partial class customeritempage
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
            this.nametb = new System.Windows.Forms.TextBox();
            this.sortcmb = new System.Windows.Forms.ComboBox();
            this.datav1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.orderitembtn = new System.Windows.Forms.Button();
            this.categoryidtb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.categorytb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.brandtb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.itemimagepb = new System.Windows.Forms.PictureBox();
            this.quantitytb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.costtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descriptiontb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchtb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.itemidtb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datav1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemimagepb)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nametb
            // 
            this.nametb.Location = new System.Drawing.Point(21, 148);
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(175, 23);
            this.nametb.TabIndex = 1;
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
            this.sortcmb.TabIndex = 9;
            this.sortcmb.Text = "Sort by";
            this.sortcmb.SelectedIndexChanged += new System.EventHandler(this.sortcmb_SelectedIndexChanged);
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
            this.datav1.TabIndex = 5;
            this.datav1.SelectionChanged += new System.EventHandler(this.datav1_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.itemidtb);
            this.groupBox2.Controls.Add(this.orderitembtn);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.categoryidtb);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.categorytb);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.brandtb);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.itemimagepb);
            this.groupBox2.Controls.Add(this.quantitytb);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.costtb);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.descriptiontb);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nametb);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 536);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // orderitembtn
            // 
            this.orderitembtn.BackColor = System.Drawing.Color.Teal;
            this.orderitembtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderitembtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderitembtn.Location = new System.Drawing.Point(21, 480);
            this.orderitembtn.Name = "orderitembtn";
            this.orderitembtn.Size = new System.Drawing.Size(520, 43);
            this.orderitembtn.TabIndex = 6;
            this.orderitembtn.Text = "Order item";
            this.orderitembtn.UseVisualStyleBackColor = false;
            this.orderitembtn.Click += new System.EventHandler(this.orderitembtn_Click);
            // 
            // categoryidtb
            // 
            this.categoryidtb.Location = new System.Drawing.Point(21, 440);
            this.categoryidtb.Name = "categoryidtb";
            this.categoryidtb.Size = new System.Drawing.Size(175, 23);
            this.categoryidtb.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(224, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Category Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(331, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Item image:";
            // 
            // categorytb
            // 
            this.categorytb.Enabled = false;
            this.categorytb.Location = new System.Drawing.Point(224, 373);
            this.categorytb.Name = "categorytb";
            this.categorytb.Size = new System.Drawing.Size(175, 23);
            this.categorytb.TabIndex = 16;
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
            // itemimagepb
            // 
            this.itemimagepb.BackColor = System.Drawing.Color.RosyBrown;
            this.itemimagepb.Location = new System.Drawing.Point(224, 76);
            this.itemimagepb.Name = "itemimagepb";
            this.itemimagepb.Size = new System.Drawing.Size(307, 247);
            this.itemimagepb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.itemimagepb.TabIndex = 8;
            this.itemimagepb.TabStop = false;
            // 
            // quantitytb
            // 
            this.quantitytb.Location = new System.Drawing.Point(224, 440);
            this.quantitytb.Name = "quantitytb";
            this.quantitytb.Size = new System.Drawing.Size(175, 23);
            this.quantitytb.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(224, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity:";
            // 
            // costtb
            // 
            this.costtb.Location = new System.Drawing.Point(21, 303);
            this.costtb.Name = "costtb";
            this.costtb.Size = new System.Drawing.Size(175, 23);
            this.costtb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cost per item:";
            // 
            // descriptiontb
            // 
            this.descriptiontb.Location = new System.Drawing.Point(21, 227);
            this.descriptiontb.Name = "descriptiontb";
            this.descriptiontb.Size = new System.Drawing.Size(175, 23);
            this.descriptiontb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item name:";
            // 
            // searchtb
            // 
            this.searchtb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchtb.Location = new System.Drawing.Point(353, 24);
            this.searchtb.Name = "searchtb";
            this.searchtb.Size = new System.Drawing.Size(198, 25);
            this.searchtb.TabIndex = 7;
            this.searchtb.Text = "search for an item";
            this.searchtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchtb.TextChanged += new System.EventHandler(this.searchtb_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(795, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 564);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modifications";
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
            this.searchbtn.TabIndex = 8;
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // itemidtb
            // 
            this.itemidtb.Location = new System.Drawing.Point(21, 76);
            this.itemidtb.Name = "itemidtb";
            this.itemidtb.Size = new System.Drawing.Size(175, 23);
            this.itemidtb.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(21, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 21);
            this.label9.TabIndex = 20;
            this.label9.Text = "Item ID";
            // 
            // customeritempage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 588);
            this.Controls.Add(this.sortcmb);
            this.Controls.Add(this.datav1);
            this.Controls.Add(this.searchtb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchbtn);
            this.Name = "customeritempage";
            this.Text = "customeritempage";
            this.Load += new System.EventHandler(this.customeritempage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datav1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemimagepb)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.ComboBox sortcmb;
        private System.Windows.Forms.DataGridView datav1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button orderitembtn;
        private System.Windows.Forms.TextBox categoryidtb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox categorytb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox brandtb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox itemimagepb;
        private System.Windows.Forms.TextBox quantitytb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox costtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descriptiontb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchtb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox itemidtb;
        private System.Windows.Forms.Label label9;
    }
}