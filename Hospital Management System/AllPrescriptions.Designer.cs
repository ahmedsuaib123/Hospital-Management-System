namespace Hospital_Management_System
{
    partial class AllPrescriptions
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
            this.PrescriptionsDataGridView = new System.Windows.Forms.DataGridView();
            this.BackToDocDash = new System.Windows.Forms.Button();
            this.PrescriptionTabControl = new System.Windows.Forms.TabControl();
            this.PrescriptionDetailsTabPage = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReportIDLabel = new System.Windows.Forms.Label();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DosageLabel = new System.Windows.Forms.Label();
            this.TestDateLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.PatientNameLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.MedicinesLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DiagnosisLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PrescriptioonIDLabel = new System.Windows.Forms.Label();
            this.ShowAllButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PrescriptionsDataGridView)).BeginInit();
            this.PrescriptionTabControl.SuspendLayout();
            this.PrescriptionDetailsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrescriptionsDataGridView
            // 
            this.PrescriptionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrescriptionsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.PrescriptionsDataGridView.Name = "PrescriptionsDataGridView";
            this.PrescriptionsDataGridView.Size = new System.Drawing.Size(533, 394);
            this.PrescriptionsDataGridView.TabIndex = 1;
            // 
            // BackToDocDash
            // 
            this.BackToDocDash.Location = new System.Drawing.Point(13, 415);
            this.BackToDocDash.Name = "BackToDocDash";
            this.BackToDocDash.Size = new System.Drawing.Size(75, 23);
            this.BackToDocDash.TabIndex = 3;
            this.BackToDocDash.Text = "Back";
            this.BackToDocDash.UseVisualStyleBackColor = true;
            this.BackToDocDash.Click += new System.EventHandler(this.BackToDocDash_Click);
            // 
            // PrescriptionTabControl
            // 
            this.PrescriptionTabControl.Controls.Add(this.PrescriptionDetailsTabPage);
            this.PrescriptionTabControl.Location = new System.Drawing.Point(564, 13);
            this.PrescriptionTabControl.Name = "PrescriptionTabControl";
            this.PrescriptionTabControl.SelectedIndex = 0;
            this.PrescriptionTabControl.Size = new System.Drawing.Size(200, 393);
            this.PrescriptionTabControl.TabIndex = 4;
            // 
            // PrescriptionDetailsTabPage
            // 
            this.PrescriptionDetailsTabPage.Controls.Add(this.label10);
            this.PrescriptionDetailsTabPage.Controls.Add(this.TimeLabel);
            this.PrescriptionDetailsTabPage.Controls.Add(this.label8);
            this.PrescriptionDetailsTabPage.Controls.Add(this.DateLabel);
            this.PrescriptionDetailsTabPage.Controls.Add(this.label1);
            this.PrescriptionDetailsTabPage.Controls.Add(this.ReportIDLabel);
            this.PrescriptionDetailsTabPage.Controls.Add(this.NotesLabel);
            this.PrescriptionDetailsTabPage.Controls.Add(this.label4);
            this.PrescriptionDetailsTabPage.Controls.Add(this.DosageLabel);
            this.PrescriptionDetailsTabPage.Controls.Add(this.TestDateLabel);
            this.PrescriptionDetailsTabPage.Controls.Add(this.label12);
            this.PrescriptionDetailsTabPage.Controls.Add(this.label11);
            this.PrescriptionDetailsTabPage.Controls.Add(this.PatientNameLabel);
            this.PrescriptionDetailsTabPage.Controls.Add(this.label9);
            this.PrescriptionDetailsTabPage.Controls.Add(this.MedicinesLabel);
            this.PrescriptionDetailsTabPage.Controls.Add(this.label7);
            this.PrescriptionDetailsTabPage.Controls.Add(this.label6);
            this.PrescriptionDetailsTabPage.Controls.Add(this.DiagnosisLabel);
            this.PrescriptionDetailsTabPage.Controls.Add(this.ResultLabel);
            this.PrescriptionDetailsTabPage.Controls.Add(this.label3);
            this.PrescriptionDetailsTabPage.Controls.Add(this.label2);
            this.PrescriptionDetailsTabPage.Controls.Add(this.PrescriptioonIDLabel);
            this.PrescriptionDetailsTabPage.Location = new System.Drawing.Point(4, 22);
            this.PrescriptionDetailsTabPage.Name = "PrescriptionDetailsTabPage";
            this.PrescriptionDetailsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PrescriptionDetailsTabPage.Size = new System.Drawing.Size(192, 367);
            this.PrescriptionDetailsTabPage.TabIndex = 0;
            this.PrescriptionDetailsTabPage.Text = "Details";
            this.PrescriptionDetailsTabPage.UseVisualStyleBackColor = true;
            this.PrescriptionDetailsTabPage.Click += new System.EventHandler(this.PrescriptionDetailsTabPage_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Time : ";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(50, 58);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(33, 13);
            this.TimeLabel.TabIndex = 20;
            this.TimeLabel.Text = "Label";
            this.TimeLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Date : ";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(50, 33);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(33, 13);
            this.DateLabel.TabIndex = 18;
            this.DateLabel.Text = "Label";
            this.DateLabel.Click += new System.EventHandler(this.DateLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Report ID : ";
            // 
            // ReportIDLabel
            // 
            this.ReportIDLabel.AutoSize = true;
            this.ReportIDLabel.Location = new System.Drawing.Point(89, 177);
            this.ReportIDLabel.Name = "ReportIDLabel";
            this.ReportIDLabel.Size = new System.Drawing.Size(33, 13);
            this.ReportIDLabel.TabIndex = 16;
            this.ReportIDLabel.Text = "Label";
            this.ReportIDLabel.Click += new System.EventHandler(this.ReportIDLabel_Click);
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Location = new System.Drawing.Point(89, 305);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(33, 13);
            this.NotesLabel.TabIndex = 15;
            this.NotesLabel.Text = "Label";
            this.NotesLabel.Click += new System.EventHandler(this.NotesLabel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Notes : ";
            // 
            // DosageLabel
            // 
            this.DosageLabel.AutoSize = true;
            this.DosageLabel.Location = new System.Drawing.Point(89, 272);
            this.DosageLabel.Name = "DosageLabel";
            this.DosageLabel.Size = new System.Drawing.Size(33, 13);
            this.DosageLabel.TabIndex = 13;
            this.DosageLabel.Text = "Label";
            this.DosageLabel.Click += new System.EventHandler(this.DosageLabel_Click);
            // 
            // TestDateLabel
            // 
            this.TestDateLabel.AutoSize = true;
            this.TestDateLabel.Location = new System.Drawing.Point(85, 149);
            this.TestDateLabel.Name = "TestDateLabel";
            this.TestDateLabel.Size = new System.Drawing.Size(33, 13);
            this.TestDateLabel.TabIndex = 12;
            this.TestDateLabel.Text = "Label";
            this.TestDateLabel.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Result : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Test Date : ";
            // 
            // PatientNameLabel
            // 
            this.PatientNameLabel.AutoSize = true;
            this.PatientNameLabel.Location = new System.Drawing.Point(89, 83);
            this.PatientNameLabel.Name = "PatientNameLabel";
            this.PatientNameLabel.Size = new System.Drawing.Size(33, 13);
            this.PatientNameLabel.TabIndex = 9;
            this.PatientNameLabel.Text = "Label";
            this.PatientNameLabel.Click += new System.EventHandler(this.PatientNameLabel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Medicine : ";
            // 
            // MedicinesLabel
            // 
            this.MedicinesLabel.AutoSize = true;
            this.MedicinesLabel.Location = new System.Drawing.Point(89, 241);
            this.MedicinesLabel.Name = "MedicinesLabel";
            this.MedicinesLabel.Size = new System.Drawing.Size(33, 13);
            this.MedicinesLabel.TabIndex = 7;
            this.MedicinesLabel.Text = "Label";
            this.MedicinesLabel.Click += new System.EventHandler(this.MedicinesLabel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Dosage : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Diagnosis : ";
            // 
            // DiagnosisLabel
            // 
            this.DiagnosisLabel.AutoSize = true;
            this.DiagnosisLabel.Location = new System.Drawing.Point(89, 116);
            this.DiagnosisLabel.Name = "DiagnosisLabel";
            this.DiagnosisLabel.Size = new System.Drawing.Size(33, 13);
            this.DiagnosisLabel.TabIndex = 4;
            this.DiagnosisLabel.Text = "Label";
            this.DiagnosisLabel.Click += new System.EventHandler(this.DiagnosisLabel_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(89, 209);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(33, 13);
            this.ResultLabel.TabIndex = 3;
            this.ResultLabel.Text = "Label";
            this.ResultLabel.Click += new System.EventHandler(this.ResultLabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Patient Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prescription ID : ";
            // 
            // PrescriptioonIDLabel
            // 
            this.PrescriptioonIDLabel.AutoSize = true;
            this.PrescriptioonIDLabel.Location = new System.Drawing.Point(89, 10);
            this.PrescriptioonIDLabel.Name = "PrescriptioonIDLabel";
            this.PrescriptioonIDLabel.Size = new System.Drawing.Size(33, 13);
            this.PrescriptioonIDLabel.TabIndex = 0;
            this.PrescriptioonIDLabel.Text = "Label";
            this.PrescriptioonIDLabel.Click += new System.EventHandler(this.PrescriptioonIDLabel_Click);
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.Location = new System.Drawing.Point(469, 415);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(75, 23);
            this.ShowAllButton.TabIndex = 5;
            this.ShowAllButton.Text = "Show All";
            this.ShowAllButton.UseVisualStyleBackColor = true;
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // AllPrescriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowAllButton);
            this.Controls.Add(this.PrescriptionTabControl);
            this.Controls.Add(this.BackToDocDash);
            this.Controls.Add(this.PrescriptionsDataGridView);
            this.Name = "AllPrescriptions";
            this.Text = "AllPrescriptions";
            this.Load += new System.EventHandler(this.AllPrescriptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrescriptionsDataGridView)).EndInit();
            this.PrescriptionTabControl.ResumeLayout(false);
            this.PrescriptionDetailsTabPage.ResumeLayout(false);
            this.PrescriptionDetailsTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PrescriptionsDataGridView;
        private System.Windows.Forms.Button BackToDocDash;
        private System.Windows.Forms.TabControl PrescriptionTabControl;
        private System.Windows.Forms.TabPage PrescriptionDetailsTabPage;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PrescriptioonIDLabel;
        private System.Windows.Forms.Label DosageLabel;
        private System.Windows.Forms.Label TestDateLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label PatientNameLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label MedicinesLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label DiagnosisLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ReportIDLabel;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Button ShowAllButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label TimeLabel;
    }
}