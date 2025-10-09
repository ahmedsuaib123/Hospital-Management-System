namespace Hospital_Management_System
{
    partial class Signup
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
            this.GeneralInformationsPanel = new System.Windows.Forms.Panel();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.BloodGroupComboBox = new System.Windows.Forms.ComboBox();
            this.BloodGroupLabel = new System.Windows.Forms.Label();
            this.ContactTextBox = new System.Windows.Forms.TextBox();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.DateOfTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.QualificationTextBox = new System.Windows.Forms.TextBox();
            this.QualificationLabel = new System.Windows.Forms.Label();
            this.AvailableSlotTextBox = new System.Windows.Forms.TextBox();
            this.AvailableSlotLabel = new System.Windows.Forms.Label();
            this.GeneralInformationsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GeneralInformationsPanel
            // 
            this.GeneralInformationsPanel.Controls.Add(this.AvailableSlotTextBox);
            this.GeneralInformationsPanel.Controls.Add(this.AvailableSlotLabel);
            this.GeneralInformationsPanel.Controls.Add(this.QualificationTextBox);
            this.GeneralInformationsPanel.Controls.Add(this.QualificationLabel);
            this.GeneralInformationsPanel.Controls.Add(this.AddressTextBox);
            this.GeneralInformationsPanel.Controls.Add(this.AddressLabel);
            this.GeneralInformationsPanel.Controls.Add(this.NextButton);
            this.GeneralInformationsPanel.Controls.Add(this.ResetButton);
            this.GeneralInformationsPanel.Controls.Add(this.BackButton);
            this.GeneralInformationsPanel.Controls.Add(this.CategoryComboBox);
            this.GeneralInformationsPanel.Controls.Add(this.CategoryLabel);
            this.GeneralInformationsPanel.Controls.Add(this.BloodGroupComboBox);
            this.GeneralInformationsPanel.Controls.Add(this.BloodGroupLabel);
            this.GeneralInformationsPanel.Controls.Add(this.ContactTextBox);
            this.GeneralInformationsPanel.Controls.Add(this.ContactLabel);
            this.GeneralInformationsPanel.Controls.Add(this.comboBox1);
            this.GeneralInformationsPanel.Controls.Add(this.GenderLabel);
            this.GeneralInformationsPanel.Controls.Add(this.AgeTextBox);
            this.GeneralInformationsPanel.Controls.Add(this.AgeLabel);
            this.GeneralInformationsPanel.Controls.Add(this.DateOfTimeDateTimePicker);
            this.GeneralInformationsPanel.Controls.Add(this.DateOfBirthLabel);
            this.GeneralInformationsPanel.Controls.Add(this.FullNameTextBox);
            this.GeneralInformationsPanel.Controls.Add(this.FullNameLabel);
            this.GeneralInformationsPanel.Controls.Add(this.TitleLabel);
            this.GeneralInformationsPanel.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.GeneralInformationsPanel.Location = new System.Drawing.Point(3, 3);
            this.GeneralInformationsPanel.Name = "GeneralInformationsPanel";
            this.GeneralInformationsPanel.Size = new System.Drawing.Size(801, 447);
            this.GeneralInformationsPanel.TabIndex = 0;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "Patient",
            "Doctor",
            "Nurse"});
            this.CategoryComboBox.Location = new System.Drawing.Point(261, 291);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(74, 25);
            this.CategoryComboBox.TabIndex = 32;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.CategoryLabel.Location = new System.Drawing.Point(170, 294);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(62, 17);
            this.CategoryLabel.TabIndex = 31;
            this.CategoryLabel.Text = "Category";
            // 
            // BloodGroupComboBox
            // 
            this.BloodGroupComboBox.FormattingEnabled = true;
            this.BloodGroupComboBox.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.BloodGroupComboBox.Location = new System.Drawing.Point(261, 250);
            this.BloodGroupComboBox.Name = "BloodGroupComboBox";
            this.BloodGroupComboBox.Size = new System.Drawing.Size(74, 25);
            this.BloodGroupComboBox.TabIndex = 30;
            // 
            // BloodGroupLabel
            // 
            this.BloodGroupLabel.AutoSize = true;
            this.BloodGroupLabel.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.BloodGroupLabel.Location = new System.Drawing.Point(150, 253);
            this.BloodGroupLabel.Name = "BloodGroupLabel";
            this.BloodGroupLabel.Size = new System.Drawing.Size(82, 17);
            this.BloodGroupLabel.TabIndex = 29;
            this.BloodGroupLabel.Text = "Blood Group";
            // 
            // ContactTextBox
            // 
            this.ContactTextBox.Location = new System.Drawing.Point(261, 208);
            this.ContactTextBox.Name = "ContactTextBox";
            this.ContactTextBox.Size = new System.Drawing.Size(246, 24);
            this.ContactTextBox.TabIndex = 28;
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.ContactLabel.Location = new System.Drawing.Point(178, 208);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(54, 17);
            this.ContactLabel.TabIndex = 27;
            this.ContactLabel.Text = "Contact";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.comboBox1.Location = new System.Drawing.Point(261, 165);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(84, 25);
            this.comboBox1.TabIndex = 26;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.GenderLabel.Location = new System.Drawing.Point(181, 168);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(51, 17);
            this.GenderLabel.TabIndex = 25;
            this.GenderLabel.Text = "Gender";
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(261, 123);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.ReadOnly = true;
            this.AgeTextBox.Size = new System.Drawing.Size(74, 24);
            this.AgeTextBox.TabIndex = 24;
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.AgeLabel.Location = new System.Drawing.Point(199, 126);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(33, 17);
            this.AgeLabel.TabIndex = 23;
            this.AgeLabel.Text = "Age";
            // 
            // DateOfTimeDateTimePicker
            // 
            this.DateOfTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfTimeDateTimePicker.Location = new System.Drawing.Point(261, 84);
            this.DateOfTimeDateTimePicker.Name = "DateOfTimeDateTimePicker";
            this.DateOfTimeDateTimePicker.Size = new System.Drawing.Size(84, 24);
            this.DateOfTimeDateTimePicker.TabIndex = 22;
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.DateOfBirthLabel.Location = new System.Drawing.Point(142, 88);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(90, 17);
            this.DateOfBirthLabel.TabIndex = 21;
            this.DateOfBirthLabel.Text = "Date Of Birth";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(261, 44);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(246, 24);
            this.FullNameTextBox.TabIndex = 20;
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.FullNameLabel.Location = new System.Drawing.Point(163, 47);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(69, 17);
            this.FullNameLabel.TabIndex = 19;
            this.FullNameLabel.Text = "Full Name";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(274, 6);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(191, 23);
            this.TitleLabel.TabIndex = 18;
            this.TitleLabel.Text = "General Informations";
            // 
            // BackButton
            // 
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.BackButton.Location = new System.Drawing.Point(9, 411);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(87, 33);
            this.BackButton.TabIndex = 33;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetButton.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.ResetButton.Location = new System.Drawing.Point(321, 411);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(87, 33);
            this.ResetButton.TabIndex = 34;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextButton.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(685, 411);
            this.NextButton.Name = "NextButton";
            this.NextButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NextButton.Size = new System.Drawing.Size(87, 33);
            this.NextButton.TabIndex = 35;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(261, 325);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(133, 24);
            this.AddressTextBox.TabIndex = 37;
            this.AddressTextBox.Visible = false;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.AddressLabel.Location = new System.Drawing.Point(178, 328);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(57, 17);
            this.AddressLabel.TabIndex = 36;
            this.AddressLabel.Text = "Address";
            this.AddressLabel.Visible = false;
            this.AddressLabel.Click += new System.EventHandler(this.AddressLabel_Click);
            // 
            // QualificationTextBox
            // 
            this.QualificationTextBox.Location = new System.Drawing.Point(261, 325);
            this.QualificationTextBox.Name = "QualificationTextBox";
            this.QualificationTextBox.Size = new System.Drawing.Size(133, 24);
            this.QualificationTextBox.TabIndex = 39;
            this.QualificationTextBox.Visible = false;
            this.QualificationTextBox.TextChanged += new System.EventHandler(this.QualificationTextBox_TextChanged);
            // 
            // QualificationLabel
            // 
            this.QualificationLabel.AutoSize = true;
            this.QualificationLabel.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.QualificationLabel.Location = new System.Drawing.Point(150, 328);
            this.QualificationLabel.Name = "QualificationLabel";
            this.QualificationLabel.Size = new System.Drawing.Size(82, 17);
            this.QualificationLabel.TabIndex = 38;
            this.QualificationLabel.Text = "Qualification";
            this.QualificationLabel.Visible = false;
            this.QualificationLabel.Click += new System.EventHandler(this.QualificationLabel_Click);
            // 
            // AvailableSlotTextBox
            // 
            this.AvailableSlotTextBox.Location = new System.Drawing.Point(261, 370);
            this.AvailableSlotTextBox.Name = "AvailableSlotTextBox";
            this.AvailableSlotTextBox.Size = new System.Drawing.Size(133, 24);
            this.AvailableSlotTextBox.TabIndex = 41;
            this.AvailableSlotTextBox.Visible = false;
            // 
            // AvailableSlotLabel
            // 
            this.AvailableSlotLabel.AutoSize = true;
            this.AvailableSlotLabel.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.AvailableSlotLabel.Location = new System.Drawing.Point(147, 373);
            this.AvailableSlotLabel.Name = "AvailableSlotLabel";
            this.AvailableSlotLabel.Size = new System.Drawing.Size(88, 17);
            this.AvailableSlotLabel.TabIndex = 40;
            this.AvailableSlotLabel.Text = "Available Slot";
            this.AvailableSlotLabel.Visible = false;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GeneralInformationsPanel);
            this.Name = "Signup";
            this.Text = "Hospital Management System";
            this.GeneralInformationsPanel.ResumeLayout(false);
            this.GeneralInformationsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GeneralInformationsPanel;
        private System.Windows.Forms.DateTimePicker DateOfTimeDateTimePicker;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox ContactTextBox;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ComboBox BloodGroupComboBox;
        private System.Windows.Forms.Label BloodGroupLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox QualificationTextBox;
        private System.Windows.Forms.Label QualificationLabel;
        private System.Windows.Forms.TextBox AvailableSlotTextBox;
        private System.Windows.Forms.Label AvailableSlotLabel;
    }
}