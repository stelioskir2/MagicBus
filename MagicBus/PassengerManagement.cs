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
    public partial class PassengerManagement : Form
    {
        private DataTable passengerTable;
        private int availableSeats = 12;
        private int totalSeats = 40;

        public PassengerManagement()
        {
            InitializeComponent();
        }

        private void PassengerManagement_Load(object sender, EventArgs e)
        {
            LoadPassengerData();
            UpdateSeatsDisplay();
        }

        // Φόρτωση συνδυασμού ελληνικών και διεθνών δεδομένων επιβατών
        private void LoadPassengerData()
        {
            passengerTable = new DataTable();
            passengerTable.Columns.Add("Κωδικός Εισιτηρίου", typeof(string));
            passengerTable.Columns.Add("Ονοματεπώνυμο", typeof(string));
            passengerTable.Columns.Add("Τηλέφωνο", typeof(string));
            passengerTable.Columns.Add("Θέση", typeof(string));

            // Ελληνικά και Διεθνή ονόματα & νούμερα
            passengerTable.Rows.Add("TKT-101", "Νικόλαος Παπαδόπουλος", "+30 6941234567", "12A");
            passengerTable.Rows.Add("TKT-102", "John Smith", "+1 555-0192", "14B");
            passengerTable.Rows.Add("TKT-103", "Marie Dupont", "+33 6 12 34 56 78", "05C");
            passengerTable.Rows.Add("TKT-104", "Hans Weber", "+49 151 23456789", "22A");
            passengerTable.Rows.Add("TKT-105", "Ελένη Κωνσταντίνου", "+30 6939988776", "08F");
            passengerTable.Rows.Add("TKT-106", "Li Wei", "+86 138 0013 8000", "03D");
            passengerTable.Rows.Add("TKT-107", "Sarah Connor", "+44 7700 900077", "19E");

            dgvPassengers.DataSource = passengerTable;
        }

        // Ενημέρωση ετικέτας διαθεσιμότητας θέσεων
        private void UpdateSeatsDisplay()
        {
            int bookedSeats = passengerTable.Rows.Count;
            availableSeats = totalSeats - bookedSeats;
            lblSeatsAvailable.Text = $"Ελεύθερες Θέσεις: {availableSeats} / {totalSeats} (Κρατημένες: {bookedSeats})";
        }

        // Λειτουργία ακύρωσης εισιτηρίου με βάση τον κωδικό
        private void btnCancelTicket_Click(object sender, EventArgs e)
        {
            string codeToCancel = txtTicketCode.Text.Trim();

            if (string.IsNullOrEmpty(codeToCancel))
            {
                lblCancelStatus.ForeColor = Color.Firebrick;
                lblCancelStatus.Text = "Παρακαλώ εισάγετε κωδικό!";
                return;
            }

            DataRow rowToRemove = null;
            foreach (DataRow row in passengerTable.Rows)
            {
                if (row["Κωδικός Εισιτηρίου"].ToString().Equals(codeToCancel, StringComparison.OrdinalIgnoreCase))
                {
                    rowToRemove = row;
                    break;
                }
            }

            if (rowToRemove != null)
            {
                passengerTable.Rows.Remove(rowToRemove);
                UpdateSeatsDisplay();
                lblCancelStatus.ForeColor = Color.ForestGreen;
                lblCancelStatus.Text = $"Το εισιτήριο {codeToCancel} ακυρώθηκε!";
                txtTicketCode.Clear();
            }
            else
            {
                lblCancelStatus.ForeColor = Color.Firebrick;
                lblCancelStatus.Text = "Ο κωδικός δεν βρέθηκε!";
            }
        }

        // Επιστροφή στον Πίνακα Ελέγχου Προσωπικού
        private void btnBack_Click(object sender, EventArgs e)
        {
            EmployeeDashboard staffDashboard = new EmployeeDashboard();
            staffDashboard.Show();
            this.Close();
        }
    }
}