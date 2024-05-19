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

                    MySqlCommand userCommand = new MySqlCommand("SELECT concat(first_name,' ' ,last_name) as full_name,  address, date_created, email, phone_number, profileimage FROM users WHERE username = @username", MySqlConnection);
                    userCommand.Parameters.AddWithValue("@username", loggedInUsername);
                    MySqlDataReader userReader = userCommand.ExecuteReader();

                    if (userReader.Read())
                    {
                        usernamelbl.Text = loggedInUsername;

                        string address = userReader.GetString("address");
                        addresslbl.Text = address;

                        string firstname = userReader.GetString("full_name");
                        fullnamelbl.Text = firstname;

                        string phonenum = userReader.GetString("phone_number");
                        phonelbl.Text = phonenum;

                        string email = userReader.GetString("email");
                        emaillbl.Text = email;

                        DateTime datecreated = userReader.GetDateTime("date_created");
                        string conv = Convert.ToString(datecreated);
                        datecreatedlbl.Text = conv;


                        //show image if user has image
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

        private void profilepb_Click(object sender, EventArgs e)
        {

        }

        private void editpanel_Paint(object sender, PaintEventArgs e)
        {
            
        }



       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void editprofilebtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            editform openeditform = new editform(loggedInUsername);
            openeditform.Show();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            CustomerForm customerForm = new CustomerForm(loggedInUsername);
            customerForm.Show();
        }
    }

}
