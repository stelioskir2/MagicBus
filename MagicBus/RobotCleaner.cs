using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MagicBus
{
    public partial class RobotCleaner : Form
    {
        public RobotCleaner()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cmbFloor.SelectedItem == null)
            {
                MessageBox.Show("Επιλέξτε πρώτα όροφο καθαρισμού.");
                return;
            }

            progressCleaning.Value = 0;
            lblProgress.Text = "Πρόοδος: 0%";
            lblStatus.Text = $"Κατάσταση: Καθαρισμός — {cmbFloor.SelectedItem}";

            cmbFloor.Enabled = false;
            btnStart.Enabled = false;
            btnStop.Enabled = true;

            timerCleaning.Start();
        }

        private void timerCleaning_Tick(object sender, EventArgs e)
        {
            progressCleaning.Value = Math.Min(
    progressCleaning.Value + 5,
    progressCleaning.Maximum);

            lblProgress.Text = $"Πρόοδος: {progressCleaning.Value}%";

            if (progressCleaning.Value == 50)
            {
                string floor = cmbFloor.SelectedItem!.ToString()!;

                string itemName = cmbFloor.SelectedIndex == 0
                    ? "Διαβατήριο"
                    : "Κόσμημα";

                bool alreadyRecorded = LostItemsData.Items.Exists(
                    item => item.Name == itemName && item.Floor == floor);

                if (!alreadyRecorded)
                {
                    LostItemsData.Items.Add(new FoundItem
                    {
                        Name = itemName,
                        Floor = floor,
                        FoundAt = DateTime.Now
                    });

                    lblStatus.Text =
                        $"Κατάσταση: Καθαρισμός — εντοπίστηκε {itemName}";
                }
            }

            if (progressCleaning.Value == progressCleaning.Maximum)
            {
                timerCleaning.Stop();

                lblStatus.Text = "Κατάσταση: Ο καθαρισμός ολοκληρώθηκε";

                cmbFloor.Enabled = true;
                btnStart.Enabled = true;
                btnStop.Enabled = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            timerCleaning.Stop();
            Close();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timerCleaning.Stop();

            lblStatus.Text = "Κατάσταση: Ο καθαρισμός διακόπηκε";

            cmbFloor.Enabled = true;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }
    }
}
