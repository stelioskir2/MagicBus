using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MagicBus
{
    public partial class PassengerHome : Form
    {
        public PassengerHome()
        {
            InitializeComponent();
            lblLostNotification.Visible = LostItemsData.Items.Exists(
                item => item.FoundAt.Date == DateTime.Today);
        }

        private void PassengerHome_Load(object sender, EventArgs e)
        {

        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            using MapStops map = new MapStops();
            map.ShowDialog(this);
        }

        private void btnAttractions_Click(object sender, EventArgs e)
        {
            using Attractions attractions = new Attractions();
            attractions.ShowDialog(this);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            using RouteView route = new RouteView();
            route.ShowDialog(this);
        }

        private void btnTour_Click(object sender, EventArgs e)
        {
            using TourNavigation tour = new TourNavigation();
            tour.ShowDialog(this);
        }

        private void btnShelter_Click(object sender, EventArgs e)
        {
            using ShelterNavigation shelter = new ShelterNavigation();
            shelter.ShowDialog(this);
        }

        private void btnLost_Click(object sender, EventArgs e)
        {
            using LostItems lostItems = new LostItems();
            lostItems.ShowDialog(this);
        }

        private void btnCafe_Click(object sender, EventArgs e)
        {
            using CafeSelection cafe = new CafeSelection();
            cafe.ShowDialog(this);
        }

        private void btnOrderTracking_Click(object sender, EventArgs e)
        {
            using OrderTracking tracking = new OrderTracking();
            tracking.ShowDialog(this);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Οδηγίες Αρχικού Μενού Επιβάτη:\n\n" +
                "• Χάρτης & στάσεις: Προβολή στάσεων της διαδρομής.\n" +
                "• Θέα διαδρομής: Ζωντανή προβολή κάμερας λεωφορείου.\n" +
                "• Αξιοθέατα & Τουριστική πλοήγηση: Πληροφορίες και καθοδήγηση GPS.\n" +
                "• Παραγγελία από καφετέρια & Η παραγγελία μου: Παραγγελία ροφημάτων με παράδοση σε επόμενη στάση.\n" +
                "• Απολεσθέντα: Ενημέρωση για αντικείμενα που βρέθηκαν στο λεωφορείο.\n" +
                "• Ασφαλή καταφύγια: Οδηγίες σε περίπτωση κακοκαιρίας.",
                "On-line Help — Μενού Επιβάτη",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}