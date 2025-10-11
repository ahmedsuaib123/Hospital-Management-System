namespace Hospital_Management
{
    partial class AddAppointments
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.BookButton = new System.Windows.Forms.Button();
            this.AppointmentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AvailableSlotComboBox = new System.Windows.Forms.ComboBox();
            this.DiagnosisTextBox = new System.Windows.Forms.TextBox();
            this.DepartmentTextBox = new System.Windows.Forms.TextBox();
            this.DocNameTextBox = new System.Windows.Forms.TextBox();
            this.AppointmentDateLabel = new System.Windows.Forms.Label();
            this.DiagnosisLabel = new System.Windows.Forms.Label();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.AvailableSlotLlabel = new System.Windows.Forms.Label();
            this.DoctorNameLabel = new System.Windows.Forms.Label();
            this.DoctorIDLabel = new System.Windows.Forms.Label();
            this.DoctorIDComboBox = new System.Windows.Forms.ComboBox();
            this.PatientIDLabel = new System.Windows.Forms.Label();
            this.PatientIDComboBox = new System.Windows.Forms.ComboBox();
            this.PatientNameLabel = new System.Windows.Forms.Label();
            this.PatientNameTextBox = new System.Windows.Forms.TextBox();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.ContactTextBox = new System.Windows.Forms.TextBox();
            this.DoctorListLabel = new System.Windows.Forms.Label();
            this.DoctorListDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.Location = new System.Drawing.Point(115, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(172, 24);
            this.TitleLabel.TabIndex = 82;
            this.TitleLabel.Text = "Add Appointment";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.BackButton.Location = new System.Drawing.Point(8, 450);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(62, 36);
            this.BackButton.TabIndex = 96;
            this.BackButton.Text = "Cancel";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BookButton
            // 
            this.BookButton.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.BookButton.Location = new System.Drawing.Point(272, 450);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(82, 36);
            this.BookButton.TabIndex = 95;
            this.BookButton.Text = "Book Now";
            this.BookButton.UseVisualStyleBackColor = true;
            this.BookButton.Click += new System.EventHandler(this.BookButton_Click);
            // 
            // AppointmentDatePicker
            // 
            this.AppointmentDatePicker.Location = new System.Drawing.Point(167, 401);
            this.AppointmentDatePicker.Name = "AppointmentDatePicker";
            this.AppointmentDatePicker.Size = new System.Drawing.Size(187, 20);
            this.AppointmentDatePicker.TabIndex = 94;
            // 
            // AvailableSlotComboBox
            // 
            this.AvailableSlotComboBox.FormattingEnabled = true;
            this.AvailableSlotComboBox.Location = new System.Drawing.Point(167, 305);
            this.AvailableSlotComboBox.Name = "AvailableSlotComboBox";
            this.AvailableSlotComboBox.Size = new System.Drawing.Size(108, 21);
            this.AvailableSlotComboBox.TabIndex = 93;
            // 
            // DiagnosisTextBox
            // 
            this.DiagnosisTextBox.Location = new System.Drawing.Point(167, 353);
            this.DiagnosisTextBox.Name = "DiagnosisTextBox";
            this.DiagnosisTextBox.Size = new System.Drawing.Size(87, 20);
            this.DiagnosisTextBox.TabIndex = 92;
            // 
            // DepartmentTextBox
            // 
            this.DepartmentTextBox.Location = new System.Drawing.Point(167, 256);
            this.DepartmentTextBox.Name = "DepartmentTextBox";
            this.DepartmentTextBox.ReadOnly = true;
            this.DepartmentTextBox.Size = new System.Drawing.Size(87, 20);
            this.DepartmentTextBox.TabIndex = 91;
            // 
            // DocNameTextBox
            // 
            this.DocNameTextBox.Location = new System.Drawing.Point(167, 208);
            this.DocNameTextBox.Name = "DocNameTextBox";
            this.DocNameTextBox.ReadOnly = true;
            this.DocNameTextBox.Size = new System.Drawing.Size(87, 20);
            this.DocNameTextBox.TabIndex = 90;
            this.DocNameTextBox.TextChanged += new System.EventHandler(this.DocNameTextBox_TextChanged);
            // 
            // AppointmentDateLabel
            // 
            this.AppointmentDateLabel.AutoSize = true;
            this.AppointmentDateLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.AppointmentDateLabel.Location = new System.Drawing.Point(33, 404);
            this.AppointmentDateLabel.Name = "AppointmentDateLabel";
            this.AppointmentDateLabel.Size = new System.Drawing.Size(120, 16);
            this.AppointmentDateLabel.TabIndex = 89;
            this.AppointmentDateLabel.Text = "Appointment Date : ";
            // 
            // DiagnosisLabel
            // 
            this.DiagnosisLabel.AutoSize = true;
            this.DiagnosisLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.DiagnosisLabel.Location = new System.Drawing.Point(33, 353);
            this.DiagnosisLabel.Name = "DiagnosisLabel";
            this.DiagnosisLabel.Size = new System.Drawing.Size(73, 16);
            this.DiagnosisLabel.TabIndex = 88;
            this.DiagnosisLabel.Text = "Diagnosis : ";
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.AutoSize = true;
            this.DepartmentLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.DepartmentLabel.Location = new System.Drawing.Point(33, 256);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(84, 16);
            this.DepartmentLabel.TabIndex = 87;
            this.DepartmentLabel.Text = "Department : ";
            // 
            // AvailableSlotLlabel
            // 
            this.AvailableSlotLlabel.AutoSize = true;
            this.AvailableSlotLlabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.AvailableSlotLlabel.Location = new System.Drawing.Point(33, 305);
            this.AvailableSlotLlabel.Name = "AvailableSlotLlabel";
            this.AvailableSlotLlabel.Size = new System.Drawing.Size(93, 16);
            this.AvailableSlotLlabel.TabIndex = 86;
            this.AvailableSlotLlabel.Text = "Available Slot : ";
            // 
            // DoctorNameLabel
            // 
            this.DoctorNameLabel.AutoSize = true;
            this.DoctorNameLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.DoctorNameLabel.Location = new System.Drawing.Point(33, 205);
            this.DoctorNameLabel.Name = "DoctorNameLabel";
            this.DoctorNameLabel.Size = new System.Drawing.Size(95, 16);
            this.DoctorNameLabel.TabIndex = 85;
            this.DoctorNameLabel.Text = "Doctor Name : ";
            // 
            // DoctorIDLabel
            // 
            this.DoctorIDLabel.AutoSize = true;
            this.DoctorIDLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.DoctorIDLabel.Location = new System.Drawing.Point(34, 168);
            this.DoctorIDLabel.Name = "DoctorIDLabel";
            this.DoctorIDLabel.Size = new System.Drawing.Size(77, 16);
            this.DoctorIDLabel.TabIndex = 84;
            this.DoctorIDLabel.Text = "Doctor ID : ";
            // 
            // DoctorIDComboBox
            // 
            this.DoctorIDComboBox.FormattingEnabled = true;
            this.DoctorIDComboBox.Location = new System.Drawing.Point(167, 168);
            this.DoctorIDComboBox.Name = "DoctorIDComboBox";
            this.DoctorIDComboBox.Size = new System.Drawing.Size(108, 21);
            this.DoctorIDComboBox.TabIndex = 83;
            this.DoctorIDComboBox.SelectedIndexChanged += new System.EventHandler(this.DoctorIDComboBox_SelectedIndexChanged_1);
            // 
            // PatientIDLabel
            // 
            this.PatientIDLabel.AutoSize = true;
            this.PatientIDLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.PatientIDLabel.Location = new System.Drawing.Point(34, 56);
            this.PatientIDLabel.Name = "PatientIDLabel";
            this.PatientIDLabel.Size = new System.Drawing.Size(75, 16);
            this.PatientIDLabel.TabIndex = 98;
            this.PatientIDLabel.Text = "Patient ID : ";
            // 
            // PatientIDComboBox
            // 
            this.PatientIDComboBox.FormattingEnabled = true;
            this.PatientIDComboBox.Location = new System.Drawing.Point(167, 56);
            this.PatientIDComboBox.Name = "PatientIDComboBox";
            this.PatientIDComboBox.Size = new System.Drawing.Size(108, 21);
            this.PatientIDComboBox.TabIndex = 97;
            this.PatientIDComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // PatientNameLabel
            // 
            this.PatientNameLabel.AutoSize = true;
            this.PatientNameLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.PatientNameLabel.Location = new System.Drawing.Point(34, 90);
            this.PatientNameLabel.Name = "PatientNameLabel";
            this.PatientNameLabel.Size = new System.Drawing.Size(89, 16);
            this.PatientNameLabel.TabIndex = 99;
            this.PatientNameLabel.Text = "Patient Name :";
            // 
            // PatientNameTextBox
            // 
            this.PatientNameTextBox.Location = new System.Drawing.Point(167, 93);
            this.PatientNameTextBox.Name = "PatientNameTextBox";
            this.PatientNameTextBox.ReadOnly = true;
            this.PatientNameTextBox.Size = new System.Drawing.Size(108, 20);
            this.PatientNameTextBox.TabIndex = 100;
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.ContactLabel.Location = new System.Drawing.Point(34, 133);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(58, 16);
            this.ContactLabel.TabIndex = 101;
            this.ContactLabel.Text = "Contact :";
            // 
            // ContactTextBox
            // 
            this.ContactTextBox.Location = new System.Drawing.Point(167, 133);
            this.ContactTextBox.Name = "ContactTextBox";
            this.ContactTextBox.ReadOnly = true;
            this.ContactTextBox.Size = new System.Drawing.Size(108, 20);
            this.ContactTextBox.TabIndex = 102;
            // 
            // DoctorListLabel
            // 
            this.DoctorListLabel.AutoSize = true;
            this.DoctorListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.DoctorListLabel.Location = new System.Drawing.Point(445, 9);
            this.DoctorListLabel.Name = "DoctorListLabel";
            this.DoctorListLabel.Size = new System.Drawing.Size(108, 24);
            this.DoctorListLabel.TabIndex = 103;
            this.DoctorListLabel.Text = "Doctor List";
            this.DoctorListLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // DoctorListDataGridView
            // 
            this.DoctorListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorListDataGridView.Location = new System.Drawing.Point(372, 56);
            this.DoctorListDataGridView.Name = "DoctorListDataGridView";
            this.DoctorListDataGridView.Size = new System.Drawing.Size(273, 417);
            this.DoctorListDataGridView.TabIndex = 104;
            this.DoctorListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AddAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 498);
            this.Controls.Add(this.DoctorListDataGridView);
            this.Controls.Add(this.DoctorListLabel);
            this.Controls.Add(this.ContactTextBox);
            this.Controls.Add(this.ContactLabel);
            this.Controls.Add(this.PatientNameTextBox);
            this.Controls.Add(this.PatientNameLabel);
            this.Controls.Add(this.PatientIDLabel);
            this.Controls.Add(this.PatientIDComboBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.BookButton);
            this.Controls.Add(this.AppointmentDatePicker);
            this.Controls.Add(this.AvailableSlotComboBox);
            this.Controls.Add(this.DiagnosisTextBox);
            this.Controls.Add(this.DepartmentTextBox);
            this.Controls.Add(this.DocNameTextBox);
            this.Controls.Add(this.AppointmentDateLabel);
            this.Controls.Add(this.DiagnosisLabel);
            this.Controls.Add(this.DepartmentLabel);
            this.Controls.Add(this.AvailableSlotLlabel);
            this.Controls.Add(this.DoctorNameLabel);
            this.Controls.Add(this.DoctorIDLabel);
            this.Controls.Add(this.DoctorIDComboBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "AddAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Management System";
            this.Load += new System.EventHandler(this.AddAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DoctorListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button BookButton;
        private System.Windows.Forms.DateTimePicker AppointmentDatePicker;
        private System.Windows.Forms.ComboBox AvailableSlotComboBox;
        private System.Windows.Forms.TextBox DiagnosisTextBox;
        private System.Windows.Forms.TextBox DepartmentTextBox;
        private System.Windows.Forms.TextBox DocNameTextBox;
        private System.Windows.Forms.Label AppointmentDateLabel;
        private System.Windows.Forms.Label DiagnosisLabel;
        private System.Windows.Forms.Label DepartmentLabel;
        private System.Windows.Forms.Label AvailableSlotLlabel;
        private System.Windows.Forms.Label DoctorNameLabel;
        private System.Windows.Forms.Label DoctorIDLabel;
        private System.Windows.Forms.ComboBox DoctorIDComboBox;
        private System.Windows.Forms.Label PatientIDLabel;
        private System.Windows.Forms.ComboBox PatientIDComboBox;
        private System.Windows.Forms.Label PatientNameLabel;
        private System.Windows.Forms.TextBox PatientNameTextBox;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.TextBox ContactTextBox;
        private System.Windows.Forms.Label DoctorListLabel;
        private System.Windows.Forms.DataGridView DoctorListDataGridView;
    }
}
