using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class NurseDutySchedule : Form
    {
        public NurseDutySchedule()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new NurseManagement().Show();
            this.Hide();
        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void NurseDutySchedule_Load(object sender, EventArgs e)
        {
            string query = "Select NurseID,NurseName from Nurse";

        }
    }
}
