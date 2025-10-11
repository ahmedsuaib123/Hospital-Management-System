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
using System.Windows.Forms.VisualStyles;


namespace Hospital_Management_System
{
    public partial class CheckAccountStatus : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HOP36BN\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");

        public CheckAccountStatus()
        {
            InitializeComponent();
        }

        private void CheckAccountStatus_Load(object sender, EventArgs e)
        {
            // Initialize combobox
            StatusCombobox.Items.Clear();
            StatusCombobox.Items.Add("0");
            StatusCombobox.Items.Add("1");
            StatusCombobox.DropDownStyle = ComboBoxStyle.DropDownList;

            LoadAccountData();

            // Ensure both click events behave the same way
            AccountStatusDataGridView.CellClick += AccountStatusDataGridView_CellContentClick;
        }

        private void LoadAccountData()
        {
            try
            {
                string query = "SELECT Username, Role, Status FROM Login";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                AccountStatusDataGridView.DataSource = dt;
                AccountStatusDataGridView.ReadOnly = true;
                AccountStatusDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                AccountStatusDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                // Rename headers
                AccountStatusDataGridView.Columns["Username"].HeaderText = "Username";
                AccountStatusDataGridView.Columns["Role"].HeaderText = "Role";
                AccountStatusDataGridView.Columns["Status"].HeaderText = "Account Status";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Hide();
        }

        private void AccountStatusDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ignore clicks on the header
            if (e.RowIndex < 0) return;

            DataGridViewRow row = AccountStatusDataGridView.Rows[e.RowIndex];

            UsernameTextBox.Text = row.Cells["Username"].Value?.ToString() ?? "";
            RoleTextBox.Text = row.Cells["Role"].Value?.ToString() ?? "";

            // handle bit/int/string Status values
            string statusVal = row.Cells["Status"].Value?.ToString()?.Trim() ?? "";

            if (statusVal.Equals("True", StringComparison.OrdinalIgnoreCase))
                statusVal = "1";
            else if (statusVal.Equals("False", StringComparison.OrdinalIgnoreCase))
                statusVal = "0";

            if (StatusCombobox.Items.Contains(statusVal))
                StatusCombobox.SelectedItem = statusVal;
            else
                StatusCombobox.SelectedIndex = -1;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "")
            {
                MessageBox.Show("Please select a user first!");
                return;
            }

            if (StatusCombobox.SelectedItem == null)
            {
                MessageBox.Show("Please select a status");
                return;
            }

            // Validate status
            if (!int.TryParse(StatusCombobox.SelectedItem.ToString(), out int statusInt))
            {
                MessageBox.Show("Invalid status value. Only 0 or 1 allowed.");
                return;
            }

            try
            {
                con.Open();
                string updateQuery = "UPDATE Login SET Status = @status WHERE Username = @username";
                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.Add("@status", SqlDbType.Int).Value = statusInt;
                    cmd.Parameters.AddWithValue("@username", UsernameTextBox.Text);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Account status updated successfully!");
                    else
                        MessageBox.Show("Update failed: username not found.");
                }

                // Refresh grid
                LoadAccountData();

                // Clear selection
                UsernameTextBox.Clear();
                RoleTextBox.Clear();
                StatusCombobox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating status: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
