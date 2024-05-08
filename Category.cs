using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            // this.datav1.Dock = DockStyle.Fill;
            this.datav1.ReadOnly = true;
            this.datav1.RowTemplate.Height = 120;
            this.Controls.Add(this.datav1);
            ((System.ComponentModel.ISupportInitialize)(this.datav1)).EndInit();
            this.ResumeLayout(false);
        }
        private void Category_Load(object sender, EventArgs e)
        {


            LoadData();
        }

        private void LoadData()
        {
            string my_sql_connection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";

            try
            {

                using (MySqlConnection MySqlConnection = new MySqlConnection(my_sql_connection))
                {
                    MySqlConnection.Open();
                    string query = "SELECT category_id, category_name from category";


                    using (MySqlCommand adminCommand = new MySqlCommand(query, MySqlConnection))
                    {

                        using (MySqlDataReader adminReader = adminCommand.ExecuteReader())
                        {
                            DataTable table = new DataTable();

                            table.Columns.Add("Category ID", typeof(int));
                            table.Columns.Add("Category name", typeof(string));
                            

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
    }
}
