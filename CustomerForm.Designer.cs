
namespace DB2_PROJECT
{
    partial class CustomerForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addresslbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dashboardbtn = new System.Windows.Forms.Button();
            this.profilepb = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilepb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(891, 449);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addresslbl);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.usernamelbl);
            this.groupBox2.Location = new System.Drawing.Point(9, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 74);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // addresslbl
            // 
            this.addresslbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addresslbl.Location = new System.Drawing.Point(379, 29);
            this.addresslbl.Name = "addresslbl";
            this.addresslbl.Size = new System.Drawing.Size(195, 26);
            this.addresslbl.TabIndex = 6;
            this.addresslbl.Text = "Address";
            this.addresslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome:";
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernamelbl.Location = new System.Drawing.Point(90, 29);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(57, 21);
            this.usernamelbl.TabIndex = 4;
            this.usernamelbl.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dashboardbtn);
            this.panel1.Controls.Add(this.profilepb);
            this.panel1.Location = new System.Drawing.Point(616, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 416);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(49, 323);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 66);
            this.button4.TabIndex = 3;
            this.button4.Text = "Orders";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(49, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 66);
            this.button2.TabIndex = 2;
            this.button2.Text = "Shop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dashboardbtn
            // 
            this.dashboardbtn.Location = new System.Drawing.Point(49, 165);
            this.dashboardbtn.Name = "dashboardbtn";
            this.dashboardbtn.Size = new System.Drawing.Size(165, 66);
            this.dashboardbtn.TabIndex = 1;
            this.dashboardbtn.Text = "Dashboard";
            this.dashboardbtn.UseVisualStyleBackColor = true;
            this.dashboardbtn.Click += new System.EventHandler(this.dashboardbtn_Click);
            // 
            // profilepb
            // 
            this.profilepb.Location = new System.Drawing.Point(8, 8);
            this.profilepb.Name = "profilepb";
            this.profilepb.Size = new System.Drawing.Size(249, 148);
            this.profilepb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilepb.TabIndex = 0;
            this.profilepb.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Teal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(601, 336);
            this.dataGridView1.TabIndex = 1;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 451);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilepb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button dashboardbtn;
        private System.Windows.Forms.PictureBox profilepb;
        public System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label addresslbl;
    }
}