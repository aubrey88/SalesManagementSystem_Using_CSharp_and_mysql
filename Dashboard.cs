using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DB2_PROJECT
{
    public partial class Dashboard : Form
    {
        private object loggedInUsername;

        public Dashboard()
        {
            InitializeComponent();
        }




        private void Dashboard_Load(object sender, EventArgs e)
        {
            
            string my_sql_connection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";
            try
            { 


                string loggedInUsename = usernamelbl.Text;
            MySqlConnection MySqlConnection = new MySqlConnection(my_sql_connection);
                MySqlConnection.Open();

                MySqlCommand userCommand = new MySqlCommand("SELECT * FROM users WHERE username = @username", MySqlConnection);
                userCommand.Parameters.AddWithValue("@username", loggedInUsername);
                MySqlDataReader userReader = userCommand.ExecuteReader();

                if (userReader.Read())
                {
                    string loggedInUsername = userReader.GetString("username");
                    string email = userReader.GetString("email");
                    string fullName = userReader.GetString("full_name");

                    // Display user information in appropriate controls
                    usernamelbl.Text = loggedInUsername;
                    emaillbl.Text = email;
                    fullnamelbl.Text = fullName;
                }

                userReader.Close();
                MySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }

}
