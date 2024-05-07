using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;


namespace DB2_PROJECT
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            SignupForm f1 = new SignupForm();
            f1.Close();


            Form1 me = new Form1();
            me.Show();
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            string my_sql_connection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";
            try
            {
                MySqlConnection MySqlConnection = new MySqlConnection(my_sql_connection);

                MySqlConnection.Open();

                string username = usernametb.Text.ToString();
                string password = passwordtb.Text.ToString();
                string first_name = firstnametb.Text.ToString();
                string last_name = lastnametb.Text.ToString();
                string email = emailtb.Text.ToString();
                string dob = dobtb.Text.ToString();
                string address = addresstb.Text.ToString();
                string phonenumber = phonetb.Text.ToString();
                string gender = gendertb.Text.ToString();
                byte[] profileImage = ImageToByteArray(profilepb.Image);

                if (profilepb.Image == Properties.Resource1.images)
                {
                    MessageBox.Show("Profile picture cannot be empty!");
                    return;
                }

                if ((String.IsNullOrEmpty(username)) || (profilepb.Image == null) || (String.IsNullOrEmpty(address)) || (String.IsNullOrEmpty(gender)) || (String.IsNullOrEmpty(phonenumber)) || (String.IsNullOrEmpty(dob)) || (String.IsNullOrEmpty(password)) || (String.IsNullOrEmpty(last_name)) || (String.IsNullOrEmpty(first_name)) || (String.IsNullOrEmpty(email)))
                {

                    MessageBox.Show("No field should be empty!");
                    usernametb.Focus();
                }
                else
                {
                    string query = "INSERT INTO users (first_name, last_name, date_of_birth, gender, address, email, phone_number, username, userpassword, profileimage) VALUES (@first_name, @last_name, @dob, @gender, @address, @email, @phone_number, @username, @password, @profile)";

                    MySqlCommand cmd = new MySqlCommand(query, MySqlConnection);
                    cmd.Parameters.AddWithValue("@first_name", first_name);
                    cmd.Parameters.AddWithValue("@last_name", last_name);
                    cmd.Parameters.AddWithValue("@dob", dob);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone_number", phonenumber);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@profile", profileImage);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("User created successfully!");
                }

                byte[] ImageToByteArray(Image image)
                {
                    using (System.IO.MemoryStream ms = new MemoryStream())
                    {
                        image.Save(ms, ImageFormat.Jpeg);
                        return ms.ToArray();
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

