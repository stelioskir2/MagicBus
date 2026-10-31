using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MagicBus
{
    public partial class CafeSelection : Form
    {
        public CafeSelection()
        {
            InitializeComponent();
        }

        private void lstCafes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCafes.SelectedItem == null)
            {
                return;
            }

            string cafe = lstCafes.SelectedItem.ToString()!;

            lblCafeInfo.Text = cafe switch
            {
                "Καφέ Λευκός Πύργος" =>
                    "Καφές, ροφήματα και γλυκά δίπλα στην παραλία.\n"
                    + "Παραδίδει στις στάσεις: Λευκός Πύργος, Πλατεία Αριστοτέλους.",

                "Αριστοτέλους Coffee" =>
                    "Specialty καφές και φρέσκοι χυμοί.\n"
                    + "Παραδίδει στις στάσεις: Πλατεία Αριστοτέλους, Πλατεία Ελευθερίας.",

                "Bougatsa Ροτόντα" =>
                    "Παραδοσιακή μπουγάτσα, τυρόπιτες και καφές.\n"
                    + "Παραδίδει στις στάσεις: Ροτόντα, Καμάρα, Άγιος Δημήτριος.",

                _ => "Δεν υπάρχουν διαθέσιμες πληροφορίες."
            };
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (lstCafes.SelectedItem == null)
            {
                MessageBox.Show(
                    "Επιλέξτε πρώτα μια καφετέρια από τη λίστα.",
                    "Επιλογή καφετέριας",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            string cafe = lstCafes.SelectedItem.ToString()!;

            using CafeMenu menu = new CafeMenu(cafe);
            if (menu.ShowDialog(this) == DialogResult.OK)
            {
                Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
