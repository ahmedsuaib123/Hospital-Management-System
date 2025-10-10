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
            this.MedicalRecordsTitleLabel = new System.Windows.Forms.Label();
            this.MedicalRecordsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MedicalRecordsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MedicalRecordsTitleLabel
            // 
            this.MedicalRecordsTitleLabel.AutoSize = true;
            this.MedicalRecordsTitleLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicalRecordsTitleLabel.Location = new System.Drawing.Point(323, 32);
            this.MedicalRecordsTitleLabel.Name = "MedicalRecordsTitleLabel";
            this.MedicalRecordsTitleLabel.Size = new System.Drawing.Size(151, 23);
            this.MedicalRecordsTitleLabel.TabIndex = 2;
            this.MedicalRecordsTitleLabel.Text = "Medical Records";
            // 
            // MedicalRecordsDataGridView
            // 
            this.MedicalRecordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicalRecordsDataGridView.Location = new System.Drawing.Point(84, 79);
            this.MedicalRecordsDataGridView.Name = "MedicalRecordsDataGridView";
            this.MedicalRecordsDataGridView.Size = new System.Drawing.Size(623, 292);
            this.MedicalRecordsDataGridView.TabIndex = 3;
            // 
            // MedicalRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MedicalRecordsDataGridView);
            this.Controls.Add(this.MedicalRecordsTitleLabel);
            this.Name = "MedicalRecords";
            this.Text = "Hospital Management System";
            ((System.ComponentModel.ISupportInitialize)(this.MedicalRecordsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MedicalRecordsTitleLabel;
        private System.Windows.Forms.DataGridView MedicalRecordsDataGridView;
    }
}