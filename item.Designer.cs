
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
            this.suppliertb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.itemidtb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.adminaddtocartbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.neworderbtn = new System.Windows.Forms.Button();
            this.datav1 = new System.Windows.Forms.DataGridView();
            this.cartbtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.orderitemidtb = new System.Windows.Forms.TextBox();
            this.itemordercategorytb = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.orderidcmb = new System.Windows.Forms.ComboBox();
            this.ordersuppliertb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.orderquantitytb = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemimagepb)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datav1)).BeginInit();
            this.groupBox3.SuspendLayout();
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
            this.sortcmb.Size = new System.Drawing.Size(184, 25);
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
            this.editbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editbtn.Location = new System.Drawing.Point(21, 73);
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
            this.newbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newbtn.Location = new System.Drawing.Point(21, 144);
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
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deletebtn.Location = new System.Drawing.Point(21, 217);
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
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clear.Location = new System.Drawing.Point(21, 290);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(121, 43);
            this.clear.TabIndex = 3;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.suppliertb);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.itemidtb);
            this.groupBox2.Controls.Add(this.label9);
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
            // suppliertb
            // 
            this.suppliertb.Location = new System.Drawing.Point(206, 427);
            this.suppliertb.Name = "suppliertb";
            this.suppliertb.Size = new System.Drawing.Size(175, 23);
            this.suppliertb.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(206, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 21);
            this.label10.TabIndex = 22;
            this.label10.Text = "Supplier ID:";
            // 
            // itemidtb
            // 
            this.itemidtb.Enabled = false;
            this.itemidtb.Location = new System.Drawing.Point(22, 57);
            this.itemidtb.Name = "itemidtb";
            this.itemidtb.Size = new System.Drawing.Size(175, 23);
            this.itemidtb.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(22, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 21);
            this.label9.TabIndex = 20;
            this.label9.Text = "Item ID:";
            // 
            // categoryidtb
            // 
            this.categoryidtb.Location = new System.Drawing.Point(22, 504);
            this.categoryidtb.Name = "categoryidtb";
            this.categoryidtb.Size = new System.Drawing.Size(175, 23);
            this.categoryidtb.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(206, 467);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Category Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(240, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Item image:";
            // 
            // categorytb
            // 
            this.categorytb.Enabled = false;
            this.categorytb.Location = new System.Drawing.Point(206, 504);
            this.categorytb.Name = "categorytb";
            this.categorytb.Size = new System.Drawing.Size(175, 23);
            this.categorytb.TabIndex = 16;
            this.categorytb.TextChanged += new System.EventHandler(this.categorytb_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(22, 467);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Category ID:";
            // 
            // brandtb
            // 
            this.brandtb.Location = new System.Drawing.Point(22, 427);
            this.brandtb.Name = "brandtb";
            this.brandtb.Size = new System.Drawing.Size(175, 23);
            this.brandtb.TabIndex = 14;
            this.brandtb.TextChanged += new System.EventHandler(this.brandtb_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(22, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Item brand:";
            // 
            // chooseimgbtn
            // 
            this.chooseimgbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chooseimgbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseimgbtn.Location = new System.Drawing.Point(206, 264);
            this.chooseimgbtn.Name = "chooseimgbtn";
            this.chooseimgbtn.Size = new System.Drawing.Size(175, 32);
            this.chooseimgbtn.TabIndex = 5;
            this.chooseimgbtn.Text = "Choose image";
            this.chooseimgbtn.UseVisualStyleBackColor = true;
            this.chooseimgbtn.Click += new System.EventHandler(this.chooseimgbtn_Click);
            // 
            // itemimagepb
            // 
            this.itemimagepb.BackColor = System.Drawing.Color.RosyBrown;
            this.itemimagepb.Location = new System.Drawing.Point(206, 129);
            this.itemimagepb.Name = "itemimagepb";
            this.itemimagepb.Size = new System.Drawing.Size(175, 129);
            this.itemimagepb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.itemimagepb.TabIndex = 8;
            this.itemimagepb.TabStop = false;
            // 
            // quantitytb
            // 
            this.quantitytb.Location = new System.Drawing.Point(22, 354);
            this.quantitytb.Name = "quantitytb";
            this.quantitytb.Size = new System.Drawing.Size(175, 23);
            this.quantitytb.TabIndex = 7;
            this.quantitytb.TextChanged += new System.EventHandler(this.quantitytb_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity:";
            // 
            // costtb
            // 
            this.costtb.Location = new System.Drawing.Point(22, 281);
            this.costtb.Name = "costtb";
            this.costtb.Size = new System.Drawing.Size(175, 23);
            this.costtb.TabIndex = 5;
            this.costtb.TextChanged += new System.EventHandler(this.costtb_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cost per item:";
            // 
            // descriptiontb
            // 
            this.descriptiontb.Location = new System.Drawing.Point(22, 200);
            this.descriptiontb.Name = "descriptiontb";
            this.descriptiontb.Size = new System.Drawing.Size(175, 23);
            this.descriptiontb.TabIndex = 3;
            this.descriptiontb.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            // 
            // nametb
            // 
            this.nametb.Location = new System.Drawing.Point(22, 129);
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(175, 23);
            this.nametb.TabIndex = 1;
            this.nametb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item name:";
            // 
            // categorybtn
            // 
            this.categorybtn.BackColor = System.Drawing.Color.Teal;
            this.categorybtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categorybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categorybtn.Location = new System.Drawing.Point(21, 491);
            this.categorybtn.Name = "categorybtn";
            this.categorybtn.Size = new System.Drawing.Size(121, 43);
            this.categorybtn.TabIndex = 5;
            this.categorybtn.Text = "View categories";
            this.categorybtn.UseVisualStyleBackColor = false;
            this.categorybtn.Click += new System.EventHandler(this.categorybtn_Click);
            // 
            // adminaddtocartbtn
            // 
            this.adminaddtocartbtn.BackColor = System.Drawing.Color.Teal;
            this.adminaddtocartbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminaddtocartbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.adminaddtocartbtn.Location = new System.Drawing.Point(1128, 30);
            this.adminaddtocartbtn.Name = "adminaddtocartbtn";
            this.adminaddtocartbtn.Size = new System.Drawing.Size(121, 43);
            this.adminaddtocartbtn.TabIndex = 6;
            this.adminaddtocartbtn.Text = "Add to cart";
            this.adminaddtocartbtn.UseVisualStyleBackColor = false;
            this.adminaddtocartbtn.Click += new System.EventHandler(this.adminaddtocartbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.neworderbtn);
            this.groupBox1.Controls.Add(this.categorybtn);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Controls.Add(this.deletebtn);
            this.groupBox1.Controls.Add(this.newbtn);
            this.groupBox1.Controls.Add(this.editbtn);
            this.groupBox1.Location = new System.Drawing.Point(754, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 565);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modifications";
            // 
            // neworderbtn
            // 
            this.neworderbtn.BackColor = System.Drawing.Color.Teal;
            this.neworderbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.neworderbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.neworderbtn.Location = new System.Drawing.Point(21, 398);
            this.neworderbtn.Name = "neworderbtn";
            this.neworderbtn.Size = new System.Drawing.Size(121, 43);
            this.neworderbtn.TabIndex = 7;
            this.neworderbtn.Text = "Create New Order";
            this.neworderbtn.UseVisualStyleBackColor = false;
            this.neworderbtn.Click += new System.EventHandler(this.neworderbtn_Click);
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
            this.datav1.Size = new System.Drawing.Size(734, 496);
            this.datav1.TabIndex = 0;
            this.datav1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datav1_CellContentClick);
            this.datav1.SelectionChanged += new System.EventHandler(this.datav1_SelectionChanged);
            // 
            // cartbtn
            // 
            this.cartbtn.BackgroundImage = global::DB2_PROJECT.Properties.Resource1.carticon;
            this.cartbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cartbtn.Location = new System.Drawing.Point(656, 24);
            this.cartbtn.Name = "cartbtn";
            this.cartbtn.Size = new System.Drawing.Size(90, 52);
            this.cartbtn.TabIndex = 20;
            this.cartbtn.UseVisualStyleBackColor = true;
            this.cartbtn.Click += new System.EventHandler(this.cartbtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.orderitemidtb);
            this.groupBox3.Controls.Add(this.itemordercategorytb);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.orderidcmb);
            this.groupBox3.Controls.Add(this.ordersuppliertb);
            this.groupBox3.Controls.Add(this.adminaddtocartbtn);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.orderquantitytb);
            this.groupBox3.Location = new System.Drawing.Point(12, 583);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1301, 100);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Item";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(28, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 21);
            this.label15.TabIndex = 31;
            this.label15.Text = "Choose Order ID:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(484, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 21);
            this.label14.TabIndex = 25;
            this.label14.Text = "Category Name:";
            // 
            // orderitemidtb
            // 
            this.orderitemidtb.Enabled = false;
            this.orderitemidtb.Location = new System.Drawing.Point(260, 50);
            this.orderitemidtb.Name = "orderitemidtb";
            this.orderitemidtb.Size = new System.Drawing.Size(175, 23);
            this.orderitemidtb.TabIndex = 30;
            // 
            // itemordercategorytb
            // 
            this.itemordercategorytb.Enabled = false;
            this.itemordercategorytb.Location = new System.Drawing.Point(484, 50);
            this.itemordercategorytb.Name = "itemordercategorytb";
            this.itemordercategorytb.Size = new System.Drawing.Size(175, 23);
            this.itemordercategorytb.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(260, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 21);
            this.label13.TabIndex = 29;
            this.label13.Text = "Item ID:";
            // 
            // orderidcmb
            // 
            this.orderidcmb.FormattingEnabled = true;
            this.orderidcmb.Location = new System.Drawing.Point(28, 50);
            this.orderidcmb.Name = "orderidcmb";
            this.orderidcmb.Size = new System.Drawing.Size(175, 23);
            this.orderidcmb.TabIndex = 28;
            this.orderidcmb.SelectedIndexChanged += new System.EventHandler(this.orderidcmb_SelectedIndexChanged);
            // 
            // ordersuppliertb
            // 
            this.ordersuppliertb.Enabled = false;
            this.ordersuppliertb.Location = new System.Drawing.Point(927, 50);
            this.ordersuppliertb.Name = "ordersuppliertb";
            this.ordersuppliertb.Size = new System.Drawing.Size(175, 23);
            this.ordersuppliertb.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(927, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 21);
            this.label11.TabIndex = 26;
            this.label11.Text = "Order Supplier ID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(709, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 21);
            this.label12.TabIndex = 24;
            this.label12.Text = "Order Quantity";
            // 
            // orderquantitytb
            // 
            this.orderquantitytb.Location = new System.Drawing.Point(709, 50);
            this.orderquantitytb.Name = "orderquantitytb";
            this.orderquantitytb.Size = new System.Drawing.Size(175, 23);
            this.orderquantitytb.TabIndex = 25;
            // 
            // item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 686);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cartbtn);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Button adminaddtocartbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView datav1;
        private System.Windows.Forms.Button cartbtn;
        private System.Windows.Forms.TextBox itemidtb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox suppliertb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button neworderbtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox ordersuppliertb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox orderquantitytb;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox orderitemidtb;
        private System.Windows.Forms.TextBox itemordercategorytb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox orderidcmb;
    }
}