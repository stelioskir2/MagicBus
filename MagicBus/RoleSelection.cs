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
            // Ανοίγει την οθόνη του επιβάτη (του Ατόμου 1)
            PassengerHome passengerForm = new PassengerHome();
            passengerForm.Show();
            this.Hide();
        }

        private void btnDriver_Click(object sender, EventArgs e)
        {
            // Ανοίγει τον πίνακα ελέγχου του οδηγού (Άτομο 3)
            DriverDashboard driverForm = new DriverDashboard();
            driverForm.Show();
            this.Hide();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            // Ανοίγει τον πίνακα ελέγχου του υπαλλήλου (Άτομο 3)
            EmployeeDashboard employeeForm = new EmployeeDashboard();
            employeeForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}