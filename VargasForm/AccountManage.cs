using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using VargasForm;

namespace VargasForm
{
    public partial class AccountManage : UserControl
    {
        String loggedEmail = Login.login_email;
        private DatabaseManager dbManager;

        public AccountManage()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
            DisplayAdminUsername(); // Call this method to display admin username
            //LoadData();
        }

        private void DisplayAdminUsername()
        {
            email.Text = loggedEmail;
            try
            {
                if (dbManager.OpenConnection())
                {
                    string adminUsernameQuery = "SELECT email FROM admin WHERE email = @email";

                    using (MySqlCommand command = new MySqlCommand(adminUsernameQuery, dbManager.connection))
                    {
                        command.Parameters.AddWithValue("@email", loggedEmail);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                email.Text = reader["email"].ToString();
                                email.Enabled = false; // Disable the textbox so the user can't change it
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(accountID.Text)
                || string.IsNullOrWhiteSpace(name.Text)
                || string.IsNullOrWhiteSpace(phonenumber.Text)
                || string.IsNullOrWhiteSpace(sex.Text))
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (dbManager.OpenConnection())
                    {
                        string insertQuery = "INSERT INTO accounts (account_id, full_name, gender, contact_num, email) " +
                                             "VALUES (@account_id, @full_name, @gender, @contact_num, @email)";

                        using (MySqlCommand command = new MySqlCommand(insertQuery, dbManager.connection))
                        {
                            command.Parameters.AddWithValue("@account_id", accountID.Text);
                            command.Parameters.AddWithValue("@full_name", name.Text);
                            command.Parameters.AddWithValue("@gender", sex.SelectedItem.ToString());
                            command.Parameters.AddWithValue("@contact_num", phonenumber.Text);
                            command.Parameters.AddWithValue("@email", email.Text); // Use the value fetched from admin database

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Optionally, clear the textboxes or perform any other post-save actions
                                ClearTextBoxes();
                            }
                            else
                            {
                                MessageBox.Show("Failed to save record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dbManager.CloseConnection();
                }
            }
            //LoadData();
        }

        private void ClearTextBoxes()
        {
            // Add all your TextBoxes to this method
            accountID.Text = string.Empty;
            name.Text = string.Empty;
            phonenumber.Text = string.Empty;
            sex.Text = string.Empty;
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
