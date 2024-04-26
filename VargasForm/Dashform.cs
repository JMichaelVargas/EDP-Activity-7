using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using VargasForm;

namespace VargasForm
{
    public partial class Dashform : UserControl
    {
        private DatabaseManager dbManager;
        private DataTable originalDataTable;
        private string selectedAccountID;

        public Dashform()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();

            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            textBox1.TextChanged += textBox1_TextChanged;

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                if (dbManager.OpenConnection())
                {
                    string selectQuery = "SELECT account_id, full_name, gender, contact_num, status FROM accounts";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, dbManager.connection))
                    {
                        originalDataTable = new DataTable();
                        adapter.Fill(originalDataTable);

                        // Bind the original DataTable to the DataGridView
                        dataGridView1.DataSource = originalDataTable;
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

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectedAccountID = dataGridView1.SelectedRows[0].Cells["account_id"].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Replace "DeleteButtonColumn" with the actual name of your delete button column
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["DeleteButtonColumn"].Index)
            {
                string accountIDToDelete = dataGridView1.Rows[e.RowIndex].Cells["account_id"].Value.ToString();

                // Assign the selected account ID to the class-level variable
                selectedAccountID = accountIDToDelete;

                if (MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteRecord(accountIDToDelete);
                    LoadData(); // Reload data after deletion
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Example of deleting a selected record (you can modify this based on your needs)
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string accountIDToDelete = dataGridView1.SelectedRows[0].Cells["account_id"].Value.ToString();

                // Assign the selected account ID to the class-level variable
                selectedAccountID = accountIDToDelete;

                if (MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteRecord(accountIDToDelete);
                    LoadData(); // Reload data after deletion
                }
            }
        }

        private void DeleteRecord(string accountID)
        {
            try
            {
                if (dbManager.OpenConnection())
                {
                    string deleteQuery = "DELETE FROM accounts WHERE account_id = @account_id";

                    using (MySqlCommand command = new MySqlCommand(deleteQuery, dbManager.connection))
                    {
                        command.Parameters.AddWithValue("@account_id", accountID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void active_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedAccountID))
            {
                UpdateStatus(selectedAccountID, "Active");
                LoadData(); // Reload data after status update
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inactive_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedAccountID))
            {
                UpdateStatus(selectedAccountID, "Inactive");
                LoadData(); // Reload data after status update
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateStatus(string accountID, string newStatus)
        {
            try
            {
                if (dbManager.OpenConnection())
                {
                    string updateQuery = "UPDATE accounts SET status = @status WHERE account_id = @account_id";

                    using (MySqlCommand command = new MySqlCommand(updateQuery, dbManager.connection))
                    {
                        command.Parameters.AddWithValue("@status", newStatus);
                        command.Parameters.AddWithValue("@account_id", accountID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to update status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Filter the data based on the entered full name
            FilterData(textBox1.Text.Trim());
        }

        private void FilterData(string filterText)
        {
            try
            {
                // Create a DataView based on the original DataTable
                DataView dataView = originalDataTable.DefaultView;

                // Apply a RowFilter to dynamically filter the data
                dataView.RowFilter = $"full_name LIKE '%{filterText}%'";

                // Assign the DataView to the DataGridView
                dataGridView1.DataSource = dataView.ToTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while filtering data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
