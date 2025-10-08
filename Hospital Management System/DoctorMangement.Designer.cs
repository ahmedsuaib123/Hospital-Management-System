namespace Hospital_Management_System
{
    partial class DoctorMangement
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
            this.DoctorTitleLabel = new System.Windows.Forms.Label();
            this.DoctorsDataGridView = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DoctorTitleLabel
            // 
            this.DoctorTitleLabel.AutoSize = true;
            this.DoctorTitleLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorTitleLabel.Location = new System.Drawing.Point(344, 24);
            this.DoctorTitleLabel.Name = "DoctorTitleLabel";
            this.DoctorTitleLabel.Size = new System.Drawing.Size(76, 23);
            this.DoctorTitleLabel.TabIndex = 1;
            this.DoctorTitleLabel.Text = "Doctors";
            // 
            // DoctorsDataGridView
            // 
            this.DoctorsDataGridView.AllowUserToAddRows = false;
            this.DoctorsDataGridView.AllowUserToDeleteRows = false;
            this.DoctorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorsDataGridView.Location = new System.Drawing.Point(78, 88);
            this.DoctorsDataGridView.Name = "DoctorsDataGridView";
            this.DoctorsDataGridView.ReadOnly = true;
            this.DoctorsDataGridView.Size = new System.Drawing.Size(647, 258);
            this.DoctorsDataGridView.TabIndex = 2;
            // 
            // BackButton
            // 
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(638, 387);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(87, 33);
            this.BackButton.TabIndex = 19;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(444, 387);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(87, 33);
            this.UpdateButton.TabIndex = 18;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(271, 387);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(87, 33);
            this.DeleteButton.TabIndex = 17;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(76, 387);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(87, 33);
            this.AddButton.TabIndex = 16;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // DoctorMangement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DoctorsDataGridView);
            this.Controls.Add(this.DoctorTitleLabel);
            this.Name = "DoctorMangement";
            this.Text = "Hospital Management System";
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DoctorTitleLabel;
        private System.Windows.Forms.DataGridView DoctorsDataGridView;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
    }
}