using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class AllPrescriptions : Form
    {
        private Form parentForm;
        private int doctorID;
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");

        public AllPrescriptions(Form parent, int doctorID)
        {
            InitializeComponent();
            this.parentForm = parent;
            this.doctorID = doctorID;

            PrescriptionsDataGridView.CellClick += PrescriptionsDataGridView_CellClick;

        }

        private void AllPrescriptions_Load(object sender, EventArgs e)
        {
            LoadPrescriptions();
        }

        private void LoadPrescriptions()
        {
            try
            {
                string query = @"
SELECT 
    pr.PrescriptionID,
    p.PatientName,
    pr.PrescriptionDate,
    pr.MedicineName,
    pr.Dosage,
    pr.Notes
FROM Prescription pr
INNER JOIN Patient p ON pr.PatientID = p.PatientID
WHERE pr.DoctorID = @DoctorID
ORDER BY pr.PrescriptionDate DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@DoctorID", doctorID);

                DataTable dt = new DataTable();
                da.Fill(dt);

                PrescriptionsDataGridView.DataSource = dt;

                PrescriptionsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                PrescriptionsDataGridView.ReadOnly = true;
                PrescriptionsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading prescriptions: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackToDocDash_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }

        private void PrescriptionsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                var prescriptionID = Convert.ToInt32(PrescriptionsDataGridView.Rows[e.RowIndex].Cells["PrescriptionID"].Value);

                string query = @"
SELECT 
    pr.PrescriptionID,
    p.PatientName,
    p.Diagnosis,
    tr.TestDate,
    tr.ReportID,
    tr.TestResult,
    pr.PrescriptionDate,
    pr.MedicineName,
    pr.Dosage,
    pr.Notes
FROM Prescription pr
INNER JOIN Patient p ON pr.PatientID = p.PatientID
LEFT JOIN TestReport tr 
    ON tr.PatientID = p.PatientID AND tr.DoctorID = pr.DoctorID
WHERE pr.PrescriptionID = @PrescriptionID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@PrescriptionID", prescriptionID);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        PrescriptioonIDLabel.Text = reader["PrescriptionID"].ToString();
                        PatientNameLabel.Text = reader["PatientName"].ToString();
                        DiagnosisLabel.Text = reader["Diagnosis"].ToString();
                        TestDateLabel.Text = reader["TestDate"].ToString();
                        ReportIDLabel.Text = reader["ReportID"].ToString();
                        ResultLabel.Text = reader["TestResult"].ToString();

                        // Separate Date and Time
                        DateTime prescriptionDateTime;
                        if (DateTime.TryParse(reader["PrescriptionDate"].ToString(), out prescriptionDateTime))
                        {
                            DateLabel.Text = prescriptionDateTime.ToString("yyyy-MM-dd"); // Date only
                            TimeLabel.Text = prescriptionDateTime.ToString("HH:mm tt");   // Time only
                        }
                        else
                        {
                            DateLabel.Text = reader["PrescriptionDate"].ToString();
                            TimeLabel.Text = "";
                        }

                        MedicinesLabel.Text = reader["MedicineName"].ToString();
                        DosageLabel.Text = reader["Dosage"].ToString();
                        NotesLabel.Text = reader["Notes"].ToString();
                    }

                    reader.Close();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading prescription details: " + ex.Message);
                if (con.State == ConnectionState.Open) con.Close();
            }
        }



        private void PrescriptioonIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void DateLabel_Click(object sender, EventArgs e)//date label
        {

        }

        private void PatientNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void DiagnosisLabel_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)//test date label
        {

        }

        private void ReportIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void ResultLabel_Click(object sender, EventArgs e)
        {

        }

        private void MedicinesLabel_Click(object sender, EventArgs e)
        {

        }

        private void DosageLabel_Click(object sender, EventArgs e)
        {

        }

        private void NotesLabel_Click(object sender, EventArgs e)
        {

        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            LoadPrescriptions();
        }

        private void PrescriptionDetailsTabPage_Click(object sender, EventArgs e)
        {

        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
