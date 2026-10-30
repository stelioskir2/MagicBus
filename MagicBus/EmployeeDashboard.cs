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
    public partial class EmployeeDashboard : Form
    {
        public EmployeeDashboard()
        {
            InitializeComponent();
        }

        private void EmployeeDashboard_Load(object sender, EventArgs e)
        {
        }

        private void btnPassengers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η διαχείριση επιβατών είναι υπό κατασκευή.", "MagicBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBusStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η κατάσταση λεωφορείου είναι υπό κατασκευή.", "MagicBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ο προγραμματισμός και οι στάσεις είναι υπό κατασκευή.", "MagicBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            RoleSelection roleForm = new RoleSelection();
            roleForm.Show();
            this.Close();
        }
    }
}