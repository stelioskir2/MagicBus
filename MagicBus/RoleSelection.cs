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
    public partial class RoleSelection : Form
    {
        public RoleSelection()
        {
            InitializeComponent();
        }

        private void btnPassenger_Click(object sender, EventArgs e)
        {
            // Προσωρινό μήνυμα μέχρι να ανέβει η φόρμα του επιβάτη από την ομάδα
            MessageBox.Show("Η ενότητα του Επιβάτη αναπτύσσεται από άλλο μέλος της ομάδας.", "Υπό Κατασκευή", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnStaffLogin_Click(object sender, EventArgs e)
        {
            // Ανοίγει τη φόρμα πιστοποίησης προσωπικού (Οδηγός / Υπάλληλος)
            StaffLogin staffLoginForm = new StaffLogin();
            staffLoginForm.Show();
            this.Hide();
        }

        private void RoleSelection_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Welcome welcomeForm = new Welcome();
            welcomeForm.Show();
            this.Close();
        }

        private void btnPassenger_Click_1(object sender, EventArgs e)
        {
            using PassengerHome passengerForm = new PassengerHome();
            passengerForm.ShowDialog(this);
        }

        private void btnEmployee_Click_1(object sender, EventArgs e)
        {
            using EmployeeDashboard employeeForm = new EmployeeDashboard();
            employeeForm.ShowDialog(this);
        }
    }
}