
namespace DB2_PROJECT
{
    partial class cart
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
            this.itemgb = new System.Windows.Forms.GroupBox();
            this.itemimagepb = new System.Windows.Forms.PictureBox();
            this.namelbl = new System.Windows.Forms.Label();
            this.quantitytb = new System.Windows.Forms.TextBox();
            this.quantitygb = new System.Windows.Forms.GroupBox();
            this.minusbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.placeorderbtn = new System.Windows.Forms.Button();
            this.confirmgb = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalcostlbl = new System.Windows.Forms.Label();
            this.currencylbl = new System.Windows.Forms.Label();
            this.deletebtnpb = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.itemgb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemimagepb)).BeginInit();
            this.quantitygb.SuspendLayout();
            this.confirmgb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deletebtnpb)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.confirmgb);
            this.groupBox1.Controls.Add(this.itemgb);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // itemgb
            // 
            this.itemgb.Controls.Add(this.deletebtnpb);
            this.itemgb.Controls.Add(this.quantitygb);
            this.itemgb.Controls.Add(this.namelbl);
            this.itemgb.Controls.Add(this.itemimagepb);
            this.itemgb.Location = new System.Drawing.Point(13, 23);
            this.itemgb.Name = "itemgb";
            this.itemgb.Size = new System.Drawing.Size(516, 80);
            this.itemgb.TabIndex = 0;
            this.itemgb.TabStop = false;
            this.itemgb.Text = "item";
            // 
            // itemimagepb
            // 
            this.itemimagepb.Location = new System.Drawing.Point(18, 18);
            this.itemimagepb.Name = "itemimagepb";
            this.itemimagepb.Size = new System.Drawing.Size(73, 50);
            this.itemimagepb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.itemimagepb.TabIndex = 0;
            this.itemimagepb.TabStop = false;
            // 
            // namelbl
            // 
            this.namelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.namelbl.Location = new System.Drawing.Point(107, 30);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(163, 23);
            this.namelbl.TabIndex = 1;
            this.namelbl.Text = "Item 1";
            // 
            // quantitytb
            // 
            this.quantitytb.Location = new System.Drawing.Point(55, 25);
            this.quantitytb.Name = "quantitytb";
            this.quantitytb.Size = new System.Drawing.Size(65, 23);
            this.quantitytb.TabIndex = 2;
            this.quantitytb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // quantitygb
            // 
            this.quantitygb.Controls.Add(this.addbtn);
            this.quantitygb.Controls.Add(this.minusbtn);
            this.quantitygb.Controls.Add(this.quantitytb);
            this.quantitygb.Location = new System.Drawing.Point(266, 12);
            this.quantitygb.Name = "quantitygb";
            this.quantitygb.Size = new System.Drawing.Size(173, 62);
            this.quantitygb.TabIndex = 3;
            this.quantitygb.TabStop = false;
            this.quantitygb.Text = "Quantity";
            // 
            // minusbtn
            // 
            this.minusbtn.BackgroundImage = global::DB2_PROJECT.Properties.Resource1.subtracticon;
            this.minusbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minusbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minusbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minusbtn.Location = new System.Drawing.Point(20, 25);
            this.minusbtn.Name = "minusbtn";
            this.minusbtn.Size = new System.Drawing.Size(29, 25);
            this.minusbtn.TabIndex = 3;
            this.minusbtn.UseVisualStyleBackColor = true;
            // 
            // addbtn
            // 
            this.addbtn.BackgroundImage = global::DB2_PROJECT.Properties.Resource1.addicon;
            this.addbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addbtn.Location = new System.Drawing.Point(125, 24);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(29, 25);
            this.addbtn.TabIndex = 4;
            this.addbtn.UseVisualStyleBackColor = true;
            // 
            // placeorderbtn
            // 
            this.placeorderbtn.BackColor = System.Drawing.Color.LimeGreen;
            this.placeorderbtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.placeorderbtn.Location = new System.Drawing.Point(6, 59);
            this.placeorderbtn.Name = "placeorderbtn";
            this.placeorderbtn.Size = new System.Drawing.Size(516, 41);
            this.placeorderbtn.TabIndex = 1;
            this.placeorderbtn.Text = "Confirm and place order!";
            this.placeorderbtn.UseVisualStyleBackColor = false;
            // 
            // confirmgb
            // 
            this.confirmgb.Controls.Add(this.currencylbl);
            this.confirmgb.Controls.Add(this.totalcostlbl);
            this.confirmgb.Controls.Add(this.label1);
            this.confirmgb.Controls.Add(this.placeorderbtn);
            this.confirmgb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.confirmgb.Location = new System.Drawing.Point(3, 332);
            this.confirmgb.Name = "confirmgb";
            this.confirmgb.Size = new System.Drawing.Size(535, 115);
            this.confirmgb.TabIndex = 2;
            this.confirmgb.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Cost:";
            // 
            // totalcostlbl
            // 
            this.totalcostlbl.AutoSize = true;
            this.totalcostlbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalcostlbl.Location = new System.Drawing.Point(176, 19);
            this.totalcostlbl.Name = "totalcostlbl";
            this.totalcostlbl.Size = new System.Drawing.Size(46, 30);
            this.totalcostlbl.TabIndex = 3;
            this.totalcostlbl.Text = "300";
            // 
            // currencylbl
            // 
            this.currencylbl.AutoSize = true;
            this.currencylbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currencylbl.Location = new System.Drawing.Point(145, 19);
            this.currencylbl.Name = "currencylbl";
            this.currencylbl.Size = new System.Drawing.Size(34, 30);
            this.currencylbl.TabIndex = 4;
            this.currencylbl.Text = "Le";
            // 
            // deletebtnpb
            // 
            this.deletebtnpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deletebtnpb.Image = global::DB2_PROJECT.Properties.Resource1.deleteicon;
            this.deletebtnpb.Location = new System.Drawing.Point(452, 27);
            this.deletebtnpb.Name = "deletebtnpb";
            this.deletebtnpb.Size = new System.Drawing.Size(50, 38);
            this.deletebtnpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deletebtnpb.TabIndex = 4;
            this.deletebtnpb.TabStop = false;
            this.deletebtnpb.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "cart";
            this.Text = "cart";
            this.groupBox1.ResumeLayout(false);
            this.itemgb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemimagepb)).EndInit();
            this.quantitygb.ResumeLayout(false);
            this.quantitygb.PerformLayout();
            this.confirmgb.ResumeLayout(false);
            this.confirmgb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deletebtnpb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox confirmgb;
        private System.Windows.Forms.Label currencylbl;
        private System.Windows.Forms.Label totalcostlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button placeorderbtn;
        private System.Windows.Forms.GroupBox itemgb;
        private System.Windows.Forms.PictureBox deletebtnpb;
        private System.Windows.Forms.GroupBox quantitygb;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button minusbtn;
        private System.Windows.Forms.TextBox quantitytb;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.PictureBox itemimagepb;
    }
}