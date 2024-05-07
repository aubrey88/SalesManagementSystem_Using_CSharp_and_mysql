using MySql.Data.MySqlClient;
using System;
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
                    string query = "SELECT item_id, item_name, description, item_brand, cost_per_item, quantity, item_image, category_id FROM item";

                    
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
                            table.Columns.Add("Category", typeof(int));

                            while (adminReader.Read())
                            {
                                table.Rows.Add(adminReader["item_id"], adminReader["item_name"], adminReader["description"], adminReader["item_brand"], adminReader["cost_per_item"], adminReader["quantity"], adminReader["item_image"], adminReader["category_id"]);
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

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            Clear_all();
        }

        public void Clear_all()
        {
            categorytb.Text = "";
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

             
                categorytb.Text = selectedRow.Cells["Category"].Value.ToString();
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
                string.IsNullOrEmpty(categorytb.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string itemName = nametb.Text;
            string description = descriptiontb.Text;
            string itemBrand = brandtb.Text;
            decimal costPerItem = decimal.Parse(costtb.Text);
            int quantity = int.Parse(quantitytb.Text);
            int categoryId = int.Parse(categorytb.Text);
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

    }
}
