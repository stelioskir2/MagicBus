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
    public partial class BusStatus : Form
    {
        public BusStatus()
        {
            InitializeComponent();
        }

        private void BusStatus_Load(object sender, EventArgs e)
        {
            GenerateRandomBusStatus();
        }

        // Τυχαία παραγωγή δεδομένων κατάστασης λεωφορείου
        private void GenerateRandomBusStatus()
        {
            Random rand = new Random();

            // 1. Επίπεδο μπαταρίας από 20% έως 100%
            int battery = rand.Next(20, 101);
            lblBatteryVal.Text = $"{battery}%";

            // 2. Ηλιοφάνεια πάνελ σε ποσοστό (%) από 10% έως 100%
            int solar = rand.Next(10, 101);
            lblSolarVal.Text = $"{solar}%";

            // 3. Βαθμός ρύπανσης φωτοβολταϊκών (με Χαμηλή / Μέτρια / Υψηλή)
            string[] dustLevels = { "Χαμηλή (4%)", "Μέτρια (18%)", "Υψηλή (35% - Απαιτείται καθαρισμός)" };
            lblDustVal.Text = dustLevels[rand.Next(dustLevels.Length)];

            // 4. Ημερομηνία επόμενου ελέγχου (τυχαίες επόμενες μέρες)
            DateTime nextCheck = DateTime.Now.AddDays(rand.Next(1, 31));
            lblCheckDateVal.Text = nextCheck.ToString("dd/MM/yyyy");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GenerateRandomBusStatus();
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