using System;
using System.Data;
using System.Data.SqlClient; // For interacting with a SQL database
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
        public partial class GymOwnerCheck : Form
        {
            private string connectionString = "Your_Connection_String_Here"; // Connection string to your database

            public GymOwnerCheck()
            {
                InitializeComponent(); // Initialize the form components
            }

            private void AccountManagement_Load(object sender, EventArgs e)
            {
                // Load accounts to be displayed in the data grid
                LoadAccounts();
            }

            private void LoadAccounts()
            {
                DataTable accountsTable = new DataTable();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Query to fetch members and trainers
                    string query = "SELECT 'Member' AS AccountType, Member_ID AS AccountID, MemberName AS AccountName FROM Members " +
                                   "UNION " +
                                   "SELECT 'Trainer', Trainer_ID, TrainerName FROM Trainers";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        adapter.Fill(accountsTable); // Fill the data table with the fetched records
                    }
                }

                // Display accounts in the data grid
                dataGridViewAccounts.DataSource = accountsTable;
            }

            private void buttonDelete_Click(object sender, EventArgs e)
            {
                // Get the selected row in the data grid
                if (dataGridViewAccounts.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select an account to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Get the account type and ID from the selected row
                DataGridViewRow selectedRow = dataGridViewAccounts.SelectedRows[0];
                string accountType = selectedRow.Cells["AccountType"].Value.ToString();
                int accountID = Convert.ToInt32(selectedRow.Cells["AccountID"].Value);

                // Confirm the deletion
                DialogResult result = MessageBox.Show($"Are you sure you want to delete this {accountType}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return; // If the user chooses "No," cancel the deletion
                }

                // Delete the selected account based on account type
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string deleteQuery;
                    if (accountType == "Member")
                    {
                        deleteQuery = "DELETE FROM Members WHERE Member_ID = @AccountID";
                    }
                    else if (accountType == "Trainer")
                    {
                        deleteQuery = "DELETE FROM Trainers WHERE Trainer_ID = @AccountID";
                    }
                    else
                    {
                        MessageBox.Show("Invalid account type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@AccountID", accountID); // Add the account ID parameter
                        cmd.ExecuteNonQuery(); // Execute the delete command
                    }
                }

                // Reload the accounts to reflect the deletion
                LoadAccounts();

                // Show a success message
                MessageBox.Show("Account deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

