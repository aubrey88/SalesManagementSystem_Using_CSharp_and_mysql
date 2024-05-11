using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

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
                    bool isAdmin = false;

                    MySqlCommand userCommand = new MySqlCommand("SELECT * FROM users WHERE username = @username", MySqlConnection);
                    userCommand.Parameters.AddWithValue("@username", username);
                    MySqlDataReader userReader = userCommand.ExecuteReader();

                    if (userReader.Read())
                    {
                        if (password.Equals(userReader.GetString("userpassword")))
                        {
                            loginSuccessful = true;
                        }
                    }
                    userReader.Close();

                    if (!loginSuccessful)
                    {
                            MySqlCommand adminCommand = new MySqlCommand("SELECT * FROM admins WHERE username = @username", MySqlConnection);
                        adminCommand.Parameters.AddWithValue("@username", username);
                        MySqlDataReader adminReader = adminCommand.ExecuteReader();

                        if (adminReader.Read())
                        {
                            if (password.Equals(adminReader.GetString("password")))
                            {
                                loginSuccessful = true;
                                isAdmin = true;
                            }
                        }
                        adminReader.Close();
                    }

                    MySqlConnection.Close();

                    if (loginSuccessful)
                    {
                        if (isAdmin)
                        {
                            MessageBox.Show("Login successful, Welcome Admin!");
                            MainMenu mainForm = new MainMenu();
                            mainForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Login successful");

                            CustomerForm customerForm = new CustomerForm(username);
                            customerForm.Show();
                            this.Hide();
                            return;

                        }
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


            this.Hide();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
