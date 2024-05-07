using System;
using System.Windows.Forms;

namespace DB2_PROJECT
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        public string LoggedInUsername { get; set; }

        public CustomerForm(string loggedInUsername)
        {
            InitializeComponent();
            this.LoggedInUsername = loggedInUsername;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string loggedInUsername = LoggedInUsername;

            usernamelbl.Text = loggedInUsername;

            CustomerForm cf = new CustomerForm(loggedInUsername);

            Dashboard da = new Dashboard();
            da.Show();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
