using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class AllReports : Form
    {
        private int doctorID;
        private DoctorDashboard dashboard;

        SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");

        public AllReports(DoctorDashboard dashboard, int doctorID)
        {
            InitializeComponent();
            this.dashboard = dashboard;
            this.doctorID = doctorID;

            ReportDataGridView.CellDoubleClick += ReportDataGridView_CellDoubleClick;
        }

        private void AllReports_Load(object sender, EventArgs e)
        {
            LoadReports();
        }

        private void LoadReports()
        {
            try
            {
                string query = @"
SELECT r.ReportID, r.PatientID, p.PatientName, r.TestDate, r.TestType, r.TestResult, r.Remarks
FROM TestReport r
INNER JOIN Patient p ON r.PatientID = p.PatientID
WHERE r.DoctorID = @DoctorID";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@DoctorID", doctorID);

                DataTable dt = new DataTable();
                da.Fill(dt);

                ReportDataGridView.DataSource = dt;

                // DEBUG: Check column names
                foreach (DataColumn col in dt.Columns)
                {
                    Console.WriteLine(col.ColumnName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reports: " + ex.Message);
            }
        }

        private void ReportDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = ReportDataGridView.Rows[e.RowIndex];

                    dashboard.SetReportDetails(
                        row.Cells["ReportID"]?.Value?.ToString() ?? "",
                        row.Cells["PatientID"]?.Value?.ToString() ?? "",
                        row.Cells["PatientName"]?.Value?.ToString() ?? "",
                        row.Cells["TestDate"]?.Value?.ToString() ?? "",
                        row.Cells["TestType"]?.Value?.ToString() ?? "",
                        row.Cells["TestResult"]?.Value?.ToString() ?? "",
                        row.Cells["Remarks"]?.Value?.ToString() ?? ""
                    );

                    this.Hide(); // hide instead of closing
                    dashboard.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
