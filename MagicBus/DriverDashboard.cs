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
            // Ανοίγει τη φόρμα ελέγχου κλιματισμού
            ClimateControl climateForm = new ClimateControl();
            climateForm.Show();
            this.Hide(); // Κρύβει προσωρινά το dashboard του οδηγού
        }

        private void btnWeatherRoof_Click(object sender, EventArgs e)
        {
            // Ανοίγει τη νέα φόρμα Καιρού & Οροφής
            WeatherAndRoof weatherForm = new WeatherAndRoof();
            weatherForm.Show();
            this.Hide(); // Κρύβει προσωρινά το dashboard του οδηγού
        }

        private void btnSafety_Click(object sender, EventArgs e)
        {
            using DriverSafety safety = new DriverSafety();
            safety.ShowDialog(this);
        }

        private void btnDoors_Click(object sender, EventArgs e)
        {
            using Doors doors = new Doors();
            doors.ShowDialog(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            RoleSelection roleForm = new RoleSelection();
            roleForm.Show();
            this.Close();
        }

        private void DriverDashboard_Load_1(object sender, EventArgs e)
        {

        }
    }
}