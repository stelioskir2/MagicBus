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
    public partial class WeatherAndRoof : Form
    {
        public WeatherAndRoof()
        {
            InitializeComponent();

            cmbWeather.Items.Clear();
            cmbWeather.Items.AddRange(new object[]
            {
                "Ηλιοφάνεια",
                "Συννεφιά",
                "Βροχή"
            });

            cmbWeather.SelectedItem = BusWeatherData.Condition;

            cmbWeather.SelectedIndexChanged +=
                cmbWeather_SelectedIndexChanged;
        }

        private void WeatherAndRoof_Load(object sender, EventArgs e)
        {
            UpdateWeatherDisplay();
        }

        private void UpdateWeatherDisplay()
        {
            lblWeatherInfo.Text =
                $"Εξωτερική Θερμοκρασία: {BusWeatherData.Temperature}°C";

            lblFeelsLike.Text =
                $"Αίσθηση Θερμοκρασίας: {BusWeatherData.Temperature + 2}°C";

            lblHumidity.Text = BusWeatherData.IsRaining
                ? "Υγρασία: 85%"
                : "Υγρασία: 45%";

            lblVisibility.Text = BusWeatherData.IsRaining
                ? "Ορατότητα: Μειωμένη"
                : "Ορατότητα: Καλή";

            lblSunSet.Text = "Ώρα Δύσης Ηλίου: 20:30";

            UpdateRoofDisplay();
        }

        private void UpdateRoofDisplay()
        {
            lblRoofStatus.Text = BusWeatherData.RoofOpen
                ? "Κατάσταση Οροφής: Ανοιχτή"
                : "Κατάσταση Οροφής: Κλειστή";

            lblRoofStatus.ForeColor = BusWeatherData.RoofOpen
                ? Color.ForestGreen
                : Color.Firebrick;
        }

        private void cmbWeather_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            if (cmbWeather.SelectedItem == null)
            {
                return;
            }

            BusWeatherData.Condition =
                cmbWeather.SelectedItem.ToString()!;

            if (BusWeatherData.IsRaining)
            {
                BusWeatherData.RoofOpen = false;
            }
            else if (BusWeatherData.Condition == "Ηλιοφάνεια")
            {
                BusWeatherData.RoofOpen = true;
            }

            UpdateWeatherDisplay();
        }

        private void btnRoofOpen_Click(object sender, EventArgs e)
        {
            if (BusWeatherData.IsRaining)
            {
                MessageBox.Show(
                    this,
                    "Βρέχει. Η οροφή πρέπει να παραμείνει κλειστή.",
                    "Προστασία από βροχή",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            BusWeatherData.RoofOpen = true;
            UpdateRoofDisplay();
        }

        private void btnRoofClose_Click(object sender, EventArgs e)
        {
            BusWeatherData.RoofOpen = false;
            UpdateRoofDisplay();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DriverDashboard driverDashboard = new DriverDashboard();
            driverDashboard.Show();
            this.Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}