using System;
using System.Collections;
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
    public partial class AdminManagement : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");

        public AdminManagement()
        {
            InitializeComponent();
        }

        private void AdminManagement_Load(object sender, EventArgs e)
        {
            string query = "SELECT AdminID,AdminName,AdminContact,Username FROM Admin";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            AdminsDataGridView.DataSource = dt;
            AdminsDataGridView.Columns["AdminID"].HeaderText = "Admin ID";
            AdminsDataGridView.Columns["AdminName"].HeaderText = "Full Name";

            AdminsDataGridView.Columns["AdminContact"].HeaderText = "Contact";
            AdminsDataGridView.Columns["Username"].HeaderText = "Username";

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            new AddAdmin().Show();
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

            string query = "SELECT * FROM Admin WHERE AdminID LIKE @keyword OR AdminName LIKE @keyword OR AdminEmail LIKE @keyword OR AdminContact LIKE @keyword OR Username LIKE @keyword";

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Cast<DataRow>().Any())
            {
                AdminsDataGridView.DataSource = dt;
            }
            else
            {
                DataTable emptyTable = new DataTable();
                emptyTable.Columns.Add("Message");
                emptyTable.Rows.Add("No match found");
                AdminsDataGridView.DataSource = emptyTable;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Hide();
        }
    }
}
