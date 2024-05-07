
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datav1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.clear = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.newbtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datav1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemimagepb)).BeginInit();
            this.SuspendLayout();
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
            this.datav1.Location = new System.Drawing.Point(12, 81);
            this.datav1.Name = "datav1";
            this.datav1.RowTemplate.Height = 25;
            this.datav1.Size = new System.Drawing.Size(756, 495);
            this.datav1.TabIndex = 0;
            this.datav1.SelectionChanged += new System.EventHandler(this.datav1_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.savebtn);
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
            // savebtn
            // 
            this.savebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.savebtn.Location = new System.Drawing.Point(21, 413);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(121, 43);
            this.savebtn.TabIndex = 5;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
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
            this.categorytb.Location = new System.Drawing.Point(21, 442);
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
            this.label5.Size = new System.Drawing.Size(76, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Category:";
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
            // chooseimgbtn
            // 
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
            this.itemimagepb.TabIndex = 8;
            this.itemimagepb.TabStop = false;
            // 
            // quantitytb
            // 
            this.quantitytb.Location = new System.Drawing.Point(21, 300);
            this.quantitytb.Name = "quantitytb";
            this.quantitytb.Size = new System.Drawing.Size(175, 23);
            this.quantitytb.TabIndex = 7;
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
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clear.Location = new System.Drawing.Point(21, 476);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(121, 43);
            this.clear.TabIndex = 3;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deletebtn.Location = new System.Drawing.Point(21, 282);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(121, 43);
            this.deletebtn.TabIndex = 2;
            this.deletebtn.Text = "Delete item";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // newbtn
            // 
            this.newbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newbtn.Location = new System.Drawing.Point(21, 209);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(121, 43);
            this.newbtn.TabIndex = 1;
            this.newbtn.Text = "Add new Item";
            this.newbtn.UseVisualStyleBackColor = true;
            this.newbtn.Click += new System.EventHandler(this.newbtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editbtn.Location = new System.Drawing.Point(21, 138);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(121, 43);
            this.editbtn.TabIndex = 0;
            this.editbtn.Text = "Edit Item";
            this.editbtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(352, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "search for an item";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(557, 24);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(34, 23);
            this.button5.TabIndex = 3;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 588);
            this.Controls.Add(this.datav1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "item";
            this.Load += new System.EventHandler(this.item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datav1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemimagepb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datav1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button newbtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox quantitytb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox costtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descriptiontb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox itemimagepb;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox categorytb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox brandtb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button chooseimgbtn;
    }
}