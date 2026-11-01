using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MagicBus
{
    public partial class TourNavigation : Form
    {
        public TourNavigation()
        {
            InitializeComponent();
            btnNavigate.Click += btnNavigate_Click;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstDestinations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDestinations.Items.Clear();

            string[] destinations = cmbCategory.SelectedIndex switch
            {
                0 => new[]
                {
                    "Λευκός Πύργος",
                    "Πλατεία Αριστοτέλους",
                    "Άγιος Δημήτριος",
                    "Ροτόντα",
                    "Καμάρα"
                },

                1 => new[]
                {
                    "Παλάτι",
                    "Φουλ του Μεζέ"
                },

                2 => new[]
                {
                    "Λευκός Πύργος",
                    "Πλατεία Αριστοτέλους",
                    "Πλατεία Ελευθερίας",
                    "Άγιος Δημήτριος",
                    "Ροτόντα",
                    "Καμάρα"
                },

                _ => Array.Empty<string>()
            };

            lstDestinations.Items.AddRange(destinations);
        }

        private void cmbStart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNavigate_Click(object sender, EventArgs e)
        {
            if (cmbStart.SelectedItem == null ||
                lstDestinations.SelectedItem == null)
            {
                MessageBox.Show("Επιλέξτε αφετηρία και προορισμό.");
                return;
            }

            string start = cmbStart.SelectedItem.ToString()!;
            string destination = lstDestinations.SelectedItem.ToString()!;

            if (cmbCategory.SelectedIndex == 1)
            {
                destination = destination switch
                {
                    "Παλάτι" => "Παλάτι, Πλατεία Μοριχόβου 3",
                    "Φουλ του Μεζέ" => "Φουλ του Μεζέ, Κατούνη 3",
                    _ => destination
                };
            }

            if (start == destination)
            {
                MessageBox.Show("Η αφετηρία και ο προορισμός είναι το ίδιο σημείο.");
                return;
            }

            string origin = Uri.EscapeDataString(start + ", Θεσσαλονίκη, Ελλάδα");
            string target = Uri.EscapeDataString(destination + ", Θεσσαλονίκη, Ελλάδα");

            string url = "https://www.google.com/maps/dir/?api=1"
                + "&origin=" + origin
                + "&destination=" + target
                + "&travelmode=walking";

            try
            {
                System.Diagnostics.Process.Start(
                    new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true
                    });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Δεν ήταν δυνατό να ανοίξει ο χάρτης: " + ex.Message);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Οδηγίες — Τουριστική Πλοήγηση:\n\n" +
                "1. Επιλέξτε κατηγορία προορισμού από την αναπτυσσόμενη λίστα.\n" +
                "2. Επιλέξτε τον επιθυμητό προορισμό από τη λίστα.\n" +
                "3. Επιλέξτε στάση εκκίνησης.\n" +
                "4. Πατήστε 'Έναρξη πλοήγησης' για να ανοίξει ο χάρτης.",
                "On-line Help — Πλοήγηση",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}