using MySql.Data.MySqlClient;
using System;
using System.Text;
using System.Security.Cryptography;
using VargasForm;

namespace VargasForm
{
    public partial class Signup : Form
    {
        private DatabaseManager dbManager;
        public Signup()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var loginForm = new Login();
            loginForm.ShowDialog();
            this.Close();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string pw = password.Text;
            string cp = confirmpassword.Text;
            string email = username.Text;

            if (pw != cp)
            {
                MessageBox.Show("Password does not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(username.Text) || string.IsNullOrWhiteSpace(password.Text) || string.IsNullOrWhiteSpace(confirmpassword.Text))
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the event handler to prevent further execution
            }

            try
            {
                // Open the database connection
                {
                    if (dbManager.OpenConnection())
                    {
                        MySqlCommand command = dbManager.connection.CreateCommand();
                        HashAlgorithm algorithm = SHA256.Create();
                        byte[] inputBytes = Encoding.UTF8.GetBytes(pw);
                        byte[] hashBytes = algorithm.ComputeHash(inputBytes);
                        string hashString = BitConverter.ToString(hashBytes).Replace("-", "");

                        command.CommandText = "INSERT INTO admin (email, password, confirmpass) VALUES (@email, @password, @confirmpass)";
                        command.Parameters.AddWithValue("@email", username.Text);
                        command.Parameters.AddWithValue("@password", hashString);
                        command.Parameters.AddWithValue("@confirmpass", hashString);
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Failed to open database connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                MessageBox.Show("Registered Successfully");

                var button1 = new Login();
                button1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password.UseSystemPasswordChar = false;
                confirmpassword.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
                confirmpassword.UseSystemPasswordChar = true;
            }
        }
    }
}
