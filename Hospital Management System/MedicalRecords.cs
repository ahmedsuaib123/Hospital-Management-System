using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class MedicalRecords : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");

        public MedicalRecords()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Hide();
        }

        private void MedicalRecords_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM MedicalRecords";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            MedicalRecordsDataGridView.DataSource = dt;


        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string keyword = SearchTextBox.Text;
            if (keyword.Length == 0)
            {
                MessageBox.Show("Please enter a keyword to search.");
                return;
            }

            if (SearchComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a search category.");
                return;
            }

            string selectedCategory = SearchComboBox.SelectedItem.ToString();
            string query = "";

            // Build query based on selected category
            if (selectedCategory == "Record ID")
            {
                query = "SELECT * FROM MedicalRecords WHERE RecordID LIKE @keyword";
            }
            else if (selectedCategory == "Patient ID")
            {
                query = "SELECT * FROM MedicalRecords WHERE PatientID LIKE @keyword";
            }
            else if (selectedCategory == "Doctor ID")
            {
                query = "SELECT * FROM MedicalRecords WHERE DoctorID LIKE @keyword";
            }
            else
            {
                MessageBox.Show("Invalid search category.");
                return;
            }

            // Execute query
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);

            // Display the results
            if (dt.Rows.Cast<DataRow>().Any())
            {
                MedicalRecordsDataGridView.DataSource = dt;
            }
            else
            {
                DataTable emptyTable = new DataTable();
                emptyTable.Columns.Add("Message");
                emptyTable.Rows.Add("No match found");
                MedicalRecordsDataGridView.DataSource = emptyTable;
            }
        }
    }
}
