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
    public partial class Doors : Form
    {
        private readonly string[] stops =
        {
            "Λευκός Πύργος", "Πλατεία Αριστοτέλους", "Πλατεία Ελευθερίας",
            "Άγιος Δημήτριος", "Ροτόντα", "Καμάρα"
        };

        private int currentStop = 0;
        private bool doorsOpen = false;
        private int passengersExiting = 0;

        public Doors()
        {
            InitializeComponent();
            ShowStop();
            UpdateDoors();
        }

        private void ShowStop()
        {
            lblStop.Text = "Στάση: " + stops[currentStop];
            lblNextStop.Text = "Επόμενη στάση: " + stops[(currentStop + 1) % stops.Length];
            lblPassengers.Text = "Επιβάτες που αποβιβάζονται: 0";
            prgExit.Value = 0;
        }

        private void UpdateDoors()
        {
            if (doorsOpen)
            {
                lblDoors.Text = "Πόρτες: ΑΝΟΙΧΤΕΣ";
                pnlDoors.BackColor = Color.DarkOrange;
            }
            else
            {
                lblDoors.Text = "Πόρτες: Κλειστές";
                pnlDoors.BackColor = Color.SeaGreen;
            }
        }

        private void ShowMessage(string message, bool warning)
        {
            lblMessage.Text = message;
            lblMessage.ForeColor = warning ? Color.Firebrick : Color.MidnightBlue;

            if (warning)
            {
                SystemSounds.Hand.Play();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (doorsOpen)
            {
                ShowMessage("Οι πόρτες είναι ήδη ανοιχτές.", false);
                return;
            }

            doorsOpen = true;
            passengersExiting = Random.Shared.Next(3, 9);
            prgExit.Maximum = passengersExiting;
            prgExit.Value = 0;
            lblPassengers.Text = $"Επιβάτες που αποβιβάζονται: {passengersExiting}";

            UpdateDoors();
            ShowMessage("Οι πόρτες άνοιξαν. Αποβίβαση επιβατών...", false);
            timerExit.Start();
        }

        private void timerExit_Tick(object sender, EventArgs e)
        {
            passengersExiting--;
            prgExit.Value = prgExit.Maximum - passengersExiting;
            lblPassengers.Text = $"Επιβάτες που αποβιβάζονται: {passengersExiting}";

            if (passengersExiting == 0)
            {
                timerExit.Stop();
                ShowMessage("Η αποβίβαση ολοκληρώθηκε. Μπορείτε να κλείσετε τις πόρτες.", false);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (!doorsOpen)
            {
                ShowMessage("Οι πόρτες είναι ήδη κλειστές.", false);
                return;
            }

            if (passengersExiting > 0)
            {
                ShowMessage("Προσοχή! Κατεβαίνουν ακόμα επιβάτες.\nΜην κλείσετε τις πόρτες.", true);
                return;
            }

            doorsOpen = false;
            UpdateDoors();
            ShowMessage("Οι πόρτες έκλεισαν. Μπορείτε να αναχωρήσετε.", false);
        }

        private void btnDepart_Click(object sender, EventArgs e)
        {
            if (doorsOpen)
            {
                ShowMessage("Δεν μπορείτε να ξεκινήσετε με ανοιχτές πόρτες!", true);
                return;
            }

            currentStop = (currentStop + 1) % stops.Length;
            ShowStop();
            ShowMessage("Καλή διαδρομή! Το λεωφορείο έφτασε στην επόμενη στάση.", false);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
