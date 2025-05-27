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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           // private string connectionString = "Your_Connection_String_Here";

        // Collect information from text boxes
      //  string name = textBox1.Text;
            string email = textBox2.Text;
            string entityLeft = textBox3.Text; // Changed from 'bio' to 'entityLeft'
            string phoneNo = textBox4.Text;

            // Ensure all required information is provided
            if (
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(entityLeft) ||
                string.IsNullOrWhiteSpace(phoneNo))
            {
                MessageBox.Show("Please fill in all the details before proceeding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Send request to the admin via database (example)
           // using (SqlConnection conn = new SqlConnection(connectionString))
            {
               // conn.Open();

                // Assuming you have a 'Requests' table with fields for the request data
                string query = "INSERT INTO Requests (Name, Email, EntityLeft, PhoneNo, Status) VALUES (@Name, @Email, @EntityLeft, @PhoneNo, @Status)";
               // using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                   // cmd.Parameters.AddWithValue("@Name", name);
                   // cmd.Parameters.AddWithValue("@Email", email);
                   // cmd.Parameters.AddWithValue("@EntityLeft", entityLeft);
                   // cmd.Parameters.AddWithValue("@PhoneNo", phoneNo);
                   // cmd.Parameters.AddWithValue("@Status", "Pending"); // Set request status to "Pending"

                   // cmd.ExecuteNonQuery(); // Execute the query to insert the request into the database
                }

                // Notify the admin (if needed, you could use email or another form of notification)
            }

            // Notify the user that a request has been sent
            MessageBox.Show("Request sent to the admin.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
