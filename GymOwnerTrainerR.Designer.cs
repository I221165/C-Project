namespace WindowsFormsApp1
{
    partial class GymOwnerTrainerR
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
            this.comboBoxTrainerFilter = new System.Windows.Forms.ComboBox();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.dataGridViewTrainerReports = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainerReports)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTrainerFilter
            // 
            this.comboBoxTrainerFilter.FormattingEnabled = true;
            this.comboBoxTrainerFilter.Location = new System.Drawing.Point(12, 12);
            this.comboBoxTrainerFilter.Name = "comboBoxTrainerFilter";
            this.comboBoxTrainerFilter.Size = new System.Drawing.Size(250, 24);
            this.comboBoxTrainerFilter.TabIndex = 0;
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonGenerateReport.Location = new System.Drawing.Point(272, 12);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(100, 24);
            this.buttonGenerateReport.TabIndex = 1;
            this.buttonGenerateReport.Text = "Generate Report";
            this.buttonGenerateReport.UseVisualStyleBackColor = false;
            this.buttonGenerateReport.Click += new System.EventHandler(this.buttonGenerateReport_Click);
            // 
            // dataGridViewTrainerReports
            // 
            this.dataGridViewTrainerReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTrainerReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrainerReports.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewTrainerReports.Name = "dataGridViewTrainerReports";
            this.dataGridViewTrainerReports.RowHeadersWidth = 51;
            this.dataGridViewTrainerReports.Size = new System.Drawing.Size(729, 360);
            this.dataGridViewTrainerReports.TabIndex = 2;
            // 
            // GymOwnerTrainerR
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(764, 422);
            this.Controls.Add(this.comboBoxTrainerFilter);
            this.Controls.Add(this.buttonGenerateReport);
            this.Controls.Add(this.dataGridViewTrainerReports);
            this.Name = "GymOwnerTrainerR";
            this.Text = "Gym Owner - Trainer Reports";
            this.Load += new System.EventHandler(this.GymOwner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainerReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTrainerFilter;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.DataGridView dataGridViewTrainerReports;
    }
}