using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DB2_PROJECT
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        public string LoggedInUsername { get; set; }

        public CustomerForm(string loggedInUsername)
        {
            InitializeComponent();
            this.LoggedInUsername = loggedInUsername;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string loggedInUsername = LoggedInUsername;

            usernamelbl.Text = loggedInUsername;

            CustomerForm cf = new CustomerForm(loggedInUsername);

            Dashboard da = new Dashboard();
            da.Show();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

            string saddress = "";

            string my_sql_connection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";
            try
            {
                MySqlConnection MySqlConnection = new MySqlConnection(my_sql_connection);
                MySqlConnection.Open();

                MySqlCommand userCommand = new MySqlCommand("SELECT * FROM users WHERE username = @username and address = @address", MySqlConnection);
                userCommand.Parameters.AddWithValue("@username", LoggedInUsername);
                userCommand.Parameters.AddWithValue("@address", saddress);

                MySqlDataReader userReader = userCommand.ExecuteReader();

                if (userReader.Read())
                {
                    addresslbl.Text = saddress;
                    profilepb.Image = null;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            }

        private void button2_Click(object sender, EventArgs e)
        {
            item itemplay = new item();
            itemplay.Show();
        }
    }
}
