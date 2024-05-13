
namespace DB2_PROJECT
{
    partial class MainMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dashboardbtn = new System.Windows.Forms.Button();
            this.profilepb = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilepb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dashboardbtn);
            this.panel1.Controls.Add(this.profilepb);
            this.panel1.Location = new System.Drawing.Point(750, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 416);
            this.panel1.TabIndex = 1;
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
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 450);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilepb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button dashboardbtn;
        private System.Windows.Forms.PictureBox profilepb;
    }
}