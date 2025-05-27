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
    public partial class GymOwnerMain : Form
    {
        public GymOwnerMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            GymMemberReportO form = new GymMemberReportO();
            form.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            GymOwnerTrainerR workout = new GymOwnerTrainerR();
            workout.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TrainerAddition tt = new TrainerAddition();
            tt.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GymOwnerCheck reportForm = new GymOwnerCheck();
            reportForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          //  GymOwnerCheck reportForm = new GymOwnerCheck();
          // reportForm.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
          //  FeedbackForm feedbackForm = new FeedbackForm();
          //  feedbackForm.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
