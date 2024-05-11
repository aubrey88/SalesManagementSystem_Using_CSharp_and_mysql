using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DB2_PROJECT
{
    public partial class Category : Form
    {
        public Category()
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
            this.datav1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
            //this.datav1.Dock = DockStyle.Fill;
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
                    string query = "SELECT c.category_id, c.category_name FROM category c";


                    using (MySqlCommand adminCommand = new MySqlCommand(query, MySqlConnection))
                    {

                        using (MySqlDataReader adminReader = adminCommand.ExecuteReader())
                        {
                            DataTable table = new DataTable();

                            table.Columns.Add("Category ID", typeof(int));
                            table.Columns.Add("Category Name", typeof(string));


                            while (adminReader.Read())
                            {
                                table.Rows.Add(adminReader["category_id"], adminReader["category_name"]);
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
        private void Category_Load(object sender, EventArgs e)
        {


       
        }


        public void Clear_all()
        {
            categorynametb.Text = "";
            categoryidtb.Text = "";
            

        }

        private void datav1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void newbtn_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(categorynametb.Text) ||
              string.IsNullOrEmpty(categoryidtb.Text))

            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            try
            {

                int categoryId = int.Parse(categoryidtb.Text);
                string categoryName = categorynametb.Text;


                string my_sql_connection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";

                try
                {
                    using (MySqlConnection MySqlConnection = new MySqlConnection(my_sql_connection))
                    {
                        MySqlConnection.Open();
                        string query = "insert into category(category_id,category_name) " +
                                       "VALUES (@category_id, @category_name)";

                        using (MySqlCommand sqlCommand = new MySqlCommand(query, MySqlConnection))
                        {
                            sqlCommand.Parameters.AddWithValue("@category_id", categoryId);
                            sqlCommand.Parameters.AddWithValue("@category_name", categoryName);


                            int rowsAffected = sqlCommand.ExecuteNonQuery();

                            MessageBox.Show("New Category added successfully.");
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
                MessageBox.Show(ex.Message + "\n");
            }
        }

        private void datav1_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (datav1.SelectedRows.Count > 0)
                {
                    //select row to display it
                    DataGridViewRow selectedRow = datav1.SelectedRows[0];


                    categoryidtb.Text = selectedRow.Cells["Category ID"].Value.ToString();
                    categorynametb.Text = selectedRow.Cells["Category Name"].Value.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          

        }

        private void clear_Click(object sender, EventArgs e)
        {
            Clear_all();
            
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
                    string query = @"select c.category_id, c.category_name  from category c where lower(c.category_name) LIKE (lower(@keyword))";


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

        private void deletebtn_Click_1(object sender, EventArgs e)
        {
            if (datav1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a category to delete.");
                return;
            }

            //find the selected row
            int catId = Convert.ToInt32(datav1.SelectedRows[0].Cells["Category ID"].Value);
            DialogResult result = MessageBox.Show("Are you sure you want to delete this Category?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool categoryInUse = IsCategoryInUse(catId);

                if (categoryInUse)
                {
                    MessageBox.Show("Cannot delete the category because it is associated with one or more items.");
                    return;
                }

                string my_sql_connection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";

                try
                {
                    using (MySqlConnection MySqlConnection = new MySqlConnection(my_sql_connection))
                    {
                        MySqlConnection.Open();
                        string query = "DELETE FROM category WHERE category_id = @categoryId";
                        using (MySqlCommand sqlCommand = new MySqlCommand(query, MySqlConnection))
                        {
                            sqlCommand.Parameters.AddWithValue("@categoryId", catId);
                            int rowsAffected = sqlCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Category deleted successfully.");
                                Clear_all();
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("Cannot delete, invalid Category ID");
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

        private bool IsCategoryInUse(int categoryId)
        {
            string my_sql_connection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";
            bool categoryInUse = false;

            try
            {
                using (MySqlConnection MySqlConnection = new MySqlConnection(my_sql_connection))
                {
                    MySqlConnection.Open();
                    string query = "SELECT COUNT(*) FROM item WHERE category_id = @categoryId";
                    using (MySqlCommand sqlCommand = new MySqlCommand(query, MySqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@categoryId", categoryId);
                        object result = sqlCommand.ExecuteScalar();
                        int count = Convert.ToInt32(result);
                        categoryInUse = count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return categoryInUse;
        }

        private bool changesMade = false;

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (datav1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a category to edit.");
                return;
            }

            try
            {
                if (changesMade)
                {
                    int catID = Convert.ToInt32(datav1.SelectedRows[0].Cells["Category ID"].Value);


                    string categoyID = categoryidtb.Text;
                    string catName = categorynametb.Text;
                   

                    if (string.IsNullOrEmpty(categoryidtb.Text) ||
             string.IsNullOrEmpty(categoryidtb.Text))

                    {
                        MessageBox.Show("Please fill in all fields.");
                        return;
                    }
                    //call update record function
                    UpdateRecord(catID, catName);

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n");
            }
        }

        private void UpdateRecord(int itemId, string itemName)
        {
            string my_sql_connection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";

            try
            {
                using (MySqlConnection MySqlConnection = new MySqlConnection(my_sql_connection))
                {
                    MySqlConnection.Open();
                    string query = "update category set category_name = @catName WHERE category_id = @catId";

                    using (MySqlCommand sqlCommand = new MySqlCommand(query, MySqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@catId", itemId);
                        sqlCommand.Parameters.AddWithValue("@catName", itemName);
          
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating record: " + ex.Message);
            }
        }

        private void categoryidtb_TextChanged(object sender, EventArgs e)
        {
            //making sure a textbox was modified first.
            changesMade = true;
        }

        private void categorynametb_TextChanged(object sender, EventArgs e)
        {
            //making sure a textbox was modified first.
            changesMade = true;
           // categoryidtb.Enabled = false;
        }

        private void searchtb_TextChanged_1(object sender, EventArgs e)
        {
            string a = searchtb.Text.ToString();
            if (searchtb.Text == "")
            {
                LoadData();
            }
        }
    }
}
