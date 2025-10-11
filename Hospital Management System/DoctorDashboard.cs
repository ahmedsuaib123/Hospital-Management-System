using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class DoctorDashboard : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");
        private bool isProfilePanelExpanded = false;
        private int targetWidth = 220;
        private int animationStep = 20;
        public static int DoctorID;

        public DoctorDashboard()
        {
            InitializeComponent();

            ProfilePanel.Width = 0;
            ProfilePanel.Left = this.ClientSize.Width;

            timer1.Tick += timer1_Tick;
            ProfilePanelExtender.Click += ProfilePanelExtender_Click;
            SearchButton.Click += SearchButton_Click;
            ClearButton.Click += ClearButton_Click;
            ShowAllButton.Click += ShowAllButton_Click;
            ReportsButton.Click += ReportsButton_Click;
            LogoutButton.Click += LogoutButton_Click;

            AppointmentDataGridView.CellDoubleClick += AppointmentDataGridView_CellDoubleClick;
        }

        private void DoctorDashboard_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome, " + Login.username;

            Name1Label.Text = Login.fullName;
            Contact1Label.Text = Login.contact;
            Age1Label.Text = Login.age != null ? Login.age.ToString() : "N/A";
            Gender1Label.Text = Login.gender;
            BloodGroup1Label.Text = Login.bloodGroup;
            Available1Label.Text = Login.availableSlot;

            DateLabel.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm:ss tt");
            Timer dateTimer = new Timer { Interval = 1000 };
            dateTimer.Tick += (s, ev) => DateLabel.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm:ss tt");
            dateTimer.Start();
        }

        public void SetReportDetails(string reportID, string patientID, string patientName, string testDate, string testType, string testResult, string remarks)
        {
            ReportIDLabelR.Text = reportID;
            label8.Text = patientID;
            label7.Text = patientName;
            label6.Text = testDate;
            label5.Text = testType;
            label4.Text = testResult;
            label2.Text = remarks;
        }

        private void ReportsPage_Click(object sender, EventArgs e)
        {
            //AllReports allReportsForm = new AllReports(this, Login.doctorID);
            //allReportsForm.Show();
            //this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isProfilePanelExpanded)
            {
                ProfilePanel.Width -= animationStep;
                ProfilePanel.Left += animationStep;
                if (ProfilePanel.Width <= 0)
                {
                    ProfilePanel.Width = 0;
                    ProfilePanel.Left = this.ClientSize.Width;
                    isProfilePanelExpanded = false;
                    timer1.Stop();
                }
            }
            else
            {
                ProfilePanel.Width += animationStep;
                ProfilePanel.Left -= animationStep;
                if (ProfilePanel.Width >= targetWidth)
                {
                    ProfilePanel.Width = targetWidth;
                    ProfilePanel.Left = this.ClientSize.Width - targetWidth;
                    isProfilePanelExpanded = true;
                    timer1.Stop();
                }
            }
        }

        private void ProfilePanelExtender_Click(object sender, EventArgs e) => timer1.Start();

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string keyword = SearchTextBox.Text.Trim();
            try
            {
                string query = @"
SELECT a.AppointmentID, p.PatientName, p.PatientContact, a.AppointmentDate, a.AppointmentSlot
FROM Appointment a
JOIN Patient p ON a.PatientID = p.PatientID
JOIN Doctor d ON a.DoctorID = d.DoctorID
WHERE d.DoctorUsername = @DoctorUsername
AND (
    CAST(a.AppointmentID AS NVARCHAR) LIKE @keyword
    OR p.PatientName LIKE @keyword
    OR p.PatientContact LIKE @keyword
)
ORDER BY a.AppointmentDate, a.AppointmentSlot";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@DoctorUsername", Login.username);
                da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);
                AppointmentDataGridView.DataSource = dt.Rows.Count > 0 ? dt : new DataTable { Columns = { "Message" } };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading appointments: " + ex.Message);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SearchTextBox.Clear();
            AppointmentDataGridView.DataSource = new DataTable();
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"
SELECT a.AppointmentID, p.PatientName, p.PatientContact, a.AppointmentDate, a.AppointmentSlot
FROM Appointment a
INNER JOIN Patient p ON a.PatientID = p.PatientID
INNER JOIN Doctor d ON a.DoctorID = d.DoctorID
WHERE d.DoctorUsername = @DoctorUsername
ORDER BY a.AppointmentDate, a.AppointmentSlot";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.SelectCommand.Parameters.AddWithValue("@DoctorUsername", Login.username);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                AppointmentDataGridView.DataSource = dt.Rows.Count > 0 ? dt : new DataTable { Columns = { "Message" } };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading appointments: " + ex.Message);
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to Logout?", "Logout", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new Login().Show();
                this.Hide();
            }
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            //AllReports reportsForm = new AllReports(this, Login.doctorID);
            //reportsForm.Show();
            //this.Hide();
        }

        private void PrescriptionsButton_Click(object sender, EventArgs e) 
        {
            //new AllPrescriptions(this, Login.doctorID).Show();
            //this.Hide();
        }

        // ===== Empty Event Handlers to Fix Missing Errors =====
        private void label1_Click(object sender, EventArgs e) { }
        private void ProfilePanel_Paint(object sender, PaintEventArgs e) { }
        private void BloodGroupLabel_Click(object sender, EventArgs e) { }
        private void GenderLabel_Click(object sender, EventArgs e) { }
        private void AgeLabel_Click(object sender, EventArgs e) { }
        private void AvailableLabel_Click(object sender, EventArgs e) { }
        private void ContactLabel_Click(object sender, EventArgs e) { }
        private void NameLabel_Click(object sender, EventArgs e) { }
        private void IDLabel_Click(object sender, EventArgs e) { }
        private void SearchTextBox_TextChanged_1(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void ShowAllButton_Click_1(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void label2_Click_1(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void ReportIDLabelR_Click(object sender, EventArgs e) { }
        private void PrescriptionsPage_Click(object sender, EventArgs e) { }
        private void DateLabel_Click(object sender, EventArgs e) { }
        private void ClearButton_Click_1(object sender, EventArgs e) { }
        private void SearchButton_Click_1(object sender, EventArgs e) { }

        private void ProfilePanelExtenderButton_Click(object sender, EventArgs e) => timer1.Start();

        private void AppointmentDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignore header row

            try
            {
                // Get AppointmentID from clicked row
                var appointmentIDObj = AppointmentDataGridView.Rows[e.RowIndex].Cells["AppointmentID"].Value;
                if (appointmentIDObj == null) return;

                int appointmentID = Convert.ToInt32(appointmentIDObj);

                using (SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();

                    string query = @"
SELECT p.PatientID, p.PatientName, p.PatientContact
FROM Appointment a
JOIN Patient p ON a.PatientID = p.PatientID
WHERE a.AppointmentID = @AppointmentID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@AppointmentID", appointmentID);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            PatientIDTextBoxD.Text = reader["PatientID"].ToString();
                            PatientNameTextBoxD.Text = reader["PatientName"].ToString();
                            PatientContactTextBoxD.Text = reader["PatientContact"].ToString();
                        }
                    }
                }

                // Switch to ReportsPage tab
                DocDashFormTab.SelectedTab = ReportsPage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading patient details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void SaveReportButtonD_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TestTypeComboBox.Text) ||
                    string.IsNullOrWhiteSpace(ResultTextBoxR.Text) ||
                    string.IsNullOrWhiteSpace(RemarkTextBoxR.Text))
                {
                    MessageBox.Show("Please fill all report details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int patientID = 0;

                // Get PatientID reliably from PatientName and Contact stored in textboxes
                using (SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();

                    string patientQuery = @"
SELECT PatientID
FROM Patient
WHERE PatientName = @PatientName AND PatientContact = @PatientContact";

                    using (SqlCommand cmd = new SqlCommand(patientQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@PatientName", PatientNameTextBoxD.Text.Trim());
                        cmd.Parameters.AddWithValue("@PatientContact", PatientContactTextBoxD.Text.Trim());

                        object result = cmd.ExecuteScalar();

                        if (result == null || !int.TryParse(result.ToString(), out patientID))
                        {
                            MessageBox.Show("Invalid Patient ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Insert report
                    string insertQuery = @"
INSERT INTO TestReport (PatientID, DoctorID, TestDate, TestType, TestResult, Remarks)
VALUES (@PatientID, @DoctorID, @TestDate, @TestType, @TestResult, @Remarks)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@PatientID", patientID);
                        cmd.Parameters.AddWithValue("@DoctorID", Login.doctorID);
                        cmd.Parameters.AddWithValue("@TestDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@TestType", TestTypeComboBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@TestResult", ResultTextBoxR.Text.Trim());
                        cmd.Parameters.AddWithValue("@Remarks", RemarkTextBoxR.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Report saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh after saving
                ReportsPage_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void PatientIDTextBoxD_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientNameTextBoxD_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientContactTextBoxD_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrescriptionPrintPreview_Load(object sender, EventArgs e)
        {

        }

        private void PrescriptionPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            float y = 50;
            int leftMargin = 50;
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font subHeaderFont = new Font("Arial", 10, FontStyle.Bold);
            Font normalFont = new Font("Arial", 10);
            Brush brush = Brushes.Black;

            // Department Header
            e.Graphics.DrawString("DEPARTMENT OF  " + DepartmentTextbox.Text, headerFont, brush, leftMargin + 150, y);
            y += 40;

            // Patient details
            e.Graphics.DrawString("Name        : " + NameTextbox.Text, normalFont, brush, leftMargin, y);
            e.Graphics.DrawString("Hospital No : " + PatientIDTextbox.Text, normalFont, brush, leftMargin + 350, y);
            y += 20;

            e.Graphics.DrawString("Age / Sex   : " + AgeTextbox.Text + "/" + GenderTextbox.Text, normalFont, brush, leftMargin, y);
            e.Graphics.DrawString("Report ID   : " + ReportIDLabelR.Text, normalFont, brush, leftMargin + 350, y);
            e.Graphics.DrawString("Prescription ID: " + PrescriptionIDShowLabelP.Text, normalFont, brush, leftMargin + 550, y);
            y += 20;

            e.Graphics.DrawString("Doctor      : " + DoctorTextbox.Text, normalFont, brush, leftMargin, y);
            e.Graphics.DrawString("Date        :  " + DateTextbox.Text, normalFont, brush, leftMargin + 350, y);
            y += 20;

            e.Graphics.DrawString("Department  : " + DepartmentTextbox.Text, normalFont, brush, leftMargin, y);
            y += 30;

            e.Graphics.DrawLine(Pens.Black, leftMargin, y, leftMargin + 700, y);
            y += 20;

            // OUTPATIENT SUMMARY header
            e.Graphics.DrawString("OUTPATIENT SUMMARY", subHeaderFont, brush, leftMargin + 220, y);
            y += 30;

            // Medicine name and dosage
            e.Graphics.DrawString("Medicine Name : " + MedicineNameTextbox.Text, normalFont, brush, leftMargin, y);
            y += 20;
            e.Graphics.DrawString("Dosage        : " + DosageTextbox.Text, normalFont, brush, leftMargin, y);
            y += 30;

            // Custom Notes
            e.Graphics.DrawString("Consultant Notes :", subHeaderFont, brush, leftMargin, y);
            y += 20;
            e.Graphics.DrawString(NoteRichTextBox.Text, normalFont, brush, leftMargin, y);
        }


        private void PrescriptionIDShowLabelP_Click(object sender, EventArgs e)
        {

        }

        private void NameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgeTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenderTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DoctorTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DepartmentTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientIDTextbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PatientIDTextbox.Text))
                return;

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();

                    // 1. Get Patient Details
                    string patientQuery = @"
SELECT PatientName, PatientAge, Gender, Diagnosis
FROM Patient
WHERE PatientID = @PatientID";

                    using (SqlCommand cmd = new SqlCommand(patientQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@PatientID", PatientIDTextbox.Text.Trim());
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            NameTextbox.Text = reader["PatientName"].ToString();
                            AgeTextbox.Text = reader["PatientAge"].ToString();
                            GenderTextbox.Text = reader["Gender"].ToString();
                            DiagnosisTextbox.Text = reader["Diagnosis"].ToString();
                        }
                        reader.Close();
                    }

                    // 2. Get Latest Test Report
                    string testReportQuery = @"
SELECT TOP 1 TestType, TestResult, TestDate, Remarks
FROM TestReport
WHERE PatientID = @PatientID
ORDER BY TestDate DESC";

                    using (SqlCommand cmd = new SqlCommand(testReportQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@PatientID", PatientIDTextbox.Text.Trim());
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            TestTypeTextbox.Text = reader["TestType"].ToString();
                            TestResultTextbox.Text = reader["TestResult"].ToString();
                            TestDateTextbox.Text = Convert.ToDateTime(reader["TestDate"]).ToString("dd/MM/yyyy hh:mm tt");
                            RemarkTextbox.Text = reader["Remarks"].ToString();
                        }
                        reader.Close();
                    }

                    // 3. Get Doctor Info
                    string doctorQuery = @"
SELECT DoctorName, Department
FROM Doctor
WHERE DoctorID = @DoctorID";

                    using (SqlCommand cmd = new SqlCommand(doctorQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@DoctorID", Login.doctorID);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            DoctorTextbox.Text = reader["DoctorName"].ToString();
                            DepartmentTextbox.Text = reader["Department"].ToString();
                        }
                        reader.Close();
                    }

                    // 4. Generate Prescription ID
                    string idQuery = "SELECT ISNULL(MAX(PrescriptionID), 0) + 1 FROM Prescription";
                    using (SqlCommand cmd = new SqlCommand(idQuery, con))
                    {
                        object result = cmd.ExecuteScalar();
                        PrescriptionIDShowLabelP.Text = result.ToString();
                    }

                    // 5. Set Current Date/Time
                    DateTextbox.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error autofilling details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TestTypeTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TestResultTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TestDateTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RemarkTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(PatientIDTextbox.Text) ||
                    string.IsNullOrWhiteSpace(MedicineNameTextbox.Text) ||
                    string.IsNullOrWhiteSpace(DosageTextbox.Text))
                {
                    MessageBox.Show("Please fill all required prescription details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();

                    string insertQuery = @"
INSERT INTO Prescription (PatientID, DoctorID, PrescriptionDate, MedicineName, Dosage, Notes)
VALUES (@PatientID, @DoctorID, @PrescriptionDate, @MedicineName, @Dosage, @Notes)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@PatientID", PatientIDTextbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@DoctorID", Login.doctorID);
                        cmd.Parameters.AddWithValue("@PrescriptionDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@MedicineName", MedicineNameTextbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@Dosage", DosageTextbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@Notes", NoteRichTextBox.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Prescription saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Now show the print preview
                PrescriptionPrintPreview.Document = PrescriptionPrint;
                PrescriptionPrintPreview.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving prescription: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void MedicineNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DosageTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NoteRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProfilePanelTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}
