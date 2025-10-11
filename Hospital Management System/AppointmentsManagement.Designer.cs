namespace Hospital_Management_System
{
    partial class AppointmentsManagement
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
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.AppointmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.AppointmentsTitleLabel = new System.Windows.Forms.Label();
            this.SearchComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(76, 83);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(193, 20);
            this.SearchTextBox.TabIndex = 51;
            this.SearchTextBox.Visible = false;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.SearchLabel.Location = new System.Drawing.Point(72, 51);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(84, 20);
            this.SearchLabel.TabIndex = 50;
            this.SearchLabel.Text = "Search By";
            // 
            // BackButton
            // 
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(638, 401);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(87, 33);
            this.BackButton.TabIndex = 48;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(76, 401);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(87, 33);
            this.AddButton.TabIndex = 45;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AppointmentsDataGridView
            // 
            this.AppointmentsDataGridView.AllowUserToAddRows = false;
            this.AppointmentsDataGridView.AllowUserToDeleteRows = false;
            this.AppointmentsDataGridView.AllowUserToResizeColumns = false;
            this.AppointmentsDataGridView.AllowUserToResizeRows = false;
            this.AppointmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentsDataGridView.Location = new System.Drawing.Point(76, 109);
            this.AppointmentsDataGridView.Name = "AppointmentsDataGridView";
            this.AppointmentsDataGridView.ReadOnly = true;
            this.AppointmentsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.AppointmentsDataGridView.Size = new System.Drawing.Size(649, 286);
            this.AppointmentsDataGridView.TabIndex = 44;
            // 
            // AppointmentsTitleLabel
            // 
            this.AppointmentsTitleLabel.AutoSize = true;
            this.AppointmentsTitleLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentsTitleLabel.Location = new System.Drawing.Point(353, 16);
            this.AppointmentsTitleLabel.Name = "AppointmentsTitleLabel";
            this.AppointmentsTitleLabel.Size = new System.Drawing.Size(126, 23);
            this.AppointmentsTitleLabel.TabIndex = 43;
            this.AppointmentsTitleLabel.Text = "Appointments";
            // 
            // SearchComboBox
            // 
            this.SearchComboBox.FormattingEnabled = true;
            this.SearchComboBox.Items.AddRange(new object[] {
            "AppointmentID",
            "PatientName",
            "DoctorName"});
            this.SearchComboBox.Location = new System.Drawing.Point(162, 51);
            this.SearchComboBox.Name = "SearchComboBox";
            this.SearchComboBox.Size = new System.Drawing.Size(107, 21);
            this.SearchComboBox.TabIndex = 52;
            // 
            // AppointmentsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchComboBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AppointmentsDataGridView);
            this.Controls.Add(this.AppointmentsTitleLabel);
            this.Name = "AppointmentsManagement";
            this.Text = "Hospital Management System";
            this.Load += new System.EventHandler(this.ShowAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView AppointmentsDataGridView;
        private System.Windows.Forms.Label AppointmentsTitleLabel;
        private System.Windows.Forms.ComboBox SearchComboBox;
    }
}