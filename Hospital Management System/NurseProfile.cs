using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class NurseProfile : Form
    {
        private int nurseId;
        private string loggedInUsername;
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");

        public NurseProfile(int nurseId, string username)
        {
            InitializeComponent();
            this.nurseId = nurseId;
            this.loggedInUsername = username;

            txtUsername.Text = loggedInUsername;
            txtUsername.ReadOnly = true;
        }

        private void ResetPasswordBTN_Click(object sender, EventArgs e)
        {
            lblUsername.Visible = txtUsername.Visible =
            lblOldPassword.Visible = txtOldPassword.Visible =
            lblNewPassword.Visible = txtNewPassword.Visible =
            lblConfirmPassword.Visible = txtConfirmPassword.Visible =
            btnSavePassword.Visible = btnCancelPassword.Visible =
            btnClearPassword.Visible = true;
        }

        private void btnClearPassword_Click(object sender, EventArgs e)
        {
            txtOldPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
        }

        private void btnCancelPassword_Click(object sender, EventArgs e)
        {
            lblUsername.Visible = txtUsername.Visible =
            lblOldPassword.Visible = txtOldPassword.Visible =
            lblNewPassword.Visible = txtNewPassword.Visible =
            lblConfirmPassword.Visible = txtConfirmPassword.Visible =
            btnSavePassword.Visible = btnCancelPassword.Visible =
            btnClearPassword.Visible = false;
        }

        private void txtOldPassword_TextChanged(object sender, EventArgs e)
        {
            EnablePasswordFields();
        }

        private void EnablePasswordFields()
        {
            string oldPassword = txtOldPassword.Text.Trim();
            if (string.IsNullOrEmpty(oldPassword))
            {
                txtNewPassword.ReadOnly = txtConfirmPassword.ReadOnly = true;
                return;
            }

            try
            {
                con.Open();
                string queryCheck = @"SELECT * FROM Login 
                                      WHERE Username=@Username 
                                        AND Password=@OldPassword COLLATE SQL_Latin1_General_CP1_CS_AS
                                        AND Role='Nurse'";
                SqlDataAdapter adapter = new SqlDataAdapter(queryCheck, con);
                adapter.SelectCommand.Parameters.AddWithValue("@Username", loggedInUsername);
                adapter.SelectCommand.Parameters.AddWithValue("@OldPassword", oldPassword);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                bool validOldPass = dt.Rows.Count > 0;
                txtNewPassword.ReadOnly = txtConfirmPassword.ReadOnly = !validOldPass;
                txtNewPassword.Visible = txtConfirmPassword.Visible = validOldPass;
                lblNewPassword.Visible = lblConfirmPassword.Visible = validOldPass;
                btnSavePassword.Visible = validOldPass;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            string oldPassword = txtOldPassword.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(oldPassword) ||
                string.IsNullOrEmpty(newPassword) ||
                string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password do not match.");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(newPassword, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&]).{6,}$"))
            {
                MessageBox.Show("Password must have at least one uppercase, lowercase, number, special char, and min 6 chars.");
                return;
            }

            try
            {
                con.Open();
                string queryUpdate = @"UPDATE Login 
                                       SET Password=@NewPassword
                                       WHERE Username=@Username 
                                         AND Password=@OldPassword COLLATE SQL_Latin1_General_CP1_CS_AS
                                         AND Role='Nurse'";
                SqlCommand cmdUpdate = new SqlCommand(queryUpdate, con);
                cmdUpdate.Parameters.AddWithValue("@NewPassword", newPassword);
                cmdUpdate.Parameters.AddWithValue("@Username", loggedInUsername);
                cmdUpdate.Parameters.AddWithValue("@OldPassword", oldPassword);

                int rowsAffected = cmdUpdate.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Password updated successfully!");
                    txtOldPassword.Clear();
                    txtNewPassword.Clear();
                    txtConfirmPassword.Clear();
                    txtNewPassword.ReadOnly = txtConfirmPassword.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Password update failed. Check old password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void NurseProfileBackBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            new NurseDashboard(nurseId, loggedInUsername).Show();
        }

        private void NurseProfileExitBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to close the application?", "Exit Confirmation",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void NurseProfile_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM Nurse WHERE NurseID=@NurseId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@NurseId", nurseId);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblNurseName.Text = reader["NurseName"].ToString();
                    lblNurseEmail.Text = reader["Email"].ToString();
                    lblPhone.Text = reader["NurseContact"].ToString();
                    lblAge.Text = reader["NurseAge"].ToString();
                    lblGender.Text = reader["Gender"].ToString();
                    lblBloodGroup.Text = reader["BloodGroup"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading nurse profile: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void lblNurseName_Click(object sender, EventArgs e) { }
    }
}
