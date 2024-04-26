using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace VargasForm
{
    public partial class ForgotPass : Form
    {
        public string Username { get; set; }
        private DatabaseManager dbManager;

        public ForgotPass()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
        }

        // Additional constructor that takes a username parameter
        public ForgotPass(string username) : this()
        {
            Username = username;
            // You can perform additional initialization based on the username if needed
        }

        private void ForgotPass_Load(object sender, EventArgs e)
        {
            // You can perform any additional setup or loading logic here
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newPassword = newPasswordTextBox.Text;
            string confirmNewPassword = confirmNewPasswordTextBox.Text;

            if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmNewPassword))
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the new password and confirm password match
            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("New password and confirm password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update the password in the database
            if (UpdatePassword(Username, newPassword, confirmNewPassword))
            {
                MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to change password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Update password in the database
        private bool UpdatePassword(string username, string newPassword, string confirmNewPassword)
        {
            try
            {
                if (dbManager.OpenConnection())
                {
                    using (MySqlCommand command = dbManager.connection.CreateCommand())
                    {
                        // Hash the new password before storing it in the database
                        HashAlgorithm algorithm = SHA256.Create();
                        byte[] inputBytes = Encoding.UTF8.GetBytes(newPassword);
                        byte[] hashBytes = algorithm.ComputeHash(inputBytes);
                        string hashedPassword = BitConverter.ToString(hashBytes).Replace("-", "");

                        // Update the password in the database for the existing username
                        command.CommandText = "UPDATE admin SET password = @newPassword, confirmpass = @confirmNewPassword WHERE email = @username";
                        command.Parameters.Add(new MySqlParameter("@newPassword", MySqlDbType.VarChar) { Value = hashedPassword });
                        command.Parameters.Add(new MySqlParameter("@confirmNewPassword", MySqlDbType.VarChar) { Value = hashedPassword });
                        command.Parameters.Add(new MySqlParameter("@username", MySqlDbType.VarChar) { Value = username });

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
                else
                {
                    MessageBox.Show("Failed to open database connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                newPasswordTextBox.UseSystemPasswordChar = false;
                confirmNewPasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                newPasswordTextBox.UseSystemPasswordChar = true;
                confirmNewPasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void newPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            // Handle any additional logic related to the new password textbox
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var loginForm = new Login();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
