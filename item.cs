using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DB2_PROJECT
{
    public partial class item : Form
    {


        public item()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadData();


        }

        private void item_Load(object sender, EventArgs e)
        {
            showorderID();
        }

        private void showorderID()
        {
            string my_sql_connection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";

            try
            {

                using (MySqlConnection MySqlConnection = new MySqlConnection(my_sql_connection))
                {
                    MySqlConnection.Open();
                    string query = "select admin_order_id from admin_orders";


                    using (MySqlCommand adminCommand = new MySqlCommand(query, MySqlConnection))
                    {

                        using (MySqlDataReader adminReader = adminCommand.ExecuteReader())
                        {
                            orderidcmb.Items.Clear();
                            while (adminReader.Read())
                            {
                                int admin_order_id = adminReader.GetInt32("admin_order_id");
                                orderidcmb.Items.Add(admin_order_id);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
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
                    string query = "SELECT i.item_id, i.item_name, i.description, i.item_brand, i.cost_per_item, i.quantity, i.item_image, c.category_id, c.category_name, i.supplier_id FROM item i join supplier s on i.supplier_id= s.supplier_id join category c on i.category_id=c.category_id";


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

                            table.Columns.Add("Supplier ID", typeof(int));
                            while (adminReader.Read())
                            {
                                table.Rows.Add(adminReader["item_id"], adminReader["item_name"], adminReader["description"], adminReader["item_brand"], adminReader["cost_per_item"], adminReader["quantity"], adminReader["item_image"] != DBNull.Value ? adminReader["item_image"] : null, adminReader["category_id"], adminReader["category_name"], adminReader["supplier_id"]);
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //making sure a textbox was modified first.
            changesMade = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //making sure a textbox was modified first.
            changesMade = true;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Clear_all();
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
            suppliertb.Text = "";
            itemidtb.Text = "";
            itemimagepb.Image = null;
            orderidcmb.SelectedIndex = -1;
            orderitemidtb.Text = "";
            orderquantitytb.Text = "";
            ordersuppliertb.Text = "";
            itemordercategorytb.Text = "";

        }

        public void Refresh_data()
        {

        }

        private void chooseimgbtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    string selectedFilePath = openFileDialog.FileName;
                    itemimagepb.Image = Image.FromFile(selectedFilePath);
                    itemimagepb.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

        private void datav1_SelectionChanged(object sender, EventArgs e)
        {
            if (datav1.SelectedRows.Count > 0)
            {
                //select row to display it
                DataGridViewRow selectedRow = datav1.SelectedRows[0];


                categoryidtb.Text = selectedRow.Cells["Category ID"].Value.ToString();
                categorytb.Text = selectedRow.Cells["Category Name"].Value.ToString();
                itemordercategorytb.Text = selectedRow.Cells["Category Name"].Value.ToString();
                itemidtb.Text = selectedRow.Cells["Item ID"].Value.ToString();
                brandtb.Text = selectedRow.Cells["Item brand"].Value.ToString();
                orderitemidtb.Text = selectedRow.Cells["Item ID"].Value.ToString();
                nametb.Text = selectedRow.Cells["Item Name"].Value.ToString();
                costtb.Text = selectedRow.Cells["Cost per item"].Value.ToString();
                quantitytb.Text = selectedRow.Cells["Quantity"].Value.ToString();
                descriptiontb.Text = selectedRow.Cells["Description"].Value.ToString();
                suppliertb.Text = selectedRow.Cells["Supplier ID"].Value.ToString();
                ordersuppliertb.Text = selectedRow.Cells["Supplier ID"].Value.ToString();


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

        private void newbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nametb.Text) ||
                string.IsNullOrEmpty(descriptiontb.Text) ||
                string.IsNullOrEmpty(brandtb.Text) ||
                string.IsNullOrEmpty(costtb.Text) ||
                string.IsNullOrEmpty(quantitytb.Text) ||
                string.IsNullOrEmpty(suppliertb.Text) ||

                string.IsNullOrEmpty(categoryidtb.Text))

            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            try
            {
                string itemName = nametb.Text;
                string description = descriptiontb.Text;
                string itemBrand = brandtb.Text;
                decimal costPerItem = decimal.Parse(costtb.Text);
                int quantity = int.Parse(quantitytb.Text);
                int categoryId = int.Parse(categoryidtb.Text);
                string categoryName = categorytb.Text;
                byte[] imageData = null;
                int supplierID = int.Parse(suppliertb.Text);


                if (datav1.SelectedRows[0].Cells["Image"].Value != DBNull.Value)
                {
                    imageData = (byte[])datav1.SelectedRows[0].Cells["Image"].Value;
                }

                string my_sql_connection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";

                try
                {
                    using (MySqlConnection MySqlConnection = new MySqlConnection(my_sql_connection))
                    {
                        MySqlConnection.Open();
                        string query = "insert into item(item_name, description, item_brand, cost_per_item, quantity,  item_image, category_id,supplier_id) " +
                                       "VALUES (@itemName, @description, @itemBrand, @costPerItem, @quantity, @imageData, @categoryId, @supplierID)";

                        using (MySqlCommand sqlCommand = new MySqlCommand(query, MySqlConnection))
                        {
                            sqlCommand.Parameters.AddWithValue("@itemName", itemName);
                            sqlCommand.Parameters.AddWithValue("@description", description);
                            sqlCommand.Parameters.AddWithValue("@itemBrand", itemBrand);
                            sqlCommand.Parameters.AddWithValue("@costPerItem", costPerItem);
                            sqlCommand.Parameters.AddWithValue("@quantity", quantity);
                            sqlCommand.Parameters.AddWithValue("@categoryId", categoryId);
                            sqlCommand.Parameters.AddWithValue("@supplierID", supplierID);
                            sqlCommand.Parameters.AddWithValue("@imageData", (object)imageData ?? DBNull.Value);


                            int rowsAffected = sqlCommand.ExecuteNonQuery();

                            MessageBox.Show("New item added successfully.");
                            Clear_all();
                            LoadData();
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
                MessageBox.Show(ex.Message + "\nPlease make sure the Category field is in integer number! \nCheck category form to know more");
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
            int itemId = Convert.ToInt32(datav1.SelectedRows[0].Cells["Item ID"].Value);
            DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string my_sql_connection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";

                try
                {
                    using (MySqlConnection MySqlConnection = new MySqlConnection(my_sql_connection))
                    {
                        MySqlConnection.Open();
                        string query = "DELETE FROM item WHERE item_id = @itemId";
                        using (MySqlCommand sqlCommand = new MySqlCommand(query, MySqlConnection))
                        {
                            sqlCommand.Parameters.AddWithValue("@itemId", itemId);
                            int rowsAffected = sqlCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Item deleted successfully.");
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

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string keyword = searchtb.Text.Trim();


            string my_sql_connection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";

            try
            {
                using (MySqlConnection MySqlConnection = new MySqlConnection(my_sql_connection))
                {
                    MySqlConnection.Open();
                    string query = @"select i.item_id as 'Item ID', i.item_name as 'Item Name', i.description as 'Description', i.item_brand as 'Item Brand', i.cost_per_item as 'Cost per item', i.quantity as Quantity, i.item_image as Image, c.category_id as 'Category ID', c.category_name as 'Category Name', s.supplier_id as 'Supplier ID'
                             from item i join category c ON i.category_id = c.category_id  join supplier s on i.supplier_id =i.supplier_id where lower(i.item_name) LIKE (lower(@keyword))";


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
                MessageBox.Show(ex.Message);
            }
        }

        private bool changesMade = false;


        private void editbtn_Click(object sender, EventArgs e)
        {
            if (datav1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to edit.");
                return;
            }

            try
            {
                if (changesMade)
                {
                    int itemId = Convert.ToInt32(datav1.SelectedRows[0].Cells["Item ID"].Value);

                    string itemName = nametb.Text;
                    string description = descriptiontb.Text;
                    string itemBrand = brandtb.Text;
                    decimal costPerItem = decimal.Parse(costtb.Text);
                    int quantity = int.Parse(quantitytb.Text);
                    int categoryId = int.Parse(categoryidtb.Text);
                    int supplierID = int.Parse(suppliertb.Text);

                    byte[] imageData = null;


                    if (datav1.SelectedRows[0].Cells["Image"].Value != DBNull.Value)
                    {
                        imageData = (byte[])datav1.SelectedRows[0].Cells["Image"].Value;
                    }


                    if (string.IsNullOrEmpty(itemName) ||
                        string.IsNullOrEmpty(description) ||
                        string.IsNullOrEmpty(itemBrand) ||
                        string.IsNullOrEmpty(costtb.Text) ||
                        string.IsNullOrEmpty(quantitytb.Text) ||
                        string.IsNullOrEmpty(suppliertb.Text) ||
                        string.IsNullOrEmpty(categorytb.Text) ||
                        string.IsNullOrEmpty(categoryidtb.Text))
                    {
                        MessageBox.Show("Please fill in all fields.");
                        return;
                    }

                    // Call update record function
                    UpdateRecord(itemId, itemName, description, itemBrand, costPerItem, quantity, categoryId, imageData, supplierID);

                    MessageBox.Show("Record updated successfully.");
                    changesMade = false;
                    LoadData();
                    Clear_all();
                }
                else
                {
                    MessageBox.Show("No Changes were made!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
       
        }
        


        
        private void UpdateRecord(int itemId, string itemName, string description, string itemBrand, decimal costPerItem, int quantity, int categoryId, byte[] imageData, int supplierID)
        {
            string my_sql_connection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";

            try
            {
                using (MySqlConnection MySqlConnection = new MySqlConnection(my_sql_connection))
                {
                    MySqlConnection.Open();
                    string query = "update item set item_name = @itemName, description = @description, " +
                                   "item_brand = @itemBrand, cost_per_item = @costPerItem, " +
                                   "quantity = @quantity, category_id = @categoryId, " +
                                   "item_image = @imageData," + "supplier_id = @supplier WHERE item_id = @itemId";

                    using (MySqlCommand sqlCommand = new MySqlCommand(query, MySqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@itemId", itemId);
                        sqlCommand.Parameters.AddWithValue("@itemName", itemName);
                        sqlCommand.Parameters.AddWithValue("@description", description);
                        sqlCommand.Parameters.AddWithValue("@itemBrand", itemBrand);
                        sqlCommand.Parameters.AddWithValue("@costPerItem", costPerItem);
                        sqlCommand.Parameters.AddWithValue("@quantity", quantity);
                        sqlCommand.Parameters.AddWithValue("@categoryId", categoryId);
                      

                        sqlCommand.Parameters.AddWithValue("@supplier", supplierID);

                        if (itemimagepb.Image != null)
                        {
                            sqlCommand.Parameters.Add("@imageData", MySqlDbType.Blob).Value = imageData;
                        }

                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }
        }

        private void costtb_TextChanged(object sender, EventArgs e)
        {
            //making sure a textbox was modified first.
            changesMade = true;
        }

        private void quantitytb_TextChanged(object sender, EventArgs e)
        {
            //making sure a textbox was modified first.
            changesMade = true;
        }

        private void brandtb_TextChanged(object sender, EventArgs e)
        {
            //making sure a textbox was modified first.
            changesMade = true;
        }

        private void categorytb_TextChanged(object sender, EventArgs e)
        {
            //making sure a textbox was modified first.
            changesMade = true;
        }

        private void categorybtn_Click(object sender, EventArgs e)
        {
            Category newcat = new Category();
            newcat.Show();
      
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }


        private void datav1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void item_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void adminaddtocartbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string orderitemid = orderitemidtb.Text;
                string quantity = orderquantitytb.Text;

                int adminOrderId = Convert.ToInt32(orderidcmb.SelectedItem);


                string my_sql_connection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";

                try
                {
                    string ordercode = "f";
                    if (orderquantitytb.Text == "")
                    {
                        MessageBox.Show("Quantity number should not be empty!");
                        return;
                    }

                    if (orderidcmb.SelectedIndex==-1)
                    {
                        MessageBox.Show("Order ID should not be empty!");
                        return;
                    }

                    using (MySqlConnection MySqlConnection = new MySqlConnection(my_sql_connection))
                    {
                        MySqlConnection.Open();
                        string query = "insert into admin_order_items(admin_order_id, item_id, quantity) " +
                                       "VALUES (@adminid, @item, @quantity)";

                        using (MySqlCommand sqlCommand = new MySqlCommand(query, MySqlConnection))
                        {
                            sqlCommand.Parameters.AddWithValue("@adminid", adminOrderId);
                            sqlCommand.Parameters.AddWithValue("@item", orderitemid);
                            sqlCommand.Parameters.AddWithValue("@quantity", quantity);


                            int rowsAffected = sqlCommand.ExecuteNonQuery();

                            MessageBox.Show("Item added successfully to Order code: " + adminOrderId + "!");
                            Clear_all();
                           
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

        private void neworderbtn_Click(object sender, EventArgs e)
        {
            string admin = "admin";
            string orderstatus = "pending";

            if (ordersuppliertb.Text == "")
            {
                MessageBox.Show("Please enter a supplier ID in the supplier ID field");
                return;
            }


            string my_sql_connection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";

            try
            {
                int supplierID = int.Parse(ordersuppliertb.Text);

          
                using (MySqlConnection MySqlConnection = new MySqlConnection(my_sql_connection))
                {
                    MySqlConnection.Open();
                    string query = "insert into admin_orders(admin_name, order_status, supplier_id) " +
                                   "VALUES (@adminname, @orderstatus, @supplier)";

                    using (MySqlCommand sqlCommand = new MySqlCommand(query, MySqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@adminname", admin);
                        sqlCommand.Parameters.AddWithValue("@orderstatus", orderstatus);
                        sqlCommand.Parameters.AddWithValue("@supplier", supplierID);



                        int rowsAffected = sqlCommand.ExecuteNonQuery();

                        MessageBox.Show("New Order created successfully.");
                        showorderID();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void orderidcmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cartbtn_Click(object sender, EventArgs e)
        {

        }
    }

}
