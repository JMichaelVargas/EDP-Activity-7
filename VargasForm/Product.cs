using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace VargasForm
{
    public partial class Product : UserControl
    {
        private DatabaseManager dbManager;
        public Product()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text)
                || string.IsNullOrWhiteSpace(price.Text)
                || string.IsNullOrWhiteSpace(description.Text)
                || string.IsNullOrWhiteSpace(category.Text))
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (dbManager.OpenConnection())
                    {
                        string insertQuery = "INSERT INTO product (Name, Price, Description, Category) " +
                                             "VALUES (@name, @price, @description, @category)";

                        using (MySqlCommand command = new MySqlCommand(insertQuery, dbManager.connection))
                        {
                            command.Parameters.AddWithValue("@name", name.Text);
                            command.Parameters.AddWithValue("@price", price.Text);
                            command.Parameters.AddWithValue("@description", description.Text);
                            command.Parameters.AddWithValue("@category", category.SelectedItem.ToString());
                             // Use the value fetched from admin database

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
            name.Text = string.Empty;
            price.Text = string.Empty;
            description.Text = string.Empty;
            category.Text = string.Empty;
        }
    }
}
