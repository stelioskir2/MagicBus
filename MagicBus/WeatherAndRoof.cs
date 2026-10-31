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
        }

        private void WeatherAndRoof_Load(object sender, EventArgs e)
        {
            GenerateRandomWeather();
        }

        // Τυχαία παραγωγή στοιχείων καιρού για ποικιλία
        private void GenerateRandomWeather()
        {
            Random rand = new Random();
            int temp = rand.Next(15, 34); // Θερμοκρασία από 15°C έως 33°C

            string[] conditions = { "Ηλιοφάνεια", "Μερική Συννεφιά", "Αίθριος", "Ελαφρύς Άνεμος" };
            string condition = conditions[rand.Next(conditions.Length)];

            lblWeatherInfo.Text = $"Εξωτερική Θερμοκρασία: {temp}°C ({condition})";
            lblSunSet.Text = "Ώρα Δύσης Ηλίου: 20:30";
        }

        // Άνοιγμα οροφής
        private void btnRoofOpen_Click(object sender, EventArgs e)
        {
            lblRoofStatus.Text = "Κατάσταση Οροφής: Ανοιχτή";
            lblRoofStatus.ForeColor = Color.ForestGreen;
        }

        // Κλείσιμο οροφής
        private void btnRoofClose_Click(object sender, EventArgs e)
        {
            lblRoofStatus.Text = "Κατάσταση Οροφής: Κλειστή";
            lblRoofStatus.ForeColor = Color.Firebrick;
        }

        // Επιστροφή στον Πίνακα Ελέγχου Οδηγού
        private void btnBack_Click(object sender, EventArgs e)
        {
            DriverDashboard driverDashboard = new DriverDashboard();
            driverDashboard.Show();
            this.Close();
        }
    }
}