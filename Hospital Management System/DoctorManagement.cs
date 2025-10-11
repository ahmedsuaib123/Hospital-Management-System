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
    public partial class DoctorManagement : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");

        public DoctorManagement()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Hide();
        }

        private void DoctorsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DoctorManagement_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Doctor";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            DoctorsDataGridView.DataSource = dt;

            DoctorsDataGridView.Columns["DoctorID"].HeaderText = "Doctor ID";

            DoctorsDataGridView.Columns["DoctorName"].HeaderText = "Full Name";

            DoctorsDataGridView.Columns["DoctorAge"].HeaderText = "Age";

            DoctorsDataGridView.Columns["DoctorContact"].HeaderText = "Contact";

            DoctorsDataGridView.Columns["AvailableSlot"].HeaderText = "Available Slot";

            DoctorsDataGridView.Columns["DoctorUsername"].HeaderText = "Username";

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            new AddDoctor().Show();
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
            if (selectedCategory == "Doctor ID")
            {
                query = "SELECT * FROM Doctor WHERE DoctorID LIKE @keyword";
            }
            else if (selectedCategory == "Doctor Name")
            {
                query = "SELECT * FROM Doctor WHERE DoctorName LIKE @keyword";
            }
            else if (selectedCategory == "Doctor Contact")
            {
                query = "SELECT * FROM Doctor WHERE DoctorContact LIKE @keyword";
            }
            else if (selectedCategory == "Department")
            {
                query = "SELECT * FROM Doctor WHERE Department LIKE @keyword";
            }
            else
            {
                MessageBox.Show("Invalid search category.");
                return;
            }

            // Execute the query
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);

            // Display the result
            if (dt.Rows.Cast<DataRow>().Any())
            {
                DoctorsDataGridView.DataSource = dt;
            }
            else
            {
                DataTable emptyTable = new DataTable();
                emptyTable.Columns.Add("Message");
                emptyTable.Rows.Add("No match found");
                DoctorsDataGridView.DataSource = emptyTable;
            }
        }
    }
}
