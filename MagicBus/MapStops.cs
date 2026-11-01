using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MagicBus
{
    public partial class MapStops : Form
    {
        public MapStops()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lstStops_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstStops.SelectedItem != null)
            {
                lblStop.Text = "Επιλεγμένη στάση: "
                    + lstStops.SelectedItem.ToString();
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Οδηγίες — Χάρτης και Στάσεις:\n\n" +
                "1. Επιλέξτε μια στάση από τη λίστα στα αριστερά.\n" +
                "2. Δείτε τη θέση της στάσης στο σχηματικό διάγραμμα διαδρομής.\n" +
                "3. Πατήστε 'Επιστροφή στο μενού' για να γυρίσετε στην αρχική οθόνη.",
                "On-line Help — Στάσεις",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}