namespace Hospital_Management_System
{
    partial class MedicalRecords
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SearchComboBox = new System.Windows.Forms.ComboBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.MedicalRecordsDataGridView = new System.Windows.Forms.DataGridView();
            this.TitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MedicalRecordsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchComboBox
            // 
            this.SearchComboBox.FormattingEnabled = true;
            this.SearchComboBox.Items.AddRange(new object[] {
            "AppointmentID",
            "PatientName",
            "DoctorName"});
            this.SearchComboBox.Location = new System.Drawing.Point(165, 46);
            this.SearchComboBox.Name = "SearchComboBox";
            this.SearchComboBox.Size = new System.Drawing.Size(88, 21);
            this.SearchComboBox.TabIndex = 70;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(79, 73);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(174, 20);
            this.SearchTextBox.TabIndex = 69;
            this.SearchTextBox.Visible = false;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.SearchLabel.Location = new System.Drawing.Point(75, 46);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(84, 20);
            this.SearchLabel.TabIndex = 68;
            this.SearchLabel.Text = "Search By";
            // 
            // BackButton
            // 
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.BackButton.Location = new System.Drawing.Point(79, 405);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(87, 33);
            this.BackButton.TabIndex = 67;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // MedicalRecordsDataGridView
            // 
            this.MedicalRecordsDataGridView.AllowUserToAddRows = false;
            this.MedicalRecordsDataGridView.AllowUserToDeleteRows = false;
            this.MedicalRecordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicalRecordsDataGridView.Location = new System.Drawing.Point(79, 118);
            this.MedicalRecordsDataGridView.Name = "MedicalRecordsDataGridView";
            this.MedicalRecordsDataGridView.ReadOnly = true;
            this.MedicalRecordsDataGridView.Size = new System.Drawing.Size(664, 258);
            this.MedicalRecordsDataGridView.TabIndex = 63;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(343, 21);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(151, 23);
            this.TitleLabel.TabIndex = 62;
            this.TitleLabel.Text = "Medical Records";
            // 
            // MedicalRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchComboBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.MedicalRecordsDataGridView);
            this.Controls.Add(this.TitleLabel);
            this.Name = "MedicalRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Management System";
            this.Load += new System.EventHandler(this.MedicalRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MedicalRecordsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SearchComboBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DataGridView MedicalRecordsDataGridView;
        private System.Windows.Forms.Label TitleLabel;
    }
}