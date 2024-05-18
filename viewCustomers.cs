using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DB2_PROJECT
{
    public partial class viewCustomers : Form
    {
        public viewCustomers()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadData();

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
            this.datav1.RowTemplate.Height = 160;
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
                    string query = "SELECT c.customer_id, u.user_id, u.username, u.first_name, u.last_name, u.gender,u.date_of_birth,u.date_created,u.address,u.email,u.phone_number, u.profileimage FROM customer c join users u on c.user_id=u.user_id";


                    using (MySqlCommand adminCommand = new MySqlCommand(query, MySqlConnection))
                    {

                        using (MySqlDataReader adminReader = adminCommand.ExecuteReader())
                        {
                            DataTable table = new DataTable();

                            table.Columns.Add("Customer ID", typeof(int));
                            table.Columns.Add("User ID", typeof(int));
                            table.Columns.Add("Username", typeof(string));
                            table.Columns.Add("First Name", typeof(string));
                            table.Columns.Add("Last Name", typeof(string));
                            table.Columns.Add("Gender", typeof(string));
                            table.Columns.Add("Date of Birth", typeof(string));
                            table.Columns.Add("Date created", typeof(string));

                            table.Columns.Add("Address", typeof(string));
                            table.Columns.Add("Email", typeof(string));
                            table.Columns.Add("Phone number", typeof(string));


                            table.Columns.Add("Image", typeof(byte[]));
                           

                            while (adminReader.Read())
                            {
                                table.Rows.Add(adminReader["customer_id"], adminReader["user_id"], adminReader["username"], adminReader["first_name"], adminReader["last_name"], adminReader["gender"], adminReader["date_of_birth"], adminReader["date_created"], adminReader["address"], adminReader["email"], adminReader["phone_number"], adminReader["profileimage"]);
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


        private void viewCustomers_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu mainmenuform = new MainMenu();
            mainmenuform.Show();
        }

        private void datav1_SelectionChanged(object sender, EventArgs e)
        {
            if (datav1.SelectedRows.Count > 0)
            {
                //select row to display it
                DataGridViewRow selectedRow = datav1.SelectedRows[0];


                customeridtb.Text = selectedRow.Cells["Customer ID"].Value.ToString();
                useridtb.Text = selectedRow.Cells["User ID"].Value.ToString();
                usernametb.Text = selectedRow.Cells["Username"].Value.ToString();
                firstnametb.Text = selectedRow.Cells["First Name"].Value.ToString();
                lastnametb.Text = selectedRow.Cells["Last Name"].Value.ToString();
                gendertb.Text = selectedRow.Cells["Gender"].Value.ToString();
                emailtb.Text = selectedRow.Cells["Email"].Value.ToString();

                datecreatedtb.Text = selectedRow.Cells["Date created"].Value.ToString();
                addresstb.Text = selectedRow.Cells["Address"].Value.ToString();
                phonenumbertb.Text = selectedRow.Cells["Phone number"].Value.ToString();
                dobtb.Text = selectedRow.Cells["Date of Birth"].Value.ToString();




                if (selectedRow.Cells["Image"].Value != DBNull.Value)
                {
                    //get the image row 
                    byte[] imageData = (byte[])selectedRow.Cells["Image"].Value;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        customerimagepb.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    customerimagepb.Image = null;
                }
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (datav1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            //find the selected row
            int cusId = Convert.ToInt32(datav1.SelectedRows[0].Cells["Customer ID"].Value);
            DialogResult result = MessageBox.Show("Are you sure you want to delete this Customer?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string my_sql_connection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";

                try
                {
                    using (MySqlConnection MySqlConnection = new MySqlConnection(my_sql_connection))
                    {
                        MySqlConnection.Open();
                        string query = "DELETE FROM customer WHERE customer_id = @customerId";
                        using (MySqlCommand sqlCommand = new MySqlCommand(query, MySqlConnection))
                        {
                            sqlCommand.Parameters.AddWithValue("@customerId", cusId);
                            int rowsAffected = sqlCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Customer deleted successfully.");
                                Clear_all();
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("Cannot delete, invalid item ID");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Clear_all()
        {
            usernametb.Text = "";
            useridtb.Text = "";
            customerimagepb.Image = null;
            customeridtb.Text = "";
            firstnametb.Text = "";
            lastnametb.Text = "";
            emailtb.Text = "";
            addresstb.Text = "";
            dobtb.Text = "";
            datecreatedtb.Text = "";
            phonenumbertb.Text = "";
            gendertb.Text = "";

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            Clear_all();
        }

        private void viewCustomers_Load(object sender, EventArgs e)
        {

        }
    }
}
