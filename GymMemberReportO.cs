using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class GymMemberReportO : Form
    {
        // Connection string for your database
        private string connectionString = "Your_Connection_String_Here";

        public GymMemberReportO()
        {
            InitializeComponent(); // Initialize the form
        }

        private void GymOwner_Load(object sender, EventArgs e)
        {
            // Load the combo box with report options (e.g., by membership type)
            comboBoxReportType.Items.Add("All Members");
            comboBoxReportType.Items.Add("Active Memberships");
            comboBoxReportType.Items.Add("Expired Memberships");

            // Set default selection
            comboBoxReportType.SelectedIndex = 0;
        }

        private void buttonLoadReport_Click(object sender, EventArgs e)
        {
            // Load the report based on selected combo box item
            string reportType = comboBoxReportType.SelectedItem.ToString();

            DataTable dataTable = new DataTable();

//            using (SqlConnection conn = new SqlConnection(connectionString))
            {
  //              conn.Open();

                string query;

                // Example: Different query depending on report type
                if (reportType == "All Members")
                {
                    query = "SELECT * FROM GymMembers"; // Fetch all gym members
                }
                else if (reportType == "Active Memberships")
                {
                    query = "SELECT * FROM GymMembers WHERE MembershipStatus = 'Active'";
                }
                else if (reportType == "Expired Memberships")
                {
                    query = "SELECT * FROM GymMembers WHERE MembershipStatus = 'Expired'";
                }
                else
                {
                    MessageBox.Show("Invalid report type selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Fetch data and load into dataTable
    //            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
      //              adapter.Fill(dataTable);
                }
            }

            // Display data in the DataGridView
            dataGridViewReports.DataSource = dataTable;
        }
    }
}

