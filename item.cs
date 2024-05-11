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
            itemimagepb.Image = null;

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

        private void newbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nametb.Text) ||
                string.IsNullOrEmpty(descriptiontb.Text) ||
                string.IsNullOrEmpty(brandtb.Text) ||
                string.IsNullOrEmpty(costtb.Text) ||
                string.IsNullOrEmpty(quantitytb.Text) ||
                string.IsNullOrEmpty(categorytb.Text) ||
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


                if (itemimagepb.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        itemimagepb.Image.Save(ms, itemimagepb.Image.RawFormat);
                        imageData = ms.ToArray();
                    }
                }

                string my_sql_connection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";

                try
                {
                    using (MySqlConnection MySqlConnection = new MySqlConnection(my_sql_connection))
                    {
                        MySqlConnection.Open();
                        string query = "insert into item(item_name, description, item_brand, cost_per_item, quantity,  item_image, category_id) " +
                                       "VALUES (@itemName, @description, @itemBrand, @costPerItem, @quantity, @imageData, @categoryId)";

                        using (MySqlCommand sqlCommand = new MySqlCommand(query, MySqlConnection))
                        {
                            sqlCommand.Parameters.AddWithValue("@itemName", itemName);
                            sqlCommand.Parameters.AddWithValue("@description", description);
                            sqlCommand.Parameters.AddWithValue("@itemBrand", itemBrand);
                            sqlCommand.Parameters.AddWithValue("@costPerItem", costPerItem);
                            sqlCommand.Parameters.AddWithValue("@quantity", quantity);
                            sqlCommand.Parameters.AddWithValue("@categoryId", categoryId);
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+ "\nSearch box must be cleared!");
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


                    Image profileImage = itemimagepb.Image;
                    if (profileImage != null)
                    {

                        byte[] imageData = ImageToByteArray(profileImage);


                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            itemimagepb.Image = Image.FromStream(ms);
                        }



                        if (string.IsNullOrEmpty(nametb.Text) ||
             string.IsNullOrEmpty(descriptiontb.Text) ||
             string.IsNullOrEmpty(brandtb.Text) ||
             string.IsNullOrEmpty(costtb.Text) ||
             string.IsNullOrEmpty(quantitytb.Text) ||
             string.IsNullOrEmpty(categorytb.Text) ||
             string.IsNullOrEmpty(categoryidtb.Text))

                        {
                            MessageBox.Show("Please fill in all fields.");
                            return;
                        }
                        //call update record function
                        UpdateRecord(itemId, itemName, description, itemBrand, costPerItem, quantity, categoryId, imageData);

                        MessageBox.Show("Record updated successfully.");
                        changesMade = false;
                        LoadData();
                        Clear_all();
                    }
                    else
                    {
                        MessageBox.Show("No changes were made.");
                    }
                }
                else
                {
                    MessageBox.Show("No image selected");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Please make sure the Category field is in integer number! \nCheck category form to know more");
            }
        }

        
        private void UpdateRecord(int itemId, string itemName, string description, string itemBrand, decimal costPerItem, int quantity, int categoryId, byte[] imageData)
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
                                   "item_image = @imageData WHERE item_id = @itemId";

                    using (MySqlCommand sqlCommand = new MySqlCommand(query, MySqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@itemId", itemId);
                        sqlCommand.Parameters.AddWithValue("@itemName", itemName);
                        sqlCommand.Parameters.AddWithValue("@description", description);
                        sqlCommand.Parameters.AddWithValue("@itemBrand", itemBrand);
                        sqlCommand.Parameters.AddWithValue("@costPerItem", costPerItem);
                        sqlCommand.Parameters.AddWithValue("@quantity", quantity);
                        sqlCommand.Parameters.AddWithValue("@categoryId", categoryId);
                        sqlCommand.Parameters.AddWithValue("@imageData", (object)imageData ?? DBNull.Value); // Use DBNull.Value if imageData is null

                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating record: " + ex.Message);
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
    }

}
