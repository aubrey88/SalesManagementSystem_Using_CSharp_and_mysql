using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DB2_PROJECT
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadData();
            LoadSalesData();
            
        }

        private void InitializeDataGridView()
        {

            ((System.ComponentModel.ISupportInitialize)(this.datav1)).BeginInit();
            //this.SuspendLayout();

            this.datav1.AllowUserToAddRows = false;
            this.datav1.AllowUserToDeleteRows = false;
            this.datav1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            // this.datav1.Dock = DockStyle.Fill;
            this.datav1.ReadOnly = true;
            this.datav1.RowTemplate.Height = 120;
            this.Controls.Add(this.datav1);
            ((System.ComponentModel.ISupportInitialize)(this.datav1)).EndInit();
            this.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)(this.salesdata)).BeginInit();
            //this.SuspendLayout();

            this.salesdata.AllowUserToAddRows = false;
            this.salesdata.AllowUserToDeleteRows = false;
            this.salesdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            // this.datav1.Dock = DockStyle.Fill;
            this.salesdata.ReadOnly = true;
            this.salesdata.RowTemplate.Height = 120;
            this.Controls.Add(this.salesdata);
            ((System.ComponentModel.ISupportInitialize)(this.salesdata)).EndInit();
            this.ResumeLayout(false);
        }

        private void LoadSalesData()
        {
            string my_sql_connection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";

            try
            {

                using (MySqlConnection MySqlConnection = new MySqlConnection(my_sql_connection))
                {
                    MySqlConnection.Open();
                    string query = "select p.payment_id, p.payment_date, p.payment_amount, payment_status, " +
                        "p.item_quantity_taken, o.order_id, o.customerid, concat(u.first_name, ' ', u.last_name) " +
                        "as Customer_Name  from payment p join orders o on p.order_id = o.order_id " +
                        "join customer c on o.customerid=c.customer_id join users u on c.user_id = u.user_id " +
                        "order by p.payment_amount desc";

 
                    using (MySqlCommand adminCommand = new MySqlCommand(query, MySqlConnection))
                    {

                        using (MySqlDataReader adminReader = adminCommand.ExecuteReader())
                        {
                            DataTable table = new DataTable();

                            table.Columns.Add("Payment ID", typeof(int));
                            table.Columns.Add("Payment Date", typeof(string));
                            table.Columns.Add("Payment Amount", typeof(string));
                            table.Columns.Add("Payment Status", typeof(string));
                            table.Columns.Add("Item Quantity Taken", typeof(string));

                            table.Columns.Add("Order ID", typeof(int));
                            table.Columns.Add("Customer ID", typeof(int));
                    
                            table.Columns.Add("Customer Name", typeof(string));





                            while (adminReader.Read())
                            {
                                table.Rows.Add(adminReader["payment_id"], adminReader["payment_date"], adminReader["payment_amount"], adminReader["payment_status"], adminReader["item_quantity_taken"], adminReader["order_id"], adminReader["customerid"], adminReader["Customer_Name"]);
                            }
                            salesdata.DataSource = table;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message + "\nStack Trace: " + ex.StackTrace);

            }
        }


        private void LoadData()
        {
            string my_sql_connection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";

            try
            {

                using (MySqlConnection MySqlConnection = new MySqlConnection(my_sql_connection))
                {
                    MySqlConnection.Open();
                    string query = "select ad.admin_order_id, ad.order_date, s.supplier_id, concat(u.first_name, ' ', u.last_name) as Supplier_name, ad.order_status from admin_orders ad join supplier s on ad.supplier_id = s.supplier_id join users u on s.user_id = u.user_id";




                    using (MySqlCommand adminCommand = new MySqlCommand(query, MySqlConnection))
                    {

                        using (MySqlDataReader adminReader = adminCommand.ExecuteReader())
                        {
                            DataTable table = new DataTable();

                            table.Columns.Add("Order ID", typeof(int));
                            table.Columns.Add("Order Date", typeof(string));
                            table.Columns.Add("Supplier ID", typeof(string));
                            table.Columns.Add("Supplier Name", typeof(string));


                            table.Columns.Add("Order status", typeof(string));
                            


                            while (adminReader.Read())
                            {
                                table.Rows.Add(adminReader["admin_order_id"], adminReader["order_date"], adminReader["supplier_id"], adminReader["Supplier_name"], adminReader["order_status"]);
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


        private void button2_Click(object sender, System.EventArgs e)
        {

             item itemForm = new item();
             itemForm.Show();
        }

        private void button6_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
                this.Close();
            }
        }

        private void button4_Click(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            viewCustomers vc = new viewCustomers();
            vc.Show();
            this.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            string username = "admin";
            string my_sql_connection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";

            try
            {
                using (MySqlConnection MySqlConnection = new MySqlConnection(my_sql_connection))
                {
                    MySqlConnection.Open();
                    string query = "SELECT admin_image FROM admins WHERE username = @username";

                    using (MySqlCommand adminCommand = new MySqlCommand(query, MySqlConnection))
                    {
                        adminCommand.Parameters.AddWithValue("@username", username);

                        using (MySqlDataReader adminReader = adminCommand.ExecuteReader())
                        {
                            if (adminReader.Read())
                            {
                                byte[] imgData = (byte[])adminReader["admin_image"];
                                using (var ms = new System.IO.MemoryStream(imgData))
                                {
                                    profilepb.Image = Image.FromStream(ms);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
    }
}
