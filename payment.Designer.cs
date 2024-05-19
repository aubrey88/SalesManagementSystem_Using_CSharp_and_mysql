
namespace DB2_PROJECT
{
    partial class payment
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.oocmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.orderidcmb = new System.Windows.Forms.ComboBox();
            this.totalcost = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.addresstb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.emailtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstnamelbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmbtn = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.oocmb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.orderidcmb);
            this.groupBox1.Controls.Add(this.totalcost);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.addresstb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.emailtb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.firstnamelbl);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.confirmbtn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 421);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // oocmb
            // 
            this.oocmb.FormattingEnabled = true;
            this.oocmb.Location = new System.Drawing.Point(231, 52);
            this.oocmb.Name = "oocmb";
            this.oocmb.Size = new System.Drawing.Size(192, 23);
            this.oocmb.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(30, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Order #";
            // 
            // orderidcmb
            // 
            this.orderidcmb.FormattingEnabled = true;
            this.orderidcmb.Location = new System.Drawing.Point(231, 102);
            this.orderidcmb.Name = "orderidcmb";
            this.orderidcmb.Size = new System.Drawing.Size(192, 23);
            this.orderidcmb.TabIndex = 14;
            this.orderidcmb.SelectedIndexChanged += new System.EventHandler(this.orderidcmb_SelectedIndexChanged);
            // 
            // totalcost
            // 
            this.totalcost.AutoSize = true;
            this.totalcost.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalcost.Location = new System.Drawing.Point(231, 146);
            this.totalcost.Name = "totalcost";
            this.totalcost.Size = new System.Drawing.Size(73, 20);
            this.totalcost.TabIndex = 13;
            this.totalcost.Text = "Total cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(30, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total cost:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(30, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Payment for payment #";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(30, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(440, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "Get Verification code";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addresstb
            // 
            this.addresstb.Location = new System.Drawing.Point(231, 192);
            this.addresstb.Name = "addresstb";
            this.addresstb.Size = new System.Drawing.Size(192, 23);
            this.addresstb.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Billing address:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::DB2_PROJECT.Properties.Resource1.check;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(429, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 23);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // emailtb
            // 
            this.emailtb.Location = new System.Drawing.Point(231, 247);
            this.emailtb.Name = "emailtb";
            this.emailtb.Size = new System.Drawing.Size(192, 23);
            this.emailtb.TabIndex = 5;
            this.emailtb.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirm your email address:";
            // 
            // firstnamelbl
            // 
            this.firstnamelbl.AutoSize = true;
            this.firstnamelbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstnamelbl.Location = new System.Drawing.Point(283, 19);
            this.firstnamelbl.Name = "firstnamelbl";
            this.firstnamelbl.Size = new System.Drawing.Size(80, 20);
            this.firstnamelbl.TabIndex = 3;
            this.firstnamelbl.Text = "First Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 346);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(440, 23);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(142, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Make your payment,";
            // 
            // confirmbtn
            // 
            this.confirmbtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmbtn.Location = new System.Drawing.Point(30, 385);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(440, 28);
            this.confirmbtn.TabIndex = 0;
            this.confirmbtn.Text = "Confirm code";
            this.confirmbtn.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 421);
            this.Controls.Add(this.groupBox1);
            this.Name = "payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "payment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.payment_FormClosing);
            this.Load += new System.EventHandler(this.payment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label totalcost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox addresstb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox emailtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label firstnamelbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmbtn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ComboBox orderidcmb;
        private System.Windows.Forms.ComboBox oocmb;
        private System.Windows.Forms.Label label4;
    }
}