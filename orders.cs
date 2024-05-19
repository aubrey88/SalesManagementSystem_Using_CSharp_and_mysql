using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace DB2_PROJECT
{
    public partial class orders : Form
    {

        private string loggedInUsername;
        public orders()
        {
            InitializeComponent();
            LoadData();
        }

        public orders(string username)
        {
            loggedInUsername = username;

            InitializeComponent();
            InitializeDataGridView();
            LoadData();
        }


        private void orders_Load(object sender, EventArgs e)
        {
            label4.Text = loggedInUsername;
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
                    string query = "SELECT o.order_id, o.order_date, o.item_id, i.item_name,i.item_image,o.quantity,o.total_price,o.order_status FROM orders o join customer c on o.customerid=c.customer_id join users u on c.user_id=u.user_id join item i on o.item_id=i.item_id where u.username=@customerid";

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

        private void datav1_SelectionChanged(object sender, EventArgs e)
        {
            if (datav1.SelectedRows.Count > 0)
            {
                //select row to display it
                DataGridViewRow selectedRow = datav1.SelectedRows[0];


                orderidtb.Text = selectedRow.Cells["Order ID"].Value.ToString();
                orderdatetb.Text = selectedRow.Cells["Order date"].Value.ToString();
                itemidtb.Text = selectedRow.Cells["Item ID"].Value.ToString();
                itemnametb.Text = selectedRow.Cells["Item name"].Value.ToString();
                quantitytb.Text = selectedRow.Cells["Quantity"].Value.ToString();
         

     
            }

     
        }

        private void orders_FormClosing(object sender, FormClosingEventArgs e)
        {
            CustomerForm cf = new CustomerForm(loggedInUsername);
            cf.Show();

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            clear_all();
        }

        public void clear_all()
        {
            quantitytb.Text = "";
            amounttb.Text = "";
            itemidtb.Text = "";
            itemnametb.Text = "";
            orderidtb.Text = "";
            orderdatetb.Text = "";
        }

        private void makepaymentbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int orderitemid = int.Parse(orderidtb.Text);
                string orderdate = orderdatetb.Text;
                int itemid = int.Parse(itemidtb.Text);
                string orderitemname = itemnametb.Text;
                int quantity = int.Parse(quantitytb.Text);
                string paymentstatus = "pending";


                if (string.IsNullOrEmpty(orderidtb.Text) ||
                      string.IsNullOrEmpty(orderdatetb.Text) ||
                      string.IsNullOrEmpty(itemidtb.Text) ||
                      string.IsNullOrEmpty(itemnametb.Text) ||

                      string.IsNullOrEmpty(quantitytb.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }


                string my_sql_connection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";

                try
                {
                   

                    using (MySqlConnection MySqlConnection = new MySqlConnection(my_sql_connection))
                    {
                        MySqlConnection.Open();

                        string costQuery = "SELECT cost_per_item FROM item WHERE item_id = @itemid";
                        decimal costPerItem = 0;

                        using (MySqlCommand costCommand = new MySqlCommand(costQuery, MySqlConnection))
                        {
                            costCommand.Parameters.AddWithValue("@itemid", itemid);
                            object result = costCommand.ExecuteScalar();
                            if (result != null)
                            {
                                costPerItem = Convert.ToDecimal(result);
                            }
                            else
                            {
                                MessageBox.Show("Invalid item ID.");
                                return;
                            }
                        }

                        // decimal amount = costPerItem * quantity;
                        decimal amount = decimal.Parse(amounttb.Text);

                        amounttb.Text = amount.ToString();
                      
                       
                        string query = "insert into payment(payment_amount,payment_status,item_quantity_taken,order_id) " +
                                       "VALUES (@amount, @status, @quantity, @orderid)";

                        using (MySqlCommand sqlCommand = new MySqlCommand(query, MySqlConnection))
                        {
                            sqlCommand.Parameters.AddWithValue("@amount", amount);
                            sqlCommand.Parameters.AddWithValue("@status", paymentstatus);
                      

                            sqlCommand.Parameters.AddWithValue("@quantity", quantity);
                            sqlCommand.Parameters.AddWithValue("@orderid", orderitemid);

                            int rowsAffected = sqlCommand.ExecuteNonQuery();

                            MessageBox.Show("Payment code generated for order code:  " + orderitemid +" ! " + "\n\n\n Go to Payment form to complete payment");
                            clear_all();

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

 

        private void quantitytb_TextChanged(object sender, EventArgs e)
        {

            try
            {
                int itemid = int.Parse(itemidtb.Text); 
                int quantity;

                if (!int.TryParse(quantitytb.Text, out quantity))
                {
                    amounttb.Text = "0";
                    return;
                }

                string my_sql_connection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";

                using (MySqlConnection MySqlConnection = new MySqlConnection(my_sql_connection))
                {
                    MySqlConnection.Open();
                    string costQuery = "SELECT cost_per_item FROM item WHERE item_id = @itemid";
                    decimal costPerItem = 0;

                    using (MySqlCommand costCommand = new MySqlCommand(costQuery, MySqlConnection))
                    {
                        costCommand.Parameters.AddWithValue("@itemid", itemid);
                        object result = costCommand.ExecuteScalar();
                        if (result != null)
                        {
                            costPerItem = Convert.ToDecimal(result);
                        }
                        else
                        {
                            MessageBox.Show("Invalid item ID.");
                            return;
                        }
                    }
                    decimal amount = costPerItem * quantity;
                    amounttb.Text = amount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
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
            int odId = Convert.ToInt32(datav1.SelectedRows[0].Cells["Order ID"].Value);
            DialogResult result = MessageBox.Show("Are you sure you want to delete this Order?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string my_sql_connection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";

                try
                {
                    using (MySqlConnection MySqlConnection = new MySqlConnection(my_sql_connection))
                    {
                        MySqlConnection.Open();
                        string query = "DELETE FROM orders WHERE order_id = @orderId";
                        using (MySqlCommand sqlCommand = new MySqlCommand(query, MySqlConnection))
                        {
                            sqlCommand.Parameters.AddWithValue("@orderId", odId);
                            int rowsAffected = sqlCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Order deleted successfully.");
                                clear_all();
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("Cannot delete, invalid Order ID");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot delete an order in Payment processing stage!" + "\n\n \n Delete payment for this order first!");
                }
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string keyword = searchtb.Text.Trim();


            string my_sql_connection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";

            try
            {
                using (MySqlConnection MySqlConnection = new MySqlConnection(my_sql_connection))
                {
                    MySqlConnection.Open();
                    
                    string query = "SELECT o.order_id as 'Order ID', o.order_date as'Order date', o.item_id as 'Item ID', i.item_name as 'Item name',i.item_image as 'Item image',o.quantity as Quantity,o.total_price as 'Total price',o.order_status as 'Order status' FROM orders o join customer c on o.customerid=c.customer_id join users u on c.user_id=u.user_id join item i on o.item_id=i.item_id where o.order_id LIKE @keyword";
                    

                    using (MySqlCommand sqlCommand = new MySqlCommand(query, MySqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                        DataTable table = new DataTable();

                        using (MySqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            table.Load(reader);
                        }
                        datav1.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching for item: " + ex.Message);
            }
        }

        private void searchtb_TextChanged(object sender, EventArgs e)
        {
            string a = searchtb.Text.ToString();
            if (searchtb.Text == "")
            {
                LoadData();
            }
        }

        private void sortcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sorting it by using column names to match the cases(string)
            string selectedoption = sortcmb.SelectedItem.ToString();


            try
            {
                switch (selectedoption)
                {
                    case "Order ID":
                        datav1.Sort(datav1.Columns["Order ID"], ListSortDirection.Ascending);
                        break;
                    case "Order Date":
                        datav1.Sort(datav1.Columns["Order date"], ListSortDirection.Ascending);
                        break;
                    case "Item ID":
                        datav1.Sort(datav1.Columns["Item ID"], ListSortDirection.Ascending);
                        break;
                    case "Item Name":
                        datav1.Sort(datav1.Columns["Item name"], ListSortDirection.Ascending);
                        break;
                    case "Total amount":
                        datav1.Sort(datav1.Columns["Total price"], ListSortDirection.Ascending);
                        break;
                    case "Quantity":
                        datav1.Sort(datav1.Columns["Quantity"], ListSortDirection.Ascending);
                        break;
                    default:

                        datav1.Sort(datav1.Columns["Order ID"], ListSortDirection.Ascending);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
