using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DB2_PROJECT
{
    public partial class customeritempage : Form
    {

        private string loggedInUsername;
        public customeritempage()
        {
            InitializeComponent();
         
        }

  


        public customeritempage(string loggedInUsername)
        {
            InitializeComponent();
            this.loggedInUsername = loggedInUsername;
            InitializeDataGridView();
            LoadData();
        }


        private void disableall()
        {
            categoryidtb.Enabled = false;
            categorytb.Enabled = false;
            nametb.Enabled = false;
            costtb.Enabled = false;
            brandtb.Enabled = false;
            descriptiontb.Enabled = false;
        }

        public void Clear_all()
        {
            categorytb.Text = "";
            categoryidtb.Text = "";
            brandtb.Text = "";
            nametb.Text = "";
            costtb.Text = "";
            quantitytb.Text = "";
            descriptiontb.Text = "";
            itemidtb.Text = "";
            itemimagepb.Image = null;

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
            this.datav1.RowTemplate.Height = 120;
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
                    string query = "SELECT i.item_id, i.item_name, i.description, i.item_brand, i.cost_per_item, i.quantity, i.item_image, c.category_id, c.category_name FROM item i join category c on i.category_id=c.category_id";


                    using (MySqlCommand adminCommand = new MySqlCommand(query, MySqlConnection))
                    {

                        using (MySqlDataReader adminReader = adminCommand.ExecuteReader())
                        {
                            DataTable table = new DataTable();

                            table.Columns.Add("Item ID", typeof(int));
                            table.Columns.Add("Item Name", typeof(string));
                            table.Columns.Add("Description", typeof(string));
                            table.Columns.Add("Item brand", typeof(string));
                            table.Columns.Add("Cost per item", typeof(string));
                            table.Columns.Add("Quantity", typeof(string));

                            table.Columns.Add("Image", typeof(byte[]));
                            table.Columns.Add("Category ID", typeof(int));
                            table.Columns.Add("Category Name", typeof(string));

                            while (adminReader.Read())
                            {
                                table.Rows.Add(adminReader["item_id"], adminReader["item_name"], adminReader["description"], adminReader["item_brand"], adminReader["cost_per_item"], adminReader["quantity"], adminReader["item_image"], adminReader["category_id"], adminReader["category_name"]);
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
        private void customeritempage_Load(object sender, EventArgs e)
        {
            disableall();
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
                        string query = @"select i.item_id, i.item_name, i.description, i.item_brand, i.cost_per_item, i.quantity, i.item_image, c.category_name 
                             from item i join category c ON i.category_id = c.category_id where lower(i.item_name) LIKE (lower(@keyword))";


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

        private void datav1_SelectionChanged(object sender, EventArgs e)
        {
           
                if (datav1.SelectedRows.Count > 0)
                {
                    //select row to display it
                    DataGridViewRow selectedRow = datav1.SelectedRows[0];

                     itemidtb.Text = selectedRow.Cells["Item ID"].Value.ToString();

                    categoryidtb.Text = selectedRow.Cells["Category ID"].Value.ToString();
                    categorytb.Text = selectedRow.Cells["Category Name"].Value.ToString();
                    brandtb.Text = selectedRow.Cells["Item brand"].Value.ToString();
                    nametb.Text = selectedRow.Cells["Item Name"].Value.ToString();
                    costtb.Text = selectedRow.Cells["Cost per item"].Value.ToString();
                    quantitytb.Text = selectedRow.Cells["Quantity"].Value.ToString();
                    descriptiontb.Text = selectedRow.Cells["Description"].Value.ToString();


                    if (selectedRow.Cells["Image"].Value != DBNull.Value)
                    {
                        //get the image row 
                        byte[] imageData = (byte[])selectedRow.Cells["Image"].Value;
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            itemimagepb.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        itemimagepb.Image = null;
                    }
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
                        case "Item ID":
                            datav1.Sort(datav1.Columns["Item ID"], ListSortDirection.Ascending);
                            break;
                        case "Item Name":
                            datav1.Sort(datav1.Columns["Item Name"], ListSortDirection.Ascending);
                            break;
                        case "Item Brand":
                            datav1.Sort(datav1.Columns["Item Brand"], ListSortDirection.Ascending);
                            break;
                        case "Category":
                            datav1.Sort(datav1.Columns["Category"], ListSortDirection.Ascending);
                            break;
                        case "Cost per item":
                            datav1.Sort(datav1.Columns["Cost per item"], ListSortDirection.Ascending);
                            break;
                        case "Quantity":
                            datav1.Sort(datav1.Columns["Quantity"], ListSortDirection.Ascending);
                            break;
                        default:

                            datav1.Sort(datav1.Columns["Item ID"], ListSortDirection.Ascending);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nSearch box must be cleared!");
                }
            
        }

        private void orderitembtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(quantitytb.Text))

            {
                MessageBox.Show("Please enter how many quantity you want!");
                return;
            }
            try
                {

                string orderstatus = "Pending confirmation";
                int itemid = int.Parse(itemidtb.Text);
                int quantity = int.Parse(quantitytb.Text);


                    string my_sql_connection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";

                    try
                    {

                    using (MySqlConnection MySqlConnection = new MySqlConnection(my_sql_connection))
                    {
                        MySqlConnection.Open();

                        string quantityQuery = "SELECT quantity FROM item WHERE item_id = @itemid";

                        int availableQuantity;
                        using (MySqlCommand quantityCommand = new MySqlCommand(quantityQuery, MySqlConnection))
                        {
                            quantityCommand.Parameters.AddWithValue("@itemid", itemid);
                            object result = quantityCommand.ExecuteScalar();
                            if (result == null || result == DBNull.Value)
                            {
                                MessageBox.Show("Item not found!");
                                return;
                            }
                            availableQuantity = Convert.ToInt32(result);
                        }

                        if (quantity > availableQuantity)
                        {
                            MessageBox.Show("Not enough quantity available in stock!");
                            orderstatus = "Insufficient stock";
                        }
                        else
                        {

                            string customerQuery = "SELECT customer_id FROM customer " +
                          "INNER JOIN users ON customer.user_id = users.user_id " +
                          "WHERE users.username = @loggedInUsername";

                            int customerid;
                            using (MySqlCommand customerCommand = new MySqlCommand(customerQuery, MySqlConnection))
                            {
                                customerCommand.Parameters.AddWithValue("@loggedInUsername", loggedInUsername);
                                object result = customerCommand.ExecuteScalar();
                                if (result == null || result == DBNull.Value)
                                {
                                    MessageBox.Show("Customer not found!");
                                    return;
                                }
                                customerid = Convert.ToInt32(result);
                            }

                            string query = "insert into orders(item_id, quantity, order_status,customerid) " +
                                               "VALUES (@item_id, @quantity, @order_status, @customerid)";

                            using (MySqlCommand sqlCommand = new MySqlCommand(query, MySqlConnection))
                            {

                                sqlCommand.Parameters.AddWithValue("@item_id", itemid);
                                sqlCommand.Parameters.AddWithValue("@quantity", quantity);
                                sqlCommand.Parameters.AddWithValue("@customerid", customerid);
                                sqlCommand.Parameters.AddWithValue("@order_status", orderstatus);


                                int rowsAffected = sqlCommand.ExecuteNonQuery();

                                MessageBox.Show("Order has been placed successfully!");
                                Clear_all();


                            }
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

        private void customeritempage_FormClosing(object sender, FormClosingEventArgs e)
        {
            CustomerForm cff = new CustomerForm(loggedInUsername);
            cff.Show();
        }
    }

   
    
}
