using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VargasForm
{
    public partial class Form1 : Form
    {
        private DatabaseManager dbManager;

        public Form1()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Your initialization logic here
        }

        private void recoveraccount_Click(object sender, EventArgs e)
        {
            // Assuming you have a TextBox for username input in Form4
            string enteredUsername = username.Text;

            if (string.IsNullOrWhiteSpace(enteredUsername))
            {
                MessageBox.Show("Please enter a username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the username exists in the database
            bool usernameExists = CheckUsernameExists(enteredUsername);

            if (usernameExists)
            {
                // Open the ForgotPass class with the entered username
                ForgotPass forgotPassForm = new ForgotPass(enteredUsername);
                forgotPassForm.Show();

                // Optionally, close the current form
                this.Close();
            }
            else
            {
                MessageBox.Show("Username not found. Please check your username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Replace this with your actual database check for username existence
        private bool CheckUsernameExists(string username)
        {
            try
            {
                if (dbManager.OpenConnection())
                {
                    // Your actual database query to check if the username exists
                    string query = "SELECT COUNT(*) FROM admin WHERE email = @username";

                    using (MySqlCommand command = new MySqlCommand(query, dbManager.connection))
                    {
                        command.Parameters.Add(new MySqlParameter("@username", MySqlDbType.VarChar) { Value = username });

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        return count > 0;
                    }
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
            return false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
