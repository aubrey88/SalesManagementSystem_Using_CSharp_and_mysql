using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using MySql.Data.MySqlClient;

namespace DB2_PROJECT
{
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int code = random.Next(1000, 9999);

            string email = emailtb.Text;
            SendCodeByEmail(email, code.ToString());

            InsertCodeIntoPaymentTable(code);
        }


        private void SendCodeByEmail(string email, string code)
        {
            try
            {
               
                SmtpClient smtpClient = new SmtpClient("smtp.example.com"); 
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential("your_email@example.com", "your_password"); 
                smtpClient.EnableSsl = true;

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("aubreycarew507@gmail.com");
                mailMessage.To.Add(email);
                mailMessage.Subject = "Your Verification Code";
                mailMessage.Body = "Your verification code is: " + code;

                
                smtpClient.Send(mailMessage);
                MessageBox.Show("Verification code sent to your email.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send verification code: " + ex.Message);
            }
        }

        private void InsertCodeIntoPaymentTable(int code)
        {
            try
            {
               string my_sql_connection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";
                using (MySqlConnection MySqlConnection = new MySqlConnection(my_sql_connection))
                {
                    MySqlConnection.Open();
                    string query = "INSERT INTO payment (payment_code) VALUES (@code)";
                    MySqlCommand cmd = new MySqlCommand(query, MySqlConnection);
                    cmd.Parameters.AddWithValue("@code", code);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Code inserted into payment table.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to insert code into payment table: " + ex.Message);
            }
        }
    }
}
