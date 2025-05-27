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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=PSL-ADM-LT-002\\SQLEXPRESS;Initial Catalog=\"Facebook Db\";Integrated Security=True");
            conn.Open();
            //  SqlCommand cm;
            string fn = textBox1.Text;
            string pass = textBox2.Text;


            // string query = "Select * FROM Facebook_Userss  where email = '" + fn + "' and pass = '" + pass + "'";
            // cm = new SqlCommand(query, conn);
            // SqlDataReader rsr = cm.ExecuteReader();
            // if (!rsr.HasRows)
            // {
            //    MessageBox.Show("Logged In UnSccessfully!");
            //}
            //else
            //{
            //   MessageBox.Show("Logged In Successfully!");
            //}
            //cm.Dispose();


            if (!string.IsNullOrWhiteSpace(textBox1.Text) &&
            !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = ""; // Clear the text box
                textBox2.Text = ""; // Clear the text box
                GymOwnerMain gymOwnerMain = new GymOwnerMain(); 
                gymOwnerMain.Show();

            }
            else
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp form = new SignUp();
            form.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
