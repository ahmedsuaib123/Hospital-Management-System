namespace Hospital_Management_System
{
    partial class PatientDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientDashboard));
            this.DateLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ProfilePanelExtender = new System.Windows.Forms.Button();
            this.ProfilePanel = new System.Windows.Forms.Panel();
            this.BloodGroup1Label = new System.Windows.Forms.Label();
            this.Gender1Label = new System.Windows.Forms.Label();
            this.Age1Label = new System.Windows.Forms.Label();
            this.Contact1Label = new System.Windows.Forms.Label();
            this.Name1Label = new System.Windows.Forms.Label();
            this.BloodGroupLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.labelLastAppointment = new System.Windows.Forms.Label();
            this.labelNextAppointment = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.BookAppointmentButton = new System.Windows.Forms.Button();
            this.ReportsButton = new System.Windows.Forms.Button();
            this.PrescriptionsButton = new System.Windows.Forms.Button();
            this.ProfilePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(310, 20);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(91, 13);
            this.DateLabel.TabIndex = 13;
            this.DateLabel.Text = "Date Shows Here";
            this.DateLabel.Click += new System.EventHandler(this.DateLabel_Click);
            // 
            // timer
            // 
            this.timer.Interval = 15;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ProfilePanelExtender
            // 
            this.ProfilePanelExtender.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProfilePanelExtender.BackgroundImage")));
            this.ProfilePanelExtender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ProfilePanelExtender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfilePanelExtender.Location = new System.Drawing.Point(12, 9);
            this.ProfilePanelExtender.Name = "ProfilePanelExtender";
            this.ProfilePanelExtender.Size = new System.Drawing.Size(50, 35);
            this.ProfilePanelExtender.TabIndex = 23;
            this.ProfilePanelExtender.UseVisualStyleBackColor = true;
            this.ProfilePanelExtender.Click += new System.EventHandler(this.ProfilePanelExtender_Click);
            // 
            // ProfilePanel
            // 
            this.ProfilePanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.ProfilePanel.Controls.Add(this.BloodGroup1Label);
            this.ProfilePanel.Controls.Add(this.Gender1Label);
            this.ProfilePanel.Controls.Add(this.Age1Label);
            this.ProfilePanel.Controls.Add(this.Contact1Label);
            this.ProfilePanel.Controls.Add(this.Name1Label);
            this.ProfilePanel.Controls.Add(this.BloodGroupLabel);
            this.ProfilePanel.Controls.Add(this.GenderLabel);
            this.ProfilePanel.Controls.Add(this.AgeLabel);
            this.ProfilePanel.Controls.Add(this.button1);
            this.ProfilePanel.Controls.Add(this.ContactLabel);
            this.ProfilePanel.Controls.Add(this.NameLabel);
            this.ProfilePanel.Location = new System.Drawing.Point(790, 0);
            this.ProfilePanel.Name = "ProfilePanel";
            this.ProfilePanel.Size = new System.Drawing.Size(10, 450);
            this.ProfilePanel.TabIndex = 24;
            // 
            // BloodGroup1Label
            // 
            this.BloodGroup1Label.AutoSize = true;
            this.BloodGroup1Label.Location = new System.Drawing.Point(113, 264);
            this.BloodGroup1Label.Name = "BloodGroup1Label";
            this.BloodGroup1Label.Size = new System.Drawing.Size(0, 13);
            this.BloodGroup1Label.TabIndex = 10;
            // 
            // Gender1Label
            // 
            this.Gender1Label.AutoSize = true;
            this.Gender1Label.Location = new System.Drawing.Point(86, 229);
            this.Gender1Label.Name = "Gender1Label";
            this.Gender1Label.Size = new System.Drawing.Size(0, 13);
            this.Gender1Label.TabIndex = 9;
            // 
            // Age1Label
            // 
            this.Age1Label.AutoSize = true;
            this.Age1Label.Location = new System.Drawing.Point(73, 193);
            this.Age1Label.Name = "Age1Label";
            this.Age1Label.Size = new System.Drawing.Size(0, 13);
            this.Age1Label.TabIndex = 8;
            // 
            // Contact1Label
            // 
            this.Contact1Label.AutoSize = true;
            this.Contact1Label.Location = new System.Drawing.Point(88, 163);
            this.Contact1Label.Name = "Contact1Label";
            this.Contact1Label.Size = new System.Drawing.Size(0, 13);
            this.Contact1Label.TabIndex = 7;
            // 
            // Name1Label
            // 
            this.Name1Label.AutoSize = true;
            this.Name1Label.Location = new System.Drawing.Point(79, 134);
            this.Name1Label.Name = "Name1Label";
            this.Name1Label.Size = new System.Drawing.Size(0, 13);
            this.Name1Label.TabIndex = 6;
            // 
            // BloodGroupLabel
            // 
            this.BloodGroupLabel.AutoSize = true;
            this.BloodGroupLabel.Location = new System.Drawing.Point(29, 264);
            this.BloodGroupLabel.Name = "BloodGroupLabel";
            this.BloodGroupLabel.Size = new System.Drawing.Size(75, 13);
            this.BloodGroupLabel.TabIndex = 5;
            this.BloodGroupLabel.Text = "Blood Group : ";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(29, 229);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(51, 13);
            this.GenderLabel.TabIndex = 4;
            this.GenderLabel.Text = "Gender : ";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(29, 193);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(35, 13);
            this.AgeLabel.TabIndex = 3;
            this.AgeLabel.Text = "Age : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(161, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 37);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Location = new System.Drawing.Point(29, 163);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(53, 13);
            this.ContactLabel.TabIndex = 1;
            this.ContactLabel.Text = "Contact : ";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(29, 134);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(44, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name : ";
            // 
            // labelLastAppointment
            // 
            this.labelLastAppointment.AutoSize = true;
            this.labelLastAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelLastAppointment.Location = new System.Drawing.Point(286, 257);
            this.labelLastAppointment.Name = "labelLastAppointment";
            this.labelLastAppointment.Size = new System.Drawing.Size(148, 20);
            this.labelLastAppointment.TabIndex = 30;
            this.labelLastAppointment.Text = "Last Appointment: -";
            // 
            // labelNextAppointment
            // 
            this.labelNextAppointment.AutoSize = true;
            this.labelNextAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelNextAppointment.Location = new System.Drawing.Point(285, 188);
            this.labelNextAppointment.Name = "labelNextAppointment";
            this.labelNextAppointment.Size = new System.Drawing.Size(149, 20);
            this.labelNextAppointment.TabIndex = 28;
            this.labelNextAppointment.Text = "Next Appointment: -";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button4.Location = new System.Drawing.Point(12, 116);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 34);
            this.button4.TabIndex = 26;
            this.button4.Text = "Appointments";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // BookAppointmentButton
            // 
            this.BookAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BookAppointmentButton.Location = new System.Drawing.Point(12, 193);
            this.BookAppointmentButton.Name = "BookAppointmentButton";
            this.BookAppointmentButton.Size = new System.Drawing.Size(171, 34);
            this.BookAppointmentButton.TabIndex = 25;
            this.BookAppointmentButton.Text = "Book Appointment";
            this.BookAppointmentButton.UseVisualStyleBackColor = true;
            this.BookAppointmentButton.Click += new System.EventHandler(this.BookAppointmentButton_Click);
            // 
            // ReportsButton
            // 
            this.ReportsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ReportsButton.Location = new System.Drawing.Point(12, 275);
            this.ReportsButton.Name = "ReportsButton";
            this.ReportsButton.Size = new System.Drawing.Size(171, 34);
            this.ReportsButton.TabIndex = 31;
            this.ReportsButton.Text = "Reports";
            this.ReportsButton.UseVisualStyleBackColor = true;
            // 
            // PrescriptionsButton
            // 
            this.PrescriptionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.PrescriptionsButton.Location = new System.Drawing.Point(12, 359);
            this.PrescriptionsButton.Name = "PrescriptionsButton";
            this.PrescriptionsButton.Size = new System.Drawing.Size(171, 34);
            this.PrescriptionsButton.TabIndex = 32;
            this.PrescriptionsButton.Text = "Prescriptions";
            this.PrescriptionsButton.UseVisualStyleBackColor = true;
            // 
            // PatientDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PrescriptionsButton);
            this.Controls.Add(this.ReportsButton);
            this.Controls.Add(this.labelLastAppointment);
            this.Controls.Add(this.labelNextAppointment);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BookAppointmentButton);
            this.Controls.Add(this.ProfilePanel);
            this.Controls.Add(this.ProfilePanelExtender);
            this.Controls.Add(this.DateLabel);
            this.Name = "PatientDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientDashboard";
            this.Load += new System.EventHandler(this.PatientDashboard_Load);
            this.ProfilePanel.ResumeLayout(false);
            this.ProfilePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button ProfilePanelExtender;
        private System.Windows.Forms.Panel ProfilePanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label BloodGroup1Label;
        private System.Windows.Forms.Label Gender1Label;
        private System.Windows.Forms.Label Age1Label;
        private System.Windows.Forms.Label Contact1Label;
        private System.Windows.Forms.Label Name1Label;
        private System.Windows.Forms.Label BloodGroupLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label labelLastAppointment;
        private System.Windows.Forms.Label labelNextAppointment;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BookAppointmentButton;
        private System.Windows.Forms.Button ReportsButton;
        private System.Windows.Forms.Button PrescriptionsButton;
    }
}