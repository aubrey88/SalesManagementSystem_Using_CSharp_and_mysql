using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DB2_PROJECT
{
    public partial class editform : Form
    {
        private string loggedInUsername;
        public editform()
        {
            InitializeComponent();
        }
        public editform(string loggedInUsername)
        {
            InitializeComponent();
            this.loggedInUsername = loggedInUsername;
        }
        private void editform_Load(object sender, EventArgs e)
        {
            
            FetchUserData();
        }

        private void FetchUserData()
        {
            string mySqlConnection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";

            try
            {
                using (MySqlConnection MySqlConnection = new MySqlConnection(mySqlConnection))
                {
                    MySqlConnection.Open();

                    MySqlCommand userCommand = new MySqlCommand("SELECT first_name, last_name,  address, phone_number, profileimage FROM users WHERE username = @username", MySqlConnection);
                    userCommand.Parameters.AddWithValue("@username", loggedInUsername);
                    MySqlDataReader userReader = userCommand.ExecuteReader();

                    if (userReader.Read())
                    {
                        //usernamelbl.Text = loggedInUsername;

                        string address = userReader.GetString("address");
                        addresstb.Text = address;

                        string firstname = userReader.GetString("first_name");
                        firstnametb.Text = firstname;

                        string lastname = userReader.GetString("last_name");
                        lastnametb.Text = lastname;

                        string phonenum = userReader.GetString("phone_number");
                        phonenumbertb.Text = phonenum;





                        if (!userReader.IsDBNull(userReader.GetOrdinal("profileimage")))
                        {
                            byte[] imageData = (byte[])userReader["profileimage"];
                            editprofilepb.Image = Image.FromStream(new MemoryStream(imageData));
                        }
                        else
                        {
                            editprofilepb.Image = null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("User not found!");
                    }

                    userReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editimagebtn_Click(object sender, EventArgs e)
        {
            {

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                DialogResult result = openFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    try
                    {
                        string selectedFilePath = openFileDialog.FileName;
                        editprofilepb.Image = Image.FromFile(selectedFilePath);
                        editprofilepb.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message);
                    }
                }
            }
        }



        private void confirmchangesbtn_Click_1(object sender, EventArgs e)
        {
            string mySqlConnection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";

            try
            {
                using (MySqlConnection MySqlConnection = new MySqlConnection(mySqlConnection))
                {
                    MySqlConnection.Open();

                    MySqlCommand updateCommand = new MySqlCommand("UPDATE users SET first_name = @firstName, last_name = @lastName, address = @address, phone_number = @phonenumber, profileimage = @profileImage WHERE username = @username", MySqlConnection);
                    updateCommand.Parameters.AddWithValue("@firstName", firstnametb.Text);
                    updateCommand.Parameters.AddWithValue("@lastName", lastnametb.Text);
                    updateCommand.Parameters.AddWithValue("@address", addresstb.Text);
                    updateCommand.Parameters.AddWithValue("@phonenumber", phonenumbertb.Text);
                    updateCommand.Parameters.AddWithValue("@username", loggedInUsername);

                    if (editprofilepb.Image != null)
                    {
                        MemoryStream ms = new MemoryStream();
                        editprofilepb.Image.Save(ms, editprofilepb.Image.RawFormat);
                        byte[] imageData = ms.ToArray();
                        updateCommand.Parameters.AddWithValue("@profileImage", imageData);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@profileImage", DBNull.Value);
                    }

                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User profile updated successfully!");
                        this.Close();
                        Dashboard dc = new Dashboard(loggedInUsername);
                        dc.Show();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update user profile");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void changepasswordbtn_Click(object sender, EventArgs e)
        {
            {
                string oldPassword = oldpasswordtb.Text;
                string newPassword = newpasswordtb.Text;

                try
                {
                    if (string.IsNullOrWhiteSpace(oldPassword) || string.IsNullOrWhiteSpace(newPassword))
                    {
                        MessageBox.Show("Both fields must not be empty!");
                        return;
                    }

                    string mySqlConnection = "server=127.0.0.1; user=iam; database=sales_management; password=EL@oVJF]zQFk(6[E";

                    using (MySqlConnection MySqlConnection = new MySqlConnection(mySqlConnection))
                    {
                        MySqlConnection.Open();

                        MySqlCommand checkPasswordCommand = new MySqlCommand("select userpassword from users where username = @username", MySqlConnection);
                        checkPasswordCommand.Parameters.AddWithValue("@username", loggedInUsername);
                        string savedPassword = checkPasswordCommand.ExecuteScalar()?.ToString();

                        if (savedPassword != oldPassword)
                        {
                            MessageBox.Show("Old password is incorrect!");
                            return;
                        }

                        MySqlCommand updatePasswordCommand = new MySqlCommand("UPDATE users SET userpassword = @newPassword WHERE username = @username", MySqlConnection);
                        updatePasswordCommand.Parameters.AddWithValue("@newPassword", newPassword);
                        updatePasswordCommand.Parameters.AddWithValue("@username", loggedInUsername);
                        updatePasswordCommand.ExecuteNonQuery();

                        MessageBox.Show("Password changed successfully.");
                        oldpasswordtb.Text = " ";
                        newpasswordtb.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }

}

