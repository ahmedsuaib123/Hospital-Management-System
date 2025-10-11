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
    public partial class PatientManagement : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");

        public PatientManagement()
        {
            InitializeComponent();
        }

        private void PatientManagement_Load(object sender, EventArgs e)
        {
            string query = "SELECT PatientID,PatientName,PatientAge,Gender,PatientContact,BloodGroup,PatientAddress,PatientUsername FROM Patient";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            PatientDataGridView.DataSource = dt;

            PatientDataGridView.Columns["PatientID"].HeaderText = "Patient ID";

            PatientDataGridView.Columns["PatientName"].HeaderText = "Full Name";

            PatientDataGridView.Columns["PatientAge"].HeaderText = "Age";

            PatientDataGridView.Columns["PatientContact"].HeaderText = "Contact";

            PatientDataGridView.Columns["BloodGroup"].HeaderText = "Blood Group";

            PatientDataGridView.Columns["PatientAddress"].HeaderText = "Address";

            PatientDataGridView.Columns["PatientUsername"].HeaderText = "Username";

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            new AddPatient().Show();
            this.Hide();
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
            if (selectedCategory == "Patient ID")
            {
                query = "SELECT * FROM Patient WHERE PatientID LIKE @keyword";
            }
            else if (selectedCategory == "Patient Name")
            {
                query = "SELECT * FROM Patient WHERE PatientName LIKE @keyword";
            }
            else if (selectedCategory == "Patient Contact")
            {
                query = "SELECT * FROM Patient WHERE PatientContact LIKE @keyword";
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

            // Show results
            if (dt.Rows.Cast<DataRow>().Any())
            {
                PatientDataGridView.DataSource = dt;
            }
            else
            {
                DataTable emptyTable = new DataTable();
                emptyTable.Columns.Add("Message");
                emptyTable.Rows.Add("No match found");
                PatientDataGridView.DataSource = emptyTable;
            }
        }
    }
}
