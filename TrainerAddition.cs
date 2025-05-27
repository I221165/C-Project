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
   
        public partial class TrainerAddition : Form
        {
            // Connection string for your database
            private string connectionString = "Your_Connection_String_Here";

            public TrainerAddition()
            {
                InitializeComponent();
            }

            private void TrainerAddition_Load(object sender, EventArgs e)
            {
                // Initialize any required elements here
            }

            private void buttonAddTrainer_Click(object sender, EventArgs e)
            {
                // Collect information from the form fields
                string firstName = textBoxFirstName.Text;
                string lastName = textBoxLastName.Text;
                int experience = int.Parse(textBoxExperience.Text);
                string specialty = comboBoxSpecialty.SelectedItem.ToString();
                string qualifications = textBoxQualifications.Text;
                string email = textBoxEmail.Text;
                string phone = textBoxPhone.Text;

                // Validate input to ensure required fields are not empty
                if (string.IsNullOrWhiteSpace(firstName) ||
                    string.IsNullOrWhiteSpace(lastName) ||
                    string.IsNullOrWhiteSpace(specialty) ||
                    string.IsNullOrWhiteSpace(email) ||
                    string.IsNullOrWhiteSpace(phone))
                {
                    MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Add the new trainer to the database
              //  using (SqlConnection conn = new SqlConnection(connectionString))
                {
               //     conn.Open();

                    // Insert the new trainer into the database
                    string query = "INSERT INTO Trainers (FirstName, LastName, Experience, Specialty, Qualifications, Email, Phone) VALUES (@FirstName, @LastName, @Experience, @Specialty, @Qualifications, @Email, @Phone)";
                //    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                  //      cmd.Parameters.AddWithValue("@FirstName", firstName);
                   //     cmd.Parameters.AddWithValue("@LastName", lastName);
                   //     cmd.Parameters.AddWithValue("@Experience", experience);
                   //     cmd.Parameters.AddWithValue("@Specialty", specialty);
                   //     cmd.Parameters.AddWithValue("@Qualifications", qualifications);
                   //     cmd.Parameters.AddWithValue("@Email", email);
                   //     cmd.Parameters.AddWithValue("@Phone", phone);

              //          cmd.ExecuteNonQuery(); // Execute the insertion
                    }
                }

                // Confirm that the trainer was added
                MessageBox.Show("Trainer successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    

}
