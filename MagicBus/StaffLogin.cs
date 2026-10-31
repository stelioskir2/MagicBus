using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicBus
{
    public partial class StaffLogin : Form
    {
        public StaffLogin()
        {
            InitializeComponent();
        }

        private void StaffLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Έλεγχος αν έχουν συμπληρωθεί τα πεδία
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Παρακαλώ συμπληρώστε όνομα χρήστη και κωδικό.", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Έλεγχος για Οδηγό
            if (rbDriver.Checked)
            {
                DriverDashboard driverForm = new DriverDashboard();
                driverForm.Show();
                this.Close();
            }
            // Έλεγχος για Υπάλληλο / Προσωπικό
            else if (rbEmployee.Checked)
            {
                EmployeeDashboard employeeForm = new EmployeeDashboard();
                employeeForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Παρακαλώ επιλέξτε ιδιότητα (Οδηγός ή Υπάλληλος).", "Προσοχή", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}