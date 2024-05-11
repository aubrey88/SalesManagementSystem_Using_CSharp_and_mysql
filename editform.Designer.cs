
namespace DB2_PROJECT
{
    partial class editform
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
            this.editpanel = new System.Windows.Forms.Panel();
            this.confirmchangesbtn = new System.Windows.Forms.Button();
            this.passwordgb = new System.Windows.Forms.GroupBox();
            this.changepasswordbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.newpasswordtb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.oldpasswordtb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addresstb = new System.Windows.Forms.TextBox();
            this.lastnamelbl = new System.Windows.Forms.Label();
            this.lastnametb = new System.Windows.Forms.TextBox();
            this.phonenumlbl = new System.Windows.Forms.Label();
            this.phonenumbertb = new System.Windows.Forms.TextBox();
            this.firstnamelbl = new System.Windows.Forms.Label();
            this.firstnametb = new System.Windows.Forms.TextBox();
            this.editimagebtn = new System.Windows.Forms.Button();
            this.editprofilepb = new System.Windows.Forms.PictureBox();
            this.editpanel.SuspendLayout();
            this.passwordgb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editprofilepb)).BeginInit();
            this.SuspendLayout();
            // 
            // editpanel
            // 
            this.editpanel.Controls.Add(this.confirmchangesbtn);
            this.editpanel.Controls.Add(this.passwordgb);
            this.editpanel.Controls.Add(this.label8);
            this.editpanel.Controls.Add(this.addresstb);
            this.editpanel.Controls.Add(this.lastnamelbl);
            this.editpanel.Controls.Add(this.lastnametb);
            this.editpanel.Controls.Add(this.phonenumlbl);
            this.editpanel.Controls.Add(this.phonenumbertb);
            this.editpanel.Controls.Add(this.firstnamelbl);
            this.editpanel.Controls.Add(this.firstnametb);
            this.editpanel.Controls.Add(this.editimagebtn);
            this.editpanel.Controls.Add(this.editprofilepb);
            this.editpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editpanel.Location = new System.Drawing.Point(0, 0);
            this.editpanel.Name = "editpanel";
            this.editpanel.Size = new System.Drawing.Size(796, 450);
            this.editpanel.TabIndex = 11;
            // 
            // confirmchangesbtn
            // 
            this.confirmchangesbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmchangesbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.confirmchangesbtn.Location = new System.Drawing.Point(310, 349);
            this.confirmchangesbtn.Name = "confirmchangesbtn";
            this.confirmchangesbtn.Size = new System.Drawing.Size(245, 39);
            this.confirmchangesbtn.TabIndex = 17;
            this.confirmchangesbtn.Text = "Confirm Changes";
            this.confirmchangesbtn.UseVisualStyleBackColor = true;
            this.confirmchangesbtn.Click += new System.EventHandler(this.confirmchangesbtn_Click_1);
            // 
            // passwordgb
            // 
            this.passwordgb.Controls.Add(this.changepasswordbtn);
            this.passwordgb.Controls.Add(this.label1);
            this.passwordgb.Controls.Add(this.newpasswordtb);
            this.passwordgb.Controls.Add(this.label4);
            this.passwordgb.Controls.Add(this.oldpasswordtb);
            this.passwordgb.Location = new System.Drawing.Point(537, 18);
            this.passwordgb.Name = "passwordgb";
            this.passwordgb.Size = new System.Drawing.Size(241, 237);
            this.passwordgb.TabIndex = 18;
            this.passwordgb.TabStop = false;
            this.passwordgb.Text = "Change Password";
            // 
            // changepasswordbtn
            // 
            this.changepasswordbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changepasswordbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changepasswordbtn.Location = new System.Drawing.Point(33, 168);
            this.changepasswordbtn.Name = "changepasswordbtn";
            this.changepasswordbtn.Size = new System.Drawing.Size(185, 39);
            this.changepasswordbtn.TabIndex = 19;
            this.changepasswordbtn.Text = "Change Password";
            this.changepasswordbtn.UseVisualStyleBackColor = true;
            this.changepasswordbtn.Click += new System.EventHandler(this.changepasswordbtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "New Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newpasswordtb
            // 
            this.newpasswordtb.Location = new System.Drawing.Point(33, 118);
            this.newpasswordtb.Name = "newpasswordtb";
            this.newpasswordtb.Size = new System.Drawing.Size(185, 23);
            this.newpasswordtb.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(33, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "Old Password:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oldpasswordtb
            // 
            this.oldpasswordtb.Location = new System.Drawing.Point(33, 48);
            this.oldpasswordtb.Name = "oldpasswordtb";
            this.oldpasswordtb.Size = new System.Drawing.Size(185, 23);
            this.oldpasswordtb.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(342, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 26);
            this.label8.TabIndex = 16;
            this.label8.Text = "Address";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addresstb
            // 
            this.addresstb.Location = new System.Drawing.Point(342, 273);
            this.addresstb.Name = "addresstb";
            this.addresstb.Size = new System.Drawing.Size(185, 23);
            this.addresstb.TabIndex = 15;
            // 
            // lastnamelbl
            // 
            this.lastnamelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastnamelbl.Location = new System.Drawing.Point(342, 94);
            this.lastnamelbl.Name = "lastnamelbl";
            this.lastnamelbl.Size = new System.Drawing.Size(185, 26);
            this.lastnamelbl.TabIndex = 14;
            this.lastnamelbl.Text = "Last Name: ";
            this.lastnamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastnametb
            // 
            this.lastnametb.Location = new System.Drawing.Point(342, 123);
            this.lastnametb.Name = "lastnametb";
            this.lastnametb.Size = new System.Drawing.Size(185, 23);
            this.lastnametb.TabIndex = 13;
            // 
            // phonenumlbl
            // 
            this.phonenumlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phonenumlbl.Location = new System.Drawing.Point(342, 170);
            this.phonenumlbl.Name = "phonenumlbl";
            this.phonenumlbl.Size = new System.Drawing.Size(185, 26);
            this.phonenumlbl.TabIndex = 12;
            this.phonenumlbl.Text = "Phone Number:";
            this.phonenumlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phonenumbertb
            // 
            this.phonenumbertb.Location = new System.Drawing.Point(342, 199);
            this.phonenumbertb.Name = "phonenumbertb";
            this.phonenumbertb.Size = new System.Drawing.Size(185, 23);
            this.phonenumbertb.TabIndex = 11;
            // 
            // firstnamelbl
            // 
            this.firstnamelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstnamelbl.Location = new System.Drawing.Point(342, 24);
            this.firstnamelbl.Name = "firstnamelbl";
            this.firstnamelbl.Size = new System.Drawing.Size(185, 26);
            this.firstnamelbl.TabIndex = 10;
            this.firstnamelbl.Text = "First Name:";
            this.firstnamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstnametb
            // 
            this.firstnametb.Location = new System.Drawing.Point(342, 53);
            this.firstnametb.Name = "firstnametb";
            this.firstnametb.Size = new System.Drawing.Size(185, 23);
            this.firstnametb.TabIndex = 8;
            // 
            // editimagebtn
            // 
            this.editimagebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editimagebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editimagebtn.Location = new System.Drawing.Point(17, 257);
            this.editimagebtn.Name = "editimagebtn";
            this.editimagebtn.Size = new System.Drawing.Size(299, 39);
            this.editimagebtn.TabIndex = 7;
            this.editimagebtn.Text = "Choose Image";
            this.editimagebtn.UseVisualStyleBackColor = true;
            this.editimagebtn.Click += new System.EventHandler(this.editimagebtn_Click);
            // 
            // editprofilepb
            // 
            this.editprofilepb.Location = new System.Drawing.Point(17, 18);
            this.editprofilepb.Name = "editprofilepb";
            this.editprofilepb.Size = new System.Drawing.Size(299, 227);
            this.editprofilepb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editprofilepb.TabIndex = 0;
            this.editprofilepb.TabStop = false;
            // 
            // editform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.editpanel);
            this.Name = "editform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "editform";
            this.Load += new System.EventHandler(this.editform_Load);
            this.editpanel.ResumeLayout(false);
            this.editpanel.PerformLayout();
            this.passwordgb.ResumeLayout(false);
            this.passwordgb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editprofilepb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel editpanel;
        private System.Windows.Forms.Button confirmchangesbtn;
        private System.Windows.Forms.GroupBox passwordgb;
        private System.Windows.Forms.Button changepasswordbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newpasswordtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox oldpasswordtb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox addresstb;
        private System.Windows.Forms.Label lastnamelbl;
        private System.Windows.Forms.TextBox lastnametb;
        private System.Windows.Forms.Label phonenumlbl;
        private System.Windows.Forms.TextBox phonenumbertb;
        private System.Windows.Forms.Label firstnamelbl;
        private System.Windows.Forms.TextBox firstnametb;
        private System.Windows.Forms.Button editimagebtn;
        private System.Windows.Forms.PictureBox editprofilepb;
    }
}