using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DB2_PROJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string my_sql_connection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";
           MySqlConnection  MySqlConnection = new MySqlConnection(my_sql_connection);
            try
            {
                MySqlConnection.Open();
                MessageBox.Show("Connection Successful");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                MySqlConnection.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
