using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DB2_PROJECT
{
    public partial class Dashboard : Form
    {

        private string loggedInUsername;

        public Dashboard()
        {
            InitializeComponent();
        }


        public Dashboard(string username)
        {
            InitializeComponent();
            loggedInUsername = username;
            
            FetchUserData();
        }

        private void FetchUserData()
        {
            string mySqlConnection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";

            try
            {
                using (MySqlConnection MySqlConnection = new MySqlConnection(mySqlConnection))
                {
                    MySqlConnection.Open();

                    MySqlCommand userCommand = new MySqlCommand("SELECT address, profileimage FROM users WHERE username = @username", MySqlConnection);
                    userCommand.Parameters.AddWithValue("@username", loggedInUsername);
                    MySqlDataReader userReader = userCommand.ExecuteReader();

                    if (userReader.Read())
                    {
                        string address = userReader.GetString("address");
                        addresslbl.Text = address;

                        // Display user's profile image if available
                        if (!userReader.IsDBNull(userReader.GetOrdinal("profileimage")))
                        {
                            byte[] imageData = (byte[])userReader["profileimage"];
                            profilepb.Image = Image.FromStream(new MemoryStream(imageData));
                        }
                        else
                        {
                            profilepb.Image = null;
                        }
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

        private void Dashboard_Load(object sender, EventArgs e)
        {


        }
                

    }

}
