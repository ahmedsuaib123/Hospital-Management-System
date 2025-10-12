namespace Hospital_Management_System
{
    partial class NurseDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView NurseDataGridView;
        private System.Windows.Forms.Button PatientInfoBTN;
        private System.Windows.Forms.Button DutyScheduleBTN;
        private System.Windows.Forms.Button NurseDashboardExitBTN;
        private System.Windows.Forms.Button NurseProfileBTN;
        private System.Windows.Forms.TextBox PatientSearchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogOutBTN;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.NurseDataGridView = new System.Windows.Forms.DataGridView();
            this.PatientInfoBTN = new System.Windows.Forms.Button();
            this.DutyScheduleBTN = new System.Windows.Forms.Button();
            this.NurseDashboardExitBTN = new System.Windows.Forms.Button();
            this.NurseProfileBTN = new System.Windows.Forms.Button();
            this.PatientSearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LogOutBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NurseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NurseDataGridView
            // 
            this.NurseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NurseDataGridView.Location = new System.Drawing.Point(9, 79);
            this.NurseDataGridView.Name = "NurseDataGridView";
            this.NurseDataGridView.Size = new System.Drawing.Size(582, 212);
            this.NurseDataGridView.TabIndex = 7;
            // 
            // PatientInfoBTN
            // 
            this.PatientInfoBTN.Location = new System.Drawing.Point(347, 312);
            this.PatientInfoBTN.Name = "PatientInfoBTN";
            this.PatientInfoBTN.Size = new System.Drawing.Size(77, 34);
            this.PatientInfoBTN.TabIndex = 6;
            this.PatientInfoBTN.Text = "Patient Info";
            this.PatientInfoBTN.UseVisualStyleBackColor = true;
            this.PatientInfoBTN.Click += new System.EventHandler(this.PatientInfoBTN_Click);
            // 
            // DutyScheduleBTN
            // 
            this.DutyScheduleBTN.Location = new System.Drawing.Point(145, 312);
            this.DutyScheduleBTN.Name = "DutyScheduleBTN";
            this.DutyScheduleBTN.Size = new System.Drawing.Size(110, 34);
            this.DutyScheduleBTN.TabIndex = 5;
            this.DutyScheduleBTN.Text = "Duty Schedule";
            this.DutyScheduleBTN.UseVisualStyleBackColor = true;
            this.DutyScheduleBTN.Click += new System.EventHandler(this.DutyScheduleBTN_Click);
            // 
            // NurseDashboardExitBTN
            // 
            this.NurseDashboardExitBTN.Location = new System.Drawing.Point(9, 312);
            this.NurseDashboardExitBTN.Name = "NurseDashboardExitBTN";
            this.NurseDashboardExitBTN.Size = new System.Drawing.Size(77, 34);
            this.NurseDashboardExitBTN.TabIndex = 4;
            this.NurseDashboardExitBTN.Text = "Exit";
            this.NurseDashboardExitBTN.UseVisualStyleBackColor = true;
            this.NurseDashboardExitBTN.Click += new System.EventHandler(this.NurseDashboardExitBTN_Click);
            // 
            // NurseProfileBTN
            // 
            this.NurseProfileBTN.Location = new System.Drawing.Point(498, 35);
            this.NurseProfileBTN.Name = "NurseProfileBTN";
            this.NurseProfileBTN.Size = new System.Drawing.Size(81, 26);
            this.NurseProfileBTN.TabIndex = 3;
            this.NurseProfileBTN.Text = "My Profile";
            this.NurseProfileBTN.UseVisualStyleBackColor = true;
            this.NurseProfileBTN.Click += new System.EventHandler(this.NurseProfileBTN_Click);
            // 
            // PatientSearchTextBox
            // 
            this.PatientSearchTextBox.Location = new System.Drawing.Point(128, 41);
            this.PatientSearchTextBox.Name = "PatientSearchTextBox";
            this.PatientSearchTextBox.Size = new System.Drawing.Size(186, 20);
            this.PatientSearchTextBox.TabIndex = 2;
            this.PatientSearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PatientSearchTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Patient";
            // 
            // LogOutBTN
            // 
            this.LogOutBTN.Location = new System.Drawing.Point(520, 312);
            this.LogOutBTN.Name = "LogOutBTN";
            this.LogOutBTN.Size = new System.Drawing.Size(71, 34);
            this.LogOutBTN.TabIndex = 0;
            this.LogOutBTN.Text = "Log Out";
            this.LogOutBTN.UseVisualStyleBackColor = true;
            this.LogOutBTN.Click += new System.EventHandler(this.LogOutBTN_Click);
            // 
            // NurseDashboard
            // 
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.LogOutBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PatientSearchTextBox);
            this.Controls.Add(this.NurseProfileBTN);
            this.Controls.Add(this.NurseDashboardExitBTN);
            this.Controls.Add(this.DutyScheduleBTN);
            this.Controls.Add(this.PatientInfoBTN);
            this.Controls.Add(this.NurseDataGridView);
            this.Name = "NurseDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Management System";
            ((System.ComponentModel.ISupportInitialize)(this.NurseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
