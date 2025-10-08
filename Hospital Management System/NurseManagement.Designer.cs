namespace Hospital_Management_System
{
    partial class NurseManagement
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
            this.BackButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.NurseDataGridView = new System.Windows.Forms.DataGridView();
            this.NurseTitleLabel = new System.Windows.Forms.Label();
            this.DutyScheduleButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NurseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(638, 394);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(87, 33);
            this.BackButton.TabIndex = 21;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(444, 394);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(87, 33);
            this.UpdateButton.TabIndex = 20;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(271, 394);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(87, 33);
            this.DeleteButton.TabIndex = 19;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(76, 394);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(87, 33);
            this.AddButton.TabIndex = 18;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // NurseDataGridView
            // 
            this.NurseDataGridView.AllowUserToAddRows = false;
            this.NurseDataGridView.AllowUserToDeleteRows = false;
            this.NurseDataGridView.AllowUserToResizeColumns = false;
            this.NurseDataGridView.AllowUserToResizeRows = false;
            this.NurseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NurseDataGridView.Location = new System.Drawing.Point(76, 79);
            this.NurseDataGridView.Name = "NurseDataGridView";
            this.NurseDataGridView.ReadOnly = true;
            this.NurseDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.NurseDataGridView.Size = new System.Drawing.Size(649, 286);
            this.NurseDataGridView.TabIndex = 17;
            // 
            // NurseTitleLabel
            // 
            this.NurseTitleLabel.AutoSize = true;
            this.NurseTitleLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NurseTitleLabel.Location = new System.Drawing.Point(353, 9);
            this.NurseTitleLabel.Name = "NurseTitleLabel";
            this.NurseTitleLabel.Size = new System.Drawing.Size(68, 23);
            this.NurseTitleLabel.TabIndex = 16;
            this.NurseTitleLabel.Text = "Nurses";
            // 
            // DutyScheduleButton
            // 
            this.DutyScheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DutyScheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DutyScheduleButton.Location = new System.Drawing.Point(551, 32);
            this.DutyScheduleButton.Name = "DutyScheduleButton";
            this.DutyScheduleButton.Size = new System.Drawing.Size(174, 32);
            this.DutyScheduleButton.TabIndex = 22;
            this.DutyScheduleButton.Text = "Duty Schedule";
            this.DutyScheduleButton.UseVisualStyleBackColor = true;
            // 
            // NurseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DutyScheduleButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.NurseDataGridView);
            this.Controls.Add(this.NurseTitleLabel);
            this.Name = "NurseManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Management System";
            ((System.ComponentModel.ISupportInitialize)(this.NurseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView NurseDataGridView;
        private System.Windows.Forms.Label NurseTitleLabel;
        private System.Windows.Forms.Button DutyScheduleButton;
    }
}