
namespace DB2_PROJECT
{
    partial class Category
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datav1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clear = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.newbtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.categorynametb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryidtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datav1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.datav1);
            this.groupBox1.Location = new System.Drawing.Point(3, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 374);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // datav1
            // 
            this.datav1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datav1.Location = new System.Drawing.Point(9, 22);
            this.datav1.Name = "datav1";
            this.datav1.RowTemplate.Height = 25;
            this.datav1.Size = new System.Drawing.Size(332, 244);
            this.datav1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.categorynametb);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.categoryidtb);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(363, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 244);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.clear);
            this.groupBox3.Controls.Add(this.deletebtn);
            this.groupBox3.Controls.Add(this.newbtn);
            this.groupBox3.Controls.Add(this.editbtn);
            this.groupBox3.Location = new System.Drawing.Point(10, 272);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(584, 96);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modifications";
            // 
            // clear
            // 
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clear.Location = new System.Drawing.Point(437, 51);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(121, 28);
            this.clear.TabIndex = 11;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // deletebtn
            // 
            this.deletebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deletebtn.Location = new System.Drawing.Point(300, 51);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(121, 28);
            this.deletebtn.TabIndex = 10;
            this.deletebtn.Text = "Delete Category";
            this.deletebtn.UseVisualStyleBackColor = true;
            // 
            // newbtn
            // 
            this.newbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newbtn.Location = new System.Drawing.Point(158, 51);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(121, 28);
            this.newbtn.TabIndex = 9;
            this.newbtn.Text = "Add new Category";
            this.newbtn.UseVisualStyleBackColor = true;
            // 
            // editbtn
            // 
            this.editbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editbtn.Location = new System.Drawing.Point(20, 51);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(121, 28);
            this.editbtn.TabIndex = 8;
            this.editbtn.Text = "Edit Category";
            this.editbtn.UseVisualStyleBackColor = true;
            // 
            // categorynametb
            // 
            this.categorynametb.Location = new System.Drawing.Point(30, 152);
            this.categorynametb.Name = "categorynametb";
            this.categorynametb.Size = new System.Drawing.Size(175, 23);
            this.categorynametb.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Category ID";
            // 
            // categoryidtb
            // 
            this.categoryidtb.Enabled = false;
            this.categoryidtb.Location = new System.Drawing.Point(30, 77);
            this.categoryidtb.Name = "categoryidtb";
            this.categoryidtb.Size = new System.Drawing.Size(175, 23);
            this.categoryidtb.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Category name:";
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 399);
            this.Controls.Add(this.groupBox1);
            this.Name = "Category";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datav1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView datav1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button newbtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.TextBox categorynametb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox categoryidtb;
        private System.Windows.Forms.Label label1;
    }
}