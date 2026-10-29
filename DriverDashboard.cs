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
    public partial class DriverDashboard : Form
    {
        public DriverDashboard()
        {
            InitializeComponent();
        }

        private void DriverDashboard_Load(object sender, EventArgs e)
        {
        }

        private void btnClimate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η οθόνη κλιματισμού είναι υπό κατασκευή.", "MagicBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnWeatherRoof_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η οθόνη καιρού & οροφής είναι υπό κατασκευή.", "MagicBus", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            RoleSelection roleForm = new RoleSelection();
            roleForm.Show();
            this.Close();
        }
    }
}