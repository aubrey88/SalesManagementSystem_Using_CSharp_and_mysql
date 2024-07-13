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
        private string loggedInUsername;

        public payment()
        {
            InitializeComponent();
        }




        public payment(string username)
        {
            InitializeComponent();

            this.loggedInUsername = username;
            showorderID();
            FetchUserData();
        }
            private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void FetchUserData()
        {
            string mySqlConnection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";

            try
            {
                using (MySqlConnection MySqlConnection = new MySqlConnection(mySqlConnection))
                {
                    MySqlConnection.Open();

                    MySqlCommand userCommand = new MySqlCommand("SELECT first_name, last_name, username, email,  address, phone_number, profileimage FROM users WHERE username = @username", MySqlConnection);
                    userCommand.Parameters.AddWithValue("@username", loggedInUsername);
                    MySqlDataReader userReader = userCommand.ExecuteReader();

                    if (userReader.Read())
                    {
                        //usernamelbl.Text = loggedInUsername;

                        string address = userReader.GetString("address");
                        addresstb.Text = address;

                        string firstname = userReader.GetString("username");
                        firstnamelbl.Text = firstname;

                        string email = userReader.GetString("email");
                        emailtb.Text = email;

                    }
                    else
                    {
                        MessageBox.Show("User not found!");
                    }

                    userReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showorderID()
        {
            string my_sql_connection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";

            try
            {

                using (MySqlConnection MySqlConnection = new MySqlConnection(my_sql_connection))
                {
                    MySqlConnection.Open();
                    string query = "SELECT p.payment_id, p.order_id AS payment_order_id, o.order_id AS order_order_id " +
                            "FROM payment p " +
                            "JOIN orders o ON p.order_id = o.order_id " +
                            "JOIN customer c ON o.customerid = c.customer_id " +
                            "JOIN users u ON c.user_id = u.user_id " +
                            "JOIN item i ON o.item_id = i.item_id " +
                            "WHERE u.username = @customerid";


                    using (MySqlCommand customerCommand = new MySqlCommand(query, MySqlConnection))
                    {

                        customerCommand.Parameters.AddWithValue("@customerid", loggedInUsername);

                        using (MySqlDataReader customerReader = customerCommand.ExecuteReader())
                        {
                            orderidcmb.Items.Clear();
                            oocmb.Items.Clear();
                            while (customerReader.Read())
                            {
                                if (!customerReader.IsDBNull(customerReader.GetOrdinal("payment_id")))
                                {
                                    int payment_id = customerReader.GetInt32("payment_id");
                                    oocmb.Items.Add(payment_id);
                                }

                                if (!customerReader.IsDBNull(customerReader.GetOrdinal("order_order_id")))
                                {
                                    int order_id = customerReader.GetInt32("order_order_id");
                                    orderidcmb.Items.Add(order_id);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (oocmb.SelectedItem != null)
                {
                    int selectedchoice = int.Parse(oocmb.SelectedItem.ToString());

                    Random random = new Random();
                    int code = random.Next(1000, 9999);

                    string email = emailtb.Text;
                    ;

                    if (checkconfirm)
                    {
                        InsertCodeIntoPaymentTable(code, email, selectedchoice);
                        SendCodeByEmail(email, code.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Please confirm your email address before proceeding!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please select a payment ID number!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("The selected order ID is not valid. Please select a valid order ID.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void SendCodeByEmail(string email, string code)
        {
            try
            {
               
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"); 
                smtpClient.Port = 587;
                smtpClient.UseDefaultCredentials = false;
//this is where i said in the readme file to change to your email and password
                smtpClient.Credentials = new NetworkCredential("youremail", "password"); 
                smtpClient.EnableSsl = true;

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("youremail");
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


        private void InsertCodeIntoPaymentTable(int code, string email, int choice)
        {
            try
            {
                string my_sql_connection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";
                using (MySqlConnection MySqlConnection = new MySqlConnection(my_sql_connection))
                {
                    MySqlConnection.Open();

                    string getUserIdQuery = "SELECT user_id FROM users WHERE username = @username";
                    MySqlCommand getUserIdCmd = new MySqlCommand(getUserIdQuery, MySqlConnection);
                    getUserIdCmd.Parameters.AddWithValue("@username", loggedInUsername);
                    int userId = Convert.ToInt32(getUserIdCmd.ExecuteScalar());

                    string query = "UPDATE payment SET payment_code = @code WHERE payment_id = @orderid";
                    MySqlCommand cmd = new MySqlCommand(query, MySqlConnection);
                    cmd.Parameters.AddWithValue("@orderid", choice);
                    cmd.Parameters.AddWithValue("@code", code);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Payment code updated successfully. Code sent to your email.");
                        checkconfirm = false;
                    }
                    else
                    {
                        MessageBox.Show("No rows were updated. Please check the payment ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to insert code into payment table: " + ex.Message);
            }
        }


        private void payment_FormClosing(object sender, FormClosingEventArgs e)
        {
            CustomerForm customerForm = new CustomerForm(loggedInUsername);
            customerForm.Show();
        }

        private void payment_Load(object sender, EventArgs e)
        {

        }

        private void orderidcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string costvalue = totalcost.Text;
            if (orderidcmb.SelectedIndex != -1)
            {
                int selectedOrderId = (int)orderidcmb.SelectedItem;
                FetchAndDisplayPaymentAmount(selectedOrderId);
            }

        }

        private void FetchAndDisplayPaymentAmount(int orderId)
        {
            string my_sql_connection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";

            try
            {
                using (MySqlConnection MySqlConnection = new MySqlConnection(my_sql_connection))
                {
                    MySqlConnection.Open();
                    string query = "SELECT p.payment_amount FROM payment p WHERE p.order_id = @orderId";

                    using (MySqlCommand paymentCommand = new MySqlCommand(query, MySqlConnection))
                    {
                        paymentCommand.Parameters.AddWithValue("@orderId", orderId);

                        object result = paymentCommand.ExecuteScalar();
                        if (result != null)
                        {
                            decimal paymentAmount = Convert.ToDecimal(result);
                            totalcost.Text = paymentAmount.ToString("F2"); 
                        }
                        else
                        {
                            totalcost.Text = "0.00";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to fetch payment amount: " + ex.Message);
            }
        }

        private bool checkconfirm = false;
        private void button1_Click(object sender, EventArgs e)
        {
            checkconfirm = true;
            MessageBox.Show("Email address confirmed");
        }
    }
}
