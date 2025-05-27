using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GymOwnerTrainerR : Form
    {
        private string connectionString = "Your_Connection_String_Here";

        public GymOwnerTrainerR()
        {
            InitializeComponent();
        }

        private void GymOwner_Load(object sender, EventArgs e)
        {
            // Load combo box with filter options for trainer reports
            comboBoxTrainerFilter.Items.Add("All Trainers");
            comboBoxTrainerFilter.Items.Add("Experience: 1-3 Years");
            comboBoxTrainerFilter.Items.Add("Experience: 3-5 Years");
            comboBoxTrainerFilter.Items.Add("Experience: 5+ Years");
            comboBoxTrainerFilter.Items.Add("Rating: 4+ Stars");

            comboBoxTrainerFilter.SelectedIndex = 0; // Default selection
        }

        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            // Get the selected filter
            string selectedFilter = comboBoxTrainerFilter.SelectedItem.ToString();

            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query;

                switch (selectedFilter)
                {
                    case "All Trainers":
                        query = "SELECT * FROM Trainers"; // Fetch all trainers
                        break;
                    case "Experience: 1-3 Years":
                        query = "SELECT * FROM Trainers WHERE Experience >= 1 AND Experience <= 3";
                        break;
                    case "Experience: 3-5 Years":
                        query = "SELECT * FROM Trainers WHERE Experience >= 3 AND Experience <= 5";
                        break;
                    case "Experience: 5+ Years":
                        query = "SELECT * FROM Trainers WHERE Experience > 5";
                        break;
                    case "Rating: 4+ Stars":
                        query = "SELECT * FROM Trainers WHERE Rating >= 4"; // Fetch trainers with high rating
                        break;
                    default:
                        MessageBox.Show("Invalid filter selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(dataTable);
                }
            }

            // Display the data in the DataGridView
            dataGridViewTrainerReports.DataSource = dataTable;
        }
    }
}
