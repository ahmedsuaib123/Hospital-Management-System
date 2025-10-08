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
    public partial class Login : Form
    {
        public static string username;
        public static string adminID;
        public static string patientID;
        public static string doctorID;
        public static string nurseID;
        public static string fullName;
        public static string adminEmail;
        public static string age;
        public static string gender;
        public static string bloodGroup;
        public static string contact;
        public static string role;
        public static string department;
        public static string qualification;
        public static string availableSlot;

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HOP36BN\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");

        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string insert_query = "select * from Login where Username = '" + UsernameTextBox.Text + "' and Password = '" + PasswordTextBox.Text + "'";

            SqlDataAdapter sda = new SqlDataAdapter(insert_query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                if (dt.Rows[0]["Status"].ToString() == "1")
                {
                    username = dt.Rows[0]["Username"].ToString();
                    role = dt.Rows[0][3].ToString();
                    if (role == "Admin")
                    {
                        string admin_query = "select * from Admin where Username = '" + UsernameTextBox.Text + "'";

                        SqlDataAdapter admin_sda = new SqlDataAdapter(admin_query, con);

                        DataTable admin_dt = new DataTable();

                        admin_sda.Fill(admin_dt);

                        if (admin_dt.Rows.Count > 0)
                        {
                            adminID = admin_dt.Rows[0]["AdminID"].ToString();
                            fullName = admin_dt.Rows[0]["AdminName"].ToString();
                            adminEmail = admin_dt.Rows[0]["AdminEmail"].ToString();
                            contact = admin_dt.Rows[0]["AdminContact"].ToString();

                            AdminDashboard ad = new AdminDashboard();
                            ad.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Admin record not found.");
                        }
                    }
                    else if (role == "Patient")
                    {
                        string pat_query = "select * from Patient where PatientUsername = '" + UsernameTextBox.Text + "'";

                        SqlDataAdapter pat_sda = new SqlDataAdapter(pat_query, con);

                        DataTable pat_dt = new DataTable();

                        pat_sda.Fill(pat_dt);

                        if (pat_dt.Rows.Count > 0)
                        {
                            patientID = pat_dt.Rows[0]["PatientID"].ToString();
                            fullName = pat_dt.Rows[0]["PatientName"].ToString();
                            age = pat_dt.Rows[0]["PatientAge"].ToString();
                            gender = pat_dt.Rows[0]["PatientGender"].ToString();
                            bloodGroup = pat_dt.Rows[0]["PatientBloodGroup"].ToString();
                            contact = pat_dt.Rows[0]["PatientContact"].ToString();

                            new PatientDashboard().Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Patient record not found.");
                        }
                    }
                    else if (role == "Doctor")
                    {
                        string doc_query = "select * from Doctor where DoctorUsername = '" + UsernameTextBox.Text + "'";

                        SqlDataAdapter doc_sda = new SqlDataAdapter(doc_query, con);

                        DataTable doc_dt = new DataTable();

                        doc_sda.Fill(doc_dt);

                        if (doc_dt.Rows.Count > 0)
                        {
                            doctorID = Convert.ToInt32(doc_dt.Rows[0]["DoctorID"]).ToString();
                            fullName = doc_dt.Rows[0]["DoctorName"].ToString();
                            contact = doc_dt.Rows[0]["DoctorContact"].ToString();
                            age = Convert.ToInt32(doc_dt.Rows[0]["DoctorAge"]).ToString();
                            gender = doc_dt.Rows[0]["Gender"].ToString();
                            bloodGroup = doc_dt.Rows[0]["BloodGroup"].ToString();
                            availableSlot = doc_dt.Rows[0]["AvailableSlot"].ToString();

                            new DoctorDashboard().Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Doctor record not found.");
                        }
                    }
                    else if (role == "Nurse")
                    {
                        string nurse_query = "select * from Nurse where NurseUsername = '" + UsernameTextBox.Text + "'";

                        SqlDataAdapter nurse_sda = new SqlDataAdapter(nurse_query, con);

                        DataTable nur_dt = new DataTable();

                        nurse_sda.Fill(nur_dt);

                        if (nur_dt.Rows.Count > 0)
                        {
                            nurseID = nur_dt.Rows[0]["NurseID"].ToString();
                            fullName = nur_dt.Rows[0]["NurseName"].ToString();
                            age = nur_dt.Rows[0]["NurseAge"].ToString();
                            contact = nur_dt.Rows[0]["NurseContact"].ToString();

                            new NurseDashboard().Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Nurse record not found.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Your account is blocked. Please contact with Admin.");
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ForgetPasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ForgetPassword().Show();
            this.Hide();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            new Signup().Show();
            this.Hide();
        }
    }

}
