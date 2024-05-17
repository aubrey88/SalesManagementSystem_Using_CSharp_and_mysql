using MySql.Data.MySqlClient;
using System;
using System.Data;
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
            this.Hide();


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

                if (profilepb.Image == null)
                {
                    MessageBox.Show("Profile picture cannot be empty!");
                    return;
                }

                if ((String.IsNullOrEmpty(username)) || (String.IsNullOrEmpty(address)) || (String.IsNullOrEmpty(gender)) || (String.IsNullOrEmpty(phonenumber)) || (String.IsNullOrEmpty(dob)) || (String.IsNullOrEmpty(password)) || (String.IsNullOrEmpty(last_name)) || (String.IsNullOrEmpty(first_name)) || ((profilepb.Image==Properties.Resource1.images)) || (String.IsNullOrEmpty(email)))
                {
                    MessageBox.Show("No field should be empty!");
                    usernametb.Focus();
                }
                else
                {
                    //directly calling the procedures
                    using (MySqlCommand cmd = new MySqlCommand("insert_user", MySqlConnection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_first_name", first_name);
                        cmd.Parameters.AddWithValue("@p_last_name", last_name);
                        cmd.Parameters.AddWithValue("@p_gender", gender);
                        cmd.Parameters.AddWithValue("@p_date_of_birth", dob);
                        cmd.Parameters.AddWithValue("@p_address", address);
                        cmd.Parameters.AddWithValue("@p_email", email);
                        cmd.Parameters.AddWithValue("@p_phone_number", phonenumber);
                        cmd.Parameters.AddWithValue("@p_profileimage", profileImage);
                        cmd.Parameters.AddWithValue("@p_username", username);
                        cmd.Parameters.AddWithValue("@p_userpassword", password);

                        
                        cmd.ExecuteNonQuery();

                        //using (MySqlCommand cmdCustomer = new MySqlCommand("insert_customer", MySqlConnection))
                        //{
                        //    cmdCustomer.CommandType = CommandType.StoredProcedure;
                        //    cmdCustomer.ExecuteNonQuery();
                        //}

                        MessageBox.Show("Your account has been created successfully!");
                        clearall();
                    }
                }

                byte[] ImageToByteArray(Image image)
                {
                    if (image == null)
                    {
                        return null;
                    }

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

        private void clearall()
        {
            usernametb.Text = "";
            passwordtb.Text = "";
            profilepb.Image = null;
            firstnametb.Text = "";
            lastnametb.Text = "";
            gendertb.Text = "";
            dobtb.Text = "";
            addresstb.Text = "";
            emailtb.Text = "";
            phonetb.Text = "";
        }

        private void chooseimagebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    string selectedFilePath = openFileDialog.FileName;
                    profilepb.Image = Image.FromFile(selectedFilePath);
                    profilepb.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }
    }
}

