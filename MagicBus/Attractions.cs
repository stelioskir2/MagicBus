using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MagicBus
{
    public partial class Attractions : Form
    {
        public Attractions()
        {
            InitializeComponent();
        }

        private void Attractions_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstAttractions.SelectedItem == null)
            {
                MessageBox.Show(
                    "Επιλέξτε πρώτα ένα αξιοθέατο από τη λίστα.",
                    "Επιλογή αξιοθέατου",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            string attraction = lstAttractions.SelectedItem.ToString()!;

            using AttractionDetails details = new AttractionDetails(attraction);
            details.ShowDialog(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Οδηγίες — Αξιοθέατα:\n\n" +
                "1. Επιλέξτε ένα αξιοθέατο από τη λίστα στα αριστερά.\n" +
                "2. Πατήστε 'Πληροφορίες αξιοθέατου' για να δείτε λεπτομέρειες και να ακούσετε την περιγραφή του.\n" +
                "3. Πατήστε 'Επιστροφή στο μενού' για να γυρίσετε στην αρχική οθόνη.",
                "On-line Help — Αξιοθέατα",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}