using MySql.Data.MySqlClient;
using System;
using System.Text;
using System.Security.Cryptography;
using VargasForm;

namespace VargasForm
{
    public partial class Login : Form
    {
        public static string login_email;
        private DatabaseManager dbManager;

        public Login()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var signUpForm = new Signup();
            signUpForm.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = username.Text;
            login_email = username.Text;

            if (string.IsNullOrWhiteSpace(username.Text) || string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Open the database connection
                if (dbManager.OpenConnection())
                {
                    MySqlCommand command = dbManager.connection.CreateCommand();

                    // Perform user authentication
                    command.CommandText = "SELECT password FROM admin WHERE email = @username";
                    command.Parameters.AddWithValue("@username", email);

                    // Retrieve the hashed password from the database
                    string storedPasswordHash = command.ExecuteScalar()?.ToString();

                    if (storedPasswordHash != null)
                    {
                        // Hash the entered password for comparison
                        HashAlgorithm algorithm = SHA256.Create();
                        byte[] inputBytes = Encoding.UTF8.GetBytes(password.Text);
                        byte[] hashBytes = algorithm.ComputeHash(inputBytes);
                        string enteredPasswordHash = BitConverter.ToString(hashBytes).Replace("-", "");

                        if (enteredPasswordHash == storedPasswordHash)
                        {
                            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Open the DashboardForm upon successful login
                            var dashboard = new Dashboard();
                            dashboard.ShowDialog();

                            // Close the current login form or do other necessary actions
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to open database connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the database connection
                dbManager.CloseConnection();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var forgotpass = new Form1();
            forgotpass.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
