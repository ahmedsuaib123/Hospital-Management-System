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
    public partial class CheckAccountStatus : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HOP36BN\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");
        public CheckAccountStatus()
        {
            InitializeComponent();
        }

        private void CheckAccountStatus_Load(object sender, EventArgs e)
        {
            string query = "Select Username,Role,Status from Login";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            AccountStatusDataGridView.DataSource = dt;

            AccountStatusDataGridView.Columns["Username"].HeaderText = "Username";

            AccountStatusDataGridView.Columns["Role"].HeaderText = "Role";

            AccountStatusDataGridView.Columns["Status"].HeaderText = "Account Status";
        }
    }
}
