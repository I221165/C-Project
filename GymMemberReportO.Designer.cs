namespace WindowsFormApp1
{
    partial class GymMemberReportO
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
            this.comboBoxReportType = new System.Windows.Forms.ComboBox();
            this.buttonLoadReport = new System.Windows.Forms.Button();
            this.dataGridViewReports = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxReportType
            // 
            this.comboBoxReportType.FormattingEnabled = true;
            this.comboBoxReportType.Location = new System.Drawing.Point(12, 12);
            this.comboBoxReportType.Name = "comboBoxReportType";
            this.comboBoxReportType.Size = new System.Drawing.Size(200, 24);
            this.comboBoxReportType.TabIndex = 0;
            // 
            // buttonLoadReport
            // 
            this.buttonLoadReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonLoadReport.Location = new System.Drawing.Point(220, 12);
            this.buttonLoadReport.Name = "buttonLoadReport";
            this.buttonLoadReport.Size = new System.Drawing.Size(100, 24);
            this.buttonLoadReport.TabIndex = 1;
            this.buttonLoadReport.Text = "Load Report";
            this.buttonLoadReport.UseVisualStyleBackColor = false;
            this.buttonLoadReport.Click += new System.EventHandler(this.buttonLoadReport_Click);
            // 
            // dataGridViewReports
            // 
            this.dataGridViewReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReports.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridViewReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReports.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewReports.Name = "dataGridViewReports";
            this.dataGridViewReports.RowHeadersWidth = 51;
            this.dataGridViewReports.Size = new System.Drawing.Size(600, 300);
            this.dataGridViewReports.TabIndex = 2;
            // 
            // GymMemberReportO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(764, 422);
            this.Controls.Add(this.comboBoxReportType);
            this.Controls.Add(this.buttonLoadReport);
            this.Controls.Add(this.dataGridViewReports);
            this.Name = "GymMemberReportO";
            this.Text = "Gym Owner Interface";
            this.Load += new System.EventHandler(this.GymOwner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxReportType;
        private System.Windows.Forms.Button buttonLoadReport;
        private System.Windows.Forms.DataGridView dataGridViewReports;
    }
}
