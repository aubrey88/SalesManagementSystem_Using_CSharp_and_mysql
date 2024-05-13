using System.Windows.Forms;

namespace DB2_PROJECT
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {

             item itemForm = new item();
             itemForm.Show();
        }
    }
}
