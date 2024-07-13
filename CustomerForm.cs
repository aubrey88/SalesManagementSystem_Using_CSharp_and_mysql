using System;
using System.Data;
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
           // InitializeDataGridView();  //do not uncomment it 
         

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadData();
            FetchUserData();
        }

        private void InitializeDataGridView()
        {

            ((System.ComponentModel.ISupportInitialize)(this.datav1)).BeginInit();
           this.SuspendLayout();

            this.datav1.AllowUserToAddRows = false;
            this.datav1.AllowUserToDeleteRows = false;
            this.datav1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            // this.datav1.Dock = DockStyle.Fill;
            this.datav1.ReadOnly = true;
            this.datav1.RowTemplate.Height = 80;
            this.Controls.Add(this.datav1);
            ((System.ComponentModel.ISupportInitialize)(this.datav1)).EndInit();
            this.ResumeLayout(false);
        }



        private void LoadData()
        {
            string my_sql_connection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";

            try
            {

                using (MySqlConnection MySqlConnection = new MySqlConnection(my_sql_connection))
                {
                    MySqlConnection.Open();
                    string query = "SELECT o.order_id, o.order_date, o.item_id, i.item_name,i.item_image,o.quantity,o.total_price,o.order_status FROM orders o join customer c on o.customerid=c.customer_id join users u on c.user_id=u.user_id join item i on o.item_id=i.item_id where u.username=@customerid Limit 5";
                    using (MySqlCommand customerCommand = new MySqlCommand(query, MySqlConnection))
                    {
                        customerCommand.Parameters.AddWithValue("@customerid", loggedInUsername);

                        using (MySqlDataReader adminReader = customerCommand.ExecuteReader())
                        {
                            DataTable table = new DataTable();

                            table.Columns.Add("Order ID", typeof(int));

                            table.Columns.Add("Order date", typeof(string));
                            table.Columns.Add("Item ID", typeof(int));
                            table.Columns.Add("Item name", typeof(string));

                            table.Columns.Add("Item image", typeof(byte[]));
                            table.Columns.Add("Quantity", typeof(int));
                            table.Columns.Add("Total price", typeof(decimal));

                            table.Columns.Add("Order status", typeof(string));

                            while (adminReader.Read())
                            {
                                table.Rows.Add(adminReader["order_id"], adminReader["order_date"], adminReader["item_id"], adminReader["item_name"], adminReader["item_image"], adminReader["quantity"], adminReader["total_price"], adminReader["order_status"]);
                            }
                            datav1.DataSource = table;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message + "\nStack Trace: " + ex.StackTrace);

            }
        }

        private void FetchUserData()
        {
            string mySqlConnection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";

            try
            {
                using (MySqlConnection MySqlConnection = new MySqlConnection(mySqlConnection))
                {
                    MySqlConnection.Open();

                    MySqlCommand userCommand = new MySqlCommand("SELECT address, profileimage, date_created FROM users WHERE username = @username", MySqlConnection);
                    userCommand.Parameters.AddWithValue("@username", loggedInUsername);
                    MySqlDataReader userReader = userCommand.ExecuteReader();

                    if (userReader.Read())
                    {
                        DateTime datecreated = userReader.GetDateTime("date_created");
                        string address = userReader.GetString("address");

                        
                        string conv = Convert.ToString(datecreated);
                        addresslbl.Text = address;

                        datelbl.Text = conv;
                        usernamelbl.Text = loggedInUsername;


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
            this.Hide();
           
            customeritempage customershopform = new customeritempage(loggedInUsername);
            customershopform.Show();
        }

        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard da = new Dashboard(loggedInUsername);
            da.Show();
          

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            orders orderform = new orders(loggedInUsername);
            orderform.Show();
           
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
          
            }
        }

        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void profilepb_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            editform openeditform = new editform(loggedInUsername);
            openeditform.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            payment pay = new payment(loggedInUsername);
            pay.Show();
       
        }
    }
}
