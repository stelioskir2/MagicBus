using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace MagicBus
{
    public partial class DriverSafety : Form
    {
        private const int SpeedLimit = 50;
        private bool speeding = false;

        public DriverSafety()
        {
            InitializeComponent();
            lblLimit.Text = $"Όριο: {SpeedLimit} km/h";
            ShowNormal();
        }

        private void ShowAlert(string message, bool sound = true)
        {
            pnlAlert.BackColor = Color.Firebrick;
            lblAlert.Text = message;

            if (sound)
            {
                SystemSounds.Exclamation.Play();
                lstAlerts.Items.Insert(0, $"{DateTime.Now:HH:mm:ss} — {message.Replace("\n", " ")}");
            }
        }

        private void ShowNormal()
        {
            pnlAlert.BackColor = Color.SeaGreen;
            lblAlert.Text = "Όλα κανονικά\nΚαλή διαδρομή!";
        }

        private void trkSpeed_ValueChanged(object sender, EventArgs e)
        {
            lblSpeed.Text = $"{trkSpeed.Value} km/h";

            if (trkSpeed.Value > SpeedLimit && !speeding)
            {
                speeding = true;
                lblSpeed.ForeColor = Color.Firebrick;
                ShowAlert("Υπέρβαση ορίου ταχύτητας!\nΜειώστε ταχύτητα.");
            }
            else if (trkSpeed.Value <= SpeedLimit && speeding)
            {
                speeding = false;
                lblSpeed.ForeColor = Color.MidnightBlue;
                ShowNormal();
            }
        }

        private void btnLane_Click(object sender, EventArgs e)
        {
            ShowAlert("Έξοδος από τη λωρίδα!\nΕπιστρέψτε στη λωρίδα σας.");
            timerAlert.Stop();
            timerAlert.Start();
        }

        private void btnFatigue_Click(object sender, EventArgs e)
        {
            ShowAlert("Φαίνεστε κουρασμένος.\nΣκεφτείτε μήπως θέλετε καφέ ;)");
            timerAlert.Stop();
            timerAlert.Start();
        }

        private void timerAlert_Tick(object sender, EventArgs e)
        {
            timerAlert.Stop();

            if (speeding)
            {
                ShowAlert("Υπέρβαση ορίου ταχύτητας!\nΜειώστε ταχύτητα.", false);
            }
            else
            {
                ShowNormal();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
