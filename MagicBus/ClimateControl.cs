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
    public partial class ClimateControl : Form
    {
        // Αρχική θερμοκρασία καμπίνας
        private int currentTemperature = 22;

        public ClimateControl()
        {
            InitializeComponent();
            UpdateTemperatureDisplay();
        }

        private void ClimateControl_Load(object sender, EventArgs e)
        {

        }

        // Κουμπί Αύξησης Θερμοκρασίας (+)
        private void btnTempUp_Click(object sender, EventArgs e)
        {
            if (currentTemperature < 30) // Όριο ασφαλείας έως 30°C
            {
                currentTemperature++;
                UpdateTemperatureDisplay();
            }
        }

        // Κουμπί Μείωσης Θερμοκρασίας (-)
        private void btnTempDown_Click(object sender, EventArgs e)
        {
            if (currentTemperature > 16) // Όριο ασφαλείας κάτω έως 16°C
            {
                currentTemperature--;
                UpdateTemperatureDisplay();
            }
        }

        // Συνάρτηση ενημέρωσης του Label στην οθόνη
        private void UpdateTemperatureDisplay()
        {
            lblTemperature.Text = currentTemperature.ToString() + "°C";
        }

        // Ενεργοποίηση A/C
        private void btnAcOn_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Κατάσταση: Ενεργό (ON)";
            lblStatus.ForeColor = Color.ForestGreen;
        }

        // Απενεργοποίηση A/C
        private void btnAcOff_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Κατάσταση: Ανενεργό (OFF)";
            lblStatus.ForeColor = Color.Firebrick;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Επιστροφή στον Πίνακα Ελέγχου Οδηγού
            DriverDashboard driverDashboard = new DriverDashboard();
            driverDashboard.Show();
            this.Close();
        }
    }
}