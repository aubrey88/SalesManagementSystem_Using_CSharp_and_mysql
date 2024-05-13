using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DB2_PROJECT
{
    public partial class CustomerForm : Form
    {
        private string loggedInUsername;

        public CustomerForm()
        {
            InitializeComponent();
        }

        public CustomerForm(string loggedInUsername)
        {
            InitializeComponent();
            this.loggedInUsername = loggedInUsername;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
         
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



        private void button2_Click(object sender, EventArgs e)
        {
         
           
            customeritempage customershopform = new customeritempage(loggedInUsername);
            customershopform.Show();
        }

        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            Dashboard da = new Dashboard(loggedInUsername);
            da.Show();
            this.Hide();

        }
    }
}
