using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DB2_PROJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // string my_sql_connection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";
            //MySqlConnection  MySqlConnection = new MySqlConnection(my_sql_connection);
            // try
            // {
            //     MySqlConnection.Open();
            //     MessageBox.Show("Connection Successful");
            // }
            // catch(Exception ex)
            // {
            //     MessageBox.Show(ex.Message);

            // }

            // finally
            // {
            //     MySqlConnection.Close();
            // }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string my_sql_connection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";
            try
            {
                MySqlConnection MySqlConnection = new MySqlConnection(my_sql_connection);
                MySqlConnection.Open();

                string username = usernametb.Text;
                string password = passwordtb.Text;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("No field should be empty!");
                    usernametb.Focus();
                }
                else
                {
                    bool loginSuccessful = false;

                    MySqlCommand newcommand = new MySqlCommand("SELECT * FROM users", MySqlConnection);
                    MySqlDataReader reader = newcommand.ExecuteReader();

                    while (reader.Read())
                    {
                        if (username.Equals(reader.GetString("username")) && password.Equals(reader.GetString("userpassword")))
                        {
                            loginSuccessful = true;
                            break; // Exit the loop once a successful login is found
                        }
                    }

                    MySqlConnection.Close();

                    if (loginSuccessful)
                    {
                        MessageBox.Show("Login successful");
                    }
                    else
                    {
                        MessageBox.Show("Invalid login, try again!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void signupbtn_Click(object sender, EventArgs e)
        {
            SignupForm f1 = new SignupForm();
            f1.Show();


            Form1 me = new Form1();
            me.Close();

        }
    }
}
