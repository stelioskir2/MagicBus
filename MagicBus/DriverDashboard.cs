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

            lblFoundItems.Left =
                (ClientSize.Width - lblFoundItems.Width) / 2;

            Activated += (_, _) =>
            {
                int count = LostItemsData.Items.Count(
                    item => item.FoundAt.Date == DateTime.Today);

                lblFoundItems.Text = count == 0
                    ? "Δεν υπάρχουν σημερινά ευρήματα."
                    : $"Σημερινά ευρήματα: {count}\n"
                      + "Από το ρομπότ καθαρισμού.";
            };
        }

        private void DriverDashboard_Load(object sender, EventArgs e)
        {
        }

        private void btnClimate_Click(object sender, EventArgs e)
        {
            using ClimateControl climateForm = new ClimateControl();
            climateForm.ShowDialog(this);
        }

        private void btnWeatherRoof_Click(object sender, EventArgs e)
        {
            using WeatherAndRoof weatherForm = new WeatherAndRoof();
            weatherForm.ShowDialog(this);
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
            Close();
        }

        private void DriverDashboard_Load_1(object sender, EventArgs e)
        {
        }
    }
}