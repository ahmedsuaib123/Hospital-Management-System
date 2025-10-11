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
    public partial class NurseManagement : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");
        public NurseManagement()
        {
            InitializeComponent();
        }

        private void NurseManagement_Load(object sender, EventArgs e)
        {
            string query = "SELECT NurseID,NurseName,NurseAge,Gender,NurseContact,NurseUsername FROM Nurse";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            NurseDataGridView.DataSource = dt;

            NurseDataGridView.Columns["NurseID"].HeaderText = "ID";

            NurseDataGridView.Columns["NurseName"].HeaderText = "Full Name";

            NurseDataGridView.Columns["NurseAge"].HeaderText = "Age";

            NurseDataGridView.Columns["NurseContact"].HeaderText = "Contact";

            NurseDataGridView.Columns["NurseUsername"].HeaderText = "Username";


        }

        private void DutyScheduleButton_Click(object sender, EventArgs e)
        {
            new NurseDutySchedule().Show();
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            new AddNurse().Show();
            this.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
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
            if (selectedCategory == "Nurse ID")
            {
                query = "SELECT * FROM Nurse WHERE NurseID LIKE @keyword";
            }
            else if (selectedCategory == "Nurse Name")
            {
                query = "SELECT * FROM Nurse WHERE NurseName LIKE @keyword";
            }
            else if (selectedCategory == "Nurse Contact")
            {
                query = "SELECT * FROM Nurse WHERE NurseContact LIKE @keyword";
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

            // Display the results
            if (dt.Rows.Cast<DataRow>().Any())
            {
                NurseDataGridView.DataSource = dt;
            }
            else
            {
                DataTable emptyTable = new DataTable();
                emptyTable.Columns.Add("Message");
                emptyTable.Rows.Add("No match found");
                NurseDataGridView.DataSource = emptyTable;
            }
        }
    }
}
