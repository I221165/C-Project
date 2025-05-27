namespace WindowsFormApp1
{
    partial class TrainerAddition
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxExperience = new System.Windows.Forms.TextBox();
            this.comboBoxSpecialty = new System.Windows.Forms.ComboBox();
            this.textBoxQualifications = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.buttonAddTrainer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(51, 28);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(200, 22);
            this.textBoxFirstName.TabIndex = 0;
            this.textBoxFirstName.Text = "First Name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(51, 70);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(200, 22);
            this.textBoxLastName.TabIndex = 1;
            this.textBoxLastName.Text = "Last Name";
            // 
            // textBoxExperience
            // 
            this.textBoxExperience.Location = new System.Drawing.Point(51, 114);
            this.textBoxExperience.Name = "textBoxExperience";
            this.textBoxExperience.Size = new System.Drawing.Size(200, 22);
            this.textBoxExperience.TabIndex = 2;
            this.textBoxExperience.Text = "Experience (Years)";
            // 
            // comboBoxSpecialty
            // 
            this.comboBoxSpecialty.FormattingEnabled = true;
            this.comboBoxSpecialty.Items.AddRange(new object[] {
            "Cardio",
            "Strength Training",
            "Yoga",
            "Pilates",
            "CrossFit",
            "Dance",
            "Martial Arts"});
            this.comboBoxSpecialty.Location = new System.Drawing.Point(51, 159);
            this.comboBoxSpecialty.Name = "comboBoxSpecialty";
            this.comboBoxSpecialty.Size = new System.Drawing.Size(200, 24);
            this.comboBoxSpecialty.TabIndex = 3;
            // 
            // textBoxQualifications
            // 
            this.textBoxQualifications.Location = new System.Drawing.Point(51, 211);
            this.textBoxQualifications.Name = "textBoxQualifications";
            this.textBoxQualifications.Size = new System.Drawing.Size(200, 22);
            this.textBoxQualifications.TabIndex = 4;
            this.textBoxQualifications.Text = "Qualifications";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(51, 259);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(200, 22);
            this.textBoxEmail.TabIndex = 5;
            this.textBoxEmail.Text = "Email";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(51, 310);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(200, 22);
            this.textBoxPhone.TabIndex = 6;
            this.textBoxPhone.Text = "Phone Number";
            // 
            // buttonAddTrainer
            // 
            this.buttonAddTrainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonAddTrainer.Location = new System.Drawing.Point(12, 386);
            this.buttonAddTrainer.Name = "buttonAddTrainer";
            this.buttonAddTrainer.Size = new System.Drawing.Size(100, 24);
            this.buttonAddTrainer.TabIndex = 7;
            this.buttonAddTrainer.Text = "Add Trainer";
            this.buttonAddTrainer.UseVisualStyleBackColor = false;
            this.buttonAddTrainer.Click += new System.EventHandler(this.buttonAddTrainer_Click);
            // 
            // TrainerAddition
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(764, 422);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxExperience);
            this.Controls.Add(this.comboBoxSpecialty);
            this.Controls.Add(this.textBoxQualifications);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.buttonAddTrainer);
            this.Name = "TrainerAddition";
            this.Text = "Add Trainer";
            this.Load += new System.EventHandler(this.TrainerAddition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxExperience;
        private System.Windows.Forms.ComboBox comboBoxSpecialty;
        private System.Windows.Forms.TextBox textBoxQualifications;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Button buttonAddTrainer;
    }
}